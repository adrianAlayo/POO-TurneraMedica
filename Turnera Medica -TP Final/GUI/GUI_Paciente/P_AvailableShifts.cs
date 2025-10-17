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
    public partial class P_AvailableShifts : Form
    {
        public P_AvailableShifts()
        {
            InitializeComponent();
        }

        private void return_start_P_Click(object sender, EventArgs e)
        {
            P_AvailableShiftsForm p_available_shiftform_form = new P_AvailableShiftsForm();
            p_available_shiftform_form.Show(); //abre de vuelta el form del formulario para ver los turnos disponibles
            this.Hide(); // quitamos el form de ver turnos disponibles 
        }
    }
}
