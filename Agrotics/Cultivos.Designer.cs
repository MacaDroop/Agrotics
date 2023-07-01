
namespace Agrotics
{
    partial class Cultivos
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Button btnPiña;
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMaiz = new System.Windows.Forms.Button();
            this.Principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            label1 = new System.Windows.Forms.Label();
            btnPiña = new System.Windows.Forms.Button();
            this.Principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(167, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(432, 29);
            label1.TabIndex = 6;
            label1.Text = "SELECCIONA EL TIPO DE CULTIVO";
            // 
            // btnPiña
            // 
            btnPiña.BackColor = System.Drawing.Color.Transparent;
            btnPiña.BackgroundImage = global::Agrotics.Properties.Resources.piña;
            btnPiña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnPiña.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            btnPiña.FlatAppearance.BorderSize = 0;
            btnPiña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPiña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnPiña.ForeColor = System.Drawing.Color.Black;
            btnPiña.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnPiña.Location = new System.Drawing.Point(92, 91);
            btnPiña.Name = "btnPiña";
            btnPiña.Size = new System.Drawing.Size(127, 89);
            btnPiña.TabIndex = 0;
            btnPiña.Text = "PIÑA";
            btnPiña.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnPiña.UseVisualStyleBackColor = false;
            btnPiña.Click += new System.EventHandler(this.button1_Click);
            btnPiña.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::Agrotics.Properties.Resources.icon_chile;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(572, 239);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 89);
            this.button6.TabIndex = 5;
            this.button6.Text = "CHILE";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::Agrotics.Properties.Resources.icon_frijol;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(102, 239);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 89);
            this.button5.TabIndex = 4;
            this.button5.Text = "FRIJOL";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Agrotics.Properties.Resources.sandia;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(338, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 89);
            this.button4.TabIndex = 3;
            this.button4.Text = "SANDIA";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Agrotics.Properties.Resources.caña;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(559, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 89);
            this.button3.TabIndex = 2;
            this.button3.Text = "CAÑA";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // btnMaiz
            // 
            this.btnMaiz.BackColor = System.Drawing.Color.Transparent;
            this.btnMaiz.BackgroundImage = global::Agrotics.Properties.Resources.maiz;
            this.btnMaiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaiz.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Agrotics.Properties.Settings.Default, "ValorB1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnMaiz.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnMaiz.FlatAppearance.BorderSize = 0;
            this.btnMaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaiz.Location = new System.Drawing.Point(338, 91);
            this.btnMaiz.Name = "btnMaiz";
            this.btnMaiz.Size = new System.Drawing.Size(117, 89);
            this.btnMaiz.TabIndex = 1;
            this.btnMaiz.Text = global::Agrotics.Properties.Settings.Default.ValorB1;
            this.btnMaiz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaiz.UseVisualStyleBackColor = false;
            this.btnMaiz.Click += new System.EventHandler(this.button2_Click);
            this.btnMaiz.Paint += new System.Windows.Forms.PaintEventHandler(this.button2_Paint);
            this.btnMaiz.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // Principal
            // 
            this.Principal.Controls.Add(this.tabPage1);
            this.Principal.Controls.Add(this.tabPage2);
            this.Principal.Location = new System.Drawing.Point(1, 0);
            this.Principal.Name = "Principal";
            this.Principal.SelectedIndex = 0;
            this.Principal.Size = new System.Drawing.Size(778, 477);
            this.Principal.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Agrotics.Properties.Resources.Imagen_de_WhatsApp_2023_05_13_a_las_13_52_20;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(btnPiña);
            this.tabPage1.Controls.Add(label1);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.btnMaiz);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(770, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(770, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuración";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Cultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Agrotics.Properties.Resources.Imagen_de_WhatsApp_2023_05_13_a_las_13_52_20;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 473);
            this.Controls.Add(this.Principal);
            this.Name = "Cultivos";
            this.Text = "Cultivos";
            this.Load += new System.EventHandler(this.Cultivos_Load);
            this.Principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMaiz;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabControl Principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}