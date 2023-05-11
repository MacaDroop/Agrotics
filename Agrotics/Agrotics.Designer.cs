
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCultivos = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnventas = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnProveedores
            // 
            resources.ApplyResources(this.btnProveedores, "btnProveedores");
            this.btnProveedores.BackColor = System.Drawing.Color.Transparent;
            this.btnProveedores.BackgroundImage = global::Agrotics.Properties.Resources.icon_proveedores;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.Name = "btnProveedores";
            this.toolTip1.SetToolTip(this.btnProveedores, resources.GetString("btnProveedores.ToolTip"));
            this.toolTip2.SetToolTip(this.btnProveedores, resources.GetString("btnProveedores.ToolTip1"));
            this.toolTip3.SetToolTip(this.btnProveedores, resources.GetString("btnProveedores.ToolTip2"));
            this.toolTip4.SetToolTip(this.btnProveedores, resources.GetString("btnProveedores.ToolTip3"));
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.button1_Click);
            this.btnProveedores.MouseHover += new System.EventHandler(this.btnProveedores_MouseHover);
            // 
            // btnProductos
            // 
            resources.ApplyResources(this.btnProductos, "btnProductos");
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.BackgroundImage = global::Agrotics.Properties.Resources.icon_productos;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.Name = "btnProductos";
            this.toolTip1.SetToolTip(this.btnProductos, resources.GetString("btnProductos.ToolTip"));
            this.toolTip2.SetToolTip(this.btnProductos, resources.GetString("btnProductos.ToolTip1"));
            this.toolTip3.SetToolTip(this.btnProductos, resources.GetString("btnProductos.ToolTip2"));
            this.toolTip4.SetToolTip(this.btnProductos, resources.GetString("btnProductos.ToolTip3"));
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.button2_Click);
            this.btnProductos.MouseHover += new System.EventHandler(this.btnProductos_MouseHover);
            // 
            // btnCultivos
            // 
            resources.ApplyResources(this.btnCultivos, "btnCultivos");
            this.btnCultivos.BackColor = System.Drawing.Color.Transparent;
            this.btnCultivos.BackgroundImage = global::Agrotics.Properties.Resources.icon_cultivos;
            this.btnCultivos.FlatAppearance.BorderSize = 0;
            this.btnCultivos.Name = "btnCultivos";
            this.toolTip1.SetToolTip(this.btnCultivos, resources.GetString("btnCultivos.ToolTip"));
            this.toolTip2.SetToolTip(this.btnCultivos, resources.GetString("btnCultivos.ToolTip1"));
            this.toolTip3.SetToolTip(this.btnCultivos, resources.GetString("btnCultivos.ToolTip2"));
            this.toolTip4.SetToolTip(this.btnCultivos, resources.GetString("btnCultivos.ToolTip3"));
            this.btnCultivos.UseVisualStyleBackColor = false;
            this.btnCultivos.Click += new System.EventHandler(this.button3_Click);
            this.btnCultivos.MouseHover += new System.EventHandler(this.btnCultivos_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.IsBalloon = true;
            // 
            // btnventas
            // 
            resources.ApplyResources(this.btnventas, "btnventas");
            this.btnventas.BackColor = System.Drawing.Color.Transparent;
            this.btnventas.BackgroundImage = global::Agrotics.Properties.Resources.cc_sinfondo;
            this.btnventas.FlatAppearance.BorderSize = 0;
            this.btnventas.Name = "btnventas";
            this.toolTip1.SetToolTip(this.btnventas, resources.GetString("btnventas.ToolTip"));
            this.toolTip2.SetToolTip(this.btnventas, resources.GetString("btnventas.ToolTip1"));
            this.toolTip3.SetToolTip(this.btnventas, resources.GetString("btnventas.ToolTip2"));
            this.toolTip4.SetToolTip(this.btnventas, resources.GetString("btnventas.ToolTip3"));
            this.btnventas.UseVisualStyleBackColor = false;
            this.btnventas.Click += new System.EventHandler(this.btnventas_Click);
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
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Agrotics.Properties.Resources.Sin_título;
            this.Controls.Add(this.btnventas);
            this.Controls.Add(this.btnCultivos);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.toolTip3.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.toolTip4.SetToolTip(this, resources.GetString("$this.ToolTip1"));
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip2"));
            this.toolTip2.SetToolTip(this, resources.GetString("$this.ToolTip3"));
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
    }
}

