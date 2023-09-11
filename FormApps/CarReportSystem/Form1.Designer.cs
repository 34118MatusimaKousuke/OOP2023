
namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label3;
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.gbMaker = new System.Windows.Forms.GroupBox();
            this.rbDaihatu = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbSuzuki = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbImported = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.dgvCarReports = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.carReportTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202314DataSet = new CarReportSystem.infosys202314DataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btImageOpen = new System.Windows.Forms.Button();
            this.btImageDelete = new System.Windows.Forms.Button();
            this.pbCarImage = new System.Windows.Forms.PictureBox();
            this.btAddReport = new System.Windows.Forms.Button();
            this.btDeleteReport = new System.Windows.Forms.Button();
            this.btModifyReport = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.色設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdImageFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsInfoText = new System.Windows.Forms.ToolStripStatusLabel();
            this.cdColor = new System.Windows.Forms.ColorDialog();
            this.btScaleChange = new System.Windows.Forms.Button();
            this.tmTimeUpdate = new System.Windows.Forms.Timer(this.components);
            this.ofdCarRepoOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdCarRepoSave = new System.Windows.Forms.SaveFileDialog();
            this.carReportTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.carReportTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btConnection = new System.Windows.Forms.Button();
            this.carReportTableTableAdapter = new CarReportSystem.infosys202314DataSetTableAdapters.CarReportTableTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202314DataSetTableAdapters.TableAdapterManager();
            label3 = new System.Windows.Forms.Label();
            this.gbMaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202314DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportTableBindingNavigator)).BeginInit();
            this.carReportTableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(57, 177);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 12);
            label3.TabIndex = 4;
            label3.Text = "メーカー：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(143, 83);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(311, 19);
            this.dtpDate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "記録者：";
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(143, 125);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(311, 20);
            this.cbAuthor.TabIndex = 1;
            // 
            // gbMaker
            // 
            this.gbMaker.Controls.Add(this.rbDaihatu);
            this.gbMaker.Controls.Add(this.rbNissan);
            this.gbMaker.Controls.Add(this.rbSuzuki);
            this.gbMaker.Controls.Add(this.rbOther);
            this.gbMaker.Controls.Add(this.rbSubaru);
            this.gbMaker.Controls.Add(this.rbImported);
            this.gbMaker.Controls.Add(this.rbHonda);
            this.gbMaker.Controls.Add(this.rbToyota);
            this.gbMaker.Location = new System.Drawing.Point(143, 177);
            this.gbMaker.Name = "gbMaker";
            this.gbMaker.Size = new System.Drawing.Size(311, 89);
            this.gbMaker.TabIndex = 2;
            this.gbMaker.TabStop = false;
            // 
            // rbDaihatu
            // 
            this.rbDaihatu.AutoSize = true;
            this.rbDaihatu.Location = new System.Drawing.Point(154, 56);
            this.rbDaihatu.Name = "rbDaihatu";
            this.rbDaihatu.Size = new System.Drawing.Size(60, 16);
            this.rbDaihatu.TabIndex = 8;
            this.rbDaihatu.TabStop = true;
            this.rbDaihatu.Tag = "5";
            this.rbDaihatu.Text = "ダイハツ";
            this.rbDaihatu.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(68, 18);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 3;
            this.rbNissan.TabStop = true;
            this.rbNissan.Tag = "1";
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbSuzuki
            // 
            this.rbSuzuki.AutoSize = true;
            this.rbSuzuki.Location = new System.Drawing.Point(74, 56);
            this.rbSuzuki.Name = "rbSuzuki";
            this.rbSuzuki.Size = new System.Drawing.Size(52, 16);
            this.rbSuzuki.TabIndex = 7;
            this.rbSuzuki.TabStop = true;
            this.rbSuzuki.Tag = "4";
            this.rbSuzuki.Text = "スズキ";
            this.rbSuzuki.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(243, 56);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(54, 16);
            this.rbOther.TabIndex = 9;
            this.rbOther.TabStop = true;
            this.rbOther.Tag = "7";
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(6, 56);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 6;
            this.rbSubaru.TabStop = true;
            this.rbSubaru.Tag = "3";
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbImported
            // 
            this.rbImported.AutoSize = true;
            this.rbImported.Location = new System.Drawing.Point(237, 18);
            this.rbImported.Name = "rbImported";
            this.rbImported.Size = new System.Drawing.Size(59, 16);
            this.rbImported.TabIndex = 5;
            this.rbImported.TabStop = true;
            this.rbImported.Tag = "6";
            this.rbImported.Text = "輸入車";
            this.rbImported.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(154, 18);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 5;
            this.rbHonda.TabStop = true;
            this.rbHonda.Tag = "2";
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Checked = true;
            this.rbToyota.Location = new System.Drawing.Point(6, 18);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 2;
            this.rbToyota.TabStop = true;
            this.rbToyota.Tag = "0";
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(143, 296);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(311, 20);
            this.cbCarName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "レポート：";
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(143, 337);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(311, 135);
            this.tbReport.TabIndex = 4;
            // 
            // dgvCarReports
            // 
            this.dgvCarReports.AllowUserToAddRows = false;
            this.dgvCarReports.AllowUserToDeleteRows = false;
            this.dgvCarReports.AutoGenerateColumns = false;
            this.dgvCarReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.makerDataGridViewTextBoxColumn,
            this.carNameDataGridViewTextBoxColumn,
            this.reportDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dgvCarReports.DataSource = this.carReportTableBindingSource;
            this.dgvCarReports.Location = new System.Drawing.Point(143, 488);
            this.dgvCarReports.MultiSelect = false;
            this.dgvCarReports.Name = "dgvCarReports";
            this.dgvCarReports.ReadOnly = true;
            this.dgvCarReports.RowTemplate.Height = 21;
            this.dgvCarReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarReports.Size = new System.Drawing.Size(596, 153);
            this.dgvCarReports.TabIndex = 10;
            this.dgvCarReports.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarReports_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // makerDataGridViewTextBoxColumn
            // 
            this.makerDataGridViewTextBoxColumn.DataPropertyName = "Maker";
            this.makerDataGridViewTextBoxColumn.HeaderText = "Maker";
            this.makerDataGridViewTextBoxColumn.Name = "makerDataGridViewTextBoxColumn";
            this.makerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carNameDataGridViewTextBoxColumn
            // 
            this.carNameDataGridViewTextBoxColumn.DataPropertyName = "CarName";
            this.carNameDataGridViewTextBoxColumn.HeaderText = "CarName";
            this.carNameDataGridViewTextBoxColumn.Name = "carNameDataGridViewTextBoxColumn";
            this.carNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportDataGridViewTextBoxColumn
            // 
            this.reportDataGridViewTextBoxColumn.DataPropertyName = "Report";
            this.reportDataGridViewTextBoxColumn.HeaderText = "Report";
            this.reportDataGridViewTextBoxColumn.Name = "reportDataGridViewTextBoxColumn";
            this.reportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            // 
            // carReportTableBindingSource
            // 
            this.carReportTableBindingSource.DataMember = "CarReportTable";
            this.carReportTableBindingSource.DataSource = this.infosys202314DataSet;
            // 
            // infosys202314DataSet
            // 
            this.infosys202314DataSet.DataSetName = "infosys202314DataSet";
            this.infosys202314DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "記事一覧：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "画像：";
            // 
            // btImageOpen
            // 
            this.btImageOpen.Location = new System.Drawing.Point(501, 83);
            this.btImageOpen.Name = "btImageOpen";
            this.btImageOpen.Size = new System.Drawing.Size(75, 23);
            this.btImageOpen.TabIndex = 5;
            this.btImageOpen.Text = "開く...";
            this.btImageOpen.UseVisualStyleBackColor = true;
            this.btImageOpen.Click += new System.EventHandler(this.btImageOpen_Click);
            // 
            // btImageDelete
            // 
            this.btImageDelete.Location = new System.Drawing.Point(582, 83);
            this.btImageDelete.Name = "btImageDelete";
            this.btImageDelete.Size = new System.Drawing.Size(75, 23);
            this.btImageDelete.TabIndex = 6;
            this.btImageDelete.Text = "削除";
            this.btImageDelete.UseVisualStyleBackColor = true;
            this.btImageDelete.Click += new System.EventHandler(this.btImageDelete_Click);
            // 
            // pbCarImage
            // 
            this.pbCarImage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbCarImage.Location = new System.Drawing.Point(462, 112);
            this.pbCarImage.Name = "pbCarImage";
            this.pbCarImage.Size = new System.Drawing.Size(279, 276);
            this.pbCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCarImage.TabIndex = 15;
            this.pbCarImage.TabStop = false;
            // 
            // btAddReport
            // 
            this.btAddReport.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAddReport.Location = new System.Drawing.Point(462, 394);
            this.btAddReport.Name = "btAddReport";
            this.btAddReport.Size = new System.Drawing.Size(69, 43);
            this.btAddReport.TabIndex = 8;
            this.btAddReport.Text = "追加";
            this.btAddReport.UseVisualStyleBackColor = true;
            this.btAddReport.Click += new System.EventHandler(this.btAddReport_Click);
            // 
            // btDeleteReport
            // 
            this.btDeleteReport.Location = new System.Drawing.Point(670, 394);
            this.btDeleteReport.Name = "btDeleteReport";
            this.btDeleteReport.Size = new System.Drawing.Size(69, 43);
            this.btDeleteReport.TabIndex = 10;
            this.btDeleteReport.Text = "削除";
            this.btDeleteReport.UseVisualStyleBackColor = true;
            this.btDeleteReport.Click += new System.EventHandler(this.btDeleteReport_Click);
            // 
            // btModifyReport
            // 
            this.btModifyReport.Location = new System.Drawing.Point(568, 394);
            this.btModifyReport.Name = "btModifyReport";
            this.btModifyReport.Size = new System.Drawing.Size(69, 43);
            this.btModifyReport.TabIndex = 9;
            this.btModifyReport.Text = "修正";
            this.btModifyReport.UseVisualStyleBackColor = true;
            this.btModifyReport.Click += new System.EventHandler(this.btModifyReport_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem,
            this.toolStripSeparator1,
            this.保存SToolStripMenuItem,
            this.toolStripSeparator2,
            this.終了XToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.開くToolStripMenuItem.Text = "接続(&O)...";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.保存SToolStripMenuItem.Text = "保存(&S)...";
            this.保存SToolStripMenuItem.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.色設定ToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            // 
            // 色設定ToolStripMenuItem
            // 
            this.色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            this.色設定ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.色設定ToolStripMenuItem.Text = "色設定...";
            this.色設定ToolStripMenuItem.Click += new System.EventHandler(this.色設定ToolStripMenuItem_Click);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報ToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // バージョン情報ToolStripMenuItem
            // 
            this.バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem";
            this.バージョン情報ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.バージョン情報ToolStripMenuItem.Text = "バージョン情報";
            this.バージョン情報ToolStripMenuItem.Click += new System.EventHandler(this.バージョン情報ToolStripMenuItem_Click);
            // 
            // ofdImageFileOpen
            // 
            this.ofdImageFileOpen.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTime,
            this.tsInfoText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 654);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(790, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsTime
            // 
            this.tsTime.Name = "tsTime";
            this.tsTime.Size = new System.Drawing.Size(55, 17);
            this.tsTime.Text = "時刻表示";
            // 
            // tsInfoText
            // 
            this.tsInfoText.Name = "tsInfoText";
            this.tsInfoText.Size = new System.Drawing.Size(82, 17);
            this.tsInfoText.Text = "インフォメーション";
            // 
            // btScaleChange
            // 
            this.btScaleChange.Location = new System.Drawing.Point(664, 83);
            this.btScaleChange.Name = "btScaleChange";
            this.btScaleChange.Size = new System.Drawing.Size(75, 23);
            this.btScaleChange.TabIndex = 7;
            this.btScaleChange.Text = "サイズ変更";
            this.btScaleChange.UseVisualStyleBackColor = true;
            this.btScaleChange.Click += new System.EventHandler(this.btScaleChange_Click);
            // 
            // tmTimeUpdate
            // 
            this.tmTimeUpdate.Tick += new System.EventHandler(this.tmTimeUpdate_Tick);
            // 
            // ofdCarRepoOpen
            // 
            this.ofdCarRepoOpen.FileName = "openFileDialog1";
            // 
            // carReportTableBindingNavigator
            // 
            this.carReportTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carReportTableBindingNavigator.BindingSource = this.carReportTableBindingSource;
            this.carReportTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carReportTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carReportTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.carReportTableBindingNavigatorSaveItem});
            this.carReportTableBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.carReportTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carReportTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carReportTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carReportTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carReportTableBindingNavigator.Name = "carReportTableBindingNavigator";
            this.carReportTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carReportTableBindingNavigator.Size = new System.Drawing.Size(790, 25);
            this.carReportTableBindingNavigator.TabIndex = 27;
            this.carReportTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // carReportTableBindingNavigatorSaveItem
            // 
            this.carReportTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carReportTableBindingNavigatorSaveItem.Name = "carReportTableBindingNavigatorSaveItem";
            this.carReportTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.carReportTableBindingNavigatorSaveItem.Text = "データの保存";
            this.carReportTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.carReportTableBindingNavigatorSaveItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "日付：";
            // 
            // btConnection
            // 
            this.btConnection.Location = new System.Drawing.Point(49, 523);
            this.btConnection.Name = "btConnection";
            this.btConnection.Size = new System.Drawing.Size(67, 66);
            this.btConnection.TabIndex = 29;
            this.btConnection.Text = "接続";
            this.btConnection.UseVisualStyleBackColor = true;
            this.btConnection.Click += new System.EventHandler(this.btConnection_Click);
            // 
            // carReportTableTableAdapter
            // 
            this.carReportTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportTableTableAdapter = this.carReportTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202314DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(790, 676);
            this.Controls.Add(this.btConnection);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.carReportTableBindingNavigator);
            this.Controls.Add(this.btScaleChange);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btModifyReport);
            this.Controls.Add(this.btDeleteReport);
            this.Controls.Add(this.btAddReport);
            this.Controls.Add(this.pbCarImage);
            this.Controls.Add(this.btImageDelete);
            this.Controls.Add(this.btImageOpen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvCarReports);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.gbMaker);
            this.Controls.Add(label3);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "カーレポート管理システム";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbMaker.ResumeLayout(false);
            this.gbMaker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202314DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportTableBindingNavigator)).EndInit();
            this.carReportTableBindingNavigator.ResumeLayout(false);
            this.carReportTableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.GroupBox gbMaker;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.RadioButton rbDaihatu;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbSuzuki;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbImported;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.DataGridView dgvCarReports;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btImageOpen;
        private System.Windows.Forms.Button btImageDelete;
        private System.Windows.Forms.PictureBox pbCarImage;
        private System.Windows.Forms.Button btAddReport;
        private System.Windows.Forms.Button btDeleteReport;
        private System.Windows.Forms.Button btModifyReport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog ofdImageFileOpen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsInfoText;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 色設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog cdColor;
        private System.Windows.Forms.Button btScaleChange;
        private System.Windows.Forms.ToolStripStatusLabel tsTime;
        private System.Windows.Forms.Timer tmTimeUpdate;
        private System.Windows.Forms.OpenFileDialog ofdCarRepoOpen;
        private System.Windows.Forms.SaveFileDialog sfdCarRepoSave;
        private infosys202314DataSet infosys202314DataSet;
        private System.Windows.Forms.BindingSource carReportTableBindingSource;
        private infosys202314DataSetTableAdapters.CarReportTableTableAdapter carReportTableTableAdapter;
        private infosys202314DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator carReportTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton carReportTableBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btConnection;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
    }
}

