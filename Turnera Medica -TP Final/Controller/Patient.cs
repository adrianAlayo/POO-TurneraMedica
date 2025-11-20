using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    public class Patient : User
    {   
        public int Social_work_id {  get; set; }
        public Patient(int id, int dni, string name, string lastname, int age,string email, string telnumber, string password, int id_socialwork)
            : base(id, dni, name, lastname, age ,email, telnumber, password)
        {
            Social_work_id = id_socialwork;   
        }

        //Consultar un Turno especifico por fecha
        public override void specificShift(DateTime date)
        {

        }

        //Consultar todos los turnos
        public override void Shifts()
        {
            listTurno = new List<Shift>();

            using (MySqlConnection conexionDB = Connection.conexion())
            {
                conexionDB.Open();

                string query = @"
                    SELECT 
                        s.id AS shift_id, s.shift_date, s.shift_time, s.duration, s.original_price, s.state,

                        m.id AS medic_id,
                        um.name AS medic_name, um.last_name AS medic_last_name,

                        o.id AS office_id, o.ubication AS office_location

                    FROM shifts s
                    LEFT JOIN medics m ON s.medic_id = m.id
                    LEFT JOIN users um ON um.id = m.user_id
                    LEFT JOIN offices o ON o.id = s.office_id

                    WHERE s.patient_id = @idpatient AND s.state = 'programado'
                    ORDER BY s.shift_date, s.shift_time";

                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                cmd.Parameters.AddWithValue("@idpatient", this.Id);

                using (MySqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        // MÉDICO (datos mínimos)
                        Medic doctor = new Medic(
                            Convert.ToInt32(read["medic_id"]),
                            0,
                            read["medic_name"].ToString(),
                            read["medic_last_name"].ToString(),
                            0,
                            "",
                            "",
                            "",
                            0,
                            0,
                            Convert.ToInt32(read["office_id"]),
                            TimeSpan.Zero,
                            TimeSpan.Zero
                        );

                        // CONSULTORIO
                        Office office = new Office(
                            Convert.ToInt32(read["office_id"]),
                            read["office_location"].ToString(),
                            TimeSpan.Zero,
                            TimeSpan.Zero,
                            null
                        );

                        // SHIFT
                        Shift shift = new Shift(
                            Convert.ToInt32(read["shift_id"]),
                            Convert.ToDateTime(read["shift_date"]),
                            TimeSpan.Parse(read["shift_time"].ToString()),
                            Convert.ToInt32(read["duration"]),
                            Convert.ToDouble(read["original_price"]),
                            doctor,
                            this,
                            office,
                            (StateShift)Enum.Parse(typeof(StateShift), read["state"].ToString())
                        );

                        listTurno.Add(shift);
                    }
                }
            }
        }
        public List<Shift> AvailableShifts(DateTime date, int officeId, int specialityId)
        {
            List<Shift> availableShifts = new List<Shift>();

            using (MySqlConnection conexionDB = Connection.conexion())
            {
                conexionDB.Open();

                // 1) Buscar todos los médicos de esa especialidad en ese consultorio
                List<int> medicsIds = new List<int>();

                string queryMedics =
                    "SELECT m.id " +
                    "FROM medics m " +
                    "INNER JOIN assigned_doctors_office ado ON ado.medic_id = m.id " +
                    "WHERE m.speciality_id = @spec AND ado.office_id = @office";

                MySqlCommand cmdMedics = new MySqlCommand(queryMedics, conexionDB);
                cmdMedics.Parameters.AddWithValue("@spec", specialityId);
                cmdMedics.Parameters.AddWithValue("@office", officeId);

                using (var read = cmdMedics.ExecuteReader())
                {
                    while (read.Read())
                        medicsIds.Add(Convert.ToInt32(read["id"]));
                }

                if (medicsIds.Count == 0)
                    return availableShifts;

                // 2) Buscar turnos libres de TODOS esos médicos
                string searchshifts =
                    "SELECT " +
                    "s.id, s.shift_date, s.shift_time, s.duration, s.original_price, s.state, " +
                    "m.id AS medic_id, u.name AS medic_name, u.last_name AS medic_last_name, " +
                    "o.id AS office_id, o.ubication " +
                    "FROM shifts s " +
                    "INNER JOIN medics m ON s.medic_id = m.id " +
                    "INNER JOIN users u ON m.user_id = u.id " +
                    "INNER JOIN offices o ON s.office_id = o.id " +
                    "WHERE s.state = 'libre' " +
                    "AND s.patient_id IS NULL " +
                    "AND s.shift_date = @date " +
                    "AND s.medic_id IN (" + string.Join(",", medicsIds) + ")";

                MySqlCommand cmd = new MySqlCommand(searchshifts, conexionDB);
                cmd.Parameters.AddWithValue("@date", date);

                using (var read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        Medic doctor = new Medic(
                            Convert.ToInt32(read["medic_id"]),
                            0,
                            read["medic_name"].ToString(),
                            read["medic_last_name"].ToString(),
                            0,
                            "",
                            "",
                            "",
                            0,
                            0,
                            officeId,
                            TimeSpan.Zero,
                            TimeSpan.Zero
                        );

                        Office office = new Office(
                            Convert.ToInt32(read["office_id"]),
                            read["ubication"].ToString(),
                            TimeSpan.Zero,
                            TimeSpan.Zero,
                            null
                        );

                        Shift shift = new Shift(
                            Convert.ToInt32(read["id"]),
                            Convert.ToDateTime(read["shift_date"]),
                            TimeSpan.Parse(read["shift_time"].ToString()),
                            Convert.ToInt32(read["duration"]),
                            Convert.ToDouble(read["original_price"]),
                            doctor,
                            null,
                            office,
                            StateShift.libre
                        );

                        availableShifts.Add(shift);
                    }
                }
            }

            return availableShifts;
        }


        //Seleccionar un turno disponible, esta informacion se guardara en la lista 
        // de TURNOS del paciente y del Medico asignado
        public bool RequestAppointment(int shiftId)
        {
            using (MySqlConnection conexionDB = Connection.conexion())
            {
                conexionDB.Open();

                string query =
                    "UPDATE shifts " +
                    "SET state = 'programado', patient_id = @pid " +
                    "WHERE id = @sid AND state = 'libre' AND patient_id IS NULL";

                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                cmd.Parameters.AddWithValue("@pid", this.Id);
                cmd.Parameters.AddWithValue("@sid", shiftId);

                int affected = cmd.ExecuteNonQuery();

                return affected > 0;
            }
        }



    }
}
