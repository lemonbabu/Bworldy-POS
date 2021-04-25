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
    public partial class frmReportDeposit : Form
    {
        ConnectionString obj = new ConnectionString();
        public frmReportDeposit()
        {
            InitializeComponent();
        }

        private void frmReportDeposit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.tblDeposit' table. You can move, or remove it, as needed.
           // this.tblDepositTableAdapter.Fill(this.mainDataSet.tblDeposit);
            pnlPrint.Visible = false;
            pnlView.Visible = true;

            DateTime date = DateTime.Now.Date;
            dateTimePicker1.Value = date;
            dateTimePicker2.Value = date;

            dataGridViewReload();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string date1 = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            string date2 = dateTimePicker2.Value.ToString("MM/dd/yyyy");

            if (date1 != "" && date2 != "")
            {
                try
                {
                    obj.cmd = new SqlCommand(" SELECT * FROM tblDeposit Where date >= '" + date1 + "' and date <= '" + date2 + "' ", obj.con);
                    SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewDeposit.DataSource = dt;
                    dataGridViewDeposit.Refresh();
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
            pnlPrint.Visible = true;
            pnlView.Visible = false;
            string date1 = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            string date2 = dateTimePicker2.Value.ToString("MM/dd/yyyy");

            try
            {
                obj.cmd = new SqlCommand("SELECT * FROM tblDeposit  Where date >= '" + date1 + "' and date <= '" + date2 + "' ", obj.con);
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

        void dataGridViewReload()
        {
            try
            {
                obj.con.Open();
                obj.cmd = new SqlCommand(" SELECT * FROM tblDeposit ", obj.con);
                SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewDeposit.DataSource = dt;
                dataGridViewDeposit.Refresh();
                obj.con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
