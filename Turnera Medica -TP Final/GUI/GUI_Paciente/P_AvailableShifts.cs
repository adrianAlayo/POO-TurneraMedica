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

        private void loadAvailableShifts() 
        {
            try
            {
                conexionDB.Open();

                int idoffice = -1;
                int idmedic = -1;
                int idspeciality = -1;

                // 1) Buscar ID de la oficina
                string sqlOffice = "SELECT id FROM offices WHERE ubication = @office";
                MySqlCommand cmdOffice = new MySqlCommand(sqlOffice, conexionDB);
                cmdOffice.Parameters.AddWithValue("@office", office);

                var r1 = cmdOffice.ExecuteReader();
                if (r1.Read())
                    idoffice = Convert.ToInt32(r1["id"]);
                r1.Close();

                // 2) Buscar ID de la especialidad
                string sqlSpec = "SELECT id FROM specialities WHERE name = @spec";
                MySqlCommand cmdSpec = new MySqlCommand(sqlSpec, conexionDB);
                cmdSpec.Parameters.AddWithValue("@spec", speciality);

                var r2 = cmdSpec.ExecuteReader();
                if (r2.Read())
                    idspeciality = Convert.ToInt32(r2["id"]);
                r2.Close();

                // 3) Buscar ID del médico segun especialidad y oficina asignada
                string sqlMedic =
                    "SELECT m.id " +
                    "FROM medics m " +
                    "INNER JOIN assigned_doctors_office ado ON ado.medic_id = m.id " +
                    "WHERE m.speciality_id = @spec AND ado.office_id = @office";

                MySqlCommand cmdMedic = new MySqlCommand(sqlMedic, conexionDB);
                cmdMedic.Parameters.AddWithValue("@spec", idspeciality);
                cmdMedic.Parameters.AddWithValue("@office", idoffice);

                var r3 = cmdMedic.ExecuteReader();
                if (r3.Read())
                    idmedic = Convert.ToInt32(r3["id"]);
                r3.Close();

                // 4) Cargar turnos disponibles (JOIN correcto con users)
                // 4) Buscar turnos disponibles con JOIN para obtener nombre del médico
                string searchshifts =
                    "SELECT " +
                    "s.id, " +
                    "CONCAT(u.name, ' ', u.last_name) AS medico, " +
                    "s.shift_date, " +
                    "s.shift_time, " +
                    "s.duration, " +
                    "s.state " +
                    "FROM shifts s " +
                    "INNER JOIN medics m ON s.medic_id = m.id " +
                    "INNER JOIN users u ON m.user_id = u.id " +
                    "WHERE s.medic_id = @idmedic " +
                    "AND s.patient_id IS NULL " +
                    "AND s.shift_date = @shiftdate " +
                    "AND s.state = 'libre'";


                MySqlCommand cmdshifts = new MySqlCommand(searchshifts, conexionDB);
                cmdshifts.Parameters.AddWithValue("@idmedic", idmedic);
                cmdshifts.Parameters.AddWithValue("@shiftdate", dateshift);

                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmdshifts);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                dataGridView_shifts_result.DataSource = dt;

                // Ocultar columnas internas
                dataGridView_shifts_result.Columns["id"].Visible = false;

                // Renombrar columnas visibles
                dataGridView_shifts_result.Columns["medico"].HeaderText = "Médico";
                dataGridView_shifts_result.Columns["shift_date"].HeaderText = "Fecha";
                dataGridView_shifts_result.Columns["shift_time"].HeaderText = "Hora";
                dataGridView_shifts_result.Columns["duration"].HeaderText = "Duración";
                dataGridView_shifts_result.Columns["state"].HeaderText = "Estado";

                dataGridView_shifts_result.DataSource = dt;

                conexionDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar turnos: " + ex.Message);
            }
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

            int shiftId = Convert.ToInt32(dataGridView_shifts_result.SelectedRows[0].Cells["id"].Value);

            try
            {
                conexionDB.Open();

                string sqlUpdate =
                    "UPDATE shifts " +
                    "SET state = 'programado', patient_id = @pid " +
                    "WHERE id = @sid AND state = 'libre' AND patient_id IS NULL";

                MySqlCommand cmd = new MySqlCommand(sqlUpdate, conexionDB);
                cmd.Parameters.AddWithValue("@pid", userpatient.Id);
                cmd.Parameters.AddWithValue("@sid", shiftId);

                int affected = cmd.ExecuteNonQuery();

                conexionDB.Close();

                if (affected > 0)
                {
                    MessageBox.Show("Turno reservado con éxito.");
                    loadAvailableShifts();
                }
                else
                {
                    MessageBox.Show("El turno ya no está disponible.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reservar turno: " + ex.Message);
            }
        }
    }
}
