using Google.Protobuf.WellKnownTypes;
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

namespace Turnera_Medica__TP_Final.GUI.GUI_Medico
{
    public partial class M_SpecificShift : Form
    {
        private Medic usermedic { get; set; }
        public M_SpecificShift(Medic usermedic)
        {
            InitializeComponent();
            this.usermedic = usermedic;
        }

        private void return_start_M_Click(object sender, EventArgs e)
        {
            M_Start m_start_form = new M_Start(usermedic);
            m_start_form.Show(); //abre de vuelta el form de inicio del medico
            this.Hide(); // quitamos el form de ver turno especifico
        }
        private void LoadTable() 
        {
            DateTime selectedDate = selectDate.Value.Date;

            // obtiene turnos filtrados por fecha
            usermedic.specificShift(selectedDate);

            // carga tabla
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");              
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Hora");
            dt.Columns.Add("Duración");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Estado");
            dt.Columns.Add("Paciente");

            foreach (var shift in usermedic.listTurno)
            {
                string paciente = shift.PatientAssigned != null
                    ? $"{shift.PatientAssigned.Name} {shift.PatientAssigned.LastName}"
                    : "";

                dt.Rows.Add(
                    shift.Id,                      
                    shift.Date.ToShortDateString(),
                    shift.Hour.ToString(@"hh\:mm"),
                    shift.Duration,
                    shift.OriginalPrice,
                    shift.State.ToString(),
                    paciente
                );
            }

            M_SpecificShift_list.DataSource = dt;

            // ocultar columna id
            M_SpecificShift_list.Columns["ID"].Visible = false;
        }

        private void M_SpecificShift_Load(object sender, EventArgs e)
        {
            M_name_user_guia.Text += " " + usermedic.Name + " " + usermedic.LastName;
        }

        private void selectDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime selectedDate = selectDate.Value.Date;
            if (selectedDate.DayOfWeek == DayOfWeek.Saturday || selectedDate.DayOfWeek == DayOfWeek.Sunday)
            {
                e.Cancel = true; // cancela la seleccion
                MessageBox.Show("No se permiten fines de semana.");
            }
        }

        private void M_SpecificShift_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void selectDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void searchShifts_Click(object sender, EventArgs e)
        {
            LoadTable();
        }
        private int GetSelectedShiftId()
        {
            if (M_SpecificShift_list.SelectedRows.Count == 0)
            {
                return -1;
            }

            return Convert.ToInt32(M_SpecificShift_list.SelectedRows[0].Cells["ID"].Value);
        }

        private void attendedShift_Click(object sender, EventArgs e)
        {
            int shiftId = GetSelectedShiftId();

            if (shiftId == -1)
            {
                MessageBox.Show("Seleccione un turno primero.");
                return;
            }

            usermedic.UpdateShiftAttended(shiftId);

            MessageBox.Show("Turno marcado como ASISTIDO.");

            // refrescamos
            usermedic.specificShift(selectDate.Value.Date);
            LoadTable();
        }

        private void canceledShift_Click(object sender, EventArgs e)
        {
            int shiftId = GetSelectedShiftId();

            if (shiftId == -1)
            {
                MessageBox.Show("Seleccione un turno primero.");
                return;
            }

            usermedic.UpdateShiftCanceled(shiftId);

            MessageBox.Show("Turno CANCELADO correctamente.");

            // refrescar tabla
            usermedic.specificShift(selectDate.Value.Date);
            LoadTable();

        }

        private void SendLogin_Click(object sender, EventArgs e)
        {
            Login login_form = new Login();
            login_form.Show(); // Abro la pantalla de login
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
