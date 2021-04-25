
namespace ERP
{
    partial class frmBarcodeGenerate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarcodeGenerate));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BarcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLyPnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAddStockTools = new System.Windows.Forms.Panel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtCurentStock = new Bunifu.Framework.BunifuCustomTextbox();
            this.btnClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGenerate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbProductCtg = new System.Windows.Forms.ComboBox();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.cmbProductSize = new System.Windows.Forms.ComboBox();
            this.pnlBarcode = new System.Windows.Forms.Panel();
            this.btnBarcodePrint = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.appData1 = new ERP.AppData();
            this.AppData = new ERP.AppData();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeBindingSource)).BeginInit();
            this.tblLyPnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlAddStockTools.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlBarcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlReport.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppData)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLyPnlMain
            // 
            this.tblLyPnlMain.ColumnCount = 1;
            this.tblLyPnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLyPnlMain.Controls.Add(this.panel1, 0, 1);
            this.tblLyPnlMain.Controls.Add(this.lblTitle, 0, 0);
            this.tblLyPnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLyPnlMain.ForeColor = System.Drawing.Color.Black;
            this.tblLyPnlMain.Location = new System.Drawing.Point(0, 0);
            this.tblLyPnlMain.Name = "tblLyPnlMain";
            this.tblLyPnlMain.RowCount = 3;
            this.tblLyPnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblLyPnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tblLyPnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLyPnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLyPnlMain.Size = new System.Drawing.Size(550, 450);
            this.tblLyPnlMain.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 359);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.88889F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel1.Controls.Add(this.pnlAddStockTools, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlBarcode, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 359);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // pnlAddStockTools
            // 
            this.pnlAddStockTools.Controls.Add(this.bunifuLabel2);
            this.pnlAddStockTools.Controls.Add(this.txtCurentStock);
            this.pnlAddStockTools.Controls.Add(this.btnClear);
            this.pnlAddStockTools.Controls.Add(this.btnGenerate);
            this.pnlAddStockTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddStockTools.Location = new System.Drawing.Point(33, 50);
            this.pnlAddStockTools.Name = "pnlAddStockTools";
            this.pnlAddStockTools.Size = new System.Drawing.Size(477, 39);
            this.pnlAddStockTools.TabIndex = 0;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(11, 6);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(133, 23);
            this.bunifuLabel2.TabIndex = 19;
            this.bunifuLabel2.Text = "Available Quantity:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtCurentStock
            // 
            this.txtCurentStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCurentStock.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCurentStock.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCurentStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurentStock.Location = new System.Drawing.Point(150, 4);
            this.txtCurentStock.Name = "txtCurentStock";
            this.txtCurentStock.Size = new System.Drawing.Size(77, 29);
            this.txtCurentStock.TabIndex = 18;
            this.txtCurentStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCurentStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCurentStock_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.ActiveBorderThickness = 1;
            this.btnClear.ActiveCornerRadius = 10;
            this.btnClear.ActiveFillColor = System.Drawing.Color.Red;
            this.btnClear.ActiveForecolor = System.Drawing.Color.White;
            this.btnClear.ActiveLineColor = System.Drawing.Color.Red;
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.ButtonText = "Clear";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.IdleBorderThickness = 1;
            this.btnClear.IdleCornerRadius = 10;
            this.btnClear.IdleFillColor = System.Drawing.Color.White;
            this.btnClear.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.btnClear.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.Location = new System.Drawing.Point(392, -4);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 45);
            this.btnClear.TabIndex = 9;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.ActiveBorderThickness = 1;
            this.btnGenerate.ActiveCornerRadius = 10;
            this.btnGenerate.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.ActiveForecolor = System.Drawing.Color.White;
            this.btnGenerate.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnGenerate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerate.BackgroundImage")));
            this.btnGenerate.ButtonText = "Generate";
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.IdleBorderThickness = 1;
            this.btnGenerate.IdleCornerRadius = 10;
            this.btnGenerate.IdleFillColor = System.Drawing.Color.White;
            this.btnGenerate.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.Location = new System.Drawing.Point(271, -4);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(95, 45);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cmbProductCtg, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbProductName, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbProductSize, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(33, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(477, 41);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cmbProductCtg
            // 
            this.cmbProductCtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbProductCtg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProductCtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductCtg.FormattingEnabled = true;
            this.cmbProductCtg.ItemHeight = 20;
            this.cmbProductCtg.Location = new System.Drawing.Point(11, 3);
            this.cmbProductCtg.Name = "cmbProductCtg";
            this.cmbProductCtg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbProductCtg.Size = new System.Drawing.Size(214, 28);
            this.cmbProductCtg.TabIndex = 1;
            this.cmbProductCtg.Text = " Select a Categorie";
            this.cmbProductCtg.Click += new System.EventHandler(this.cmbProductCtg_Click);
            // 
            // cmbProductName
            // 
            this.cmbProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(236, 3);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(144, 28);
            this.cmbProductName.TabIndex = 2;
            this.cmbProductName.Click += new System.EventHandler(this.cmbProductName_Click);
            // 
            // cmbProductSize
            // 
            this.cmbProductSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbProductSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductSize.FormattingEnabled = true;
            this.cmbProductSize.Location = new System.Drawing.Point(391, 3);
            this.cmbProductSize.Name = "cmbProductSize";
            this.cmbProductSize.Size = new System.Drawing.Size(74, 28);
            this.cmbProductSize.TabIndex = 3;
            this.cmbProductSize.SelectedValueChanged += new System.EventHandler(this.cmbProductSize_SelectedValueChanged);
            this.cmbProductSize.Click += new System.EventHandler(this.cmbProductSize_Click);
            // 
            // pnlBarcode
            // 
            this.pnlBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlBarcode.Controls.Add(this.btnBarcodePrint);
            this.pnlBarcode.Controls.Add(this.pictureBox1);
            this.pnlBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBarcode.Location = new System.Drawing.Point(33, 95);
            this.pnlBarcode.Name = "pnlBarcode";
            this.pnlBarcode.Size = new System.Drawing.Size(477, 229);
            this.pnlBarcode.TabIndex = 0;
            // 
            // btnBarcodePrint
            // 
            this.btnBarcodePrint.ActiveBorderThickness = 1;
            this.btnBarcodePrint.ActiveCornerRadius = 10;
            this.btnBarcodePrint.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btnBarcodePrint.ActiveForecolor = System.Drawing.Color.White;
            this.btnBarcodePrint.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.btnBarcodePrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBarcodePrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBarcodePrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBarcodePrint.BackgroundImage")));
            this.btnBarcodePrint.ButtonText = "Print >>";
            this.btnBarcodePrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBarcodePrint.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarcodePrint.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBarcodePrint.IdleBorderThickness = 1;
            this.btnBarcodePrint.IdleCornerRadius = 10;
            this.btnBarcodePrint.IdleFillColor = System.Drawing.Color.White;
            this.btnBarcodePrint.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.btnBarcodePrint.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnBarcodePrint.Location = new System.Drawing.Point(187, 100);
            this.btnBarcodePrint.Margin = new System.Windows.Forms.Padding(5);
            this.btnBarcodePrint.Name = "btnBarcodePrint";
            this.btnBarcodePrint.Size = new System.Drawing.Size(97, 42);
            this.btnBarcodePrint.TabIndex = 10;
            this.btnBarcodePrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBarcodePrint.Click += new System.EventHandler(this.btnBarcodePrint_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Location = new System.Drawing.Point(181, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 40);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(127, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(296, 64);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "BARCODE GENERATE";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlReport
            // 
            this.pnlReport.Controls.Add(this.tableLayoutPanel4);
            this.pnlReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReport.Location = new System.Drawing.Point(0, 0);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(550, 450);
            this.pnlReport.TabIndex = 13;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.Controls.Add(this.bunifuCustomLabel1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.reportViewer1, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(550, 450);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(147, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(255, 67);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Barcode Generate";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 33;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.BarcodeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERP.Reports.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(58, 70);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(434, 331);
            this.reportViewer1.TabIndex = 3;
            // 
            // appData1
            // 
            this.appData1.DataSetName = "AppData";
            this.appData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AppData
            // 
            this.AppData.DataSetName = "AppData";
            this.AppData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmBarcodeGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.tblLyPnlMain);
            this.Controls.Add(this.pnlReport);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBarcodeGenerate";
            this.Text = "frmBarcodeGenerate";
            this.Load += new System.EventHandler(this.frmBarcodeGenerate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeBindingSource)).EndInit();
            this.tblLyPnlMain.ResumeLayout(false);
            this.tblLyPnlMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlAddStockTools.ResumeLayout(false);
            this.pnlAddStockTools.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlBarcode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlReport.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLyPnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlAddStockTools;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.Framework.BunifuCustomTextbox txtCurentStock;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClear;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGenerate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cmbProductCtg;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.ComboBox cmbProductSize;
        private System.Windows.Forms.Panel pnlBarcode;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBarcodePrint;
        private System.Windows.Forms.Panel pnlReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.BindingSource BarcodeBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AppData appData1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private AppData AppData;
    }
}