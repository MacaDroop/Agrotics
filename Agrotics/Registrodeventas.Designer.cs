namespace Agrotics
{
    partial class s
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(s));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombrep = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.txtboton4 = new System.Windows.Forms.Label();
            this.txtboton3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.Label();
            this.txtboton1 = new System.Windows.Forms.Label();
            this.txtboton2 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvRVentas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE VENTAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(359, 133);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(97, 16);
            this.txtFecha.TabIndex = 1;
            this.txtFecha.Text = "Fecha Actual";
            this.txtFecha.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(468, 133);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(62, 16);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "lblfecha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombrep);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dtFecha);
            this.groupBox1.Controls.Add(this.cmbProveedor);
            this.groupBox1.Controls.Add(this.txtboton4);
            this.groupBox1.Controls.Add(this.txtboton3);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.txtboton1);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.txtboton2);
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Location = new System.Drawing.Point(80, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 169);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtNombrep
            // 
            this.txtNombrep.Location = new System.Drawing.Point(38, 36);
            this.txtNombrep.Name = "txtNombrep";
            this.txtNombrep.Size = new System.Drawing.Size(274, 20);
            this.txtNombrep.TabIndex = 21;
            this.txtNombrep.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(559, 92);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(83, 71);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(39, 130);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(274, 20);
            this.dtFecha.TabIndex = 20;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(359, 41);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(274, 21);
            this.cmbProveedor.TabIndex = 17;
            // 
            // txtboton4
            // 
            this.txtboton4.AutoSize = true;
            this.txtboton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboton4.Location = new System.Drawing.Point(360, 17);
            this.txtboton4.Name = "txtboton4";
            this.txtboton4.Size = new System.Drawing.Size(80, 16);
            this.txtboton4.TabIndex = 14;
            this.txtboton4.Text = "Proveedor";
            // 
            // txtboton3
            // 
            this.txtboton3.AutoSize = true;
            this.txtboton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboton3.Location = new System.Drawing.Point(36, 108);
            this.txtboton3.Name = "txtboton3";
            this.txtboton3.Size = new System.Drawing.Size(119, 16);
            this.txtboton3.TabIndex = 13;
            this.txtboton3.Text = "Fecha Estimada";
            this.txtboton3.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoSize = true;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(345, 16);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(0, 16);
            this.txtCantidad.TabIndex = 11;
            this.txtCantidad.Click += new System.EventHandler(this.txtCantidad_Click);
            // 
            // txtboton1
            // 
            this.txtboton1.AutoSize = true;
            this.txtboton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboton1.Location = new System.Drawing.Point(35, 16);
            this.txtboton1.Name = "txtboton1";
            this.txtboton1.Size = new System.Drawing.Size(69, 16);
            this.txtboton1.TabIndex = 9;
            this.txtboton1.Text = "Producto";
            this.txtboton1.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtboton2
            // 
            this.txtboton2.AutoSize = true;
            this.txtboton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboton2.Location = new System.Drawing.Point(35, 64);
            this.txtboton2.Name = "txtboton2";
            this.txtboton2.Size = new System.Drawing.Size(55, 16);
            this.txtboton2.TabIndex = 8;
            this.txtboton2.Text = "Cliente";
            this.txtboton2.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(38, 83);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(274, 21);
            this.cmbCliente.TabIndex = 0;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(756, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSalir.Size = new System.Drawing.Size(41, 33);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(101, 226);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(41, 32);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.BackgroundImage")));
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(179, 226);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(47, 32);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvRVentas
            // 
            this.dgvRVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRVentas.Location = new System.Drawing.Point(80, 291);
            this.dgvRVentas.Name = "dgvRVentas";
            this.dgvRVentas.Size = new System.Drawing.Size(642, 150);
            this.dgvRVentas.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRVentas);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "s";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrodeventas";
            this.Load += new System.EventHandler(this.Registrodeventas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label txtboton1;
        private System.Windows.Forms.Label txtboton2;
        private System.Windows.Forms.Label txtCantidad;
        private System.Windows.Forms.Label txtboton3;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label txtboton4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.DataGridView dgvRVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombrep;
    }
}