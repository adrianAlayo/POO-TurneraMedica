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
    public partial class M_AddSocialWork : Form
    {
        private Medic usermedic { get; set; }
        public M_AddSocialWork(Medic usermedic)
        {
            InitializeComponent();
            this.usermedic = usermedic;
        }

        MySqlConnection conexionDB = Connection.conexion();

        private void M_AddSocialWork_Load(object sender, EventArgs e)
        {
            M_name_user_guia.Text += " " + usermedic.Name + " " + usermedic.LastName;
        }

        private void socialwork_name_user_TextChanged(object sender, EventArgs e)
        {

        }

        // ES PARA AÑADIR LA OBRA SOCIAL 
            private void sent_socialwork_Click(object sender, EventArgs e)
        {
            try
            {
                bool ok = usermedic.AddSocialWork(socialwork_name_user.Text.Trim());

                if (ok)
                    MessageBox.Show("Obra social agregada correctamente.");
                else
                    MessageBox.Show("No se pudo agregar la obra social.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void return_start_M_Click(object sender, EventArgs e)
        {
            M_Start m_start_form = new M_Start(usermedic);
            m_start_form.Show(); //abre de vuelta el form de inicio del medico
            this.Hide(); // quitamos el form de añadir obra social
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SendLogin_Click(object sender, EventArgs e)
        {
            Login login_form = new Login();
            login_form.Show(); // Abro la pantalla de login
            this.Hide();
        }
    }
}
