using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agrotics.Resources
{
    public partial class Ventas1 : Form
    {
        public Ventas1()
        {
            InitializeComponent();
        }

        private void btnBuscarProVent_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtBuscarProVen.TextLength == 0) {
                MessageBox.Show("PRIMERO SELECCIONA LA CANTIDAD DE PRODUCTOS A VENDER");
            
            }
            else
            {

            }
        }

        private void Ventas1_Load(object sender, EventArgs e)
        {

        }
    }
}
