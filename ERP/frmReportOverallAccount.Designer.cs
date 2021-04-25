
namespace ERP
{
    partial class frmReportOverallAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportOverallAccount));
            this.pnlPrinting = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlSaleReport = new System.Windows.Forms.Panel();
            this.tblLayPnlSaleView = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlGridView = new System.Windows.Forms.Panel();
            this.dataGridViewAccount = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payDiscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duePayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOverallAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new ERP.AppData();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tblOverallAccountTableAdapter = new ERP.AppDataTableAdapters.tblOverallAccountTableAdapter();
            this.pnlPrinting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlSaleReport.SuspendLayout();
            this.tblLayPnlSaleView.SuspendLayout();
            this.pnlGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOverallAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrinting
            // 
            this.pnlPrinting.Controls.Add(this.tableLayoutPanel1);
            this.pnlPrinting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrinting.Location = new System.Drawing.Point(0, 0);
            this.pnlPrinting.Name = "pnlPrinting";
            this.pnlPrinting.Size = new System.Drawing.Size(550, 450);
            this.pnlPrinting.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.bunifuCustomLabel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 450);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(199, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(151, 44);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Print View";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(30, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 372);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERP.Reports.rptSalesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(489, 372);
            this.reportViewer1.TabIndex = 0;
            // 
            // pnlSaleReport
            // 
            this.pnlSaleReport.Controls.Add(this.tblLayPnlSaleView);
            this.pnlSaleReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSaleReport.Location = new System.Drawing.Point(0, 0);
            this.pnlSaleReport.Name = "pnlSaleReport";
            this.pnlSaleReport.Size = new System.Drawing.Size(550, 450);
            this.pnlSaleReport.TabIndex = 3;
            // 
            // tblLayPnlSaleView
            // 
            this.tblLayPnlSaleView.ColumnCount = 3;
            this.tblLayPnlSaleView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblLayPnlSaleView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tblLayPnlSaleView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblLayPnlSaleView.Controls.Add(this.lblTitle, 1, 0);
            this.tblLayPnlSaleView.Controls.Add(this.pnlGridView, 1, 2);
            this.tblLayPnlSaleView.Controls.Add(this.panel1, 1, 1);
            this.tblLayPnlSaleView.Controls.Add(this.btnPrint, 1, 3);
            this.tblLayPnlSaleView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayPnlSaleView.Location = new System.Drawing.Point(0, 0);
            this.tblLayPnlSaleView.Name = "tblLayPnlSaleView";
            this.tblLayPnlSaleView.RowCount = 4;
            this.tblLayPnlSaleView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayPnlSaleView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblLayPnlSaleView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblLayPnlSaleView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayPnlSaleView.Size = new System.Drawing.Size(550, 450);
            this.tblLayPnlSaleView.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(151, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(247, 40);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "ACCOUNTS VIEW";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGridView
            // 
            this.pnlGridView.Controls.Add(this.dataGridViewAccount);
            this.pnlGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridView.Location = new System.Drawing.Point(30, 88);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Size = new System.Drawing.Size(489, 318);
            this.pnlGridView.TabIndex = 1;
            // 
            // dataGridViewAccount
            // 
            this.dataGridViewAccount.AllowCustomTheming = true;
            this.dataGridViewAccount.AllowUserToAddRows = false;
            this.dataGridViewAccount.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAccount.AutoGenerateColumns = false;
            this.dataGridViewAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAccount.ColumnHeadersHeight = 40;
            this.dataGridViewAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pPriceDataGridViewTextBoxColumn,
            this.sPriceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.payDiscDataGridViewTextBoxColumn,
            this.payDataGridViewTextBoxColumn,
            this.duePayDataGridViewTextBoxColumn});
            this.dataGridViewAccount.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewAccount.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewAccount.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewAccount.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewAccount.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewAccount.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewAccount.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewAccount.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewAccount.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridViewAccount.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewAccount.CurrentTheme.Name = null;
            this.dataGridViewAccount.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewAccount.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.dataGridViewAccount.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewAccount.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewAccount.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewAccount.DataSource = this.tblOverallAccountBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAccount.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAccount.EnableHeadersVisualStyles = false;
            this.dataGridViewAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewAccount.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewAccount.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewAccount.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewAccount.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAccount.Name = "dataGridViewAccount";
            this.dataGridViewAccount.ReadOnly = true;
            this.dataGridViewAccount.RowHeadersVisible = false;
            this.dataGridViewAccount.RowTemplate.Height = 40;
            this.dataGridViewAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccount.Size = new System.Drawing.Size(489, 318);
            this.dataGridViewAccount.TabIndex = 4;
            this.dataGridViewAccount.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // pPriceDataGridViewTextBoxColumn
            // 
            this.pPriceDataGridViewTextBoxColumn.DataPropertyName = "pPrice";
            this.pPriceDataGridViewTextBoxColumn.HeaderText = "Total P. Price";
            this.pPriceDataGridViewTextBoxColumn.Name = "pPriceDataGridViewTextBoxColumn";
            this.pPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.pPriceDataGridViewTextBoxColumn.ToolTipText = "Total Purchase Price";
            // 
            // sPriceDataGridViewTextBoxColumn
            // 
            this.sPriceDataGridViewTextBoxColumn.DataPropertyName = "sPrice";
            this.sPriceDataGridViewTextBoxColumn.HeaderText = "Total S. Price";
            this.sPriceDataGridViewTextBoxColumn.Name = "sPriceDataGridViewTextBoxColumn";
            this.sPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.sPriceDataGridViewTextBoxColumn.ToolTipText = "Total Sale Price";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total Sales";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payDiscDataGridViewTextBoxColumn
            // 
            this.payDiscDataGridViewTextBoxColumn.DataPropertyName = "payDisc";
            this.payDiscDataGridViewTextBoxColumn.HeaderText = "Total Discount";
            this.payDiscDataGridViewTextBoxColumn.Name = "payDiscDataGridViewTextBoxColumn";
            this.payDiscDataGridViewTextBoxColumn.ReadOnly = true;
            this.payDiscDataGridViewTextBoxColumn.ToolTipText = "Total Discount";
            // 
            // payDataGridViewTextBoxColumn
            // 
            this.payDataGridViewTextBoxColumn.DataPropertyName = "pay";
            this.payDataGridViewTextBoxColumn.HeaderText = "Total Payment";
            this.payDataGridViewTextBoxColumn.Name = "payDataGridViewTextBoxColumn";
            this.payDataGridViewTextBoxColumn.ReadOnly = true;
            this.payDataGridViewTextBoxColumn.ToolTipText = "Payment";
            // 
            // duePayDataGridViewTextBoxColumn
            // 
            this.duePayDataGridViewTextBoxColumn.DataPropertyName = "duePay";
            this.duePayDataGridViewTextBoxColumn.HeaderText = "Total Due Pay";
            this.duePayDataGridViewTextBoxColumn.Name = "duePayDataGridViewTextBoxColumn";
            this.duePayDataGridViewTextBoxColumn.ReadOnly = true;
            this.duePayDataGridViewTextBoxColumn.ToolTipText = "Duy payment";
            // 
            // tblOverallAccountBindingSource
            // 
            this.tblOverallAccountBindingSource.DataMember = "tblOverallAccount";
            this.tblOverallAccountBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePickerStart);
            this.panel1.Controls.Add(this.dateTimePickerEnd);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(30, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 39);
            this.panel1.TabIndex = 3;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerStart.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dateTimePickerStart.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerStart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(10, 5);
            this.dateTimePickerStart.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStart.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(146, 29);
            this.dateTimePickerStart.TabIndex = 6;
            this.dateTimePickerStart.Value = new System.DateTime(2021, 2, 22, 0, 0, 0, 0);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerEnd.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dateTimePickerEnd.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(198, 5);
            this.dateTimePickerEnd.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerEnd.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(144, 29);
            this.dateTimePickerEnd.TabIndex = 5;
            this.dateTimePickerEnd.Value = new System.DateTime(2021, 2, 22, 0, 0, 0, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Active = false;
            this.btnSearch.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = global::ERP.Properties.Resources.search_25px;
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 60D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(394, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(95, 39);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.EllipsisFormat = Bunifu.UI.WinForms.Ellipsis.EllipsisFormat.None;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuLabel1.Location = new System.Drawing.Point(164, 6);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(26, 27);
            this.bunifuLabel1.TabIndex = 3;
            this.bunifuLabel1.Text = "To";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnPrint
            // 
            this.btnPrint.Active = false;
            this.btnPrint.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.BorderRadius = 5;
            this.btnPrint.ButtonText = "Print";
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnPrint.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrint.Iconimage = global::ERP.Properties.Resources.print_25px;
            this.btnPrint.Iconimage_right = null;
            this.btnPrint.Iconimage_right_Selected = null;
            this.btnPrint.Iconimage_Selected = null;
            this.btnPrint.IconMarginLeft = 0;
            this.btnPrint.IconMarginRight = 0;
            this.btnPrint.IconRightVisible = true;
            this.btnPrint.IconRightZoom = 0D;
            this.btnPrint.IconVisible = true;
            this.btnPrint.IconZoom = 60D;
            this.btnPrint.IsTab = false;
            this.btnPrint.Location = new System.Drawing.Point(424, 412);
            this.btnPrint.MaximumSize = new System.Drawing.Size(95, 35);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.btnPrint.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btnPrint.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnPrint.selected = false;
            this.btnPrint.Size = new System.Drawing.Size(95, 35);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.Textcolor = System.Drawing.Color.Black;
            this.btnPrint.TextFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tblOverallAccountTableAdapter
            // 
            this.tblOverallAccountTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportOverallAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.pnlSaleReport);
            this.Controls.Add(this.pnlPrinting);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportOverallAccount";
            this.Text = "frmReportOverallAccount";
            this.Load += new System.EventHandler(this.frmReportOverallAccount_Load);
            this.pnlPrinting.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlSaleReport.ResumeLayout(false);
            this.tblLayPnlSaleView.ResumeLayout(false);
            this.tblLayPnlSaleView.PerformLayout();
            this.pnlGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOverallAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrinting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel pnlSaleReport;
        private System.Windows.Forms.TableLayoutPanel tblLayPnlSaleView;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private System.Windows.Forms.Panel pnlGridView;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrint;
        private AppData appData;
        private System.Windows.Forms.BindingSource tblOverallAccountBindingSource;
        private AppDataTableAdapters.tblOverallAccountTableAdapter tblOverallAccountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payDiscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duePayDataGridViewTextBoxColumn;
    }
}