namespace Gss.View {
    partial class AggiungiModificaCliente {
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
            this.dataNascitaTimePicker = new System.Windows.Forms.DateTimePicker();
            this.annullaButton = new Gss.View.Components.MyButton(this.components);
            this.salvaButton = new Gss.View.Components.MyButton(this.components);
            this.emailTextBox = new Gss.View.Components.MyTextBox(this.components);
            this.telefonoTextBox = new Gss.View.Components.MyTextBox(this.components);
            this.indirizzoTextBox = new Gss.View.Components.MyTextBox(this.components);
            this.codiceFiscaleTextBox = new Gss.View.Components.MyTextBox(this.components);
            this.cognomeTextBox = new Gss.View.Components.MyTextBox(this.components);
            this.nomeTextBox = new Gss.View.Components.MyTextBox(this.components);
            this.myLabel7 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel6 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel5 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel4 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel3 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel2 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel1 = new Gss.View.Components.MyLabel(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataNascitaTimePicker
            // 
            this.dataNascitaTimePicker.Location = new System.Drawing.Point(178, 177);
            this.dataNascitaTimePicker.Name = "dataNascitaTimePicker";
            this.dataNascitaTimePicker.Size = new System.Drawing.Size(186, 23);
            this.dataNascitaTimePicker.TabIndex = 9;
            // 
            // annullaButton
            // 
            this.annullaButton.BackColor = System.Drawing.Color.LightGray;
            this.annullaButton.FlatAppearance.BorderSize = 0;
            this.annullaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annullaButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annullaButton.Location = new System.Drawing.Point(54, 502);
            this.annullaButton.Name = "annullaButton";
            this.annullaButton.Size = new System.Drawing.Size(120, 26);
            this.annullaButton.TabIndex = 15;
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
            this.salvaButton.Location = new System.Drawing.Point(223, 502);
            this.salvaButton.Name = "salvaButton";
            this.salvaButton.Size = new System.Drawing.Size(120, 26);
            this.salvaButton.TabIndex = 14;
            this.salvaButton.Text = "Aggiungi";
            this.salvaButton.UseVisualStyleBackColor = false;
            this.salvaButton.Click += new System.EventHandler(this.salvaButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.emailTextBox.Location = new System.Drawing.Point(178, 419);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(186, 21);
            this.emailTextBox.TabIndex = 13;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.telefonoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefonoTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.telefonoTextBox.Location = new System.Drawing.Point(178, 359);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(186, 21);
            this.telefonoTextBox.TabIndex = 12;
            this.telefonoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // indirizzoTextBox
            // 
            this.indirizzoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.indirizzoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.indirizzoTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indirizzoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.indirizzoTextBox.Location = new System.Drawing.Point(178, 299);
            this.indirizzoTextBox.Name = "indirizzoTextBox";
            this.indirizzoTextBox.Size = new System.Drawing.Size(186, 21);
            this.indirizzoTextBox.TabIndex = 11;
            this.indirizzoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // codiceFiscaleTextBox
            // 
            this.codiceFiscaleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.codiceFiscaleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codiceFiscaleTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codiceFiscaleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.codiceFiscaleTextBox.Location = new System.Drawing.Point(178, 239);
            this.codiceFiscaleTextBox.Name = "codiceFiscaleTextBox";
            this.codiceFiscaleTextBox.Size = new System.Drawing.Size(186, 21);
            this.codiceFiscaleTextBox.TabIndex = 10;
            this.codiceFiscaleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cognomeTextBox
            // 
            this.cognomeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cognomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cognomeTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cognomeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.cognomeTextBox.Location = new System.Drawing.Point(178, 117);
            this.cognomeTextBox.Name = "cognomeTextBox";
            this.cognomeTextBox.Size = new System.Drawing.Size(186, 21);
            this.cognomeTextBox.TabIndex = 8;
            this.cognomeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.nomeTextBox.Location = new System.Drawing.Point(178, 57);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(186, 21);
            this.nomeTextBox.TabIndex = 7;
            this.nomeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // myLabel7
            // 
            this.myLabel7.AutoSize = true;
            this.myLabel7.BackColor = System.Drawing.Color.Transparent;
            this.myLabel7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel7.Location = new System.Drawing.Point(36, 423);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.Size = new System.Drawing.Size(53, 21);
            this.myLabel7.TabIndex = 6;
            this.myLabel7.Text = "E-mail";
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = true;
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel6.Location = new System.Drawing.Point(36, 362);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Size = new System.Drawing.Size(68, 21);
            this.myLabel6.TabIndex = 5;
            this.myLabel6.Text = "Telefono";
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel5.Location = new System.Drawing.Point(36, 301);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(69, 21);
            this.myLabel5.TabIndex = 4;
            this.myLabel5.Text = "Indirizzo";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel4.Location = new System.Drawing.Point(36, 240);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(106, 21);
            this.myLabel4.TabIndex = 3;
            this.myLabel4.Text = "Codice Fiscale";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel3.Location = new System.Drawing.Point(36, 179);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(97, 21);
            this.myLabel3.TabIndex = 2;
            this.myLabel3.Text = "Data Nascita";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel2.Location = new System.Drawing.Point(36, 117);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(76, 21);
            this.myLabel2.TabIndex = 1;
            this.myLabel2.Text = "Cognome";
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.BackColor = System.Drawing.Color.Transparent;
            this.myLabel1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel1.Location = new System.Drawing.Point(36, 57);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(52, 21);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "Nome";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AggiungiModificaCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(401, 553);
            this.Controls.Add(this.annullaButton);
            this.Controls.Add(this.salvaButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.indirizzoTextBox);
            this.Controls.Add(this.codiceFiscaleTextBox);
            this.Controls.Add(this.dataNascitaTimePicker);
            this.Controls.Add(this.cognomeTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.myLabel7);
            this.Controls.Add(this.myLabel6);
            this.Controls.Add(this.myLabel5);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.myLabel1);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AggiungiModificaCliente";
            this.Text = "Aggiungi Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.MyLabel myLabel1;
        private Components.MyLabel myLabel2;
        private Components.MyLabel myLabel3;
        private Components.MyLabel myLabel4;
        private Components.MyLabel myLabel5;
        private Components.MyLabel myLabel6;
        private Components.MyLabel myLabel7;
        private Components.MyTextBox nomeTextBox;
        private Components.MyTextBox cognomeTextBox;
        private System.Windows.Forms.DateTimePicker dataNascitaTimePicker;
        private Components.MyTextBox codiceFiscaleTextBox;
        private Components.MyTextBox indirizzoTextBox;
        private Components.MyTextBox telefonoTextBox;
        private Components.MyTextBox emailTextBox;
        private Components.MyButton salvaButton;
        private Components.MyButton annullaButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}