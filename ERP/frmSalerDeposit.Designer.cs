
namespace ERP
{
    partial class frmSalerDeposit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalerDeposit));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblDepositBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet = new ERP.mainDataSet();
            this.bunifuRadioButton2 = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.pnlView = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDeposit = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.depositIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnlDepositSubmition = new System.Windows.Forms.Panel();
            this.txtAmnt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.tblDepositTableAdapter = new ERP.mainDataSetTableAdapters.tblDepositTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepositBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            this.pnlView.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeposit)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlDepositSubmition.SuspendLayout();
            this.pnlPrint.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDepositBindingSource
            // 
            this.tblDepositBindingSource.DataMember = "tblDeposit";
            this.tblDepositBindingSource.DataSource = this.mainDataSet;
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "mainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuRadioButton2
            // 
            this.bunifuRadioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuRadioButton2.Checked = true;
            this.bunifuRadioButton2.Location = new System.Drawing.Point(-18, -73);
            this.bunifuRadioButton2.Name = "bunifuRadioButton2";
            this.bunifuRadioButton2.OutlineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuRadioButton2.RadioColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuRadioButton2.Size = new System.Drawing.Size(591, 591);
            this.bunifuRadioButton2.TabIndex = 0;
            this.bunifuRadioButton2.Text = null;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(198, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "DEPOSIT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(217, 224);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(107, 38);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSubmit_KeyDown);
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnView.Location = new System.Drawing.Point(217, 282);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(107, 38);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            this.btnView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnView_KeyDown);
            // 
            // pnlView
            // 
            this.pnlView.Controls.Add(this.tableLayoutPanel2);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(550, 450);
            this.pnlView.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Controls.Add(this.btnPrint, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewDeposit, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(550, 450);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnPrint.Location = new System.Drawing.Point(227, 397);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(95, 39);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(161, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "VIEW DEPOSIT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewDeposit
            // 
            this.dataGridViewDeposit.AllowCustomTheming = true;
            this.dataGridViewDeposit.AllowUserToAddRows = false;
            this.dataGridViewDeposit.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewDeposit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDeposit.AutoGenerateColumns = false;
            this.dataGridViewDeposit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDeposit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDeposit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewDeposit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDeposit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeposit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depositIdDataGridViewTextBoxColumn,
            this.amntDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn});
            this.dataGridViewDeposit.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewDeposit.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewDeposit.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewDeposit.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewDeposit.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewDeposit.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewDeposit.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewDeposit.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewDeposit.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridViewDeposit.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewDeposit.CurrentTheme.Name = null;
            this.dataGridViewDeposit.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewDeposit.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.dataGridViewDeposit.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewDeposit.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewDeposit.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewDeposit.DataSource = this.tblDepositBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDeposit.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDeposit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDeposit.EnableHeadersVisualStyles = false;
            this.dataGridViewDeposit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewDeposit.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewDeposit.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewDeposit.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewDeposit.Location = new System.Drawing.Point(13, 100);
            this.dataGridViewDeposit.Name = "dataGridViewDeposit";
            this.dataGridViewDeposit.ReadOnly = true;
            this.dataGridViewDeposit.RowHeadersVisible = false;
            this.dataGridViewDeposit.RowTemplate.Height = 40;
            this.dataGridViewDeposit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDeposit.Size = new System.Drawing.Size(524, 291);
            this.dataGridViewDeposit.TabIndex = 2;
            this.dataGridViewDeposit.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridViewDeposit.VirtualMode = true;
            // 
            // depositIdDataGridViewTextBoxColumn
            // 
            this.depositIdDataGridViewTextBoxColumn.DataPropertyName = "depositId";
            this.depositIdDataGridViewTextBoxColumn.HeaderText = "depositId";
            this.depositIdDataGridViewTextBoxColumn.Name = "depositIdDataGridViewTextBoxColumn";
            this.depositIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.depositIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // amntDataGridViewTextBoxColumn
            // 
            this.amntDataGridViewTextBoxColumn.DataPropertyName = "amnt";
            this.amntDataGridViewTextBoxColumn.HeaderText = "Amont";
            this.amntDataGridViewTextBoxColumn.Name = "amntDataGridViewTextBoxColumn";
            this.amntDataGridViewTextBoxColumn.ReadOnly = true;
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
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(13, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 39);
            this.panel1.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(370, 3);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 34);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(177, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "To";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Segoe UI", 8F);
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(217, 6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(135, 29);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.Value = new System.DateTime(2021, 2, 28, 21, 5, 37, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 8F);
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 29);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2021, 2, 28, 21, 5, 37, 0);
            // 
            // pnlDepositSubmition
            // 
            this.pnlDepositSubmition.Controls.Add(this.btnView);
            this.pnlDepositSubmition.Controls.Add(this.btnSubmit);
            this.pnlDepositSubmition.Controls.Add(this.txtAmnt);
            this.pnlDepositSubmition.Controls.Add(this.label1);
            this.pnlDepositSubmition.Controls.Add(this.bunifuRadioButton2);
            this.pnlDepositSubmition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDepositSubmition.Location = new System.Drawing.Point(0, 0);
            this.pnlDepositSubmition.Name = "pnlDepositSubmition";
            this.pnlDepositSubmition.Size = new System.Drawing.Size(550, 450);
            this.pnlDepositSubmition.TabIndex = 6;
            // 
            // txtAmnt
            // 
            this.txtAmnt.AcceptsReturn = false;
            this.txtAmnt.AcceptsTab = false;
            this.txtAmnt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAmnt.AnimationSpeed = 200;
            this.txtAmnt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAmnt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAmnt.BackColor = System.Drawing.Color.White;
            this.txtAmnt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAmnt.BackgroundImage")));
            this.txtAmnt.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtAmnt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtAmnt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtAmnt.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtAmnt.BorderRadius = 1;
            this.txtAmnt.BorderThickness = 1;
            this.txtAmnt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAmnt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmnt.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.txtAmnt.DefaultText = "";
            this.txtAmnt.FillColor = System.Drawing.Color.White;
            this.txtAmnt.HideSelection = true;
            this.txtAmnt.IconLeft = null;
            this.txtAmnt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmnt.IconPadding = 10;
            this.txtAmnt.IconRight = null;
            this.txtAmnt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmnt.Lines = new string[0];
            this.txtAmnt.Location = new System.Drawing.Point(170, 169);
            this.txtAmnt.MaxLength = 32767;
            this.txtAmnt.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtAmnt.Modified = false;
            this.txtAmnt.Multiline = false;
            this.txtAmnt.Name = "txtAmnt";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAmnt.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAmnt.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAmnt.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAmnt.OnIdleState = stateProperties8;
            this.txtAmnt.PasswordChar = '\0';
            this.txtAmnt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAmnt.PlaceholderText = "Enter text";
            this.txtAmnt.ReadOnly = false;
            this.txtAmnt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmnt.SelectedText = "";
            this.txtAmnt.SelectionLength = 0;
            this.txtAmnt.SelectionStart = 0;
            this.txtAmnt.ShortcutsEnabled = true;
            this.txtAmnt.Size = new System.Drawing.Size(200, 35);
            this.txtAmnt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtAmnt.TabIndex = 2;
            this.txtAmnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmnt.TextMarginBottom = 0;
            this.txtAmnt.TextMarginLeft = 5;
            this.txtAmnt.TextMarginTop = 0;
            this.txtAmnt.TextPlaceholder = "Enter text";
            this.txtAmnt.UseSystemPasswordChar = false;
            this.txtAmnt.WordWrap = true;
            this.txtAmnt.TextChanged += new System.EventHandler(this.txtAmnt_TextChanged);
            this.txtAmnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmnt_KeyDown);
            // 
            // pnlPrint
            // 
            this.pnlPrint.Controls.Add(this.tableLayoutPanel1);
            this.pnlPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrint.Location = new System.Drawing.Point(0, 0);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(550, 450);
            this.pnlPrint.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.reportViewer1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 450);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tblDepositBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERP.Reports.rptDeposit.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(524, 368);
            this.reportViewer1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(161, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 66);
            this.label3.TabIndex = 2;
            this.label3.Text = "VIEW DEPOSIT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblDepositTableAdapter
            // 
            this.tblDepositTableAdapter.ClearBeforeFill = true;
            // 
            // frmSalerDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.pnlDepositSubmition);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.pnlPrint);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalerDeposit";
            this.Text = "frmSalerDeposit";
            this.Load += new System.EventHandler(this.frmSalerDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDepositBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            this.pnlView.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeposit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDepositSubmition.ResumeLayout(false);
            this.pnlDepositSubmition.PerformLayout();
            this.pnlPrint.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuRadioButton bunifuRadioButton2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtAmnt;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Panel pnlDepositSubmition;
        private System.Windows.Forms.Panel pnlPrint;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewDeposit;
        private mainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource tblDepositBindingSource;
        private mainDataSetTableAdapters.tblDepositTableAdapter tblDepositTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}