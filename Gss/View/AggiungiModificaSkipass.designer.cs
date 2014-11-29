namespace Gss.View {
    partial class AggiungiModificaSkipass {
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
            this.visualizzaDettagliImpiantoButton = new Gss.View.Components.MyButton(this.components);
            this.impiantiDataGridView = new Gss.View.Components.MyDataGridView(this.components);
            this.codiceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versanteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPisteAlpineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPisteDiFodnoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPisteSnowparkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filtraImpiantiGroupBox = new System.Windows.Forms.GroupBox();
            this.filtraButton = new Gss.View.Components.MyButton(this.components);
            this.tipoFiltroTabControl = new Gss.View.Components.TabControlWithoutHeader(this.components);
            this.filtroPerNomeTabPage = new System.Windows.Forms.TabPage();
            this.nomeImpiantoFiltroTextBox = new Gss.View.Components.MyTextBox(this.components);
            this.myLabel7 = new Gss.View.Components.MyLabel(this.components);
            this.filtroPerPrezzoTabPage = new System.Windows.Forms.TabPage();
            this.prezzoMassimoFiltroTextBox = new Gss.View.Components.MyTextBox(this.components);
            this.myLabel8 = new Gss.View.Components.MyLabel(this.components);
            this.filtroPerTipoPisteTabPage = new System.Windows.Forms.TabPage();
            this.tipologiaPistaFiltroComboBox = new Gss.View.Components.MyComboBox(this.components);
            this.myLabel10 = new Gss.View.Components.MyLabel(this.components);
            this.numeroPisteFiltroTextBox = new Gss.View.Components.MyTextBox(this.components);
            this.myLabel9 = new Gss.View.Components.MyLabel(this.components);
            this.filtroPerCaratteristicaTabPage = new System.Windows.Forms.TabPage();
            this.caratteristicaSpecificaAlmenoFiltroTextBox = new Gss.View.Components.MyTextBox(this.components);
            this.myLabel11 = new Gss.View.Components.MyLabel(this.components);
            this.caratteristicaSpecificaFiltroComboBox = new Gss.View.Components.MyComboBox(this.components);
            this.caratteristicaSpecificaRadioButton = new System.Windows.Forms.RadioButton();
            this.nPisteDiTipoRadioButton = new System.Windows.Forms.RadioButton();
            this.prezzoMassimoRadioButton = new System.Windows.Forms.RadioButton();
            this.perNomeRadioButton = new System.Windows.Forms.RadioButton();
            this.tipoSkipassTabControl = new Gss.View.Components.TabControlWithoutHeader(this.components);
            this.skipassAGiornataTabPage = new System.Windows.Forms.TabPage();
            this.skipassAGiornataDataFineTimePicker = new System.Windows.Forms.DateTimePicker();
            this.skipassAGiornataDataInizioTimePicker = new System.Windows.Forms.DateTimePicker();
            this.myLabel4 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel3 = new Gss.View.Components.MyLabel(this.components);
            this.skipassAdAccessoTabPage = new System.Windows.Forms.TabPage();
            this.skipassAdAccessoDataInizioTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numeroAccessiTextBox = new Gss.View.Components.MyTextBox(this.components);
            this.myLabel6 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel5 = new Gss.View.Components.MyLabel(this.components);
            this.annullaButton = new Gss.View.Components.MyButton(this.components);
            this.AggiungiSkipassButton = new Gss.View.Components.MyButton(this.components);
            this.tipologiaSkipassComboBox = new Gss.View.Components.MyComboBox(this.components);
            this.codiceSkipassTextBox = new Gss.View.Components.MyTextBox(this.components);
            this.myLabel2 = new Gss.View.Components.MyLabel(this.components);
            this.myLabel1 = new Gss.View.Components.MyLabel(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.impiantiDataGridView)).BeginInit();
            this.filtraImpiantiGroupBox.SuspendLayout();
            this.tipoFiltroTabControl.SuspendLayout();
            this.filtroPerNomeTabPage.SuspendLayout();
            this.filtroPerPrezzoTabPage.SuspendLayout();
            this.filtroPerTipoPisteTabPage.SuspendLayout();
            this.filtroPerCaratteristicaTabPage.SuspendLayout();
            this.tipoSkipassTabControl.SuspendLayout();
            this.skipassAGiornataTabPage.SuspendLayout();
            this.skipassAdAccessoTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.visualizzaDettagliImpiantoButton);
            this.groupBox1.Controls.Add(this.impiantiDataGridView);
            this.groupBox1.Controls.Add(this.filtraImpiantiGroupBox);
            this.groupBox1.Controls.Add(this.tipoSkipassTabControl);
            this.groupBox1.Location = new System.Drawing.Point(-2, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 617);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // visualizzaDettagliImpiantoButton
            // 
            this.visualizzaDettagliImpiantoButton.BackColor = System.Drawing.Color.LightGray;
            this.visualizzaDettagliImpiantoButton.FlatAppearance.BorderSize = 0;
            this.visualizzaDettagliImpiantoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualizzaDettagliImpiantoButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizzaDettagliImpiantoButton.Location = new System.Drawing.Point(516, 582);
            this.visualizzaDettagliImpiantoButton.Name = "visualizzaDettagliImpiantoButton";
            this.visualizzaDettagliImpiantoButton.Size = new System.Drawing.Size(193, 26);
            this.visualizzaDettagliImpiantoButton.TabIndex = 3;
            this.visualizzaDettagliImpiantoButton.Text = "Visualizza Dettagli Impianto";
            this.visualizzaDettagliImpiantoButton.UseVisualStyleBackColor = false;
            this.visualizzaDettagliImpiantoButton.Click += new System.EventHandler(this.visualizzaDettagliImpiantoButton_Click);
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
            this.impiantiDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
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
            this.impiantiDataGridView.Location = new System.Drawing.Point(26, 414);
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
            this.impiantiDataGridView.Size = new System.Drawing.Size(689, 157);
            this.impiantiDataGridView.TabIndex = 2;
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
            // filtraImpiantiGroupBox
            // 
            this.filtraImpiantiGroupBox.Controls.Add(this.filtraButton);
            this.filtraImpiantiGroupBox.Controls.Add(this.tipoFiltroTabControl);
            this.filtraImpiantiGroupBox.Controls.Add(this.caratteristicaSpecificaRadioButton);
            this.filtraImpiantiGroupBox.Controls.Add(this.nPisteDiTipoRadioButton);
            this.filtraImpiantiGroupBox.Controls.Add(this.prezzoMassimoRadioButton);
            this.filtraImpiantiGroupBox.Controls.Add(this.perNomeRadioButton);
            this.filtraImpiantiGroupBox.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtraImpiantiGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.filtraImpiantiGroupBox.Location = new System.Drawing.Point(26, 131);
            this.filtraImpiantiGroupBox.Name = "filtraImpiantiGroupBox";
            this.filtraImpiantiGroupBox.Size = new System.Drawing.Size(689, 264);
            this.filtraImpiantiGroupBox.TabIndex = 1;
            this.filtraImpiantiGroupBox.TabStop = false;
            this.filtraImpiantiGroupBox.Text = " Filtra Impianti ";
            // 
            // filtraButton
            // 
            this.filtraButton.BackColor = System.Drawing.Color.LightGray;
            this.filtraButton.FlatAppearance.BorderSize = 0;
            this.filtraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtraButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtraButton.Location = new System.Drawing.Point(565, 214);
            this.filtraButton.Name = "filtraButton";
            this.filtraButton.Size = new System.Drawing.Size(101, 26);
            this.filtraButton.TabIndex = 5;
            this.filtraButton.Text = "Filtra";
            this.filtraButton.UseVisualStyleBackColor = false;
            this.filtraButton.Click += new System.EventHandler(this.filtraButton_Click);
            // 
            // tipoFiltroTabControl
            // 
            this.tipoFiltroTabControl.Controls.Add(this.filtroPerNomeTabPage);
            this.tipoFiltroTabControl.Controls.Add(this.filtroPerPrezzoTabPage);
            this.tipoFiltroTabControl.Controls.Add(this.filtroPerTipoPisteTabPage);
            this.tipoFiltroTabControl.Controls.Add(this.filtroPerCaratteristicaTabPage);
            this.tipoFiltroTabControl.Font = new System.Drawing.Font("Calibri", 9F);
            this.tipoFiltroTabControl.Location = new System.Drawing.Point(6, 166);
            this.tipoFiltroTabControl.Name = "tipoFiltroTabControl";
            this.tipoFiltroTabControl.SelectedIndex = 0;
            this.tipoFiltroTabControl.Size = new System.Drawing.Size(671, 86);
            this.tipoFiltroTabControl.TabIndex = 4;
            // 
            // filtroPerNomeTabPage
            // 
            this.filtroPerNomeTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.filtroPerNomeTabPage.Controls.Add(this.nomeImpiantoFiltroTextBox);
            this.filtroPerNomeTabPage.Controls.Add(this.myLabel7);
            this.filtroPerNomeTabPage.Location = new System.Drawing.Point(4, 23);
            this.filtroPerNomeTabPage.Name = "filtroPerNomeTabPage";
            this.filtroPerNomeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.filtroPerNomeTabPage.Size = new System.Drawing.Size(663, 59);
            this.filtroPerNomeTabPage.TabIndex = 0;
            this.filtroPerNomeTabPage.Text = "Filtro Per Nome";
            // 
            // nomeImpiantoFiltroTextBox
            // 
            this.nomeImpiantoFiltroTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.nomeImpiantoFiltroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeImpiantoFiltroTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeImpiantoFiltroTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.nomeImpiantoFiltroTextBox.Location = new System.Drawing.Point(98, 23);
            this.nomeImpiantoFiltroTextBox.Name = "nomeImpiantoFiltroTextBox";
            this.nomeImpiantoFiltroTextBox.Size = new System.Drawing.Size(417, 17);
            this.nomeImpiantoFiltroTextBox.TabIndex = 1;
            // 
            // myLabel7
            // 
            this.myLabel7.AutoSize = true;
            this.myLabel7.BackColor = System.Drawing.Color.Transparent;
            this.myLabel7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel7.Location = new System.Drawing.Point(18, 23);
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.Size = new System.Drawing.Size(42, 17);
            this.myLabel7.TabIndex = 0;
            this.myLabel7.Text = "Nome";
            // 
            // filtroPerPrezzoTabPage
            // 
            this.filtroPerPrezzoTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.filtroPerPrezzoTabPage.Controls.Add(this.prezzoMassimoFiltroTextBox);
            this.filtroPerPrezzoTabPage.Controls.Add(this.myLabel8);
            this.filtroPerPrezzoTabPage.Location = new System.Drawing.Point(4, 23);
            this.filtroPerPrezzoTabPage.Name = "filtroPerPrezzoTabPage";
            this.filtroPerPrezzoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.filtroPerPrezzoTabPage.Size = new System.Drawing.Size(663, 59);
            this.filtroPerPrezzoTabPage.TabIndex = 1;
            this.filtroPerPrezzoTabPage.Text = "Filtro Per Prezzo";
            // 
            // prezzoMassimoFiltroTextBox
            // 
            this.prezzoMassimoFiltroTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.prezzoMassimoFiltroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prezzoMassimoFiltroTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezzoMassimoFiltroTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.prezzoMassimoFiltroTextBox.Location = new System.Drawing.Point(146, 25);
            this.prezzoMassimoFiltroTextBox.Name = "prezzoMassimoFiltroTextBox";
            this.prezzoMassimoFiltroTextBox.Size = new System.Drawing.Size(366, 17);
            this.prezzoMassimoFiltroTextBox.TabIndex = 1;
            // 
            // myLabel8
            // 
            this.myLabel8.AutoSize = true;
            this.myLabel8.BackColor = System.Drawing.Color.Transparent;
            this.myLabel8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel8.Location = new System.Drawing.Point(16, 25);
            this.myLabel8.Name = "myLabel8";
            this.myLabel8.Size = new System.Drawing.Size(99, 17);
            this.myLabel8.TabIndex = 0;
            this.myLabel8.Text = "Prezzo Massimo";
            // 
            // filtroPerTipoPisteTabPage
            // 
            this.filtroPerTipoPisteTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.filtroPerTipoPisteTabPage.Controls.Add(this.tipologiaPistaFiltroComboBox);
            this.filtroPerTipoPisteTabPage.Controls.Add(this.myLabel10);
            this.filtroPerTipoPisteTabPage.Controls.Add(this.numeroPisteFiltroTextBox);
            this.filtroPerTipoPisteTabPage.Controls.Add(this.myLabel9);
            this.filtroPerTipoPisteTabPage.Location = new System.Drawing.Point(4, 23);
            this.filtroPerTipoPisteTabPage.Name = "filtroPerTipoPisteTabPage";
            this.filtroPerTipoPisteTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.filtroPerTipoPisteTabPage.Size = new System.Drawing.Size(663, 59);
            this.filtroPerTipoPisteTabPage.TabIndex = 2;
            this.filtroPerTipoPisteTabPage.Text = "Filtro Per Tipo Piste";
            // 
            // tipologiaPistaFiltroComboBox
            // 
            this.tipologiaPistaFiltroComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.tipologiaPistaFiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipologiaPistaFiltroComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipologiaPistaFiltroComboBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipologiaPistaFiltroComboBox.FormattingEnabled = true;
            this.tipologiaPistaFiltroComboBox.Location = new System.Drawing.Point(354, 20);
            this.tipologiaPistaFiltroComboBox.Name = "tipologiaPistaFiltroComboBox";
            this.tipologiaPistaFiltroComboBox.Size = new System.Drawing.Size(151, 22);
            this.tipologiaPistaFiltroComboBox.TabIndex = 3;
            // 
            // myLabel10
            // 
            this.myLabel10.AutoSize = true;
            this.myLabel10.BackColor = System.Drawing.Color.Transparent;
            this.myLabel10.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel10.Location = new System.Drawing.Point(291, 25);
            this.myLabel10.Name = "myLabel10";
            this.myLabel10.Size = new System.Drawing.Size(35, 17);
            this.myLabel10.TabIndex = 2;
            this.myLabel10.Text = "Piste";
            // 
            // numeroPisteFiltroTextBox
            // 
            this.numeroPisteFiltroTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.numeroPisteFiltroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numeroPisteFiltroTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroPisteFiltroTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.numeroPisteFiltroTextBox.Location = new System.Drawing.Point(98, 25);
            this.numeroPisteFiltroTextBox.Name = "numeroPisteFiltroTextBox";
            this.numeroPisteFiltroTextBox.Size = new System.Drawing.Size(173, 17);
            this.numeroPisteFiltroTextBox.TabIndex = 1;
            // 
            // myLabel9
            // 
            this.myLabel9.AutoSize = true;
            this.myLabel9.BackColor = System.Drawing.Color.Transparent;
            this.myLabel9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel9.Location = new System.Drawing.Point(7, 25);
            this.myLabel9.Name = "myLabel9";
            this.myLabel9.Size = new System.Drawing.Size(51, 17);
            this.myLabel9.TabIndex = 0;
            this.myLabel9.Text = "Almeno";
            // 
            // filtroPerCaratteristicaTabPage
            // 
            this.filtroPerCaratteristicaTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.filtroPerCaratteristicaTabPage.Controls.Add(this.caratteristicaSpecificaAlmenoFiltroTextBox);
            this.filtroPerCaratteristicaTabPage.Controls.Add(this.myLabel11);
            this.filtroPerCaratteristicaTabPage.Controls.Add(this.caratteristicaSpecificaFiltroComboBox);
            this.filtroPerCaratteristicaTabPage.Location = new System.Drawing.Point(4, 23);
            this.filtroPerCaratteristicaTabPage.Name = "filtroPerCaratteristicaTabPage";
            this.filtroPerCaratteristicaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.filtroPerCaratteristicaTabPage.Size = new System.Drawing.Size(663, 59);
            this.filtroPerCaratteristicaTabPage.TabIndex = 3;
            this.filtroPerCaratteristicaTabPage.Text = "Filtro Per Caratteristica";
            // 
            // caratteristicaSpecificaAlmenoFiltroTextBox
            // 
            this.caratteristicaSpecificaAlmenoFiltroTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.caratteristicaSpecificaAlmenoFiltroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.caratteristicaSpecificaAlmenoFiltroTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caratteristicaSpecificaAlmenoFiltroTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.caratteristicaSpecificaAlmenoFiltroTextBox.Location = new System.Drawing.Point(335, 23);
            this.caratteristicaSpecificaAlmenoFiltroTextBox.Name = "caratteristicaSpecificaAlmenoFiltroTextBox";
            this.caratteristicaSpecificaAlmenoFiltroTextBox.Size = new System.Drawing.Size(177, 17);
            this.caratteristicaSpecificaAlmenoFiltroTextBox.TabIndex = 2;
            // 
            // myLabel11
            // 
            this.myLabel11.AutoSize = true;
            this.myLabel11.BackColor = System.Drawing.Color.Transparent;
            this.myLabel11.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel11.Location = new System.Drawing.Point(243, 23);
            this.myLabel11.Name = "myLabel11";
            this.myLabel11.Size = new System.Drawing.Size(51, 17);
            this.myLabel11.TabIndex = 1;
            this.myLabel11.Text = "Almeno";
            // 
            // caratteristicaSpecificaFiltroComboBox
            // 
            this.caratteristicaSpecificaFiltroComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.caratteristicaSpecificaFiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.caratteristicaSpecificaFiltroComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caratteristicaSpecificaFiltroComboBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caratteristicaSpecificaFiltroComboBox.FormattingEnabled = true;
            this.caratteristicaSpecificaFiltroComboBox.Location = new System.Drawing.Point(25, 19);
            this.caratteristicaSpecificaFiltroComboBox.Name = "caratteristicaSpecificaFiltroComboBox";
            this.caratteristicaSpecificaFiltroComboBox.Size = new System.Drawing.Size(195, 22);
            this.caratteristicaSpecificaFiltroComboBox.TabIndex = 0;
            this.caratteristicaSpecificaFiltroComboBox.SelectedIndexChanged += new System.EventHandler(this.caratteristicaSpecificaFiltroComboBox_SelectedIndexChanged);
            // 
            // caratteristicaSpecificaRadioButton
            // 
            this.caratteristicaSpecificaRadioButton.AutoSize = true;
            this.caratteristicaSpecificaRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caratteristicaSpecificaRadioButton.Location = new System.Drawing.Point(10, 122);
            this.caratteristicaSpecificaRadioButton.Name = "caratteristicaSpecificaRadioButton";
            this.caratteristicaSpecificaRadioButton.Size = new System.Drawing.Size(221, 21);
            this.caratteristicaSpecificaRadioButton.TabIndex = 3;
            this.caratteristicaSpecificaRadioButton.TabStop = true;
            this.caratteristicaSpecificaRadioButton.Text = "Con caratteristica specifica almeno";
            this.caratteristicaSpecificaRadioButton.UseVisualStyleBackColor = true;
            this.caratteristicaSpecificaRadioButton.CheckedChanged += new System.EventHandler(this.caratteristicaSpecificaRadioButton_CheckedChanged);
            // 
            // nPisteDiTipoRadioButton
            // 
            this.nPisteDiTipoRadioButton.AutoSize = true;
            this.nPisteDiTipoRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPisteDiTipoRadioButton.Location = new System.Drawing.Point(10, 94);
            this.nPisteDiTipoRadioButton.Name = "nPisteDiTipoRadioButton";
            this.nPisteDiTipoRadioButton.Size = new System.Drawing.Size(170, 21);
            this.nPisteDiTipoRadioButton.TabIndex = 2;
            this.nPisteDiTipoRadioButton.TabStop = true;
            this.nPisteDiTipoRadioButton.Text = "Con almeno n piste di tipo";
            this.nPisteDiTipoRadioButton.UseVisualStyleBackColor = true;
            this.nPisteDiTipoRadioButton.CheckedChanged += new System.EventHandler(this.nPisteDiTipoRadioButton_CheckedChanged);
            // 
            // prezzoMassimoRadioButton
            // 
            this.prezzoMassimoRadioButton.AutoSize = true;
            this.prezzoMassimoRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezzoMassimoRadioButton.Location = new System.Drawing.Point(10, 66);
            this.prezzoMassimoRadioButton.Name = "prezzoMassimoRadioButton";
            this.prezzoMassimoRadioButton.Size = new System.Drawing.Size(164, 21);
            this.prezzoMassimoRadioButton.TabIndex = 1;
            this.prezzoMassimoRadioButton.TabStop = true;
            this.prezzoMassimoRadioButton.Text = "Prezzo al massimo pari a";
            this.prezzoMassimoRadioButton.UseVisualStyleBackColor = true;
            this.prezzoMassimoRadioButton.CheckedChanged += new System.EventHandler(this.prezzoMassimoRadioButton_CheckedChanged);
            // 
            // perNomeRadioButton
            // 
            this.perNomeRadioButton.AutoSize = true;
            this.perNomeRadioButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perNomeRadioButton.Location = new System.Drawing.Point(10, 38);
            this.perNomeRadioButton.Name = "perNomeRadioButton";
            this.perNomeRadioButton.Size = new System.Drawing.Size(80, 21);
            this.perNomeRadioButton.TabIndex = 0;
            this.perNomeRadioButton.TabStop = true;
            this.perNomeRadioButton.Text = "Per nome";
            this.perNomeRadioButton.UseVisualStyleBackColor = true;
            this.perNomeRadioButton.CheckedChanged += new System.EventHandler(this.perNomeRadioButton_CheckedChanged);
            // 
            // tipoSkipassTabControl
            // 
            this.tipoSkipassTabControl.Controls.Add(this.skipassAGiornataTabPage);
            this.tipoSkipassTabControl.Controls.Add(this.skipassAdAccessoTabPage);
            this.tipoSkipassTabControl.Font = new System.Drawing.Font("Calibri", 9F);
            this.tipoSkipassTabControl.Location = new System.Drawing.Point(26, 22);
            this.tipoSkipassTabControl.Name = "tipoSkipassTabControl";
            this.tipoSkipassTabControl.SelectedIndex = 0;
            this.tipoSkipassTabControl.Size = new System.Drawing.Size(689, 86);
            this.tipoSkipassTabControl.TabIndex = 0;
            // 
            // skipassAGiornataTabPage
            // 
            this.skipassAGiornataTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.skipassAGiornataTabPage.Controls.Add(this.skipassAGiornataDataFineTimePicker);
            this.skipassAGiornataTabPage.Controls.Add(this.skipassAGiornataDataInizioTimePicker);
            this.skipassAGiornataTabPage.Controls.Add(this.myLabel4);
            this.skipassAGiornataTabPage.Controls.Add(this.myLabel3);
            this.skipassAGiornataTabPage.Location = new System.Drawing.Point(4, 23);
            this.skipassAGiornataTabPage.Name = "skipassAGiornataTabPage";
            this.skipassAGiornataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.skipassAGiornataTabPage.Size = new System.Drawing.Size(681, 59);
            this.skipassAGiornataTabPage.TabIndex = 0;
            this.skipassAGiornataTabPage.Text = "Skipass A Giornata";
            // 
            // skipassAGiornataDataFineTimePicker
            // 
            this.skipassAGiornataDataFineTimePicker.Location = new System.Drawing.Point(443, 15);
            this.skipassAGiornataDataFineTimePicker.Name = "skipassAGiornataDataFineTimePicker";
            this.skipassAGiornataDataFineTimePicker.Size = new System.Drawing.Size(226, 22);
            this.skipassAGiornataDataFineTimePicker.TabIndex = 3;
            // 
            // skipassAGiornataDataInizioTimePicker
            // 
            this.skipassAGiornataDataInizioTimePicker.Location = new System.Drawing.Point(86, 15);
            this.skipassAGiornataDataInizioTimePicker.Name = "skipassAGiornataDataInizioTimePicker";
            this.skipassAGiornataDataInizioTimePicker.Size = new System.Drawing.Size(226, 22);
            this.skipassAGiornataDataInizioTimePicker.TabIndex = 2;
            this.skipassAGiornataDataInizioTimePicker.ValueChanged += new System.EventHandler(this.skipassAGiornataDataInizioTimePicker_ValueChanged);
            // 
            // myLabel4
            // 
            this.myLabel4.AutoSize = true;
            this.myLabel4.BackColor = System.Drawing.Color.Transparent;
            this.myLabel4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel4.Location = new System.Drawing.Point(366, 20);
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.Size = new System.Drawing.Size(19, 17);
            this.myLabel4.TabIndex = 1;
            this.myLabel4.Text = "Al";
            // 
            // myLabel3
            // 
            this.myLabel3.AutoSize = true;
            this.myLabel3.BackColor = System.Drawing.Color.Transparent;
            this.myLabel3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel3.Location = new System.Drawing.Point(28, 19);
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.Size = new System.Drawing.Size(27, 17);
            this.myLabel3.TabIndex = 0;
            this.myLabel3.Text = "Dal";
            // 
            // skipassAdAccessoTabPage
            // 
            this.skipassAdAccessoTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.skipassAdAccessoTabPage.Controls.Add(this.skipassAdAccessoDataInizioTimePicker);
            this.skipassAdAccessoTabPage.Controls.Add(this.numeroAccessiTextBox);
            this.skipassAdAccessoTabPage.Controls.Add(this.myLabel6);
            this.skipassAdAccessoTabPage.Controls.Add(this.myLabel5);
            this.skipassAdAccessoTabPage.Location = new System.Drawing.Point(4, 23);
            this.skipassAdAccessoTabPage.Name = "skipassAdAccessoTabPage";
            this.skipassAdAccessoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.skipassAdAccessoTabPage.Size = new System.Drawing.Size(681, 59);
            this.skipassAdAccessoTabPage.TabIndex = 1;
            this.skipassAdAccessoTabPage.Text = "Skipass Ad Accesso";
            // 
            // skipassAdAccessoDataInizioTimePicker
            // 
            this.skipassAdAccessoDataInizioTimePicker.Location = new System.Drawing.Point(450, 13);
            this.skipassAdAccessoDataInizioTimePicker.Name = "skipassAdAccessoDataInizioTimePicker";
            this.skipassAdAccessoDataInizioTimePicker.Size = new System.Drawing.Size(223, 22);
            this.skipassAdAccessoDataInizioTimePicker.TabIndex = 3;
            // 
            // numeroAccessiTextBox
            // 
            this.numeroAccessiTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.numeroAccessiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numeroAccessiTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroAccessiTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.numeroAccessiTextBox.Location = new System.Drawing.Point(138, 17);
            this.numeroAccessiTextBox.Name = "numeroAccessiTextBox";
            this.numeroAccessiTextBox.Size = new System.Drawing.Size(188, 17);
            this.numeroAccessiTextBox.TabIndex = 2;
            // 
            // myLabel6
            // 
            this.myLabel6.AutoSize = true;
            this.myLabel6.BackColor = System.Drawing.Color.Transparent;
            this.myLabel6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel6.Location = new System.Drawing.Point(365, 17);
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.Size = new System.Drawing.Size(64, 17);
            this.myLabel6.TabIndex = 1;
            this.myLabel6.Text = "Valido Dal";
            // 
            // myLabel5
            // 
            this.myLabel5.AutoSize = true;
            this.myLabel5.BackColor = System.Drawing.Color.Transparent;
            this.myLabel5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel5.Location = new System.Drawing.Point(11, 17);
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.Size = new System.Drawing.Size(97, 17);
            this.myLabel5.TabIndex = 0;
            this.myLabel5.Text = "Numero Accessi";
            // 
            // annullaButton
            // 
            this.annullaButton.BackColor = System.Drawing.Color.LightGray;
            this.annullaButton.FlatAppearance.BorderSize = 0;
            this.annullaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annullaButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annullaButton.Location = new System.Drawing.Point(43, 689);
            this.annullaButton.Name = "annullaButton";
            this.annullaButton.Size = new System.Drawing.Size(122, 26);
            this.annullaButton.TabIndex = 6;
            this.annullaButton.Text = "Annulla";
            this.annullaButton.UseVisualStyleBackColor = false;
            this.annullaButton.Click += new System.EventHandler(this.annullaButton_Click);
            // 
            // AggiungiSkipassButton
            // 
            this.AggiungiSkipassButton.BackColor = System.Drawing.Color.LightGray;
            this.AggiungiSkipassButton.FlatAppearance.BorderSize = 0;
            this.AggiungiSkipassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AggiungiSkipassButton.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AggiungiSkipassButton.Location = new System.Drawing.Point(568, 689);
            this.AggiungiSkipassButton.Name = "AggiungiSkipassButton";
            this.AggiungiSkipassButton.Size = new System.Drawing.Size(122, 26);
            this.AggiungiSkipassButton.TabIndex = 5;
            this.AggiungiSkipassButton.Text = "Aggiungi";
            this.AggiungiSkipassButton.UseVisualStyleBackColor = false;
            this.AggiungiSkipassButton.Click += new System.EventHandler(this.AggiungiSkipassButton_Click);
            // 
            // tipologiaSkipassComboBox
            // 
            this.tipologiaSkipassComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.tipologiaSkipassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipologiaSkipassComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipologiaSkipassComboBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipologiaSkipassComboBox.FormattingEnabled = true;
            this.tipologiaSkipassComboBox.Location = new System.Drawing.Point(517, 31);
            this.tipologiaSkipassComboBox.Name = "tipologiaSkipassComboBox";
            this.tipologiaSkipassComboBox.Size = new System.Drawing.Size(196, 22);
            this.tipologiaSkipassComboBox.TabIndex = 3;
            this.tipologiaSkipassComboBox.SelectedIndexChanged += new System.EventHandler(this.tipologiaSkipassComboBox_SelectedIndexChanged);
            // 
            // codiceSkipassTextBox
            // 
            this.codiceSkipassTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.codiceSkipassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codiceSkipassTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codiceSkipassTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.codiceSkipassTextBox.Location = new System.Drawing.Point(94, 31);
            this.codiceSkipassTextBox.Name = "codiceSkipassTextBox";
            this.codiceSkipassTextBox.Size = new System.Drawing.Size(210, 17);
            this.codiceSkipassTextBox.TabIndex = 2;
            // 
            // myLabel2
            // 
            this.myLabel2.AutoSize = true;
            this.myLabel2.BackColor = System.Drawing.Color.Transparent;
            this.myLabel2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel2.Location = new System.Drawing.Point(438, 31);
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.Size = new System.Drawing.Size(59, 17);
            this.myLabel2.TabIndex = 1;
            this.myLabel2.Text = "Tipologia";
            // 
            // myLabel1
            // 
            this.myLabel1.AutoSize = true;
            this.myLabel1.BackColor = System.Drawing.Color.Transparent;
            this.myLabel1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.myLabel1.Location = new System.Drawing.Point(32, 31);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(45, 17);
            this.myLabel1.TabIndex = 0;
            this.myLabel1.Text = "Codice";
            // 
            // AggiungiModificaSkipass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(742, 727);
            this.Controls.Add(this.annullaButton);
            this.Controls.Add(this.AggiungiSkipassButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tipologiaSkipassComboBox);
            this.Controls.Add(this.codiceSkipassTextBox);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.myLabel1);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AggiungiModificaSkipass";
            this.Text = "Aggiungi Skipass";
            this.Load += new System.EventHandler(this.AggiungiModificaSkipass_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.impiantiDataGridView)).EndInit();
            this.filtraImpiantiGroupBox.ResumeLayout(false);
            this.filtraImpiantiGroupBox.PerformLayout();
            this.tipoFiltroTabControl.ResumeLayout(false);
            this.filtroPerNomeTabPage.ResumeLayout(false);
            this.filtroPerNomeTabPage.PerformLayout();
            this.filtroPerPrezzoTabPage.ResumeLayout(false);
            this.filtroPerPrezzoTabPage.PerformLayout();
            this.filtroPerTipoPisteTabPage.ResumeLayout(false);
            this.filtroPerTipoPisteTabPage.PerformLayout();
            this.filtroPerCaratteristicaTabPage.ResumeLayout(false);
            this.filtroPerCaratteristicaTabPage.PerformLayout();
            this.tipoSkipassTabControl.ResumeLayout(false);
            this.skipassAGiornataTabPage.ResumeLayout(false);
            this.skipassAGiornataTabPage.PerformLayout();
            this.skipassAdAccessoTabPage.ResumeLayout(false);
            this.skipassAdAccessoTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.MyLabel myLabel1;
        private Components.MyLabel myLabel2;
        private Components.MyTextBox codiceSkipassTextBox;
        private Components.MyComboBox tipologiaSkipassComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox filtraImpiantiGroupBox;
        private Components.TabControlWithoutHeader tipoSkipassTabControl;
        private System.Windows.Forms.TabPage skipassAGiornataTabPage;
        private System.Windows.Forms.TabPage skipassAdAccessoTabPage;
        private Components.TabControlWithoutHeader tipoFiltroTabControl;
        private System.Windows.Forms.TabPage filtroPerNomeTabPage;
        private System.Windows.Forms.TabPage filtroPerPrezzoTabPage;
        private System.Windows.Forms.RadioButton caratteristicaSpecificaRadioButton;
        private System.Windows.Forms.RadioButton nPisteDiTipoRadioButton;
        private System.Windows.Forms.RadioButton prezzoMassimoRadioButton;
        private System.Windows.Forms.RadioButton perNomeRadioButton;
        private Components.MyButton visualizzaDettagliImpiantoButton;
        private Components.MyDataGridView impiantiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versanteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPisteAlpineColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPisteDiFodnoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPisteSnowparkColumn;
        private Components.MyButton filtraButton;
        private Components.MyTextBox nomeImpiantoFiltroTextBox;
        private Components.MyLabel myLabel7;
        private Components.MyTextBox prezzoMassimoFiltroTextBox;
        private Components.MyLabel myLabel8;
        private System.Windows.Forms.TabPage filtroPerTipoPisteTabPage;
        private Components.MyComboBox tipologiaPistaFiltroComboBox;
        private Components.MyLabel myLabel10;
        private Components.MyTextBox numeroPisteFiltroTextBox;
        private Components.MyLabel myLabel9;
        private System.Windows.Forms.TabPage filtroPerCaratteristicaTabPage;
        private Components.MyTextBox caratteristicaSpecificaAlmenoFiltroTextBox;
        private Components.MyLabel myLabel11;
        private Components.MyComboBox caratteristicaSpecificaFiltroComboBox;
        private System.Windows.Forms.DateTimePicker skipassAGiornataDataFineTimePicker;
        private System.Windows.Forms.DateTimePicker skipassAGiornataDataInizioTimePicker;
        private Components.MyLabel myLabel4;
        private Components.MyLabel myLabel3;
        private System.Windows.Forms.DateTimePicker skipassAdAccessoDataInizioTimePicker;
        private Components.MyTextBox numeroAccessiTextBox;
        private Components.MyLabel myLabel6;
        private Components.MyLabel myLabel5;
        private Components.MyButton AggiungiSkipassButton;
        private Components.MyButton annullaButton;
    }
}