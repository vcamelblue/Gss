namespace Gss.View {
    partial class AggiungiModificaPista {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.annullaButton = new Gss.View.Components.MyButton(this.components);
            this.salvaButton = new Gss.View.Components.MyButton(this.components);
            this.tipologiaComboBox1 = new Gss.View.Components.MyComboBox(this.components);
            this.tabControlWithoutHeader1 = new Gss.View.Components.TabControlWithoutHeader(this.components);
            this.tabVuoto = new System.Windows.Forms.TabPage();
            this.tabAlpina = new System.Windows.Forms.TabPage();
            this.difficoltaComboBox = new Gss.View.Components.MyComboBox(this.components);
            this.myLabel3 = new Gss.View.Components.MyLabel(this.components);
            this.nomeAlpinaTextBox = new Gss.View.Components.MyTextBox(this.components);
            this.myLabel2 = new Gss.View.Components.MyLabel(this.components);
            this.tabFondo = new System.Windows.Forms.TabPage();
            this.dislivelloMedioTextBox = new Gss.View.Components.MyTextBox(this.components);
            this.dislivelloMaxTextBox2 = new Gss.View.Components.MyTextBox(this.components);
            this.nomeFondoTextBox = new Gss.View.Components.MyTextBox(this.components);
            this.myLabel6 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel5 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel4 = new Gss.View.Components.MyLabel(this.components);
            this.tabSnowpark = new System.Windows.Forms.TabPage();
            this.numeroJibsTextBox = new Gss.View.Components.MyTextBox(this.components);
            this.numeroSaltiTextBox = new Gss.View.Components.MyTextBox(this.components);
            this.nomeSnowparkTextBox = new Gss.View.Components.MyTextBox(this.components);
            this.myLabel9 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel8 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel7 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel1 = new Gss.View.Components.MyLabel(this.components);
            this.tabControlWithoutHeader1.SuspendLayout();
            this.tabAlpina.SuspendLayout();
            this.tabFondo.SuspendLayout();
            this.tabSnowpark.SuspendLayout();
            this.SuspendLayout();
            // 
            // annullaButton
            // 
            this.annullaButton.BackColor = System.Drawing.Color.LightGray;
            this.annullaButton.FlatAppearance.BorderSize = 0;
            this.annullaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annullaButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annullaButton.Location = new System.Drawing.Point(80, 244);
            this.annullaButton.Name = "annullaButton";
            this.annullaButton.Size = new System.Drawing.Size(63, 26);
            this.annullaButton.TabIndex = 8;
            this.annullaButton.Text = "Annulla";
            this.annullaButton.UseVisualStyleBackColor = false;
            this.annullaButton.Click += new System.EventHandler(this.annullaButton_Click);
            // 
            // salvaButton
            // 
            this.salvaButton.BackColor = System.Drawing.Color.LightGray;
            this.salvaButton.FlatAppearance.BorderSize = 0;
            this.salvaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvaButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvaButton.Location = new System.Drawing.Point(299, 244);
            this.salvaButton.Name = "salvaButton";
            this.salvaButton.Size = new System.Drawing.Size(120, 26);
            this.salvaButton.TabIndex = 7;
            this.salvaButton.Text = "Salva";
            this.salvaButton.UseVisualStyleBackColor = false;
            this.salvaButton.Click += new System.EventHandler(this.salvaButton_Click);
            // 
            // tipologiaComboBox1
            // 
            this.tipologiaComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.tipologiaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipologiaComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipologiaComboBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipologiaComboBox1.Location = new System.Drawing.Point(280, 28);
            this.tipologiaComboBox1.Name = "tipologiaComboBox1";
            this.tipologiaComboBox1.Size = new System.Drawing.Size(121, 22);
            this.tipologiaComboBox1.TabIndex = 6;
            this.tipologiaComboBox1.SelectedValueChanged += new System.EventHandler(this.tipologiaComboBox1_SelectedValueChanged);
            // 
            // tabControlWithoutHeader1
            // 
            this.tabControlWithoutHeader1.Controls.Add(this.tabVuoto);
            this.tabControlWithoutHeader1.Controls.Add(this.tabAlpina);
            this.tabControlWithoutHeader1.Controls.Add(this.tabFondo);
            this.tabControlWithoutHeader1.Controls.Add(this.tabSnowpark);
            this.tabControlWithoutHeader1.Font = new System.Drawing.Font("Calibri", 9F);
            this.tabControlWithoutHeader1.Location = new System.Drawing.Point(0, 56);
            this.tabControlWithoutHeader1.Name = "tabControlWithoutHeader1";
            this.tabControlWithoutHeader1.SelectedIndex = 0;
            this.tabControlWithoutHeader1.Size = new System.Drawing.Size(457, 159);
            this.tabControlWithoutHeader1.TabIndex = 5;
            // 
            // tabVuoto
            // 
            this.tabVuoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.tabVuoto.Location = new System.Drawing.Point(4, 23);
            this.tabVuoto.Name = "tabVuoto";
            this.tabVuoto.Padding = new System.Windows.Forms.Padding(3);
            this.tabVuoto.Size = new System.Drawing.Size(449, 132);
            this.tabVuoto.TabIndex = 0;
            this.tabVuoto.Text = "tabPage1";
            // 
            // tabAlpina
            // 
            this.tabAlpina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.tabAlpina.Controls.Add(this.difficoltaComboBox);
            this.tabAlpina.Controls.Add(this.myLabel3);
            this.tabAlpina.Controls.Add(this.nomeAlpinaTextBox);
            this.tabAlpina.Controls.Add(this.myLabel2);
            this.tabAlpina.Location = new System.Drawing.Point(4, 23);
            this.tabAlpina.Name = "tabAlpina";
            this.tabAlpina.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlpina.Size = new System.Drawing.Size(449, 132);
            this.tabAlpina.TabIndex = 1;
            this.tabAlpina.Text = "tabPage2";
            // 
            // difficoltaComboBox
            // 
            this.difficoltaComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.difficoltaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficoltaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.difficoltaComboBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficoltaComboBox.FormattingEnabled = true;
            this.difficoltaComboBox.Location = new System.Drawing.Point(276, 80);
            this.difficoltaComboBox.Name = "difficoltaComboBox";
            this.difficoltaComboBox.Size = new System.Drawing.Size(121, 22);
            this.difficoltaComboBox.TabIndex = 3;
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel3.Location = new System.Drawing.Point(52, 80);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(59, 17);
            this.myLabel3.TabIndex = 2;
            this.myLabel3.Text = "Difficolta";
            // 
            // nomeAlpinaTextBox
            // 
            this.nomeAlpinaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.nomeAlpinaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeAlpinaTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeAlpinaTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.nomeAlpinaTextBox.Location = new System.Drawing.Point(276, 34);
            this.nomeAlpinaTextBox.Name = "nomeAlpinaTextBox";
            this.nomeAlpinaTextBox.Size = new System.Drawing.Size(100, 17);
            this.nomeAlpinaTextBox.TabIndex = 1;
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel2.Location = new System.Drawing.Point(49, 34);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(42, 17);
            this.myLabel2.TabIndex = 0;
            this.myLabel2.Text = "Nome";
            // 
            // tabFondo
            // 
            this.tabFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.tabFondo.Controls.Add(this.dislivelloMedioTextBox);
            this.tabFondo.Controls.Add(this.dislivelloMaxTextBox2);
            this.tabFondo.Controls.Add(this.nomeFondoTextBox);
            this.tabFondo.Controls.Add(this.myLabel6);
            this.tabFondo.Controls.Add(this.myLabel5);
            this.tabFondo.Controls.Add(this.myLabel4);
            this.tabFondo.Location = new System.Drawing.Point(4, 23);
            this.tabFondo.Name = "tabFondo";
            this.tabFondo.Padding = new System.Windows.Forms.Padding(3);
            this.tabFondo.Size = new System.Drawing.Size(449, 132);
            this.tabFondo.TabIndex = 2;
            this.tabFondo.Text = "tabPage3";
            // 
            // dislivelloMedioTextBox
            // 
            this.dislivelloMedioTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dislivelloMedioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dislivelloMedioTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dislivelloMedioTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.dislivelloMedioTextBox.Location = new System.Drawing.Point(201, 96);
            this.dislivelloMedioTextBox.Name = "dislivelloMedioTextBox";
            this.dislivelloMedioTextBox.Size = new System.Drawing.Size(100, 17);
            this.dislivelloMedioTextBox.TabIndex = 5;
            // 
            // dislivelloMaxTextBox2
            // 
            this.dislivelloMaxTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dislivelloMaxTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dislivelloMaxTextBox2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dislivelloMaxTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.dislivelloMaxTextBox2.Location = new System.Drawing.Point(201, 60);
            this.dislivelloMaxTextBox2.Name = "dislivelloMaxTextBox2";
            this.dislivelloMaxTextBox2.Size = new System.Drawing.Size(100, 17);
            this.dislivelloMaxTextBox2.TabIndex = 4;
            // 
            // nomeFondoTextBox
            // 
            this.nomeFondoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.nomeFondoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeFondoTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeFondoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.nomeFondoTextBox.Location = new System.Drawing.Point(201, 27);
            this.nomeFondoTextBox.Name = "nomeFondoTextBox";
            this.nomeFondoTextBox.Size = new System.Drawing.Size(100, 17);
            this.nomeFondoTextBox.TabIndex = 3;
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = true;
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel6.Location = new System.Drawing.Point(49, 96);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Size = new System.Drawing.Size(96, 17);
            this.myLabel6.TabIndex = 2;
            this.myLabel6.Text = "Dislivello Medio";
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel5.Location = new System.Drawing.Point(49, 60);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(110, 17);
            this.myLabel5.TabIndex = 1;
            this.myLabel5.Text = "Dislivello Massimo";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel4.Location = new System.Drawing.Point(49, 27);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(42, 17);
            this.myLabel4.TabIndex = 0;
            this.myLabel4.Text = "Nome";
            // 
            // tabSnowpark
            // 
            this.tabSnowpark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.tabSnowpark.Controls.Add(this.numeroJibsTextBox);
            this.tabSnowpark.Controls.Add(this.numeroSaltiTextBox);
            this.tabSnowpark.Controls.Add(this.nomeSnowparkTextBox);
            this.tabSnowpark.Controls.Add(this.myLabel9);
            this.tabSnowpark.Controls.Add(this.myLabel8);
            this.tabSnowpark.Controls.Add(this.myLabel7);
            this.tabSnowpark.Location = new System.Drawing.Point(4, 23);
            this.tabSnowpark.Name = "tabSnowpark";
            this.tabSnowpark.Padding = new System.Windows.Forms.Padding(3);
            this.tabSnowpark.Size = new System.Drawing.Size(449, 132);
            this.tabSnowpark.TabIndex = 3;
            this.tabSnowpark.Text = "tabPage4";
            // 
            // numeroJibsTextBox
            // 
            this.numeroJibsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.numeroJibsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numeroJibsTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroJibsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.numeroJibsTextBox.Location = new System.Drawing.Point(177, 94);
            this.numeroJibsTextBox.Name = "numeroJibsTextBox";
            this.numeroJibsTextBox.Size = new System.Drawing.Size(100, 17);
            this.numeroJibsTextBox.TabIndex = 5;
            // 
            // numeroSaltiTextBox
            // 
            this.numeroSaltiTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.numeroSaltiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numeroSaltiTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroSaltiTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.numeroSaltiTextBox.Location = new System.Drawing.Point(177, 58);
            this.numeroSaltiTextBox.Name = "numeroSaltiTextBox";
            this.numeroSaltiTextBox.Size = new System.Drawing.Size(100, 17);
            this.numeroSaltiTextBox.TabIndex = 4;
            // 
            // nomeSnowparkTextBox
            // 
            this.nomeSnowparkTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.nomeSnowparkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeSnowparkTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeSnowparkTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.nomeSnowparkTextBox.Location = new System.Drawing.Point(177, 25);
            this.nomeSnowparkTextBox.Name = "nomeSnowparkTextBox";
            this.nomeSnowparkTextBox.Size = new System.Drawing.Size(100, 17);
            this.nomeSnowparkTextBox.TabIndex = 3;
            // 
            // myLabel9
            // 
            this.myLabel9.AutoSize = true;
            this.myLabel9.BackColor = System.Drawing.Color.Transparent;
            this.myLabel9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel9.Location = new System.Drawing.Point(37, 94);
            this.myLabel9.Name = "myLabel9";
            this.myLabel9.Size = new System.Drawing.Size(76, 17);
            this.myLabel9.TabIndex = 2;
            this.myLabel9.Text = "Numero Jibs";
            // 
            // myLabel8
            // 
            this.myLabel8.AutoSize = true;
            this.myLabel8.BackColor = System.Drawing.Color.Transparent;
            this.myLabel8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel8.Location = new System.Drawing.Point(37, 58);
            this.myLabel8.Name = "myLabel8";
            this.myLabel8.Size = new System.Drawing.Size(81, 17);
            this.myLabel8.TabIndex = 1;
            this.myLabel8.Text = "Numero Salti";
            // 
            // myLabel7
            // 
            this.myLabel7.AutoSize = true;
            this.myLabel7.BackColor = System.Drawing.Color.Transparent;
            this.myLabel7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel7.Location = new System.Drawing.Point(37, 25);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.Size = new System.Drawing.Size(42, 17);
            this.myLabel7.TabIndex = 0;
            this.myLabel7.Text = "Nome";
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.BackColor = System.Drawing.Color.Transparent;
            this.myLabel1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel1.Location = new System.Drawing.Point(53, 29);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(59, 17);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "Tipologia";
            // 
            // AggiungiModificaPista
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(454, 295);
            this.Controls.Add(this.annullaButton);
            this.Controls.Add(this.salvaButton);
            this.Controls.Add(this.tipologiaComboBox1);
            this.Controls.Add(this.tabControlWithoutHeader1);
            this.Controls.Add(this.myLabel1);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AggiungiModificaPista";
            this.Text = "Aggiungi Pista";
            this.Load += new System.EventHandler(this.AggiungiModificaPista_Load);
            this.tabControlWithoutHeader1.ResumeLayout(false);
            this.tabAlpina.ResumeLayout(false);
            this.tabAlpina.PerformLayout();
            this.tabFondo.ResumeLayout(false);
            this.tabFondo.PerformLayout();
            this.tabSnowpark.ResumeLayout(false);
            this.tabSnowpark.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.MyLabel myLabel1;
        private Components.TabControlWithoutHeader tabControlWithoutHeader1;
        private System.Windows.Forms.TabPage tabVuoto;
        private System.Windows.Forms.TabPage tabAlpina;
        private Components.MyLabel myLabel2;
        private System.Windows.Forms.TabPage tabFondo;
        private System.Windows.Forms.TabPage tabSnowpark;
        private Components.MyComboBox difficoltaComboBox;
        private Components.MyLabel myLabel3;
        private Components.MyTextBox nomeAlpinaTextBox;
        private Components.MyTextBox dislivelloMedioTextBox;
        private Components.MyTextBox dislivelloMaxTextBox2;
        private Components.MyTextBox nomeFondoTextBox;
        private Components.MyLabel myLabel6;
        private Components.MyLabel myLabel5;
        private Components.MyLabel myLabel4;
        private Components.MyTextBox numeroJibsTextBox;
        private Components.MyTextBox numeroSaltiTextBox;
        private Components.MyTextBox nomeSnowparkTextBox;
        private Components.MyLabel myLabel9;
        private Components.MyLabel myLabel8;
        private Components.MyLabel myLabel7;
        private Components.MyComboBox tipologiaComboBox1;
        private Components.MyButton salvaButton;
        private Components.MyButton annullaButton;
    }
}