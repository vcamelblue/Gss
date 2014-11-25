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
            this.myLabel1 = new Gss.View.Components.MyLabel(this.components);
            this.tabControlWithoutHeader1 = new Gss.View.Components.TabControlWithoutHeader(this.components);
            this.tabVuoto = new System.Windows.Forms.TabPage();
            this.tabAlpina = new System.Windows.Forms.TabPage();
            this.tabFondo = new System.Windows.Forms.TabPage();
            this.tabSnowpark = new System.Windows.Forms.TabPage();
            this.myLabel2 = new Gss.View.Components.MyLabel(this.components);
            this.nomeAlpinaTextBox = new Gss.View.Components.MyTextBox(this.components);
            this.tabControlWithoutHeader1.SuspendLayout();
            this.tabAlpina.SuspendLayout();
            this.SuspendLayout();
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.BackColor = System.Drawing.Color.Transparent;
            this.myLabel1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel1.Location = new System.Drawing.Point(57, 30);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(59, 17);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "Tipologia";
            // 
            // tabControlWithoutHeader1
            // 
            this.tabControlWithoutHeader1.Controls.Add(this.tabVuoto);
            this.tabControlWithoutHeader1.Controls.Add(this.tabAlpina);
            this.tabControlWithoutHeader1.Controls.Add(this.tabFondo);
            this.tabControlWithoutHeader1.Controls.Add(this.tabSnowpark);
            this.tabControlWithoutHeader1.Location = new System.Drawing.Point(0, 50);
            this.tabControlWithoutHeader1.Name = "tabControlWithoutHeader1";
            this.tabControlWithoutHeader1.SelectedIndex = 0;
            this.tabControlWithoutHeader1.Size = new System.Drawing.Size(457, 159);
            this.tabControlWithoutHeader1.TabIndex = 5;
            // 
            // tabVuoto
            // 
            this.tabVuoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.tabVuoto.Location = new System.Drawing.Point(4, 22);
            this.tabVuoto.Name = "tabVuoto";
            this.tabVuoto.Padding = new System.Windows.Forms.Padding(3);
            this.tabVuoto.Size = new System.Drawing.Size(449, 133);
            this.tabVuoto.TabIndex = 0;
            this.tabVuoto.Text = "tabPage1";
            // 
            // tabAlpina
            // 
            this.tabAlpina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.tabAlpina.Controls.Add(this.nomeAlpinaTextBox);
            this.tabAlpina.Controls.Add(this.myLabel2);
            this.tabAlpina.Location = new System.Drawing.Point(4, 22);
            this.tabAlpina.Name = "tabAlpina";
            this.tabAlpina.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlpina.Size = new System.Drawing.Size(449, 133);
            this.tabAlpina.TabIndex = 1;
            this.tabAlpina.Text = "tabPage2";
            // 
            // tabFondo
            // 
            this.tabFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.tabFondo.Location = new System.Drawing.Point(4, 22);
            this.tabFondo.Name = "tabFondo";
            this.tabFondo.Padding = new System.Windows.Forms.Padding(3);
            this.tabFondo.Size = new System.Drawing.Size(449, 133);
            this.tabFondo.TabIndex = 2;
            this.tabFondo.Text = "tabPage3";
            // 
            // tabSnowpark
            // 
            this.tabSnowpark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.tabSnowpark.Location = new System.Drawing.Point(4, 22);
            this.tabSnowpark.Name = "tabSnowpark";
            this.tabSnowpark.Padding = new System.Windows.Forms.Padding(3);
            this.tabSnowpark.Size = new System.Drawing.Size(449, 133);
            this.tabSnowpark.TabIndex = 3;
            this.tabSnowpark.Text = "tabPage4";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel2.Location = new System.Drawing.Point(48, 16);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(42, 17);
            this.myLabel2.TabIndex = 0;
            this.myLabel2.Text = "Nome";
            // 
            // nomeAlpinaTextBox
            // 
            this.nomeAlpinaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.nomeAlpinaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeAlpinaTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeAlpinaTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.nomeAlpinaTextBox.Location = new System.Drawing.Point(264, 16);
            this.nomeAlpinaTextBox.Name = "nomeAlpinaTextBox";
            this.nomeAlpinaTextBox.Size = new System.Drawing.Size(100, 17);
            this.nomeAlpinaTextBox.TabIndex = 1;
            // 
            // AggiungiModificaPista
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(454, 295);
            this.Controls.Add(this.tabControlWithoutHeader1);
            this.Controls.Add(this.myLabel1);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AggiungiModificaPista";
            this.Text = "Aggiungi Pista";
            this.tabControlWithoutHeader1.ResumeLayout(false);
            this.tabAlpina.ResumeLayout(false);
            this.tabAlpina.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.MyLabel myLabel1;
        private Components.TabControlWithoutHeader tabControlWithoutHeader1;
        private System.Windows.Forms.TabPage tabVuoto;
        private System.Windows.Forms.TabPage tabAlpina;
        private Components.MyTextBox nomeAlpinaTextBox;
        private Components.MyLabel myLabel2;
        private System.Windows.Forms.TabPage tabFondo;
        private System.Windows.Forms.TabPage tabSnowpark;
    }
}