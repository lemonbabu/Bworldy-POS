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
    public partial class frmReportOverallAccount : Form
    {
        ConnectionString obj = new ConnectionString();
        public frmReportOverallAccount()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string date = dateTimePickerStart.Value.ToString("MM/dd/yyyy");
            try
            {
                obj.cmd = new SqlCommand("SELECT SUM(tblStockHistory.pPrice) as pPrice, SUM(tblStockHistory.sPrice) as sPrice, SUM(tblPaymentHistory.total) as total, SUM(tblPaymentHistory.discount + tblPaymentHistory.overallDiscount) as payDisc, SUM(tblPaymentHistory.payment) as pay,  SUM(tblDuePaymentHistory.duePayAmnt) as duePay FROM tblStockHistory INNER JOIN tblPaymentHistory ON tblStockHistory.dt = tblPaymentHistory.date  JOIN tblDuePaymentHistory ON tblPaymentHistory.date = tblDuePaymentHistory.date WHERE tblStockHistory.dt = '"+ date +"' ", obj.con);
                SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewAccount.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmReportOverallAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tblOverallAccount' table. You can move, or remove it, as needed.
            this.tblOverallAccountTableAdapter.Fill(this.appData.tblOverallAccount);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePickerStart.Value;
            try
            {
                obj.cmd = new SqlCommand("  SELECT SUM(tblStockHistory.pPrice) as pPrice, SUM(tblStockHistory.sPrice) as sPrice, SUM(tblPaymentHistory.total) as total, SUM(tblPaymentHistory.discount + tblPaymentHistory.overallDiscount) as payDisc, SUM(tblPaymentHistory.payment) as pay,  SUM(tblDuePaymentHistory.duePayAmnt) as duePay FROM tblStockHistory INNER JOIN tblPaymentHistory JOIN tblDuePaymentHistory WHERE tblStockHistory.dt = '" + date + "' ", obj.con);
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
        }
    }
}
