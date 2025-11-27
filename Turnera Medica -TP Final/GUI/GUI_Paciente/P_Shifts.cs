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
    public partial class P_Shifts : Form
    {
        private Patient userpatient { get; set; }
        public P_Shifts(Patient userpatient)
        {
            InitializeComponent();
            this.userpatient = userpatient;
        }

        private void return_start_P_Click(object sender, EventArgs e)
        {
            P_Start p_start_form = new P_Start(userpatient);
            p_start_form.Show(); //abre de vuelta el form del inicio de paciente
            this.Hide(); // quitamos el form de ver todos los turnos
        }

        private void LoadTable() 
        {
            userpatient.Shifts();

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
                string medico = $"{shift.Assigned_Doctor.Name} {shift.Assigned_Doctor.LastName}";
                string office = shift.OfficeAssigned.Ubication;

                dt.Rows.Add(
                    shift.Date.ToShortDateString(),
                    shift.Hour.ToString(@"hh\:mm"),
                    shift.Duration,
                    shift.OriginalPrice,
                    shift.State.ToString(),
                    medico,
                    office
                );
            }

            P_Shifts_list.DataSource = dt;
        }
        private void P_Shifts_Load(object sender, EventArgs e)
        {
            LoadTable();
            P_name_user_guia.Text += " " + userpatient.Name + " " + userpatient.LastName;
        }

        private void P_Shifts_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
