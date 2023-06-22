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
        public string TextoBotonMaiz
        {
            get { return btnMaiz.Text; }
        }
        private void Cultivos_Load(object sender, EventArgs e)
        {
            
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
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
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
    }
}
