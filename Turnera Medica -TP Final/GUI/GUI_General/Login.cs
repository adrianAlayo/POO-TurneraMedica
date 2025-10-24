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
using Turnera_Medica__TP_Final.GUI.GUI_Paciente;

namespace Turnera_Medica__TP_Final.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        MySqlConnection conexionDB = Connection.conexion();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
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

        private void SendLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conexionDB.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conexionDB;

            codigo.CommandText = ("SELECT * FROM  users WHERE email = '" + login_email_user.Text + "'AND password_hash = '" + login_password_user.Text + "'");

            MySqlDataReader leer = codigo.ExecuteReader();

            if (leer.Read() == true) 
            {
                P_Start P_Start_form = new P_Start();
                P_Start_form.Show(); //Abre este form
                this.Hide(); // Oculto el Login
            }
            else 
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
                login_email_user.Clear();
                login_password_user.Clear();
            }
            conexionDB.Close();
            //string email = login_email_user.Text;
            //string password = login_password_user.Text;

            //// Reviso que los campos no estén vacíos
            //if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            //{
            //    MessageBox.Show("Por favor, complete todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //// Login de prueba (por ahora sin base de datos)
            //if (email == "admin@gmail.com" && password == "1234")
            //{
            //    //Llamo el form o ventana UpdatePassword
            //    M_Start M_Start_form = new M_Start();
            //    M_Start_form.Show(); //Abre este form
            //    this.Hide(); // Oculto el Login

            //    MessageBox.Show("Inicio de sesión exitoso.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    // Más adelante acá se va a abrir el menú principal
            //    // Ejemplo: new MenuPrincipal().Show();
            //    // this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Email o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_email_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_password_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
