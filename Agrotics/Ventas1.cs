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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace Agrotics.Resources
    
{
    public partial class Ventas1 : Form
    {
        public String ValorCelda { get; set; }
        public Ventas1()
        {
            InitializeComponent();

        }

        public void limpiar()
        {
            txtBuscarProVen.Clear();
            txtBuscarPresentacion.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtLabVentas.Clear();
            txtCadVentas.Clear();
            txtTipoPVentas.Clear();
            txtPrecioVentas.Clear();
           txtPresentacionVentas.Clear();
            txtCultivos.Clear();
            txtStockVentas.Clear();
        }
        private void btnBuscarProVent_Click(object sender, EventArgs e)
        {
            if (btnBuscarProVent.Text.Length == 0)
            {
                MessageBox.Show("El campo de busqueda esta vacio");
            }
            else
            {
                string buscar = txtBuscarProVen.Text;
                MySqlDataReader reader = null;

                string sql = "SELECT NombreProducto, DescripcionCultivos, LaboratorioP, Precio, FechaCaducidad, Stock, Tipo, Presentacion, Cultivos FROM productos WHERE NombreProducto = '" + buscar + "' AND Presentacion = '"+txtBuscarPresentacion.Text+"'  LIMIT 1";
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
                            txtPresentacionVentas.Text = reader.GetString(7);
                            txtCultivos.Text = reader.GetString(8);

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
            if (txtCantVen.TextLength == 0) {
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
            
            if (!string.IsNullOrEmpty(ValorCelda))
            {
              
                string buscar = txtBuscarProVen.Text;
                MySqlDataReader reader = null;

                string sql = "SELECT NombreProducto, DescripcionCultivos, LaboratorioP, Precio, FechaCaducidad, Stock, Tipo, Presentacion, Cultivos FROM productos WHERE NombreProducto = '" + ValorCelda + "'LIMIT 1";
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
                            txtPresentacionVentas.Text = reader.GetString(7);
                            txtCultivos.Text = reader.GetString(8);

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
        

        private void txtVender_Click(object sender, EventArgs e)
        {
            // Creamos el documento PDF
            Document doc = new Document(PageSize.A4, 50, 50, 50, 50);

            // Creamos un objeto PDFWriter para escribir el PDF
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Tabla.pdf", FileMode.Create));

            // Abrimos el documento
            doc.Open();

            // Creamos una tabla con tres columnas
            PdfPTable table = new PdfPTable(3);

            // Agregamos los encabezados de las columnas
            table.AddCell("ListBox 1");
            table.AddCell("ListBox 2");
            table.AddCell("ListBox 3");

            // Agregamos las filas de la tabla con la información de los ListBox
            for (int i = 0; i < Math.Max(ListaPrecios.Items.Count, Math.Max(lstCantidad.Items.Count, ListaPrecios.Items.Count)); i++)
            {
                table.AddCell(i < listaProductos.Items.Count ? listaProductos.Items[i].ToString() : "");
                table.AddCell(i < lstCantidad.Items.Count ? lstCantidad.Items[i].ToString() : "");
                table.AddCell(i < ListaPrecios.Items.Count ? ListaPrecios.Items[i].ToString() : "");
            }

            // Agregamos la tabla al documento
            doc.Add(table);

            // Cerramos el documento
            doc.Close();

            MessageBox.Show("PDF generado exitosamente.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
