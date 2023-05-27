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
         public int total = 0;


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

        public void actualizarStock(string nombreProducto, int cantid)
        {
           

                MySqlDataReader reader = null;

                string sql = $"UPDATE productos SET Stock = Stock - {cantid} WHERE NombreProducto = '{nombreProducto}'";

                MySqlConnection conexionBD = Conexion2.conexion();
                conexionBD.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    reader = comando.ExecuteReader();     
                   
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
                    //limpiar();
                    
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

                string sql = "SELECT NombreProducto, DescripcionCultivos, LaboratorioP, Precio, FechaCaducidad, Stock, Tipo, Presentacion, Cultivos, Referencia FROM productos WHERE NombreProducto = '" + ValorCelda + "'LIMIT 1";
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
                float ticketWidth = 250;
                float ticketHeight = 350;

                // Generar el PDF con la información de la tabla y guardar en la ruta seleccionada
               
                iTextSharp.text.Rectangle ticketSize = new iTextSharp.text.Rectangle(ticketWidth, ticketHeight);
                Document doc = new Document(ticketSize, 50, 50, 50, 50);
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
                doc.Open();


                string rutaImagen = "logotick.jpg"; // Reemplaza esto con la ruta de tu imagen
                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(rutaImagen);
                imagen.Alignment = Element.ALIGN_CENTER;
                imagen.ScaleToFit(45, 45); // Ajusta el tamaño de la imagen según tus necesidades
                                           // Establecer la posición de la imagen
                float x = (doc.PageSize.Width - imagen.ScaledWidth) / 2; // Centrar horizontalmente
                float y = doc.PageSize.Height - 60; // Ajustar la posición vertical aquí (por ejemplo, 50 es la distancia desde la parte superior)
                imagen.SetAbsolutePosition(x, y);
                doc.Add(imagen);

                //TITULO EN EL PFF
                iTextSharp.text.Font tituloFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 22, iTextSharp.text.Font.BOLD);
                Paragraph titulo = new Paragraph("Agrotics", tituloFont);
                titulo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                doc.Add(titulo);

                iTextSharp.text.Font subtituloFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.NORMAL);
                Paragraph subtitulo = new Paragraph("Ventas", subtituloFont);
                subtitulo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                doc.Add(subtitulo);

                iTextSharp.text.Font espacioFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL);
                Paragraph espacio = new Paragraph(" ", espacioFont);
                espacio.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                doc.Add(espacio);

                iTextSharp.text.Font fechaFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL);
                Paragraph fecha = new Paragraph("Fecha:"+fechaFormateada, fechaFont);
                fecha.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                doc.Add(fecha);

                iTextSharp.text.Font lugarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL);
                Paragraph lugar = new Paragraph("Juan Rodriguez Clara, Ver", lugarFont);
                lugar.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                doc.Add(lugar);

                iTextSharp.text.Font direccionFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL);
                Paragraph direccion = new Paragraph("Col. Las Bodegas", direccionFont);
                direccion.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                doc.Add(direccion);

                iTextSharp.text.Font espacioFont2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL);
                Paragraph espacio2 = new Paragraph(" ", espacioFont2);
                espacio2.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                doc.Add(espacio2);


                // Añadir la tabla con los datos
                PdfPTable table = new PdfPTable(3);
                table.DefaultCell.Padding = 5;
                table.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;

                // Establecer el tamaño de fuente para las celdas de la tabla
                iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 7, iTextSharp.text.Font.NORMAL);

                // Agregar las celdas de encabezado
                PdfPCell productosHeader = new PdfPCell(new Phrase("Producto", font));
                PdfPCell cantidadHeader = new PdfPCell(new Phrase("Cantidad", font));
                PdfPCell precioHeader = new PdfPCell(new Phrase("Precio Unitario", font));

                // Establecer el estilo de las celdas de encabezado
                productosHeader.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cantidadHeader.Border = iTextSharp.text.Rectangle.NO_BORDER;
                precioHeader.Border = iTextSharp.text.Rectangle.NO_BORDER;

                // Agregar las celdas de encabezado a la tabla
                table.AddCell(productosHeader);
                table.AddCell(cantidadHeader);
                table.AddCell(precioHeader);

                // Agregar las celdas con la información correspondiente
                for (int i = 0; i < Math.Max(ListaPrecios.Items.Count, Math.Max(lstCantidad.Items.Count, listaProductos.Items.Count)); i++)
                {
                    PdfPCell productoCell = new PdfPCell(new Phrase(i < listaProductos.Items.Count ? listaProductos.Items[i].ToString() : "", font));
                    PdfPCell cantidadCell = new PdfPCell(new Phrase(i < lstCantidad.Items.Count ? lstCantidad.Items[i].ToString() : "", font));
                    PdfPCell precioCell = new PdfPCell(new Phrase(i < ListaPrecios.Items.Count ? ListaPrecios.Items[i].ToString() : "", font));

                    // Establecer el estilo de las celdas de información
                    productoCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    cantidadCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    precioCell.Border = iTextSharp.text.Rectangle.NO_BORDER;

                    // Agregar las celdas de información a la tabla
                    table.AddCell(productoCell);
                    table.AddCell(cantidadCell);
                    table.AddCell(precioCell);
                }

                PdfPCell celdanull = new PdfPCell(new Phrase("", font));
                PdfPCell totaltxt = new PdfPCell(new Phrase("Total:", font));
                PdfPCell totalCant = new PdfPCell(new Phrase(total.ToString(), font));
                
                celdanull.Border = iTextSharp.text.Rectangle.NO_BORDER;
                totaltxt.Border = iTextSharp.text.Rectangle.NO_BORDER;
                totalCant.Border = iTextSharp.text.Rectangle.NO_BORDER;

                table.AddCell(celdanull);
                table.AddCell(totaltxt);
                table.AddCell(totalCant);
                doc.Add(table);

                iTextSharp.text.Font espacioFont3 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL);
                Paragraph espacio3 = new Paragraph(" ", espacioFont3);
                espacio.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                doc.Add(espacio3);

                iTextSharp.text.Font esloganFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL);
                Paragraph eslogan = new Paragraph("ORGANIZAMOS TU CAMPO", esloganFont);
                eslogan.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                doc.Add(eslogan);


                // Cerrar el documento
                doc.Close();

                MessageBox.Show("PDF generado exitosamente.");
            }

            //RECORRER LOS LISTBOX PARA ACTUALIZAR EL STOCK EN LA BASE DE DATOS
            int cantidadProductos = listaProductos.Items.Count;

            for (int i = 0; i < cantidadProductos; i++)
            {
                string nombreProducto = listaProductos.Items[i].ToString();
                int cantidad = Convert.ToInt32(lstCantidad.Items[i]);

                actualizarStock(nombreProducto, cantidad);
            }


            //AGREGAR A LA BASE DE DATOS LOS REGISTROS DEL PRODUCTO VENDIDO
            DateTime horaActual = DateTime.Now;
            string horaActualString = horaActual.ToString("HH:mm:ss");
            //sexo = Convert.ToString(cbHM.SelectedItem.ToString()); 
            string sql = "INSERT INTO registroventas (NombreProducto, DescripcionCultivos, LaboratorioP, Precio, FechaCaducidad, Stock, Tipo, Presentacion, Cultivos, Referencia,  Hora) VALUES ('" + txtName.Text + "', '" + txtDescription.Text + "', '" + "', '" + txtLabVentas.Text + "', '" + txtPrecioVentas.Text + "', '" + txtCadVentas.Text + "', '" + txtStockVentas.Text + "', '" + txtTipoPVentas.Text + "', '" + txtPresentacionVentas.Text + "','" + txtCultivos.Text + "' + '"+txtReferVen.Text+"', '"+horaActualString+"')";
            MySqlConnection conexionBD = Conexion2.conexion();
            conexionBD.Open();
            
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();


                MessageBox.Show("Registro Ingresado");


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Eliminar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
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
