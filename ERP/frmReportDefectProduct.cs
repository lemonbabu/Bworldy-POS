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
    public partial class frmReportDefectProduct : Form
    {
        ConnectionString obj = new ConnectionString();

        public frmReportDefectProduct()
        {
            InitializeComponent();
        }

        private void frmReportDefectProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tblDefectProducts' table. You can move, or remove it, as needed.
            //this.tblDefectProductsTableAdapter.Fill(this.appData.tblDefectProducts);
            pnlPrinting.Visible = false;
            pnlSaleReport.Visible = true;
            btnSearch_Click(sender, e);

            DateTime date = DateTime.Now.Date;
            dateTimePickerStart.Value = date;
            dateTimePickerEnd.Value = date;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string date1 = dateTimePickerStart.Value.ToString("MM/dd/yyyy");
            string date2 = dateTimePickerEnd.Value.ToString("MM/dd/yyyy");
            if (date1 != "" && date2 != "")
            {
                try
                {
                    obj.con.Open();
                    obj.cmd = new SqlCommand(" SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblDefectProduct.quantity, tblDefectProduct.details, tblDefectProduct.date, tblStock.pPrice FROM tblDefectProduct INNER JOIN tblProducts ON tblDefectProduct.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId INNER JOIN tblStock ON tblProducts.pId = tblStock.pId Where tblDefectProduct.date >= '" + date1 + "' and tblDefectProduct.date <= '" + date2 + "' ", obj.con);
                    SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewSales.DataSource = dt;
                    obj.con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select date first", "Error");
                return;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string date1 = dateTimePickerStart.Value.ToString("MM/dd/yyyy");
            string date2 = dateTimePickerEnd.Value.ToString("MM/dd/yyyy");
            if (date1 != "" && date2 != "")
            {
                try
                {
                    obj.con.Open();
                    obj.cmd = new SqlCommand(" SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblDefectProduct.quantity, tblDefectProduct.details, tblDefectProduct.date, tblStock.pPrice FROM tblDefectProduct INNER JOIN tblProducts ON tblDefectProduct.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId INNER JOIN tblStock ON tblProducts.pId = tblStock.pId Where tblDefectProduct.date >= '" + date1 + "' and tblDefectProduct.date <= '" + date2 + "' ", obj.con);
                    SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.RefreshReport();
                    obj.con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select date first", "Error");
                return;
            }

            pnlPrinting.Visible = true;
            pnlSaleReport.Visible = false;
        }

    }
}
