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
    public partial class frmViewDuePayHistory : Form
    {
        ConnectionString obj = new ConnectionString();
        public frmViewDuePayHistory()
        {
            InitializeComponent();
        }

        private void frmViewDuePayHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.tblDuePaymentHistory' table. You can move, or remove it, as needed.
            //this.tblDuePaymentHistoryTableAdapter.Fill(this.mainDataSet.tblDuePaymentHistory);
            DateTime date = DateTime.Now.Date;
            dateTimePickerStart.Value = date;
            dateTimePickerEnd.Value = date;
            btnSearch_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string date1 = dateTimePickerStart.Value.ToString("MM/dd/yyyy");
            string date2 = dateTimePickerEnd.Value.ToString("MM/dd/yyyy");

            if (date1 != "" && date2 != "")
            {
                try
                {
                    obj.cmd = new SqlCommand(" SELECT * FROM tblDuePaymentHistory Where date >= '" + date1 + "' and date <= '" + date2 + "' ", obj.con);
                    SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewDuePayHistory.DataSource = dt;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    obj.cmd = new SqlCommand(" SELECT SUM(duePayAmnt) as sum FROM tblDuePaymentHistory Where date >= '" + date1 + "' and date <= '" + date2 + "' ", obj.con);
                    SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count < 1)
                        lblTotalDuePay.Text = "0";
                    else
                        lblTotalDuePay.Text = dt.Rows[0]["sum"].ToString();
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
