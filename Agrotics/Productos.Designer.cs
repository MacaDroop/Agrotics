
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.bttAg = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbldosis = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblcaducidad = new System.Windows.Forms.Label();
            this.txtNombrePro = new System.Windows.Forms.TextBox();
            this.txtDescripcionPro = new System.Windows.Forms.TextBox();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaducidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtPresentacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCultivos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarpro
            // 
            this.txtBuscarpro.Location = new System.Drawing.Point(21, 35);
            this.txtBuscarpro.Name = "txtBuscarpro";
            this.txtBuscarpro.Size = new System.Drawing.Size(209, 20);
            this.txtBuscarpro.TabIndex = 0;
            // 
            // btnBuscarPro
            // 
            this.btnBuscarPro.BackgroundImage = global::Agrotics.Properties.Resources.icons8_búsqueda_usuaria_100;
            this.btnBuscarPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPro.Location = new System.Drawing.Point(236, 28);
            this.btnBuscarPro.Name = "btnBuscarPro";
            this.btnBuscarPro.Size = new System.Drawing.Size(129, 33);
            this.btnBuscarPro.TabIndex = 1;
            this.btnBuscarPro.Text = "Buscar";
            this.btnBuscarPro.UseVisualStyleBackColor = true;
            this.btnBuscarPro.Click += new System.EventHandler(this.bttBuscar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(359, 120);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(355, 150);
            this.dgvProductos.TabIndex = 2;
            // 
            // bttAg
            // 
            this.bttAg.BackColor = System.Drawing.Color.Transparent;
            this.bttAg.BackgroundImage = global::Agrotics.Properties.Resources.icons8_añadir_usuario_grupo_mujer_hombre_100;
            this.bttAg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttAg.FlatAppearance.BorderSize = 0;
            this.bttAg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAg.Location = new System.Drawing.Point(359, 308);
            this.bttAg.Name = "bttAg";
            this.bttAg.Size = new System.Drawing.Size(97, 39);
            this.bttAg.TabIndex = 3;
            this.bttAg.Text = "Agregar";
            this.bttAg.UseVisualStyleBackColor = false;
            this.bttAg.Click += new System.EventHandler(this.bttAg_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::Agrotics.Properties.Resources.icons8_retire_hombre_usuario_100;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(486, 310);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 39);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEli_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::Agrotics.Properties.Resources.icons8_editar_usuaria_100;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(615, 308);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 41);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEdi_Clik);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(12, 100);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(106, 13);
            this.lblnombre.TabIndex = 6;
            this.lblnombre.Text = "Nombre del producto";
            // 
            // lbldosis
            // 
            this.lbldosis.AutoSize = true;
            this.lbldosis.Location = new System.Drawing.Point(12, 138);
            this.lbldosis.Name = "lbldosis";
            this.lbldosis.Size = new System.Drawing.Size(63, 13);
            this.lbldosis.TabIndex = 7;
            this.lbldosis.Text = "Descripcion";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(12, 219);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(37, 13);
            this.lblprecio.TabIndex = 8;
            this.lblprecio.Text = "Precio";
            // 
            // lblcaducidad
            // 
            this.lblcaducidad.AutoSize = true;
            this.lblcaducidad.Location = new System.Drawing.Point(12, 253);
            this.lblcaducidad.Name = "lblcaducidad";
            this.lblcaducidad.Size = new System.Drawing.Size(58, 13);
            this.lblcaducidad.TabIndex = 9;
            this.lblcaducidad.Text = "Caducidad";
            this.lblcaducidad.Click += new System.EventHandler(this.lblcaducidad_Click);
            // 
            // txtNombrePro
            // 
            this.txtNombrePro.Location = new System.Drawing.Point(124, 97);
            this.txtNombrePro.Name = "txtNombrePro";
            this.txtNombrePro.Size = new System.Drawing.Size(168, 20);
            this.txtNombrePro.TabIndex = 10;
            // 
            // txtDescripcionPro
            // 
            this.txtDescripcionPro.Location = new System.Drawing.Point(124, 123);
            this.txtDescripcionPro.Multiline = true;
            this.txtDescripcionPro.Name = "txtDescripcionPro";
            this.txtDescripcionPro.Size = new System.Drawing.Size(168, 48);
            this.txtDescripcionPro.TabIndex = 11;
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.Location = new System.Drawing.Point(124, 187);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(168, 20);
            this.txtLaboratorio.TabIndex = 12;
            this.txtLaboratorio.Text = " ";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(124, 216);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(168, 20);
            this.txtPrecio.TabIndex = 13;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Laboratorio";
            // 
            // txtCaducidad
            // 
            this.txtCaducidad.Location = new System.Drawing.Point(124, 250);
            this.txtCaducidad.Name = "txtCaducidad";
            this.txtCaducidad.Size = new System.Drawing.Size(168, 20);
            this.txtCaducidad.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Año";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(124, 294);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(168, 20);
            this.txtStock.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tipo";
            // 
            // txtTipo
            // 
            this.txtTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "HERBICIDA",
            "FERTILIZANTE"});
            this.txtTipo.Location = new System.Drawing.Point(124, 325);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(168, 20);
            this.txtTipo.TabIndex = 25;
            this.txtTipo.Text = " ";
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.AutoCompleteCustomSource.AddRange(new string[] {
            "250GR",
            "500GR",
            "1KG",
            "500ML",
            "1L"});
            this.txtPresentacion.Location = new System.Drawing.Point(124, 351);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Size = new System.Drawing.Size(168, 20);
            this.txtPresentacion.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Presentacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Cultivos";
            // 
            // txtCultivos
            // 
            this.txtCultivos.AutoCompleteCustomSource.AddRange(new string[] {
            "Piña",
            "Maiz",
            "Frijol",
            "Chile",
            "Caña",
            "Sandia"});
            this.txtCultivos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtCultivos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCultivos.Location = new System.Drawing.Point(124, 383);
            this.txtCultivos.Name = "txtCultivos";
            this.txtCultivos.Size = new System.Drawing.Size(168, 20);
            this.txtCultivos.TabIndex = 31;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(736, 418);
            this.Controls.Add(this.txtCultivos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPresentacion);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCaducidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtLaboratorio);
            this.Controls.Add(this.txtDescripcionPro);
            this.Controls.Add(this.txtNombrePro);
            this.Controls.Add(this.lblcaducidad);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lbldosis);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.bttAg);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnBuscarPro);
            this.Controls.Add(this.txtBuscarpro);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarpro;
        private System.Windows.Forms.Button btnBuscarPro;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button bttAg;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbldosis;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblcaducidad;
        private System.Windows.Forms.TextBox txtNombrePro;
        private System.Windows.Forms.TextBox txtDescripcionPro;
        private System.Windows.Forms.TextBox txtLaboratorio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaducidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtPresentacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCultivos;
    }
}