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
        //INSTANCIA DE LA CLASE REC
        Rec mensajero = new Rec();
        public Asesoria()
        {
            InitializeComponent();
        }

        private void cmbTipoCultivo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void QueryErwinia()
        {
            try
            {
                string Sql = "SELECT NombreProducto, DescripcionCultivos, Precio, Stock, Tipo, Presentacion FROM productos WHERE NombreProducto = 'Kasugamicina'";
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
        private void QueryFusarium()
        {
            try
            {
                string Sql = "SELECT NombreProducto, DescripcionCultivos, Precio, Stock, Tipo, Presentacion,  FROM productos WHERE NombreProducto IN ('Fenbuconazole', 'METIL TIOFANATO', 'Carvendasim', 'Tiabendazol', 'Tiazolil', 'Benzimidazol')";
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
                                txtRecomendacion.Text = mensajero.Fusarium();
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

        private void QueryPhytophthotora()
        {
            try
            {
                string Sql = "SELECT NombreProducto, DescripcionCultivos, Precio, Stock, Tipo, Presentacion,  FROM productos WHERE NombreProducto = 'Metalaxil'";
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
                                txtRecomendacion.Text = mensajero.Phytophthora();
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

        private void Diuron()
        {
            try
            {
                string Sql = "SELECT NombreProducto, DescripcionCultivos, Precio, Stock, Tipo, Presentacion FROM productos WHERE NombreProducto = 'Diuron'";
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
            
                                txtRecomendacion.Text = "UTILIZAR A PARTIR DE 5 MESES EN ADELANTE";
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

        private void Ametrina()
        {
            try
            {
                string Sql = "SELECT NombreProducto, DescripcionCultivos, Precio, Stock, Tipo, Presentacion FROM productos WHERE NombreProducto = 'Ametrina'";
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

                                txtRecomendacion.Text = "CAMBIAR DE PRODUCTO PARA NO GENERAR RESISTENCIA....";
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
        //metodo para seleccion de sintomas
        private void pruebaChecked()
        {
            bool s1 = checkedListBox1.GetItemChecked(0);
            bool s2 = checkedListBox1.GetItemChecked(1);
            bool s3 = checkedListBox1.GetItemChecked(2);
            bool s4 = checkedListBox1.GetItemChecked(3);
            
            bool s5 = checkedListBox2.GetItemChecked(0);
            bool s6 = checkedListBox2.GetItemChecked(1);
            bool s7 = checkedListBox2.GetItemChecked(2);
            bool s8 = checkedListBox2.GetItemChecked(3);
            bool s9 = checkedListBox2.GetItemChecked(4);
            bool s10 = checkedListBox2.GetItemChecked(5);

            bool s11 = checkedListBox3.GetItemChecked(0);
            bool s12 = checkedListBox3.GetItemChecked(1);
            bool s13 = checkedListBox3.GetItemChecked(2);
            
            //CASO EW
            if(s1 && s2 && s3 && s4 == true)
            {
                //SE EJECUTA EL METODO DE CONSULTA
                QueryErwinia();
                txtRecomendacion.Text = mensajero.Erwinia();
                TABCONTROL.SelectedTab = tbDiagnostico;
                ObtenerElementosSeleccionadosYAgregarAListBox();
                lblEnfermedad.Text = "BACTERIA ERWINIA";
            }
            //CS FS
            if(s5 && s6 && s7 & s8 == true || s2 && s3 && s5 && s6 && s7 && s8 || s3 && s5 && s8)
            {
                MessageBox.Show("OK");
                ObtenerElementosSeleccionadosYAgregarAListBox();
                //QueryFusarium();
                txtRecomendacion.Text = mensajero.Fusarium();
                QueryFusarium();
                TABCONTROL.SelectedTab = tbDiagnostico;
               
                lblEnfermedad.Text = "FUSARIOSIS (FUSARIUM)";
            }

            if(s2 && s9 && s10 == true)
            {
                MessageBox.Show("PHYTOPHTHORA");
                ObtenerElementosSeleccionadosYAgregarAListBox();
                txtRecomendacion.Text = mensajero.Phytophthora();
                QueryPhytophthotora();
                lblEnfermedad.Text = "PHYTOPHTHORA";
                TABCONTROL.SelectedTab = tbDiagnostico;
               
            }

            if (s2 && s5 && s9 == true)
            {
                MessageBox.Show("combinación");
                ObtenerElementosSeleccionadosYAgregarAListBox();
                lblEnfermedad.Text = "[ERWINIA, FUSARIUM, PHYTOPHTHORA]";
                txtRecomendacion.Text = mensajero.recomendacion();
                TABCONTROL.SelectedTab = tbDiagnostico;
            }

            if(s13 == true)
            {
                if(txtUltimoProducto.Text == "Ametrina")
                {
                    ObtenerElementosSeleccionadosYAgregarAListBox();
                    lblEnfermedad.Text = "APLICACION DE HERBICIDA";
                    TABCONTROL.SelectedTab = tbDiagnostico;
                    Diuron();
                }
                else
                {
                    ObtenerElementosSeleccionadosYAgregarAListBox();
                    lblEnfermedad.Text = "APLICACION DE HERBICIDA";
                    TABCONTROL.SelectedTab = tbDiagnostico;
                    Ametrina();
                }
                

            }

            if(s11 == true)
            {
                if (txtUltimoProducto.Text == "Diuron")
                {
                    ObtenerElementosSeleccionadosYAgregarAListBox();
                    lblEnfermedad.Text = "APLICACION DE HERBICIDA";
                    TABCONTROL.SelectedTab = tbDiagnostico;
                    Ametrina();
                }
                else
                {
                    ObtenerElementosSeleccionadosYAgregarAListBox();
                    lblEnfermedad.Text = "APLICACION DE HERBICIDA";
                    TABCONTROL.SelectedTab = tbDiagnostico;
                    Diuron();
                }
              
            }
        }

        //obtener los valores clickeados
        private void ObtenerElementosSeleccionadosYAgregarAListBox()
        {
            // Crea una lista para almacenar los elementos seleccionados
            List<string> elementosSeleccionados = new List<string>();

            // Recorre el primer CheckedListBox
            foreach (object item in checkedListBox1.CheckedItems)
            {
                elementosSeleccionados.Add(item.ToString());
            }

            // Recorre el segundo CheckedListBox
            foreach (object item in checkedListBox2.CheckedItems)
            {
                elementosSeleccionados.Add(item.ToString());
            }

            // Agrega los elementos seleccionados al ListBox
            sintomasClicked.Items.Clear(); // Limpia el ListBox antes de agregar los elementos
            sintomasClicked.Items.AddRange(elementosSeleccionados.ToArray());
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
            //Rec mensajero = new Rec();
            //txtRecomendacion.Text = mensajero.Erwinia();
            //TABCONTROL.SelectedTab = tbDiagnostico;
            
            pruebaChecked();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            checkedListBox1.SelectedItem = false;
        }
    }
}
