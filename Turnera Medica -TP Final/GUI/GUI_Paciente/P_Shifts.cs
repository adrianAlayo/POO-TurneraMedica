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
    public partial class P_Shifts : Form
    {
        private Patient userpatient { get; set; }
        public P_Shifts(Patient userpatient)
        {
            InitializeComponent();
            this.userpatient = userpatient;
        }

        private void return_start_P_Click(object sender, EventArgs e)
        {
            P_Start p_start_form = new P_Start(userpatient);
            p_start_form.Show(); //abre de vuelta el form del inicio de paciente
            this.Hide(); // quitamos el form de ver todos los turnos
        }

        private void P_Shifts_Load(object sender, EventArgs e)
        {

        }
    }
}
