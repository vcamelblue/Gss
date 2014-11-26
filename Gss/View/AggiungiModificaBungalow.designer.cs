namespace Gss.View {
    partial class AggiungiModificaBungalow {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stanzeDataGridView = new Gss.View.Components.MyDataGridView(this.components);
            this.infoStanzaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postiStandardColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postiMaxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annullaButton = new Gss.View.Components.MyButton(this.components);
            this.salvaButton = new Gss.View.Components.MyButton(this.components);
            this.rimuoviStanzaButton = new Gss.View.Components.MyButton(this.components);
            this.modificaStanzaButton = new Gss.View.Components.MyButton(this.components);
            this.aggiungiStanzaButton = new Gss.View.Components.MyButton(this.components);
            this.postiMaxTotaliLabel = new Gss.View.Components.MyLabel(this.components);
            this.postiTotoaliLabel = new Gss.View.Components.MyLabel(this.components);
            this.codiceTextBox1 = new Gss.View.Components.MyTextBox(this.components);
            this.myLabel2 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel1 = new Gss.View.Components.MyLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stanzeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-1, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 361);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // stanzeDataGridView
            // 
            this.stanzeDataGridView.AllowUserToAddRows = false;
            this.stanzeDataGridView.AllowUserToDeleteRows = false;
            this.stanzeDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.stanzeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.stanzeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stanzeDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.stanzeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stanzeDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.stanzeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stanzeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.stanzeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stanzeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.infoStanzaColumn,
            this.postiStandardColumn,
            this.postiMaxColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stanzeDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.stanzeDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.stanzeDataGridView.Location = new System.Drawing.Point(12, 104);
            this.stanzeDataGridView.MultiSelect = false;
            this.stanzeDataGridView.Name = "stanzeDataGridView";
            this.stanzeDataGridView.ReadOnly = true;
            this.stanzeDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stanzeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.stanzeDataGridView.RowHeadersVisible = false;
            this.stanzeDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stanzeDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.stanzeDataGridView.RowTemplate.Height = 24;
            this.stanzeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stanzeDataGridView.Size = new System.Drawing.Size(708, 184);
            this.stanzeDataGridView.TabIndex = 3;
            // 
            // infoStanzaColumn
            // 
            this.infoStanzaColumn.HeaderText = "Info Stanza";
            this.infoStanzaColumn.Name = "infoStanzaColumn";
            this.infoStanzaColumn.ReadOnly = true;
            // 
            // postiStandardColumn
            // 
            this.postiStandardColumn.FillWeight = 50F;
            this.postiStandardColumn.HeaderText = "Posti Standard";
            this.postiStandardColumn.Name = "postiStandardColumn";
            this.postiStandardColumn.ReadOnly = true;
            // 
            // postiMaxColumn
            // 
            this.postiMaxColumn.FillWeight = 50F;
            this.postiMaxColumn.HeaderText = "Posti Max";
            this.postiMaxColumn.Name = "postiMaxColumn";
            this.postiMaxColumn.ReadOnly = true;
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
            // 
            // rimuoviStanzaButton
            // 
            this.rimuoviStanzaButton.BackColor = System.Drawing.Color.LightGray;
            this.rimuoviStanzaButton.FlatAppearance.BorderSize = 0;
            this.rimuoviStanzaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rimuoviStanzaButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rimuoviStanzaButton.Location = new System.Drawing.Point(483, 358);
            this.rimuoviStanzaButton.Name = "rimuoviStanzaButton";
            this.rimuoviStanzaButton.Size = new System.Drawing.Size(170, 26);
            this.rimuoviStanzaButton.TabIndex = 8;
            this.rimuoviStanzaButton.Text = "Rimuovi Stanza";
            this.rimuoviStanzaButton.UseVisualStyleBackColor = false;
            this.rimuoviStanzaButton.Click += new System.EventHandler(this.rimuoviStanzaButton_Click);
            // 
            // modificaStanzaButton
            // 
            this.modificaStanzaButton.BackColor = System.Drawing.Color.LightGray;
            this.modificaStanzaButton.FlatAppearance.BorderSize = 0;
            this.modificaStanzaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificaStanzaButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificaStanzaButton.Location = new System.Drawing.Point(281, 358);
            this.modificaStanzaButton.Name = "modificaStanzaButton";
            this.modificaStanzaButton.Size = new System.Drawing.Size(170, 26);
            this.modificaStanzaButton.TabIndex = 7;
            this.modificaStanzaButton.Text = "Modifica Stanza";
            this.modificaStanzaButton.UseVisualStyleBackColor = false;
            this.modificaStanzaButton.Click += new System.EventHandler(this.modificaStanzaButton_Click);
            // 
            // aggiungiStanzaButton
            // 
            this.aggiungiStanzaButton.BackColor = System.Drawing.Color.LightGray;
            this.aggiungiStanzaButton.FlatAppearance.BorderSize = 0;
            this.aggiungiStanzaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aggiungiStanzaButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aggiungiStanzaButton.Location = new System.Drawing.Point(79, 358);
            this.aggiungiStanzaButton.Name = "aggiungiStanzaButton";
            this.aggiungiStanzaButton.Size = new System.Drawing.Size(170, 26);
            this.aggiungiStanzaButton.TabIndex = 6;
            this.aggiungiStanzaButton.Text = "Aggiungi Stanza";
            this.aggiungiStanzaButton.UseVisualStyleBackColor = false;
            // 
            // postiMaxTotaliLabel
            // 
            this.postiMaxTotaliLabel.AutoSize = true;
            this.postiMaxTotaliLabel.BackColor = System.Drawing.Color.Transparent;
            this.postiMaxTotaliLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postiMaxTotaliLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.postiMaxTotaliLabel.Location = new System.Drawing.Point(549, 291);
            this.postiMaxTotaliLabel.Name = "postiMaxTotaliLabel";
            this.postiMaxTotaliLabel.Size = new System.Drawing.Size(117, 17);
            this.postiMaxTotaliLabel.TabIndex = 5;
            this.postiMaxTotaliLabel.Text = "Posti Totali Max  10";
            // 
            // postiTotoaliLabel
            // 
            this.postiTotoaliLabel.AutoSize = true;
            this.postiTotoaliLabel.BackColor = System.Drawing.Color.Transparent;
            this.postiTotoaliLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postiTotoaliLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.postiTotoaliLabel.Location = new System.Drawing.Point(373, 291);
            this.postiTotoaliLabel.Name = "postiTotoaliLabel";
            this.postiTotoaliLabel.Size = new System.Drawing.Size(82, 17);
            this.postiTotoaliLabel.TabIndex = 4;
            this.postiTotoaliLabel.Text = "Posti Totali  5";
            // 
            // codiceTextBox1
            // 
            this.codiceTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.codiceTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codiceTextBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codiceTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.codiceTextBox1.Location = new System.Drawing.Point(258, 23);
            this.codiceTextBox1.Name = "codiceTextBox1";
            this.codiceTextBox1.Size = new System.Drawing.Size(445, 17);
            this.codiceTextBox1.TabIndex = 2;
            this.codiceTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.myLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel2.Location = new System.Drawing.Point(23, 78);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(51, 19);
            this.myLabel2.TabIndex = 1;
            this.myLabel2.Text = "Stanze";
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.BackColor = System.Drawing.Color.Transparent;
            this.myLabel1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel1.Location = new System.Drawing.Point(23, 23);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(104, 17);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "Codice Bungalow";
            // 
            // AggiungiModificaBungalow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.Controls.Add(this.stanzeDataGridView);
            this.Controls.Add(this.annullaButton);
            this.Controls.Add(this.salvaButton);
            this.Controls.Add(this.rimuoviStanzaButton);
            this.Controls.Add(this.modificaStanzaButton);
            this.Controls.Add(this.aggiungiStanzaButton);
            this.Controls.Add(this.postiMaxTotaliLabel);
            this.Controls.Add(this.postiTotoaliLabel);
            this.Controls.Add(this.codiceTextBox1);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.myLabel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AggiungiModificaBungalow";
            this.Text = "Aggiungi Bungalow";
            this.Load += new System.EventHandler(this.AggiungiModificaBungalow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stanzeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.MyLabel myLabel2;
        private Components.MyTextBox codiceTextBox1;
        private Components.MyDataGridView stanzeDataGridView;
        private Components.MyLabel postiTotoaliLabel;
        private Components.MyLabel postiMaxTotaliLabel;
        private Components.MyLabel myLabel1;
        private Components.MyButton aggiungiStanzaButton;
        private Components.MyButton modificaStanzaButton;
        private Components.MyButton rimuoviStanzaButton;
        private Components.MyButton salvaButton;
        private Components.MyButton annullaButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoStanzaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postiStandardColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postiMaxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}