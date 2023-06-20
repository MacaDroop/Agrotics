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
    public partial class Asesoria : Form
    {
        public Asesoria()
        {
            InitializeComponent();
        }

        private void cmbTipoCultivo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
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
    }
}
