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
using Turnera_Medica__TP_Final.GUI.GUI_Medico;

namespace Turnera_Medica__TP_Final.GUI.GUI_Paciente
{
    public partial class P_MyInfo : Form
    {
        private Patient userpatient { get; set; }
        public P_MyInfo(Patient userpatient)
        {
            InitializeComponent();
            this.userpatient = userpatient;
        }
        MySqlConnection conexionDB = Connection.conexion();
        
        
        private void return_start_P_Click(object sender, EventArgs e)
        {
            P_Start p_start_form = new P_Start(userpatient);
            p_start_form.Show(); //abre de vuelta el form del menu para el paciente
            this.Hide(); // quitamos el form de ver mi informacion
        }


        private void P_MyInfo_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void P_MyInfo_dni_TextChanged(object sender, EventArgs e)
        {

        }

        private void P_MyInfo_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void P_MyInfo_social_work_TextChanged(object sender, EventArgs e)
        {

        }

        private void P_MyInfo_last_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void P_MyInfo_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void P_MyInfo_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void P_MyInfo_Load_1(object sender, EventArgs e)
        {
            conexionDB.Open();

            // Datos directos
            P_name_user_guia.Text += " " + userpatient.Name + " " + userpatient.LastName;
            P_MyInfo_name.Text = userpatient.Name;
            P_MyInfo_last_name.Text = userpatient.LastName;
            P_MyInfo_age.Text = userpatient.Age.ToString();
            P_MyInfo_dni.Text = userpatient.Dni.ToString();
            P_MyInfo_phone.Text = userpatient.TelNumber;
            P_MyInfo_email.Text = userpatient.Email;

            
            string querySocial = "SELECT name FROM social_works WHERE id = @id";

            MySqlCommand cmdSocial = new MySqlCommand(querySocial, conexionDB);
            cmdSocial.Parameters.AddWithValue("@id", userpatient.Social_work_id);

            string socialName = "";

            using (MySqlDataReader read1 = cmdSocial.ExecuteReader())
            {
                if (read1.Read())
                {
                    socialName = read1["name"].ToString();
                }
                else
                {
                    socialName = "Sin obra social";
                }
            }

            P_MyInfo_social_work.Text = socialName;

            conexionDB.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SendLogin_Click(object sender, EventArgs e)
        {
            Login login_form = new Login();
            login_form.Show(); // Abro la pantalla de login
            this.Hide();
        }

        private void social_work_Click(object sender, EventArgs e)
        {

        }
    }
}
