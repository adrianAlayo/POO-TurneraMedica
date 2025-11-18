using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turnera_Medica__TP_Final.Controller;

namespace Turnera_Medica__TP_Final.GUI.GUI_Medico
{
    public partial class M_MyInfo : Form
    {
        private Medic usermedic { get; set; }
        public M_MyInfo(Medic usermedic)
        {
            InitializeComponent();
            this.usermedic = usermedic;
        }

        
        private void return_start_M_Click(object sender, EventArgs e)
        {
            M_Start m_start_form = new M_Start(usermedic);
            m_start_form.Show(); //abre de vuelta el form de inicio del medico
            this.Hide(); // quitamos el form de ver mi informacion
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void M_MyInfo_Load(object sender, EventArgs e)
        {
            M_MyInfo_name.Text = usermedic.Name;
            M_MyInfo_last_name.Text = usermedic.LastName;
            M_MyInfo_dni.Text = Convert.ToString(usermedic.Dni);
            M_MyInfo_age.Text = Convert.ToString(usermedic.Age);
            M_MyInfo_phone.Text = usermedic.TelNumber;
            M_MyInfo_email.Text = usermedic.Email;
            M_MyInfo_consult_price.Text = usermedic.ConsultationAmount.ToString();
            M_MyInfo_entry_time.Text = usermedic.entryTime.ToString();
            M_MyInfo_departure_time.Text = usermedic.departureTime.ToString();
            
            

            MySqlConnection conexionDB = Connection.conexion();
            conexionDB.Open();

           
            string querySpeciality = "SELECT name FROM specialities WHERE id = @id";
            MySqlCommand cmdSpec = new MySqlCommand(querySpeciality, conexionDB);
            cmdSpec.Parameters.AddWithValue("@id", usermedic.Speciality_Id);

            string specialityName = "";
            using (MySqlDataReader read1 = cmdSpec.ExecuteReader())
            {
                if (read1.Read())
                {
                    specialityName = read1["name"].ToString();
                }
            }
            M_MyInfo_speciality.Text = specialityName;

           
            string queryOffice = "SELECT ubication FROM offices WHERE id = @id";
            MySqlCommand cmdOffice = new MySqlCommand(queryOffice, conexionDB);
            cmdOffice.Parameters.AddWithValue("@id", usermedic.OfficeAssigned);

            string officeName = "";
            using (MySqlDataReader read2 = cmdOffice.ExecuteReader())
            {
                if (read2.Read())
                {
                    officeName = read2["ubication"].ToString();
                }
            }
            M_MyInfo_office.Text = officeName;


            string querySocialWorks =
                "SELECT sw.name FROM social_works sw " +
                "INNER JOIN medic_social_work msw ON msw.social_work_id = sw.id " +
                "WHERE msw.medic_id = @id";

            MySqlCommand cmdSocial = new MySqlCommand(querySocialWorks, conexionDB);
            cmdSocial.Parameters.AddWithValue("@id", usermedic.Id);

            List<string> socialWorksList = new List<string>();

            using (MySqlDataReader read3 = cmdSocial.ExecuteReader())
            {
                while (read3.Read())
                {
                    socialWorksList.Add(read3["name"].ToString());
                }
            }

            M_MyInfo_social_works.Text = string.Join(", ", socialWorksList);

            conexionDB.Close();
        }

        private void M_MyInfo_office_Click(object sender, EventArgs e)
        {

        }

        private void M_MyInfo_dni_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void M_MyInfo_phone_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void M_MyInfo_speciality_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void M_MyInfo_office_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void M_MyInfo_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void M_MyInfo_consult_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void M_MyInfo_last_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void M_MyInfo_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void M_MyInfo_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void M_MyInfo_social_works_TextChanged(object sender, EventArgs e)
        {

        }

        private void M_MyInfo_entry_time_TextChanged(object sender, EventArgs e)
        {

        }

        private void M_MyInfo_departure_time_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
