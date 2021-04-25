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
    public partial class frmOverallAccount : Form
    {
        ConnectionString obj = new ConnectionString();

        public frmOverallAccount()
        {
            InitializeComponent();

            DateTime date = DateTime.Now.Date;
            dateTimePicker1.Value = date;
            dateTimePicker2.Value = date;

            account();
        }


        
        void account()
        {
            try
            {
                double totalAmnt = 0, paidAmnt = 0, disct = 0, overallDisc = 0, due;
                SqlDataAdapter sd = new SqlDataAdapter("SELECT SUM(totalAmnt) as totalAmnt, SUM(paidAmnt) as paidAmnt, SUM(discount) as dis, SUM(overallDiscount) as ovDisc FROM tblSales ", obj.con);
                DataTable dtbl = new DataTable();
                sd.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                {
                    return;
                }
                else
                {
                    if(dtbl.Rows[0]["totalAmnt"].ToString() != "")
                        totalAmnt = Convert.ToDouble(dtbl.Rows[0]["totalAmnt"].ToString());
                    if (dtbl.Rows[0]["paidAmnt"].ToString() != "")
                        paidAmnt = Convert.ToDouble(dtbl.Rows[0]["paidAmnt"].ToString());
                    if (dtbl.Rows[0]["dis"].ToString() != "")
                        disct = Convert.ToDouble(dtbl.Rows[0]["dis"].ToString());
                    if (dtbl.Rows[0]["ovDisc"].ToString() != "")
                        overallDisc = Convert.ToDouble(dtbl.Rows[0]["ovDisc"].ToString());

                    due = totalAmnt - (paidAmnt + disct + overallDisc);

                    lblTotalSales.Text = (paidAmnt + due).ToString();
                    lblTotalSale.Text = (paidAmnt + due).ToString();
                    lblTotalDue.Text = due.ToString();
                    lblTotalPay.Text = paidAmnt.ToString();
                }

                sd = new SqlDataAdapter("SELECT SUM(pPrice * quantity) as sum FROM tblStockHistory ", obj.con);
                dtbl = new DataTable();
                sd.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                    lblTotalStock.Text = "000.0";
                else if (dtbl.Rows[0]["sum"].ToString() != "")
                    lblTotalStock.Text = dtbl.Rows[0]["sum"].ToString();

                sd = new SqlDataAdapter("SELECT SUM(amnt) as sum FROM tblExpense ", obj.con);
                dtbl = new DataTable();
                sd.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                    lblExpense.Text = "000.0";
                else if (dtbl.Rows[0]["sum"].ToString() != "")
                    lblExpense.Text = dtbl.Rows[0]["sum"].ToString();
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
            try
            {
                double totalAmnt = 0, paidAmnt = 0, disct = 0, overallDisc = 0, due;
                SqlDataAdapter sd = new SqlDataAdapter("SELECT SUM(totalAmnt) as totalAmnt, SUM(paidAmnt) as paidAmnt, SUM(discount) as dis, SUM(overallDiscount) as ovDisc FROM tblSales  where date >= '" + date1 + "' and date <= '" + date2 + "' ", obj.con);
                DataTable dtbl = new DataTable();
                sd.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                {
                    return;
                }
                else
                {
                    if (dtbl.Rows[0]["totalAmnt"].ToString() != "")
                        totalAmnt = Convert.ToDouble(dtbl.Rows[0]["totalAmnt"].ToString());
                    if (dtbl.Rows[0]["paidAmnt"].ToString() != "")
                        paidAmnt = Convert.ToDouble(dtbl.Rows[0]["paidAmnt"].ToString());
                    if (dtbl.Rows[0]["dis"].ToString() != "")
                        disct = Convert.ToDouble(dtbl.Rows[0]["dis"].ToString());
                    if (dtbl.Rows[0]["ovDisc"].ToString() != "")
                        overallDisc = Convert.ToDouble(dtbl.Rows[0]["ovDisc"].ToString());

                    due = totalAmnt - (paidAmnt + disct + overallDisc);

                    lblSl.Text = (paidAmnt + due).ToString();
                }

                sd = new SqlDataAdapter("SELECT SUM(pPrice  * quantity) as sum FROM tblStockHistory where dt >= '" + date1 + "' and dt <= '" + date2 + "' ", obj.con);
                dtbl = new DataTable();
                sd.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                    lblStc.Text = "000.0";
                else if (dtbl.Rows[0]["sum"].ToString() != "")
                    lblStc.Text = dtbl.Rows[0]["sum"].ToString();

                sd = new SqlDataAdapter("SELECT SUM(amnt) as sum FROM tblExpense where date >= '" + date1 + "' and date <= '" + date2 + "'", obj.con);
                dtbl = new DataTable();
                sd.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                    lblExp.Text = "000.0";
                else if (dtbl.Rows[0]["sum"].ToString() != "")
                    lblExp.Text = dtbl.Rows[0]["sum"].ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
