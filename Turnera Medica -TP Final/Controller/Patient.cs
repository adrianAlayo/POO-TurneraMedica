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
        public int Social_work_id {  get; set; } //guardamos el id de la obra social a la que esta relacionado el paciente
        public Patient(int id, int dni, string name, string lastname, int age,string email, string telnumber, string password, int id_socialwork)
            : base(id, dni, name, lastname, age ,email, telnumber, password)
        {
            Social_work_id = id_socialwork;   
        }

        //Consultar un Turno/s especifico por fecha
        public override void specificShift(DateTime date)
        {
            listTurno = new List<Shift>(); //creamos una lista donde vamos a guardar los turnos mas tarde

            using (MySqlConnection conexionDB = Connection.conexion())
            {
                conexionDB.Open();

                //realizamos la query sql para buscar el/los turno/s que esten relacionados con el paciente y que su estado sea programado,
                //ademas de que usamos left join para combinar las columnas de id de las tablas
                // shifts, medics, user y offices para poder tener el nombre y apellido del medico, y la ubicacion del consultorio
                string query = @"
                    SELECT 
                        s.id AS shift_id, s.shift_date, s.shift_time, s.duration, s.original_price, s.state,

                        m.id AS medic_id,
                        um.name AS medic_name, um.last_name AS medic_last_name,

                        o.id AS office_id, o.ubication AS office_ubication

                    FROM shifts s
                    LEFT JOIN medics m ON s.medic_id = m.id
                    LEFT JOIN users um ON um.id = m.user_id
                    LEFT JOIN offices o ON o.id = s.office_id
                    WHERE s.patient_id = @idpatient AND s.state = 'programado' AND s.shift_date = @date
                    ORDER BY s.shift_time";

                MySqlCommand cmd = new MySqlCommand(query, conexionDB); //creamos un comando para ejecutar la query que creamos antes
                cmd.Parameters.AddWithValue("@idpatient", this.Id);
                cmd.Parameters.AddWithValue("@date", date);

                using (MySqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read()) //mientras la lectura del comando sobre la query que creamos sea verdera se van a crear 3 objetos
                    {
                        // un objeto medico donde solamente vamos a guardar su id, su nombre y apellido, y el consultorio donde trabaja
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

                        // un objeto consultorio donde solo vamos a guardar su id y su ubicacion
                        Office office = new Office(
                            Convert.ToInt32(read["office_id"]),
                            read["office_ubication"].ToString(),
                            TimeSpan.Zero,
                            TimeSpan.Zero,
                            null
                        );

                        // un objeto shift donde vamos a guardar los datos de el/los turno/s que cumplieron con nuestras con nuestras condiciones
                        // al momento de ejecutar la query, ademas de tambien agregar los datos de los objetos consultorio y medico que guardamos anteriormente
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

                        listTurno.Add(shift); // por ultimo guardamos este turno en la lista que habiamos creado al principio
                    }
                }
            }
        }


        //Consultar todos los turnos
        public override void Shifts()
        {
            listTurno = new List<Shift>(); // creamos una lista donde vamos a guardar los turnos mas tarde

            using (MySqlConnection conexionDB = Connection.conexion())
            {
                conexionDB.Open();

                //realizamos la query sql para buscar los turnos que esten relacionados con el paciente y que su estado sea programado,
                //ademas de que usamos left join para combinar las columnas de id de las tablas
                // shifts, medics, user y offices para poder tener el nombre y apellido del medico, y la ubicacion del consultorio
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

                MySqlCommand cmd = new MySqlCommand(query, conexionDB); // creamos un comando para ejecutar la query que creamos anteriormente
                cmd.Parameters.AddWithValue("@idpatient", this.Id);

                using (MySqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read()) //mientras la lectura del comando sea verdadera se van a crear 3 objetos
                    {
                        //un objeto medico donde solo guardaremos su id, su nombre y apellido, y el consultorio donde trabaja
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

                        //un objeto consultorio donde vamos a guardar solo su id y la ubicacion
                        Office office = new Office(
                            Convert.ToInt32(read["office_id"]),
                            read["office_location"].ToString(),
                            TimeSpan.Zero,
                            TimeSpan.Zero,
                            null
                        );

                        //un objeto turno donde vamos a guardar todos los datos del turno mas los objetos que creamos anteriormente
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

                        listTurno.Add(shift); // por ultimo añadimos el turno que creamos a la lista que creamos al principio
                    }
                }
            }
        }

        // Consultar todos los turnos disponibles/libres de una fecha (de una especialidad en un cierto consultorio)
        public List<Shift> AvailableShifts(DateTime date, int officeId, int specialityId)
        {
            List<Shift> availableShifts = new List<Shift>();

            using (MySqlConnection conexionDB = Connection.conexion())
            {
                conexionDB.Open();

                // creamos una lista donde guardar los ids de los medicos, ya que vamos a hacer una query para buscar todos los medicos de una sola especialidad en 
                // ese consultorio
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
                    while (read.Read()) // mientras la lectura del comando sea verdadera este va a agregar a una lista todos los ids de medicos que cumplan 
                                        // con los requisitos
                    {
                        medicsIds.Add(Convert.ToInt32(read["id"]));
                    }
                }

                if (medicsIds.Count == 0) //si es que este no encuentra ningun medico con esa especialidad en el consultorio seleccionado entonces
                                          //devuelve una lista vacia de turnos
                {
                    return availableShifts;
                }
                

                //ahora hacemos una query para buscar todos los turnos libres de esos medicos en la fecha pedida por el paciente
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

                MySqlCommand cmd = new MySqlCommand(searchshifts, conexionDB); //creamos un comando para ejecutar la query que creamos
                cmd.Parameters.AddWithValue("@date", date);

                using (var read = cmd.ExecuteReader())
                {
                    while (read.Read()) // mientras la lectura del comando sea verdadera se van a crear 3 objetos
                    {
                        //un objeto medico donde solo vamos a guardar su id, su nombre y apellido, y el consultorio donde trabaja
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

                        //un objeto consultorio donde solo vamos a guardar su id y su ubicacion
                        Office office = new Office(
                            Convert.ToInt32(read["office_id"]),
                            read["ubication"].ToString(),
                            TimeSpan.Zero,
                            TimeSpan.Zero,
                            null
                        );

                        //un objeto turno donde vamos a guardar todos los datos sobre el turno y los objetos que creamos anteriormente
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

                        availableShifts.Add(shift); //por ultimos guardamos el objeto turno que creamos en la lista que creamos al principio
                    }
                }
            }

            return availableShifts;
        }


        //Al seleccionar uno de los turnos disponibles el paciente puede reservarlo para el mismo
        public bool RequestAppointment(int shiftId)
        {
            using (MySqlConnection conexionDB = Connection.conexion())
            {
                conexionDB.Open();

                string query = //realizamos el query actualizar el estado del turno y asignarlo al paciente
                    "UPDATE shifts " +
                    "SET state = 'programado', patient_id = @pid " +
                    "WHERE id = @sid AND state = 'libre' AND patient_id IS NULL";

                MySqlCommand cmd = new MySqlCommand(query, conexionDB); //creamos el comando para ejecutar la query
                cmd.Parameters.AddWithValue("@pid", this.Id);
                cmd.Parameters.AddWithValue("@sid", shiftId);

                int affected = cmd.ExecuteNonQuery();

                return affected > 0; //si alguna fila fue afectada este devuelve true
            }
        }



    }
}
