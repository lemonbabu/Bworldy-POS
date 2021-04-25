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
    public partial class adminSalesActivity : Form
    {

        ConnectionString obj = new ConnectionString();

        public adminSalesActivity()
        {
            InitializeComponent();
            pnlPrinting.Visible = false;
            pnlSaleReport.Visible = true;
        }

        private void adminSalesActivity_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.tblActivity' table. You can move, or remove it, as needed.
            this.tblActivityTableAdapter.Fill(this.mainDataSet.tblActivity);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                obj.con.Open();
                obj.cmd = new SqlCommand(" SELECT * FROM tblActivity ", obj.con);
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
            pnlPrinting.Visible = true;
            pnlSaleReport.Visible = false;
        }
    }
}
