
namespace ERP
{
    partial class frmStockDetailsReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockDetailsReport));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblStockDetailsReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new ERP.AppData();
            this.pnlStockReport = new System.Windows.Forms.Panel();
            this.tblLayPnlSaleView = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlGridView = new System.Windows.Forms.Panel();
            this.dataGridViewSales = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ctgNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDiscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbProductCtg = new System.Windows.Forms.ComboBox();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.cmbProductSize = new System.Windows.Forms.ComboBox();
            this.btnSearch = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlPrinting = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblStockDetailsReportTableAdapter = new ERP.AppDataTableAdapters.tblStockDetailsReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblStockDetailsReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.pnlStockReport.SuspendLayout();
            this.tblLayPnlSaleView.SuspendLayout();
            this.pnlGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlPrinting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblStockDetailsReportBindingSource
            // 
            this.tblStockDetailsReportBindingSource.DataMember = "tblStockDetailsReport";
            this.tblStockDetailsReportBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlStockReport
            // 
            this.pnlStockReport.Controls.Add(this.tblLayPnlSaleView);
            this.pnlStockReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStockReport.Location = new System.Drawing.Point(0, 0);
            this.pnlStockReport.Name = "pnlStockReport";
            this.pnlStockReport.Size = new System.Drawing.Size(550, 450);
            this.pnlStockReport.TabIndex = 2;
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
            this.tblLayPnlSaleView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblLayPnlSaleView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblLayPnlSaleView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.81818F));
            this.tblLayPnlSaleView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblLayPnlSaleView.Size = new System.Drawing.Size(550, 450);
            this.tblLayPnlSaleView.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(104, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 36);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "STOCKS DETAILS VIEW";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGridView
            // 
            this.pnlGridView.Controls.Add(this.dataGridViewSales);
            this.pnlGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridView.Location = new System.Drawing.Point(30, 84);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlGridView.Size = new System.Drawing.Size(489, 325);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.stockDataGridViewTextBoxColumn,
            this.pPriceDataGridViewTextBoxColumn,
            this.tpPriceDataGridViewTextBoxColumn,
            this.sPriceDataGridViewTextBoxColumn,
            this.tsPriceDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.tDiscDataGridViewTextBoxColumn,
            this.profit});
            this.dataGridViewSales.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewSales.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewSales.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSales.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewSales.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewSales.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewSales.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewSales.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewSales.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSales.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewSales.CurrentTheme.Name = null;
            this.dataGridViewSales.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewSales.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSales.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSales.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewSales.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewSales.DataSource = this.tblStockDetailsReportBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridViewSales.Location = new System.Drawing.Point(0, 5);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.ReadOnly = true;
            this.dataGridViewSales.RowHeadersVisible = false;
            this.dataGridViewSales.RowTemplate.Height = 40;
            this.dataGridViewSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSales.Size = new System.Drawing.Size(489, 320);
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
            this.pSizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.pSizeDataGridViewTextBoxColumn.Name = "pSizeDataGridViewTextBoxColumn";
            this.pSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pPriceDataGridViewTextBoxColumn
            // 
            this.pPriceDataGridViewTextBoxColumn.DataPropertyName = "pPrice";
            this.pPriceDataGridViewTextBoxColumn.HeaderText = "Unit Pur. Price";
            this.pPriceDataGridViewTextBoxColumn.Name = "pPriceDataGridViewTextBoxColumn";
            this.pPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tpPriceDataGridViewTextBoxColumn
            // 
            this.tpPriceDataGridViewTextBoxColumn.DataPropertyName = "tpPrice";
            this.tpPriceDataGridViewTextBoxColumn.HeaderText = "Subtotal Pur. Price";
            this.tpPriceDataGridViewTextBoxColumn.Name = "tpPriceDataGridViewTextBoxColumn";
            this.tpPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPriceDataGridViewTextBoxColumn
            // 
            this.sPriceDataGridViewTextBoxColumn.DataPropertyName = "sPrice";
            this.sPriceDataGridViewTextBoxColumn.HeaderText = "Unit Sale Price";
            this.sPriceDataGridViewTextBoxColumn.Name = "sPriceDataGridViewTextBoxColumn";
            this.sPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tsPriceDataGridViewTextBoxColumn
            // 
            this.tsPriceDataGridViewTextBoxColumn.DataPropertyName = "tsPrice";
            this.tsPriceDataGridViewTextBoxColumn.HeaderText = "Subtotal Sale Price";
            this.tsPriceDataGridViewTextBoxColumn.Name = "tsPriceDataGridViewTextBoxColumn";
            this.tsPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Unit Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tDiscDataGridViewTextBoxColumn
            // 
            this.tDiscDataGridViewTextBoxColumn.DataPropertyName = "tDisc";
            this.tDiscDataGridViewTextBoxColumn.HeaderText = "Subtotal Disc";
            this.tDiscDataGridViewTextBoxColumn.Name = "tDiscDataGridViewTextBoxColumn";
            this.tDiscDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profit
            // 
            this.profit.DataPropertyName = "profit";
            this.profit.HeaderText = "Sub Profit";
            this.profit.Name = "profit";
            this.profit.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(30, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 39);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cmbProductCtg, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbProductName, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbProductSize, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSearch, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(489, 39);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // cmbProductCtg
            // 
            this.cmbProductCtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbProductCtg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProductCtg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductCtg.FormattingEnabled = true;
            this.cmbProductCtg.ItemHeight = 21;
            this.cmbProductCtg.Location = new System.Drawing.Point(6, 3);
            this.cmbProductCtg.Name = "cmbProductCtg";
            this.cmbProductCtg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbProductCtg.Size = new System.Drawing.Size(174, 29);
            this.cmbProductCtg.TabIndex = 1;
            this.cmbProductCtg.Text = " Select a Categorie";
            this.cmbProductCtg.Click += new System.EventHandler(this.cmbProductCtg_Click);
            // 
            // cmbProductName
            // 
            this.cmbProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(186, 3);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(134, 29);
            this.cmbProductName.TabIndex = 2;
            this.cmbProductName.Click += new System.EventHandler(this.cmbProductName_Click);
            // 
            // cmbProductSize
            // 
            this.cmbProductSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbProductSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductSize.FormattingEnabled = true;
            this.cmbProductSize.Location = new System.Drawing.Point(326, 3);
            this.cmbProductSize.Name = "cmbProductSize";
            this.cmbProductSize.Size = new System.Drawing.Size(74, 29);
            this.cmbProductSize.TabIndex = 3;
            this.cmbProductSize.Click += new System.EventHandler(this.cmbProductSize_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AllowToggling = false;
            this.btnSearch.AnimationSpeed = 200;
            this.btnSearch.AutoGenerateColors = false;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.ButtonTextMarginLeft = 0;
            this.btnSearch.ColorContrastOnClick = 45;
            this.btnSearch.ColorContrastOnHover = 45;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSearch.CustomizableEdges = borderEdges1;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSearch.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearch.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.IconMarginLeft = 11;
            this.btnSearch.IconPadding = 10;
            this.btnSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.IdleBorderRadius = 1;
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.IdleIconLeftImage = null;
            this.btnSearch.IdleIconRightImage = null;
            this.btnSearch.IndicateFocus = false;
            this.btnSearch.Location = new System.Drawing.Point(409, 3);
            this.btnSearch.Name = "btnSearch";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnSearch.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnSearch.OnPressedState = stateProperties2;
            this.btnSearch.Size = new System.Drawing.Size(74, 33);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.TextMarginLeft = 0;
            this.btnSearch.UseDefaultRadiusAndThickness = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Active = false;
            this.btnPrint.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.BorderRadius = 1;
            this.btnPrint.ButtonText = "Print";
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnPrint.Location = new System.Drawing.Point(436, 415);
            this.btnPrint.MaximumSize = new System.Drawing.Size(95, 35);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.btnPrint.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btnPrint.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnPrint.selected = false;
            this.btnPrint.Size = new System.Drawing.Size(83, 31);
            this.btnPrint.TabIndex = 7;
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
            this.pnlPrinting.TabIndex = 3;
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
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
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
            reportDataSource1.Value = this.tblStockDetailsReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERP.Reports.rptStockDetailsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(489, 372);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblStockDetailsReportTableAdapter
            // 
            this.tblStockDetailsReportTableAdapter.ClearBeforeFill = true;
            // 
            // frmStockDetailsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.pnlStockReport);
            this.Controls.Add(this.pnlPrinting);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStockDetailsReport";
            this.Text = "frmStockDetailsReport";
            this.Load += new System.EventHandler(this.frmStockDetailsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblStockDetailsReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.pnlStockReport.ResumeLayout(false);
            this.tblLayPnlSaleView.ResumeLayout(false);
            this.tblLayPnlSaleView.PerformLayout();
            this.pnlGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlPrinting.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStockReport;
        private System.Windows.Forms.TableLayoutPanel tblLayPnlSaleView;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private System.Windows.Forms.Panel pnlGridView;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewSales;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrint;
        private System.Windows.Forms.Panel pnlPrinting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private AppData appData;
        private System.Windows.Forms.BindingSource tblStockDetailsReportBindingSource;
        private AppDataTableAdapters.tblStockDetailsReportTableAdapter tblStockDetailsReportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctgNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDiscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profit;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cmbProductCtg;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.ComboBox cmbProductSize;
    }
}