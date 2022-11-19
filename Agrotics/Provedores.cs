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
                string sql = "INSERT INTO provedores (Nombre, Domicilio, Telefono, Laboratorio, RFC, Correo) VALUES ('" + nombre + "', '" + Domicilio + "', '" + Telefono + "', '" + Laboratorio + "', '" + RFC + "', '" + Correo + "')";
                MySqlConnection conexionBD = Conexion.conexion();
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
    }
}
