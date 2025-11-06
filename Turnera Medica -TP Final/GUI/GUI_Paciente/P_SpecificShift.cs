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
    public partial class P_SpecificShift : Form
    {
        private Patient userpatient {  get; set; }
        public P_SpecificShift(Patient userpatient)
        {
            InitializeComponent();
            this.userpatient = userpatient;
        }

        private void P_SpecificShift_Load(object sender, EventArgs e)
        {

        }

        private void return_start_P_Click(object sender, EventArgs e)
        {
            P_Start p_start_form = new P_Start(userpatient);
            p_start_form.Show(); //abre de vuelta el form del inicio de paciente
            this.Hide(); // quitamos el form de ver todos los turnos
        }
    }
}
