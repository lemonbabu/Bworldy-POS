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
    public partial class frmReportCustomer : Form
    {
        ConnectionString obj = new ConnectionString();
        public frmReportCustomer()
        {
            InitializeComponent();
        }

        private void frmReportCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.tblCustomers' table. You can move, or remove it, as needed.
            this.tblCustomersTableAdapter.Fill(this.mainDataSet.tblCustomers);
            pnlSaleReport.Visible = true;
            pnlPrinting.Visible = false;
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                obj.cmd = new SqlCommand(" SELECT * FROM tblCustomers", obj.con);
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
