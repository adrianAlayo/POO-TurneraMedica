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

        private void return_start_P_Click(object sender, EventArgs e)
        {
            P_Start p_start_form = new P_Start();
            p_start_form.Show(); //abre de vuelta el form del inicio de paciente
            this.Hide(); // quitamos el form del formulario para ver los turnos disponibles
        }
    }
}
