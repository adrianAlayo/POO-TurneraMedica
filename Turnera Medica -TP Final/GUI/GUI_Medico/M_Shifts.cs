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

namespace Turnera_Medica__TP_Final.GUI.GUI_Medico
{
    public partial class M_Shifts : Form
    {
        public M_Shifts()
        {
            InitializeComponent();
        }
        MySqlConnection conexionDB = Connection.conexion();

        private void return_start_M_Click(object sender, EventArgs e)
        {
            M_Start m_start_form = new M_Start();
            m_start_form.Show(); //abre de vuelta el form de inicio del medico
            this.Hide(); // quitamos el form de ver todos los turnos
        }

        private void M_Shifts_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void M_Shfts_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                conexionDB.Open();

                string query = "SELECT * FROM turnos WHERE medico_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                cmd.Parameters.AddWithValue("@id", 1);

                // Creamos el adaptador y la tabla
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();

                // Llenamos la tabla con los datos que trajo el adaptador
                sda.Fill(table);

                // Enlazamos la tabla al DataGridView
                M_Shfts_list.DataSource = table;

                // Si querés ajustar el ancho automáticamente
                M_Shfts_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("No hay turnos disponibles por el momento.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el listado de los turnos: " + ex.Message);
            }
            finally
            {
                conexionDB.Close();
            }
        }
    }
}
