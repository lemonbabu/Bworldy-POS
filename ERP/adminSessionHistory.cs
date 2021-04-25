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
    public partial class adminSessionHistory : Form
    {
        ConnectionString obj = new ConnectionString();
        public adminSessionHistory()
        {
            InitializeComponent();
            pnlPrinting.Visible = false;
            pnlSaleReport.Visible = true;
        }

        private void adminSessionHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.tblActivity' table. You can move, or remove it, as needed.
            this.tblActivityTableAdapter.Fill(this.mainDataSet.tblActivity);
            // TODO: This line of code loads data into the 'mainDataSet.tblSession' table. You can move, or remove it, as needed.
            this.tblSessionTableAdapter.Fill(this.mainDataSet.tblSession);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            DialogResult result = MessageBox.Show("Are you want to delete previous data of this date?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                obj.cmd = new SqlCommand("DELETE FROM tblSession WHERE logoutDT <= '" + date + "'", obj.con);
                try
                {
                    obj.con.Open();
                    obj.cmd.ExecuteNonQuery();
                    obj.con.Close();
                    gridViewRefash();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        void gridViewRefash()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from tblSession", obj.con);
            adapt.Fill(dt);
            dataGridViewSales.DataSource = dt;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                obj.con.Open();
                obj.cmd = new SqlCommand(" SELECT * FROM tblSession ", obj.con);
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
