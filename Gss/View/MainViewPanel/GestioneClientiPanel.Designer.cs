namespace Gss.View.MainViewPanel
{
    partial class GestioneClientiPanel
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
            this.clientiDataGridView = new Gss.View.Components.MyDataGridView(this.components);
            this.prenInCorsoNumeroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenInCorsoDataInizioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenInCorsoDataFineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenInCorsoClienteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientiDataGridView
            // 
            this.clientiDataGridView.AllowUserToAddRows = false;
            this.clientiDataGridView.AllowUserToDeleteRows = false;
            this.clientiDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.clientiDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.clientiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientiDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.clientiDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientiDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.clientiDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientiDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.clientiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.clientiDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.clientiDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.clientiDataGridView.Location = new System.Drawing.Point(0, -1);
            this.clientiDataGridView.MultiSelect = false;
            this.clientiDataGridView.Name = "clientiDataGridView";
            this.clientiDataGridView.ReadOnly = true;
            this.clientiDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientiDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.clientiDataGridView.RowHeadersVisible = false;
            this.clientiDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientiDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.clientiDataGridView.RowTemplate.Height = 24;
            this.clientiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientiDataGridView.Size = new System.Drawing.Size(698, 520);
            this.clientiDataGridView.TabIndex = 8;
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
            // GestioneClientiPanel
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.clientiDataGridView);
            this.Name = "GestioneClientiPanel";
            this.Size = new System.Drawing.Size(698, 573);
            ((System.ComponentModel.ISupportInitialize)(this.clientiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MyDataGridView clientiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenInCorsoNumeroColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenInCorsoDataInizioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenInCorsoDataFineColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenInCorsoClienteColumn;
    }
}
