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
            string name = registerP_name_user.Text.Trim();
            string last_name = registerP_lastName_user.Text.Trim();
            int age = Convert.ToInt32(registerP_age_user.Text.Trim());
            string dni = registerP_dni_user.Text.Trim();
            string telephone_number = registerP_numberPhone_user.Text.Trim();
            string email = registerP_email_user.Text.Trim();
            string password = registerP_password_user.Text.Trim();
            string confirmation = registerP_confirPassword_user.Text.Trim();
            string social_works = registerP_socialWork_user.Text.Trim();

            if (password != confirmation)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            try
            {
                conexionDB.Open();
                string hash = Utils.HashPassword(password);

                // Insertar usuario
                string insertUser = "INSERT INTO users (dni, name, last_name, age, email, telephone_number, password_hash, rol) VALUES (@dni, @name, @last_name, @age, @email, @telephone_number, @password, 'paciente')";
                MySqlCommand cmdUser = new MySqlCommand(insertUser, conexionDB);
                cmdUser.Parameters.AddWithValue("@dni", dni);
                cmdUser.Parameters.AddWithValue("@name", name);
                cmdUser.Parameters.AddWithValue("@last_name", last_name);
                cmdUser.Parameters.AddWithValue("@age", age);
                cmdUser.Parameters.AddWithValue("@email", email);
                cmdUser.Parameters.AddWithValue("@telephone_number", telephone_number);
                cmdUser.Parameters.AddWithValue("@password", hash);
                cmdUser.ExecuteNonQuery();

                int userId = (int)cmdUser.LastInsertedId;

                // Obtener o crear obra social
                string getObra = "SELECT id FROM social_works WHERE name = @obra LIMIT 1";
                MySqlCommand cmdGetObra = new MySqlCommand(getObra, conexionDB);
                cmdGetObra.Parameters.AddWithValue("@obra", social_works);
                object result = cmdGetObra.ExecuteScalar();

                int obraId = 0;
                if (result == null && !string.IsNullOrEmpty(social_works))
                {
                    string insertObra = "INSERT INTO social_works (name) VALUES (@obra)";
                    MySqlCommand cmdInsertObra = new MySqlCommand(insertObra, conexionDB);
                    cmdInsertObra.Parameters.AddWithValue("@obra", social_works);
                    cmdInsertObra.ExecuteNonQuery();
                    obraId = (int)cmdInsertObra.LastInsertedId;
                }
                else if (result != null)
                {
                    obraId = Convert.ToInt32(result);
                }

                //  Insertar paciente
                string insertPatient = "INSERT INTO patients (user_id, social_work_id) VALUES (@user, @obra)";
                MySqlCommand cmdPac = new MySqlCommand(insertPatient, conexionDB);
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
