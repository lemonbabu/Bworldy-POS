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
    public partial class frmReportSales : Form
    {
        ConnectionString obj = new ConnectionString();
        public frmReportSales()
        {
            InitializeComponent();
        }

        private void frmReportSales_Load(object sender, EventArgs e)
        {
            pnlSaleReport.Visible = true;
            pnlPrinting.Visible = false;
            // TODO: This line of code loads data into the 'appData.tblSalesView' table. You can move, or remove it, as needed.
            //this.tblSalesViewTableAdapter.Fill(this.appData.tblSalesView);

            DateTime date = DateTime.Now.Date;
            dateTimePickerStart.Value = date;
            dateTimePickerEnd.Value = date;
            btnSearch_Click(sender, e);
            //this.reportViewer1.RefreshReport();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string date1 = dateTimePickerStart.Value.ToString("MM/dd/yyyy");
            string date2 = dateTimePickerEnd.Value.ToString("MM/dd/yyyy");
            if (date1 != "" && date2 != "")
            {
                try
                {
                    obj.cmd = new SqlCommand(" SELECT tblSales.date, tblSales.time, tblSales.SaleId, tblCustomers.cstName, tblCustomers.cstPhone, tblSales.totalAmnt, tblSales.discount, tblSales.overallDiscount, tblSales.payMethod, tblSales.PaidAmnt FROM tblSales INNER JOIN tblCustomers ON tblSales.cstId = tblCustomers.cstId Where tblSales.date >= '" + date1 + "' and tblSales.date <= '" + date2 + "' ", obj.con);
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
                    obj.cmd = new SqlCommand(" SELECT tblSales.date, tblSales.time, tblSales.SaleId, tblCustomers.cstName, tblCustomers.cstPhone, tblSales.totalAmnt, tblSales.discount, tblSales.overallDiscount, tblSales.payMethod, tblSales.PaidAmnt FROM tblSales INNER JOIN tblCustomers ON tblSales.cstId = tblCustomers.cstId Where tblSales.date >= '" + date1 + "' and tblSales.date <= '" + date2 + "' ", obj.con);
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

            pnlSaleReport.Visible = false;
            pnlPrinting.Visible = true;
        }


    }
}
