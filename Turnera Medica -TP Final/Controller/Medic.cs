using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    public class Medic : User
    {
        //Saber la especialidad del Medico
        public int Speciality_Id { get; set; }
        
        //Saber Cuando cobra la consulta
        public double ConsultationAmount { get; set; }
        
        //Consultorio/lugar donde trabaja
        public int OfficeAssigned { get; set; } //Guarda el ID del consultario, en la tabla que relaciona medico con consultorio

        public TimeSpan entryTime { get; set; }
        public TimeSpan departureTime { get; set; }

        public Medic (int id, int dni, string name, string lastname, int age,string email, string telnumber, string password, int speciality_id, double consultationamount, int officeassigned, TimeSpan entrytime, TimeSpan departuretime) 
            : base(id, dni, name, lastname, age, email, telnumber, password)
        {
            Speciality_Id = speciality_id;
            ConsultationAmount = consultationamount;
            OfficeAssigned = officeassigned;
            entryTime = entrytime;
            departureTime = departuretime;
        }

        //Consultar un Turno especifico por fecha
        public override void specificShift(DateTime date)
        {
            listTurno = new List<Shift>();

            using (MySqlConnection conexionDB = Connection.conexion())
            {
                conexionDB.Open();

                string query = @"
            SELECT 
                s.id,
                s.shift_date,
                s.shift_time,
                s.duration,
                s.original_price,
                s.state,
                u.name AS patient_name,
                u.last_name AS patient_lastname
            FROM shifts s
            LEFT JOIN patients p ON p.id = s.patient_id
            LEFT JOIN users u ON u.id = p.user_id
            WHERE s.medic_id = @medicId
              AND s.shift_date = @dateSelected
            ORDER BY s.shift_time;
        ";

                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                cmd.Parameters.AddWithValue("@medicId", this.Id);
                cmd.Parameters.AddWithValue("@dateSelected", date.Date);

                using (MySqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        Patient paciente = null;

                        if (!string.IsNullOrEmpty(read["patient_name"].ToString()))
                        {
                            paciente = new Patient(
                                0,
                                0,
                                read["patient_name"].ToString(),
                                read["patient_lastname"].ToString(),
                                0, "", "", "", 0
                            );
                        }

                        Shift turno = new Shift(
                            Convert.ToInt32(read["id"]),
                            Convert.ToDateTime(read["shift_date"]),
                            TimeSpan.Parse(read["shift_time"].ToString()),
                            Convert.ToInt32(read["duration"]),
                            Convert.ToDouble(read["original_price"]),
                            this,
                            paciente,
                            null,
                            (StateShift)Enum.Parse(typeof(StateShift), read["state"].ToString())
                        );

                        listTurno.Add(turno);
                    }
                }
            }
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
                        s.id,
                        s.shift_date,
                        s.shift_time,
                        s.duration,
                        s.original_price,
                        s.state,
                        u.name AS patient_name,
                        u.last_name AS patient_lastname
                    FROM shifts s
                    LEFT JOIN patients p ON p.id = s.patient_id
                    LEFT JOIN users u ON u.id = p.user_id
                    WHERE s.medic_id = @medicId
                      AND s.state NOT IN ('asistido','cancelado')
                      AND s.shift_date >= CURDATE()
                    ORDER BY s.shift_date, s.shift_time;
                ";

                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                cmd.Parameters.AddWithValue("@medicId", this.Id);

                using (MySqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        // Crear paciente (si existe)
                        Patient paciente = null;

                        if (!string.IsNullOrEmpty(read["patient_name"].ToString()))
                        {
                            paciente = new Patient(
                                0,
                                0,
                                read["patient_name"].ToString(),
                                read["patient_lastname"].ToString(),
                                0, "", "", "", 0
                            );
                        }

                        // Crear turno
                        Shift turno = new Shift(
                            Convert.ToInt32(read["id"]),
                            Convert.ToDateTime(read["shift_date"]),
                            TimeSpan.Parse(read["shift_time"].ToString()),
                            Convert.ToInt32(read["duration"]),
                            Convert.ToDouble(read["original_price"]),
                            this,
                            paciente,
                            null,
                            (StateShift)Enum.Parse(typeof(StateShift), read["state"].ToString())
                        );

                        listTurno.Add(turno);
                    }
                }
            }
        }

        //Calcular cuanto recaudo El medico en un rango de una fecha. 
        public double CalculateReceipt(DateTime from, DateTime until)
        {
            return 0;
        }

        //Sirve para que el medico agrega una obra social a su lista de Obras Sociales.
        public bool AddSocialWork(string socialWorkName)
        {
            if (string.IsNullOrWhiteSpace(socialWorkName))
                throw new Exception("El nombre de la obra social no puede estar vacío.");

            using (MySqlConnection conexionDB = Connection.conexion())
            {
                conexionDB.Open();

                // Queries
                string queryAddSocial = "INSERT INTO social_works (name) VALUES (@namesocial)";
                string queryGetSocial = "SELECT id FROM social_works WHERE name = @namesocial";
                string queryCheckRel = "SELECT COUNT(*) FROM medic_social_work WHERE medic_id = @idmedic AND social_work_id = @idsocial";
                string queryAddRel = "INSERT INTO medic_social_work (medic_id, social_work_id) VALUES (@idmedic, @idsocial)";

                int idsocial = 0;

                // 1) Intentar insertar la obra social (ignorar si ya existe)
                try
                {
                    MySqlCommand cmdAdd = new MySqlCommand(queryAddSocial, conexionDB);
                    cmdAdd.Parameters.AddWithValue("@namesocial", socialWorkName.Trim());
                    cmdAdd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number != 1062) // Duplicado → ignorar
                        throw;
                }

                // 2) Obtener el ID de la obra social
                MySqlCommand cmdGet = new MySqlCommand(queryGetSocial, conexionDB);
                cmdGet.Parameters.AddWithValue("@namesocial", socialWorkName.Trim());

                using (MySqlDataReader read = cmdGet.ExecuteReader())
                {
                    if (read.Read())
                    {
                        idsocial = Convert.ToInt32(read["id"]);
                    }
                }

                if (idsocial == 0)
                    throw new Exception("No se pudo obtener el ID de la obra social.");

                // 3) Verificar si ya está asociada al médico
                MySqlCommand cmdCheck = new MySqlCommand(queryCheckRel, conexionDB);
                cmdCheck.Parameters.AddWithValue("@idmedic", this.Id);
                cmdCheck.Parameters.AddWithValue("@idsocial", idsocial);

                int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (existe > 0)
                    throw new Exception("Este médico ya tiene asociada esta obra social.");

                // 4) Insertar relación medico–obra social
                MySqlCommand cmdAddRel = new MySqlCommand(queryAddRel, conexionDB);
                cmdAddRel.Parameters.AddWithValue("@idmedic", this.Id);
                cmdAddRel.Parameters.AddWithValue("@idsocial", idsocial);

                int filas = cmdAddRel.ExecuteNonQuery();

                // IMPORTANTE ✔ actualizamos la lista interna del médico (si la usás después)
                if (filas > 0)
                {
                    if (this.listObraSocial == null)
                        this.listObraSocial = new List<SocialWork>();

                    this.listObraSocial.Add(new SocialWork(idsocial, socialWorkName.Trim()));

                    return true;
                }

                return false;
            }
        }

        //Cuando el paciente no asista al turno el emdico tendra que actualizar el turno como no asistido de parte del paciente
        public void UpdateShiftAttended(int shiftId)
        {
            using (MySqlConnection conexionDB = Connection.conexion())
            {
                conexionDB.Open();

                string query = "UPDATE shifts SET state = 'asistido' WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                cmd.Parameters.AddWithValue("@id", shiftId);

                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateShiftCanceled(int shiftId) 
        {
            using (MySqlConnection conexionDB = Connection.conexion())
            {
                conexionDB.Open();

                string query = "UPDATE shifts SET state = 'cancelado' WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                cmd.Parameters.AddWithValue("@id", shiftId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
