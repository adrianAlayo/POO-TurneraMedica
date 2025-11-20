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

namespace Turnera_Medica__TP_Final.GUI.GUI_Paciente
{
    public partial class P_AvailableShifts : Form
    {
        private Patient userpatient {  get; set; }
        string dateshift { get; set; }
        string office {  get; set; }
        string speciality { get; set; }
        public P_AvailableShifts(Patient userpatient, string dateshift, string office, string speciality)
        {
            InitializeComponent();
            this.userpatient = userpatient;
            this.dateshift = dateshift;
            this.office = office;
            this.speciality = speciality;
        }
        MySqlConnection conexionDB = Connection.conexion();

        private void return_start_P_Click(object sender, EventArgs e)
        {
            P_AvailableShiftsForm p_available_shiftform_form = new P_AvailableShiftsForm(userpatient);
            p_available_shiftform_form.Show(); //abre de vuelta el form del formulario para ver los turnos disponibles
            this.Hide(); // quitamos el form de ver turnos disponibles 
        }
        private int GetOfficeId(string officeName)
        {
            using (var conexionDB = Connection.conexion())
            {
                conexionDB.Open();
                string query = "SELECT id FROM offices WHERE ubication = @o";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                cmd.Parameters.AddWithValue("@o", officeName);

                var read = cmd.ExecuteReader();
                if (read.Read()) return Convert.ToInt32(read["id"]);
            }
            return -1;
        }

        private int GetSpecialityId(string speciality)
        {
            using (var conexionDB = Connection.conexion())
            {
                conexionDB.Open();
                string query = "SELECT id FROM specialities WHERE name = @speciality_name";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                cmd.Parameters.AddWithValue("@speciality_name", speciality);

                var read = cmd.ExecuteReader();
                if (read.Read()) return Convert.ToInt32(read["id"]);
            }
            return -1;
        }


        private void loadAvailableShifts()
        {
            DateTime d = DateTime.Parse(dateshift);

            // Obtener IDs
            int officeId = GetOfficeId(office);
            int specialityId = GetSpecialityId(speciality);

            List<Shift> shifts = userpatient.AvailableShifts(d, officeId, specialityId);

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Médico");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Hora");
            dt.Columns.Add("Duración");
            dt.Columns.Add("Estado");

            foreach (var shift in shifts)
            {
                dt.Rows.Add(
                    shift.Id,
                    $"{shift.Assigned_Doctor.Name} {shift.Assigned_Doctor.LastName}",
                    shift.Date.ToShortDateString(),
                    shift.Hour.ToString(@"hh\:mm"),
                    shift.Duration,
                    shift.State.ToString()
                );
            }

            dataGridView_shifts_result.DataSource = dt;
            dataGridView_shifts_result.Columns["ID"].Visible = false;
        }



        private void P_AvailableShifts_Load(object sender, EventArgs e)
        {
            loadAvailableShifts();
        }

        private void dataGridView_shifts_result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void take_turn_P_Click(object sender, EventArgs e)
        {
            if (dataGridView_shifts_result.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un turno.");
                return;
            }

            int shiftId = Convert.ToInt32(
                dataGridView_shifts_result.SelectedRows[0].Cells["ID"].Value
            );

            bool ok = userpatient.RequestAppointment(shiftId);

            if (ok)
            {
                MessageBox.Show("Turno reservado con éxito.");
                loadAvailableShifts();
            }
            else
            {
                MessageBox.Show("El turno ya no está disponible.");
            }
        }


    }
}
