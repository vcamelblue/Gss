﻿namespace Gss.View.MainViewPanel
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
            this.visualizzaClienteButton = new Gss.View.Components.MyButton(this.components);
            this.rimuoviClienteButton = new Gss.View.Components.MyButton(this.components);
            this.modificaClienteButton = new Gss.View.Components.MyButton(this.components);
            this.aggiungiClienteButton = new Gss.View.Components.MyButton(this.components);
            this.clientiDataGridView = new Gss.View.Components.MyDataGridView(this.components);
            this.nomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdiceFiscaleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // visualizzaClienteButton
            // 
            this.visualizzaClienteButton.BackColor = System.Drawing.Color.LightGray;
            this.visualizzaClienteButton.FlatAppearance.BorderSize = 0;
            this.visualizzaClienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualizzaClienteButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizzaClienteButton.Location = new System.Drawing.Point(525, 547);
            this.visualizzaClienteButton.Name = "visualizzaClienteButton";
            this.visualizzaClienteButton.Size = new System.Drawing.Size(173, 26);
            this.visualizzaClienteButton.TabIndex = 12;
            this.visualizzaClienteButton.Text = "Visualizza Cliente";
            this.visualizzaClienteButton.UseVisualStyleBackColor = false;
            this.visualizzaClienteButton.Click += new System.EventHandler(this.visualizzaClienteButton_Click);
            // 
            // rimuoviClienteButton
            // 
            this.rimuoviClienteButton.BackColor = System.Drawing.Color.LightGray;
            this.rimuoviClienteButton.FlatAppearance.BorderSize = 0;
            this.rimuoviClienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rimuoviClienteButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rimuoviClienteButton.Location = new System.Drawing.Point(350, 547);
            this.rimuoviClienteButton.Name = "rimuoviClienteButton";
            this.rimuoviClienteButton.Size = new System.Drawing.Size(174, 26);
            this.rimuoviClienteButton.TabIndex = 11;
            this.rimuoviClienteButton.Text = "Rimuovi Cliente";
            this.rimuoviClienteButton.UseVisualStyleBackColor = false;
            this.rimuoviClienteButton.Click += new System.EventHandler(this.rimuoviClienteButton_Click);
            // 
            // modificaClienteButton
            // 
            this.modificaClienteButton.BackColor = System.Drawing.Color.LightGray;
            this.modificaClienteButton.FlatAppearance.BorderSize = 0;
            this.modificaClienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificaClienteButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificaClienteButton.Location = new System.Drawing.Point(175, 547);
            this.modificaClienteButton.Name = "modificaClienteButton";
            this.modificaClienteButton.Size = new System.Drawing.Size(174, 26);
            this.modificaClienteButton.TabIndex = 10;
            this.modificaClienteButton.Text = "Modifica Cliente";
            this.modificaClienteButton.UseVisualStyleBackColor = false;
            this.modificaClienteButton.Click += new System.EventHandler(this.modificaClienteButton_Click);
            // 
            // aggiungiClienteButton
            // 
            this.aggiungiClienteButton.BackColor = System.Drawing.Color.LightGray;
            this.aggiungiClienteButton.FlatAppearance.BorderSize = 0;
            this.aggiungiClienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aggiungiClienteButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aggiungiClienteButton.Location = new System.Drawing.Point(0, 547);
            this.aggiungiClienteButton.Name = "aggiungiClienteButton";
            this.aggiungiClienteButton.Size = new System.Drawing.Size(174, 26);
            this.aggiungiClienteButton.TabIndex = 9;
            this.aggiungiClienteButton.Text = "Aggiungi Cliente";
            this.aggiungiClienteButton.UseVisualStyleBackColor = false;
            this.aggiungiClienteButton.Click += new System.EventHandler(this.aggiungiClienteButton_Click);
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
            this.nomeColumn,
            this.cognomeColumn,
            this.cdiceFiscaleColumn,
            this.telefonoColumn,
            this.emailColumn});
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
            this.clientiDataGridView.RowTemplate.Height = 30;
            this.clientiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientiDataGridView.Size = new System.Drawing.Size(698, 549);
            this.clientiDataGridView.TabIndex = 8;
            // 
            // nomeColumn
            // 
            this.nomeColumn.HeaderText = "Nome";
            this.nomeColumn.Name = "nomeColumn";
            this.nomeColumn.ReadOnly = true;
            // 
            // cognomeColumn
            // 
            this.cognomeColumn.HeaderText = "Cognome";
            this.cognomeColumn.Name = "cognomeColumn";
            this.cognomeColumn.ReadOnly = true;
            // 
            // cdiceFiscaleColumn
            // 
            this.cdiceFiscaleColumn.FillWeight = 120F;
            this.cdiceFiscaleColumn.HeaderText = "Codice Fiscale";
            this.cdiceFiscaleColumn.Name = "cdiceFiscaleColumn";
            this.cdiceFiscaleColumn.ReadOnly = true;
            // 
            // telefonoColumn
            // 
            this.telefonoColumn.HeaderText = "Telefono";
            this.telefonoColumn.Name = "telefonoColumn";
            this.telefonoColumn.ReadOnly = true;
            // 
            // emailColumn
            // 
            this.emailColumn.HeaderText = "E-mail";
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.ReadOnly = true;
            // 
            // GestioneClientiPanel
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.visualizzaClienteButton);
            this.Controls.Add(this.rimuoviClienteButton);
            this.Controls.Add(this.modificaClienteButton);
            this.Controls.Add(this.aggiungiClienteButton);
            this.Controls.Add(this.clientiDataGridView);
            this.Name = "GestioneClientiPanel";
            this.Size = new System.Drawing.Size(698, 573);
            this.Load += new System.EventHandler(this.GestioneClientiPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MyDataGridView clientiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdiceFiscaleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColumn;
        private Components.MyButton aggiungiClienteButton;
        private Components.MyButton modificaClienteButton;
        private Components.MyButton rimuoviClienteButton;
        private Components.MyButton visualizzaClienteButton;
    }
}
