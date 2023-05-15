﻿using MySql.Data.MySqlClient;
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
        int total = 0;


        public Ventas1()
        {
            InitializeComponent();
            


        }

        public void manita()
        {
            Cursor = Cursors.Hand;
        }

        public void cursorDefec()
        {
            Cursor = Cursors.Default;
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
            txtCantVen.Clear();
            txtReferVen.Clear();
        }
        private void btnBuscarProVent_Click(object sender, EventArgs e)
        {
            if (txtBuscarProVen.Text.Length == 0)
            {
                MessageBox.Show("El campo de busqueda esta vacio");
            }
            else
            {
                string buscar = txtBuscarProVen.Text;
                MySqlDataReader reader = null;

                string sql = "SELECT NombreProducto, DescripcionCultivos, LaboratorioP, Precio, FechaCaducidad, Stock, Tipo, Presentacion, Cultivos, Referencia FROM productos WHERE NombreProducto = '" + buscar + "' AND Presentacion = '"+txtBuscarPresentacion.Text+"'  LIMIT 1";
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
                            txtReferVen.Text = reader.GetString(9);

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
                


                if (!string.IsNullOrEmpty(nproduc) && !string.IsNullOrEmpty(cantidad) && !string.IsNullOrEmpty(precio)) // Verificar que el texto no esté vacío
                {
                    listaProductos.Items.Add(nproduc); // Agregar el elemento a la lista
                    lstCantidad.Items.Add(cantidad); // Limpiar el cuadro de texto
                    ListaPrecios.Items.Add(precio);
                    limpiar();
                    
                    total += Convert.ToInt32(precio) * Convert.ToInt32(cantidad);
                    lblTotal.Text = Convert.ToString("Total: "+total);
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

            DateTime fechaActual = DateTime.Now;
            string fechaFormateada = fechaActual.ToString("dd-MMM-yyyy");


            // Crear y configurar el objeto SaveFileDialog
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Archivo PDF|*.pdf"; // Filtro para mostrar solo archivos PDF
            saveDialog.Title = "Guardar como...";
            saveDialog.FileName = "Tabla.pdf"; // Nombre predeterminado del archivo

            // Mostrar el cuadro de diálogo para guardar el archivo
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta y el nombre del archivo seleccionado
                string rutaArchivo = saveDialog.FileName;

                // Generar el PDF con la información de la tabla y guardar en la ruta seleccionada
                Document doc = new Document(PageSize.A4, 50, 50, 50, 50);
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
                doc.Open();

              



                //TITULO EN EL PFF
                iTextSharp.text.Font tituloFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 22, iTextSharp.text.Font.BOLD);
                Paragraph titulo = new Paragraph("Agrotics", tituloFont);
                titulo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                doc.Add(titulo);

                iTextSharp.text.Font subtituloFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.NORMAL);
                Paragraph subtitulo = new Paragraph("Ventas", subtituloFont);
                subtitulo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                doc.Add(subtitulo);

                iTextSharp.text.Font espacioFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL);
                Paragraph espacio = new Paragraph(" ", espacioFont);
                titulo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                doc.Add(espacio);

                iTextSharp.text.Font fechaFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL);
                Paragraph fecha = new Paragraph("Fecha:"+fechaFormateada, fechaFont);
                titulo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                doc.Add(fecha);

                iTextSharp.text.Font lugarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL);
                Paragraph lugar = new Paragraph("JUAN RODRIGUEZ CLARA VERACRUZ", lugarFont);
                titulo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                doc.Add(lugar);

                iTextSharp.text.Font espacioFont2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL);
                Paragraph espacio2 = new Paragraph(" ", espacioFont2);
                titulo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                doc.Add(espacio2);

                // Añadir la tabla con los datos
                PdfPTable table = new PdfPTable(3);
                table.AddCell("Productos");
                table.AddCell("Cantidad");
                table.AddCell("Precio Unitario");
              

                for (int i = 0; i < Math.Max(ListaPrecios.Items.Count, Math.Max(lstCantidad.Items.Count, listaProductos.Items.Count)); i++)
                {
                    table.AddCell(i < listaProductos.Items.Count ? listaProductos.Items[i].ToString() : "");
                    table.AddCell(i < lstCantidad.Items.Count ? lstCantidad.Items[i].ToString() : "");
                    table.AddCell(i < ListaPrecios.Items.Count ? ListaPrecios.Items[i].ToString() : "");
                }

                doc.Add(table);



                // Cerrar el documento
                doc.Close();

                MessageBox.Show("PDF generado exitosamente.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBuscarProVen_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtBuscarProVen.Text))
            {
                string buscar = txtBuscarProVen.Text;
                MySqlDataReader reader = null;


                string sql = "SELECT * FROM productos WHERE NombreProducto  LIKE '" + buscar.Replace("'", "''") + "%'";
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
                            txtReferVen.Text = reader.GetString(9);

                        }
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
            else
            {
                limpiar();
            }

        }

        private void btnBuscarProVent_MouseEnter(object sender, EventArgs e)
        {
            manita();
        }

        private void btnBuscarProVent_MouseLeave(object sender, EventArgs e)
        {
            cursorDefec();
        }

        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            manita();
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            cursorDefec();
        }

        private void txtVender_MouseEnter(object sender, EventArgs e)
        {
            manita();
        }

        private void txtVender_MouseLeave(object sender, EventArgs e)
        {
            cursorDefec();
        }
    }
            
}
