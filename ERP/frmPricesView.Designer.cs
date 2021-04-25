
namespace ERP
{
    partial class frmPricesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPricesView));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridviewPriceView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalQun = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSearch = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtCategorie = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.appData = new ERP.AppData();
            this.tblPriceViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPriceViewTableAdapter = new ERP.AppDataTableAdapters.tblPriceViewTableAdapter();
            this.ctgNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblTotalPPrice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblTotalSPrice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblTotalDisc = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewPriceView)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPriceViewBindingSource)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 450);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(169, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 36);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "PRICE VIEW ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridviewPriceView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(30, 84);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panel1.Size = new System.Drawing.Size(489, 318);
            this.panel1.TabIndex = 3;
            // 
            // dataGridviewPriceView
            // 
            this.dataGridviewPriceView.AllowCustomTheming = true;
            this.dataGridviewPriceView.AllowUserToAddRows = false;
            this.dataGridviewPriceView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridviewPriceView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridviewPriceView.AutoGenerateColumns = false;
            this.dataGridviewPriceView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridviewPriceView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridviewPriceView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridviewPriceView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridviewPriceView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridviewPriceView.ColumnHeadersHeight = 40;
            this.dataGridviewPriceView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ctgNameDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn,
            this.pSizeDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.pPriceDataGridViewTextBoxColumn,
            this.sPriceDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn});
            this.dataGridviewPriceView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridviewPriceView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridviewPriceView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridviewPriceView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridviewPriceView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridviewPriceView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridviewPriceView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridviewPriceView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridviewPriceView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridviewPriceView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridviewPriceView.CurrentTheme.Name = null;
            this.dataGridviewPriceView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridviewPriceView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.dataGridviewPriceView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridviewPriceView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridviewPriceView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridviewPriceView.DataSource = this.tblPriceViewBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridviewPriceView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridviewPriceView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridviewPriceView.EnableHeadersVisualStyles = false;
            this.dataGridviewPriceView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridviewPriceView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridviewPriceView.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridviewPriceView.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridviewPriceView.Location = new System.Drawing.Point(10, 10);
            this.dataGridviewPriceView.Name = "dataGridviewPriceView";
            this.dataGridviewPriceView.ReadOnly = true;
            this.dataGridviewPriceView.RowHeadersVisible = false;
            this.dataGridviewPriceView.RowTemplate.Height = 40;
            this.dataGridviewPriceView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridviewPriceView.Size = new System.Drawing.Size(469, 308);
            this.dataGridviewPriceView.TabIndex = 2;
            this.dataGridviewPriceView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtCategorie);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(30, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 39);
            this.panel3.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Controls.Add(this.panel10, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(30, 408);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(489, 39);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotalQun);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(210, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel2.Size = new System.Drawing.Size(63, 33);
            this.panel2.TabIndex = 4;
            // 
            // lblTotalQun
            // 
            this.lblTotalQun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTotalQun.AutoSize = true;
            this.lblTotalQun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQun.ForeColor = System.Drawing.Color.White;
            this.lblTotalQun.Location = new System.Drawing.Point(14, 7);
            this.lblTotalQun.Name = "lblTotalQun";
            this.lblTotalQun.Size = new System.Drawing.Size(36, 20);
            this.lblTotalQun.TabIndex = 3;
            this.lblTotalQun.Text = "000";
            this.lblTotalQun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bunifuCustomLabel1);
            this.panel4.Location = new System.Drawing.Point(141, 3);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel4.Size = new System.Drawing.Size(63, 33);
            this.panel4.TabIndex = 5;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(6, 7);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(52, 20);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Total :";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.AllowToggling = false;
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.btnSearch.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnSearch.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearch.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSearch.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.IconMarginLeft = 11;
            this.btnSearch.IconPadding = 10;
            this.btnSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.IdleBorderRadius = 3;
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.IdleIconLeftImage = null;
            this.btnSearch.IdleIconRightImage = null;
            this.btnSearch.IndicateFocus = false;
            this.btnSearch.Location = new System.Drawing.Point(274, 0);
            this.btnSearch.Name = "btnSearch";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnSearch.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnSearch.OnPressedState = stateProperties2;
            this.btnSearch.Size = new System.Drawing.Size(109, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.TextMarginLeft = 0;
            this.btnSearch.UseDefaultRadiusAndThickness = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCategorie
            // 
            this.txtCategorie.AcceptsReturn = false;
            this.txtCategorie.AcceptsTab = false;
            this.txtCategorie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCategorie.AnimationSpeed = 200;
            this.txtCategorie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCategorie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCategorie.BackColor = System.Drawing.Color.Transparent;
            this.txtCategorie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCategorie.BackgroundImage")));
            this.txtCategorie.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtCategorie.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtCategorie.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtCategorie.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtCategorie.BorderRadius = 1;
            this.txtCategorie.BorderThickness = 1;
            this.txtCategorie.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCategorie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategorie.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.txtCategorie.DefaultText = "";
            this.txtCategorie.FillColor = System.Drawing.Color.White;
            this.txtCategorie.HideSelection = true;
            this.txtCategorie.IconLeft = null;
            this.txtCategorie.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategorie.IconPadding = 10;
            this.txtCategorie.IconRight = null;
            this.txtCategorie.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategorie.Lines = new string[0];
            this.txtCategorie.Location = new System.Drawing.Point(68, 0);
            this.txtCategorie.MaxLength = 32767;
            this.txtCategorie.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtCategorie.Modified = false;
            this.txtCategorie.Multiline = false;
            this.txtCategorie.Name = "txtCategorie";
            stateProperties3.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCategorie.OnActiveState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Empty;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtCategorie.OnDisabledState = stateProperties4;
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCategorie.OnHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Silver;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCategorie.OnIdleState = stateProperties6;
            this.txtCategorie.PasswordChar = '\0';
            this.txtCategorie.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtCategorie.PlaceholderText = "Categorie";
            this.txtCategorie.ReadOnly = false;
            this.txtCategorie.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCategorie.SelectedText = "";
            this.txtCategorie.SelectionLength = 0;
            this.txtCategorie.SelectionStart = 0;
            this.txtCategorie.ShortcutsEnabled = true;
            this.txtCategorie.Size = new System.Drawing.Size(178, 35);
            this.txtCategorie.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtCategorie.TabIndex = 0;
            this.txtCategorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCategorie.TextMarginBottom = 0;
            this.txtCategorie.TextMarginLeft = 5;
            this.txtCategorie.TextMarginTop = 0;
            this.txtCategorie.TextPlaceholder = "Categorie";
            this.txtCategorie.UseSystemPasswordChar = false;
            this.txtCategorie.WordWrap = true;
            this.txtCategorie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCategorie_KeyDown);
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPriceViewBindingSource
            // 
            this.tblPriceViewBindingSource.DataMember = "tblPriceView";
            this.tblPriceViewBindingSource.DataSource = this.appData;
            // 
            // tblPriceViewTableAdapter
            // 
            this.tblPriceViewTableAdapter.ClearBeforeFill = true;
            // 
            // ctgNameDataGridViewTextBoxColumn
            // 
            this.ctgNameDataGridViewTextBoxColumn.DataPropertyName = "ctgName";
            this.ctgNameDataGridViewTextBoxColumn.HeaderText = "Categorie";
            this.ctgNameDataGridViewTextBoxColumn.Name = "ctgNameDataGridViewTextBoxColumn";
            this.ctgNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ctgNameDataGridViewTextBoxColumn.ToolTipText = "Categorie Name";
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "pName";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            this.pNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pNameDataGridViewTextBoxColumn.ToolTipText = "Product Name";
            // 
            // pSizeDataGridViewTextBoxColumn
            // 
            this.pSizeDataGridViewTextBoxColumn.DataPropertyName = "pSize";
            this.pSizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.pSizeDataGridViewTextBoxColumn.Name = "pSizeDataGridViewTextBoxColumn";
            this.pSizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.pSizeDataGridViewTextBoxColumn.ToolTipText = "Product Size";
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
            this.pPriceDataGridViewTextBoxColumn.HeaderText = "Purchase Price";
            this.pPriceDataGridViewTextBoxColumn.Name = "pPriceDataGridViewTextBoxColumn";
            this.pPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPriceDataGridViewTextBoxColumn
            // 
            this.sPriceDataGridViewTextBoxColumn.DataPropertyName = "sPrice";
            this.sPriceDataGridViewTextBoxColumn.HeaderText = "Sale Price";
            this.sPriceDataGridViewTextBoxColumn.Name = "sPriceDataGridViewTextBoxColumn";
            this.sPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblTotalPPrice);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(279, 3);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel8.Size = new System.Drawing.Size(63, 33);
            this.panel8.TabIndex = 8;
            // 
            // lblTotalPPrice
            // 
            this.lblTotalPPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTotalPPrice.AutoSize = true;
            this.lblTotalPPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPPrice.Location = new System.Drawing.Point(14, 7);
            this.lblTotalPPrice.Name = "lblTotalPPrice";
            this.lblTotalPPrice.Size = new System.Drawing.Size(36, 20);
            this.lblTotalPPrice.TabIndex = 3;
            this.lblTotalPPrice.Text = "000";
            this.lblTotalPPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lblTotalSPrice);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(348, 3);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel9.Size = new System.Drawing.Size(63, 33);
            this.panel9.TabIndex = 9;
            // 
            // lblTotalSPrice
            // 
            this.lblTotalSPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTotalSPrice.AutoSize = true;
            this.lblTotalSPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalSPrice.Location = new System.Drawing.Point(14, 7);
            this.lblTotalSPrice.Name = "lblTotalSPrice";
            this.lblTotalSPrice.Size = new System.Drawing.Size(36, 20);
            this.lblTotalSPrice.TabIndex = 3;
            this.lblTotalSPrice.Text = "000";
            this.lblTotalSPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.lblTotalDisc);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(417, 3);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel10.Size = new System.Drawing.Size(69, 33);
            this.panel10.TabIndex = 10;
            // 
            // lblTotalDisc
            // 
            this.lblTotalDisc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTotalDisc.AutoSize = true;
            this.lblTotalDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDisc.ForeColor = System.Drawing.Color.White;
            this.lblTotalDisc.Location = new System.Drawing.Point(17, 7);
            this.lblTotalDisc.Name = "lblTotalDisc";
            this.lblTotalDisc.Size = new System.Drawing.Size(36, 20);
            this.lblTotalDisc.TabIndex = 3;
            this.lblTotalDisc.Text = "000";
            this.lblTotalDisc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPricesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPricesView";
            this.Text = "frmPricesView";
            this.Load += new System.EventHandler(this.frmPricesView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewPriceView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPriceViewBindingSource)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridviewPriceView;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSearch;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtCategorie;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTotalQun;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private AppData appData;
        private System.Windows.Forms.BindingSource tblPriceViewBindingSource;
        private AppDataTableAdapters.tblPriceViewTableAdapter tblPriceViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctgNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel10;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTotalDisc;
        private System.Windows.Forms.Panel panel9;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTotalSPrice;
        private System.Windows.Forms.Panel panel8;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTotalPPrice;
    }
}