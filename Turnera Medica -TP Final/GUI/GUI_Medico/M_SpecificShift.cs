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

        private void M_SpecificShift_Load(object sender, EventArgs e)
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

        private void M_SpecificShift_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void selectDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void searchShifts_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = selectDate.Value.Date;

            // Actualiza lista según la fecha
            usermedic.specificShift(selectedDate);

            // Cargar en tabla
            DataTable dt = new DataTable();
            
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Hora");
            dt.Columns.Add("Duración");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Estado");
            dt.Columns.Add("Paciente");

            foreach (var column in usermedic.listTurno)
            {
                string paciente = column.PatientAssigned != null
                    ? $"{column.PatientAssigned.Name} {column.PatientAssigned.LastName}"
                    : "";

                dt.Rows.Add(
                    column.Date.ToShortDateString(),
                    column.Hour.ToString(@"hh\:mm"),
                    column.Duration,
                    column.OriginalPrice,
                    column.State.ToString(),
                    paciente
                );
            }

            M_SpecificShift_list.DataSource = dt;
        }
    }
}
