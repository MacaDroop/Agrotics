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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            txtBuscarpro.Text = "";
            txtDescripcionPro.Text = "";
            txtCaducidad.Text = "";
            txtLaboratorio.Text = "";
            txtNombrePro.Text = "";
            txtPrecio.Text = "";
        }
        private void lblcaducidad_Click(object sender, EventArgs e)
        {

        }
        public void agregarProductos()
        {
            string nombrePro = txtNombrePro.Text;
            string descripcionPro = txtDescripcionPro.Text;
            string laboratorioPro = txtLaboratorio.Text;
            string precio = txtPrecio.Text;
            string fechaCad = txtCaducidad.Text;
            


            if (txtPrecio.Text.Length == 0)
            {
                MessageBox.Show("No se han completado todos los campos");
            }

            else
            {
                //sexo = Convert.ToString(cbHM.SelectedItem.ToString()); 
                string sql = "INSERT INTO productos (NombreProducto, DescripcionCultivos, LaboratorioP, Precio, FechaCaducidad) VALUES ('" + nombrePro + "', '" + descripcionPro + "', '" + laboratorioPro + "', '"  + precio + "', '" + fechaCad + "')";
                MySqlConnection conexionBD = Conexion2.conexion();
                conexionBD.Open();


                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Guardado");
                    todosProductos();
                    limpiar();


                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }
            }
        }
        public void editarProductos()
        {
            string nombrePro = txtNombrePro.Text;
            string descripcion = txtDescripcionPro.Text;
            string Laboratorio =txtLaboratorio.Text;
            string Precio = txtPrecio.Text;
            string fechaCad =txtCaducidad.Text;
            

            string sql = "UPDATE productos SET NombreProducto= '" + nombrePro + "', DescripcionCultivos='" + descripcion + "', ='" + Laboratorio + "', Precio='" + Precio + "', FechaCaducidad='" + fechaCad + "' WHERE NombreProducto='" + txtBuscarpro.Text + "'";
            MySqlConnection conexionBD = Conexion2.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Actualizado");
                limpiar();
              


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Registrar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
        public void eliminarproductos()

        {
            string sql = "DELETE FROM productos WHERE NombreProducto= '" + txtBuscarpro.Text + "'";
            MySqlConnection conexionBD = Conexion2.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();


                MessageBox.Show("Registro Eliminado");
                

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
        public void todosProductos()
        {
            MySqlDataReader reader = null;

            string Sql = "SELECT  from productos";
            MySqlConnection conexionBD = Conexion2.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand(Sql, conexionBD);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable datos = new DataTable();

                datos.Load(reader);
                dgvProductos.DataSource = datos;
            }
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

                string sql = "SELECT NombreProducto, DescripcionCultivos, LaboratorioP, Precio, FechaCaducidad, stock, TipoProducto, cantidadProducto FROM productos WHERE Nombre LIKE '" + buscar + "' LIMIT 1";
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
                            txtCaducidad.Text = reader.GetString(4);
                            txtStock.Text = reader.GetString(5);
                            txtTipo.Text = reader.GetString(6);
                            txtCaducidad.Text = reader.GetString(6);
                            

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
            todosProductos();
        }

        private void bttAg_Click(object sender, EventArgs e)
        {
            agregarProductos();
        }

        private void btnEdi_Clik(object sender, EventArgs e)
        {
            editarProductos();
        }

        private void btnEli_Click(object sender, EventArgs e)
        {
            eliminarproductos();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
