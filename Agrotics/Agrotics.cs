﻿using System;
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
    }
}
