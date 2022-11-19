using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agrotics
{
    public partial class Provedores : Form
    {
        public Provedores()
        {
            InitializeComponent();
        }

        public void todosprovedores()
        {
            MySqlDataReader reader = null;

            string Sql = "SELECT * from proveedores";
            MySqlConnection conexionBD = Conexion2.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand(Sql, conexionBD);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable datos = new DataTable();

                datos.Load(reader);
                dgvprovedores.DataSource = datos;
            }

        }
        private void Provedores_Load(object sender, EventArgs e)
        {
            todosprovedores();
        }
    }
}
