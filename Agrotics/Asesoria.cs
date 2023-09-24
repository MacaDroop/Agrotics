using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Agrotics
{
    public partial class Asesoria : Form
    {
        public Asesoria()
        {
            InitializeComponent();
        }

        private void cmbTipoCultivo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void sintomaList1()
        {
            
            int contadorChequeados = 0;

            foreach (object item in checkedListBox1.CheckedItems)
            {
                contadorChequeados++;

                if (contadorChequeados >= 2)
                {
                    // Si al menos dos elementos están marcados como verdaderos, puedes salir del bucle
                    break;
                }
            }

            if (contadorChequeados >= 2)
            {
                // Al menos dos elementos están marcados como verdaderos
                try
                {
                    string Sql = "SELECT NombreProducto, DescripcionCultivos, Precio, Stock, Tipo, Presentacion,  FROM productos WHERE NombreProducto = 'Kasugamicina'" ;
                    using (MySqlConnection conexionBD = Conexion2.conexion())
                    {
                        conexionBD.Open();
                        using (MySqlCommand comando = new MySqlCommand(Sql, conexionBD))
                        {
                            using (MySqlDataReader reader = comando.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    DataTable datos = new DataTable();
                                    datos.Load(reader);
                                    dgvResultados.DataSource = datos;
                                    Rec mensajero = new Rec();
                                    txtRecomendacion.Text = mensajero.Erwinia();
                                }
                                else
                                {
                                    MessageBox.Show("SE REQUIERE DE MÁS INFORMACIÓN...");
                                    // No se encontraron resultados, puedes mostrar un mensaje o realizar otra acción.
                                }
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    // Manejo de excepciones de MySQL, por ejemplo, conexión fallida, consulta inválida, etc.
                    MessageBox.Show("Error de MySQL: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones generales, como problemas no relacionados con MySQL.
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("SE REQUIEREN MÁS DATOS...");
                // Menos de dos elementos están marcados como verdaderos
                // Puedes realizar otra acción aquí si es necesario
            }
        }
        private void cmbTipoCultivo_SelectedValueChanged(object sender, EventArgs e)
        {
            string valorSeleccionado = cmbTipoCultivo.SelectedItem.ToString();

            foreach (TabPage tabPage in tcSintomas.TabPages)
            {
                if (tabPage.Name == "tp" + valorSeleccionado)
                {
                    tcSintomas.SelectTab(tabPage);
                }
                else
                {
                    tabPage.Enabled = false;
                   
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Asesoria_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //sintomaList1();
            Rec mensajero = new Rec();
            txtRecomendacion.Text = mensajero.Erwinia();
            TABCONTROL.SelectedTab = tbDiagnostico;
        }
    }
}
