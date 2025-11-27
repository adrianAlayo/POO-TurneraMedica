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
    public partial class UpdatePassword : Form
    {
        public UpdatePassword()
        {
            InitializeComponent();
        }
        MySqlConnection conexionDB = Connection.conexion();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void update_password_Click(object sender, EventArgs e)
        {
            try 
            {
                conexionDB.Open();

                string email = update_email_user.Text.Trim();
                string newPass = update_newPass_user.Text.Trim();
                string confirmPass = update_confirmPass_user.Text.Trim();

                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(newPass) || string.IsNullOrWhiteSpace(confirmPass))
                {
                    MessageBox.Show("Complete todos los campos por favor");
                    return;
                }

                if (newPass != confirmPass)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    return;
                }

                string hashedPass = Utils.HashPassword(confirmPass);

                string queryupdate = "UPDATE users SET password_hash = @updatepassword WHERE email = @useremail";
                MySqlCommand cmdupdate = new MySqlCommand(queryupdate, conexionDB);
                cmdupdate.Parameters.AddWithValue("@updatepassword", hashedPass);
                cmdupdate.Parameters.AddWithValue("@useremail", email); 

                int filasAfectadas = cmdupdate.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Contraseña cambiada con éxito");
                }
                else
                {
                    MessageBox.Show("No existe un usuario con ese email");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la contraseña: " + ex);
            }
            finally 
            {
                conexionDB.Close();
            }
          

            /*if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(newPass) || string.IsNullOrWhiteSpace(confirmPass))
            {
                MessageBox.Show("Complete todos los campos por favor");

            }*/
        }

        private void return_login_Click(object sender, EventArgs e)
        {
            Login login_form = new Login();
            login_form.Show(); //abre de vuelta el form de iniciar sesion
            this.Hide(); // quitamos el form de actualizar contraseña
        }

        private void UpdatePassword_Load(object sender, EventArgs e)
        {

        }

        private void update_newPass_user_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void update_confirmPass_user_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void update_password_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexionDB.Open();

                string email = update_email_user.Text.Trim();
                string newPass = update_newPass_user.Text.Trim();
                string confirmPass = update_confirmPass_user.Text.Trim();

                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(newPass) || string.IsNullOrWhiteSpace(confirmPass))
        {
                    MessageBox.Show("Complete todos los campos por favor");
                    return;
                }

                if (newPass != confirmPass)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    return;
                }

                string hashedPass = Utils.HashPassword(confirmPass);

                string queryupdate = "UPDATE users SET password_hash = @updatepassword WHERE email = @useremail";
                MySqlCommand cmdupdate = new MySqlCommand(queryupdate, conexionDB);
                cmdupdate.Parameters.AddWithValue("@updatepassword", hashedPass);
                cmdupdate.Parameters.AddWithValue("@useremail", email);

                int filasAfectadas = cmdupdate.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Contraseña cambiada con éxito");
                }
                else
                {
                    MessageBox.Show("No existe un usuario con ese email");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la contraseña: " + ex);
            }
            finally
            {
                conexionDB.Close();
            }
        }

        private void update_confirmPass_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void return_login_Click_1(object sender, EventArgs e)
        {
            Login login_form = new Login();
            login_form.Show(); //abre de vuelta el form de iniciar sesion
            this.Hide(); // quitamos el form de actualizar contraseña
        }

        private void update_confirmPass_user_DoubleClick_1(object sender, EventArgs e)
        {
            update_confirmPass_user.UseSystemPasswordChar = !update_confirmPass_user.UseSystemPasswordChar;
        }

        private void update_newPass_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_newPass_user_DoubleClick_1(object sender, EventArgs e)
        {

            update_newPass_user.UseSystemPasswordChar = !update_newPass_user.UseSystemPasswordChar;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
