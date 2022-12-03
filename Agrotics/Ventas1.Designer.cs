namespace Agrotics.Resources
{
    partial class Ventas1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBuscarProVen = new System.Windows.Forms.TextBox();
            this.btnBuscarProVent = new System.Windows.Forms.Button();
            this.listaProductos = new System.Windows.Forms.ListBox();
            this.ListaPrecios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBuscarProVen
            // 
            this.txtBuscarProVen.Location = new System.Drawing.Point(70, 56);
            this.txtBuscarProVen.Name = "txtBuscarProVen";
            this.txtBuscarProVen.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarProVen.TabIndex = 0;
            // 
            // btnBuscarProVent
            // 
            this.btnBuscarProVent.Location = new System.Drawing.Point(190, 54);
            this.btnBuscarProVent.Name = "btnBuscarProVent";
            this.btnBuscarProVent.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProVent.TabIndex = 1;
            this.btnBuscarProVent.Text = "Buscar";
            this.btnBuscarProVent.UseVisualStyleBackColor = true;
            this.btnBuscarProVent.Click += new System.EventHandler(this.btnBuscarProVent_Click);
            // 
            // listaProductos
            // 
            this.listaProductos.FormattingEnabled = true;
            this.listaProductos.Location = new System.Drawing.Point(52, 295);
            this.listaProductos.Name = "listaProductos";
            this.listaProductos.Size = new System.Drawing.Size(180, 95);
            this.listaProductos.TabIndex = 2;
            // 
            // ListaPrecios
            // 
            this.ListaPrecios.FormattingEnabled = true;
            this.ListaPrecios.Location = new System.Drawing.Point(231, 295);
            this.ListaPrecios.Name = "ListaPrecios";
            this.ListaPrecios.Size = new System.Drawing.Size(130, 95);
            this.ListaPrecios.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "$0";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 209);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad:";
            // 
            // Ventas1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaPrecios);
            this.Controls.Add(this.listaProductos);
            this.Controls.Add(this.btnBuscarProVent);
            this.Controls.Add(this.txtBuscarProVen);
            this.Name = "Ventas1";
            this.Text = "Ventas1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarProVen;
        private System.Windows.Forms.Button btnBuscarProVent;
        private System.Windows.Forms.ListBox listaProductos;
        private System.Windows.Forms.ListBox ListaPrecios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}