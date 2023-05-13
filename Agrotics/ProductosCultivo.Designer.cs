namespace Agrotics
{
    partial class ProductosCultivo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddFert = new System.Windows.Forms.Button();
            this.dgvFertilizantes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvPesticidas = new System.Windows.Forms.DataGridView();
            this.dgvFungicidas = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFertilizantes)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesticidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFungicidas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-3, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAddFert);
            this.tabPage1.Controls.Add(this.dgvFertilizantes);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "FERTILIZANTES";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnAddFert
            // 
            this.btnAddFert.Location = new System.Drawing.Point(460, 20);
            this.btnAddFert.Name = "btnAddFert";
            this.btnAddFert.Size = new System.Drawing.Size(75, 23);
            this.btnAddFert.TabIndex = 3;
            this.btnAddFert.Text = "Agregar Producto";
            this.btnAddFert.UseVisualStyleBackColor = true;
            this.btnAddFert.Click += new System.EventHandler(this.btnAddFert_Click);
            // 
            // dgvFertilizantes
            // 
            this.dgvFertilizantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFertilizantes.Location = new System.Drawing.Point(23, 56);
            this.dgvFertilizantes.Name = "dgvFertilizantes";
            this.dgvFertilizantes.ReadOnly = true;
            this.dgvFertilizantes.Size = new System.Drawing.Size(747, 221);
            this.dgvFertilizantes.TabIndex = 2;
            this.dgvFertilizantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFertilizantes_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvPesticidas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PESTICIDAS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvFungicidas);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(797, 430);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "FUNGICIDAS";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvPesticidas
            // 
            this.dgvPesticidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesticidas.Location = new System.Drawing.Point(111, 84);
            this.dgvPesticidas.Name = "dgvPesticidas";
            this.dgvPesticidas.Size = new System.Drawing.Size(583, 295);
            this.dgvPesticidas.TabIndex = 0;
            // 
            // dgvFungicidas
            // 
            this.dgvFungicidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFungicidas.Location = new System.Drawing.Point(78, 56);
            this.dgvFungicidas.Name = "dgvFungicidas";
            this.dgvFungicidas.Size = new System.Drawing.Size(636, 334);
            this.dgvFungicidas.TabIndex = 0;
            // 
            // ProductosCultivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ProductosCultivo";
            this.Text = "ProductosCultivo";
            this.Load += new System.EventHandler(this.ProductosCultivo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFertilizantes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesticidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFungicidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFertilizantes;
        private System.Windows.Forms.Button btnAddFert;
        private System.Windows.Forms.DataGridView dgvPesticidas;
        private System.Windows.Forms.DataGridView dgvFungicidas;
    }
}