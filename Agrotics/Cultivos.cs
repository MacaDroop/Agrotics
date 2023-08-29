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
    public partial class Cultivos : Form
    {
        public String ValorEnviado { get; set; }
        public Cultivos()
        {
            InitializeComponent();

        }



        //SE NECESITA TENER TODOS LOS BOTONES CONFIGURADOS PARA HABILITAR ESTE METODO Y NO TENER ERRORES
        /*  public void CheckedListUpdate()
          {

              string[] elementos = { Properties.Settings.Default.Caña, Properties.Settings.Default.Maiz};
              //PIÑA SANDIA CAÑA CHILE MAIZ FRIJOL
              checkedListBox1.Items.AddRange(elementos);

          }*/

        private void MostrarMessageBox()
        {
            DialogResult resultado = MessageBox.Show("¿Los nuevos cambios son "
                +Properties.Settings.Default.Maiz1
                +txtCultivo1.Text+" "
                
                , "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // El usuario hizo clic en "Sí"
                MessageBox.Show("Has seleccionado Sí.", "Resultado");
                
            }
            else if (resultado == DialogResult.No)
            {
                // El usuario hizo clic en "No"
                MessageBox.Show("Has seleccionado No.", "Resultado");
            }
        }

        public string TextoBotonMaiz
        {
            get { return btnMaiz.Text; }
        }
        private void Cultivos_Load(object sender, EventArgs e)

            
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }

            //SE OBTIENE EL VALOR POR DEFECTO DEL BOTON Y SE ALMACENA EN EL TXT
            txtCultivo1.Text = Properties.Settings.Default.Piña;
            txtCultivo2.Text = Properties.Settings.Default.Sandia;
            txtCultivo3.Text = Properties.Settings.Default.Caña;
            txtCultivo4.Text = Properties.Settings.Default.Chile;
            txtCultivo5.Text = Properties.Settings.Default.Maiz1;
            txtCultivo6.Text = Properties.Settings.Default.Frijol;
            //CON PROPERTIES.RESOURCES SE ACCEDE A LAS IMAGENES QUE ESTAN EN RESOURCES

            //CheckedListUpdate();
        }
    
        private void button2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductosCultivo mensajero = new ProductosCultivo();
            mensajero.ValorEnviado = "Piña";
            mensajero.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductosCultivo mensajero = new ProductosCultivo();
            mensajero.ValorEnviado = "Maiz";
            mensajero.Show();
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
          
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            btnMaiz.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            btnCaña.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductosCultivo mensajero = new ProductosCultivo();
            mensajero.ValorEnviado = "Sandia";
            mensajero.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductosCultivo mensajero = new ProductosCultivo();
            mensajero.ValorEnviado = "Frijol";
            mensajero.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductosCultivo mensajero = new ProductosCultivo();
            mensajero.ValorEnviado = "Chile";
            mensajero.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductosCultivo mensajero = new ProductosCultivo();
            mensajero.ValorEnviado = "Caña";
            mensajero.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //VERIFICAR SI ESTA ACTIVO EL BOTON DEL MAIZ
            if (checkedListBox1.CheckedItems.Contains(checkedListBox1.Items[4]))
            {
                btnMaiz.Enabled = Properties.Settings.Default.AcitvarBoton = true; // Cambia el valor a false para desactivar el botón
                Properties.Settings.Default.Save();
            }
            else
            {
                btnMaiz.Enabled = Properties.Settings.Default.AcitvarBoton = false; // Cambia el valor a false para desactivar el botón
                Properties.Settings.Default.Save();
            }

            //VERIFICAR SI ESTA ACTIVO EL BOTON DEL FRIJOL
            if (checkedListBox1.CheckedItems.Contains(checkedListBox1.Items[5]))
            {
                btnFrijol.Enabled = Properties.Settings.Default.ActivarFrijol = true; // Cambia el valor a false para desactivar el botón
                Properties.Settings.Default.Save();
            }
            else
            {
                btnFrijol.Enabled = Properties.Settings.Default.ActivarFrijol = false; // Cambia el valor a false para desactivar el botón
                Properties.Settings.Default.Save();
            }

            //VERIFICAR SI ESTA ACTIVO EL BOTON DE LA CAÑA
            if (checkedListBox1.CheckedItems.Contains(checkedListBox1.Items[2]))
            {
                btnCaña.Enabled = Properties.Settings.Default.ActivarCaña = true; // Cambia el valor a false para desactivar el botón
                Properties.Settings.Default.Save();
            }
            else
            {
                btnCaña.Enabled = Properties.Settings.Default.ActivarCaña = false; // Cambia el valor a false para desactivar el botón
                Properties.Settings.Default.Save();
            }

            //VERIFICAR SI ESTA ACTIVO EL BOTON DEL CHILE
            if (checkedListBox1.CheckedItems.Contains(checkedListBox1.Items[3]))
            {
                btnChile.Enabled = Properties.Settings.Default.ActivarChile = true; // Cambia el valor a false para desactivar el botón
                Properties.Settings.Default.Save();
            }
            else
            {
                btnChile.Enabled = Properties.Settings.Default.ActivarChile = false; // Cambia el valor a false para desactivar el botón
                Properties.Settings.Default.Save();
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MostrarMessageBox(); //MENSAJE DE CONFIRMACION DE GUARDADO
            btnPiña1.Text = Properties.Settings.Default.Piña = txtCultivo1.Text;
            btnMaiz.Text = Properties.Settings.Default.Maiz = txtCultivo5.Text;
            btnCaña.Text = Properties.Settings.Default.Caña = txtCultivo3.Text;
            Properties.Settings.Default.Save();

           

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnPiña1_Click(object sender, EventArgs e)
        {
            ProductosCultivo mensajero = new ProductosCultivo();
            mensajero.ValorEnviado = "Piña";
            mensajero.Show();
        }
    }
}
