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
    public partial class frmSalesAccount : Form
    {

        //string date2 = dateTimePickerEnd.Value.ToString("MM/dd/yyyy");
        ConnectionString obj = new ConnectionString();
        public frmSalesAccount()
        {
            InitializeComponent();
        }

        private void frmSalesAccount_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now.Date;
            dateTimePicker.Value = date;
            dateTimePicker1.Value = date;
            dateTimePicker2.Value = date;

            salesAmount(date.ToString("MM/dd/yyyy"));
            chart();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            string date = dateTimePicker.Value.ToString("MM/dd/yyyy");
            salesAmount(date);
        }


        void salesAmount(string date)
        {
            try
            {
                SqlDataAdapter sd = new SqlDataAdapter("SELECT SUM(payment) as sum FROM tblPaymentHistory where date = '"+ date +"' ", obj.con);
                DataTable dtbl = new DataTable();
                sd.Fill(dtbl);
                if(dtbl.Rows.Count < 1)
                    txtSaleAmount.Text = "0.0";
                else
                    txtSaleAmount.Text = dtbl.Rows[0]["sum"].ToString();

                sd = new SqlDataAdapter("SELECT SUM(duePayAmnt) as sum FROM tblDuePaymentHistory where date = '" + date + "' ", obj.con);
                dtbl = new DataTable();
                sd.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                    txtDuePayment.Text = "0.0";
                else
                    txtDuePayment.Text = dtbl.Rows[0]["sum"].ToString();

                if (txtDuePayment.Text == "")
                    txtDuePayment.Text = "0.0";
                if (txtSaleAmount.Text == "")
                    txtSaleAmount.Text = "0.0";

                double saleAmnt = Convert.ToDouble(txtSaleAmount.Text);
                double dueAmnt = Convert.ToDouble(txtDuePayment.Text);
                txtTodayCollection.Text = (saleAmnt + dueAmnt).ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            dateTimePicker.Focus();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string date1 = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            string date2 = dateTimePicker2.Value.ToString("MM/dd/yyyy");
            double sAmnt, dAmnt;
            try
            {
                SqlDataAdapter sd = new SqlDataAdapter("SELECT SUM(payment) as sum FROM tblPaymentHistory where date >= '" + date1 + "' and date <= '" + date2 + "' ", obj.con);
                DataTable dtbl = new DataTable();
                sd.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                    sAmnt = 0.0;
                else if (dtbl.Rows[0]["sum"].ToString() != "")
                    sAmnt = Convert.ToDouble(dtbl.Rows[0]["sum"].ToString());
                else
                    sAmnt = 0.0;

                sd = new SqlDataAdapter("SELECT SUM(duePayAmnt) as sum FROM tblDuePaymentHistory where date >= '" + date1 + "' and date <= '" + date2 + "' ", obj.con);
                dtbl = new DataTable();
                sd.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                    dAmnt = 0.0;
                else if (dtbl.Rows[0]["sum"].ToString() != "")
                    dAmnt = Convert.ToDouble(dtbl.Rows[0]["sum"].ToString());
                else
                    dAmnt = 0.0;

                txtTotalSalesAmount.Text = (sAmnt + dAmnt).ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2_ValueChanged(sender, e);
        }

        void chart()
        {
            for(int i = 6; i >= 0; i--)
            {
                string date = DateTime.Now.AddDays(-i).ToString("MM/dd/yyyy");
                double total = 0, sAmnt = 0, dAmnt = 0 ;
                try
                {
                    SqlDataAdapter sd = new SqlDataAdapter("SELECT SUM(payment) as sum FROM tblPaymentHistory where date = '" + date + "' ", obj.con);
                    DataTable dtbl = new DataTable();
                    sd.Fill(dtbl);
                    if (dtbl.Rows.Count < 1)
                        sAmnt = 0.0;
                    else if (dtbl.Rows[0]["sum"].ToString() != "")
                        sAmnt = Convert.ToDouble(dtbl.Rows[0]["sum"].ToString());
                    else
                        sAmnt = 0.0;

                    sd = new SqlDataAdapter("SELECT SUM(duePayAmnt) as sum FROM tblDuePaymentHistory where date = '" + date + "' ", obj.con);
                    dtbl = new DataTable();
                    sd.Fill(dtbl);
                    if (dtbl.Rows.Count < 1)
                        dAmnt = 0.0;
                    else if (dtbl.Rows[0]["sum"].ToString() != "")
                        dAmnt = Convert.ToDouble(dtbl.Rows[0]["sum"].ToString());
                    else
                        dAmnt = 0.0;

                    total = (sAmnt + dAmnt);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                this.chrtSales.Series["Sales"].Points.AddXY(date, total);
            }
            

        }


    }
}
