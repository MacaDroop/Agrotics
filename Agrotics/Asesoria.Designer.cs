namespace Agrotics
{
    partial class Asesoria
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
            this.AS = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tcSintomas = new System.Windows.Forms.TabControl();
            this.tpPiña = new System.Windows.Forms.TabPage();
            this.tpMaiz = new System.Windows.Forms.TabPage();
            this.tpFrijol = new System.Windows.Forms.TabPage();
            this.tpCaña = new System.Windows.Forms.TabPage();
            this.tpSandia = new System.Windows.Forms.TabPage();
            this.tpChile = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoCultivo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DIAGNOSTICO = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.AS.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tcSintomas.SuspendLayout();
            this.tpPiña.SuspendLayout();
            this.SuspendLayout();
            // 
            // AS
            // 
            this.AS.Controls.Add(this.tabPage1);
            this.AS.Controls.Add(this.DIAGNOSTICO);
            this.AS.Location = new System.Drawing.Point(13, 1);
            this.AS.Name = "AS";
            this.AS.SelectedIndex = 0;
            this.AS.Size = new System.Drawing.Size(775, 437);
            this.AS.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tcSintomas);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtEdad);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbTipoCultivo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "EVALUACION";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tcSintomas
            // 
            this.tcSintomas.Controls.Add(this.tpPiña);
            this.tcSintomas.Controls.Add(this.tpMaiz);
            this.tcSintomas.Controls.Add(this.tpFrijol);
            this.tcSintomas.Controls.Add(this.tpCaña);
            this.tcSintomas.Controls.Add(this.tpSandia);
            this.tcSintomas.Controls.Add(this.tpChile);
            this.tcSintomas.Location = new System.Drawing.Point(36, 178);
            this.tcSintomas.Name = "tcSintomas";
            this.tcSintomas.Padding = new System.Drawing.Point(10, 9);
            this.tcSintomas.SelectedIndex = 0;
            this.tcSintomas.Size = new System.Drawing.Size(657, 200);
            this.tcSintomas.TabIndex = 7;
            // 
            // tpPiña
            // 
            this.tpPiña.Controls.Add(this.checkedListBox3);
            this.tpPiña.Controls.Add(this.checkedListBox2);
            this.tpPiña.Controls.Add(this.checkedListBox1);
            this.tpPiña.Location = new System.Drawing.Point(4, 34);
            this.tpPiña.Name = "tpPiña";
            this.tpPiña.Padding = new System.Windows.Forms.Padding(3);
            this.tpPiña.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tpPiña.Size = new System.Drawing.Size(649, 162);
            this.tpPiña.TabIndex = 0;
            this.tpPiña.Text = "PIÑA";
            this.tpPiña.UseVisualStyleBackColor = true;
            // 
            // tpMaiz
            // 
            this.tpMaiz.Location = new System.Drawing.Point(4, 34);
            this.tpMaiz.Name = "tpMaiz";
            this.tpMaiz.Padding = new System.Windows.Forms.Padding(3);
            this.tpMaiz.Size = new System.Drawing.Size(649, 162);
            this.tpMaiz.TabIndex = 1;
            this.tpMaiz.Text = "MAIZ";
            this.tpMaiz.UseVisualStyleBackColor = true;
            // 
            // tpFrijol
            // 
            this.tpFrijol.Location = new System.Drawing.Point(4, 34);
            this.tpFrijol.Name = "tpFrijol";
            this.tpFrijol.Padding = new System.Windows.Forms.Padding(3);
            this.tpFrijol.Size = new System.Drawing.Size(649, 162);
            this.tpFrijol.TabIndex = 2;
            this.tpFrijol.Text = "FRIJOL";
            this.tpFrijol.UseVisualStyleBackColor = true;
            // 
            // tpCaña
            // 
            this.tpCaña.Location = new System.Drawing.Point(4, 34);
            this.tpCaña.Name = "tpCaña";
            this.tpCaña.Padding = new System.Windows.Forms.Padding(3);
            this.tpCaña.Size = new System.Drawing.Size(649, 162);
            this.tpCaña.TabIndex = 3;
            this.tpCaña.Text = "CAÑA";
            this.tpCaña.UseVisualStyleBackColor = true;
            // 
            // tpSandia
            // 
            this.tpSandia.Location = new System.Drawing.Point(4, 34);
            this.tpSandia.Name = "tpSandia";
            this.tpSandia.Padding = new System.Windows.Forms.Padding(3);
            this.tpSandia.Size = new System.Drawing.Size(649, 162);
            this.tpSandia.TabIndex = 4;
            this.tpSandia.Text = "SANDIA";
            this.tpSandia.UseVisualStyleBackColor = true;
            // 
            // tpChile
            // 
            this.tpChile.Location = new System.Drawing.Point(4, 34);
            this.tpChile.Name = "tpChile";
            this.tpChile.Padding = new System.Windows.Forms.Padding(3);
            this.tpChile.Size = new System.Drawing.Size(649, 162);
            this.tpChile.TabIndex = 5;
            this.tpChile.Text = "CHILE";
            this.tpChile.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ultimo Producto Aplicado:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(166, 74);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(121, 20);
            this.txtEdad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edad:";
            // 
            // cmbTipoCultivo
            // 
            this.cmbTipoCultivo.FormattingEnabled = true;
            this.cmbTipoCultivo.Items.AddRange(new object[] {
            "Piña",
            "Maiz",
            "Frijol",
            "Caña",
            "Chile",
            "Sandia"});
            this.cmbTipoCultivo.Location = new System.Drawing.Point(166, 27);
            this.cmbTipoCultivo.Name = "cmbTipoCultivo";
            this.cmbTipoCultivo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoCultivo.TabIndex = 1;
            this.cmbTipoCultivo.SelectedValueChanged += new System.EventHandler(this.cmbTipoCultivo_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona el tipo de cultivo:";
            // 
            // DIAGNOSTICO
            // 
            this.DIAGNOSTICO.Location = new System.Drawing.Point(4, 22);
            this.DIAGNOSTICO.Name = "DIAGNOSTICO";
            this.DIAGNOSTICO.Padding = new System.Windows.Forms.Padding(3);
            this.DIAGNOSTICO.Size = new System.Drawing.Size(767, 411);
            this.DIAGNOSTICO.TabIndex = 1;
            this.DIAGNOSTICO.Text = "DIAGNOSTICO";
            this.DIAGNOSTICO.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Sintoma 1",
            "Sintoma 2",
            "Sintoma 3",
            "Sintoma 4"});
            this.checkedListBox1.Location = new System.Drawing.Point(41, 15);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 0;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Sintoma 1",
            "Sintoma 2",
            "Sintoma 3",
            "Sintoma 4"});
            this.checkedListBox2.Location = new System.Drawing.Point(256, 15);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox2.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox2.TabIndex = 1;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "Sintoma 1",
            "Sintoma 2",
            "Sintoma 3",
            "Sintoma 4"});
            this.checkedListBox3.Location = new System.Drawing.Point(457, 15);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox3.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox3.TabIndex = 2;
            // 
            // Asesoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AS);
            this.Name = "Asesoria";
            this.Text = "Asesoria";
            this.AS.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tcSintomas.ResumeLayout(false);
            this.tpPiña.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AS;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage DIAGNOSTICO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoCultivo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tcSintomas;
        private System.Windows.Forms.TabPage tpPiña;
        private System.Windows.Forms.TabPage tpMaiz;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tpFrijol;
        private System.Windows.Forms.TabPage tpCaña;
        private System.Windows.Forms.TabPage tpSandia;
        private System.Windows.Forms.TabPage tpChile;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
    }
}