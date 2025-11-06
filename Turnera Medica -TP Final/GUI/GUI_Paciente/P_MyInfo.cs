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
using Turnera_Medica__TP_Final.GUI.GUI_Medico;

namespace Turnera_Medica__TP_Final.GUI.GUI_Paciente
{
    public partial class P_MyInfo : Form
    {
        private Paciente userpatient { get; set; }
        public P_MyInfo(Paciente userpatient)
        {
            InitializeComponent();
            this.userpatient = userpatient;
        }

        private void get_info_P_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }        
        
        private void return_start_P_Click(object sender, EventArgs e)
        {
            P_Start p_start_form = new P_Start(userpatient);
            p_start_form.Show(); //abre de vuelta el form del menu para el paciente
            this.Hide(); // quitamos el form de ver mi informacion
        }
    }
}
