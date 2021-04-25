
namespace ERP
{
    partial class frmDeshboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeshboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalSale = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotalProduct = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblTotalCategories = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblTotalCustomers = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblLowStock = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel10 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblTotalStocks = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel12 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDay = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSec = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chartStocks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSec);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblDay);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 219);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(278, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 219);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartSales);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 219);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chartStocks);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(278, 228);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 219);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ERP.Properties.Resources.Bworldy_Logo_011;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // chartSales
            // 
            this.chartSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartSales.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Enabled = false;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartSales.Legends.Add(legend2);
            this.chartSales.Location = new System.Drawing.Point(0, 2);
            this.chartSales.Margin = new System.Windows.Forms.Padding(0);
            this.chartSales.Name = "chartSales";
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Sales";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chartSales.Series.Add(series3);
            this.chartSales.Size = new System.Drawing.Size(269, 217);
            this.chartSales.TabIndex = 1;
            this.chartSales.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title2.Name = "Title1";
            title2.Text = "Last seven days sales history";
            this.chartSales.Titles.Add(title2);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel10, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(269, 219);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTotalSale);
            this.panel5.Controls.Add(this.bunifuLabel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(2, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(85, 105);
            this.panel5.TabIndex = 0;
            // 
            // lblTotalSale
            // 
            this.lblTotalSale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalSale.AutoEllipsis = false;
            this.lblTotalSale.CursorType = null;
            this.lblTotalSale.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTotalSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTotalSale.Location = new System.Drawing.Point(27, 57);
            this.lblTotalSale.Margin = new System.Windows.Forms.Padding(2);
            this.lblTotalSale.Name = "lblTotalSale";
            this.lblTotalSale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalSale.Size = new System.Drawing.Size(24, 19);
            this.lblTotalSale.TabIndex = 1;
            this.lblTotalSale.Text = "000";
            this.lblTotalSale.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotalSale.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(6, 30);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(74, 20);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Total Sales";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblTotalProduct);
            this.panel6.Controls.Add(this.bunifuLabel4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(91, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(85, 105);
            this.panel6.TabIndex = 1;
            // 
            // lblTotalProduct
            // 
            this.lblTotalProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalProduct.AutoEllipsis = false;
            this.lblTotalProduct.CursorType = null;
            this.lblTotalProduct.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTotalProduct.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTotalProduct.Location = new System.Drawing.Point(33, 57);
            this.lblTotalProduct.Margin = new System.Windows.Forms.Padding(2);
            this.lblTotalProduct.Name = "lblTotalProduct";
            this.lblTotalProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalProduct.Size = new System.Drawing.Size(17, 19);
            this.lblTotalProduct.TabIndex = 4;
            this.lblTotalProduct.Text = "00";
            this.lblTotalProduct.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotalProduct.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.DarkOrange;
            this.bunifuLabel4.Location = new System.Drawing.Point(14, 30);
            this.bunifuLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(59, 20);
            this.bunifuLabel4.TabIndex = 2;
            this.bunifuLabel4.Text = "Products";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblTotalCategories);
            this.panel7.Controls.Add(this.bunifuLabel6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(180, 2);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(87, 105);
            this.panel7.TabIndex = 2;
            // 
            // lblTotalCategories
            // 
            this.lblTotalCategories.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalCategories.AutoEllipsis = false;
            this.lblTotalCategories.CursorType = null;
            this.lblTotalCategories.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTotalCategories.ForeColor = System.Drawing.Color.Lime;
            this.lblTotalCategories.Location = new System.Drawing.Point(36, 57);
            this.lblTotalCategories.Margin = new System.Windows.Forms.Padding(2);
            this.lblTotalCategories.Name = "lblTotalCategories";
            this.lblTotalCategories.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalCategories.Size = new System.Drawing.Size(17, 19);
            this.lblTotalCategories.TabIndex = 4;
            this.lblTotalCategories.Text = "00";
            this.lblTotalCategories.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotalCategories.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.bunifuLabel6.ForeColor = System.Drawing.Color.Lime;
            this.bunifuLabel6.Location = new System.Drawing.Point(11, 30);
            this.bunifuLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(67, 20);
            this.bunifuLabel6.TabIndex = 2;
            this.bunifuLabel6.Text = "Categories";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblTotalStocks);
            this.panel8.Controls.Add(this.bunifuLabel12);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(2, 111);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(85, 106);
            this.panel8.TabIndex = 3;
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalCustomers.AutoEllipsis = false;
            this.lblTotalCustomers.CursorType = null;
            this.lblTotalCustomers.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTotalCustomers.ForeColor = System.Drawing.Color.Coral;
            this.lblTotalCustomers.Location = new System.Drawing.Point(34, 57);
            this.lblTotalCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalCustomers.Size = new System.Drawing.Size(17, 19);
            this.lblTotalCustomers.TabIndex = 4;
            this.lblTotalCustomers.Text = "00";
            this.lblTotalCustomers.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotalCustomers.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel8.AutoEllipsis = false;
            this.bunifuLabel8.CursorType = null;
            this.bunifuLabel8.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.bunifuLabel8.ForeColor = System.Drawing.Color.Coral;
            this.bunifuLabel8.Location = new System.Drawing.Point(11, 31);
            this.bunifuLabel8.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(68, 20);
            this.bunifuLabel8.TabIndex = 2;
            this.bunifuLabel8.Text = "Customers";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lblLowStock);
            this.panel9.Controls.Add(this.bunifuLabel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(91, 111);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(85, 106);
            this.panel9.TabIndex = 4;
            // 
            // lblLowStock
            // 
            this.lblLowStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLowStock.AutoEllipsis = false;
            this.lblLowStock.CursorType = null;
            this.lblLowStock.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblLowStock.ForeColor = System.Drawing.Color.Yellow;
            this.lblLowStock.Location = new System.Drawing.Point(33, 57);
            this.lblLowStock.Margin = new System.Windows.Forms.Padding(2);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLowStock.Size = new System.Drawing.Size(17, 19);
            this.lblLowStock.TabIndex = 4;
            this.lblLowStock.Text = "00";
            this.lblLowStock.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblLowStock.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel10
            // 
            this.bunifuLabel10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel10.AutoEllipsis = false;
            this.bunifuLabel10.CursorType = null;
            this.bunifuLabel10.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.bunifuLabel10.ForeColor = System.Drawing.Color.Yellow;
            this.bunifuLabel10.Location = new System.Drawing.Point(8, 31);
            this.bunifuLabel10.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuLabel10.Name = "bunifuLabel10";
            this.bunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel10.Size = new System.Drawing.Size(70, 20);
            this.bunifuLabel10.TabIndex = 2;
            this.bunifuLabel10.Text = "Low Stock";
            this.bunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.lblTotalCustomers);
            this.panel10.Controls.Add(this.bunifuLabel8);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(180, 111);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(87, 106);
            this.panel10.TabIndex = 5;
            // 
            // lblTotalStocks
            // 
            this.lblTotalStocks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalStocks.AutoEllipsis = false;
            this.lblTotalStocks.CursorType = null;
            this.lblTotalStocks.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTotalStocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTotalStocks.Location = new System.Drawing.Point(27, 57);
            this.lblTotalStocks.Margin = new System.Windows.Forms.Padding(2);
            this.lblTotalStocks.Name = "lblTotalStocks";
            this.lblTotalStocks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalStocks.Size = new System.Drawing.Size(24, 19);
            this.lblTotalStocks.TabIndex = 4;
            this.lblTotalStocks.Text = "000";
            this.lblTotalStocks.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotalStocks.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel12
            // 
            this.bunifuLabel12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel12.AutoEllipsis = false;
            this.bunifuLabel12.CursorType = null;
            this.bunifuLabel12.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.bunifuLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuLabel12.Location = new System.Drawing.Point(3, 31);
            this.bunifuLabel12.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuLabel12.Name = "bunifuLabel12";
            this.bunifuLabel12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel12.Size = new System.Drawing.Size(82, 20);
            this.bunifuLabel12.TabIndex = 2;
            this.bunifuLabel12.Text = "Total Stocks";
            this.bunifuLabel12.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel12.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Yellow;
            this.lblTime.Location = new System.Drawing.Point(64, 126);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(109, 32);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "12:13 pm";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDay
            // 
            this.lblDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(158, 171);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(71, 24);
            this.lblDay.TabIndex = 3;
            this.lblDay.Text = "Sunday";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(50, 169);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 26);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "date";
            // 
            // lblSec
            // 
            this.lblSec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSec.Location = new System.Drawing.Point(179, 137);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(26, 22);
            this.lblSec.TabIndex = 5;
            this.lblSec.Text = "12";
            // 
            // chartStocks
            // 
            this.chartStocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartStocks.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chartStocks.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartStocks.Legends.Add(legend1);
            this.chartStocks.Location = new System.Drawing.Point(0, 1);
            this.chartStocks.Margin = new System.Windows.Forms.Padding(0);
            this.chartStocks.Name = "chartStocks";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Sales";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Purchase";
            this.chartStocks.Series.Add(series1);
            this.chartStocks.Series.Add(series2);
            this.chartStocks.Size = new System.Drawing.Size(269, 217);
            this.chartStocks.TabIndex = 2;
            this.chartStocks.Text = "chart2";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title1.Name = "Title1";
            title1.Text = "Last seven days sales history";
            this.chartStocks.Titles.Add(title1);
            // 
            // frmDeshboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDeshboard";
            this.Text = "frmDeshboard";
            this.Load += new System.EventHandler(this.frmDeshboard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.chartStocks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalSale;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalProduct;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalCategories;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private System.Windows.Forms.Panel panel8;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalCustomers;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private System.Windows.Forms.Panel panel9;
        private Bunifu.UI.WinForms.BunifuLabel lblLowStock;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel10;
        private System.Windows.Forms.Panel panel10;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalStocks;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel12;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSec;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStocks;
    }
}