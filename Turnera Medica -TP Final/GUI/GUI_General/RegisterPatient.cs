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
    public partial class RegisterPatient : Form
    {
        public RegisterPatient()
        {
            InitializeComponent();
        }
        MySqlConnection conexionDB = Connection.conexion();

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
            string nombre = registerP_name_user.Text.Trim();
            string apellido = registerP_lastName_user.Text.Trim();
            string dni = registerP_dni_user.Text.Trim();
            string telefono = registerP_numberPhone_user.Text.Trim();
            string email = registerP_email_user.Text.Trim();
            string password = registerP_password_user.Text.Trim();
            string confirmar = registerP_confirPassword_user.Text.Trim();
            string obraSocial = registerP_socialWork_user.Text.Trim();

            if (password != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            try
            {
                conexionDB.Open();
                string hash = Utils.HashPassword(password);

                // Insertar usuario
                string insertUser = "INSERT INTO users (dni, nombre, apellido, email, numero_tel, password_hash, rol) VALUES (@dni, @nombre, @apellido, @correo, @telefono, @password, 'paciente')";
                MySqlCommand cmdUser = new MySqlCommand(insertUser, conexionDB);
                cmdUser.Parameters.AddWithValue("@dni", dni);
                cmdUser.Parameters.AddWithValue("@nombre", nombre);
                cmdUser.Parameters.AddWithValue("@apellido", apellido);
                cmdUser.Parameters.AddWithValue("@correo", email);
                cmdUser.Parameters.AddWithValue("@telefono", telefono);
                cmdUser.Parameters.AddWithValue("@password", hash);
                cmdUser.ExecuteNonQuery();

                int userId = (int)cmdUser.LastInsertedId;

                // Obtener o crear obra social
                string getObra = "SELECT id FROM obras_sociales WHERE nombre = @obra LIMIT 1";
                MySqlCommand cmdGetObra = new MySqlCommand(getObra, conexionDB);
                cmdGetObra.Parameters.AddWithValue("@obra", obraSocial);
                object result = cmdGetObra.ExecuteScalar();

                int obraId = 0;
                if (result == null && !string.IsNullOrEmpty(obraSocial))
                {
                    string insertObra = "INSERT INTO obras_sociales (nombre) VALUES (@obra)";
                    MySqlCommand cmdInsertObra = new MySqlCommand(insertObra, conexionDB);
                    cmdInsertObra.Parameters.AddWithValue("@obra", obraSocial);
                    cmdInsertObra.ExecuteNonQuery();
                    obraId = (int)cmdInsertObra.LastInsertedId;
                }
                else if (result != null)
                {
                    obraId = Convert.ToInt32(result);
                }

                //  Insertar paciente
                string insertPaciente = "INSERT INTO pacientes (user_id, obra_social_id) VALUES (@user, @obra)";
                MySqlCommand cmdPac = new MySqlCommand(insertPaciente, conexionDB);
                cmdPac.Parameters.AddWithValue("@user", userId);
                if (obraId != 0)
                    cmdPac.Parameters.AddWithValue("@obra", obraId);
                else
                    cmdPac.Parameters.AddWithValue("@obra", DBNull.Value);

                cmdPac.ExecuteNonQuery();

                MessageBox.Show("Registro de paciente completado correctamente.");

                PreRegister pre = new PreRegister();
                pre.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar paciente: " + ex.Message);
            }
            finally
            {
                conexionDB.Close();
            }

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
