namespace Gss.View {
    partial class AggiungiModificaSkicard {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.skipassTotaliLabel = new Gss.View.Components.MyLabel(this.components);
            this.skipassDataGridView = new Gss.View.Components.MyDataGridView(this.components);
            this.codiceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impiantoAssociatoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipologiaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annullaButton = new Gss.View.Components.MyButton(this.components);
            this.salvaButton = new Gss.View.Components.MyButton(this.components);
            this.rimuoviSkipssButton = new Gss.View.Components.MyButton(this.components);
            this.modificaSkipassButton = new Gss.View.Components.MyButton(this.components);
            this.aggiungiSkipassButton = new Gss.View.Components.MyButton(this.components);
            this.codiceTextBox = new Gss.View.Components.MyTextBox(this.components);
            this.myLabel2 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel1 = new Gss.View.Components.MyLabel(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skipassDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.skipassTotaliLabel);
            this.groupBox1.Location = new System.Drawing.Point(-1, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 361);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // skipassTotaliLabel
            // 
            this.skipassTotaliLabel.AutoSize = true;
            this.skipassTotaliLabel.BackColor = System.Drawing.Color.Transparent;
            this.skipassTotaliLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipassTotaliLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.skipassTotaliLabel.Location = new System.Drawing.Point(602, 231);
            this.skipassTotaliLabel.Name = "skipassTotaliLabel";
            this.skipassTotaliLabel.Size = new System.Drawing.Size(79, 17);
            this.skipassTotaliLabel.TabIndex = 4;
            this.skipassTotaliLabel.Text = "Pass Totali  5";
            // 
            // skipassDataGridView
            // 
            this.skipassDataGridView.AllowUserToAddRows = false;
            this.skipassDataGridView.AllowUserToDeleteRows = false;
            this.skipassDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.skipassDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.skipassDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.skipassDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.skipassDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skipassDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.skipassDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skipassDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.skipassDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skipassDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codiceColumn,
            this.impiantoAssociatoColumn,
            this.tipologiaColumn,
            this.infoColumn});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skipassDataGridView.DefaultCellStyle = dataGridViewCellStyle23;
            this.skipassDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.skipassDataGridView.Location = new System.Drawing.Point(12, 104);
            this.skipassDataGridView.MultiSelect = false;
            this.skipassDataGridView.Name = "skipassDataGridView";
            this.skipassDataGridView.ReadOnly = true;
            this.skipassDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skipassDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.skipassDataGridView.RowHeadersVisible = false;
            this.skipassDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipassDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.skipassDataGridView.RowTemplate.Height = 24;
            this.skipassDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skipassDataGridView.Size = new System.Drawing.Size(708, 184);
            this.skipassDataGridView.TabIndex = 3;
            // 
            // codiceColumn
            // 
            this.codiceColumn.FillWeight = 10F;
            this.codiceColumn.HeaderText = "Codice";
            this.codiceColumn.Name = "codiceColumn";
            this.codiceColumn.ReadOnly = true;
            // 
            // impiantoAssociatoColumn
            // 
            this.impiantoAssociatoColumn.FillWeight = 20F;
            this.impiantoAssociatoColumn.HeaderText = "Impianto Associato";
            this.impiantoAssociatoColumn.Name = "impiantoAssociatoColumn";
            this.impiantoAssociatoColumn.ReadOnly = true;
            // 
            // tipologiaColumn
            // 
            this.tipologiaColumn.FillWeight = 20F;
            this.tipologiaColumn.HeaderText = "Tipologia";
            this.tipologiaColumn.Name = "tipologiaColumn";
            this.tipologiaColumn.ReadOnly = true;
            // 
            // infoColumn
            // 
            this.infoColumn.FillWeight = 40F;
            this.infoColumn.HeaderText = "Info";
            this.infoColumn.Name = "infoColumn";
            this.infoColumn.ReadOnly = true;
            // 
            // annullaButton
            // 
            this.annullaButton.BackColor = System.Drawing.Color.LightGray;
            this.annullaButton.FlatAppearance.BorderSize = 0;
            this.annullaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annullaButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annullaButton.Location = new System.Drawing.Point(27, 454);
            this.annullaButton.Name = "annullaButton";
            this.annullaButton.Size = new System.Drawing.Size(200, 26);
            this.annullaButton.TabIndex = 10;
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
            this.salvaButton.Location = new System.Drawing.Point(503, 454);
            this.salvaButton.Name = "salvaButton";
            this.salvaButton.Size = new System.Drawing.Size(200, 26);
            this.salvaButton.TabIndex = 9;
            this.salvaButton.Text = "Salva";
            this.salvaButton.UseVisualStyleBackColor = false;
            this.salvaButton.Click += new System.EventHandler(this.salvaButton_Click);
            // 
            // rimuoviSkipssButton
            // 
            this.rimuoviSkipssButton.BackColor = System.Drawing.Color.LightGray;
            this.rimuoviSkipssButton.FlatAppearance.BorderSize = 0;
            this.rimuoviSkipssButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rimuoviSkipssButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rimuoviSkipssButton.Location = new System.Drawing.Point(483, 358);
            this.rimuoviSkipssButton.Name = "rimuoviSkipssButton";
            this.rimuoviSkipssButton.Size = new System.Drawing.Size(170, 26);
            this.rimuoviSkipssButton.TabIndex = 8;
            this.rimuoviSkipssButton.Text = "Rimuovi Skipass";
            this.rimuoviSkipssButton.UseVisualStyleBackColor = false;
            this.rimuoviSkipssButton.Click += new System.EventHandler(this.rimuoviSkipssButton_Click);
            // 
            // modificaSkipassButton
            // 
            this.modificaSkipassButton.BackColor = System.Drawing.Color.LightGray;
            this.modificaSkipassButton.FlatAppearance.BorderSize = 0;
            this.modificaSkipassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificaSkipassButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificaSkipassButton.Location = new System.Drawing.Point(281, 358);
            this.modificaSkipassButton.Name = "modificaSkipassButton";
            this.modificaSkipassButton.Size = new System.Drawing.Size(170, 26);
            this.modificaSkipassButton.TabIndex = 7;
            this.modificaSkipassButton.Text = "Modifica Skipass";
            this.modificaSkipassButton.UseVisualStyleBackColor = false;
            this.modificaSkipassButton.Click += new System.EventHandler(this.modificaSkipassButton_Click);
            // 
            // aggiungiSkipassButton
            // 
            this.aggiungiSkipassButton.BackColor = System.Drawing.Color.LightGray;
            this.aggiungiSkipassButton.FlatAppearance.BorderSize = 0;
            this.aggiungiSkipassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aggiungiSkipassButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aggiungiSkipassButton.Location = new System.Drawing.Point(79, 358);
            this.aggiungiSkipassButton.Name = "aggiungiSkipassButton";
            this.aggiungiSkipassButton.Size = new System.Drawing.Size(170, 26);
            this.aggiungiSkipassButton.TabIndex = 6;
            this.aggiungiSkipassButton.Text = "Aggiungi Skipass";
            this.aggiungiSkipassButton.UseVisualStyleBackColor = false;
            this.aggiungiSkipassButton.Click += new System.EventHandler(this.aggiungiSkipassButton_Click);
            // 
            // codiceTextBox
            // 
            this.codiceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.codiceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codiceTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codiceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.codiceTextBox.Location = new System.Drawing.Point(258, 23);
            this.codiceTextBox.Name = "codiceTextBox";
            this.codiceTextBox.Size = new System.Drawing.Size(445, 17);
            this.codiceTextBox.TabIndex = 2;
            this.codiceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.myLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel2.Location = new System.Drawing.Point(23, 78);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(55, 19);
            this.myLabel2.TabIndex = 1;
            this.myLabel2.Text = "Skipass";
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.BackColor = System.Drawing.Color.Transparent;
            this.myLabel1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel1.Location = new System.Drawing.Point(23, 23);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(89, 17);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "Codice SkiCard";
            // 
            // AggiungiModificaSkicard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.Controls.Add(this.skipassDataGridView);
            this.Controls.Add(this.annullaButton);
            this.Controls.Add(this.salvaButton);
            this.Controls.Add(this.rimuoviSkipssButton);
            this.Controls.Add(this.modificaSkipassButton);
            this.Controls.Add(this.aggiungiSkipassButton);
            this.Controls.Add(this.codiceTextBox);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.myLabel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AggiungiModificaSkicard";
            this.Text = "Aggiungi SkiCard";
            this.Load += new System.EventHandler(this.AggiungiModificaSkicard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skipassDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.MyLabel myLabel2;
        private Components.MyTextBox codiceTextBox;
        private Components.MyDataGridView skipassDataGridView;
        private Components.MyLabel skipassTotaliLabel;
        private Components.MyLabel myLabel1;
        private Components.MyButton aggiungiSkipassButton;
        private Components.MyButton modificaSkipassButton;
        private Components.MyButton rimuoviSkipssButton;
        private Components.MyButton salvaButton;
        private Components.MyButton annullaButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn impiantoAssociatoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipologiaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoColumn;
    }
}