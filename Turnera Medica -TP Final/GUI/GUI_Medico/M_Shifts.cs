using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnera_Medica__TP_Final.GUI.GUI_Medico
{
    public partial class M_Shifts : Form
    {
        public M_Shifts()
        {
            InitializeComponent();
        }

        private void return_start_M_Click(object sender, EventArgs e)
        {
            M_Start m_start_form = new M_Start();
            m_start_form.Show(); //abre de vuelta el form de inicio del medico
            this.Hide(); // quitamos el form de ver todos los turnos
        }
    }
}
