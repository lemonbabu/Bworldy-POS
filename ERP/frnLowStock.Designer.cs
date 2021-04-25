
namespace ERP
{
    partial class frmLowStock
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
            this.tblLowStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new ERP.AppData();
            this.tblLowStockTableAdapter = new ERP.AppDataTableAdapters.tblLowStockTableAdapter();
            this.dataGridViewLowStock = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ctgNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSizeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tblLowStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLowStock)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLowStockBindingSource
            // 
            this.tblLowStockBindingSource.DataMember = "tblLowStock";
            this.tblLowStockBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblLowStockTableAdapter
            // 
            this.tblLowStockTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewLowStock
            // 
            this.dataGridViewLowStock.AllowCustomTheming = true;
            this.dataGridViewLowStock.AllowUserToAddRows = false;
            this.dataGridViewLowStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewLowStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLowStock.AutoGenerateColumns = false;
            this.dataGridViewLowStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLowStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLowStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewLowStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLowStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLowStock.ColumnHeadersHeight = 40;
            this.dataGridViewLowStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ctgNameDataGridViewTextBoxColumn1,
            this.pNameDataGridViewTextBoxColumn1,
            this.pSizeDataGridViewTextBoxColumn1,
            this.stockDataGridViewTextBoxColumn1});
            this.dataGridViewLowStock.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewLowStock.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewLowStock.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewLowStock.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewLowStock.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewLowStock.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewLowStock.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewLowStock.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewLowStock.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridViewLowStock.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewLowStock.CurrentTheme.Name = null;
            this.dataGridViewLowStock.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewLowStock.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.dataGridViewLowStock.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewLowStock.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewLowStock.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewLowStock.DataSource = this.tblLowStockBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLowStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLowStock.EnableHeadersVisualStyles = false;
            this.dataGridViewLowStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewLowStock.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewLowStock.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewLowStock.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewLowStock.Location = new System.Drawing.Point(29, 50);
            this.dataGridViewLowStock.Name = "dataGridViewLowStock";
            this.dataGridViewLowStock.ReadOnly = true;
            this.dataGridViewLowStock.RowHeadersVisible = false;
            this.dataGridViewLowStock.RowTemplate.Height = 40;
            this.dataGridViewLowStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLowStock.Size = new System.Drawing.Size(471, 377);
            this.dataGridViewLowStock.TabIndex = 1;
            this.dataGridViewLowStock.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // ctgNameDataGridViewTextBoxColumn1
            // 
            this.ctgNameDataGridViewTextBoxColumn1.DataPropertyName = "ctgName";
            this.ctgNameDataGridViewTextBoxColumn1.HeaderText = "Categorie";
            this.ctgNameDataGridViewTextBoxColumn1.Name = "ctgNameDataGridViewTextBoxColumn1";
            this.ctgNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pNameDataGridViewTextBoxColumn1
            // 
            this.pNameDataGridViewTextBoxColumn1.DataPropertyName = "pName";
            this.pNameDataGridViewTextBoxColumn1.HeaderText = "Product Name";
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
            // stockDataGridViewTextBoxColumn1
            // 
            this.stockDataGridViewTextBoxColumn1.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn1.FillWeight = 80F;
            this.stockDataGridViewTextBoxColumn1.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn1.Name = "stockDataGridViewTextBoxColumn1";
            this.stockDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewLowStock, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 430);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(153, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 42);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "LOW STOCKS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLowStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLowStock";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "frnLowStock";
            this.Load += new System.EventHandler(this.frnLowStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblLowStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLowStock)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private AppData appData;
        private System.Windows.Forms.BindingSource tblLowStockBindingSource;
        private AppDataTableAdapters.tblLowStockTableAdapter tblLowStockTableAdapter;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewLowStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctgNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSizeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
    }
}