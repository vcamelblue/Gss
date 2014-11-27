namespace Gss.View {
    partial class GestioneBungalows {
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
            this.rimuoviBungalowButton = new Gss.View.Components.MyButton(this.components);
            this.modificaBungalowButton = new Gss.View.Components.MyButton(this.components);
            this.aggiungiBungalowButton = new Gss.View.Components.MyButton(this.components);
            this.bungalowDataGridView = new Gss.View.Components.MyDataGridView(this.components);
            this.codiceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numStanzeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoStanzeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postiStandardColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postiMaxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bungalowDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rimuoviBungalowButton
            // 
            this.rimuoviBungalowButton.BackColor = System.Drawing.Color.LightGray;
            this.rimuoviBungalowButton.FlatAppearance.BorderSize = 0;
            this.rimuoviBungalowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rimuoviBungalowButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rimuoviBungalowButton.Location = new System.Drawing.Point(455, 526);
            this.rimuoviBungalowButton.Name = "rimuoviBungalowButton";
            this.rimuoviBungalowButton.Size = new System.Drawing.Size(226, 26);
            this.rimuoviBungalowButton.TabIndex = 3;
            this.rimuoviBungalowButton.Text = "Rimuovi Bungalow";
            this.rimuoviBungalowButton.UseVisualStyleBackColor = false;
            this.rimuoviBungalowButton.Click += new System.EventHandler(this.rimuoviBungalowButton_Click);
            // 
            // modificaBungalowButton
            // 
            this.modificaBungalowButton.BackColor = System.Drawing.Color.LightGray;
            this.modificaBungalowButton.FlatAppearance.BorderSize = 0;
            this.modificaBungalowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificaBungalowButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificaBungalowButton.Location = new System.Drawing.Point(228, 526);
            this.modificaBungalowButton.Name = "modificaBungalowButton";
            this.modificaBungalowButton.Size = new System.Drawing.Size(226, 26);
            this.modificaBungalowButton.TabIndex = 2;
            this.modificaBungalowButton.Text = "Modifica Bungalow";
            this.modificaBungalowButton.UseVisualStyleBackColor = false;
            this.modificaBungalowButton.Click += new System.EventHandler(this.modificaBungalowButton_Click);
            // 
            // aggiungiBungalowButton
            // 
            this.aggiungiBungalowButton.BackColor = System.Drawing.Color.LightGray;
            this.aggiungiBungalowButton.FlatAppearance.BorderSize = 0;
            this.aggiungiBungalowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aggiungiBungalowButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aggiungiBungalowButton.Location = new System.Drawing.Point(1, 526);
            this.aggiungiBungalowButton.Name = "aggiungiBungalowButton";
            this.aggiungiBungalowButton.Size = new System.Drawing.Size(226, 26);
            this.aggiungiBungalowButton.TabIndex = 1;
            this.aggiungiBungalowButton.Text = "Aggiungi Bungalow";
            this.aggiungiBungalowButton.UseVisualStyleBackColor = false;
            this.aggiungiBungalowButton.Click += new System.EventHandler(this.aggiungiBungalowButton_Click);
            // 
            // bungalowDataGridView
            // 
            this.bungalowDataGridView.AllowUserToAddRows = false;
            this.bungalowDataGridView.AllowUserToDeleteRows = false;
            this.bungalowDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.bungalowDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bungalowDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bungalowDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.bungalowDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bungalowDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.bungalowDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bungalowDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bungalowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bungalowDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.bungalowDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.bungalowDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bungalowDataGridView.Location = new System.Drawing.Point(-1, -1);
            this.bungalowDataGridView.MultiSelect = false;
            this.bungalowDataGridView.Name = "bungalowDataGridView";
            this.bungalowDataGridView.ReadOnly = true;
            this.bungalowDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bungalowDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bungalowDataGridView.RowHeadersVisible = false;
            this.bungalowDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bungalowDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bungalowDataGridView.RowTemplate.Height = 24;
            this.bungalowDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bungalowDataGridView.Size = new System.Drawing.Size(683, 526);
            this.bungalowDataGridView.TabIndex = 0;
            // 
            // codiceColumn
            // 
            this.codiceColumn.FillWeight = 70F;
            this.codiceColumn.HeaderText = "Codice";
            this.codiceColumn.Name = "codiceColumn";
            this.codiceColumn.ReadOnly = true;
            // 
            // numStanzeColumn
            // 
            this.numStanzeColumn.FillWeight = 70F;
            this.numStanzeColumn.HeaderText = "Numero Stanze";
            this.numStanzeColumn.Name = "numStanzeColumn";
            this.numStanzeColumn.ReadOnly = true;
            // 
            // infoStanzeColumn
            // 
            this.infoStanzeColumn.FillWeight = 170F;
            this.infoStanzeColumn.HeaderText = "Info Stanze";
            this.infoStanzeColumn.Name = "infoStanzeColumn";
            this.infoStanzeColumn.ReadOnly = true;
            // 
            // postiStandardColumn
            // 
            this.postiStandardColumn.FillWeight = 70F;
            this.postiStandardColumn.HeaderText = "Posti Standard";
            this.postiStandardColumn.Name = "postiStandardColumn";
            this.postiStandardColumn.ReadOnly = true;
            // 
            // postiMaxColumn
            // 
            this.postiMaxColumn.FillWeight = 70F;
            this.postiMaxColumn.HeaderText = "Posti Max";
            this.postiMaxColumn.Name = "postiMaxColumn";
            this.postiMaxColumn.ReadOnly = true;
            // 
            // GestioneBungalows
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.rimuoviBungalowButton);
            this.Controls.Add(this.modificaBungalowButton);
            this.Controls.Add(this.aggiungiBungalowButton);
            this.Controls.Add(this.bungalowDataGridView);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GestioneBungalows";
            this.Text = "Gestione Bungalows";
            this.Load += new System.EventHandler(this.GestioneBungalows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bungalowDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MyDataGridView bungalowDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numStanzeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoStanzeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postiStandardColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postiMaxColumn;
        private Components.MyButton aggiungiBungalowButton;
        private Components.MyButton modificaBungalowButton;
        private Components.MyButton rimuoviBungalowButton;



    }
}