using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnera_Medica__TP_Final.GUI
{
    public partial class PreRegister : Form
    {
        public PreRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Medico_option_user_Click(object sender, EventArgs e)
        {
            //Llamo el form o ventana Login
            RegisterMedic registerMedic_form = new RegisterMedic();
            registerMedic_form.Show(); //Abre este form
            this.Hide(); // Oculto el Login
        }

        private void paciente_option_user_Click(object sender, EventArgs e)
        {
            //Llamo el form o ventana Login
            RegisterPatient registerPatient_form = new RegisterPatient();
            registerPatient_form.Show(); //Abre este form
            this.Hide(); // Oculto el Login
        }

        private void volver_login_Click(object sender, EventArgs e)
        {
            //Llamo el form o ventana Login
            Login login_form = new Login();
            login_form.Show(); //Abre este form
            this.Hide(); // Oculto el Login
        }

        private void PreRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
