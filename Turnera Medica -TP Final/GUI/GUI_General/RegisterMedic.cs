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

namespace Turnera_Medica__TP_Final.GUI
{
    public partial class RegisterMedic : Form
    {
        public RegisterMedic()
        {
            InitializeComponent();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }


        private void label13_Click(object sender, EventArgs e)
        {

        }


        private void Volver_login_Click(object sender, EventArgs e)
        {
            //Llamo el form o ventana Login
            PreRegister PreRegister_form = new PreRegister();
            PreRegister_form.Show(); //Abre este form
            this.Hide(); // Oculto el Login
        }

        private void RegisterM_send_Click(object sender, EventArgs e)
        {
            //Aca hay que hacer toda la logica de como ver la informacion si es correcta para poder guardarla en a base de datos
        }

        private void RegisterMedic_Load(object sender, EventArgs e)
        {

        }

        private void ReturnPreRegister_Click(object sender, EventArgs e)
        {
            //Llamo el form o ventana Login
            PreRegister PreRegister_form = new PreRegister();
            PreRegister_form.Show(); //Abre este form
            this.Hide(); // Oculto el Login
        }

        private void registerM_dni_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerM_montConsul_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerM_office_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerM_email_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerM_confirPassword_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerM_lastName_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerM_numberPhone_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerM_especialty_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerM_socialWork_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerM_password_user_TextChanged(object sender, EventArgs e)
        {

        }


        private void registerM_departureTime_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerM_entryTime_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerM_name_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
