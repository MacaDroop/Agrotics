
namespace Agrotics
{
    partial class Productos
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
            this.txtBuscarpro = new System.Windows.Forms.TextBox();
            this.btnBuscarPro = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttAg = new System.Windows.Forms.Button();
            this.bttEd = new System.Windows.Forms.Button();
            this.bttEli = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbldosis = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblcaducidad = new System.Windows.Forms.Label();
            this.txtNombrePro = new System.Windows.Forms.TextBox();
            this.txtDescripcionPro = new System.Windows.Forms.TextBox();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaCaducidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarpro
            // 
            this.txtBuscarpro.Location = new System.Drawing.Point(65, 66);
            this.txtBuscarpro.Name = "txtBuscarpro";
            this.txtBuscarpro.Size = new System.Drawing.Size(144, 20);
            this.txtBuscarpro.TabIndex = 0;
            // 
            // btnBuscarPro
            // 
            this.btnBuscarPro.BackgroundImage = global::Agrotics.Properties.Resources.icons8_búsqueda_usuaria_100;
            this.btnBuscarPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPro.Location = new System.Drawing.Point(228, 59);
            this.btnBuscarPro.Name = "btnBuscarPro";
            this.btnBuscarPro.Size = new System.Drawing.Size(129, 33);
            this.btnBuscarPro.TabIndex = 1;
            this.btnBuscarPro.Text = "Buscar";
            this.btnBuscarPro.UseVisualStyleBackColor = true;
            this.btnBuscarPro.Click += new System.EventHandler(this.bttBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(359, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(355, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // bttAg
            // 
            this.bttAg.BackgroundImage = global::Agrotics.Properties.Resources.icons8_añadir_usuario_grupo_mujer_hombre_100;
            this.bttAg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAg.Location = new System.Drawing.Point(359, 310);
            this.bttAg.Name = "bttAg";
            this.bttAg.Size = new System.Drawing.Size(97, 39);
            this.bttAg.TabIndex = 3;
            this.bttAg.Text = "Agregar";
            this.bttAg.UseVisualStyleBackColor = true;
            this.bttAg.Click += new System.EventHandler(this.bttAg_Click);
            // 
            // bttEd
            // 
            this.bttEd.BackgroundImage = global::Agrotics.Properties.Resources.icons8_retire_hombre_usuario_100;
            this.bttEd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttEd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttEd.Location = new System.Drawing.Point(486, 310);
            this.bttEd.Name = "bttEd";
            this.bttEd.Size = new System.Drawing.Size(93, 39);
            this.bttEd.TabIndex = 4;
            this.bttEd.Text = "Eliminar";
            this.bttEd.UseVisualStyleBackColor = true;
            this.bttEd.Click += new System.EventHandler(this.bttEd_Click);
            // 
            // bttEli
            // 
            this.bttEli.BackgroundImage = global::Agrotics.Properties.Resources.icons8_editar_usuaria_100;
            this.bttEli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttEli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttEli.Location = new System.Drawing.Point(615, 308);
            this.bttEli.Name = "bttEli";
            this.bttEli.Size = new System.Drawing.Size(90, 41);
            this.bttEli.TabIndex = 5;
            this.bttEli.Text = "Editar";
            this.bttEli.UseVisualStyleBackColor = true;
            this.bttEli.Click += new System.EventHandler(this.bttEli_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(12, 120);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(106, 13);
            this.lblnombre.TabIndex = 6;
            this.lblnombre.Text = "Nombre del producto";
            // 
            // lbldosis
            // 
            this.lbldosis.AutoSize = true;
            this.lbldosis.Location = new System.Drawing.Point(12, 162);
            this.lbldosis.Name = "lbldosis";
            this.lbldosis.Size = new System.Drawing.Size(63, 13);
            this.lbldosis.TabIndex = 7;
            this.lbldosis.Text = "Descripcion";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(12, 247);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(37, 13);
            this.lblprecio.TabIndex = 8;
            this.lblprecio.Text = "Precio";
            // 
            // lblcaducidad
            // 
            this.lblcaducidad.AutoSize = true;
            this.lblcaducidad.Location = new System.Drawing.Point(12, 291);
            this.lblcaducidad.Name = "lblcaducidad";
            this.lblcaducidad.Size = new System.Drawing.Size(58, 13);
            this.lblcaducidad.TabIndex = 9;
            this.lblcaducidad.Text = "Caducidad";
            this.lblcaducidad.Click += new System.EventHandler(this.lblcaducidad_Click);
            // 
            // txtNombrePro
            // 
            this.txtNombrePro.Location = new System.Drawing.Point(124, 117);
            this.txtNombrePro.Name = "txtNombrePro";
            this.txtNombrePro.Size = new System.Drawing.Size(168, 20);
            this.txtNombrePro.TabIndex = 10;
            // 
            // txtDescripcionPro
            // 
            this.txtDescripcionPro.Location = new System.Drawing.Point(124, 162);
            this.txtDescripcionPro.Name = "txtDescripcionPro";
            this.txtDescripcionPro.Size = new System.Drawing.Size(168, 20);
            this.txtDescripcionPro.TabIndex = 11;
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.Location = new System.Drawing.Point(124, 200);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(168, 20);
            this.txtLaboratorio.TabIndex = 12;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(124, 240);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(168, 20);
            this.txtPrecio.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Laboratorio";
            // 
            // txtFechaCaducidad
            // 
            this.txtFechaCaducidad.Location = new System.Drawing.Point(124, 288);
            this.txtFechaCaducidad.Name = "txtFechaCaducidad";
            this.txtFechaCaducidad.Size = new System.Drawing.Size(168, 20);
            this.txtFechaCaducidad.TabIndex = 15;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 418);
            this.Controls.Add(this.txtFechaCaducidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtLaboratorio);
            this.Controls.Add(this.txtDescripcionPro);
            this.Controls.Add(this.txtNombrePro);
            this.Controls.Add(this.lblcaducidad);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lbldosis);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.bttEli);
            this.Controls.Add(this.bttEd);
            this.Controls.Add(this.bttAg);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarPro);
            this.Controls.Add(this.txtBuscarpro);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarpro;
        private System.Windows.Forms.Button btnBuscarPro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttAg;
        private System.Windows.Forms.Button bttEd;
        private System.Windows.Forms.Button bttEli;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbldosis;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblcaducidad;
        private System.Windows.Forms.TextBox txtNombrePro;
        private System.Windows.Forms.TextBox txtDescripcionPro;
        private System.Windows.Forms.TextBox txtLaboratorio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFechaCaducidad;
    }
}