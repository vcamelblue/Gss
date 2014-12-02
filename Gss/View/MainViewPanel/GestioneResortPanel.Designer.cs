namespace Gss.View.MainViewPanel
{
    partial class GestioneResortPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataInizioStagioneTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataFineStagioneTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.myLabel2 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel1 = new Gss.View.Components.MyLabel(this.components);
            this.gestioneImpiantiButton = new Gss.View.Components.MyButton(this.components);
            this.bungalowsDataGridView = new Gss.View.Components.MyDataGridView(this.components);
            this.bungalowDescrColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalePisteResortLabel = new Gss.View.Components.MyLabel(this.components);
            this.myLabel6 = new Gss.View.Components.MyLabel(this.components);
            this.impiantiDataGridView = new Gss.View.Components.MyDataGridView(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalePostiResortLabel = new Gss.View.Components.MyLabel(this.components);
            this.myLabel8 = new Gss.View.Components.MyLabel(this.components);
            this.gestioneBungalowsButton = new Gss.View.Components.MyButton(this.components);
            this.gestioneInfoResortButton = new Gss.View.Components.MyButton(this.components);
            this.myLabel4 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel5 = new Gss.View.Components.MyLabel(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bungalowsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impiantiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gestioneImpiantiButton);
            this.groupBox1.Controls.Add(this.bungalowsDataGridView);
            this.groupBox1.Controls.Add(this.totalePisteResortLabel);
            this.groupBox1.Controls.Add(this.myLabel6);
            this.groupBox1.Controls.Add(this.impiantiDataGridView);
            this.groupBox1.Controls.Add(this.totalePostiResortLabel);
            this.groupBox1.Controls.Add(this.myLabel8);
            this.groupBox1.Controls.Add(this.gestioneBungalowsButton);
            this.groupBox1.Location = new System.Drawing.Point(-11, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 457);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // dataInizioStagioneTimePicker
            // 
            this.dataInizioStagioneTimePicker.Enabled = false;
            this.dataInizioStagioneTimePicker.Location = new System.Drawing.Point(194, 41);
            this.dataInizioStagioneTimePicker.Name = "dataInizioStagioneTimePicker";
            this.dataInizioStagioneTimePicker.Size = new System.Drawing.Size(266, 20);
            this.dataInizioStagioneTimePicker.TabIndex = 12;
            // 
            // dataFineStagioneTimePicker
            // 
            this.dataFineStagioneTimePicker.Enabled = false;
            this.dataFineStagioneTimePicker.Location = new System.Drawing.Point(194, 78);
            this.dataFineStagioneTimePicker.Name = "dataFineStagioneTimePicker";
            this.dataFineStagioneTimePicker.Size = new System.Drawing.Size(266, 20);
            this.dataFineStagioneTimePicker.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gestioneInfoResortButton);
            this.groupBox2.Controls.Add(this.dataFineStagioneTimePicker);
            this.groupBox2.Controls.Add(this.dataInizioStagioneTimePicker);
            this.groupBox2.Controls.Add(this.myLabel4);
            this.groupBox2.Controls.Add(this.myLabel5);
            this.groupBox2.Location = new System.Drawing.Point(-11, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(720, 174);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.myLabel2.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel2.Location = new System.Drawing.Point(308, 119);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(64, 23);
            this.myLabel2.TabIndex = 23;
            this.myLabel2.Text = "Risorse";
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.BackColor = System.Drawing.Color.Transparent;
            this.myLabel1.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel1.Location = new System.Drawing.Point(311, -1);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(59, 23);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "Resort";
            // 
            // gestioneImpiantiButton
            // 
            this.gestioneImpiantiButton.BackColor = System.Drawing.Color.LightGray;
            this.gestioneImpiantiButton.FlatAppearance.BorderSize = 0;
            this.gestioneImpiantiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gestioneImpiantiButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestioneImpiantiButton.Location = new System.Drawing.Point(484, 408);
            this.gestioneImpiantiButton.Name = "gestioneImpiantiButton";
            this.gestioneImpiantiButton.Size = new System.Drawing.Size(187, 26);
            this.gestioneImpiantiButton.TabIndex = 22;
            this.gestioneImpiantiButton.Text = "Gestione Impianti";
            this.gestioneImpiantiButton.UseVisualStyleBackColor = false;
            this.gestioneImpiantiButton.Click += new System.EventHandler(this.gestioneImpiantiButton_Click);
            // 
            // bungalowsDataGridView
            // 
            this.bungalowsDataGridView.AllowUserToAddRows = false;
            this.bungalowsDataGridView.AllowUserToDeleteRows = false;
            this.bungalowsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.bungalowsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bungalowsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bungalowsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bungalowsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bungalowsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.bungalowsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bungalowsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bungalowsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bungalowsDataGridView.ColumnHeadersVisible = false;
            this.bungalowsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bungalowDescrColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bungalowsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.bungalowsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bungalowsDataGridView.Location = new System.Drawing.Point(29, 45);
            this.bungalowsDataGridView.MultiSelect = false;
            this.bungalowsDataGridView.Name = "bungalowsDataGridView";
            this.bungalowsDataGridView.ReadOnly = true;
            this.bungalowsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bungalowsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bungalowsDataGridView.RowHeadersVisible = false;
            this.bungalowsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bungalowsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bungalowsDataGridView.RowTemplate.Height = 30;
            this.bungalowsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bungalowsDataGridView.Size = new System.Drawing.Size(663, 139);
            this.bungalowsDataGridView.TabIndex = 16;
            // 
            // bungalowDescrColumn
            // 
            this.bungalowDescrColumn.FillWeight = 50F;
            this.bungalowDescrColumn.HeaderText = "Descrizione Bungalows";
            this.bungalowDescrColumn.Name = "bungalowDescrColumn";
            this.bungalowDescrColumn.ReadOnly = true;
            // 
            // totalePisteResortLabel
            // 
            this.totalePisteResortLabel.AutoSize = true;
            this.totalePisteResortLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalePisteResortLabel.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalePisteResortLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.totalePisteResortLabel.Location = new System.Drawing.Point(40, 410);
            this.totalePisteResortLabel.Name = "totalePisteResortLabel";
            this.totalePisteResortLabel.Size = new System.Drawing.Size(134, 17);
            this.totalePisteResortLabel.TabIndex = 21;
            this.totalePisteResortLabel.Text = "Totali Piste Resort    60";
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = true;
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Font = new System.Drawing.Font("Calibri", 12F);
            this.myLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel6.Location = new System.Drawing.Point(40, 17);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Size = new System.Drawing.Size(80, 19);
            this.myLabel6.TabIndex = 15;
            this.myLabel6.Text = "Bungalows";
            // 
            // impiantiDataGridView
            // 
            this.impiantiDataGridView.AllowUserToAddRows = false;
            this.impiantiDataGridView.AllowUserToDeleteRows = false;
            this.impiantiDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.impiantiDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.impiantiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.impiantiDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.impiantiDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.impiantiDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.impiantiDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.impiantiDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.impiantiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.impiantiDataGridView.ColumnHeadersVisible = false;
            this.impiantiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.impiantiDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.impiantiDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.impiantiDataGridView.Location = new System.Drawing.Point(29, 260);
            this.impiantiDataGridView.MultiSelect = false;
            this.impiantiDataGridView.Name = "impiantiDataGridView";
            this.impiantiDataGridView.ReadOnly = true;
            this.impiantiDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.impiantiDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.impiantiDataGridView.RowHeadersVisible = false;
            this.impiantiDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impiantiDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.impiantiDataGridView.RowTemplate.Height = 30;
            this.impiantiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.impiantiDataGridView.Size = new System.Drawing.Size(663, 139);
            this.impiantiDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Descrizione Impianti";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // totalePostiResortLabel
            // 
            this.totalePostiResortLabel.AutoSize = true;
            this.totalePostiResortLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalePostiResortLabel.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalePostiResortLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.totalePostiResortLabel.Location = new System.Drawing.Point(40, 195);
            this.totalePostiResortLabel.Name = "totalePostiResortLabel";
            this.totalePostiResortLabel.Size = new System.Drawing.Size(139, 17);
            this.totalePostiResortLabel.TabIndex = 17;
            this.totalePostiResortLabel.Text = "Totale Posti Resort  180";
            // 
            // myLabel8
            // 
            this.myLabel8.AutoSize = true;
            this.myLabel8.BackColor = System.Drawing.Color.Transparent;
            this.myLabel8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel8.Location = new System.Drawing.Point(40, 232);
            this.myLabel8.Name = "myLabel8";
            this.myLabel8.Size = new System.Drawing.Size(115, 19);
            this.myLabel8.TabIndex = 19;
            this.myLabel8.Text = "Impianti Sciistici";
            // 
            // gestioneBungalowsButton
            // 
            this.gestioneBungalowsButton.BackColor = System.Drawing.Color.LightGray;
            this.gestioneBungalowsButton.FlatAppearance.BorderSize = 0;
            this.gestioneBungalowsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gestioneBungalowsButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestioneBungalowsButton.Location = new System.Drawing.Point(484, 193);
            this.gestioneBungalowsButton.Name = "gestioneBungalowsButton";
            this.gestioneBungalowsButton.Size = new System.Drawing.Size(187, 26);
            this.gestioneBungalowsButton.TabIndex = 18;
            this.gestioneBungalowsButton.Text = "Gestione Bungalows";
            this.gestioneBungalowsButton.UseVisualStyleBackColor = false;
            this.gestioneBungalowsButton.Click += new System.EventHandler(this.gestioneBungalowsButton_Click);
            // 
            // gestioneInfoResortButton
            // 
            this.gestioneInfoResortButton.BackColor = System.Drawing.Color.LightGray;
            this.gestioneInfoResortButton.FlatAppearance.BorderSize = 0;
            this.gestioneInfoResortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gestioneInfoResortButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestioneInfoResortButton.Location = new System.Drawing.Point(484, 57);
            this.gestioneInfoResortButton.Name = "gestioneInfoResortButton";
            this.gestioneInfoResortButton.Size = new System.Drawing.Size(187, 26);
            this.gestioneInfoResortButton.TabIndex = 14;
            this.gestioneInfoResortButton.Text = "Gestione Resort";
            this.gestioneInfoResortButton.UseVisualStyleBackColor = false;
            this.gestioneInfoResortButton.Click += new System.EventHandler(this.gestioneInfoResortButton_Click);
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel4.Location = new System.Drawing.Point(30, 42);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(121, 17);
            this.myLabel4.TabIndex = 3;
            this.myLabel4.Text = "Data Inizio Stagione";
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel5.Location = new System.Drawing.Point(30, 79);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(114, 17);
            this.myLabel5.TabIndex = 4;
            this.myLabel5.Text = "Data Fine Stagione";
            // 
            // GestioneResortPanel
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.myLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "GestioneResortPanel";
            this.Size = new System.Drawing.Size(698, 573);
            this.Load += new System.EventHandler(this.GestioneResortPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bungalowsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impiantiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.MyButton gestioneInfoResortButton;
        private Components.MyDataGridView bungalowsDataGridView;
        private Components.MyLabel myLabel6;
        private Components.MyLabel totalePostiResortLabel;
        private Components.MyButton gestioneBungalowsButton;
        private Components.MyDataGridView impiantiDataGridView;
        private Components.MyLabel myLabel8;
        private Components.MyLabel totalePisteResortLabel;
        private Components.MyButton gestioneImpiantiButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private Components.MyLabel myLabel2;
        private Components.MyLabel myLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bungalowDescrColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Components.MyLabel myLabel4;
        private Components.MyLabel myLabel5;
        private System.Windows.Forms.DateTimePicker dataInizioStagioneTimePicker;
        private System.Windows.Forms.DateTimePicker dataFineStagioneTimePicker;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
