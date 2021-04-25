
namespace ERP
{
    partial class frmViewProducts
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlGridView = new System.Windows.Forms.Panel();
            this.dataGridViewPrdts = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctgNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblProductViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new ERP.AppData();
            this.tblProductViewTableAdapter = new ERP.AppDataTableAdapters.tblProductViewTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrdts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlGridView, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(152, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(245, 67);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "PRODUCT VIEW";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGridView
            // 
            this.pnlGridView.Controls.Add(this.dataGridViewPrdts);
            this.pnlGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridView.Location = new System.Drawing.Point(30, 70);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Size = new System.Drawing.Size(489, 376);
            this.pnlGridView.TabIndex = 1;
            // 
            // dataGridViewPrdts
            // 
            this.dataGridViewPrdts.AllowCustomTheming = true;
            this.dataGridViewPrdts.AllowUserToAddRows = false;
            this.dataGridViewPrdts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewPrdts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPrdts.AutoGenerateColumns = false;
            this.dataGridViewPrdts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPrdts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dataGridViewPrdts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPrdts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewPrdts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPrdts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPrdts.ColumnHeadersHeight = 40;
            this.dataGridViewPrdts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIdDataGridViewTextBoxColumn,
            this.ctgNameDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn,
            this.pSizeDataGridViewTextBoxColumn,
            this.pDetailsDataGridViewTextBoxColumn,
            this.pRef,
            this.btnDeleteProduct});
            this.dataGridViewPrdts.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewPrdts.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewPrdts.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewPrdts.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewPrdts.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewPrdts.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewPrdts.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewPrdts.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewPrdts.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridViewPrdts.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewPrdts.CurrentTheme.Name = null;
            this.dataGridViewPrdts.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewPrdts.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.dataGridViewPrdts.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewPrdts.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewPrdts.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewPrdts.DataSource = this.tblProductViewBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPrdts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPrdts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPrdts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPrdts.EnableHeadersVisualStyles = false;
            this.dataGridViewPrdts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewPrdts.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewPrdts.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewPrdts.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewPrdts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPrdts.Name = "dataGridViewPrdts";
            this.dataGridViewPrdts.ReadOnly = true;
            this.dataGridViewPrdts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewPrdts.RowHeadersVisible = false;
            this.dataGridViewPrdts.RowTemplate.Height = 40;
            this.dataGridViewPrdts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPrdts.Size = new System.Drawing.Size(489, 376);
            this.dataGridViewPrdts.TabIndex = 1;
            this.dataGridViewPrdts.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridViewPrdts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrdts_CellContentClick);
            // 
            // pIdDataGridViewTextBoxColumn
            // 
            this.pIdDataGridViewTextBoxColumn.DataPropertyName = "pId";
            this.pIdDataGridViewTextBoxColumn.HeaderText = "pId";
            this.pIdDataGridViewTextBoxColumn.Name = "pIdDataGridViewTextBoxColumn";
            this.pIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pIdDataGridViewTextBoxColumn.Visible = false;
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
            this.pNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            this.pNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pSizeDataGridViewTextBoxColumn
            // 
            this.pSizeDataGridViewTextBoxColumn.DataPropertyName = "pSize";
            this.pSizeDataGridViewTextBoxColumn.FillWeight = 50F;
            this.pSizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.pSizeDataGridViewTextBoxColumn.Name = "pSizeDataGridViewTextBoxColumn";
            this.pSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pDetailsDataGridViewTextBoxColumn
            // 
            this.pDetailsDataGridViewTextBoxColumn.DataPropertyName = "pDetails";
            this.pDetailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.pDetailsDataGridViewTextBoxColumn.Name = "pDetailsDataGridViewTextBoxColumn";
            this.pDetailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRef
            // 
            this.pRef.DataPropertyName = "pRef";
            this.pRef.FillWeight = 80F;
            this.pRef.HeaderText = "Reference";
            this.pRef.Name = "pRef";
            this.pRef.ReadOnly = true;
            this.pRef.ToolTipText = "Use of this product ";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.FillWeight = 60F;
            this.btnDeleteProduct.HeaderText = "Delete";
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.ReadOnly = true;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.ToolTipText = "Delete";
            this.btnDeleteProduct.UseColumnTextForButtonValue = true;
            // 
            // tblProductViewBindingSource
            // 
            this.tblProductViewBindingSource.DataMember = "tblProductView";
            this.tblProductViewBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProductViewTableAdapter
            // 
            this.tblProductViewTableAdapter.ClearBeforeFill = true;
            // 
            // frmViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewProducts";
            this.Text = "frmViewProducts";
            this.Load += new System.EventHandler(this.frmViewProducts_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrdts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private System.Windows.Forms.Panel pnlGridView;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewPrdts;
        private AppData appData;
        private System.Windows.Forms.BindingSource tblProductViewBindingSource;
        private AppDataTableAdapters.tblProductViewTableAdapter tblProductViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctgNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRef;
        private System.Windows.Forms.DataGridViewButtonColumn btnDeleteProduct;
    }
}