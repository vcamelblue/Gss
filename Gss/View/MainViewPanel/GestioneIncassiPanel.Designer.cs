namespace Gss.View.MainViewPanel
{
    partial class GestioneIncassiPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.visualizzaFatturaButton = new Gss.View.Components.MyButton(this.components);
            this.incassiDataGridView = new Gss.View.Components.MyDataGridView(this.components);
            this.numeroPrenotazioneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFatturaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incassoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.incassiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // visualizzaFatturaButton
            // 
            this.visualizzaFatturaButton.BackColor = System.Drawing.Color.LightGray;
            this.visualizzaFatturaButton.FlatAppearance.BorderSize = 0;
            this.visualizzaFatturaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualizzaFatturaButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizzaFatturaButton.Location = new System.Drawing.Point(0, 547);
            this.visualizzaFatturaButton.Name = "visualizzaFatturaButton";
            this.visualizzaFatturaButton.Size = new System.Drawing.Size(698, 26);
            this.visualizzaFatturaButton.TabIndex = 9;
            this.visualizzaFatturaButton.Text = "Visualizza Fattura";
            this.visualizzaFatturaButton.UseVisualStyleBackColor = false;
            this.visualizzaFatturaButton.Click += new System.EventHandler(this.visualizzaFatturaButton_Click);
            // 
            // incassiDataGridView
            // 
            this.incassiDataGridView.AllowUserToAddRows = false;
            this.incassiDataGridView.AllowUserToDeleteRows = false;
            this.incassiDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.incassiDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.incassiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.incassiDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.incassiDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.incassiDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.incassiDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.incassiDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.incassiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incassiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroPrenotazioneColumn,
            this.dataFatturaColumn,
            this.clienteColumn,
            this.incassoColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.incassiDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.incassiDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.incassiDataGridView.Location = new System.Drawing.Point(0, 0);
            this.incassiDataGridView.MultiSelect = false;
            this.incassiDataGridView.Name = "incassiDataGridView";
            this.incassiDataGridView.ReadOnly = true;
            this.incassiDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.incassiDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.incassiDataGridView.RowHeadersVisible = false;
            this.incassiDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incassiDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.incassiDataGridView.RowTemplate.Height = 30;
            this.incassiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.incassiDataGridView.Size = new System.Drawing.Size(698, 549);
            this.incassiDataGridView.TabIndex = 8;
            // 
            // numeroPrenotazioneColumn
            // 
            this.numeroPrenotazioneColumn.FillWeight = 30F;
            this.numeroPrenotazioneColumn.HeaderText = "N. Fattura";
            this.numeroPrenotazioneColumn.Name = "numeroPrenotazioneColumn";
            this.numeroPrenotazioneColumn.ReadOnly = true;
            // 
            // dataFatturaColumn
            // 
            this.dataFatturaColumn.FillWeight = 30F;
            this.dataFatturaColumn.HeaderText = "Data Fattura";
            this.dataFatturaColumn.Name = "dataFatturaColumn";
            this.dataFatturaColumn.ReadOnly = true;
            // 
            // clienteColumn
            // 
            this.clienteColumn.FillWeight = 45F;
            this.clienteColumn.HeaderText = "Cliente";
            this.clienteColumn.Name = "clienteColumn";
            this.clienteColumn.ReadOnly = true;
            // 
            // incassoColumn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.incassoColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.incassoColumn.FillWeight = 20F;
            this.incassoColumn.HeaderText = "Incasso";
            this.incassoColumn.Name = "incassoColumn";
            this.incassoColumn.ReadOnly = true;
            // 
            // GestioneIncassiPanel
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.visualizzaFatturaButton);
            this.Controls.Add(this.incassiDataGridView);
            this.Name = "GestioneIncassiPanel";
            this.Size = new System.Drawing.Size(698, 573);
            this.Load += new System.EventHandler(this.GestioneIncassiPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incassiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MyDataGridView incassiDataGridView;
        private Components.MyButton visualizzaFatturaButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPrenotazioneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFatturaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incassoColumn;
    }
}
