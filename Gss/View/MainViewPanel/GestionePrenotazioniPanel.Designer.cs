namespace Gss.View.MainViewPanel
{
    partial class GestionePrenotazioniPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.prenotazioniFutureTabButton = new Gss.View.Components.MyButton(this.components);
            this.prenotazioniConcluseTabButton = new Gss.View.Components.MyButton(this.components);
            this.prenotazioniInCorsoTabButton = new Gss.View.Components.MyButton(this.components);
            this.prenotazioniDataGridView = new Gss.View.Components.MyDataGridView(this.components);
            this.numeroPrenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInizioPrenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFinePrenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientePrenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiviaRimuoviPrenotazioneButton = new Gss.View.Components.MyButton(this.components);
            this.modificaPrenotazioneButton = new Gss.View.Components.MyButton(this.components);
            this.nuovaPrenotazioneButton = new Gss.View.Components.MyButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prenotazioniFutureTabButton
            // 
            this.prenotazioniFutureTabButton.BackColor = System.Drawing.Color.LightGray;
            this.prenotazioniFutureTabButton.FlatAppearance.BorderSize = 0;
            this.prenotazioniFutureTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prenotazioniFutureTabButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenotazioniFutureTabButton.Location = new System.Drawing.Point(466, 0);
            this.prenotazioniFutureTabButton.Name = "prenotazioniFutureTabButton";
            this.prenotazioniFutureTabButton.Size = new System.Drawing.Size(232, 26);
            this.prenotazioniFutureTabButton.TabIndex = 2;
            this.prenotazioniFutureTabButton.Text = "Prenotazioni Future";
            this.prenotazioniFutureTabButton.UseVisualStyleBackColor = false;
            this.prenotazioniFutureTabButton.Click += new System.EventHandler(this.prenotazioniFutureTabButton_Click);
            // 
            // prenotazioniConcluseTabButton
            // 
            this.prenotazioniConcluseTabButton.BackColor = System.Drawing.Color.LightGray;
            this.prenotazioniConcluseTabButton.FlatAppearance.BorderSize = 0;
            this.prenotazioniConcluseTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prenotazioniConcluseTabButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenotazioniConcluseTabButton.Location = new System.Drawing.Point(0, 0);
            this.prenotazioniConcluseTabButton.Name = "prenotazioniConcluseTabButton";
            this.prenotazioniConcluseTabButton.Size = new System.Drawing.Size(232, 26);
            this.prenotazioniConcluseTabButton.TabIndex = 0;
            this.prenotazioniConcluseTabButton.Text = "Prenotazioni Concluse";
            this.prenotazioniConcluseTabButton.UseVisualStyleBackColor = false;
            this.prenotazioniConcluseTabButton.Click += new System.EventHandler(this.prenotazioniConcluseTabButton_Click);
            // 
            // prenotazioniInCorsoTabButton
            // 
            this.prenotazioniInCorsoTabButton.BackColor = System.Drawing.Color.LightGray;
            this.prenotazioniInCorsoTabButton.FlatAppearance.BorderSize = 0;
            this.prenotazioniInCorsoTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prenotazioniInCorsoTabButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenotazioniInCorsoTabButton.Location = new System.Drawing.Point(233, 0);
            this.prenotazioniInCorsoTabButton.Name = "prenotazioniInCorsoTabButton";
            this.prenotazioniInCorsoTabButton.Size = new System.Drawing.Size(232, 26);
            this.prenotazioniInCorsoTabButton.TabIndex = 1;
            this.prenotazioniInCorsoTabButton.Text = "Prenotazioni In Corso";
            this.prenotazioniInCorsoTabButton.UseVisualStyleBackColor = false;
            this.prenotazioniInCorsoTabButton.Click += new System.EventHandler(this.prenotazioniInCorsoTabButton_Click);
            // 
            // prenotazioniDataGridView
            // 
            this.prenotazioniDataGridView.AllowUserToAddRows = false;
            this.prenotazioniDataGridView.AllowUserToDeleteRows = false;
            this.prenotazioniDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.prenotazioniDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.prenotazioniDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prenotazioniDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.prenotazioniDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prenotazioniDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.prenotazioniDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prenotazioniDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.prenotazioniDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prenotazioniDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroPrenColumn,
            this.dataInizioPrenColumn,
            this.dataFinePrenColumn,
            this.clientePrenColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prenotazioniDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.prenotazioniDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.prenotazioniDataGridView.Location = new System.Drawing.Point(0, 26);
            this.prenotazioniDataGridView.MultiSelect = false;
            this.prenotazioniDataGridView.Name = "prenotazioniDataGridView";
            this.prenotazioniDataGridView.ReadOnly = true;
            this.prenotazioniDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prenotazioniDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.prenotazioniDataGridView.RowHeadersVisible = false;
            this.prenotazioniDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenotazioniDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.prenotazioniDataGridView.RowTemplate.Height = 30;
            this.prenotazioniDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prenotazioniDataGridView.Size = new System.Drawing.Size(698, 520);
            this.prenotazioniDataGridView.TabIndex = 7;
            // 
            // numeroPrenColumn
            // 
            this.numeroPrenColumn.FillWeight = 20F;
            this.numeroPrenColumn.HeaderText = "Numero";
            this.numeroPrenColumn.Name = "numeroPrenColumn";
            this.numeroPrenColumn.ReadOnly = true;
            // 
            // dataInizioPrenColumn
            // 
            this.dataInizioPrenColumn.FillWeight = 30F;
            this.dataInizioPrenColumn.HeaderText = "Data Inizio";
            this.dataInizioPrenColumn.Name = "dataInizioPrenColumn";
            this.dataInizioPrenColumn.ReadOnly = true;
            // 
            // dataFinePrenColumn
            // 
            this.dataFinePrenColumn.FillWeight = 30F;
            this.dataFinePrenColumn.HeaderText = "Data Fine";
            this.dataFinePrenColumn.Name = "dataFinePrenColumn";
            this.dataFinePrenColumn.ReadOnly = true;
            // 
            // clientePrenColumn
            // 
            this.clientePrenColumn.FillWeight = 45F;
            this.clientePrenColumn.HeaderText = "Cliente";
            this.clientePrenColumn.Name = "clientePrenColumn";
            this.clientePrenColumn.ReadOnly = true;
            // 
            // archiviaRimuoviPrenotazioneButton
            // 
            this.archiviaRimuoviPrenotazioneButton.BackColor = System.Drawing.Color.LightGray;
            this.archiviaRimuoviPrenotazioneButton.FlatAppearance.BorderSize = 0;
            this.archiviaRimuoviPrenotazioneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.archiviaRimuoviPrenotazioneButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archiviaRimuoviPrenotazioneButton.Location = new System.Drawing.Point(466, 547);
            this.archiviaRimuoviPrenotazioneButton.Name = "archiviaRimuoviPrenotazioneButton";
            this.archiviaRimuoviPrenotazioneButton.Size = new System.Drawing.Size(232, 26);
            this.archiviaRimuoviPrenotazioneButton.TabIndex = 6;
            this.archiviaRimuoviPrenotazioneButton.Text = "Archivia Prenotazione";
            this.archiviaRimuoviPrenotazioneButton.UseVisualStyleBackColor = false;
            this.archiviaRimuoviPrenotazioneButton.Click += new System.EventHandler(this.archiviaRimuoviPrenotazioneButton_Click);
            // 
            // modificaPrenotazioneButton
            // 
            this.modificaPrenotazioneButton.BackColor = System.Drawing.Color.LightGray;
            this.modificaPrenotazioneButton.FlatAppearance.BorderSize = 0;
            this.modificaPrenotazioneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificaPrenotazioneButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificaPrenotazioneButton.Location = new System.Drawing.Point(233, 547);
            this.modificaPrenotazioneButton.Name = "modificaPrenotazioneButton";
            this.modificaPrenotazioneButton.Size = new System.Drawing.Size(232, 26);
            this.modificaPrenotazioneButton.TabIndex = 5;
            this.modificaPrenotazioneButton.Text = "Modifica Prenotazione";
            this.modificaPrenotazioneButton.UseVisualStyleBackColor = false;
            this.modificaPrenotazioneButton.Click += new System.EventHandler(this.modificaPrenotazioneButton_Click);
            // 
            // nuovaPrenotazioneButton
            // 
            this.nuovaPrenotazioneButton.BackColor = System.Drawing.Color.LightGray;
            this.nuovaPrenotazioneButton.FlatAppearance.BorderSize = 0;
            this.nuovaPrenotazioneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuovaPrenotazioneButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuovaPrenotazioneButton.Location = new System.Drawing.Point(0, 547);
            this.nuovaPrenotazioneButton.Name = "nuovaPrenotazioneButton";
            this.nuovaPrenotazioneButton.Size = new System.Drawing.Size(232, 26);
            this.nuovaPrenotazioneButton.TabIndex = 4;
            this.nuovaPrenotazioneButton.Text = "Nuova Prenotazione";
            this.nuovaPrenotazioneButton.UseVisualStyleBackColor = false;
            this.nuovaPrenotazioneButton.Click += new System.EventHandler(this.nuovaPrenotazioneButton_Click);
            // 
            // GestionePrenotazioniPanel
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.prenotazioniFutureTabButton);
            this.Controls.Add(this.prenotazioniConcluseTabButton);
            this.Controls.Add(this.prenotazioniInCorsoTabButton);
            this.Controls.Add(this.prenotazioniDataGridView);
            this.Controls.Add(this.archiviaRimuoviPrenotazioneButton);
            this.Controls.Add(this.modificaPrenotazioneButton);
            this.Controls.Add(this.nuovaPrenotazioneButton);
            this.Name = "GestionePrenotazioniPanel";
            this.Size = new System.Drawing.Size(698, 573);
            this.Load += new System.EventHandler(this.GestionePrenotazioniPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MyButton prenotazioniInCorsoTabButton;
        private Components.MyButton prenotazioniConcluseTabButton;
        private Components.MyButton prenotazioniFutureTabButton;
        private Components.MyButton nuovaPrenotazioneButton;
        private Components.MyButton modificaPrenotazioneButton;
        private Components.MyButton archiviaRimuoviPrenotazioneButton;
        private Components.MyDataGridView prenotazioniDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPrenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInizioPrenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFinePrenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientePrenColumn;
    }
}
