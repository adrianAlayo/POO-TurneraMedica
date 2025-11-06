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
                conexionDB.Open();

                string email = login_email_user.Text.Trim();
                string password = login_password_user.Text.Trim();

                // aca buscamons al usuario en la base de datos
                string querylogin = "SELECT * FROM users WHERE email = @Email AND password_hash = @Password";

                MySqlCommand cmdlogin = new MySqlCommand(querylogin, conexionDB);
                cmdlogin.Parameters.AddWithValue("@Email", email);
                cmdlogin.Parameters.AddWithValue("@Password", password);

                using (MySqlDataReader read = cmdlogin.ExecuteReader())
                {
                    if (!read.Read())
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta.");
                        return;
                    }

                    string roluser = read["rol"].ToString().Trim();
                    int iduser = Convert.ToInt32(read["id"]);
                    int dni = Convert.ToInt32(read["dni"]);
                    string name = read["name"].ToString().Trim();
                    string lastname = read["last_name"].ToString().Trim();
                    string emailUser = read["email"].ToString().Trim();
                    string telephone = read["telephone_number"].ToString().Trim();
                    string passwordHash = read["password_hash"].ToString().Trim();

                    read.Close(); // Cerramos este reader antes de abrir otro

                    // logica para usuario si es medico
                    if (roluser == "medico")
                    {
                        // Obtener info del médico
                        string queryMedico = "SELECT * FROM medics WHERE user_id = @userid";
                        MySqlCommand cmdMedico = new MySqlCommand(queryMedico, conexionDB);
                        cmdMedico.Parameters.AddWithValue("@userid", iduser);

                        int idmedic;
                        string speciality;
                        double consultamount;

                        using (MySqlDataReader read2 = cmdMedico.ExecuteReader())
                        {
                            if (read2.Read())
                            {
                                idmedic = Convert.ToInt32(read2["id"]);
                                speciality = read2["speciality"].ToString().Trim();
                                consultamount = Convert.ToDouble(read2["consult_amount"]);
                            }
                            else
                            {
                                MessageBox.Show("No se encontró información del médico.");
                                return;
                            }
                        }

                        // Obtener office_id desde assigned_doctors_office
                        string queryOffice = "SELECT office_id FROM assigned_doctors_office WHERE medic_id = @medicid";
                        MySqlCommand cmdOffice = new MySqlCommand(queryOffice, conexionDB);
                        cmdOffice.Parameters.AddWithValue("@medicid", idmedic);

                        int officeId;
                        using (MySqlDataReader read3 = cmdOffice.ExecuteReader())
                        {
                            if (read3.Read())
                            {
                                officeId = Convert.ToInt32(read3["office_id"]);
                            }
                            else
                            {
                                MessageBox.Show("El médico no tiene consultorio asignado.");
                                return;
                            }
                        }

                        // Crear objeto del médico y abrir interfaz
                        Medic usermedic = new Medic(
                            idmedic,
                            dni,
                            name,
                            lastname,
                            emailUser,
                            telephone,
                            passwordHash,
                            speciality,
                            consultamount,
                            officeId
                        );

                        M_Start mStartForm = new M_Start(usermedic);
                        mStartForm.Show();
                        this.Hide();
                    }

                    // 🔹 Lógica para paciente
                    else if (roluser == "paciente")
                    {
                        string queryPaciente = "SELECT * FROM patient WHERE user_id = @userid";
                        MySqlCommand cmdPaciente = new MySqlCommand(queryPaciente, conexionDB);
                        cmdPaciente.Parameters.AddWithValue("@userid", iduser);

                        using (MySqlDataReader read4 = cmdPaciente.ExecuteReader())
                        {
                            if (read4.Read())
                            {
                                Patient userpatient = new Patient(
                                    Convert.ToInt32(read4["id"]),
                                    dni,
                                    name,
                                    lastname,
                                    emailUser,
                                    telephone,
                                    passwordHash,
                                    Convert.ToInt32(read4["social_work_id"])
                                );

                                P_Start pStartForm = new P_Start(userpatient);
                                pStartForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró información del paciente.");
                            }
                        }
                    }

                    // SI tiene otro rol que no es reconocido
                    else
                    {
                        MessageBox.Show("Rol desconocido. Contacte al administrador.");
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al iniciar sesion:" + ex.Message);
            }
            finally 
            { 
                conexionDB.Close(); 
            }
            /*
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
                MySqlDataReader read = codigo.ExecuteReader();

                // Si encontró un usuario, entra al if
                if (read.Read())
                {
                    // Leo el rol del usuario (medico o paciente)
                    string rolUsuario = read["rol"].ToString().Trim();

                    // Si el rol es médico, abre la interfaz del médico
                    if (rolUsuario == "medico")
                    {
                        int userId_m = Convert.ToInt32(read["id"]);
                        int dni_m = Convert.ToInt32(read["dni"]);
                        string name_m = read["nombre"].ToString();
                        string lastName_m = read["apellido"].ToString();
                        string email_m = read["email"].ToString();
                        string tel_m = read["numero_tel"].ToString();
                        string password_m = read["password_hash"].ToString();

                        // Obtener datos de la tabla medicos
                        string queryMedico = "SELECT * FROM medicos WHERE user_id = @userId";
                        MySqlCommand cmdMed = new MySqlCommand(queryMedico, conexionDB);
                        cmdMed.Parameters.AddWithValue("@userId", userId_m);
                        MySqlDataReader leerMed = cmdMed.ExecuteReader();
                        if (leerMed.Read())
                        {
                            string specialty = leerMed["especialidad"].ToString();
                            double consultationAmount = Convert.ToDouble(leerMed["monto_consulta"]);
                            Medico currentUser = new Medico(userId_m, dni_m, name_m, lastName_m, email_m, tel_m, password_m, specialty, consultationAmount, null);

                            // Ahora puedes pasar currentUser a M_Start
                            M_Start mStartForm = new M_Start(currentUser);
                            mStartForm.Show();
                            this.Hide();
                        }
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
            */
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
