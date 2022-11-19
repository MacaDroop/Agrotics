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

        private void bttagregar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string Domicilio = txtDomicilio.Text;
            string Telefono = txtTelefono.Text;
            string Laboratorio = txtLaboratorio.Text;
            string RFC = txtRFC.Text;
            string Correo = txtCorreo.Text;


            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("No se han completado todos los campos");
            }

            else
            {
                //sexo = Convert.ToString(cbHM.SelectedItem.ToString()); 
                string sql = "INSERT INTO proveedores (Nombre, Domicilio, Telefono, Laboratorio, RFC, Correo) VALUES ('" + nombre + "', '" + Domicilio + "', '" + Telefono + "', '" + Laboratorio + "', '" + RFC + "', '" + Correo + "')";
                MySqlConnection conexionBD = Conexion2.conexion();
                conexionBD.Open();


                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Guardado");


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

        private void btteditar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string Domicilio = txtDomicilio.Text;
            string Telefono = txtTelefono.Text;
            string Laboratorio = txtLaboratorio.Text;
            string RFC = txtRFC.Text;
            string Correo = txtCorreo.Text;

            string sql = "UPDATE alumnos SET Nombre= '" + nombre + "', Domicilio='" + Domicilio + "', Telefono='" + Telefono + "', Laboratorio='" + Laboratorio + "', RFC='" + RFC + "', Correo='" + Correo + "' WHERE n_control='" + txtBusquedaPro.Text + "'";
            MySqlConnection conexionBD = Conexion2.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Actualizado");


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

      

        private void bttbusqueda_Click_1(object sender, EventArgs e)
        {

            if (txtBusquedaPro.Text.Length == 0)
            {
                MessageBox.Show("El campo de busqueda esta vacio");
            }
            else
            {
                string buscar = txtBusquedaPro.Text;
                MySqlDataReader reader = null;

                string sql = "SELECT Nombre, Domicilio, Telefono, Laboratorio, RFC, Correo FROM proveedores WHERE Nombre LIKE '" + buscar + "' LIMIT 1";
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

                            txtNombre.Text = reader.GetString(0);
                            txtDomicilio.Text = reader.GetString(1);
                            txtTelefono.Text = reader.GetString(2);
                            txtLaboratorio.Text = reader.GetString(3);
                            txtRFC.Text = reader.GetString(4);
                            txtCorreo.Text = reader.GetString(5);

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

        private void bttEliminar_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM proveedores WHERE Nombre= '" + txtBusquedaPro.Text + "'";
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
    }
}
     