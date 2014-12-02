namespace Gss.View.MainViewPanel
{
    partial class GestionePeriodiPanel
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
            this.rimuoviTuttiIPeriodiButton = new Gss.View.Components.MyButton(this.components);
            this.modificaPeriodiButton = new Gss.View.Components.MyButton(this.components);
            this.impostaPeriodiButton = new Gss.View.Components.MyButton(this.components);
            this.periodiDataGridView = new Gss.View.Components.MyDataGridView(this.components);
            this.profiloColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInizioProfiloColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFineProfiloColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.periodiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rimuoviTuttiIPeriodiButton
            // 
            this.rimuoviTuttiIPeriodiButton.BackColor = System.Drawing.Color.LightGray;
            this.rimuoviTuttiIPeriodiButton.FlatAppearance.BorderSize = 0;
            this.rimuoviTuttiIPeriodiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rimuoviTuttiIPeriodiButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rimuoviTuttiIPeriodiButton.Location = new System.Drawing.Point(466, 546);
            this.rimuoviTuttiIPeriodiButton.Name = "rimuoviTuttiIPeriodiButton";
            this.rimuoviTuttiIPeriodiButton.Size = new System.Drawing.Size(232, 26);
            this.rimuoviTuttiIPeriodiButton.TabIndex = 11;
            this.rimuoviTuttiIPeriodiButton.Text = "Rimuovi Periodi Esistenti";
            this.rimuoviTuttiIPeriodiButton.UseVisualStyleBackColor = false;
            this.rimuoviTuttiIPeriodiButton.Click += new System.EventHandler(this.rimuoviTuttiIPeriodiButton_Click);
            // 
            // modificaPeriodiButton
            // 
            this.modificaPeriodiButton.BackColor = System.Drawing.Color.LightGray;
            this.modificaPeriodiButton.FlatAppearance.BorderSize = 0;
            this.modificaPeriodiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificaPeriodiButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificaPeriodiButton.Location = new System.Drawing.Point(233, 546);
            this.modificaPeriodiButton.Name = "modificaPeriodiButton";
            this.modificaPeriodiButton.Size = new System.Drawing.Size(232, 26);
            this.modificaPeriodiButton.TabIndex = 10;
            this.modificaPeriodiButton.Text = "Modifica Periodi Esistenti";
            this.modificaPeriodiButton.UseVisualStyleBackColor = false;
            this.modificaPeriodiButton.Click += new System.EventHandler(this.modificaPeriodiButton_Click);
            // 
            // impostaPeriodiButton
            // 
            this.impostaPeriodiButton.BackColor = System.Drawing.Color.LightGray;
            this.impostaPeriodiButton.FlatAppearance.BorderSize = 0;
            this.impostaPeriodiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.impostaPeriodiButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impostaPeriodiButton.Location = new System.Drawing.Point(0, 546);
            this.impostaPeriodiButton.Name = "impostaPeriodiButton";
            this.impostaPeriodiButton.Size = new System.Drawing.Size(232, 26);
            this.impostaPeriodiButton.TabIndex = 9;
            this.impostaPeriodiButton.Text = "Imposta Nuovi Periodi";
            this.impostaPeriodiButton.UseVisualStyleBackColor = false;
            this.impostaPeriodiButton.Click += new System.EventHandler(this.impostaPeriodiButton_Click);
            // 
            // periodiDataGridView
            // 
            this.periodiDataGridView.AllowUserToAddRows = false;
            this.periodiDataGridView.AllowUserToDeleteRows = false;
            this.periodiDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.periodiDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.periodiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.periodiDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.periodiDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.periodiDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.periodiDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.periodiDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.periodiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.periodiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profiloColumn,
            this.dataInizioProfiloColumn,
            this.dataFineProfiloColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.periodiDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.periodiDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.periodiDataGridView.Location = new System.Drawing.Point(0, -1);
            this.periodiDataGridView.MultiSelect = false;
            this.periodiDataGridView.Name = "periodiDataGridView";
            this.periodiDataGridView.ReadOnly = true;
            this.periodiDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.periodiDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.periodiDataGridView.RowHeadersVisible = false;
            this.periodiDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodiDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.periodiDataGridView.RowTemplate.Height = 30;
            this.periodiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.periodiDataGridView.Size = new System.Drawing.Size(698, 547);
            this.periodiDataGridView.TabIndex = 8;
            // 
            // profiloColumn
            // 
            this.profiloColumn.FillWeight = 30F;
            this.profiloColumn.HeaderText = "Profilo";
            this.profiloColumn.Name = "profiloColumn";
            this.profiloColumn.ReadOnly = true;
            // 
            // dataInizioProfiloColumn
            // 
            this.dataInizioProfiloColumn.FillWeight = 30F;
            this.dataInizioProfiloColumn.HeaderText = "Data Inizio";
            this.dataInizioProfiloColumn.Name = "dataInizioProfiloColumn";
            this.dataInizioProfiloColumn.ReadOnly = true;
            // 
            // dataFineProfiloColumn
            // 
            this.dataFineProfiloColumn.FillWeight = 30F;
            this.dataFineProfiloColumn.HeaderText = "Data Fine";
            this.dataFineProfiloColumn.Name = "dataFineProfiloColumn";
            this.dataFineProfiloColumn.ReadOnly = true;
            // 
            // GestionePeriodiPanel
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.rimuoviTuttiIPeriodiButton);
            this.Controls.Add(this.modificaPeriodiButton);
            this.Controls.Add(this.impostaPeriodiButton);
            this.Controls.Add(this.periodiDataGridView);
            this.Name = "GestionePeriodiPanel";
            this.Size = new System.Drawing.Size(698, 573);
            ((System.ComponentModel.ISupportInitialize)(this.periodiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MyDataGridView periodiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn profiloColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInizioProfiloColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFineProfiloColumn;
        private Components.MyButton impostaPeriodiButton;
        private Components.MyButton modificaPeriodiButton;
        private Components.MyButton rimuoviTuttiIPeriodiButton;
    }
}
