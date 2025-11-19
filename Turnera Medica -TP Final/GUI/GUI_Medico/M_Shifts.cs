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
            usermedic.Shifts();
            M_Shifts_list.DataSource = usermedic.listTurno;

            // ocultar columnas con objetos
            M_Shifts_list.Columns["Id"].Visible = false;
            M_Shifts_list.Columns["Assigned_Doctor"].Visible = false;
            M_Shifts_list.Columns["PatientAssigned"].Visible = false;
            M_Shifts_list.Columns["OfficeAssigned"].Visible = false;

            M_Shifts_list.Columns["Date"].HeaderText = "Fecha";
            M_Shifts_list.Columns["Hour"].HeaderText = "Hora";
            M_Shifts_list.Columns["Duration"].HeaderText = "Duración";
            M_Shifts_list.Columns["OriginalPrice"].HeaderText = "Precio";
            M_Shifts_list.Columns["State"].HeaderText = "Estado";
        }

        private void M_Shifts_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
