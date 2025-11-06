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
    public partial class P_AvailableShiftsForm : Form
    {
        private Paciente userpatient { get; set; }
        public P_AvailableShiftsForm(Paciente userpatient)
        {
            InitializeComponent();
            this.userpatient = userpatient;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void P_AvailableShiftsForm_Load(object sender, EventArgs e)
        {

        }

        private void ReturnPreRegister_Click(object sender, EventArgs e)
        {
            P_Start p_start_form = new P_Start(userpatient);  // Abre el menú del paciente
            p_start_form.Show();
            this.Hide(); 
        }

        private void RegisterP_send_Click(object sender, EventArgs e)
        {
            P_AvailableShifts p_availableshifts = new P_AvailableShifts(userpatient);  // Abre la otra ventana de turnos
            p_availableshifts.Show();
            this.Hide();
        }

        private void login_email_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
