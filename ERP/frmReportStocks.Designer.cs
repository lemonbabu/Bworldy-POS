
namespace ERP
{
    partial class frmReportStocks
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblStocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AppData = new ERP.AppData();
            this.viewStockHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlSaleReport = new System.Windows.Forms.Panel();
            this.tblLayPnlSaleView = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlGridView = new System.Windows.Forms.Panel();
            this.dataGridViewSales = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ctgNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlPrinting = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblStocksTableAdapter = new ERP.AppDataTableAdapters.tblStocksTableAdapter();
            this.tblSaleProductViewReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSaleProductViewReportTableAdapter = new ERP.AppDataTableAdapters.tblSaleProductViewReportTableAdapter();
            this.mainDataSet = new ERP.mainDataSet();
            this.tblSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSalesTableAdapter = new ERP.mainDataSetTableAdapters.tblSalesTableAdapter();
            this.viewStockHistoryTableAdapter = new ERP.AppDataTableAdapters.viewStockHistoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblStocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewStockHistoryBindingSource)).BeginInit();
            this.pnlSaleReport.SuspendLayout();
            this.tblLayPnlSaleView.SuspendLayout();
            this.pnlGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.pnlPrinting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleProductViewReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblStocksBindingSource
            // 
            this.tblStocksBindingSource.DataMember = "tblStocks";
            this.tblStocksBindingSource.DataSource = this.AppData;
            // 
            // AppData
            // 
            this.AppData.DataSetName = "AppData";
            this.AppData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewStockHistoryBindingSource
            // 
            this.viewStockHistoryBindingSource.DataMember = "viewStockHistory";
            this.viewStockHistoryBindingSource.DataSource = this.AppData;
            // 
            // pnlSaleReport
            // 
            this.pnlSaleReport.Controls.Add(this.tblLayPnlSaleView);
            this.pnlSaleReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSaleReport.Location = new System.Drawing.Point(0, 0);
            this.pnlSaleReport.Name = "pnlSaleReport";
            this.pnlSaleReport.Size = new System.Drawing.Size(550, 450);
            this.pnlSaleReport.TabIndex = 7;
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
            this.tblLayPnlSaleView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblLayPnlSaleView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblLayPnlSaleView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayPnlSaleView.Size = new System.Drawing.Size(550, 450);
            this.tblLayPnlSaleView.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(175, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(198, 44);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "STOCK VIEW";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGridView
            // 
            this.pnlGridView.Controls.Add(this.dataGridViewSales);
            this.pnlGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridView.Location = new System.Drawing.Point(30, 52);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Size = new System.Drawing.Size(489, 350);
            this.pnlGridView.TabIndex = 1;
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.AllowCustomTheming = true;
            this.dataGridViewSales.AllowUserToAddRows = false;
            this.dataGridViewSales.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSales.AutoGenerateColumns = false;
            this.dataGridViewSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSales.ColumnHeadersHeight = 40;
            this.dataGridViewSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ctgNameDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn,
            this.pSizeDataGridViewTextBoxColumn,
            this.pPriceDataGridViewTextBoxColumn,
            this.sPriceDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.lastDateDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.dataGridViewSales.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewSales.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewSales.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSales.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewSales.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewSales.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewSales.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewSales.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewSales.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridViewSales.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewSales.CurrentTheme.Name = null;
            this.dataGridViewSales.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewSales.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.dataGridViewSales.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSales.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewSales.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewSales.DataSource = this.tblStocksBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSales.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSales.EnableHeadersVisualStyles = false;
            this.dataGridViewSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewSales.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewSales.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewSales.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewSales.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.ReadOnly = true;
            this.dataGridViewSales.RowHeadersVisible = false;
            this.dataGridViewSales.RowTemplate.Height = 40;
            this.dataGridViewSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSales.Size = new System.Drawing.Size(489, 350);
            this.dataGridViewSales.TabIndex = 4;
            this.dataGridViewSales.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // ctgNameDataGridViewTextBoxColumn
            // 
            this.ctgNameDataGridViewTextBoxColumn.DataPropertyName = "ctgName";
            this.ctgNameDataGridViewTextBoxColumn.HeaderText = "Categorie";
            this.ctgNameDataGridViewTextBoxColumn.Name = "ctgNameDataGridViewTextBoxColumn";
            this.ctgNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "pName";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            this.pNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pSizeDataGridViewTextBoxColumn
            // 
            this.pSizeDataGridViewTextBoxColumn.DataPropertyName = "pSize";
            this.pSizeDataGridViewTextBoxColumn.FillWeight = 60F;
            this.pSizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.pSizeDataGridViewTextBoxColumn.Name = "pSizeDataGridViewTextBoxColumn";
            this.pSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pPriceDataGridViewTextBoxColumn
            // 
            this.pPriceDataGridViewTextBoxColumn.DataPropertyName = "pPrice";
            this.pPriceDataGridViewTextBoxColumn.FillWeight = 80F;
            this.pPriceDataGridViewTextBoxColumn.HeaderText = "Pur. Price";
            this.pPriceDataGridViewTextBoxColumn.Name = "pPriceDataGridViewTextBoxColumn";
            this.pPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.pPriceDataGridViewTextBoxColumn.ToolTipText = "Purchase Price";
            // 
            // sPriceDataGridViewTextBoxColumn
            // 
            this.sPriceDataGridViewTextBoxColumn.DataPropertyName = "sPrice";
            this.sPriceDataGridViewTextBoxColumn.FillWeight = 80F;
            this.sPriceDataGridViewTextBoxColumn.HeaderText = "Sale Price";
            this.sPriceDataGridViewTextBoxColumn.Name = "sPriceDataGridViewTextBoxColumn";
            this.sPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.FillWeight = 80F;
            this.discountDataGridViewTextBoxColumn.HeaderText = "Disc.";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountDataGridViewTextBoxColumn.ToolTipText = "Discount";
            // 
            // lastDateDataGridViewTextBoxColumn
            // 
            this.lastDateDataGridViewTextBoxColumn.DataPropertyName = "lastDate";
            this.lastDateDataGridViewTextBoxColumn.FillWeight = 70F;
            this.lastDateDataGridViewTextBoxColumn.HeaderText = "Last Date";
            this.lastDateDataGridViewTextBoxColumn.Name = "lastDateDataGridViewTextBoxColumn";
            this.lastDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.FillWeight = 60F;
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(30, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 1);
            this.panel1.TabIndex = 3;
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
            this.btnPrint.Location = new System.Drawing.Point(424, 408);
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
            // pnlPrinting
            // 
            this.pnlPrinting.Controls.Add(this.tableLayoutPanel1);
            this.pnlPrinting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrinting.Location = new System.Drawing.Point(0, 0);
            this.pnlPrinting.Name = "pnlPrinting";
            this.pnlPrinting.Size = new System.Drawing.Size(550, 450);
            this.pnlPrinting.TabIndex = 8;
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
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(178, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(193, 44);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "PRINT VIEW";
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
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblStocksBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERP.Reports.rptStocksReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(489, 372);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblStocksTableAdapter
            // 
            this.tblStocksTableAdapter.ClearBeforeFill = true;
            // 
            // tblSaleProductViewReportBindingSource
            // 
            this.tblSaleProductViewReportBindingSource.DataMember = "tblSaleProductViewReport";
            this.tblSaleProductViewReportBindingSource.DataSource = this.AppData;
            // 
            // tblSaleProductViewReportTableAdapter
            // 
            this.tblSaleProductViewReportTableAdapter.ClearBeforeFill = true;
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "mainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSalesBindingSource
            // 
            this.tblSalesBindingSource.DataMember = "tblSales";
            this.tblSalesBindingSource.DataSource = this.mainDataSet;
            // 
            // tblSalesTableAdapter
            // 
            this.tblSalesTableAdapter.ClearBeforeFill = true;
            // 
            // viewStockHistoryTableAdapter
            // 
            this.viewStockHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.pnlSaleReport);
            this.Controls.Add(this.pnlPrinting);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportStocks";
            this.Text = "frmReportStocks";
            this.Load += new System.EventHandler(this.frmReportStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblStocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewStockHistoryBindingSource)).EndInit();
            this.pnlSaleReport.ResumeLayout(false);
            this.tblLayPnlSaleView.ResumeLayout(false);
            this.tblLayPnlSaleView.PerformLayout();
            this.pnlGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.pnlPrinting.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleProductViewReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSaleReport;
        private System.Windows.Forms.TableLayoutPanel tblLayPnlSaleView;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private System.Windows.Forms.Panel pnlGridView;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewSales;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrint;
        private System.Windows.Forms.Panel pnlPrinting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblStocksBindingSource;
        private AppData AppData;
        private AppDataTableAdapters.tblStocksTableAdapter tblStocksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctgNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblSaleProductViewReportBindingSource;
        private System.Windows.Forms.BindingSource tblSalesBindingSource;
        private mainDataSet mainDataSet;
        private AppDataTableAdapters.tblSaleProductViewReportTableAdapter tblSaleProductViewReportTableAdapter;
        private mainDataSetTableAdapters.tblSalesTableAdapter tblSalesTableAdapter;
        private System.Windows.Forms.BindingSource viewStockHistoryBindingSource;
        private AppDataTableAdapters.viewStockHistoryTableAdapter viewStockHistoryTableAdapter;
    }
}