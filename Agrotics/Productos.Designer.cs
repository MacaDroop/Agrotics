
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.bttAg = new System.Windows.Forms.Button();
            this.btnBuscarPro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarpro
            // 
            this.txtBuscarpro.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtBuscarpro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarpro.Location = new System.Drawing.Point(79, 29);
            this.txtBuscarpro.Name = "txtBuscarpro";
            this.txtBuscarpro.Size = new System.Drawing.Size(209, 20);
            this.txtBuscarpro.TabIndex = 0;
            // 
            // dgvProductos
            // 
            this.dgvProductos.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(312, 103);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(477, 229);
            this.dgvProductos.TabIndex = 2;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(35, 88);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(59, 16);
            this.lblnombre.TabIndex = 6;
            this.lblnombre.Text = "Nombre:";
            // 
            // lbldosis
            // 
            this.lbldosis.AutoSize = true;
            this.lbldosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldosis.Location = new System.Drawing.Point(12, 129);
            this.lbldosis.Name = "lbldosis";
            this.lbldosis.Size = new System.Drawing.Size(82, 16);
            this.lbldosis.TabIndex = 7;
            this.lbldosis.Text = "Descripción:";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(42, 207);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(49, 16);
            this.lblprecio.TabIndex = 8;
            this.lblprecio.Text = "Precio:";
            // 
            // lblcaducidad
            // 
            this.lblcaducidad.AutoSize = true;
            this.lblcaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaducidad.Location = new System.Drawing.Point(18, 241);
            this.lblcaducidad.Name = "lblcaducidad";
            this.lblcaducidad.Size = new System.Drawing.Size(76, 16);
            this.lblcaducidad.TabIndex = 9;
            this.lblcaducidad.Text = "Caducidad:";
            this.lblcaducidad.Click += new System.EventHandler(this.lblcaducidad_Click);
            // 
            // txtNombrePro
            // 
            this.txtNombrePro.BackColor = System.Drawing.Color.DarkGray;
            this.txtNombrePro.Location = new System.Drawing.Point(120, 84);
            this.txtNombrePro.Name = "txtNombrePro";
            this.txtNombrePro.Size = new System.Drawing.Size(168, 20);
            this.txtNombrePro.TabIndex = 10;
            // 
            // txtDescripcionPro
            // 
            this.txtDescripcionPro.BackColor = System.Drawing.Color.DarkGray;
            this.txtDescripcionPro.Location = new System.Drawing.Point(120, 110);
            this.txtDescripcionPro.Multiline = true;
            this.txtDescripcionPro.Name = "txtDescripcionPro";
            this.txtDescripcionPro.Size = new System.Drawing.Size(168, 48);
            this.txtDescripcionPro.TabIndex = 11;
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.BackColor = System.Drawing.Color.DarkGray;
            this.txtLaboratorio.Location = new System.Drawing.Point(120, 174);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(168, 20);
            this.txtLaboratorio.TabIndex = 12;
            this.txtLaboratorio.Text = " ";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.DarkGray;
            this.txtPrecio.Location = new System.Drawing.Point(120, 203);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(168, 20);
            this.txtPrecio.TabIndex = 13;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Laboratorio:";
            // 
            // txtCaducidad
            // 
            this.txtCaducidad.BackColor = System.Drawing.Color.DarkGray;
            this.txtCaducidad.Location = new System.Drawing.Point(120, 237);
            this.txtCaducidad.Name = "txtCaducidad";
            this.txtCaducidad.Size = new System.Drawing.Size(168, 20);
            this.txtCaducidad.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Año";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.DarkGray;
            this.txtStock.Location = new System.Drawing.Point(120, 281);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(168, 20);
            this.txtStock.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tipo:";
            // 
            // txtTipo
            // 
            this.txtTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "Herbicida",
            "Fertilizantes",
            "Insecticida",
            "Fungicida"});
            this.txtTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTipo.BackColor = System.Drawing.Color.DarkGray;
            this.txtTipo.Location = new System.Drawing.Point(120, 312);
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
            this.txtPresentacion.BackColor = System.Drawing.Color.DarkGray;
            this.txtPresentacion.Location = new System.Drawing.Point(120, 338);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Size = new System.Drawing.Size(168, 20);
            this.txtPresentacion.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Presentacion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Cultivos:";
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
            this.txtCultivos.BackColor = System.Drawing.Color.DarkGray;
            this.txtCultivos.Location = new System.Drawing.Point(120, 370);
            this.txtCultivos.Name = "txtCultivos";
            this.txtCultivos.Size = new System.Drawing.Size(168, 20);
            this.txtCultivos.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Referencia:";
            // 
            // txtReferencia
            // 
            this.txtReferencia.BackColor = System.Drawing.Color.DarkGray;
            this.txtReferencia.Location = new System.Drawing.Point(120, 401);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(168, 20);
            this.txtReferencia.TabIndex = 33;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImage = global::Agrotics.Properties.Resources.icons8_editar_usuaria_100;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(680, 25);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 41);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEdi_Clik);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = global::Agrotics.Properties.Resources.icons8_retire_hombre_usuario_100;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(558, 25);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 39);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEli_Click);
            // 
            // bttAg
            // 
            this.bttAg.BackColor = System.Drawing.Color.Transparent;
            this.bttAg.BackgroundImage = global::Agrotics.Properties.Resources.icons8_añadir_usuario_grupo_mujer_hombre_100;
            this.bttAg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttAg.FlatAppearance.BorderSize = 0;
            this.bttAg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAg.Location = new System.Drawing.Point(427, 28);
            this.bttAg.Name = "bttAg";
            this.bttAg.Size = new System.Drawing.Size(97, 39);
            this.bttAg.TabIndex = 3;
            this.bttAg.UseVisualStyleBackColor = false;
            this.bttAg.Click += new System.EventHandler(this.bttAg_Click);
            // 
            // btnBuscarPro
            // 
            this.btnBuscarPro.BackgroundImage = global::Agrotics.Properties.Resources.icon_lupa;
            this.btnBuscarPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPro.FlatAppearance.BorderSize = 0;
            this.btnBuscarPro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscarPro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscarPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPro.Location = new System.Drawing.Point(294, 25);
            this.btnBuscarPro.Name = "btnBuscarPro";
            this.btnBuscarPro.Size = new System.Drawing.Size(33, 27);
            this.btnBuscarPro.TabIndex = 1;
            this.btnBuscarPro.UseVisualStyleBackColor = true;
            this.btnBuscarPro.Click += new System.EventHandler(this.bttBuscar_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(824, 434);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.label8);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReferencia;
    }
}