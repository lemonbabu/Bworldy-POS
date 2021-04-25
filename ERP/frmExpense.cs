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
    public partial class frmExpense : Form
    {
        ConnectionString obj = new ConnectionString();
        string userName;

        public frmExpense(string name)
        {
            InitializeComponent();
            userName = name;
        }

        private void frmExpense_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.tblExpense' table. You can move, or remove it, as needed.
            this.tblExpenseTableAdapter.Fill(this.mainDataSet.tblExpense);
            // TODO: This line of code loads data into the 'mainDataSet.tblExpense' table. You can move, or remove it, as needed.
            /// this.tblExpenseTableAdapter.Fill(this.mainDataSet.tblExpense);
            /// 

            DateTime date = DateTime.Now.Date;
            dateTimePickerStart.Value = date;
            dateTimePickerEnd.Value = date;

            pnlExpenseEntry.Visible = true;
            pnlViewExpense.Visible = false;
            pnlPrinting.Visible = false;

        }

        private void txtDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAmnt.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtAmnt.Focus();
            }
        }

        private void txtAmnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btnSave.Focus();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string details = txtDetails.Text.Replace("'", "''");
            string amnt = txtAmnt.Text;
            DateTime date = DateTime.Now.Date;
            String time = DateTime.Now.ToString("HH:mm").Trim();

            if (details == "" || amnt == "")
            {
                MessageBox.Show("Fillup details and amount!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double amount = Convert.ToDouble(amnt);
            //insertion new expense
            DialogResult confirm = MessageBox.Show("Are you sure to add this expense?\nOnly admin can modify later.", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    obj.con.Open();
                    obj.cmd = new SqlCommand("INSERT INTO tblExpense (purpose, amnt, date, time, author)  VALUES('" + details + "', '" + amount + "', '" + date + "', '" + time + "', '" + userName + "')", obj.con);
                    obj.cmd.ExecuteNonQuery();
                    obj.con.Close();
                    MessageBox.Show("Add Successfully");
                    txtAmnt.Text = "";
                    txtDetails.Text = "";
                    txtDetails.Focus();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (confirm == DialogResult.No)
            {
                return;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            tempGridViewRefash();
            pnlExpenseEntry.Visible = false;
            pnlViewExpense.Visible = true;
            pnlPrinting.Visible = false;
        }

        void tempGridViewRefash()
        {
            string date1 = dateTimePickerStart.Value.ToString("MM/dd/yyyy");
            string date2 = dateTimePickerEnd.Value.ToString("MM/dd/yyyy");

            if (date1 != "" && date2 != "")
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter("select * from tblExpense Where date >= '" + date1 + "' and date <= '" + date2 + "'", obj.con);
                    adapt.Fill(dt);
                    dataGridViewExpense.DataSource = dt;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter("select SUM(amnt) as sum from tblExpense Where date >= '" + date1 + "' and date <= '" + date2 + "'", obj.con);
                    adapt.Fill(dt);
                    if (dt.Rows.Count < 1)
                    {
                        lblTotalExpense.Text = "0";
                    }
                    else
                    {
                        lblTotalExpense.Text = dt.Rows[0]["sum"].ToString();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridViewExpense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            // This condition for column clik avoiding
            i = Convert.ToInt16(e.RowIndex.ToString());
            if (i < 0)
                return;
            if (e.ColumnIndex == 6)
            {
                DialogResult result = MessageBox.Show("Are you sure to Delete?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        i = Convert.ToInt16(dataGridViewExpense.Rows[e.RowIndex].Cells[0].Value.ToString());
                        BindingSource a = new BindingSource();
                        deleteItem(a, i);
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
        }


        //Delete 1 item from graidview in the tbleNewSells
        void deleteItem(BindingSource a, int i)
        {
            try
            {
                obj.con.Open();
                obj.cmd = new SqlCommand("DELETE FROM tblExpense WHERE expenseId = '" + i + "'", obj.con);
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
                tempGridViewRefash();
            }
            catch (Exception e)
            {
                MessageBox.Show("SQL error" + e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tempGridViewRefash();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string date1 = dateTimePickerStart.Value.ToString("MM/dd/yyyy");
            string date2 = dateTimePickerEnd.Value.ToString("MM/dd/yyyy");

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from tblExpense Where date >= '" + date1 + "' and date <= '" + date2 + "'", obj.con);
                adapt.Fill(dt);
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            pnlExpenseEntry.Visible = false;
            pnlViewExpense.Visible = false;
            pnlPrinting.Visible = true;
        }



    }
}
