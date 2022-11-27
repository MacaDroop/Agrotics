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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void lblcaducidad_Click(object sender, EventArgs e)
        {

        }

        private void bttBuscar_Click(object sender, EventArgs e)
        {
            if (btnBuscarPro.Text.Length == 0)
            {
                MessageBox.Show("El campo de busqueda esta vacio");
            }
            else
            {
                string buscar =txtBuscarpro.Text;
                MySqlDataReader reader = null;

                string sql = "SELECT NombreProducto, DescripcionCultivos, LaboratorioP, Precio, FechaCaducidad FROM productos WHERE Nombre LIKE '" + buscar + "' LIMIT 1";
                MySqlConnection conexionBD = Conexion2.conexion();
                conexionBD.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                           txtNombrePro.Text = reader.GetString(0);
                           txtDescripcionPro.Text = reader.GetString(1);
                           txtLaboratorio.Text = reader.GetString(2);
                           txtPrecio.Text = reader.GetString(3);
                            txtFechaCaducidad.Text = reader.GetString(4);
                            

                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron los registros");
                    }


                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro al buscar: " + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }
            }
        }
         
        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void bttAg_Click(object sender, EventArgs e)
        {
         
        }

        private void bttEd_Click(object sender, EventArgs e)
        {

        }

        private void bttEli_Click(object sender, EventArgs e)
        {

        }
    }
}
