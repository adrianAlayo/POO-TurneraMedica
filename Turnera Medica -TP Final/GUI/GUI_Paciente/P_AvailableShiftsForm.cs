using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Turnera_Medica__TP_Final.Controller;

namespace Turnera_Medica__TP_Final.GUI.GUI_Paciente
{
    public partial class P_AvailableShiftsForm : Form
    {
        private Patient userpatient { get; set; }
        public P_AvailableShiftsForm(Patient userpatient)
        {
            InitializeComponent();
            this.userpatient = userpatient;
        }
        MySqlConnection conexionDB = Connection.conexion();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void P_AvailableShiftsForm_Load(object sender, EventArgs e)
        {
            P_name_user_guia.Text += " " + userpatient.Name + " " + userpatient.LastName;
        }

        private void ReturnPreRegister_Click(object sender, EventArgs e)
        {
            P_Start p_start_form = new P_Start(userpatient);  // Abre el menú del paciente
            p_start_form.Show();
            this.Hide(); 
        }


        private void login_email_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelectSpeciality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchShift_Send_Click(object sender, EventArgs e)
        {
            try
            {
                conexionDB.Open();

                string dateshift = selectDate.Text.Trim();
                string speciality = SelectSpeciality.Text.Trim();
                string office = selectOffice.Text.Trim();

                P_AvailableShifts p_availableshifts = new P_AvailableShifts(userpatient, dateshift, office, speciality);  // Abre la otra ventana de turnos
                p_availableshifts.Show();
                this.Hide();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al buscar un turno: " + ex);
            }
            finally 
            {
                conexionDB.Close();
            }
            
        }

        private void selectDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void selectOffice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime selectedDate = selectDate.Value.Date;
            if (selectedDate.DayOfWeek == DayOfWeek.Saturday || selectedDate.DayOfWeek == DayOfWeek.Sunday)
            {
                e.Cancel = true; // Cancela la selección
                MessageBox.Show("No se permiten fines de semana.");
            }
        }

        private void SendLogin_Click(object sender, EventArgs e)
        {
            Login login_form = new Login();
            login_form.Show(); // Abro la pantalla de login
            this.Hide();
        }
    }
}
