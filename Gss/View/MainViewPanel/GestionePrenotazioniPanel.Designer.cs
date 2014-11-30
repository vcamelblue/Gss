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
            this.prenotazioniInCorsoDataGridView = new Gss.View.Components.MyDataGridView(this.components);
            this.prenInCorsoNumeroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenInCorsoDataInizioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenInCorsoDataFineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenInCorsoClienteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiviaRimuoviPrenotazioneButton = new Gss.View.Components.MyButton(this.components);
            this.modificaPrenotazioneButton = new Gss.View.Components.MyButton(this.components);
            this.nuovaPrenotazioneButton = new Gss.View.Components.MyButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniInCorsoDataGridView)).BeginInit();
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
            // 
            // prenotazioniInCorsoDataGridView
            // 
            this.prenotazioniInCorsoDataGridView.AllowUserToAddRows = false;
            this.prenotazioniInCorsoDataGridView.AllowUserToDeleteRows = false;
            this.prenotazioniInCorsoDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.prenotazioniInCorsoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.prenotazioniInCorsoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prenotazioniInCorsoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.prenotazioniInCorsoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prenotazioniInCorsoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.prenotazioniInCorsoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prenotazioniInCorsoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.prenotazioniInCorsoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prenotazioniInCorsoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prenInCorsoNumeroColumn,
            this.prenInCorsoDataInizioColumn,
            this.prenInCorsoDataFineColumn,
            this.prenInCorsoClienteColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prenotazioniInCorsoDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.prenotazioniInCorsoDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.prenotazioniInCorsoDataGridView.Location = new System.Drawing.Point(0, 26);
            this.prenotazioniInCorsoDataGridView.MultiSelect = false;
            this.prenotazioniInCorsoDataGridView.Name = "prenotazioniInCorsoDataGridView";
            this.prenotazioniInCorsoDataGridView.ReadOnly = true;
            this.prenotazioniInCorsoDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prenotazioniInCorsoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.prenotazioniInCorsoDataGridView.RowHeadersVisible = false;
            this.prenotazioniInCorsoDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenotazioniInCorsoDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.prenotazioniInCorsoDataGridView.RowTemplate.Height = 24;
            this.prenotazioniInCorsoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prenotazioniInCorsoDataGridView.Size = new System.Drawing.Size(698, 520);
            this.prenotazioniInCorsoDataGridView.TabIndex = 7;
            // 
            // prenInCorsoNumeroColumn
            // 
            this.prenInCorsoNumeroColumn.FillWeight = 20F;
            this.prenInCorsoNumeroColumn.HeaderText = "Numero";
            this.prenInCorsoNumeroColumn.Name = "prenInCorsoNumeroColumn";
            this.prenInCorsoNumeroColumn.ReadOnly = true;
            // 
            // prenInCorsoDataInizioColumn
            // 
            this.prenInCorsoDataInizioColumn.FillWeight = 30F;
            this.prenInCorsoDataInizioColumn.HeaderText = "Data Inizio";
            this.prenInCorsoDataInizioColumn.Name = "prenInCorsoDataInizioColumn";
            this.prenInCorsoDataInizioColumn.ReadOnly = true;
            // 
            // prenInCorsoDataFineColumn
            // 
            this.prenInCorsoDataFineColumn.FillWeight = 30F;
            this.prenInCorsoDataFineColumn.HeaderText = "Data Fine";
            this.prenInCorsoDataFineColumn.Name = "prenInCorsoDataFineColumn";
            this.prenInCorsoDataFineColumn.ReadOnly = true;
            // 
            // prenInCorsoClienteColumn
            // 
            this.prenInCorsoClienteColumn.FillWeight = 45F;
            this.prenInCorsoClienteColumn.HeaderText = "Cliente";
            this.prenInCorsoClienteColumn.Name = "prenInCorsoClienteColumn";
            this.prenInCorsoClienteColumn.ReadOnly = true;
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
            // 
            // PrenotazioniPanel
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.prenotazioniFutureTabButton);
            this.Controls.Add(this.prenotazioniConcluseTabButton);
            this.Controls.Add(this.prenotazioniInCorsoTabButton);
            this.Controls.Add(this.prenotazioniInCorsoDataGridView);
            this.Controls.Add(this.archiviaRimuoviPrenotazioneButton);
            this.Controls.Add(this.modificaPrenotazioneButton);
            this.Controls.Add(this.nuovaPrenotazioneButton);
            this.Name = "PrenotazioniPanel";
            this.Size = new System.Drawing.Size(698, 573);
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniInCorsoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MyButton prenotazioniInCorsoTabButton;
        private Components.MyButton prenotazioniConcluseTabButton;
        private Components.MyButton prenotazioniFutureTabButton;
        private Components.MyButton nuovaPrenotazioneButton;
        private Components.MyButton modificaPrenotazioneButton;
        private Components.MyButton archiviaRimuoviPrenotazioneButton;
        private Components.MyDataGridView prenotazioniInCorsoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenInCorsoNumeroColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenInCorsoDataInizioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenInCorsoDataFineColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenInCorsoClienteColumn;
    }
}
