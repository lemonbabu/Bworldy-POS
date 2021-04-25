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
    public partial class frmDeshboard : Form
    {
        ConnectionString obj = new ConnectionString();

        public frmDeshboard()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm tt");
            lblSec.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("dd MM yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
        }

        private void frmDeshboard_Load(object sender, EventArgs e)
        {
            chart();
            chart2();
            double sales, stocks, rev;
            try
            {
                // this query for count total sales
                SqlDataAdapter sd = new SqlDataAdapter("SELECT COUNT(saleId) as sum FROM tblSales ", obj.con);
                DataTable dtbl = new DataTable();
                sd.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                    lblTotalSale.Text = "0";
                else
                    lblTotalSale.Text = dtbl.Rows[0]["sum"].ToString();

                // this query for summation of total stocks
                sd = new SqlDataAdapter("SELECT SUM(stock) as sum FROM tblStock ", obj.con);
                dtbl = new DataTable();
                sd.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                    lblTotalStocks.Text = "0";
                else
                    lblTotalStocks.Text = dtbl.Rows[0]["sum"].ToString();

                // this query for summation of low stock product
                sd = new SqlDataAdapter("SELECT COUNT(stockId) as sum FROM tblStock where stock <= '" + 5 +"' ", obj.con);
                dtbl = new DataTable();
                sd.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                    lblLowStock.Text = "0";
                else
                    lblLowStock.Text = dtbl.Rows[0]["sum"].ToString();

                // this query for product counting 
                sd = new SqlDataAdapter("SELECT COUNT(pId) as sum FROM tblProducts ", obj.con);
                dtbl = new DataTable();
                sd.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                    lblTotalProduct.Text = "0";
                else
                    lblTotalProduct.Text = dtbl.Rows[0]["sum"].ToString();

                // this query for count categoris
                sd = new SqlDataAdapter("SELECT COUNT(ctgId) as sum FROM tblCategories ", obj.con);
                dtbl = new DataTable();
                sd.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                    lblTotalCategories.Text = "0";
                else
                    lblTotalCategories.Text = dtbl.Rows[0]["sum"].ToString();

                // this query for count customers
                sd = new SqlDataAdapter("SELECT COUNT(cstId) as sum FROM tblCustomers ", obj.con);
                dtbl = new DataTable();
                sd.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                    lblTotalCustomers.Text = "0";
                else
                    lblTotalCustomers.Text = dtbl.Rows[0]["sum"].ToString();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void chart()
        {
            for (int i = 6; i >= 0; i--)
            {
                string date = DateTime.Now.AddDays(-i).ToString("MM/dd/yyyy");
                string dates = DateTime.Now.AddDays(-i).ToString("MM/dd/yyyy");
                double total = 0, sAmnt = 0, dAmnt = 0;
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

                this.chartSales.Series["Sales"].Points.AddXY(dates, total);
            }
        }

        void chart2()
        {
            for (int i = 4; i >= 0; i--)
            {
                string date = DateTime.Now.AddDays(-i).ToString("MM/dd/yyyy");
                double pAmnt = 0, sAmnt = 0;
                try
                {
                    SqlDataAdapter sd = new SqlDataAdapter("SELECT SUM(pPrice) as sum FROM tblStockHistory where  dt = '" + date + "' ", obj.con);
                    DataTable dtbl = new DataTable();
                    sd.Fill(dtbl);
                    if (dtbl.Rows.Count < 1)
                        pAmnt = 0.0;
                    else if (dtbl.Rows[0]["sum"].ToString() != "")
                        pAmnt = Convert.ToDouble(dtbl.Rows[0]["sum"].ToString());
                    else
                        pAmnt = 0.0;

                    sd = new SqlDataAdapter("SELECT SUM(sPrice) as sum FROM tblStockHistory where dt = '" + date + "' ", obj.con);
                    dtbl = new DataTable();
                    sd.Fill(dtbl);
                    if (dtbl.Rows.Count < 1)
                        sAmnt = 0.0;
                    else if (dtbl.Rows[0]["sum"].ToString() != "")
                        sAmnt = Convert.ToDouble(dtbl.Rows[0]["sum"].ToString());
                    else
                        sAmnt = 0.0;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                this.chartStocks.Series["Purchase"].Points.AddXY(date, pAmnt);
                this.chartStocks.Series["Sales"].Points.AddXY(date, sAmnt);
            }
        }


    }
}
