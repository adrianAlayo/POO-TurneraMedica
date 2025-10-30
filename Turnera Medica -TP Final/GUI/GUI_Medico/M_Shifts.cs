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
            try
            {
                conexionDB.Open();
                string objecMedico = "1";

                string query = "SELECT * FROM turnos WHERE medico_id = @1";

                MySqlCommand codigo = new MySqlCommand(query, conexionDB);
                codigo.Parameters.AddWithValue("@1", objecMedico);

                MySqlDataReader read = codigo.ExecuteReader();

                if (read.Read())
                {
                    
                }
                else
                {
                    MessageBox.Show("Lamento informarle que usted no tiene Turnos Disponibles por el momento");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !!! al mostrar el listado de los turnos: " + ex.Message);

            }
            finally
            {
                conexionDB.Close();
            }
        }
    }
}
