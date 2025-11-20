using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    public class Office
    {
        public int Id { get; set; } //id para identificar el consultorio
        public string Ubication { get; set; } //la ubicacion del consultorio
        public TimeSpan HourOpen { get; set; } //la hora a la que abre el consultorio
        public TimeSpan TimeClosed { get; set; } //la hora a la que cierra el consultorio
        public List<Medic> Assigned_Doctors { get; set; } //la lista de medicos que trabaja en ese consultorio

        public Office(int id, string ubication, TimeSpan houropen, TimeSpan timeclosed, List<Medic> assigned_doctors)
        {
            Id = id;
            Ubication = ubication;
            HourOpen = houropen;
            TimeClosed = timeclosed;
            Assigned_Doctors = assigned_doctors;
        }

        // este metodo se encarga de asignar un doctor a un consultorio, este va a tener como parametros el medico a asignar, su horario de trabajo y la conexion a la DB
        public void AssignDoctor(Medic medic, TimeSpan open_from, TimeSpan close_after, MySqlConnection conexionDB) 
        {
            // nos aseguramos que la lista no sea nula , si es que es nulo entonces creamos una nueva lista
            if (Assigned_Doctors == null)
            {
                Assigned_Doctors = new List<Medic>();
            }
            Assigned_Doctors.Add(medic);

            //creamos la query para insertar la relacion entre el medico y el consultorio, y luego la ejecutamos

            string query = "INSERT INTO assigned_doctors_office (medic_id, office_id, open_from, close_after) VALUES (@medic, @office, @open, @close)";

            using (MySqlCommand cmd = new MySqlCommand(query, conexionDB))
            {
                cmd.Parameters.AddWithValue("@medic", medic.Id);
                cmd.Parameters.AddWithValue("@office", this.Id);
                cmd.Parameters.AddWithValue("@open", open_from);
                cmd.Parameters.AddWithValue("@close", close_after);

                cmd.ExecuteNonQuery();
            }
        }



    }
}
