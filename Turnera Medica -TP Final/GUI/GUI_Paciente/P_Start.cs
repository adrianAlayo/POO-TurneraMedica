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
   
    public partial class P_Start : Form
    {
        private Paciente userpatient { get; set; }
        public P_Start(Paciente userpatient )
        {
            InitializeComponent();
            this .userpatient = userpatient;
        }

        private void P_Start_Load(object sender, EventArgs e)
        {

        }

        private void GetShifts_Click(object sender, EventArgs e)
        {
            P_Shifts p_shifts_form = new P_Shifts(userpatient);
            p_shifts_form.Show(); // Abro la ventana de turnos
            this.Hide(); // Oculta el menú principal del paciente
        }

        private void GetInfo_Click(object sender, EventArgs e)
        {
            P_MyInfo p_myinfo_form = new P_MyInfo(userpatient);
            p_myinfo_form.Show(); // Abro la ventana de información
            this.Hide();
        }

        private void GetShift_Click(object sender, EventArgs e)
        {
            P_SpecificShift p_specificshift_form = new P_SpecificShift(userpatient);
            p_specificshift_form.Show(); // Abro la ventana de turno específico
            this.Hide();
        }

        private void RequestAppointment_Click(object sender, EventArgs e)
        {
            P_AvailableShifts p_availableshifts_form = new P_AvailableShifts(userpatient);
            p_availableshifts_form.Show(); // Abro la ventana de turnos disponibles
            this.Hide();
        }

        private void SendLogin_Click(object sender, EventArgs e)
        {
            Login login_form = new Login();
            login_form.Show(); // Abro la pantalla de login
            this.Hide();
        }
    }
}
