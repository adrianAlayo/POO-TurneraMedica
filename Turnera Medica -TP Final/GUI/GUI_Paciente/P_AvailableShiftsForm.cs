using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnera_Medica__TP_Final.GUI.GUI_Paciente
{
    public partial class P_AvailableShiftsForm : Form
    {
        public P_AvailableShiftsForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void P_AvailableShiftsForm_Load(object sender, EventArgs e)
        {

        }

        private void ReturnPreRegister_Click(object sender, EventArgs e)
        {
            P_Start p_start_form = new P_Start();  // Abre el menú del paciente
            p_start_form.Show();
            this.Hide(); 
        }

        private void RegisterP_send_Click(object sender, EventArgs e)
        {
            P_AvailableShifts p_availableshifts = new P_AvailableShifts();  // Abre la otra ventana de turnos
            p_availableshifts.Show();
            this.Hide();
        }
    }
}
