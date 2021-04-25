
namespace ERP
{
    partial class frmReportInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportInvoice));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblSaleDetailsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AppData = new ERP.AppData();
            this.pnlSaleReport = new System.Windows.Forms.Panel();
            this.tblLayPnlSaleView = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlGridView = new System.Windows.Forms.Panel();
            this.dataGridViewInvoice = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.saleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidAmntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Print = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlPrinting = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblSaleDetailsViewTableAdapter = new ERP.AppDataTableAdapters.tblSaleDetailsViewTableAdapter();
            this.tblInvoiceTableAdapter = new ERP.AppDataTableAdapters.tblInvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleDetailsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppData)).BeginInit();
            this.pnlSaleReport.SuspendLayout();
            this.tblLayPnlSaleView.SuspendLayout();
            this.pnlGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblInvoiceBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlPrinting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblSaleDetailsViewBindingSource
            // 
            this.tblSaleDetailsViewBindingSource.DataMember = "tblSaleDetailsView";
            this.tblSaleDetailsViewBindingSource.DataSource = this.AppData;
            // 
            // AppData
            // 
            this.AppData.DataSetName = "AppData";
            this.AppData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlSaleReport
            // 
            this.pnlSaleReport.Controls.Add(this.tblLayPnlSaleView);
            this.pnlSaleReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSaleReport.Location = new System.Drawing.Point(0, 0);
            this.pnlSaleReport.Name = "pnlSaleReport";
            this.pnlSaleReport.Size = new System.Drawing.Size(550, 450);
            this.pnlSaleReport.TabIndex = 8;
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
            this.lblTitle.Location = new System.Drawing.Point(135, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(278, 40);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "GENERATE INVOICE";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGridView
            // 
            this.pnlGridView.Controls.Add(this.dataGridViewInvoice);
            this.pnlGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridView.Location = new System.Drawing.Point(30, 88);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Size = new System.Drawing.Size(489, 318);
            this.pnlGridView.TabIndex = 1;
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.AllowCustomTheming = true;
            this.dataGridViewInvoice.AllowUserToAddRows = false;
            this.dataGridViewInvoice.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(242)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewInvoice.AutoGenerateColumns = false;
            this.dataGridViewInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewInvoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewInvoice.ColumnHeadersHeight = 40;
            this.dataGridViewInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIdDataGridViewTextBoxColumn,
            this.cstNameDataGridViewTextBoxColumn,
            this.cstPhoneDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.totalAmntDataGridViewTextBoxColumn,
            this.paidAmntDataGridViewTextBoxColumn,
            this.Print});
            this.dataGridViewInvoice.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(242)))), ((int)(((byte)(203)))));
            this.dataGridViewInvoice.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewInvoice.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewInvoice.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(225)))), ((int)(((byte)(132)))));
            this.dataGridViewInvoice.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewInvoice.CurrentTheme.BackColor = System.Drawing.Color.LimeGreen;
            this.dataGridViewInvoice.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(240)))), ((int)(((byte)(193)))));
            this.dataGridViewInvoice.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.LimeGreen;
            this.dataGridViewInvoice.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridViewInvoice.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewInvoice.CurrentTheme.Name = null;
            this.dataGridViewInvoice.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(245)))), ((int)(((byte)(214)))));
            this.dataGridViewInvoice.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.dataGridViewInvoice.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewInvoice.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(225)))), ((int)(((byte)(132)))));
            this.dataGridViewInvoice.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewInvoice.DataSource = this.tblInvoiceBindingSource;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(245)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(225)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInvoice.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInvoice.EnableHeadersVisualStyles = false;
            this.dataGridViewInvoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(240)))), ((int)(((byte)(193)))));
            this.dataGridViewInvoice.HeaderBackColor = System.Drawing.Color.LimeGreen;
            this.dataGridViewInvoice.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewInvoice.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewInvoice.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.ReadOnly = true;
            this.dataGridViewInvoice.RowHeadersVisible = false;
            this.dataGridViewInvoice.RowTemplate.Height = 40;
            this.dataGridViewInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(489, 318);
            this.dataGridViewInvoice.TabIndex = 4;
            this.dataGridViewInvoice.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.LimeGreen;
            this.dataGridViewInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInvoice_CellContentClick);
            // 
            // saleIdDataGridViewTextBoxColumn
            // 
            this.saleIdDataGridViewTextBoxColumn.DataPropertyName = "saleId";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle21;
            this.saleIdDataGridViewTextBoxColumn.FillWeight = 50F;
            this.saleIdDataGridViewTextBoxColumn.HeaderText = "Sale ID";
            this.saleIdDataGridViewTextBoxColumn.Name = "saleIdDataGridViewTextBoxColumn";
            this.saleIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cstNameDataGridViewTextBoxColumn
            // 
            this.cstNameDataGridViewTextBoxColumn.DataPropertyName = "cstName";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cstNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle22;
            this.cstNameDataGridViewTextBoxColumn.HeaderText = "Cst Name";
            this.cstNameDataGridViewTextBoxColumn.Name = "cstNameDataGridViewTextBoxColumn";
            this.cstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cstPhoneDataGridViewTextBoxColumn
            // 
            this.cstPhoneDataGridViewTextBoxColumn.DataPropertyName = "cstPhone";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cstPhoneDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle23;
            this.cstPhoneDataGridViewTextBoxColumn.FillWeight = 70F;
            this.cstPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.cstPhoneDataGridViewTextBoxColumn.Name = "cstPhoneDataGridViewTextBoxColumn";
            this.cstPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle24;
            this.dateDataGridViewTextBoxColumn.FillWeight = 70F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmntDataGridViewTextBoxColumn
            // 
            this.totalAmntDataGridViewTextBoxColumn.DataPropertyName = "totalAmnt";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmntDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle25;
            this.totalAmntDataGridViewTextBoxColumn.FillWeight = 60F;
            this.totalAmntDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalAmntDataGridViewTextBoxColumn.Name = "totalAmntDataGridViewTextBoxColumn";
            this.totalAmntDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paidAmntDataGridViewTextBoxColumn
            // 
            this.paidAmntDataGridViewTextBoxColumn.DataPropertyName = "PaidAmnt";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidAmntDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle26;
            this.paidAmntDataGridViewTextBoxColumn.FillWeight = 60F;
            this.paidAmntDataGridViewTextBoxColumn.HeaderText = "Paid";
            this.paidAmntDataGridViewTextBoxColumn.Name = "paidAmntDataGridViewTextBoxColumn";
            this.paidAmntDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Print
            // 
            this.Print.FillWeight = 70F;
            this.Print.HeaderText = "Print";
            this.Print.Name = "Print";
            this.Print.ReadOnly = true;
            this.Print.Text = "Print";
            this.Print.UseColumnTextForButtonValue = true;
            // 
            // tblInvoiceBindingSource
            // 
            this.tblInvoiceBindingSource.DataMember = "tblInvoice";
            this.tblInvoiceBindingSource.DataSource = this.AppData;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(30, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 39);
            this.panel1.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearch.BorderRadius = 1;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.LimeGreen;
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(92, 2);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties9.BorderColor = System.Drawing.Color.SeaGreen;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Empty;
            stateProperties10.FillColor = System.Drawing.Color.White;
            stateProperties10.ForeColor = System.Drawing.Color.Empty;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(0)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.LimeGreen;
            stateProperties12.ForeColor = System.Drawing.Color.White;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties12;
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.PlaceholderText = "Enter Name";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(191, 35);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 5;
            this.txtSearch.TextMarginTop = 0;
            this.txtSearch.TextPlaceholder = "Enter Name";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Active = false;
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnSearch.IconZoom = 55D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(289, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.Green;
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(107, 35);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlPrinting
            // 
            this.pnlPrinting.Controls.Add(this.tableLayoutPanel1);
            this.pnlPrinting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrinting.Location = new System.Drawing.Point(0, 0);
            this.pnlPrinting.Name = "pnlPrinting";
            this.pnlPrinting.Size = new System.Drawing.Size(550, 450);
            this.pnlPrinting.TabIndex = 9;
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
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(186, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(177, 44);
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
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.tblSaleDetailsViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERP.Reports.Memo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(489, 372);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblSaleDetailsViewTableAdapter
            // 
            this.tblSaleDetailsViewTableAdapter.ClearBeforeFill = true;
            // 
            // tblInvoiceTableAdapter
            // 
            this.tblInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(104)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.pnlSaleReport);
            this.Controls.Add(this.pnlPrinting);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportInvoice";
            this.Text = "frmReportInvoice";
            this.Load += new System.EventHandler(this.frmReportInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleDetailsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppData)).EndInit();
            this.pnlSaleReport.ResumeLayout(false);
            this.tblLayPnlSaleView.ResumeLayout(false);
            this.tblLayPnlSaleView.PerformLayout();
            this.pnlGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblInvoiceBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlPrinting.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSaleReport;
        private System.Windows.Forms.TableLayoutPanel tblLayPnlSaleView;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private System.Windows.Forms.Panel pnlGridView;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewInvoice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPrinting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblSaleDetailsViewBindingSource;
        private AppData AppData;
        private AppDataTableAdapters.tblSaleDetailsViewTableAdapter tblSaleDetailsViewTableAdapter;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private System.Windows.Forms.BindingSource tblInvoiceBindingSource;
        private AppDataTableAdapters.tblInvoiceTableAdapter tblInvoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidAmntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Print;
    }
}