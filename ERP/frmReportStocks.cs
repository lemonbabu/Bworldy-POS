using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class frmReportStocks : Form
    {
        ConnectionString obj = new ConnectionString();
        public frmReportStocks()
        {
            InitializeComponent();
        }

        private void frmReportStocks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AppData.viewStockHistory' table. You can move, or remove it, as needed.
            //this.viewStockHistoryTableAdapter.Fill(this.AppData.viewStockHistory);
            // TODO: This line of code loads data into the 'AppData.tblSaleProductViewReport' table. You can move, or remove it, as needed.
            //this.tblSaleProductViewReportTableAdapter.Fill(this.AppData.tblSaleProductViewReport);
            // TODO: This line of code loads data into the 'mainDataSet.tblSales' table. You can move, or remove it, as needed.
            //this.tblSalesTableAdapter.Fill(this.mainDataSet.tblSales);
            // TODO: This line of code loads data into the 'AppData.tblStocks' table. You can move, or remove it, as needed.
            //this.tblStocksTableAdapter.Fill(this.AppData.tblStocks);
            pnlSaleReport.Visible = true;
            pnlPrinting.Visible = false;

            try
            {
                obj.cmd = new SqlCommand(" SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStock.stock, tblStock.pPrice, tblStock.sPrice, tblStock.discount, tblStock.lastDate FROM tblStock INNER JOIN tblProducts ON tblStock.pId = tblProducts.pId JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId", obj.con);
                SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewSales.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                obj.cmd = new SqlCommand(" SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStock.stock, tblStock.pPrice, tblStock.sPrice, tblStock.discount, tblStock.lastDate FROM tblStock INNER JOIN tblProducts ON tblStock.pId = tblProducts.pId JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId", obj.con);
                SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            pnlSaleReport.Visible = false;
            pnlPrinting.Visible = true;
        }
    }
}
