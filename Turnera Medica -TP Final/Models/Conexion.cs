using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Models
{
    public class Conexion
    {
        public static MySqlConnection conexion()
        {
            string server = "localhost";
            string db = "tp_turneriamedica_db";
            string user = "root";
            string password = "123";

            string stringConexion = "Database=" + db + "; Data Source=" + server + "; User Id=" + user + "; Password=" + password + "";

            try
            {
                MySqlConnection conexionDB = new MySqlConnection(stringConexion);
                return conexionDB;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
