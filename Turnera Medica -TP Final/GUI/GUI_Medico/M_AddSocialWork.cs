using MySql.Data.MySqlClient;
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
        private Medic usermedico { get; set; }
        public M_AddSocialWork(Medic usermedico)
        {
            InitializeComponent();
            this.usermedico = usermedico;
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
            try
            {
                conexionDB.Open();

                string newsocialwork = socialwork_name_user.Text.Trim();

                // creamos todas las query que vamos a usar
                string queryAddSocial = "INSERT INTO social_works (name) VALUES (@namesocial)";
                string queryGetSocial = "SELECT id FROM social_works WHERE name = @namesocial";
                string queryCheckRel = "SELECT COUNT(*) FROM medic_social_work WHERE medic_id = @idmedic AND social_work_id = @idsocial";
                string queryAddRel = "INSERT INTO medic_social_work (medic_id, social_work_id) VALUES (@idmedic, @idsocial)";

                // insertamos la nueva obra social (ademas de que tambien hacemos que lo ignore si es que esta duplicada)
                try
                {
                    MySqlCommand cmdAddSocial = new MySqlCommand(queryAddSocial, conexionDB);
                    cmdAddSocial.Parameters.AddWithValue("@namesocial", newsocialwork);
                    cmdAddSocial.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    // Si es un error de entrada duplicada (ya existe la obra social), lo ignoramos
                    if (ex.Number != 1062)
                    {
                        throw;
                    }
                }

                // aqui buscamos y guardamos el id de la obra social
                int idsocial = 0;
                MySqlCommand cmdGetSocial = new MySqlCommand(queryGetSocial, conexionDB);
                cmdGetSocial.Parameters.AddWithValue("@namesocial", newsocialwork);

                using (MySqlDataReader read = cmdGetSocial.ExecuteReader())
                {
                    if (read.Read())
                    {
                        idsocial = Convert.ToInt32(read["id"]);
                    }
                }

                if (idsocial == 0)
                {
                    MessageBox.Show("No se pudo encontrar la obra social agregada.");
                    return;
                }

                //aca se verifica si el médico ya tiene esta obra social
                MySqlCommand cmdCheck = new MySqlCommand(queryCheckRel, conexionDB);
                cmdCheck.Parameters.AddWithValue("@idmedic", usermedico.Id);
                cmdCheck.Parameters.AddWithValue("@idsocial", idsocial);

                int existeRelacion = Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (existeRelacion > 0)
                {
                    MessageBox.Show("Este médico ya tiene asociada esta obra social.");
                    return;
                }

                //aca relacionamos la obra social con el médico
                MySqlCommand cmdAddRel = new MySqlCommand(queryAddRel, conexionDB);
                cmdAddRel.Parameters.AddWithValue("@idmedic", usermedico.Id);
                cmdAddRel.Parameters.AddWithValue("@idsocial", idsocial);

                int filas = cmdAddRel.ExecuteNonQuery();

                if (filas > 0)
                {
                    MessageBox.Show("Obra social agregada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo asociar la obra social al médico.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la obra social: " + ex.Message);
            }
            finally
            {
                conexionDB.Close();
            }
        }

        private void return_start_M_Click(object sender, EventArgs e)
        {
            M_Start m_start_form = new M_Start(usermedico);
            m_start_form.Show(); //abre de vuelta el form de inicio del medico
            this.Hide(); // quitamos el form de añadir obra social
        }
    }
}
