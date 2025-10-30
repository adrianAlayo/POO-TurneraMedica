using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnera_Medica__TP_Final.GUI
{
    public partial class RegisterPatient : Form
    {
        public RegisterPatient()
        {
            InitializeComponent();
        }

        private void RegisterPatient_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RegisterP_send_Click(object sender, EventArgs e)
        {

        }

        private void ReturnPreRegister_Click(object sender, EventArgs e)
        {
            //Llamo el form o ventana Login
            PreRegister PreRegister_form = new PreRegister();
            PreRegister_form.Show(); //Abre este form
            this.Hide(); // Oculto el Login
        }

        private void registerP_name_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerP_dni_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerP_email_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerP_confirPassword_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerP_lastName_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerP_numberPhone_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerP_socialWork_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerP_password_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
