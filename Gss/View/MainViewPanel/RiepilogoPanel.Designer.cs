namespace Gss.View.MainViewPanel
{
    partial class RiepilogoPanel
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.myLabel1 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel2 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel3 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel4 = new Gss.View.Components.MyLabel(this.components);
            this.SuspendLayout();
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.BackColor = System.Drawing.Color.Transparent;
            this.myLabel1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel1.Location = new System.Drawing.Point(314, 20);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(77, 21);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "myLabel1";
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel2.Location = new System.Drawing.Point(70, 136);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(77, 21);
            this.myLabel2.TabIndex = 1;
            this.myLabel2.Text = "myLabel2";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel3.Location = new System.Drawing.Point(468, 136);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(77, 21);
            this.myLabel3.TabIndex = 2;
            this.myLabel3.Text = "myLabel3";
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel4.Location = new System.Drawing.Point(74, 431);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(77, 21);
            this.myLabel4.TabIndex = 3;
            this.myLabel4.Text = "myLabel4";
            // 
            // RiepilogoPanel
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.myLabel1);
            this.Name = "RiepilogoPanel";
            this.Size = new System.Drawing.Size(698, 573);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.MyLabel myLabel1;
        private Components.MyLabel myLabel2;
        private Components.MyLabel myLabel3;
        private Components.MyLabel myLabel4;
    }
}
