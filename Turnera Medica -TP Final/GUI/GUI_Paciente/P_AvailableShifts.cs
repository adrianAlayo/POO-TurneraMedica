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

        private void P_AvailableShifts_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_shifts_result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                conexionDB.Open();

                int idoffice;
                List<int> idmedics = new List<int>();

                string searchofficeid = "SELECT id FROM offices WHERE name = @nameoffice";
                MySqlCommand cmdidoffice = new MySqlCommand(searchofficeid, conexionDB);
                cmdidoffice.Parameters.AddWithValue("@nameoffice", office);

                MySqlDataReader read1 = cmdidoffice.ExecuteReader();

                if (read1.Read()) 
                {
                    idoffice = Convert.ToInt32(read1["id"]);
                }
                read1.Close();

                string searchidmedics = "SELECT id FROM medics WHERE speciality = @specialitysearch";
                MySqlCommand cmdidmedics = new MySqlCommand (searchidmedics, conexionDB);
                cmdidmedics.Parameters.AddWithValue("@specialitysearch", speciality);

                MySqlDataReader read2 = cmdidmedics.ExecuteReader();

                if (read2.Read()) 
                {
                    idmedics.Add(Convert.ToInt32 (read2["id"]));
                }

                string searchshifts = "SELECT * FROM shifts WHERE medic_id = @medicsids, patient_id = null, shift_date = @shiftdate AND state = libre";
                MySqlCommand cmdshifts = new MySqlCommand (searchshifts, conexionDB);
                cmdshifts.Parameters.AddWithValue("@medicsids", idmedics);
                cmdshifts.Parameters.AddWithValue("shiftdate", dateshift);

                MySqlDataReader read3 = cmdshifts.ExecuteReader();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al buscar turnos: " + ex);
            }
        }
    }
}
