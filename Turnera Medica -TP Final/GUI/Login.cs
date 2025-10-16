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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = login_email_user.Text;
            string password = login_email_password.Text;

            // Reviso que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Login de prueba (por ahora sin base de datos)
            if (email == "admin@gmail.com" && password == "1234")
            {
                MessageBox.Show("Inicio de sesión exitoso.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Más adelante acá se va a abrir el menú principal
                // Ejemplo: new MenuPrincipal().Show();
                // this.Hide();
            }
            else
            {
                MessageBox.Show("Email o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            //Llamo el form o ventana PreRegister
            PreRegister preregistro_form = new PreRegister();
            preregistro_form.Show(); //Abre este form
            this.Hide(); // Oculto el Logi_n
        }

        private void lnkOlvide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Llamo el form o ventana UpdatePassword
            UpdatePassword updatepassword_form = new UpdatePassword();
            updatepassword_form.Show(); //Abre este form
            this.Hide(); // Oculto el Login
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
