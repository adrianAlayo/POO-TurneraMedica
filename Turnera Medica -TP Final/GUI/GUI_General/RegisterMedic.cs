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
            string name = registerM_name_user.Text.Trim();
            string last_name = registerM_lastName_user.Text.Trim();
            int age = Convert.ToInt32(registerM_age_user.Text.Trim());
            string dni = registerM_dni_user.Text.Trim();
            string telephone_number = registerM_numberPhone_user.Text.Trim();
            string email = registerM_email_user.Text.Trim();
            string password = registerM_password_user.Text.Trim();
            string confirmation = registerM_confirPassword_user.Text.Trim();
            string speciality = registerM_speciality_user.Text.Trim();
            string consult_amount = registerM_montConsul_user.Text.Trim();
            string offices = registerM_office_user.Text.Trim();
            string social_works = registerM_socialWork_user.Text.Trim();
            string timeEntry = registerM_entryTime_user.Text.Trim();
            string timeDeparture = registerM_departureTime_user.Text.Trim();

            if (password != confirmation)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            try
            {
                conexionDB.Open();

                string hash = Utils.HashPassword(password);

                // Insertar en tabla users
                string insertUser = "INSERT INTO users (dni, name, last_name, age, email, telephone_number, password_hash, rol) VALUES (@dni, @name, @last_name, @age, @email, @telephone_number, @password, 'medico')";
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

                string searchspecialityid = "SELECT id FROM specialities WHERE name = @speciality LIMIT 1";
                MySqlCommand cmdSpeciality = new MySqlCommand(searchspecialityid, conexionDB);
                cmdSpeciality.Parameters.AddWithValue("@speciality", speciality);

                MySqlDataReader read1 = cmdSpeciality.ExecuteReader();
                int specialityId = -1;

                if (read1.Read())
                {
                    specialityId = Convert.ToInt32(read1["id"]);
                }
                else
                {
                    read1.Close();
                    MessageBox.Show("La especialidad no existe.");
                    return;
                }
                read1.Close();

                // Insertar en tabla medicos
                string insertMedic = "INSERT INTO medics (user_id, speciality_id, consult_amount) VALUES (@userId, @specialityId, @mount)";
                MySqlCommand cmdMedic = new MySqlCommand(insertMedic, conexionDB);
                cmdMedic.Parameters.AddWithValue("@userId", userId);
                cmdMedic.Parameters.AddWithValue("@specialityId", specialityId);
                cmdMedic.Parameters.AddWithValue("@mount", consult_amount);
                cmdMedic.ExecuteNonQuery();

                int medicId = (int)cmdMedic.LastInsertedId;

                string searchofficeid = "SELECT id FROM offices WHERE ubication = @off LIMIT 1";
                MySqlCommand cmdOffice = new MySqlCommand(searchofficeid, conexionDB);
                cmdOffice.Parameters.AddWithValue("@off", offices);

                MySqlDataReader read2 = cmdOffice.ExecuteReader();
                int officeId = -1;

                if (read2.Read())
                { 
                    officeId = Convert.ToInt32(read2["id"]);
                }
                else
                {
                    read2.Close();
                    MessageBox.Show("El consultorio no existe.");
                    return;
                }
                read2.Close();

                // Insertar consultorio asignado (simplificado)
                string insertConsultation = "INSERT INTO assigned_doctors_office (medic_id, office_id, open_from, close_after) VALUES (@medic_id, @officeId, @open_from, @close_after)";
                MySqlCommand cmdConsul = new MySqlCommand(insertConsultation, conexionDB);
                cmdConsul.Parameters.AddWithValue("@medic_id", medicId);
                cmdConsul.Parameters.AddWithValue("@officeId", officeId);
                cmdConsul.Parameters.AddWithValue("@open_from", timeEntry);
                cmdConsul.Parameters.AddWithValue("@close_after", timeDeparture);
                cmdConsul.ExecuteNonQuery();

                // Insertar obra social (si no existe la crea)
                string getObra = "SELECT id FROM social_works WHERE name = @obra LIMIT 1";
                MySqlCommand cmdGetObra = new MySqlCommand(getObra, conexionDB);
                cmdGetObra.Parameters.AddWithValue("@obra", social_works);
                object result = cmdGetObra.ExecuteScalar();

                int obraId;

                if (result == null)
                {
                    string insertObra = "INSERT INTO social_works (name) VALUES (@obra)";
                    MySqlCommand cmdInsertObra = new MySqlCommand(insertObra, conexionDB);
                    cmdInsertObra.Parameters.AddWithValue("@obra", social_works);
                    cmdInsertObra.ExecuteNonQuery();
                    obraId = (int)cmdInsertObra.LastInsertedId;
                }
                else
                {
                    obraId = Convert.ToInt32(result);
                }

                string medic_social_work = "INSERT INTO medic_social_work (medic_id, social_work_id) VALUES (@medic, @obraId)";
                MySqlCommand cmdMedObra = new MySqlCommand(medic_social_work, conexionDB);
                cmdMedObra.Parameters.AddWithValue("@medic", medicId);
                cmdMedObra.Parameters.AddWithValue("@obraId", obraId);
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

        private void registerM_speciality_user_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registerM_office_user_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void registerM_departureTime_user_ValueChanged(object sender, EventArgs e)
        {

        }

        private void registerM_entryTime_user_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
