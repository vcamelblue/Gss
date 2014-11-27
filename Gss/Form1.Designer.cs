namespace Gss {
    partial class Form1 {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codiceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numStanzeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoStanzeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postiStandardColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postiMaxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myButton5 = new Gss.View.Components.MyButton(this.components);
            this.myButton4 = new Gss.View.Components.MyButton(this.components);
            this.myButton3 = new Gss.View.Components.MyButton(this.components);
            this.myButton2 = new Gss.View.Components.MyButton(this.components);
            this.myButton1 = new Gss.View.Components.MyButton(this.components);
            this.myButton6 = new Gss.View.Components.MyButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codiceColumn,
            this.numStanzeColumn,
            this.infoStanzeColumn,
            this.postiStandardColumn,
            this.postiMaxColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(577, 203);
            this.dataGridView1.TabIndex = 2;
            // 
            // codiceColumn
            // 
            this.codiceColumn.HeaderText = "Codice";
            this.codiceColumn.Name = "codiceColumn";
            this.codiceColumn.ReadOnly = true;
            this.codiceColumn.Width = 81;
            // 
            // numStanzeColumn
            // 
            this.numStanzeColumn.HeaderText = "Numero Stanze";
            this.numStanzeColumn.Name = "numStanzeColumn";
            this.numStanzeColumn.ReadOnly = true;
            this.numStanzeColumn.Width = 142;
            // 
            // infoStanzeColumn
            // 
            this.infoStanzeColumn.HeaderText = "Info Stanze";
            this.infoStanzeColumn.Name = "infoStanzeColumn";
            this.infoStanzeColumn.ReadOnly = true;
            this.infoStanzeColumn.Width = 112;
            // 
            // postiStandardColumn
            // 
            this.postiStandardColumn.HeaderText = "Posti Standard";
            this.postiStandardColumn.Name = "postiStandardColumn";
            this.postiStandardColumn.ReadOnly = true;
            this.postiStandardColumn.Width = 136;
            // 
            // postiMaxColumn
            // 
            this.postiMaxColumn.HeaderText = "Posti Max";
            this.postiMaxColumn.Name = "postiMaxColumn";
            this.postiMaxColumn.ReadOnly = true;
            this.postiMaxColumn.Width = 103;
            // 
            // myButton5
            // 
            this.myButton5.BackColor = System.Drawing.Color.LightGray;
            this.myButton5.FlatAppearance.BorderSize = 0;
            this.myButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton5.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton5.Location = new System.Drawing.Point(244, 413);
            this.myButton5.Name = "myButton5";
            this.myButton5.Size = new System.Drawing.Size(99, 26);
            this.myButton5.TabIndex = 5;
            this.myButton5.Text = "myButton5";
            this.myButton5.UseVisualStyleBackColor = false;
            this.myButton5.Click += new System.EventHandler(this.myButton5_Click);
            // 
            // myButton4
            // 
            this.myButton4.BackColor = System.Drawing.Color.LightGray;
            this.myButton4.FlatAppearance.BorderSize = 0;
            this.myButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton4.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton4.Location = new System.Drawing.Point(144, 414);
            this.myButton4.Name = "myButton4";
            this.myButton4.Size = new System.Drawing.Size(94, 26);
            this.myButton4.TabIndex = 4;
            this.myButton4.Text = "myButton4";
            this.myButton4.UseVisualStyleBackColor = false;
            this.myButton4.Click += new System.EventHandler(this.myButton4_Click);
            // 
            // myButton3
            // 
            this.myButton3.BackColor = System.Drawing.Color.LightGray;
            this.myButton3.FlatAppearance.BorderSize = 0;
            this.myButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton3.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton3.Location = new System.Drawing.Point(39, 414);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(88, 26);
            this.myButton3.TabIndex = 3;
            this.myButton3.Text = "myButton3";
            this.myButton3.UseVisualStyleBackColor = false;
            this.myButton3.Click += new System.EventHandler(this.myButton3_Click);
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.myButton2.FlatAppearance.BorderSize = 0;
            this.myButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.myButton2.ForeColor = System.Drawing.Color.White;
            this.myButton2.Location = new System.Drawing.Point(291, 586);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(272, 57);
            this.myButton2.TabIndex = 1;
            this.myButton2.Text = "myButton2";
            this.myButton2.UseVisualStyleBackColor = false;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.myButton1.FlatAppearance.BorderSize = 0;
            this.myButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.myButton1.ForeColor = System.Drawing.Color.White;
            this.myButton1.Location = new System.Drawing.Point(13, 586);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(272, 57);
            this.myButton1.TabIndex = 0;
            this.myButton1.Text = "myButton1";
            this.myButton1.UseVisualStyleBackColor = false;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // myButton6
            // 
            this.myButton6.BackColor = System.Drawing.Color.LightGray;
            this.myButton6.FlatAppearance.BorderSize = 0;
            this.myButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            this.myButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton6.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton6.Location = new System.Drawing.Point(416, 414);
            this.myButton6.Name = "myButton6";
            this.myButton6.Size = new System.Drawing.Size(63, 26);
            this.myButton6.TabIndex = 6;
            this.myButton6.Text = "myButton6";
            this.myButton6.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(575, 655);
            this.Controls.Add(this.myButton6);
            this.Controls.Add(this.myButton5);
            this.Controls.Add(this.myButton4);
            this.Controls.Add(this.myButton3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private View.Components.MyButton myButton1;
        private View.Components.MyButton myButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numStanzeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoStanzeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postiStandardColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postiMaxColumn;
        private View.Components.MyButton myButton3;
        private View.Components.MyButton myButton4;
        private View.Components.MyButton myButton5;
        private View.Components.MyButton myButton6;
    }
}

