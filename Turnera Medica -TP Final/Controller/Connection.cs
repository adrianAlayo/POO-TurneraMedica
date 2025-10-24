using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Turnera_Medica__TP_Final.Controller
{
    internal class Connection
    {
        public static MySqlConnection conexion()
        {
            string servidor = "localhost";
            string bd = "tp_turneriamedica_db";
            string usuario = "root";
            string password = "1234";

            string cadenaConexion = "Database" + bd + "; Data Source" + servidor + "; User Id=" + usuario + "; Password=" + password+"";

            try
            {
                MySqlConnection conexionDB = new MySqlConnection(cadenaConexion);

                return conexionDB;
            }
            catch (MySqlException ex) 
            {
                Console.WriteLine("Error: " +  ex.Message);

                return null;
            }
        }
    }
}
