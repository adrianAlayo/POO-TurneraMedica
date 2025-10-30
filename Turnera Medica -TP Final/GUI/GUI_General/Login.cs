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
            PreRegister preregister_form = new PreRegister();
            preregister_form.Show(); //Abre este form
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
                // Abro la conexión con la base de datos
                conexionDB.Open();

                // Guardo los datos escritos por el usuario en los TextBox
                string email = login_email_user.Text.Trim();
                string password = login_password_user.Text.Trim();

                // Consulta SQL para buscar un usuario con ese email y contraseña
                string query = "SELECT * FROM users WHERE email = @Email AND password_hash = @Password";

                // Creo el comando SQL y paso los valores a los parámetros
                MySqlCommand codigo = new MySqlCommand(query, conexionDB);
                codigo.Parameters.AddWithValue("@Email", email);
                codigo.Parameters.AddWithValue("@Password", password);

                // Ejecuto la consulta y guardo el resultado
                MySqlDataReader leer = codigo.ExecuteReader();

                // Si encontró un usuario, entra al if
                if (leer.Read())
                {
                    // Leo el rol del usuario (medico o paciente)
                    string rolUsuario = leer["rol"].ToString().Trim();

                    // Si el rol es médico, abre la interfaz del médico
                    if (rolUsuario == "medico")
                    {
                        MessageBox.Show("Inicio de sesión correcto: Médico");
                        M_Start mStartForm = new M_Start();
                        mStartForm.Show();
                        this.Hide();
                    }
                    // Si el rol es paciente, abre la interfaz del paciente
                    else if (rolUsuario == "paciente")
                    {
                        MessageBox.Show("Inicio de sesión correcto: Paciente");
                        P_Start pStartForm = new P_Start();
                        pStartForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Si tiene otro rol, muestra un aviso
                        MessageBox.Show("Rol desconocido. Contacte al administrador.");
                    }
                }
                else
                {
                    // Si no encontró usuario, limpia los campos y muestra error
                    MessageBox.Show("Usuario o contraseña incorrecta.");
                    login_email_user.Clear();
                    login_password_user.Clear();
                }
            }
            catch (Exception ex)
            {
                // Si hubo un error (por ejemplo, de conexión), lo muestra
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
            finally
            {
                // Cierro la conexión pase lo que pase
                conexionDB.Close();
            }
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
