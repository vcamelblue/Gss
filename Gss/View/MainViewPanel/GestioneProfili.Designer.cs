namespace Gss.View.MainViewPanel
{
    partial class GestioneProfili
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
            this.visualizzaProfiloButton = new Gss.View.Components.MyButton(this.components);
            this.rimuoviProfiloButton = new Gss.View.Components.MyButton(this.components);
            this.modificaProfiloButton = new Gss.View.Components.MyButton(this.components);
            this.aggiungiProfiloButton = new Gss.View.Components.MyButton(this.components);
            this.profiliDataGridView = new Gss.View.Components.MyDataGridView(this.components);
            this.profiliColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.profiliDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // visualizzaProfiloButton
            // 
            this.visualizzaProfiloButton.BackColor = System.Drawing.Color.LightGray;
            this.visualizzaProfiloButton.FlatAppearance.BorderSize = 0;
            this.visualizzaProfiloButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualizzaProfiloButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizzaProfiloButton.Location = new System.Drawing.Point(525, 547);
            this.visualizzaProfiloButton.Name = "visualizzaProfiloButton";
            this.visualizzaProfiloButton.Size = new System.Drawing.Size(173, 26);
            this.visualizzaProfiloButton.TabIndex = 26;
            this.visualizzaProfiloButton.Text = "Visualizza Dettagli Profilo";
            this.visualizzaProfiloButton.UseVisualStyleBackColor = false;
            this.visualizzaProfiloButton.Click += new System.EventHandler(this.visualizzaProfiloButton_Click);
            // 
            // rimuoviProfiloButton
            // 
            this.rimuoviProfiloButton.BackColor = System.Drawing.Color.LightGray;
            this.rimuoviProfiloButton.FlatAppearance.BorderSize = 0;
            this.rimuoviProfiloButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rimuoviProfiloButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rimuoviProfiloButton.Location = new System.Drawing.Point(350, 547);
            this.rimuoviProfiloButton.Name = "rimuoviProfiloButton";
            this.rimuoviProfiloButton.Size = new System.Drawing.Size(174, 26);
            this.rimuoviProfiloButton.TabIndex = 25;
            this.rimuoviProfiloButton.Text = "Rimuovi Profilo";
            this.rimuoviProfiloButton.UseVisualStyleBackColor = false;
            this.rimuoviProfiloButton.Click += new System.EventHandler(this.rimuoviProfiloButton_Click);
            // 
            // modificaProfiloButton
            // 
            this.modificaProfiloButton.BackColor = System.Drawing.Color.LightGray;
            this.modificaProfiloButton.FlatAppearance.BorderSize = 0;
            this.modificaProfiloButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificaProfiloButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificaProfiloButton.Location = new System.Drawing.Point(175, 547);
            this.modificaProfiloButton.Name = "modificaProfiloButton";
            this.modificaProfiloButton.Size = new System.Drawing.Size(174, 26);
            this.modificaProfiloButton.TabIndex = 24;
            this.modificaProfiloButton.Text = "Modifica Profilo";
            this.modificaProfiloButton.UseVisualStyleBackColor = false;
            this.modificaProfiloButton.Click += new System.EventHandler(this.modificaProfiloButton_Click);
            // 
            // aggiungiProfiloButton
            // 
            this.aggiungiProfiloButton.BackColor = System.Drawing.Color.LightGray;
            this.aggiungiProfiloButton.FlatAppearance.BorderSize = 0;
            this.aggiungiProfiloButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aggiungiProfiloButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aggiungiProfiloButton.Location = new System.Drawing.Point(0, 547);
            this.aggiungiProfiloButton.Name = "aggiungiProfiloButton";
            this.aggiungiProfiloButton.Size = new System.Drawing.Size(174, 26);
            this.aggiungiProfiloButton.TabIndex = 23;
            this.aggiungiProfiloButton.Text = "Aggiungi Profilo";
            this.aggiungiProfiloButton.UseVisualStyleBackColor = false;
            this.aggiungiProfiloButton.Click += new System.EventHandler(this.aggiungiProfiloButton_Click);
            // 
            // profiliDataGridView
            // 
            this.profiliDataGridView.AllowUserToAddRows = false;
            this.profiliDataGridView.AllowUserToDeleteRows = false;
            this.profiliDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.profiliDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.profiliDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.profiliDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.profiliDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.profiliDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.profiliDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.profiliDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.profiliDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profiliDataGridView.ColumnHeadersVisible = false;
            this.profiliDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profiliColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.profiliDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.profiliDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.profiliDataGridView.Location = new System.Drawing.Point(0, 0);
            this.profiliDataGridView.MultiSelect = false;
            this.profiliDataGridView.Name = "profiliDataGridView";
            this.profiliDataGridView.ReadOnly = true;
            this.profiliDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.profiliDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.profiliDataGridView.RowHeadersVisible = false;
            this.profiliDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profiliDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.profiliDataGridView.RowTemplate.Height = 30;
            this.profiliDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.profiliDataGridView.Size = new System.Drawing.Size(698, 547);
            this.profiliDataGridView.TabIndex = 22;
            // 
            // profiliColumn
            // 
            this.profiliColumn.HeaderText = "Profili";
            this.profiliColumn.Name = "profiliColumn";
            this.profiliColumn.ReadOnly = true;
            // 
            // GestioneProfili
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.visualizzaProfiloButton);
            this.Controls.Add(this.rimuoviProfiloButton);
            this.Controls.Add(this.modificaProfiloButton);
            this.Controls.Add(this.aggiungiProfiloButton);
            this.Controls.Add(this.profiliDataGridView);
            this.Name = "GestioneProfili";
            this.Size = new System.Drawing.Size(698, 573);
            this.Load += new System.EventHandler(this.GestioneProfili_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profiliDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MyDataGridView profiliDataGridView;
        private Components.MyButton aggiungiProfiloButton;
        private Components.MyButton modificaProfiloButton;
        private Components.MyButton rimuoviProfiloButton;
        private Components.MyButton visualizzaProfiloButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn profiliColumn;
    }
}
