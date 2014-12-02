namespace Gss.View {
    partial class AggiungiModificaPeriodi {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.periodiDataGridView = new Gss.View.Components.MyDataGridView(this.components);
            this.profiloColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInizioProfiloColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFineProfiloColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rimuoviPeriodoButton = new Gss.View.Components.MyButton(this.components);
            this.modificaPeriodoButton = new Gss.View.Components.MyButton(this.components);
            this.aggiungiPeriodoButton = new Gss.View.Components.MyButton(this.components);
            this.annullaButton = new Gss.View.Components.MyButton(this.components);
            this.salvaButton = new Gss.View.Components.MyButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.periodiDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // periodiDataGridView
            // 
            this.periodiDataGridView.AllowUserToAddRows = false;
            this.periodiDataGridView.AllowUserToDeleteRows = false;
            this.periodiDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.periodiDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.periodiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.periodiDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.periodiDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.periodiDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.periodiDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.periodiDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.periodiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.periodiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profiloColumn,
            this.dataInizioProfiloColumn,
            this.dataFineProfiloColumn});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.periodiDataGridView.DefaultCellStyle = dataGridViewCellStyle23;
            this.periodiDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.periodiDataGridView.Location = new System.Drawing.Point(17, 18);
            this.periodiDataGridView.MultiSelect = false;
            this.periodiDataGridView.Name = "periodiDataGridView";
            this.periodiDataGridView.ReadOnly = true;
            this.periodiDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.periodiDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.periodiDataGridView.RowHeadersVisible = false;
            this.periodiDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodiDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.periodiDataGridView.RowTemplate.Height = 30;
            this.periodiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.periodiDataGridView.Size = new System.Drawing.Size(698, 339);
            this.periodiDataGridView.TabIndex = 9;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rimuoviPeriodoButton);
            this.groupBox1.Controls.Add(this.modificaPeriodoButton);
            this.groupBox1.Controls.Add(this.aggiungiPeriodoButton);
            this.groupBox1.Location = new System.Drawing.Point(-7, -9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 430);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // rimuoviPeriodoButton
            // 
            this.rimuoviPeriodoButton.BackColor = System.Drawing.Color.LightGray;
            this.rimuoviPeriodoButton.FlatAppearance.BorderSize = 0;
            this.rimuoviPeriodoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rimuoviPeriodoButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rimuoviPeriodoButton.Location = new System.Drawing.Point(490, 385);
            this.rimuoviPeriodoButton.Name = "rimuoviPeriodoButton";
            this.rimuoviPeriodoButton.Size = new System.Drawing.Size(170, 26);
            this.rimuoviPeriodoButton.TabIndex = 11;
            this.rimuoviPeriodoButton.Text = "Rimuovi Periodo";
            this.rimuoviPeriodoButton.UseVisualStyleBackColor = false;
            this.rimuoviPeriodoButton.Click += new System.EventHandler(this.rimuoviPeriodoButton_Click);
            // 
            // modificaPeriodoButton
            // 
            this.modificaPeriodoButton.BackColor = System.Drawing.Color.LightGray;
            this.modificaPeriodoButton.FlatAppearance.BorderSize = 0;
            this.modificaPeriodoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificaPeriodoButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificaPeriodoButton.Location = new System.Drawing.Point(288, 385);
            this.modificaPeriodoButton.Name = "modificaPeriodoButton";
            this.modificaPeriodoButton.Size = new System.Drawing.Size(170, 26);
            this.modificaPeriodoButton.TabIndex = 10;
            this.modificaPeriodoButton.Text = "Modifica Perido";
            this.modificaPeriodoButton.UseVisualStyleBackColor = false;
            this.modificaPeriodoButton.Click += new System.EventHandler(this.modificaPeriodoButton_Click);
            // 
            // aggiungiPeriodoButton
            // 
            this.aggiungiPeriodoButton.BackColor = System.Drawing.Color.LightGray;
            this.aggiungiPeriodoButton.FlatAppearance.BorderSize = 0;
            this.aggiungiPeriodoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aggiungiPeriodoButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aggiungiPeriodoButton.Location = new System.Drawing.Point(86, 385);
            this.aggiungiPeriodoButton.Name = "aggiungiPeriodoButton";
            this.aggiungiPeriodoButton.Size = new System.Drawing.Size(170, 26);
            this.aggiungiPeriodoButton.TabIndex = 9;
            this.aggiungiPeriodoButton.Text = "Aggiungi Periodo";
            this.aggiungiPeriodoButton.UseVisualStyleBackColor = false;
            this.aggiungiPeriodoButton.Click += new System.EventHandler(this.aggiungiPeriodoButton_Click);
            // 
            // annullaButton
            // 
            this.annullaButton.BackColor = System.Drawing.Color.LightGray;
            this.annullaButton.FlatAppearance.BorderSize = 0;
            this.annullaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annullaButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annullaButton.Location = new System.Drawing.Point(28, 454);
            this.annullaButton.Name = "annullaButton";
            this.annullaButton.Size = new System.Drawing.Size(200, 26);
            this.annullaButton.TabIndex = 12;
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
            this.salvaButton.Location = new System.Drawing.Point(504, 454);
            this.salvaButton.Name = "salvaButton";
            this.salvaButton.Size = new System.Drawing.Size(200, 26);
            this.salvaButton.TabIndex = 11;
            this.salvaButton.Text = "Salva";
            this.salvaButton.UseVisualStyleBackColor = false;
            this.salvaButton.Click += new System.EventHandler(this.salvaButton_Click);
            // 
            // AggiungiModificaPeriodi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.Controls.Add(this.annullaButton);
            this.Controls.Add(this.salvaButton);
            this.Controls.Add(this.periodiDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AggiungiModificaPeriodi";
            this.Text = "Nuovi Periodi Stagione";
            this.Load += new System.EventHandler(this.AggiungiModificaPeriodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.periodiDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MyDataGridView periodiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn profiloColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInizioProfiloColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFineProfiloColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private Components.MyButton rimuoviPeriodoButton;
        private Components.MyButton modificaPeriodoButton;
        private Components.MyButton aggiungiPeriodoButton;
        private Components.MyButton annullaButton;
        private Components.MyButton salvaButton;
    }
}