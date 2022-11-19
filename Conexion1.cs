using MySql.Data.MySqlClient;
using System;

namespace Agrotics
{
   
    class Conexion 
    {

    

        public static MySqlConnection conexion()
        {
            string Servidor = "localhost";
            string Puerto = "3306";
            string Usuario = "root";
            Agrotics mensajero = new Agrotics();


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

