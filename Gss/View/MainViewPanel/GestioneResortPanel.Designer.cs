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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataInizioStagioneTimePicker.Size = new System.Drawing.Size(266, 22);
            this.dataInizioStagioneTimePicker.TabIndex = 12;
            // 
            // dataFineStagioneTimePicker
            // 
            this.dataFineStagioneTimePicker.Enabled = false;
            this.dataFineStagioneTimePicker.Location = new System.Drawing.Point(194, 78);
            this.dataFineStagioneTimePicker.Name = "dataFineStagioneTimePicker";
            this.dataFineStagioneTimePicker.Size = new System.Drawing.Size(266, 22);
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
            this.myLabel2.Size = new System.Drawing.Size(82, 29);
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
            this.myLabel1.Size = new System.Drawing.Size(76, 29);
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
            // 
            // bungalowsDataGridView
            // 
            this.bungalowsDataGridView.AllowUserToAddRows = false;
            this.bungalowsDataGridView.AllowUserToDeleteRows = false;
            this.bungalowsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.bungalowsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.bungalowsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bungalowsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bungalowsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bungalowsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.bungalowsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bungalowsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.bungalowsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bungalowsDataGridView.ColumnHeadersVisible = false;
            this.bungalowsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bungalowDescrColumn});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bungalowsDataGridView.DefaultCellStyle = dataGridViewCellStyle33;
            this.bungalowsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bungalowsDataGridView.Location = new System.Drawing.Point(29, 45);
            this.bungalowsDataGridView.MultiSelect = false;
            this.bungalowsDataGridView.Name = "bungalowsDataGridView";
            this.bungalowsDataGridView.ReadOnly = true;
            this.bungalowsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bungalowsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.bungalowsDataGridView.RowHeadersVisible = false;
            this.bungalowsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bungalowsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle35;
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
            this.totalePisteResortLabel.Size = new System.Drawing.Size(168, 21);
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
            this.myLabel6.Size = new System.Drawing.Size(100, 24);
            this.myLabel6.TabIndex = 15;
            this.myLabel6.Text = "Bungalows";
            // 
            // impiantiDataGridView
            // 
            this.impiantiDataGridView.AllowUserToAddRows = false;
            this.impiantiDataGridView.AllowUserToDeleteRows = false;
            this.impiantiDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.impiantiDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle36;
            this.impiantiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.impiantiDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.impiantiDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.impiantiDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.impiantiDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.impiantiDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.impiantiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.impiantiDataGridView.ColumnHeadersVisible = false;
            this.impiantiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.impiantiDataGridView.DefaultCellStyle = dataGridViewCellStyle38;
            this.impiantiDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.impiantiDataGridView.Location = new System.Drawing.Point(29, 260);
            this.impiantiDataGridView.MultiSelect = false;
            this.impiantiDataGridView.Name = "impiantiDataGridView";
            this.impiantiDataGridView.ReadOnly = true;
            this.impiantiDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.impiantiDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.impiantiDataGridView.RowHeadersVisible = false;
            this.impiantiDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impiantiDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle40;
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
            this.totalePostiResortLabel.Size = new System.Drawing.Size(173, 21);
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
            this.myLabel8.Size = new System.Drawing.Size(143, 24);
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
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel4.Location = new System.Drawing.Point(30, 42);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(147, 21);
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
            this.myLabel5.Size = new System.Drawing.Size(139, 21);
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
