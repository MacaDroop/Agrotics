
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvprovedores = new System.Windows.Forms.DataGridView();
            this.btteditar = new System.Windows.Forms.Button();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.bttagregar = new System.Windows.Forms.Button();
            this.bttbusqueda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprovedores)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dgvprovedores
            // 
            this.dgvprovedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprovedores.Location = new System.Drawing.Point(47, 153);
            this.dgvprovedores.Name = "dgvprovedores";
            this.dgvprovedores.Size = new System.Drawing.Size(363, 150);
            this.dgvprovedores.TabIndex = 2;
            // 
            // btteditar
            // 
            this.btteditar.BackgroundImage = global::Agrotics.Properties.Resources.icons8_editar_usuaria_100;
            this.btteditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btteditar.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btteditar.Location = new System.Drawing.Point(310, 331);
            this.btteditar.Name = "btteditar";
            this.btteditar.Size = new System.Drawing.Size(75, 48);
            this.btteditar.TabIndex = 5;
            this.btteditar.Text = "Editar";
            this.btteditar.UseVisualStyleBackColor = true;
            // 
            // bttEliminar
            // 
            this.bttEliminar.BackgroundImage = global::Agrotics.Properties.Resources.icons8_retire_hombre_usuario_100;
            this.bttEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttEliminar.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttEliminar.Location = new System.Drawing.Point(184, 331);
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
            this.bttagregar.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttagregar.Location = new System.Drawing.Point(57, 331);
            this.bttagregar.Name = "bttagregar";
            this.bttagregar.Size = new System.Drawing.Size(75, 48);
            this.bttagregar.TabIndex = 3;
            this.bttagregar.Text = "Agregar";
            this.bttagregar.UseVisualStyleBackColor = true;
            // 
            // bttbusqueda
            // 
            this.bttbusqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttbusqueda.BackgroundImage = global::Agrotics.Properties.Resources.icons8_búsqueda_usuaria_100;
            this.bttbusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttbusqueda.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttbusqueda.Location = new System.Drawing.Point(282, 56);
            this.bttbusqueda.Name = "bttbusqueda";
            this.bttbusqueda.Size = new System.Drawing.Size(128, 50);
            this.bttbusqueda.TabIndex = 1;
            this.bttbusqueda.Text = "Busqueda";
            this.bttbusqueda.UseVisualStyleBackColor = false;
            // 
            // Provedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.btteditar);
            this.Controls.Add(this.bttEliminar);
            this.Controls.Add(this.bttagregar);
            this.Controls.Add(this.dgvprovedores);
            this.Controls.Add(this.bttbusqueda);
            this.Controls.Add(this.textBox1);
            this.Name = "Provedores";
            this.Text = "Provedores";
            this.Load += new System.EventHandler(this.Provedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvprovedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bttbusqueda;
        private System.Windows.Forms.DataGridView dgvprovedores;
        private System.Windows.Forms.Button bttagregar;
        private System.Windows.Forms.Button bttEliminar;
        private System.Windows.Forms.Button btteditar;
    }
}