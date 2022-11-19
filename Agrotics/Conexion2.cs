using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrotics
{
    class Conexion2
    {
        public static MySqlConnection conexion()
        {
            //PRUEBA
            string Servidor = "localhost";
            string Puerto = "3306";
            string Usuario = "root";
            Form1 mensajero = new Form1();

            
            string cadenaConexion = "Database=agrotics" + "; Data Source=" + Servidor + "; User Id=" + Usuario + ";";
            MySqlConnection Conexion = new MySqlConnection(cadenaConexion);

            try
            {

                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
