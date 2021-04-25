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
    public partial class frmSalerDeposit : Form
    {
        ConnectionString obj = new ConnectionString();
        string userName;

        public frmSalerDeposit(string name)
        {
            InitializeComponent();
            userName = name;
            txtAmnt.Focus();
            pnlDepositSubmition.Visible = true;
            pnlPrint.Visible = false;
            pnlView.Visible = false;
        }

        private void txtAmnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btnSubmit.Focus();
            }
        }

        private void txtAmnt_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(txtAmnt.Text, out parsedValue))
            {
                txtAmnt.Text = "";
                return;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string amnt = txtAmnt.Text;
            DateTime date = DateTime.Now.Date;
            DateTime time = Convert.ToDateTime(DateTime.Now.ToString("HH:mm").Trim());
            if (amnt != "")
            {
                double value = Convert.ToDouble(amnt);
                try
                {
                    DialogResult confirm = MessageBox.Show("Do you want to deposit ?? ", "Confirmation", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        obj.con.Open();
                        obj.cmd = new SqlCommand("INSERT INTO tblDeposit (amnt, date, time, author)  VALUES('" + amnt + "', '" + date + "', '" + time + "', '" + userName + "')", obj.con);
                        obj.cmd.ExecuteNonQuery();
                        obj.con.Close();
                        MessageBox.Show("Add successfully", "Confirm");
                        txtAmnt.Text = "";
                    }
                    else if (confirm == DialogResult.No)
                    {
                        return;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Please fill Amount first!");
            
        }

        private void btnSubmit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btnView.Focus();
            }
        }

        private void btnView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnView_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtAmnt.Focus();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            pnlDepositSubmition.Visible = false;
            pnlPrint.Visible = false;
            pnlView.Visible = true;
            DateTime date = DateTime.Now.Date;
            dateTimePicker1.Value = date;
            dateTimePicker2.Value = date;

            btnSearch_Click(sender, e);
        }

        private void frmSalerDeposit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.tblDeposit' table. You can move, or remove it, as needed.
            //this.tblDepositTableAdapter.Fill(this.mainDataSet.tblDeposit);
            // TODO: This line of code loads data into the 'mainDataSet.tblDeposit' table. You can move, or remove it, as needed.
            //this.tblDepositTableAdapter.Fill(this.mainDataSet.tblDeposit);
            
            // this.reportViewer1.RefreshReport();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            pnlDepositSubmition.Visible = false;
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
    }
}
