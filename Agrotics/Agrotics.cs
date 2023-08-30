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
        //para la animacion del titulo
        private string fullText = "AGROTICS";
        private int currentIndex = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 400; // Intervalo de 0.1 segundos
            timer1.Tick += timer1_Tick;
        }
        public void manita()
        {
            Cursor = Cursors.Hand;
        }

        public void cursorDefec()
        {
            Cursor = Cursors.Default;
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
            timer1.Start();
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

        private void btnventas_MouseEnter(object sender, EventArgs e)
        {
            manita();
        }

        private void btnventas_MouseLeave(object sender, EventArgs e)
        {
            cursorDefec();
        }

        private void btnProveedores_MouseEnter(object sender, EventArgs e)
        {
            manita();
        }

        private void btnProveedores_MouseLeave(object sender, EventArgs e)
        {
            cursorDefec();
        }

        private void btnCultivos_MouseEnter(object sender, EventArgs e)
        {
            manita();
        }

        private void btnCultivos_MouseLeave(object sender, EventArgs e)
        {
            cursorDefec();
        }

        private void btnProductos_MouseEnter(object sender, EventArgs e)
        {
            manita();
        }

        private void btnProductos_MouseLeave(object sender, EventArgs e)
        {
            cursorDefec();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            s mensajero = new s();
            mensajero.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           Asesoria mensajero = new Asesoria();
            mensajero.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentIndex < fullText.Length)
            {
                lblTitulo.Text += fullText[currentIndex];
                currentIndex++;
            }
            else
            {
                timer1.Stop(); // Detener el temporizador cuando se ha mostrado todo el texto
            }
        }
    }
}
