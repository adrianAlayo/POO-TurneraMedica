﻿using MySql.Data.MySqlClient;
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
    public partial class M_AddSocialWork : Form
    {
        public M_AddSocialWork()
        {
            InitializeComponent();
        }

        MySqlConnection conexionDB = Connection.conexion();

        private void M_AddSocialWork_Load(object sender, EventArgs e)
        {

        }

        private void socialwork_name_user_TextChanged(object sender, EventArgs e)
        {

        }

        // ES PARA AÑADIR LA OBRA SOCIAL 
        private void sent_socialwork_Click(object sender, EventArgs e)
        {
        
        }

        private void return_start_M_Click(object sender, EventArgs e)
        {
            M_Start m_start_form = new M_Start();
            m_start_form.Show(); //abre de vuelta el form de inicio del medico
            this.Hide(); // quitamos el form de añadir obra social
        }
    }
}
