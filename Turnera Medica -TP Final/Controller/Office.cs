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
        public int Id { get; set; }
        public string Ubication { get; set; }
        public TimeSpan HourOpen { get; set; }
        public TimeSpan TimeClosed { get; set; }
        public List<Medic> Assigned_Doctors { get; set; }

        public Office(int id, string ubication, TimeSpan houropen, TimeSpan timeclosed, List<Medic> assigned_doctors)
        {
            Id = id;
            Ubication = ubication;
            HourOpen = houropen;
            TimeClosed = timeclosed;
            Assigned_Doctors = assigned_doctors;
        }

        public void AssignDoctor(Medic medic, TimeSpan open_from, TimeSpan close_after, MySqlConnection conexionDB)
        {
            // Asegurar lista interna
            if (Assigned_Doctors == null)
                Assigned_Doctors = new List<Medic>();

            Assigned_Doctors.Add(medic);

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
