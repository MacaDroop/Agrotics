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
        public Cultivos()
        {
            InitializeComponent();
        }

        private void Cultivos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path =
       new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 25; //modificar esta variable para el border radius
            path.AddArc(0, 0, arcSize, arcSize, 180, 90);
            path.AddArc(button1.Width - arcSize, 0, arcSize, arcSize, 270, 90);
            path.AddArc(button1.Width - arcSize, button1.Height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(0, button1.Height - arcSize, arcSize, arcSize, 90, 90);
            path.CloseAllFigures();
            button1.Region = new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductosCultivo mensajero = new ProductosCultivo();
            mensajero.Show();
        }
    }
}
