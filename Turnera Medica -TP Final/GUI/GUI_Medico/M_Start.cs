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
    public partial class M_Start : Form
    {
        private Medic usermedico { get; set; }
        public M_Start(Medic usermedico)
        {
            InitializeComponent();
            this.usermedico = usermedico;
        }

        private void GetShifts_Click(object sender, EventArgs e)
        {
            M_Shifts mshifts_form = new M_Shifts(usermedico);
            mshifts_form.Show(); //Abre este form
            this.Hide();
        }

        private void GetInfo_Click(object sender, EventArgs e)
        {
            M_MyInfo myinfo_form = new M_MyInfo(usermedico);
            myinfo_form.Show(); //Abre este form
            this.Hide();

        }

        private void GetShift_Click(object sender, EventArgs e)
        {
            M_SpecificShift mspecificshift_form = new M_SpecificShift(usermedico);
            mspecificshift_form.Show(); //Abre este form
            this.Hide();
        }

        private void GetSocialWork_Click(object sender, EventArgs e)
        {
            M_AddSocialWork maddsocialwork_form = new M_AddSocialWork(usermedico);
            maddsocialwork_form.Show(); //Abre este form
            this.Hide();
        }

        private void SendLogin_Click(object sender, EventArgs e)
        {
            Login login_form = new Login();
            login_form.Show(); //Abre este form
            this.Hide();
        }

        private void M_Start_Load(object sender, EventArgs e)
        {

        }
    }
}
