using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        MySqlConnection conexionDB = Connection.conexion();
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
            string nombre = registerM_name_user.Text.Trim();
            string apellido = registerM_lastName_user.Text.Trim();
            string dni = registerM_dni_user.Text.Trim();
            string telefono = registerM_numberPhone_user.Text.Trim();
            string email = registerM_email_user.Text.Trim();
            string password = registerM_password_user.Text.Trim();
            string confirmar = registerM_confirPassword_user.Text.Trim();
            string especialidad = registerM_especialty_user.Text.Trim();
            string montoConsulta = registerM_montConsul_user.Text.Trim();
            string consultorio = registerM_office_user.Text.Trim();
            string obraSocial = registerM_socialWork_user.Text.Trim();
            string horaEntrada = registerM_entryTime_user.Text.Trim();
            string horaSalida = registerM_departureTime_user.Text.Trim();

            if (password != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            try
            {
                conexionDB.Open();

                string hash = Utils.HashPassword(password);

                // Insertar en tabla users
                string insertUser = "INSERT INTO users (dni, nombre, apellido, email, numero_tel, password_hash, rol) VALUES (@dni, @nombre, @apellido, @correo, @telefono, @password, 'medico')";
                MySqlCommand cmdUser = new MySqlCommand(insertUser, conexionDB);
                cmdUser.Parameters.AddWithValue("@dni", dni);
                cmdUser.Parameters.AddWithValue("@nombre", nombre);
                cmdUser.Parameters.AddWithValue("@apellido", apellido);
                cmdUser.Parameters.AddWithValue("@correo", email);
                cmdUser.Parameters.AddWithValue("@telefono", telefono);
                cmdUser.Parameters.AddWithValue("@password", hash);
                cmdUser.ExecuteNonQuery();

                int userId = (int)cmdUser.LastInsertedId;

                // Insertar en tabla medicos
                string insertMedico = "INSERT INTO medicos (user_id, especialidad, monto_consulta) VALUES (@userId, @especialidad, @monto)";
                MySqlCommand cmdMedico = new MySqlCommand(insertMedico, conexionDB);
                cmdMedico.Parameters.AddWithValue("@userId", userId);
                cmdMedico.Parameters.AddWithValue("@especialidad", especialidad);
                cmdMedico.Parameters.AddWithValue("@monto", montoConsulta);
                cmdMedico.ExecuteNonQuery();

                int medicoId = (int)cmdMedico.LastInsertedId;

                // Insertar consultorio asignado (simplificado)
                string insertConsultorio = "INSERT INTO medico_consultorio_asignado (medico_id, consultorio_id, horario_desde, horario_hasta) VALUES (@medico, 1, @desde, @hasta)";
                MySqlCommand cmdConsul = new MySqlCommand(insertConsultorio, conexionDB);
                cmdConsul.Parameters.AddWithValue("@medico", medicoId);
                cmdConsul.Parameters.AddWithValue("@desde", horaEntrada);
                cmdConsul.Parameters.AddWithValue("@hasta", horaSalida);
                cmdConsul.ExecuteNonQuery();

                // Insertar obra social (si no existe la crea)
                string getObra = "SELECT id FROM obras_sociales WHERE nombre = @obra LIMIT 1";
                MySqlCommand cmdGetObra = new MySqlCommand(getObra, conexionDB);
                cmdGetObra.Parameters.AddWithValue("@obra", obraSocial);
                object result = cmdGetObra.ExecuteScalar();

                int obraId;

                if (result == null)
                {
                    string insertObra = "INSERT INTO obras_sociales (nombre) VALUES (@obra)";
                    MySqlCommand cmdInsertObra = new MySqlCommand(insertObra, conexionDB);
                    cmdInsertObra.Parameters.AddWithValue("@obra", obraSocial);
                    cmdInsertObra.ExecuteNonQuery();
                    obraId = (int)cmdInsertObra.LastInsertedId;
                }
                else
                {
                    obraId = Convert.ToInt32(result);
                }

                string insertMedicoObra = "INSERT INTO medico_obra_social (medico_id, obra_social_id) VALUES (@medico, @obra)";
                MySqlCommand cmdMedObra = new MySqlCommand(insertMedicoObra, conexionDB);
                cmdMedObra.Parameters.AddWithValue("@medico", medicoId);
                cmdMedObra.Parameters.AddWithValue("@obra", obraId);
                cmdMedObra.ExecuteNonQuery();

                MessageBox.Show("Registro de médico completado correctamente.");

                PreRegister pre = new PreRegister();
                pre.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar médico: " + ex.Message);
            }
            finally
            {
                conexionDB.Close();
            }

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
