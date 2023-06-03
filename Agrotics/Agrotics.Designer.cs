﻿
namespace Agrotics
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCultivos = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnventas = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.Transparent;
            this.btnProveedores.BackgroundImage = global::Agrotics.Properties.Resources.icon_proveedores;
            this.btnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.btnProveedores.Location = new System.Drawing.Point(380, 98);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(174, 125);
            this.btnProveedores.TabIndex = 0;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnProveedores, "Aqui podras registrar la información de tus proveedores.");
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.button1_Click);
            this.btnProveedores.MouseEnter += new System.EventHandler(this.btnProveedores_MouseEnter);
            this.btnProveedores.MouseLeave += new System.EventHandler(this.btnProveedores_MouseLeave);
            this.btnProveedores.MouseHover += new System.EventHandler(this.btnProveedores_MouseHover);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.BackgroundImage = global::Agrotics.Properties.Resources.icon_productos;
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.btnProductos.Location = new System.Drawing.Point(358, 276);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(174, 125);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btnProductos, "Aquí podras podras registrar, editar y eliminar tus productos.");
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.button2_Click);
            this.btnProductos.MouseEnter += new System.EventHandler(this.btnProductos_MouseEnter);
            this.btnProductos.MouseLeave += new System.EventHandler(this.btnProductos_MouseLeave);
            this.btnProductos.MouseHover += new System.EventHandler(this.btnProductos_MouseHover);
            // 
            // btnCultivos
            // 
            this.btnCultivos.BackColor = System.Drawing.Color.Transparent;
            this.btnCultivos.BackgroundImage = global::Agrotics.Properties.Resources.icon_cultivos;
            this.btnCultivos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCultivos.FlatAppearance.BorderSize = 0;
            this.btnCultivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCultivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnCultivos.Location = new System.Drawing.Point(119, 264);
            this.btnCultivos.Name = "btnCultivos";
            this.btnCultivos.Size = new System.Drawing.Size(174, 125);
            this.btnCultivos.TabIndex = 2;
            this.btnCultivos.Text = "Cultivos";
            this.btnCultivos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip3.SetToolTip(this.btnCultivos, "Encontraras productos relacionados al cultivo seleccionado.");
            this.btnCultivos.UseVisualStyleBackColor = false;
            this.btnCultivos.Click += new System.EventHandler(this.button3_Click);
            this.btnCultivos.MouseEnter += new System.EventHandler(this.btnCultivos_MouseEnter);
            this.btnCultivos.MouseLeave += new System.EventHandler(this.btnCultivos_MouseLeave);
            this.btnCultivos.MouseHover += new System.EventHandler(this.btnCultivos_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.IsBalloon = true;
            // 
            // btnventas
            // 
            this.btnventas.BackColor = System.Drawing.Color.Transparent;
            this.btnventas.BackgroundImage = global::Agrotics.Properties.Resources.cc_sinfondo;
            this.btnventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnventas.FlatAppearance.BorderSize = 0;
            this.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnventas.Location = new System.Drawing.Point(119, 98);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(174, 125);
            this.btnventas.TabIndex = 3;
            this.btnventas.Text = "Ventas";
            this.btnventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btnventas, "Podras realizar la venta de tus Productos\r\n");
            this.btnventas.UseVisualStyleBackColor = false;
            this.btnventas.Click += new System.EventHandler(this.btnventas_Click);
            this.btnventas.MouseEnter += new System.EventHandler(this.btnventas_MouseEnter);
            this.btnventas.MouseLeave += new System.EventHandler(this.btnventas_MouseLeave);
            this.btnventas.MouseHover += new System.EventHandler(this.btnventas_MouseHover);
            // 
            // toolTip2
            // 
            this.toolTip2.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip2.IsBalloon = true;
            // 
            // toolTip3
            // 
            this.toolTip3.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip3.IsBalloon = true;
            this.toolTip3.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip3_Popup);
            // 
            // toolTip4
            // 
            this.toolTip4.IsBalloon = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(606, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 125);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Agrotics.Properties.Resources.Imagen_de_WhatsApp_2023_05_06_a_las_11_24_22;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 471);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnventas);
            this.Controls.Add(this.btnCultivos);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Agrotics";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCultivos;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Button btnventas;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

