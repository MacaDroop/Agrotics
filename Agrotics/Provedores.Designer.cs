
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
            this.btteditar = new System.Windows.Forms.Button();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.bttagregar = new System.Windows.Forms.Button();
            this.bttbusqueda = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvprovedores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusquedaPro
            // 
            this.txtBusquedaPro.Location = new System.Drawing.Point(67, 72);
            this.txtBusquedaPro.Name = "txtBusquedaPro";
            this.txtBusquedaPro.Size = new System.Drawing.Size(202, 20);
            this.txtBusquedaPro.TabIndex = 0;
            // 
            // dgvprovedores
            // 
            this.dgvprovedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprovedores.Location = new System.Drawing.Point(409, 128);
            this.dgvprovedores.Name = "dgvprovedores";
            this.dgvprovedores.Size = new System.Drawing.Size(363, 150);
            this.dgvprovedores.TabIndex = 2;
            // 
            // btteditar
            // 
            this.btteditar.BackgroundImage = global::Agrotics.Properties.Resources.icons8_editar_usuaria_100;
            this.btteditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btteditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btteditar.Location = new System.Drawing.Point(662, 313);
            this.btteditar.Name = "btteditar";
            this.btteditar.Size = new System.Drawing.Size(75, 48);
            this.btteditar.TabIndex = 5;
            this.btteditar.Text = "Editar";
            this.btteditar.UseVisualStyleBackColor = true;
            this.btteditar.Click += new System.EventHandler(this.btteditar_Click);
            // 
            // bttEliminar
            // 
            this.bttEliminar.BackgroundImage = global::Agrotics.Properties.Resources.icons8_retire_hombre_usuario_100;
            this.bttEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttEliminar.Location = new System.Drawing.Point(536, 313);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(75, 48);
            this.bttEliminar.TabIndex = 4;
            this.bttEliminar.Text = "Eliminar";
            this.bttEliminar.UseVisualStyleBackColor = true;
            // 
            // bttagregar
            // 
            this.bttagregar.BackgroundImage = global::Agrotics.Properties.Resources.icons8_añadir_usuario_grupo_mujer_hombre_100;
            this.bttagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttagregar.Location = new System.Drawing.Point(409, 313);
            this.bttagregar.Name = "bttagregar";
            this.bttagregar.Size = new System.Drawing.Size(75, 48);
            this.bttagregar.TabIndex = 3;
            this.bttagregar.Text = "Agregar";
            this.bttagregar.UseVisualStyleBackColor = true;
            this.bttagregar.Click += new System.EventHandler(this.bttagregar_Click);
            // 
            // bttbusqueda
            // 
            this.bttbusqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttbusqueda.BackgroundImage = global::Agrotics.Properties.Resources.icons8_búsqueda_usuaria_100;
            this.bttbusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttbusqueda.Location = new System.Drawing.Point(282, 56);
            this.bttbusqueda.Name = "bttbusqueda";
            this.bttbusqueda.Size = new System.Drawing.Size(128, 50);
            this.bttbusqueda.TabIndex = 1;
            this.bttbusqueda.Text = "Busqueda";
            this.bttbusqueda.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 140);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(79, 177);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(100, 20);
            this.txtDomicilio.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Docimilio";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 147);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(44, 13);
            this.label.TabIndex = 9;
            this.label.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Laboratorio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "RFC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Correo";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(79, 217);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 14;
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.Location = new System.Drawing.Point(79, 250);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(100, 20);
            this.txtLaboratorio.TabIndex = 15;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(79, 290);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(100, 20);
            this.txtRFC.TabIndex = 16;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(79, 324);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 17;
            // 
            // Provedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 450);
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
    }
}