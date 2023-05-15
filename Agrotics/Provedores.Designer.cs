
namespace Agrotics
{
    partial class Provedores
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
            this.txtBusquedaPro = new System.Windows.Forms.TextBox();
            this.dgvprovedores = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btteditar = new System.Windows.Forms.Button();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.bttagregar = new System.Windows.Forms.Button();
            this.bttbusqueda = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprovedores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusquedaPro
            // 
            this.txtBusquedaPro.Location = new System.Drawing.Point(351, 30);
            this.txtBusquedaPro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBusquedaPro.Name = "txtBusquedaPro";
            this.txtBusquedaPro.Size = new System.Drawing.Size(292, 20);
            this.txtBusquedaPro.TabIndex = 0;
            this.txtBusquedaPro.Text = "BUSCAR PROVEEDOR";
            this.txtBusquedaPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBusquedaPro.TextChanged += new System.EventHandler(this.txtBusquedaPro_TextChanged);
            // 
            // dgvprovedores
            // 
            this.dgvprovedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprovedores.Location = new System.Drawing.Point(351, 72);
            this.dgvprovedores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvprovedores.Name = "dgvprovedores";
            this.dgvprovedores.Size = new System.Drawing.Size(470, 224);
            this.dgvprovedores.TabIndex = 2;
            this.dgvprovedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprovedores_CellContentClick);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(156, 82);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(161, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(156, 119);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(161, 20);
            this.txtDomicilio.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Docimilio";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(79, 89);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 13);
            this.label.TabIndex = 9;
            this.label.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Laboratorio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "RFC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Correo";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(156, 159);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(161, 20);
            this.txtTelefono.TabIndex = 14;
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.Location = new System.Drawing.Point(156, 192);
            this.txtLaboratorio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(161, 20);
            this.txtLaboratorio.TabIndex = 15;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(156, 232);
            this.txtRFC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(161, 20);
            this.txtRFC.TabIndex = 16;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(156, 266);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(161, 20);
            this.txtCorreo.TabIndex = 17;
            // 
            // btteditar
            // 
            this.btteditar.BackgroundImage = global::Agrotics.Properties.Resources.icons8_editar_usuaria_100;
            this.btteditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btteditar.FlatAppearance.BorderSize = 0;
            this.btteditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btteditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btteditar.Location = new System.Drawing.Point(687, 302);
            this.btteditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btteditar.Name = "btteditar";
            this.btteditar.Size = new System.Drawing.Size(75, 48);
            this.btteditar.TabIndex = 5;
            this.btteditar.UseVisualStyleBackColor = true;
            this.btteditar.Click += new System.EventHandler(this.btteditar_Click);
            // 
            // bttEliminar
            // 
            this.bttEliminar.BackColor = System.Drawing.Color.Transparent;
            this.bttEliminar.BackgroundImage = global::Agrotics.Properties.Resources.icons8_retire_hombre_usuario_100;
            this.bttEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttEliminar.FlatAppearance.BorderSize = 0;
            this.bttEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttEliminar.Location = new System.Drawing.Point(555, 302);
            this.bttEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(88, 48);
            this.bttEliminar.TabIndex = 4;
            this.bttEliminar.UseVisualStyleBackColor = false;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // bttagregar
            // 
            this.bttagregar.BackgroundImage = global::Agrotics.Properties.Resources.icons8_añadir_usuario_grupo_mujer_hombre_100;
            this.bttagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttagregar.FlatAppearance.BorderSize = 0;
            this.bttagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttagregar.Location = new System.Drawing.Point(428, 302);
            this.bttagregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttagregar.Name = "bttagregar";
            this.bttagregar.Size = new System.Drawing.Size(88, 48);
            this.bttagregar.TabIndex = 3;
            this.bttagregar.UseVisualStyleBackColor = true;
            this.bttagregar.Click += new System.EventHandler(this.bttagregar_Click);
            // 
            // bttbusqueda
            // 
            this.bttbusqueda.BackColor = System.Drawing.Color.Transparent;
            this.bttbusqueda.BackgroundImage = global::Agrotics.Properties.Resources.lupa;
            this.bttbusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttbusqueda.FlatAppearance.BorderSize = 0;
            this.bttbusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttbusqueda.Location = new System.Drawing.Point(669, 12);
            this.bttbusqueda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttbusqueda.Name = "bttbusqueda";
            this.bttbusqueda.Size = new System.Drawing.Size(93, 54);
            this.bttbusqueda.TabIndex = 1;
            this.bttbusqueda.Text = " ";
            this.bttbusqueda.UseVisualStyleBackColor = false;
            this.bttbusqueda.Click += new System.EventHandler(this.bttbusqueda_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "AGREGAR PROVEEDOR";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Provedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(840, 403);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtLaboratorio);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btteditar);
            this.Controls.Add(this.bttEliminar);
            this.Controls.Add(this.bttagregar);
            this.Controls.Add(this.dgvprovedores);
            this.Controls.Add(this.bttbusqueda);
            this.Controls.Add(this.txtBusquedaPro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Provedores";
            this.Text = "Provedores";
            this.Load += new System.EventHandler(this.Provedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvprovedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusquedaPro;
        private System.Windows.Forms.Button bttbusqueda;
        private System.Windows.Forms.DataGridView dgvprovedores;
        private System.Windows.Forms.Button bttagregar;
        private System.Windows.Forms.Button bttEliminar;
        private System.Windows.Forms.Button btteditar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtLaboratorio;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox textBox1;
    }
}