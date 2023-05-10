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
    }
}
