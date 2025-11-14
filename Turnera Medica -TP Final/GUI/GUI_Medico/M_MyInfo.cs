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
    public partial class M_MyInfo : Form
    {
        private Medic usermedic { get; set; }
        public M_MyInfo(Medic usermedic)
        {
            InitializeComponent();
            this.usermedic = usermedic;
        }

        

        private void get_info_M_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void return_start_M_Click(object sender, EventArgs e)
        {
            M_Start m_start_form = new M_Start(usermedic);
            m_start_form.Show(); //abre de vuelta el form de inicio del medico
            this.Hide(); // quitamos el form de ver mi informacion
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void M_MyInfo_Load(object sender, EventArgs e)
        {

        }

        private void M_MyInfo_name_TextChanged(object sender, EventArgs e)
        {
            M_MyInfo_name.Text += " " + usermedic.Name;
        }

        private void M_MyInfo_office_Click(object sender, EventArgs e)
        {

        }

        private void M_MyInfo_lastName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void M_MyInfo_dni_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void M_MyInfo_age_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void M_MyInfo_phone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void M_MyInfo_email_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void M_MyInfo_speciality_TextChanged(object sender, EventArgs e)
        {
            //Hacer una consulta apropiada para que te muestre el nombre de la ESPECIALIDAD
           
        }

        private void M_MyInfo_socialWorck_TextChanged(object sender, EventArgs e)
        {
            //hay que hacer la consulta apropiada para quie te muestre todas las obras sociales
        }

        private void M_MyInfo_office_TextChanged(object sender, EventArgs e)
        {
            //hay que hacer la consulta apropiada para que me muestre el CONSULTORIO donde trabaja
            
        }

        private void M_MyInfo_ChekInTime_TextChanged(object sender, EventArgs e)
        {
            //hay que hacer la consulta apropiada para quie te muestre horario de entrada 
        }

        private void M_MyInfo_ChekOutTime_TextChanged(object sender, EventArgs e)
        {
            //hay que hacer la consulta apropiada para quie te muestre horario de salida
        }

        private void M_MyInfo_consultAmount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
