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
            this.TABCONTROL = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tcSintomas = new System.Windows.Forms.TabControl();
            this.tpPiña = new System.Windows.Forms.TabPage();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tpMaiz = new System.Windows.Forms.TabPage();
            this.checkedListBox6 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox5 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox4 = new System.Windows.Forms.CheckedListBox();
            this.tpFrijol = new System.Windows.Forms.TabPage();
            this.checkedListBox9 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox8 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox7 = new System.Windows.Forms.CheckedListBox();
            this.tpCaña = new System.Windows.Forms.TabPage();
            this.checkedListBox12 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox11 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox10 = new System.Windows.Forms.CheckedListBox();
            this.tpSandia = new System.Windows.Forms.TabPage();
            this.checkedListBox15 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox14 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox13 = new System.Windows.Forms.CheckedListBox();
            this.tpChile = new System.Windows.Forms.TabPage();
            this.checkedListBox18 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox17 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox16 = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoCultivo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDiagnostico = new System.Windows.Forms.TabPage();
            this.lblEnfermedad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sintomasClicked = new System.Windows.Forms.ListBox();
            this.txtRecomendacion = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lbltxtP = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.TABCONTROL.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tcSintomas.SuspendLayout();
            this.tpPiña.SuspendLayout();
            this.tpMaiz.SuspendLayout();
            this.tpFrijol.SuspendLayout();
            this.tpCaña.SuspendLayout();
            this.tpSandia.SuspendLayout();
            this.tpChile.SuspendLayout();
            this.tbDiagnostico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // TABCONTROL
            // 
            this.TABCONTROL.Controls.Add(this.tabPage1);
            this.TABCONTROL.Controls.Add(this.tbDiagnostico);
            this.TABCONTROL.Location = new System.Drawing.Point(13, 1);
            this.TABCONTROL.Name = "TABCONTROL";
            this.TABCONTROL.SelectedIndex = 0;
            this.TABCONTROL.Size = new System.Drawing.Size(775, 479);
            this.TABCONTROL.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.GreenYellow;
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnAceptar);
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
            this.tabPage1.Size = new System.Drawing.Size(767, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "EVALUACION";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(564, 76);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(564, 25);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(91, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            this.tcSintomas.Size = new System.Drawing.Size(498, 227);
            this.tcSintomas.TabIndex = 7;
            // 
            // tpPiña
            // 
            this.tpPiña.BackColor = System.Drawing.Color.LightGray;
            this.tpPiña.Controls.Add(this.checkedListBox3);
            this.tpPiña.Controls.Add(this.checkedListBox2);
            this.tpPiña.Controls.Add(this.checkedListBox1);
            this.tpPiña.Location = new System.Drawing.Point(4, 34);
            this.tpPiña.Name = "tpPiña";
            this.tpPiña.Padding = new System.Windows.Forms.Padding(3);
            this.tpPiña.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tpPiña.Size = new System.Drawing.Size(490, 189);
            this.tpPiña.TabIndex = 0;
            this.tpPiña.Text = "PIÑA";
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "Hoja ancha",
            "Pasto",
            "Maleza"});
            this.checkedListBox3.Location = new System.Drawing.Point(231, 17);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox3.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox3.TabIndex = 2;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Perdida de color en tallo",
            "Enanismo",
            "Exudaciones gomosas (fruta)",
            "Pudricion de la fruta",
            "Decoloración de las hojas",
            "Olor (pudrición)"});
            this.checkedListBox2.Location = new System.Drawing.Point(6, 77);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox2.Size = new System.Drawing.Size(178, 90);
            this.checkedListBox2.TabIndex = 1;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Tallo Blando",
            "Desprendimiento de Hojas",
            "Pudrición en Cogollo",
            "Decoloracion en tejido de pulpa"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 17);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox1.Size = new System.Drawing.Size(178, 60);
            this.checkedListBox1.TabIndex = 0;
            // 
            // tpMaiz
            // 
            this.tpMaiz.Controls.Add(this.checkedListBox6);
            this.tpMaiz.Controls.Add(this.checkedListBox5);
            this.tpMaiz.Controls.Add(this.checkedListBox4);
            this.tpMaiz.Location = new System.Drawing.Point(4, 34);
            this.tpMaiz.Name = "tpMaiz";
            this.tpMaiz.Padding = new System.Windows.Forms.Padding(3);
            this.tpMaiz.Size = new System.Drawing.Size(490, 189);
            this.tpMaiz.TabIndex = 1;
            this.tpMaiz.Text = "MAIZ";
            this.tpMaiz.UseVisualStyleBackColor = true;
            // 
            // checkedListBox6
            // 
            this.checkedListBox6.FormattingEnabled = true;
            this.checkedListBox6.Items.AddRange(new object[] {
            "Sintoma 1",
            "Sintoma 2",
            "Sintoma 3",
            "Sintoma 4"});
            this.checkedListBox6.Location = new System.Drawing.Point(473, 35);
            this.checkedListBox6.Name = "checkedListBox6";
            this.checkedListBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox6.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox6.TabIndex = 10;
            // 
            // checkedListBox5
            // 
            this.checkedListBox5.FormattingEnabled = true;
            this.checkedListBox5.Items.AddRange(new object[] {
            "Sintoma 1",
            "Sintoma 2",
            "Sintoma 3",
            "Sintoma 4"});
            this.checkedListBox5.Location = new System.Drawing.Point(248, 35);
            this.checkedListBox5.Name = "checkedListBox5";
            this.checkedListBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox5.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox5.TabIndex = 9;
            // 
            // checkedListBox4
            // 
            this.checkedListBox4.FormattingEnabled = true;
            this.checkedListBox4.Items.AddRange(new object[] {
            "Sintoma 1",
            "Sintoma 2",
            "Sintoma 3",
            "Sintoma 4"});
            this.checkedListBox4.Location = new System.Drawing.Point(40, 35);
            this.checkedListBox4.Name = "checkedListBox4";
            this.checkedListBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox4.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox4.TabIndex = 8;
            // 
            // tpFrijol
            // 
            this.tpFrijol.Controls.Add(this.checkedListBox9);
            this.tpFrijol.Controls.Add(this.checkedListBox8);
            this.tpFrijol.Controls.Add(this.checkedListBox7);
            this.tpFrijol.Location = new System.Drawing.Point(4, 34);
            this.tpFrijol.Name = "tpFrijol";
            this.tpFrijol.Padding = new System.Windows.Forms.Padding(3);
            this.tpFrijol.Size = new System.Drawing.Size(490, 189);
            this.tpFrijol.TabIndex = 2;
            this.tpFrijol.Text = "FRIJOL";
            this.tpFrijol.UseVisualStyleBackColor = true;
            // 
            // checkedListBox9
            // 
            this.checkedListBox9.FormattingEnabled = true;
            this.checkedListBox9.Items.AddRange(new object[] {
            "Sintoma 1",
            "Sintoma 2",
            "Sintoma 3",
            "Sintoma 4"});
            this.checkedListBox9.Location = new System.Drawing.Point(490, 34);
            this.checkedListBox9.Name = "checkedListBox9";
            this.checkedListBox9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox9.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox9.TabIndex = 3;
            // 
            // checkedListBox8
            // 
            this.checkedListBox8.FormattingEnabled = true;
            this.checkedListBox8.Items.AddRange(new object[] {
            "Sintoma 1",
            "Sintoma 2",
            "Sintoma 3",
            "Sintoma 4"});
            this.checkedListBox8.Location = new System.Drawing.Point(264, 34);
            this.checkedListBox8.Name = "checkedListBox8";
            this.checkedListBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox8.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox8.TabIndex = 2;
            // 
            // checkedListBox7
            // 
            this.checkedListBox7.FormattingEnabled = true;
            this.checkedListBox7.Items.AddRange(new object[] {
            "Sintoma 1",
            "Sintoma 2",
            "Sintoma 3",
            "Sintoma 4"});
            this.checkedListBox7.Location = new System.Drawing.Point(37, 34);
            this.checkedListBox7.Name = "checkedListBox7";
            this.checkedListBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox7.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox7.TabIndex = 1;
            // 
            // tpCaña
            // 
            this.tpCaña.Controls.Add(this.checkedListBox12);
            this.tpCaña.Controls.Add(this.checkedListBox11);
            this.tpCaña.Controls.Add(this.checkedListBox10);
            this.tpCaña.Location = new System.Drawing.Point(4, 34);
            this.tpCaña.Name = "tpCaña";
            this.tpCaña.Padding = new System.Windows.Forms.Padding(3);
            this.tpCaña.Size = new System.Drawing.Size(490, 189);
            this.tpCaña.TabIndex = 3;
            this.tpCaña.Text = "CAÑA";
            this.tpCaña.UseVisualStyleBackColor = true;
            // 
            // checkedListBox12
            // 
            this.checkedListBox12.FormattingEnabled = true;
            this.checkedListBox12.Items.AddRange(new object[] {
            "Sintoma 1",
            "Sintoma 2",
            "Sintoma 3",
            "Sintoma 4"});
            this.checkedListBox12.Location = new System.Drawing.Point(500, 36);
            this.checkedListBox12.Name = "checkedListBox12";
            this.checkedListBox12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox12.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox12.TabIndex = 3;
            // 
            // checkedListBox11
            // 
            this.checkedListBox11.FormattingEnabled = true;
            this.checkedListBox11.Items.AddRange(new object[] {
            "Sintoma 1",
            "Sintoma 2",
            "Sintoma 3",
            "Sintoma 4"});
            this.checkedListBox11.Location = new System.Drawing.Point(261, 36);
            this.checkedListBox11.Name = "checkedListBox11";
            this.checkedListBox11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox11.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox11.TabIndex = 2;
            // 
            // checkedListBox10
            // 
            this.checkedListBox10.FormattingEnabled = true;
            this.checkedListBox10.Items.AddRange(new object[] {
            "Sintoma 1",
            "Sintoma 2",
            "Sintoma 3",
            "Sintoma 4"});
            this.checkedListBox10.Location = new System.Drawing.Point(29, 36);
            this.checkedListBox10.Name = "checkedListBox10";
            this.checkedListBox10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox10.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox10.TabIndex = 1;
            // 
            // tpSandia
            // 
            this.tpSandia.Controls.Add(this.checkedListBox15);
            this.tpSandia.Controls.Add(this.checkedListBox14);
            this.tpSandia.Controls.Add(this.checkedListBox13);
            this.tpSandia.Location = new System.Drawing.Point(4, 34);
            this.tpSandia.Name = "tpSandia";
            this.tpSandia.Padding = new System.Windows.Forms.Padding(3);
            this.tpSandia.Size = new System.Drawing.Size(490, 189);
            this.tpSandia.TabIndex = 4;
            this.tpSandia.Text = "SANDIA";
            this.tpSandia.UseVisualStyleBackColor = true;
            // 
            // checkedListBox15
            // 
            this.checkedListBox15.FormattingEnabled = true;
            this.checkedListBox15.Items.AddRange(new object[] {
            "Sintoma 1",
            "Sintoma 2",
            "Sintoma 3",
            "Sintoma 4"});
            this.checkedListBox15.Location = new System.Drawing.Point(480, 32);
            this.checkedListBox15.Name = "checkedListBox15";
            this.checkedListBox15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox15.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox15.TabIndex = 3;
            // 
            // checkedListBox14
            // 
            this.checkedListBox14.FormattingEnabled = true;
            this.checkedListBox14.Items.AddRange(new object[] {
            "Sintoma 1",
            "Sintoma 2",
            "Sintoma 3",
            "Sintoma 4"});
            this.checkedListBox14.Location = new System.Drawing.Point(255, 32);
            this.checkedListBox14.Name = "checkedListBox14";
            this.checkedListBox14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox14.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox14.TabIndex = 2;
            // 
            // checkedListBox13
            // 
            this.checkedListBox13.FormattingEnabled = true;
            this.checkedListBox13.Items.AddRange(new object[] {
            "Sintoma 1",
            "Sintoma 2",
            "Sintoma 3",
            "Sintoma 4"});
            this.checkedListBox13.Location = new System.Drawing.Point(41, 32);
            this.checkedListBox13.Name = "checkedListBox13";
            this.checkedListBox13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox13.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox13.TabIndex = 1;
            // 
            // tpChile
            // 
            this.tpChile.Controls.Add(this.checkedListBox18);
            this.tpChile.Controls.Add(this.checkedListBox17);
            this.tpChile.Controls.Add(this.checkedListBox16);
            this.tpChile.Location = new System.Drawing.Point(4, 34);
            this.tpChile.Name = "tpChile";
            this.tpChile.Padding = new System.Windows.Forms.Padding(3);
            this.tpChile.Size = new System.Drawing.Size(490, 189);
            this.tpChile.TabIndex = 5;
            this.tpChile.Text = "CHILE";
            this.tpChile.UseVisualStyleBackColor = true;
            // 
            // checkedListBox18
            // 
            this.checkedListBox18.FormattingEnabled = true;
            this.checkedListBox18.Items.AddRange(new object[] {
            "Sintoma 1",
            "Sintoma 2",
            "Sintoma 3",
            "Sintoma 4"});
            this.checkedListBox18.Location = new System.Drawing.Point(495, 34);
            this.checkedListBox18.Name = "checkedListBox18";
            this.checkedListBox18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox18.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox18.TabIndex = 3;
            // 
            // checkedListBox17
            // 
            this.checkedListBox17.FormattingEnabled = true;
            this.checkedListBox17.Items.AddRange(new object[] {
            "Sintoma 1",
            "Sintoma 2",
            "Sintoma 3",
            "Sintoma 4"});
            this.checkedListBox17.Location = new System.Drawing.Point(264, 34);
            this.checkedListBox17.Name = "checkedListBox17";
            this.checkedListBox17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox17.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox17.TabIndex = 2;
            // 
            // checkedListBox16
            // 
            this.checkedListBox16.FormattingEnabled = true;
            this.checkedListBox16.Items.AddRange(new object[] {
            "Sintoma 1",
            "Sintoma 2",
            "Sintoma 3",
            "Sintoma 4"});
            this.checkedListBox16.Location = new System.Drawing.Point(44, 33);
            this.checkedListBox16.Name = "checkedListBox16";
            this.checkedListBox16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox16.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox16.TabIndex = 1;
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
            // tbDiagnostico
            // 
            this.tbDiagnostico.BackColor = System.Drawing.Color.Aquamarine;
            this.tbDiagnostico.Controls.Add(this.lblEnfermedad);
            this.tbDiagnostico.Controls.Add(this.label4);
            this.tbDiagnostico.Controls.Add(this.sintomasClicked);
            this.tbDiagnostico.Controls.Add(this.txtRecomendacion);
            this.tbDiagnostico.Controls.Add(this.lblResult);
            this.tbDiagnostico.Controls.Add(this.lbltxtP);
            this.tbDiagnostico.Controls.Add(this.dgvResultados);
            this.tbDiagnostico.Location = new System.Drawing.Point(4, 22);
            this.tbDiagnostico.Name = "tbDiagnostico";
            this.tbDiagnostico.Padding = new System.Windows.Forms.Padding(3);
            this.tbDiagnostico.Size = new System.Drawing.Size(767, 453);
            this.tbDiagnostico.TabIndex = 1;
            this.tbDiagnostico.Text = "DIAGNOSTICO";
            // 
            // lblEnfermedad
            // 
            this.lblEnfermedad.AutoSize = true;
            this.lblEnfermedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnfermedad.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEnfermedad.Location = new System.Drawing.Point(35, 99);
            this.lblEnfermedad.Name = "lblEnfermedad";
            this.lblEnfermedad.Size = new System.Drawing.Size(117, 20);
            this.lblEnfermedad.TabIndex = 6;
            this.lblEnfermedad.Text = "RESULTADO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(504, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sintomas correspondientes:";
            // 
            // sintomasClicked
            // 
            this.sintomasClicked.FormattingEnabled = true;
            this.sintomasClicked.Location = new System.Drawing.Point(535, 115);
            this.sintomasClicked.Name = "sintomasClicked";
            this.sintomasClicked.Size = new System.Drawing.Size(150, 95);
            this.sintomasClicked.TabIndex = 4;
            // 
            // txtRecomendacion
            // 
            this.txtRecomendacion.Location = new System.Drawing.Point(39, 131);
            this.txtRecomendacion.Multiline = true;
            this.txtRecomendacion.Name = "txtRecomendacion";
            this.txtRecomendacion.Size = new System.Drawing.Size(429, 79);
            this.txtRecomendacion.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(36, 49);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(359, 32);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "DE ACUERDO A LOS DATOS PROPORCIONADOS \r\nEL DIAGNOSTICO FUE: ";
            // 
            // lbltxtP
            // 
            this.lbltxtP.AutoSize = true;
            this.lbltxtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtP.Location = new System.Drawing.Point(36, 237);
            this.lbltxtP.Name = "lbltxtP";
            this.lbltxtP.Size = new System.Drawing.Size(200, 16);
            this.lbltxtP.TabIndex = 1;
            this.lbltxtP.Text = "PRODUCTOS APLICABLES:";
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(39, 256);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(665, 191);
            this.dgvResultados.TabIndex = 0;
            // 
            // Asesoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.TABCONTROL);
            this.Name = "Asesoria";
            this.Text = "Asesoria";
            this.Load += new System.EventHandler(this.Asesoria_Load);
            this.TABCONTROL.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tcSintomas.ResumeLayout(false);
            this.tpPiña.ResumeLayout(false);
            this.tpMaiz.ResumeLayout(false);
            this.tpFrijol.ResumeLayout(false);
            this.tpCaña.ResumeLayout(false);
            this.tpSandia.ResumeLayout(false);
            this.tpChile.ResumeLayout(false);
            this.tbDiagnostico.ResumeLayout(false);
            this.tbDiagnostico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TABCONTROL;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbDiagnostico;
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
        private System.Windows.Forms.CheckedListBox checkedListBox4;
        private System.Windows.Forms.CheckedListBox checkedListBox6;
        private System.Windows.Forms.CheckedListBox checkedListBox5;
        private System.Windows.Forms.CheckedListBox checkedListBox9;
        private System.Windows.Forms.CheckedListBox checkedListBox8;
        private System.Windows.Forms.CheckedListBox checkedListBox7;
        private System.Windows.Forms.CheckedListBox checkedListBox12;
        private System.Windows.Forms.CheckedListBox checkedListBox11;
        private System.Windows.Forms.CheckedListBox checkedListBox10;
        private System.Windows.Forms.CheckedListBox checkedListBox15;
        private System.Windows.Forms.CheckedListBox checkedListBox14;
        private System.Windows.Forms.CheckedListBox checkedListBox13;
        private System.Windows.Forms.CheckedListBox checkedListBox18;
        private System.Windows.Forms.CheckedListBox checkedListBox17;
        private System.Windows.Forms.CheckedListBox checkedListBox16;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbltxtP;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtRecomendacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox sintomasClicked;
        private System.Windows.Forms.Label lblEnfermedad;
    }
}