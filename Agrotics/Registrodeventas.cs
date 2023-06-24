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
    public partial class s : Form
    {
        public s()
        {
            InitializeComponent();
        }

        private void MostrarTodasVentas()
        {
            MySqlDataReader reader = null;
            string sql = "SELECT * FROM registroventas";
            MySqlConnection conexionBD = Conexion2.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable datos = new DataTable();

                    datos.Load(reader);
                    dgvRVentas.DataSource = datos;
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
        private void MostrarProductoVen()
        {
            MySqlDataReader reader = null;
            string sql = "SELECT * FROM registroventas WHERE NombreProducto LIKE '%" + txtNombrep + "%'";

            MySqlConnection conexionBD = Conexion2.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable datos = new DataTable();

                    datos.Load(reader);
                    dgvRVentas.DataSource = datos;
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
        private void Registrodeventas_Load(object sender, EventArgs e)
        {
            MostrarTodasVentas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void lvVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtFecha.Value;
            label2.Text = fechaSeleccionada.ToString("dd/MM/yyyy");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MostrarProductoVen();
        }
    }
}
