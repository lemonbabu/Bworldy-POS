
namespace ERP
{
    partial class frmCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategories));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCtgName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnAddCtg = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGrdViewCtg = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ctgIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctgNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctgUsedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet = new ERP.mainDataSet();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tblCategoriesTableAdapter = new ERP.mainDataSetTableAdapters.tblCategoriesTableAdapter();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdViewCtg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 450);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 450);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCtgName);
            this.panel2.Controls.Add(this.btnAddCtg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(30, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 39);
            this.panel2.TabIndex = 0;
            // 
            // txtCtgName
            // 
            this.txtCtgName.AcceptsReturn = false;
            this.txtCtgName.AcceptsTab = false;
            this.txtCtgName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCtgName.AnimationSpeed = 200;
            this.txtCtgName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCtgName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCtgName.BackColor = System.Drawing.Color.Transparent;
            this.txtCtgName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCtgName.BackgroundImage")));
            this.txtCtgName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtCtgName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtCtgName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtCtgName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtCtgName.BorderRadius = 1;
            this.txtCtgName.BorderThickness = 1;
            this.txtCtgName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCtgName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCtgName.DefaultFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCtgName.DefaultText = "";
            this.txtCtgName.FillColor = System.Drawing.Color.White;
            this.txtCtgName.HideSelection = true;
            this.txtCtgName.IconLeft = null;
            this.txtCtgName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCtgName.IconPadding = 10;
            this.txtCtgName.IconRight = null;
            this.txtCtgName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCtgName.Lines = new string[0];
            this.txtCtgName.Location = new System.Drawing.Point(53, 1);
            this.txtCtgName.MaxLength = 32767;
            this.txtCtgName.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtCtgName.Modified = false;
            this.txtCtgName.Multiline = false;
            this.txtCtgName.Name = "txtCtgName";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCtgName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtCtgName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCtgName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCtgName.OnIdleState = stateProperties4;
            this.txtCtgName.PasswordChar = '\0';
            this.txtCtgName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtCtgName.PlaceholderText = "Product Name";
            this.txtCtgName.ReadOnly = false;
            this.txtCtgName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCtgName.SelectedText = "";
            this.txtCtgName.SelectionLength = 0;
            this.txtCtgName.SelectionStart = 0;
            this.txtCtgName.ShortcutsEnabled = true;
            this.txtCtgName.Size = new System.Drawing.Size(233, 35);
            this.txtCtgName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtCtgName.TabIndex = 5;
            this.txtCtgName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCtgName.TextMarginBottom = 0;
            this.txtCtgName.TextMarginLeft = 5;
            this.txtCtgName.TextMarginTop = 0;
            this.txtCtgName.TextPlaceholder = "Product Name";
            this.txtCtgName.UseSystemPasswordChar = false;
            this.txtCtgName.WordWrap = true;
            this.txtCtgName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCtgName_KeyDown);
            // 
            // btnAddCtg
            // 
            this.btnAddCtg.ActiveBorderThickness = 1;
            this.btnAddCtg.ActiveCornerRadius = 1;
            this.btnAddCtg.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCtg.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddCtg.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCtg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCtg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAddCtg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCtg.BackgroundImage")));
            this.btnAddCtg.ButtonText = "Add New";
            this.btnAddCtg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCtg.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCtg.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCtg.IdleBorderThickness = 1;
            this.btnAddCtg.IdleCornerRadius = 1;
            this.btnAddCtg.IdleFillColor = System.Drawing.Color.White;
            this.btnAddCtg.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.btnAddCtg.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCtg.Location = new System.Drawing.Point(305, -4);
            this.btnAddCtg.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddCtg.Name = "btnAddCtg";
            this.btnAddCtg.Size = new System.Drawing.Size(113, 45);
            this.btnAddCtg.TabIndex = 10;
            this.btnAddCtg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCtg.Click += new System.EventHandler(this.btnAddCtg_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGrdViewCtg);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(30, 108);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(489, 338);
            this.panel3.TabIndex = 1;
            // 
            // dataGrdViewCtg
            // 
            this.dataGrdViewCtg.AllowCustomTheming = true;
            this.dataGrdViewCtg.AllowUserToAddRows = false;
            this.dataGrdViewCtg.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGrdViewCtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrdViewCtg.AutoGenerateColumns = false;
            this.dataGrdViewCtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrdViewCtg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrdViewCtg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrdViewCtg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrdViewCtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrdViewCtg.ColumnHeadersHeight = 40;
            this.dataGrdViewCtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ctgIdDataGridViewTextBoxColumn,
            this.ctgNameDataGridViewTextBoxColumn,
            this.ctgUsedDataGridViewTextBoxColumn,
            this.btnDelete});
            this.dataGrdViewCtg.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGrdViewCtg.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGrdViewCtg.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrdViewCtg.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGrdViewCtg.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrdViewCtg.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGrdViewCtg.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGrdViewCtg.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGrdViewCtg.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dataGrdViewCtg.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrdViewCtg.CurrentTheme.Name = null;
            this.dataGrdViewCtg.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrdViewCtg.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.dataGrdViewCtg.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrdViewCtg.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGrdViewCtg.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrdViewCtg.DataSource = this.tblCategoriesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrdViewCtg.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrdViewCtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrdViewCtg.EnableHeadersVisualStyles = false;
            this.dataGrdViewCtg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGrdViewCtg.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGrdViewCtg.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGrdViewCtg.HeaderForeColor = System.Drawing.Color.White;
            this.dataGrdViewCtg.Location = new System.Drawing.Point(10, 10);
            this.dataGrdViewCtg.Name = "dataGrdViewCtg";
            this.dataGrdViewCtg.ReadOnly = true;
            this.dataGrdViewCtg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGrdViewCtg.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGrdViewCtg.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrdViewCtg.RowTemplate.Height = 40;
            this.dataGrdViewCtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrdViewCtg.Size = new System.Drawing.Size(469, 318);
            this.dataGrdViewCtg.TabIndex = 12;
            this.dataGrdViewCtg.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGrdViewCtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrdViewCtg_CellContentClick);
            // 
            // ctgIdDataGridViewTextBoxColumn
            // 
            this.ctgIdDataGridViewTextBoxColumn.DataPropertyName = "ctgId";
            this.ctgIdDataGridViewTextBoxColumn.HeaderText = "ctgId";
            this.ctgIdDataGridViewTextBoxColumn.Name = "ctgIdDataGridViewTextBoxColumn";
            this.ctgIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ctgIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // ctgNameDataGridViewTextBoxColumn
            // 
            this.ctgNameDataGridViewTextBoxColumn.DataPropertyName = "ctgName";
            this.ctgNameDataGridViewTextBoxColumn.HeaderText = "Categories Name";
            this.ctgNameDataGridViewTextBoxColumn.Name = "ctgNameDataGridViewTextBoxColumn";
            this.ctgNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ctgNameDataGridViewTextBoxColumn.ToolTipText = "Categories Name";
            // 
            // ctgUsedDataGridViewTextBoxColumn
            // 
            this.ctgUsedDataGridViewTextBoxColumn.DataPropertyName = "ctgUsed";
            this.ctgUsedDataGridViewTextBoxColumn.HeaderText = "No of Products";
            this.ctgUsedDataGridViewTextBoxColumn.Name = "ctgUsedDataGridViewTextBoxColumn";
            this.ctgUsedDataGridViewTextBoxColumn.ReadOnly = true;
            this.ctgUsedDataGridViewTextBoxColumn.ToolTipText = "This categories are used in this number fo products";
            // 
            // btnDelete
            // 
            this.btnDelete.FillWeight = 50F;
            this.btnDelete.HeaderText = "Delete";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Delete";
            this.btnDelete.ToolTipText = "Delete";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // tblCategoriesBindingSource
            // 
            this.tblCategoriesBindingSource.DataMember = "tblCategories";
            this.tblCategoriesBindingSource.DataSource = this.mainDataSet;
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "mainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(110, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(329, 60);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "PRODUCT CATEGORIES";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblCategoriesTableAdapter
            // 
            this.tblCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategories";
            this.Text = "frmCategories";
            this.Load += new System.EventHandler(this.frmCategories_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdViewCtg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGrdViewCtg;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtCtgName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddCtg;
        private mainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource tblCategoriesBindingSource;
        private mainDataSetTableAdapters.tblCategoriesTableAdapter tblCategoriesTableAdapter;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctgIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctgNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctgUsedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}