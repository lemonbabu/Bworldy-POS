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
    public partial class frmReportDiscount : Form
    {
        ConnectionString obj = new ConnectionString();

        public frmReportDiscount()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                obj.cmd = new SqlCommand(" SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStock.sPrice, tblStock.discount FROM tblStock INNER JOIN tblProducts ON tblStock.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId where tblStock.discount > '"+ 0 +"' ", obj.con);
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

        private void frmReportDiscount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tblOffers' table. You can move, or remove it, as needed.
            try
            {
                obj.cmd = new SqlCommand(" SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStock.sPrice, tblStock.discount FROM tblStock INNER JOIN tblProducts ON tblStock.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId where tblStock.discount > '" + 0 + "' ", obj.con);
                SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewSales.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            pnlSaleReport.Visible = true;
            pnlPrinting.Visible = false;
        }
    }
}
