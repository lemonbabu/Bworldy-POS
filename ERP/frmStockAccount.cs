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
    public partial class frmStockAccount : Form
    {
        ConnectionString obj = new ConnectionString();
        public frmStockAccount()
        {
            InitializeComponent();

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
                SqlDataAdapter sd = new SqlDataAdapter("SELECT SUM(quantity) as sum, SUM(pPrice * quantity) as pPrice, SUM(sPrice * quantity) as sPrice FROM tblStockHistory where dt = '" + date + "' ", obj.con);
                DataTable dtbl = new DataTable();
                sd.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                {
                    txtProducts.Text = "0";
                    txtSalePrices.Text = "0";
                    txtPurchasePrice.Text = "0";
                }
                else
                {
                    txtProducts.Text = dtbl.Rows[0]["sum"].ToString();
                    txtSalePrices.Text = dtbl.Rows[0]["sPrice"].ToString();
                    txtPurchasePrice.Text = dtbl.Rows[0]["pPrice"].ToString();
                }
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
            try
            {
                SqlDataAdapter sd = new SqlDataAdapter("SELECT SUM(quantity) as sum, SUM(pPrice * quantity) as pPrice, SUM(sPrice * quantity) as sPrice FROM tblStockHistory where dt >= '" + date1 + "' and dt <= '" + date2 + "' ", obj.con);
                DataTable dtbl = new DataTable();
                sd.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                {
                    txtTotalProduct.Text = "0";
                    txtTotalSalePrices.Text = "0.0";
                    txtTotalPurchasePrice.Text = "0.0";
                }
                else
                {
                    txtTotalProduct.Text = dtbl.Rows[0]["sum"].ToString();
                    txtTotalSalePrices.Text = dtbl.Rows[0]["sPrice"].ToString();
                    txtTotalPurchasePrice.Text = dtbl.Rows[0]["pPrice"].ToString();
                }
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

        private void frmStockAccount_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now.Date;
            dateTimePicker.Value = date;
            dateTimePicker1.Value = date;
            dateTimePicker2.Value = date;

            dateTimePicker2_ValueChanged(sender, e);
            dateTimePicker_ValueChanged(sender, e);
            chart();
        }

        void chart()
        {
            for (int i = 5; i >= 0; i--)
            {
                string date = DateTime.Now.AddDays(-i).ToString("MM/dd/yyyy");
                double sAmnt = 0.0, pAmnt = 0.0;
                try
                {
                    SqlDataAdapter sd = new SqlDataAdapter("SELECT SUM(pPrice * quantity) as sum, SUM(sPrice * quantity) as sum2 FROM tblStockHistory where dt = '" + date + "' ", obj.con);
                    DataTable dtbl = new DataTable();
                    sd.Fill(dtbl);
                    if (dtbl.Rows.Count < 1)
                    {
                        sAmnt = 0.0;
                        pAmnt = 0.0;
                    }
                        
                    else if (dtbl.Rows[0]["sum"].ToString() != "")
                    {
                        sAmnt = Convert.ToDouble(dtbl.Rows[0]["sum2"].ToString());
                        pAmnt = Convert.ToDouble(dtbl.Rows[0]["sum"].ToString());
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                this.chrtStocks.Series["Sales"].Points.AddXY(date, sAmnt);
                this.chrtStocks.Series["Purchase"].Points.AddXY(date, pAmnt);
            }
        }


    }
}
