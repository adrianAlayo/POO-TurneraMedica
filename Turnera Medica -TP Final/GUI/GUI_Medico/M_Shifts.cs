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
        private Medic usermedic { get; set; }
        public M_Shifts(Medic usermedic)
        {
            InitializeComponent();
            this.usermedic = usermedic;
        }
        MySqlConnection conexionDB = Connection.conexion();

        private void return_start_M_Click(object sender, EventArgs e)
        {
            M_Start m_start_form = new M_Start(usermedic);
            m_start_form.Show(); //abre de vuelta el form de inicio del medico
            this.Hide(); // quitamos el form de ver todos los turnos
        }

        private void M_Shifts_Load(object sender, EventArgs e)
        {
            M_name_user_guia.Text += " " + usermedic.Name + " " + usermedic.LastName;
            usermedic.Shifts(); // carga la lista interna

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
            

            M_Shifts_list.DataSource = dt;
        }

        private void M_Shifts_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
