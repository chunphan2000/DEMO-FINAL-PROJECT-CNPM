
namespace FinalProject
{
    partial class fAccountant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cNPMDataSet = new FinalProject.CNPMDataSet();
            this.cNPMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCCOUNTANTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCCOUNTANTTableAdapter = new FinalProject.CNPMDataSetTableAdapters.ACCOUNTANTTableAdapter();
            this.tExport = new System.Windows.Forms.TabPage();
            this.flpExport = new System.Windows.Forms.FlowLayoutPanel();
            this.IsvExport = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dtgvExport = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnViewExport = new System.Windows.Forms.Button();
            this.dtpkToDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate2 = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numGoodsCount2 = new System.Windows.Forms.NumericUpDown();
            this.btnAddToExport = new System.Windows.Forms.Button();
            this.cbGoods2 = new System.Windows.Forms.ComboBox();
            this.cbCategory2 = new System.Windows.Forms.ComboBox();
            this.tImport = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnViewImport = new System.Windows.Forms.Button();
            this.dtpkToDate1 = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvImport = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flpAdd = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numGoodsCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddToImport = new System.Windows.Forms.Button();
            this.cbGoods = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IsvImport = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabReport = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTANTBindingSource)).BeginInit();
            this.tExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExport)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGoodsCount2)).BeginInit();
            this.tImport.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvImport)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGoodsCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountantToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1117, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountantToolStripMenuItem
            // 
            this.accountantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.accountantToolStripMenuItem.Name = "accountantToolStripMenuItem";
            this.accountantToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.accountantToolStripMenuItem.Text = "Accountant";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Information";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Log Out";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // cNPMDataSet
            // 
            this.cNPMDataSet.DataSetName = "CNPMDataSet";
            this.cNPMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cNPMDataSetBindingSource
            // 
            this.cNPMDataSetBindingSource.DataSource = this.cNPMDataSet;
            this.cNPMDataSetBindingSource.Position = 0;
            // 
            // aCCOUNTANTBindingSource
            // 
            this.aCCOUNTANTBindingSource.DataMember = "ACCOUNTANT";
            this.aCCOUNTANTBindingSource.DataSource = this.cNPMDataSet;
            // 
            // aCCOUNTANTTableAdapter
            // 
            this.aCCOUNTANTTableAdapter.ClearBeforeFill = true;
            // 
            // tExport
            // 
            this.tExport.Controls.Add(this.flpExport);
            this.tExport.Controls.Add(this.IsvExport);
            this.tExport.Controls.Add(this.btnSave2);
            this.tExport.Controls.Add(this.button5);
            this.tExport.Controls.Add(this.button6);
            this.tExport.Controls.Add(this.button7);
            this.tExport.Controls.Add(this.dtgvExport);
            this.tExport.Controls.Add(this.panel5);
            this.tExport.Controls.Add(this.panel4);
            this.tExport.Location = new System.Drawing.Point(4, 25);
            this.tExport.Name = "tExport";
            this.tExport.Padding = new System.Windows.Forms.Padding(3);
            this.tExport.Size = new System.Drawing.Size(1298, 655);
            this.tExport.TabIndex = 1;
            this.tExport.Text = "Export";
            this.tExport.UseVisualStyleBackColor = true;
            // 
            // flpExport
            // 
            this.flpExport.Location = new System.Drawing.Point(582, 401);
            this.flpExport.Name = "flpExport";
            this.flpExport.Size = new System.Drawing.Size(128, 53);
            this.flpExport.TabIndex = 22;
            // 
            // IsvExport
            // 
            this.IsvExport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.IsvExport.GridLines = true;
            this.IsvExport.HideSelection = false;
            this.IsvExport.Location = new System.Drawing.Point(8, 70);
            this.IsvExport.Name = "IsvExport";
            this.IsvExport.Size = new System.Drawing.Size(544, 445);
            this.IsvExport.TabIndex = 21;
            this.IsvExport.UseCompatibleStateImageBehavior = false;
            this.IsvExport.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 170;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Count";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 55;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Price";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Total Price";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 90;
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(589, 486);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(121, 52);
            this.btnSave2.TabIndex = 19;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(783, 487);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 51);
            this.button5.TabIndex = 18;
            this.button5.Text = "Print warehouse receipt";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(783, 401);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 53);
            this.button6.TabIndex = 16;
            this.button6.Text = "Edit";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(965, 401);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 53);
            this.button7.TabIndex = 15;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // dtgvExport
            // 
            this.dtgvExport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvExport.Location = new System.Drawing.Point(564, 50);
            this.dtgvExport.Name = "dtgvExport";
            this.dtgvExport.RowHeadersWidth = 51;
            this.dtgvExport.RowTemplate.Height = 24;
            this.dtgvExport.Size = new System.Drawing.Size(525, 325);
            this.dtgvExport.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnViewExport);
            this.panel5.Controls.Add(this.dtpkToDate2);
            this.panel5.Controls.Add(this.dtpkFromDate2);
            this.panel5.Location = new System.Drawing.Point(561, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(528, 38);
            this.panel5.TabIndex = 13;
            // 
            // btnViewExport
            // 
            this.btnViewExport.Location = new System.Drawing.Point(232, 2);
            this.btnViewExport.Name = "btnViewExport";
            this.btnViewExport.Size = new System.Drawing.Size(61, 33);
            this.btnViewExport.TabIndex = 2;
            this.btnViewExport.Text = "View";
            this.btnViewExport.UseVisualStyleBackColor = true;
            this.btnViewExport.Click += new System.EventHandler(this.btnViewExport_Click);
            // 
            // dtpkToDate2
            // 
            this.dtpkToDate2.Location = new System.Drawing.Point(299, 4);
            this.dtpkToDate2.Name = "dtpkToDate2";
            this.dtpkToDate2.Size = new System.Drawing.Size(226, 22);
            this.dtpkToDate2.TabIndex = 1;
            // 
            // dtpkFromDate2
            // 
            this.dtpkFromDate2.Location = new System.Drawing.Point(4, 4);
            this.dtpkFromDate2.Name = "dtpkFromDate2";
            this.dtpkFromDate2.Size = new System.Drawing.Size(221, 22);
            this.dtpkFromDate2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numGoodsCount2);
            this.panel4.Controls.Add(this.btnAddToExport);
            this.panel4.Controls.Add(this.cbGoods2);
            this.panel4.Controls.Add(this.cbCategory2);
            this.panel4.Location = new System.Drawing.Point(8, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(547, 61);
            this.panel4.TabIndex = 9;
            // 
            // numGoodsCount2
            // 
            this.numGoodsCount2.Location = new System.Drawing.Point(473, 22);
            this.numGoodsCount2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGoodsCount2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numGoodsCount2.Name = "numGoodsCount2";
            this.numGoodsCount2.Size = new System.Drawing.Size(71, 22);
            this.numGoodsCount2.TabIndex = 3;
            this.numGoodsCount2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddToExport
            // 
            this.btnAddToExport.Location = new System.Drawing.Point(376, 7);
            this.btnAddToExport.Name = "btnAddToExport";
            this.btnAddToExport.Size = new System.Drawing.Size(75, 51);
            this.btnAddToExport.TabIndex = 2;
            this.btnAddToExport.Text = "ADD";
            this.btnAddToExport.UseVisualStyleBackColor = true;
            this.btnAddToExport.Click += new System.EventHandler(this.btnAddToExport_Click);
            // 
            // cbGoods2
            // 
            this.cbGoods2.FormattingEnabled = true;
            this.cbGoods2.Location = new System.Drawing.Point(3, 36);
            this.cbGoods2.Name = "cbGoods2";
            this.cbGoods2.Size = new System.Drawing.Size(367, 24);
            this.cbGoods2.TabIndex = 1;
            // 
            // cbCategory2
            // 
            this.cbCategory2.FormattingEnabled = true;
            this.cbCategory2.Location = new System.Drawing.Point(3, 6);
            this.cbCategory2.Name = "cbCategory2";
            this.cbCategory2.Size = new System.Drawing.Size(367, 24);
            this.cbCategory2.TabIndex = 0;
            this.cbCategory2.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // tImport
            // 
            this.tImport.Controls.Add(this.panel6);
            this.tImport.Controls.Add(this.panel3);
            this.tImport.Controls.Add(this.btnSave);
            this.tImport.Controls.Add(this.button1);
            this.tImport.Controls.Add(this.flpAdd);
            this.tImport.Controls.Add(this.panel2);
            this.tImport.Controls.Add(this.panel1);
            this.tImport.Controls.Add(this.btnEdit);
            this.tImport.Controls.Add(this.btnDelete);
            this.tImport.Location = new System.Drawing.Point(4, 25);
            this.tImport.Name = "tImport";
            this.tImport.Padding = new System.Windows.Forms.Padding(3);
            this.tImport.Size = new System.Drawing.Size(1298, 655);
            this.tImport.TabIndex = 0;
            this.tImport.Text = "Import";
            this.tImport.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnViewImport);
            this.panel6.Controls.Add(this.dtpkToDate1);
            this.panel6.Controls.Add(this.dtpkFromDate1);
            this.panel6.Location = new System.Drawing.Point(560, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(528, 38);
            this.panel6.TabIndex = 12;
            // 
            // btnViewImport
            // 
            this.btnViewImport.Location = new System.Drawing.Point(232, 2);
            this.btnViewImport.Name = "btnViewImport";
            this.btnViewImport.Size = new System.Drawing.Size(61, 33);
            this.btnViewImport.TabIndex = 2;
            this.btnViewImport.Text = "View";
            this.btnViewImport.UseVisualStyleBackColor = true;
            this.btnViewImport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // dtpkToDate1
            // 
            this.dtpkToDate1.Location = new System.Drawing.Point(299, 4);
            this.dtpkToDate1.Name = "dtpkToDate1";
            this.dtpkToDate1.Size = new System.Drawing.Size(226, 22);
            this.dtpkToDate1.TabIndex = 1;
            // 
            // dtpkFromDate1
            // 
            this.dtpkFromDate1.Location = new System.Drawing.Point(4, 4);
            this.dtpkFromDate1.Name = "dtpkFromDate1";
            this.dtpkFromDate1.Size = new System.Drawing.Size(221, 22);
            this.dtpkFromDate1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvImport);
            this.panel3.Location = new System.Drawing.Point(559, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(532, 317);
            this.panel3.TabIndex = 11;
            // 
            // dtgvImport
            // 
            this.dtgvImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvImport.Location = new System.Drawing.Point(4, 3);
            this.dtgvImport.Name = "dtgvImport";
            this.dtgvImport.RowHeadersWidth = 51;
            this.dtgvImport.RowTemplate.Height = 24;
            this.dtgvImport.Size = new System.Drawing.Size(525, 325);
            this.dtgvImport.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(584, 480);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 52);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "Print warehouse receipt";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flpAdd
            // 
            this.flpAdd.Location = new System.Drawing.Point(584, 395);
            this.flpAdd.Name = "flpAdd";
            this.flpAdd.Size = new System.Drawing.Size(128, 53);
            this.flpAdd.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numGoodsCount);
            this.panel2.Controls.Add(this.btnAddToImport);
            this.panel2.Controls.Add(this.cbGoods);
            this.panel2.Controls.Add(this.cbCategory);
            this.panel2.Location = new System.Drawing.Point(6, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 61);
            this.panel2.TabIndex = 7;
            // 
            // numGoodsCount
            // 
            this.numGoodsCount.Location = new System.Drawing.Point(473, 22);
            this.numGoodsCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGoodsCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numGoodsCount.Name = "numGoodsCount";
            this.numGoodsCount.Size = new System.Drawing.Size(71, 22);
            this.numGoodsCount.TabIndex = 3;
            this.numGoodsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddToImport
            // 
            this.btnAddToImport.Location = new System.Drawing.Point(376, 7);
            this.btnAddToImport.Name = "btnAddToImport";
            this.btnAddToImport.Size = new System.Drawing.Size(75, 51);
            this.btnAddToImport.TabIndex = 2;
            this.btnAddToImport.Text = "ADD";
            this.btnAddToImport.UseVisualStyleBackColor = true;
            this.btnAddToImport.Click += new System.EventHandler(this.btnAddToImport_Click);
            // 
            // cbGoods
            // 
            this.cbGoods.FormattingEnabled = true;
            this.cbGoods.Location = new System.Drawing.Point(3, 36);
            this.cbGoods.Name = "cbGoods";
            this.cbGoods.Size = new System.Drawing.Size(367, 24);
            this.cbGoods.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 6);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(367, 24);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IsvImport);
            this.panel1.Location = new System.Drawing.Point(6, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 486);
            this.panel1.TabIndex = 6;
            // 
            // IsvImport
            // 
            this.IsvImport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3});
            this.IsvImport.GridLines = true;
            this.IsvImport.HideSelection = false;
            this.IsvImport.Location = new System.Drawing.Point(0, 3);
            this.IsvImport.Name = "IsvImport";
            this.IsvImport.Size = new System.Drawing.Size(544, 445);
            this.IsvImport.TabIndex = 7;
            this.IsvImport.UseCompatibleStateImageBehavior = false;
            this.IsvImport.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 55;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total Price";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 90;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(778, 395);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 53);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(949, 395);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 53);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.tImport);
            this.tabReport.Controls.Add(this.tExport);
            this.tabReport.Location = new System.Drawing.Point(12, 31);
            this.tabReport.Name = "tabReport";
            this.tabReport.SelectedIndex = 0;
            this.tabReport.Size = new System.Drawing.Size(1306, 684);
            this.tabReport.TabIndex = 2;
            // 
            // fAccountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 626);
            this.Controls.Add(this.tabReport);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fAccountant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acountant Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTANTBindingSource)).EndInit();
            this.tExport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExport)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numGoodsCount2)).EndInit();
            this.tImport.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvImport)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numGoodsCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.BindingSource cNPMDataSetBindingSource;
        private CNPMDataSet cNPMDataSet;
        private System.Windows.Forms.BindingSource aCCOUNTANTBindingSource;
        private CNPMDataSetTableAdapters.ACCOUNTANTTableAdapter aCCOUNTANTTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.TabPage tExport;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dtgvExport;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnViewExport;
        private System.Windows.Forms.DateTimePicker dtpkToDate2;
        private System.Windows.Forms.DateTimePicker dtpkFromDate2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numGoodsCount2;
        private System.Windows.Forms.Button btnAddToExport;
        private System.Windows.Forms.ComboBox cbGoods2;
        private System.Windows.Forms.ComboBox cbCategory2;
        private System.Windows.Forms.TabPage tImport;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnViewImport;
        private System.Windows.Forms.DateTimePicker dtpkToDate1;
        private System.Windows.Forms.DateTimePicker dtpkFromDate1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvImport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numGoodsCount;
        private System.Windows.Forms.Button btnAddToImport;
        private System.Windows.Forms.ComboBox cbGoods;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView IsvImport;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabControl tabReport;
        private System.Windows.Forms.FlowLayoutPanel flpAdd;
        private System.Windows.Forms.FlowLayoutPanel flpExport;
        private System.Windows.Forms.ListView IsvExport;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}

