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
            timer1.Interval = 700; // Intervalo de 0.1 segundos
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
            notify.ShowBalloonTip(3000, "STOCK", "Algunos productos están por acabarse", ToolTipIcon.Info);
            ;        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            Ventas1 form = new Ventas1();
            form.Show();

        }

        private void toolTip3_Popup(object sender, PopupEventArgs e)
        {

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

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
