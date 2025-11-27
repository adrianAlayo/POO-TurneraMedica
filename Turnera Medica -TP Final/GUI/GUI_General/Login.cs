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

                //traemos la informacion de los textboxs y los guardamos en variables
                string email = login_email_user.Text.Trim();
                string password = login_password_user.Text.Trim();

                string hashedPassword = Utils.HashPassword(password); //hasheamos la contraseña

                // aca buscamons al usuario en la base de datos
                string querylogin = "SELECT * FROM users WHERE email = @Email AND password_hash = @Password";

                MySqlCommand cmdlogin = new MySqlCommand(querylogin, conexionDB); //creamos un comando para ejecutar la query
                cmdlogin.Parameters.AddWithValue("@Email", email);
                cmdlogin.Parameters.AddWithValue("@Password", hashedPassword);

                using (MySqlDataReader read = cmdlogin.ExecuteReader())
                {
                    if (!read.Read())
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta.");
                        return;
                    }

                    //guardamos los datos del usuario en variables
                    string roluser = read["rol"].ToString().Trim();
                    int iduser = Convert.ToInt32(read["id"]);
                    int dni = Convert.ToInt32(read["dni"]);
                    string name = read["name"].ToString().Trim();
                    string lastname = read["last_name"].ToString().Trim();
                    int age = Convert.ToInt32(read["age"]);
                    string emailUser = read["email"].ToString().Trim();
                    string telephone = read["telephone_number"].ToString().Trim();
                    string passwordHash = read["password_hash"].ToString().Trim();

                    read.Close(); // cerramos este reader antes de abrir otro

                    // logica para usuario si es medico
                    if (roluser == "medico")
                    {
                        // hacemos una query para obtener la info del medico
                        string queryMedico = "SELECT * FROM medics WHERE user_id = @userid";
                        MySqlCommand cmdMedico = new MySqlCommand(queryMedico, conexionDB);
                        cmdMedico.Parameters.AddWithValue("@userid", iduser);

                        int idmedic;   //creamos unas variables para guardar datos de la tabla medics de nuestro medico
                        int idspeciality;
                        double consultamount;
                        TimeSpan entryTime;
                        TimeSpan departureTime;

                        using (MySqlDataReader read2 = cmdMedico.ExecuteReader()) //ejecutamos el reader 
                        {
                            if (read2.Read()) //guardamos los resultados en las variables que creamos anteriormente
                            {
                                idmedic = Convert.ToInt32(read2["id"]);
                                idspeciality = Convert.ToInt32(read2["speciality_id"]);
                                consultamount = Convert.ToDouble(read2["consult_amount"]);
                                entryTime = (TimeSpan)read2["entry_time"];
                                departureTime = (TimeSpan)read2["departure_time"];
                            }
                            else 
                            {
                                MessageBox.Show("No se encontró información del médico.");
                                return;
                            }
                        }

                        // ahora hacemos una query para obtener el office_id donde trabaja el medico de la tabla assigned_doctors_office
                        string queryOffice = "SELECT office_id FROM assigned_doctors_office WHERE medic_id = @medicid";
                        MySqlCommand cmdOffice = new MySqlCommand(queryOffice, conexionDB);
                        cmdOffice.Parameters.AddWithValue("@medicid", idmedic);

                        int officeId; //creamos la variable donde guardaremos el office_id
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

                        // creamos el objeto medico y le ponemos todos los datos que pide 
                        Medic usermedic = new Medic(
                            idmedic,
                            dni,
                            name,
                            lastname,
                            age,
                            emailUser,
                            telephone,
                            passwordHash,
                            idspeciality,
                            consultamount,
                            officeId,
                            entryTime,
                            departureTime
                        );
                        usermedic.Login();
                        M_Start mStartForm = new M_Start(usermedic);
                        mStartForm.Show();
                        this.Hide();
                    }

                    // logica para el usuario si es paciente
                    else if (roluser == "paciente")
                    {
                        string queryPaciente = "SELECT * FROM patients WHERE user_id = @userid";
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
                                    age,
                                    emailUser,
                                    telephone,
                                    passwordHash,
                                    Convert.ToInt32(read4["social_work_id"])
                                );
                                userpatient.Login();
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

        private void login_password_user_DoubleClick(object sender, EventArgs e)
        {
            login_password_user.UseSystemPasswordChar = !login_password_user.UseSystemPasswordChar;
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
