namespace Gss.View {
    partial class GestioneImpianti {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.visualizzaImpiantoButton = new Gss.View.Components.MyButton(this.components);
            this.rimuoviImpiantoButton = new Gss.View.Components.MyButton(this.components);
            this.modificaImpiantoButton = new Gss.View.Components.MyButton(this.components);
            this.AggiungiImpiantoButton = new Gss.View.Components.MyButton(this.components);
            this.impiantiDataGridView = new Gss.View.Components.MyDataGridView(this.components);
            this.codiceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versanteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPisteAlpineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPisteDiFodnoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPisteSnowparkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.impiantiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // visualizzaImpiantoButton
            // 
            this.visualizzaImpiantoButton.BackColor = System.Drawing.Color.LightGray;
            this.visualizzaImpiantoButton.FlatAppearance.BorderSize = 0;
            this.visualizzaImpiantoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualizzaImpiantoButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizzaImpiantoButton.Location = new System.Drawing.Point(512, 526);
            this.visualizzaImpiantoButton.Name = "visualizzaImpiantoButton";
            this.visualizzaImpiantoButton.Size = new System.Drawing.Size(169, 26);
            this.visualizzaImpiantoButton.TabIndex = 5;
            this.visualizzaImpiantoButton.Text = "Visualizza Impianto";
            this.visualizzaImpiantoButton.UseVisualStyleBackColor = false;
            this.visualizzaImpiantoButton.Click += new System.EventHandler(this.visualizzaImpiantoButton_Click);
            // 
            // rimuoviImpiantoButton
            // 
            this.rimuoviImpiantoButton.BackColor = System.Drawing.Color.LightGray;
            this.rimuoviImpiantoButton.FlatAppearance.BorderSize = 0;
            this.rimuoviImpiantoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rimuoviImpiantoButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rimuoviImpiantoButton.Location = new System.Drawing.Point(342, 526);
            this.rimuoviImpiantoButton.Name = "rimuoviImpiantoButton";
            this.rimuoviImpiantoButton.Size = new System.Drawing.Size(169, 26);
            this.rimuoviImpiantoButton.TabIndex = 4;
            this.rimuoviImpiantoButton.Text = "Rimuovi Impianto";
            this.rimuoviImpiantoButton.UseVisualStyleBackColor = false;
            this.rimuoviImpiantoButton.Click += new System.EventHandler(this.rimuoviImpiantoButton_Click);
            // 
            // modificaImpiantoButton
            // 
            this.modificaImpiantoButton.BackColor = System.Drawing.Color.LightGray;
            this.modificaImpiantoButton.FlatAppearance.BorderSize = 0;
            this.modificaImpiantoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificaImpiantoButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificaImpiantoButton.Location = new System.Drawing.Point(172, 526);
            this.modificaImpiantoButton.Name = "modificaImpiantoButton";
            this.modificaImpiantoButton.Size = new System.Drawing.Size(169, 26);
            this.modificaImpiantoButton.TabIndex = 3;
            this.modificaImpiantoButton.Text = "Modifica Impianto";
            this.modificaImpiantoButton.UseVisualStyleBackColor = false;
            this.modificaImpiantoButton.Click += new System.EventHandler(this.modificaImpiantoButton_Click);
            // 
            // AggiungiImpiantoButton
            // 
            this.AggiungiImpiantoButton.BackColor = System.Drawing.Color.LightGray;
            this.AggiungiImpiantoButton.FlatAppearance.BorderSize = 0;
            this.AggiungiImpiantoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AggiungiImpiantoButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AggiungiImpiantoButton.Location = new System.Drawing.Point(1, 526);
            this.AggiungiImpiantoButton.Name = "AggiungiImpiantoButton";
            this.AggiungiImpiantoButton.Size = new System.Drawing.Size(170, 26);
            this.AggiungiImpiantoButton.TabIndex = 2;
            this.AggiungiImpiantoButton.Text = "Aggiungi Impianto";
            this.AggiungiImpiantoButton.UseVisualStyleBackColor = false;
            this.AggiungiImpiantoButton.Click += new System.EventHandler(this.AggiungiImpiantoButton_Click);
            // 
            // impiantiDataGridView
            // 
            this.impiantiDataGridView.AllowUserToAddRows = false;
            this.impiantiDataGridView.AllowUserToDeleteRows = false;
            this.impiantiDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.impiantiDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.impiantiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.impiantiDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.impiantiDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.impiantiDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.impiantiDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.impiantiDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.impiantiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.impiantiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codiceColumn,
            this.nomeColumn,
            this.versanteColumn,
            this.numPisteAlpineColumn,
            this.numPisteDiFodnoColumn,
            this.numPisteSnowparkColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.impiantiDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.impiantiDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.impiantiDataGridView.Location = new System.Drawing.Point(-1, -1);
            this.impiantiDataGridView.MultiSelect = false;
            this.impiantiDataGridView.Name = "impiantiDataGridView";
            this.impiantiDataGridView.ReadOnly = true;
            this.impiantiDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.impiantiDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.impiantiDataGridView.RowHeadersVisible = false;
            this.impiantiDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impiantiDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.impiantiDataGridView.RowTemplate.Height = 24;
            this.impiantiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.impiantiDataGridView.Size = new System.Drawing.Size(683, 526);
            this.impiantiDataGridView.TabIndex = 1;
            // 
            // codiceColumn
            // 
            this.codiceColumn.FillWeight = 70F;
            this.codiceColumn.HeaderText = "Codice";
            this.codiceColumn.Name = "codiceColumn";
            this.codiceColumn.ReadOnly = true;
            // 
            // nomeColumn
            // 
            this.nomeColumn.FillWeight = 120F;
            this.nomeColumn.HeaderText = "Nome";
            this.nomeColumn.Name = "nomeColumn";
            this.nomeColumn.ReadOnly = true;
            // 
            // versanteColumn
            // 
            this.versanteColumn.FillWeight = 120F;
            this.versanteColumn.HeaderText = "Versante";
            this.versanteColumn.Name = "versanteColumn";
            this.versanteColumn.ReadOnly = true;
            // 
            // numPisteAlpineColumn
            // 
            this.numPisteAlpineColumn.FillWeight = 80F;
            this.numPisteAlpineColumn.HeaderText = "Piste Alpine";
            this.numPisteAlpineColumn.Name = "numPisteAlpineColumn";
            this.numPisteAlpineColumn.ReadOnly = true;
            // 
            // numPisteDiFodnoColumn
            // 
            this.numPisteDiFodnoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.numPisteDiFodnoColumn.FillWeight = 70F;
            this.numPisteDiFodnoColumn.HeaderText = "Piste Di Fondo";
            this.numPisteDiFodnoColumn.Name = "numPisteDiFodnoColumn";
            this.numPisteDiFodnoColumn.ReadOnly = true;
            this.numPisteDiFodnoColumn.Width = 99;
            // 
            // numPisteSnowparkColumn
            // 
            this.numPisteSnowparkColumn.HeaderText = "Piste SnowPark";
            this.numPisteSnowparkColumn.Name = "numPisteSnowparkColumn";
            this.numPisteSnowparkColumn.ReadOnly = true;
            // 
            // GestioneImpianti
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.visualizzaImpiantoButton);
            this.Controls.Add(this.rimuoviImpiantoButton);
            this.Controls.Add(this.modificaImpiantoButton);
            this.Controls.Add(this.AggiungiImpiantoButton);
            this.Controls.Add(this.impiantiDataGridView);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GestioneImpianti";
            this.Text = "Gestione Impianti";
            this.Load += new System.EventHandler(this.GestioneImpianti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.impiantiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MyDataGridView impiantiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versanteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPisteAlpineColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPisteDiFodnoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPisteSnowparkColumn;
        private Components.MyButton AggiungiImpiantoButton;
        private Components.MyButton modificaImpiantoButton;
        private Components.MyButton rimuoviImpiantoButton;
        private Components.MyButton visualizzaImpiantoButton;
    }
}