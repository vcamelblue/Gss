namespace Gss.View {
    partial class AggiungiModificaPeriodo {
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
            this.dataInizioTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataFineTimePicker = new System.Windows.Forms.DateTimePicker();
            this.annullaButton = new Gss.View.Components.MyButton(this.components);
            this.salvaButton = new Gss.View.Components.MyButton(this.components);
            this.myLabel3 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel2 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel1 = new Gss.View.Components.MyLabel(this.components);
            this.profiloPeriodoComboBox = new Gss.View.Components.MyComboBox(this.components);
            this.SuspendLayout();
            // 
            // dataInizioTimePicker
            // 
            this.dataInizioTimePicker.Location = new System.Drawing.Point(305, 117);
            this.dataInizioTimePicker.Name = "dataInizioTimePicker";
            this.dataInizioTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataInizioTimePicker.TabIndex = 4;
            this.dataInizioTimePicker.ValueChanged += new System.EventHandler(this.dataInizioTimePicker_ValueChanged);
            // 
            // dataFineTimePicker
            // 
            this.dataFineTimePicker.Location = new System.Drawing.Point(305, 175);
            this.dataFineTimePicker.Name = "dataFineTimePicker";
            this.dataFineTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataFineTimePicker.TabIndex = 5;
            // 
            // annullaButton
            // 
            this.annullaButton.BackColor = System.Drawing.Color.LightGray;
            this.annullaButton.FlatAppearance.BorderSize = 0;
            this.annullaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annullaButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annullaButton.Location = new System.Drawing.Point(108, 257);
            this.annullaButton.Name = "annullaButton";
            this.annullaButton.Size = new System.Drawing.Size(117, 26);
            this.annullaButton.TabIndex = 7;
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
            this.salvaButton.Location = new System.Drawing.Point(349, 257);
            this.salvaButton.Name = "salvaButton";
            this.salvaButton.Size = new System.Drawing.Size(117, 26);
            this.salvaButton.TabIndex = 6;
            this.salvaButton.Text = "Salva";
            this.salvaButton.UseVisualStyleBackColor = false;
            this.salvaButton.Click += new System.EventHandler(this.salvaButton_Click);
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel3.Location = new System.Drawing.Point(75, 177);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(62, 17);
            this.myLabel3.TabIndex = 2;
            this.myLabel3.Text = "Data Fine";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel2.Location = new System.Drawing.Point(75, 119);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(69, 17);
            this.myLabel2.TabIndex = 1;
            this.myLabel2.Text = "Data Inizio";
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.BackColor = System.Drawing.Color.Transparent;
            this.myLabel1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel1.Location = new System.Drawing.Point(75, 58);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(90, 17);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "Profilo Periodo";
            // 
            // profiloPeriodoComboBox
            // 
            this.profiloPeriodoComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.profiloPeriodoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profiloPeriodoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profiloPeriodoComboBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profiloPeriodoComboBox.FormattingEnabled = true;
            this.profiloPeriodoComboBox.Location = new System.Drawing.Point(305, 55);
            this.profiloPeriodoComboBox.Name = "profiloPeriodoComboBox";
            this.profiloPeriodoComboBox.Size = new System.Drawing.Size(200, 22);
            this.profiloPeriodoComboBox.TabIndex = 3;
            // 
            // AggiungiModificaPeriodo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(582, 303);
            this.Controls.Add(this.profiloPeriodoComboBox);
            this.Controls.Add(this.annullaButton);
            this.Controls.Add(this.salvaButton);
            this.Controls.Add(this.dataFineTimePicker);
            this.Controls.Add(this.dataInizioTimePicker);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.myLabel1);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AggiungiModificaPeriodo";
            this.Text = "Aggiungi Periodo";
            this.Load += new System.EventHandler(this.AggiungiModificaPeriodo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.MyLabel myLabel1;
        private Components.MyLabel myLabel2;
        private Components.MyLabel myLabel3;
        private System.Windows.Forms.DateTimePicker dataInizioTimePicker;
        private System.Windows.Forms.DateTimePicker dataFineTimePicker;
        private Components.MyButton salvaButton;
        private Components.MyButton annullaButton;
        private Components.MyComboBox profiloPeriodoComboBox;
    }
}