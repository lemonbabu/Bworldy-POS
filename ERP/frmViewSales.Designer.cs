
namespace ERP
{
    partial class frmViewSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewSales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblLayPnlSaleView = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlGridView = new System.Windows.Forms.Panel();
            this.dataGridViewSales = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.saleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overallDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidAmntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblSalesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData1 = new ERP.AppData();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotalExtDisc = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblTotalDisc = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblTotalAmnt = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            this.tblLayPnlSaleDetails = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewSalesDetails = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ctgNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSizeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleUnitPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSaleDetailsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPhoneSaleView = new System.Windows.Forms.Label();
            this.lblNameSalesView = new System.Windows.Forms.Label();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.tblSalesViewTableAdapter = new ERP.AppDataTableAdapters.tblSalesViewTableAdapter();
            this.tblSaleDetailsViewTableAdapter = new ERP.AppDataTableAdapters.tblSaleDetailsViewTableAdapter();
            this.tblLayPnlSaleView.SuspendLayout();
            this.pnlGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tblLayPnlSaleDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleDetailsViewBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.tblLayPnlSaleView.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.tblLayPnlSaleView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayPnlSaleView.Location = new System.Drawing.Point(0, 0);
            this.tblLayPnlSaleView.Name = "tblLayPnlSaleView";
            this.tblLayPnlSaleView.RowCount = 4;
            this.tblLayPnlSaleView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayPnlSaleView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblLayPnlSaleView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tblLayPnlSaleView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblLayPnlSaleView.Size = new System.Drawing.Size(550, 450);
            this.tblLayPnlSaleView.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(186, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 36);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "SALES VIEW";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGridView
            // 
            this.pnlGridView.Controls.Add(this.dataGridViewSales);
            this.pnlGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridView.Location = new System.Drawing.Point(30, 84);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Size = new System.Drawing.Size(489, 318);
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
            this.dataGridViewSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
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
            this.saleIdDataGridViewTextBoxColumn,
            this.cstNameDataGridViewTextBoxColumn,
            this.cstPhoneDataGridViewTextBoxColumn,
            this.totalAmntDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.overallDiscount,
            this.paidAmntDataGridViewTextBoxColumn,
            this.payMethodDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.View});
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
            this.dataGridViewSales.DataSource = this.tblSalesViewBindingSource;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSales.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSales.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSales.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSales.RowTemplate.Height = 40;
            this.dataGridViewSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSales.Size = new System.Drawing.Size(489, 318);
            this.dataGridViewSales.TabIndex = 4;
            this.dataGridViewSales.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridViewSales.VirtualMode = true;
            this.dataGridViewSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSales_CellContentClick);
            // 
            // saleIdDataGridViewTextBoxColumn
            // 
            this.saleIdDataGridViewTextBoxColumn.DataPropertyName = "saleId";
            this.saleIdDataGridViewTextBoxColumn.HeaderText = "Sale ID";
            this.saleIdDataGridViewTextBoxColumn.Name = "saleIdDataGridViewTextBoxColumn";
            this.saleIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cstNameDataGridViewTextBoxColumn
            // 
            this.cstNameDataGridViewTextBoxColumn.DataPropertyName = "cstName";
            this.cstNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.cstNameDataGridViewTextBoxColumn.Name = "cstNameDataGridViewTextBoxColumn";
            this.cstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cstPhoneDataGridViewTextBoxColumn
            // 
            this.cstPhoneDataGridViewTextBoxColumn.DataPropertyName = "cstPhone";
            this.cstPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.cstPhoneDataGridViewTextBoxColumn.Name = "cstPhoneDataGridViewTextBoxColumn";
            this.cstPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmntDataGridViewTextBoxColumn
            // 
            this.totalAmntDataGridViewTextBoxColumn.DataPropertyName = "totalAmnt";
            this.totalAmntDataGridViewTextBoxColumn.HeaderText = "Total Amnt";
            this.totalAmntDataGridViewTextBoxColumn.Name = "totalAmntDataGridViewTextBoxColumn";
            this.totalAmntDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalAmntDataGridViewTextBoxColumn.ToolTipText = "Total Amount";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Disc.";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountDataGridViewTextBoxColumn.ToolTipText = "Discount";
            // 
            // overallDiscount
            // 
            this.overallDiscount.DataPropertyName = "overallDiscount";
            this.overallDiscount.HeaderText = "Extra Disc.";
            this.overallDiscount.Name = "overallDiscount";
            this.overallDiscount.ReadOnly = true;
            this.overallDiscount.ToolTipText = "Extra Discount";
            // 
            // paidAmntDataGridViewTextBoxColumn
            // 
            this.paidAmntDataGridViewTextBoxColumn.DataPropertyName = "PaidAmnt";
            this.paidAmntDataGridViewTextBoxColumn.HeaderText = "Paid Amnt";
            this.paidAmntDataGridViewTextBoxColumn.Name = "paidAmntDataGridViewTextBoxColumn";
            this.paidAmntDataGridViewTextBoxColumn.ReadOnly = true;
            this.paidAmntDataGridViewTextBoxColumn.ToolTipText = "Paid Amount";
            // 
            // payMethodDataGridViewTextBoxColumn
            // 
            this.payMethodDataGridViewTextBoxColumn.DataPropertyName = "payMethod";
            this.payMethodDataGridViewTextBoxColumn.HeaderText = "Pay M.";
            this.payMethodDataGridViewTextBoxColumn.Name = "payMethodDataGridViewTextBoxColumn";
            this.payMethodDataGridViewTextBoxColumn.ReadOnly = true;
            this.payMethodDataGridViewTextBoxColumn.ToolTipText = "Payment Method";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // View
            // 
            this.View.HeaderText = "View";
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Text = "View Details";
            this.View.UseColumnTextForButtonValue = true;
            // 
            // tblSalesViewBindingSource
            // 
            this.tblSalesViewBindingSource.DataMember = "tblSalesView";
            this.tblSalesViewBindingSource.DataSource = this.appData1;
            // 
            // appData1
            // 
            this.appData1.DataSetName = "AppData";
            this.appData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePickerStart);
            this.panel1.Controls.Add(this.dateTimePickerEnd);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(30, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 39);
            this.panel1.TabIndex = 3;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerStart.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dateTimePickerStart.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerStart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(10, 5);
            this.dateTimePickerStart.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStart.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(146, 29);
            this.dateTimePickerStart.TabIndex = 6;
            this.dateTimePickerStart.Value = new System.DateTime(2021, 2, 21, 11, 2, 22, 0);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerEnd.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dateTimePickerEnd.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(198, 5);
            this.dateTimePickerEnd.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerEnd.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(144, 29);
            this.dateTimePickerEnd.TabIndex = 5;
            this.dateTimePickerEnd.Value = new System.DateTime(2021, 2, 21, 11, 2, 22, 0);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 11;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090991F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090991F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090991F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090991F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090991F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090991F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090991F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090991F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090991F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090991F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090082F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 408);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 39);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTotalPaid);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(267, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(38, 33);
            this.panel5.TabIndex = 0;
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTotalPaid.AutoSize = true;
            this.lblTotalPaid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalPaid.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalPaid.Location = new System.Drawing.Point(-4, 6);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(42, 21);
            this.lblTotalPaid.TabIndex = 1;
            this.lblTotalPaid.Text = "Total";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblTotalExtDisc);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(223, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(38, 33);
            this.panel6.TabIndex = 1;
            // 
            // lblTotalExtDisc
            // 
            this.lblTotalExtDisc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTotalExtDisc.AutoSize = true;
            this.lblTotalExtDisc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalExtDisc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalExtDisc.Location = new System.Drawing.Point(-4, 6);
            this.lblTotalExtDisc.Name = "lblTotalExtDisc";
            this.lblTotalExtDisc.Size = new System.Drawing.Size(42, 21);
            this.lblTotalExtDisc.TabIndex = 1;
            this.lblTotalExtDisc.Text = "Total";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblTotalDisc);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(179, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(38, 33);
            this.panel7.TabIndex = 2;
            // 
            // lblTotalDisc
            // 
            this.lblTotalDisc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTotalDisc.AutoSize = true;
            this.lblTotalDisc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalDisc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalDisc.Location = new System.Drawing.Point(-4, 6);
            this.lblTotalDisc.Name = "lblTotalDisc";
            this.lblTotalDisc.Size = new System.Drawing.Size(42, 21);
            this.lblTotalDisc.TabIndex = 1;
            this.lblTotalDisc.Text = "Total";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblTotalAmnt);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(135, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(38, 33);
            this.panel8.TabIndex = 3;
            // 
            // lblTotalAmnt
            // 
            this.lblTotalAmnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTotalAmnt.AutoSize = true;
            this.lblTotalAmnt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalAmnt.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalAmnt.Location = new System.Drawing.Point(-4, 6);
            this.lblTotalAmnt.Name = "lblTotalAmnt";
            this.lblTotalAmnt.Size = new System.Drawing.Size(42, 21);
            this.lblTotalAmnt.TabIndex = 1;
            this.lblTotalAmnt.Text = "Total";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(91, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(38, 33);
            this.panel9.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(-4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.lblCount);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(38, 33);
            this.panel10.TabIndex = 5;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCount.Location = new System.Drawing.Point(-2, 6);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 21);
            this.lblCount.TabIndex = 2;
            // 
            // tblLayPnlSaleDetails
            // 
            this.tblLayPnlSaleDetails.ColumnCount = 3;
            this.tblLayPnlSaleDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblLayPnlSaleDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tblLayPnlSaleDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblLayPnlSaleDetails.Controls.Add(this.bunifuCustomLabel1, 1, 0);
            this.tblLayPnlSaleDetails.Controls.Add(this.panel2, 1, 2);
            this.tblLayPnlSaleDetails.Controls.Add(this.panel3, 1, 1);
            this.tblLayPnlSaleDetails.Controls.Add(this.panel4, 1, 3);
            this.tblLayPnlSaleDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayPnlSaleDetails.Location = new System.Drawing.Point(0, 0);
            this.tblLayPnlSaleDetails.Name = "tblLayPnlSaleDetails";
            this.tblLayPnlSaleDetails.RowCount = 4;
            this.tblLayPnlSaleDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayPnlSaleDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblLayPnlSaleDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblLayPnlSaleDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayPnlSaleDetails.Size = new System.Drawing.Size(550, 450);
            this.tblLayPnlSaleDetails.TabIndex = 4;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(186, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(176, 40);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "SALES VIEW";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewSalesDetails);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(30, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 318);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewSalesDetails
            // 
            this.dataGridViewSalesDetails.AllowCustomTheming = false;
            this.dataGridViewSalesDetails.AllowUserToAddRows = false;
            this.dataGridViewSalesDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSalesDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSalesDetails.AutoGenerateColumns = false;
            this.dataGridViewSalesDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSalesDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSalesDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewSalesDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalesDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSalesDetails.ColumnHeadersHeight = 40;
            this.dataGridViewSalesDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ctgNameDataGridViewTextBoxColumn1,
            this.pNameDataGridViewTextBoxColumn1,
            this.pSizeDataGridViewTextBoxColumn1,
            this.saleUnitPriceDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn1,
            this.discountDataGridViewTextBoxColumn2,
            this.subTotalDataGridViewTextBoxColumn1});
            this.dataGridViewSalesDetails.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewSalesDetails.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewSalesDetails.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSalesDetails.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewSalesDetails.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewSalesDetails.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewSalesDetails.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewSalesDetails.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewSalesDetails.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewSalesDetails.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewSalesDetails.CurrentTheme.Name = null;
            this.dataGridViewSalesDetails.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewSalesDetails.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewSalesDetails.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSalesDetails.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewSalesDetails.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewSalesDetails.DataSource = this.tblSaleDetailsViewBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSalesDetails.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSalesDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSalesDetails.EnableHeadersVisualStyles = false;
            this.dataGridViewSalesDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewSalesDetails.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewSalesDetails.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewSalesDetails.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewSalesDetails.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSalesDetails.Name = "dataGridViewSalesDetails";
            this.dataGridViewSalesDetails.ReadOnly = true;
            this.dataGridViewSalesDetails.RowHeadersVisible = false;
            this.dataGridViewSalesDetails.RowTemplate.Height = 40;
            this.dataGridViewSalesDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSalesDetails.Size = new System.Drawing.Size(489, 318);
            this.dataGridViewSalesDetails.TabIndex = 2;
            this.dataGridViewSalesDetails.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // ctgNameDataGridViewTextBoxColumn1
            // 
            this.ctgNameDataGridViewTextBoxColumn1.DataPropertyName = "ctgName";
            this.ctgNameDataGridViewTextBoxColumn1.FillWeight = 90F;
            this.ctgNameDataGridViewTextBoxColumn1.HeaderText = "Categorie";
            this.ctgNameDataGridViewTextBoxColumn1.Name = "ctgNameDataGridViewTextBoxColumn1";
            this.ctgNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pNameDataGridViewTextBoxColumn1
            // 
            this.pNameDataGridViewTextBoxColumn1.DataPropertyName = "pName";
            this.pNameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.pNameDataGridViewTextBoxColumn1.Name = "pNameDataGridViewTextBoxColumn1";
            this.pNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pSizeDataGridViewTextBoxColumn1
            // 
            this.pSizeDataGridViewTextBoxColumn1.DataPropertyName = "pSize";
            this.pSizeDataGridViewTextBoxColumn1.FillWeight = 70F;
            this.pSizeDataGridViewTextBoxColumn1.HeaderText = "Size";
            this.pSizeDataGridViewTextBoxColumn1.Name = "pSizeDataGridViewTextBoxColumn1";
            this.pSizeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // saleUnitPriceDataGridViewTextBoxColumn1
            // 
            this.saleUnitPriceDataGridViewTextBoxColumn1.DataPropertyName = "saleUnitPrice";
            this.saleUnitPriceDataGridViewTextBoxColumn1.FillWeight = 80F;
            this.saleUnitPriceDataGridViewTextBoxColumn1.HeaderText = "Unit Price";
            this.saleUnitPriceDataGridViewTextBoxColumn1.Name = "saleUnitPriceDataGridViewTextBoxColumn1";
            this.saleUnitPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn1.FillWeight = 80F;
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            this.quantityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn2
            // 
            this.discountDataGridViewTextBoxColumn2.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn2.FillWeight = 80F;
            this.discountDataGridViewTextBoxColumn2.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn2.Name = "discountDataGridViewTextBoxColumn2";
            this.discountDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // subTotalDataGridViewTextBoxColumn1
            // 
            this.subTotalDataGridViewTextBoxColumn1.DataPropertyName = "subTotal";
            this.subTotalDataGridViewTextBoxColumn1.FillWeight = 80F;
            this.subTotalDataGridViewTextBoxColumn1.HeaderText = "Sub Total";
            this.subTotalDataGridViewTextBoxColumn1.Name = "subTotalDataGridViewTextBoxColumn1";
            this.subTotalDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tblSaleDetailsViewBindingSource
            // 
            this.tblSaleDetailsViewBindingSource.DataMember = "tblSaleDetailsView";
            this.tblSaleDetailsViewBindingSource.DataSource = this.appData1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPhoneSaleView);
            this.panel3.Controls.Add(this.lblNameSalesView);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(30, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 39);
            this.panel3.TabIndex = 3;
            // 
            // lblPhoneSaleView
            // 
            this.lblPhoneSaleView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPhoneSaleView.AutoSize = true;
            this.lblPhoneSaleView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhoneSaleView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPhoneSaleView.Location = new System.Drawing.Point(298, 8);
            this.lblPhoneSaleView.Name = "lblPhoneSaleView";
            this.lblPhoneSaleView.Size = new System.Drawing.Size(14, 21);
            this.lblPhoneSaleView.TabIndex = 7;
            this.lblPhoneSaleView.Text = " ";
            // 
            // lblNameSalesView
            // 
            this.lblNameSalesView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNameSalesView.AutoSize = true;
            this.lblNameSalesView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNameSalesView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNameSalesView.Location = new System.Drawing.Point(145, 8);
            this.lblNameSalesView.Name = "lblNameSalesView";
            this.lblNameSalesView.Size = new System.Drawing.Size(14, 21);
            this.lblNameSalesView.TabIndex = 6;
            this.lblNameSalesView.Text = " ";
            // 
            // btnBack
            // 
            this.btnBack.Active = false;
            this.btnBack.Activecolor = System.Drawing.Color.Transparent;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.BorderRadius = 0;
            this.btnBack.ButtonText = "";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledColor = System.Drawing.Color.Gray;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBack.Iconimage = global::ERP.Properties.Resources.back_arrow_25px;
            this.btnBack.Iconimage_right = null;
            this.btnBack.Iconimage_right_Selected = null;
            this.btnBack.Iconimage_Selected = null;
            this.btnBack.IconMarginLeft = 0;
            this.btnBack.IconMarginRight = 0;
            this.btnBack.IconRightVisible = true;
            this.btnBack.IconRightZoom = 0D;
            this.btnBack.IconVisible = true;
            this.btnBack.IconZoom = 60D;
            this.btnBack.IsTab = false;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBack.OnHovercolor = System.Drawing.Color.Crimson;
            this.btnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(39, 39);
            this.btnBack.TabIndex = 5;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.Textcolor = System.Drawing.Color.White;
            this.btnBack.TextFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Active = false;
            this.btnPrint.Activecolor = System.Drawing.Color.Transparent;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.BorderRadius = 0;
            this.btnPrint.ButtonText = "";
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
            this.btnPrint.Location = new System.Drawing.Point(451, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPrint.OnHovercolor = System.Drawing.Color.DeepSkyBlue;
            this.btnPrint.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrint.selected = false;
            this.btnPrint.Size = new System.Drawing.Size(38, 39);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.Textcolor = System.Drawing.Color.White;
            this.btnPrint.TextFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtTotalAmount);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(30, 412);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(489, 35);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(353, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total :  ";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTotalAmount.Location = new System.Drawing.Point(417, 0);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(72, 29);
            this.txtTotalAmount.TabIndex = 0;
            // 
            // tblSalesViewTableAdapter
            // 
            this.tblSalesViewTableAdapter.ClearBeforeFill = true;
            // 
            // tblSaleDetailsViewTableAdapter
            // 
            this.tblSaleDetailsViewTableAdapter.ClearBeforeFill = true;
            // 
            // frmViewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.tblLayPnlSaleView);
            this.Controls.Add(this.tblLayPnlSaleDetails);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewSales";
            this.Text = "frmViewSales";
            this.Load += new System.EventHandler(this.frmViewSales_Load);
            this.tblLayPnlSaleView.ResumeLayout(false);
            this.tblLayPnlSaleView.PerformLayout();
            this.pnlGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.tblLayPnlSaleDetails.ResumeLayout(false);
            this.tblLayPnlSaleDetails.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleDetailsViewBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayPnlSaleView;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private System.Windows.Forms.Panel pnlGridView;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.TableLayoutPanel tblLayPnlSaleDetails;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrint;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label1;
        private AppData appData1;
        private System.Windows.Forms.BindingSource tblSalesViewBindingSource;
        private AppDataTableAdapters.tblSalesViewTableAdapter tblSalesViewTableAdapter;
        private System.Windows.Forms.Label lblPhoneSaleView;
        private System.Windows.Forms.Label lblNameSalesView;
        private System.Windows.Forms.BindingSource tblSaleDetailsViewBindingSource;
        private AppDataTableAdapters.tblSaleDetailsViewTableAdapter tblSaleDetailsViewTableAdapter;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewSales;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewSalesDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctgNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSizeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleUnitPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotalExtDisc;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblTotalDisc;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblTotalAmnt;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overallDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidAmntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblCount;
    }
}