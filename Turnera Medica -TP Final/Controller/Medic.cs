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

        //Consultar un Turno/s especifico por fecha
        public override void specificShift(DateTime date)
        {
            listTurno = new List<Shift>(); //creamos una lista donde vamos a guardar los turnos despues de hacer todas las consultas

            using (MySqlConnection conexionDB = Connection.conexion())
            {
                conexionDB.Open();

                //realizamos la query sql para buscar el/los turno/s, ademas de que usamos left join para combinar las columnas de id de las tablas
                // shifts, patients y user para poder tener el nombre y apellido del paciente
                string query = @"         
                    SELECT 
                        s.id, s.shift_date, s.shift_time, s.duration, s.original_price, s.state,
                        
                        u.name AS patient_name, u.last_name AS patient_lastname
                    FROM shifts s
                    LEFT JOIN patients p ON p.id = s.patient_id
                    LEFT JOIN users u ON u.id = p.user_id
                    WHERE s.medic_id = @medicId AND s.shift_date = @dateSelected
                    ORDER BY s.shift_time;
        ";

                MySqlCommand cmd = new MySqlCommand(query, conexionDB); //creamos el comando para ejecutar nuestra query que creamos
                cmd.Parameters.AddWithValue("@medicId", this.Id);
                cmd.Parameters.AddWithValue("@dateSelected", date.Date);

                using (MySqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read()) //luego de ejecutar el comando hacemos un while para que mientras la lectura del comando sea verdadera este haga lo siguiente
                    {
                        Patient patient = null; //crea un objeto paciente que lo vamos a usar luego

                        if (!string.IsNullOrEmpty(read["patient_name"].ToString())) //si que es el nombre del paciente NO esta vacio entonces llenamos la nueva clase paciente
                                                                                    //solo con el nombre y apellido del paciente
                        {
                            patient = new Patient(
                                0,
                                0,
                                read["patient_name"].ToString(),
                                read["patient_lastname"].ToString(),
                                0, "", "", "", 0
                            );
                        }

                        Shift shift = new Shift(  //creamos una clase shift donde se guardaran los datos del turno para luego mostrarlo en una tabl
                            Convert.ToInt32(read["id"]),
                            Convert.ToDateTime(read["shift_date"]),
                            TimeSpan.Parse(read["shift_time"].ToString()),
                            Convert.ToInt32(read["duration"]),
                            Convert.ToDouble(read["original_price"]),
                            this,
                            patient,
                            null,
                            (StateShift)Enum.Parse(typeof(StateShift), read["state"].ToString())
                        );

                        listTurno.Add(shift); //agregamos el nuevo objeto shift que creamos anteriormente en la lista de turnos que creamos al principio
                    }
                }
            }
        }

        //Consultar/Mostrar todos los turnos que son/esten asignados al medico
        public override void Shifts()
        {
            listTurno = new List<Shift>(); //creamos una lista de turnos donde vamos a ir guardando los turnos que cumplan con las condiciones de la consulta sql

            using (MySqlConnection conexionDB = Connection.conexion())
            {
                conexionDB.Open();

                // realizamos la query para buscar todos los turnos que esten asignados al medico (usando su id), ademas de que tambien buscamos el nombre y apellido
                // del paciente al que este turno esta asignado. Por otro lado otra condicion en este query es que el estado del turno no puede ser asistido o cancalado
                // y bueno tambien usamos CURDATE para solo seleccionar los turnos que sean del dia actual hacia adelante y los ordenamos por la hora (osea de mas temprano
                // a mas tarde)
                string query = @"
                    SELECT 
                        s.id, s.shift_date, s.shift_time, s.duration, s.original_price, s.state,
                       
                        u.name AS patient_name, u.last_name AS patient_lastname
                    FROM shifts s
                    LEFT JOIN patients p ON p.id = s.patient_id
                    LEFT JOIN users u ON u.id = p.user_id
                    WHERE s.medic_id = @medicId AND s.state NOT IN ('asistido','cancelado') AND s.shift_date >= CURDATE()
                    ORDER BY s.shift_date, s.shift_time;
                ";

                MySqlCommand cmd = new MySqlCommand(query, conexionDB); //creamos el comando para ejecutar nuestra query
                cmd.Parameters.AddWithValue("@medicId", this.Id);

                using (MySqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read()) //luego de ejecutar el comando hacemos un while para que mientras la lectura del comando sea verdadera este haga lo siguiente 
                    {
                        
                        Patient patient = null; //creamos un objeto paciente que lo vamos a usar luego

                        if (!string.IsNullOrEmpty(read["patient_name"].ToString())) //si que es el nombre del paciente NO esta vacio entonces llenamos la nueva clase paciente
                                                                                    //solo con el nombre y apellido del paciente
                        {
                            patient = new Patient(
                                0,
                                0,
                                read["patient_name"].ToString(),
                                read["patient_lastname"].ToString(),
                                0, "", "", "", 0
                            );
                        }

                        // creamos un objeto shift donde vamos a guardar toda la info del turno para luego guardarla en una lista
                        Shift shift = new Shift(
                            Convert.ToInt32(read["id"]),
                            Convert.ToDateTime(read["shift_date"]),
                            TimeSpan.Parse(read["shift_time"].ToString()),
                            Convert.ToInt32(read["duration"]),
                            Convert.ToDouble(read["original_price"]),
                            this,
                            patient,
                            null,
                            (StateShift)Enum.Parse(typeof(StateShift), read["state"].ToString())
                        );

                        listTurno.Add(shift); //guardamos el objeto shift con los datos del turno en la lista que habiamos creado al principio
                    }
                }
            }
        }

        //Sirve para que el medico agrega una obra social a su lista de Obras Sociales.
        public bool AddSocialWork(string socialWorkName)
        {
            if (string.IsNullOrWhiteSpace(socialWorkName))
            {
                throw new Exception("El nombre de la obra social no puede estar vacío."); //si es que el parametro esta vacio salta un error
            }

            using (MySqlConnection conexionDB = Connection.conexion())
            {
                conexionDB.Open();

                // Realizamos todas las queries que vamos a utilizar para agregar la social a la lista del medico
                string queryAddSocial = "INSERT INTO social_works (name) VALUES (@namesocial)";
                string queryGetSocial = "SELECT id FROM social_works WHERE name = @namesocial";
                string queryCheckRel = "SELECT COUNT(*) FROM medic_social_work WHERE medic_id = @idmedic AND social_work_id = @idsocial";
                string queryAddRel = "INSERT INTO medic_social_work (medic_id, social_work_id) VALUES (@idmedic, @idsocial)";

                int idsocial = 0;

                // primero intentamos insertar la obra social (si ya existe la obra social este la ignora)
                try
                {
                    MySqlCommand cmdAdd = new MySqlCommand(queryAddSocial, conexionDB);
                    cmdAdd.Parameters.AddWithValue("@namesocial", socialWorkName.Trim());
                    cmdAdd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number != 1062) // si esta duplicado este la ignora para no interrumpir el flujo 
                        throw;
                }

                // ahora vamos a obtener el id de la obra social que agregamos a la base anteriormente
                MySqlCommand cmdGet = new MySqlCommand(queryGetSocial, conexionDB);
                cmdGet.Parameters.AddWithValue("@namesocial", socialWorkName.Trim());

                using (MySqlDataReader read = cmdGet.ExecuteReader())
                {
                    if (read.Read())
                    {
                        idsocial = Convert.ToInt32(read["id"]); //guardamos el id en una variable
                    }
                }

                if (idsocial == 0)
                    throw new Exception("No se pudo obtener el ID de la obra social.");

                // ahora vamos a chequear si es que esta obra social ya estaba asociada al medico anteriormente
                MySqlCommand cmdCheck = new MySqlCommand(queryCheckRel, conexionDB);
                cmdCheck.Parameters.AddWithValue("@idmedic", this.Id);
                cmdCheck.Parameters.AddWithValue("@idsocial", idsocial);

                int existe = Convert.ToInt32(cmdCheck.ExecuteScalar()); // como la query es un count este va a contar si ya hay una relacion entre el medico y la obra social que quiso añadir

                if (existe > 0) //si resulta ser que la query ya encuentra una relacion entre el medico y la obra que ingreso este interrumpe la operacion
                    throw new Exception("Este médico ya tiene asociada esta obra social.");

                // ahora si es que no existe una relacion entonces nosotros vamos a insertar esa relacion entre el medico y la obra social
                MySqlCommand cmdAddRel = new MySqlCommand(queryAddRel, conexionDB);
                cmdAddRel.Parameters.AddWithValue("@idmedic", this.Id);
                cmdAddRel.Parameters.AddWithValue("@idsocial", idsocial);

                int filas = cmdAddRel.ExecuteNonQuery();

                // ahora si es que hubo alguna fila de la db fue afectada (debido a la insercion de la relacion) entonces vamos a guardar los datos de la obra social
                // en una lista para usarlo despues
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

        //Cuando el paciente asista al turno el medico tendra que actualizar el turno como asistido de parte del paciente
        public void UpdateShiftAttended(int shiftId) // como parametro este va a recibir el id del turno seleccionado a cambiar de estado
        {
            using (MySqlConnection conexionDB = Connection.conexion())
            {
                conexionDB.Open();

                string query = "UPDATE shifts SET state = 'asistido' WHERE id = @id";

                // luego de hacer la query para actualizar el estado del turno seleccionado vamos a ejecutar el comando

                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                cmd.Parameters.AddWithValue("@id", shiftId);

                cmd.ExecuteNonQuery();
            }
        }

        //Cuando el paciente cancele el turno/no asistio o si ya paso la fecha/hora de un turno entonces el medico lo va a tener que poner como cancelado
        public void UpdateShiftCanceled(int shiftId) //recibimos como parametro el id del turno
        {
            using (MySqlConnection conexionDB = Connection.conexion())
            {
                conexionDB.Open();

                string query = "UPDATE shifts SET state = 'cancelado' WHERE id = @id";

                //luego de hacer la query para actualizar el estado del turno seleccionado vamos a ejecutar el comando

                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                cmd.Parameters.AddWithValue("@id", shiftId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
