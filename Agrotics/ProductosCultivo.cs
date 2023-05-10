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

namespace Agrotics
{
    public partial class ProductosCultivo : Form
    {
        public String ValorEnviado { get; set; }
        public ProductosCultivo()
        {
            InitializeComponent();
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ProductosCultivo_Load(object sender, EventArgs e)
        {
            label2.Text = ValorEnviado;


            MySqlDataReader reader = null;

            //REVISAR LA CADENA DE CONSULTA Y LA CONCATENACION DE LA VARIABLE
            string sql = "SELECT * FROM productos WHERE Cultivos LIKE '%" + ValorEnviado.Replace("'", "''") + "%'";
            MySqlConnection conexionBD = Conexion2.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable datos = new DataTable();

                datos.Load(reader);
                dgvFertilizantes.DataSource = datos;
            }

        }
    }
}
