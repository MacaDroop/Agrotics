using Agrotics.Resources;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Provedores form = new Provedores();
                form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Productos form = new Productos();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cultivos form = new Cultivos();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            Ventas1 form = new Ventas1();
            form.Show();
        
        }

        private void btnventas_MouseHover(object sender, EventArgs e)
        {
            btnventas.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnProveedores_MouseHover(object sender, EventArgs e)
        {
            btnProveedores.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnCultivos_MouseHover(object sender, EventArgs e)
        {
            btnCultivos.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnProductos_MouseHover(object sender, EventArgs e)
        {
            btnProductos.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void toolTip3_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
