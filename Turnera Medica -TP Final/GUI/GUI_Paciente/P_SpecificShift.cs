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

namespace Turnera_Medica__TP_Final.GUI.GUI_Paciente
{
    public partial class P_SpecificShift : Form
    {
        private Patient userpatient {  get; set; }
        public P_SpecificShift(Patient userpatient)
        {
            InitializeComponent();
            this.userpatient = userpatient;
        }

        private void P_SpecificShift_Load(object sender, EventArgs e)
        {
            P_name_user_guia.Text += " " + userpatient.Name + " " + userpatient.LastName;
        }

        private void return_start_P_Click(object sender, EventArgs e)
        {
            P_Start p_start_form = new P_Start(userpatient);
            p_start_form.Show(); //abre de vuelta el form del inicio de paciente
            this.Hide(); // quitamos el form de ver todos los turnos
        }

        private void selectDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void searchShift_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = selectDate.Value.Date;

            // Llamada OOP
            userpatient.specificShift(selectedDate);

            // Armar tabla
            DataTable dt = new DataTable();

            dt.Columns.Add("Fecha");
            dt.Columns.Add("Hora");
            dt.Columns.Add("Duración");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Estado");
            dt.Columns.Add("Médico");
            dt.Columns.Add("Consultorio");

            foreach (var shift in userpatient.listTurno)
            {
                dt.Rows.Add(
                    shift.Date.ToShortDateString(),
                    shift.Hour.ToString(@"hh\:mm"),
                    shift.Duration,
                    shift.OriginalPrice,
                    shift.State.ToString(),
                    $"{shift.Assigned_Doctor.Name} {shift.Assigned_Doctor.LastName}",
                    shift.OfficeAssigned.Ubication
                );
            }

            P_SpecificShift_list.DataSource = dt;
        }


        private void P_SpecificShift_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SendLogin_Click(object sender, EventArgs e)
        {
            Login login_form = new Login();
            login_form.Show(); // Abro la pantalla de login
            this.Hide();
        }
    }
}
