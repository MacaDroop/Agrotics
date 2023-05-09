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

namespace Agrotics.Resources
{
    public partial class Ventas1 : Form
    {
        public Ventas1()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtBuscarProVen.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtLabVentas.Clear();
            txtCadVentas.Clear();
            txtTipoPVentas.Clear();
            txtPrecioVentas.Clear();
           txtPresentacionVentas.Clear();
        }
        private void btnBuscarProVent_Click(object sender, EventArgs e)
        {
            if (btnBuscarProVent.Text.Length == 0)
            {
                MessageBox.Show("El campo de busqueda esta vacio");
            }
            else
            {
                string buscar = btnBuscarProVent.Text;
                MySqlDataReader reader = null;

                string sql = "SELECT NombreProducto, DescripcionCultivos, LaboratorioP, Precio, FechaCaducidad, stock, TipoProducto, cantidadProducto FROM productos WHERE Nombre = '" + buscar + "' AND presentacion = '"+txtPresentacionVentas.Text+"'  LIMIT 1";
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

                            txtName.Text = reader.GetString(0);
                            txtDescription.Text = reader.GetString(1);
                            txtLabVentas.Text = reader.GetString(2);
                            txtPrecioVentas.Text = reader.GetString(3);
                            txtCadVentas.Text = reader.GetString(4);
                            txtStockVentas.Text = reader.GetString(5);
                            txtTipoPVentas.Text = reader.GetString(6);
                            txtPresentacionVentas.Text = reader.GetString(6);

                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron los registros");
                    }


                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtBuscarProVen.TextLength == 0) {
                MessageBox.Show("PRIMERO SELECCIONA LA CANTIDAD DE PRODUCTOS A VENDER");
            
            }
            else
            {
                string nproduc = txtName.Text; // Obtener el texto ingresado en un cuadro de texto
                string cantidad = txtCantVen.Text;
                string precio = txtPrecioVentas.Text;
                int total;

                if (!string.IsNullOrEmpty(nproduc) && !string.IsNullOrEmpty(cantidad) && !string.IsNullOrEmpty(precio)) // Verificar que el texto no esté vacío
                {
                    listaProductos.Items.Add(nproduc); // Agregar el elemento a la lista
                    lstCantidad.Items.Add(cantidad); // Limpiar el cuadro de texto
                    ListaPrecios.Items.Add(precio);
                    limpiar();
                    total = Convert.ToInt32(precio) * Convert.ToInt32(cantidad);
                    lblTotal.Text = "$" + Convert.ToString(total);
                }
            }
        }

        private void Ventas1_Load(object sender, EventArgs e)
        {

        }
    }
}
