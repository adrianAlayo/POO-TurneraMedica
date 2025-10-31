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
    public partial class UpdatePassword : Form
    {
        public UpdatePassword()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void update_password_Click(object sender, EventArgs e)
        {
            string email = update_email_user.Text;
            string newPass = update_newPass_user.Text;
            string confirmPass = update_confirmPass_user.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(newPass) || string.IsNullOrWhiteSpace(confirmPass))
            {
                MessageBox.Show("Complete todos los campos por favor");

            }
            //Faltaria hacer la parte del codigo donde se haria la comparacion del email para luego cambiar la contraseña
            /* 
             buscaremail = SELECT email IN users WHERE email == email (o algo parecido)

            if (newPass == confirmpass && buscaremail == true) {
                hacer el codigo para hacer el update de la password usando confirmPass

            si el update se logro hacer entonces hay que hacer un mensaje que diga "contraseña actualizada con exito"

            }
             
             
             
             */
        }

        private void return_login_Click(object sender, EventArgs e)
        {
            Login login_form = new Login();
            login_form.Show(); //abre de vuelta el form de iniciar sesion
            this.Hide(); // quitamos el form de actualizar contraseña
        }

        private void UpdatePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
