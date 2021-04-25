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
    public partial class frmEditStocks : Form
    {
        ConnectionString obj = new ConnectionString();
        int ctId, pId, quantity, refUsed;
        string date, userName = "admin";
        bool flg = false;
        DateTime dt;

        public frmEditStocks()
        {
            InitializeComponent();
        }

        private void cmbProductCtg_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT ctgName FROM tblCategories", obj.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Assign DataTable as DataSource.
                cmbProductCtg.DataSource = dt;
                cmbProductCtg.DisplayMember = "ctgName";
                cmbProductCtg.ValueMember = "ctgName";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmbProductName.Text = "Product Name";
        }

        private void cmbProductName_Click(object sender, EventArgs e)
        {
            String pCtgName = cmbProductCtg.Text.Trim().Replace("'", "''");
            //Call categories id funtions 
            ctId = obj.funCtgId(pCtgName);
            if (ctId == 0)
            {
                MessageBox.Show("Please select a categorie!!", "Warning");
                return;
            }
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT DISTINCT pName FROM tblProducts where pCtgId = '" + ctId + "'", obj.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Assign DataTable as DataSource.
                cmbProductName.DataSource = dt;
                cmbProductName.DisplayMember = "pName";
                cmbProductName.ValueMember = "pName";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmbProductSize.Text = "Size";
        }

        private void cmbProductSize_Click(object sender, EventArgs e)
        {
            String pName = cmbProductName.Text.Trim().Replace("'", "''");
            dt = DateTime.Now;

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT pSize FROM tblProducts where pCtgId = '" + ctId + "' and pName = '" + pName + "'  ", obj.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Assign DataTable as DataSource.
                cmbProductSize.DataSource = dt;
                cmbProductSize.DisplayMember = "pSize";
                cmbProductSize.ValueMember = "pSize";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cmbProductSize_SelectedValueChanged(object sender, EventArgs e)
        {
            String pName = cmbProductName.Text.Trim().Replace("'", "''");
            string psize = cmbProductSize.Text.Trim().Replace("'", "''");
            //Call categories id funtions 
            pId = obj.funPrdId(ctId, pName, psize);
            if (pId == 0)
            {
                return;
            }
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblStock where pId = '" + pId + "' ", obj.con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                {
                    txtLDate.Text = "0";
                    txtLPPrice.Text = "0";
                    txtLQun.Text = "0";
                    txtLSalePrice.Text = "0";
                    txtCurentStock.Text = "0";
                    txtQuantity.Focus();
                    flg = false;
                    return;
                }
                else
                {
                    txtLDate.Text = dtbl.Rows[0]["lastDate"].ToString();
                    txtCurentStock.Text = dtbl.Rows[0]["stock"].ToString();
                    txtLPPrice.Text = dtbl.Rows[0]["pPrice"].ToString();
                    txtLSalePrice.Text = dtbl.Rows[0]["sPrice"].ToString();
                    date = dtbl.Rows[0]["lastDate"].ToString();
                    quantity = Convert.ToInt16(dtbl.Rows[0]["stock"].ToString());
                    flg = true;
                    //this query for last quant
                    SqlDataAdapter sd = new SqlDataAdapter("SELECT * FROM tblStockHistory where pId = '" + pId + "' and date = '" + date + "' ", obj.con);
                    DataTable dtl = new DataTable();
                    sd.Fill(dtl);
                    if (dtl.Rows.Count < 1)
                    {
                        txtLQun.Text ="0";
                    }
                    else
                        txtLQun.Text = dtl.Rows[0]["quantity"].ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            //txtQuantity.Focus();
        }


        private void txtQuantity_TextChange(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txtQuantity.Text, out parsedValue))
            {
                txtQuantity.Text = "";
                return;
            }
        }

        private void txtBuyingPrice_TextChange(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(txtBuyingPrice.Text, out parsedValue))
            {
                txtBuyingPrice.Text = "";
                return;
            }
        }


        private void txtSalePrice_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(txtSalePrice.Text, out parsedValue))
            {
                txtSalePrice.Text = "";
                return;
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBuyingPrice.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtBuyingPrice.Focus();
            }
        }

        private void txtBuyingPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSalePrice.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtSalePrice.Focus();
            }
        }

        private void btnEditStock_Click(object sender, EventArgs e)
        {
            String pName = cmbProductName.Text.Trim().Replace("'", "''");
            string psize = cmbProductSize.Text.Trim().Replace("'", "''");
            //Call categories id funtions 
            pId = obj.funPrdId(ctId, pName, psize);
            if (pId == 0)
            {
                MessageBox.Show("Please select Product Firs!!", "Warning");
                return;
            }

            if (txtQuantity.Text == "" && txtBuyingPrice.Text == "" && txtSalePrice.Text == "")
            {
                MessageBox.Show("Please Fillup Quantity, Purchase and Sale Price!!", "Warning");
                return;
            }

            int equantity = Convert.ToInt16(txtQuantity.Text);
            double pPrice = Convert.ToDouble(txtBuyingPrice.Text);
            double sPrice = Convert.ToDouble(txtSalePrice.Text);
            int cquantity = Convert.ToInt16(txtCurentStock.Text);
            int xquantity = Convert.ToInt16(txtLQun.Text);
            DateTime oldDate = Convert.ToDateTime(txtLDate.Text);
            int lessqun = xquantity - equantity;
            if (lessqun > cquantity)
            {
                MessageBox.Show("It's not possible to curent stock less then edit stock!!", "Warning");
                return;
            }

            cquantity = cquantity - lessqun;

            try
            {
                DialogResult confirm = MessageBox.Show("Do you want to Edit Stocks? \nNew Quantity: " + equantity + "\nPurchase Price: " + pPrice + "\nSale Price: " + sPrice, "Confirmation", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    obj.con.Open();
                    obj.cmd = new SqlCommand("UPDATE tblStock SET stock = '" + cquantity + "', pPrice = '" + pPrice + "', sPrice = '" + sPrice + "', lastDate = '" + dt + "'  WHERE pId = '" + pId + "' ", obj.con);
                    obj.cmd.ExecuteNonQuery();

                    obj.cmd = new SqlCommand("UPDATE tblStockHistory SET quantity = '" + equantity + "', pPrice = '" + pPrice + "', sPrice = '" + sPrice + "', date = '" + dt + "'  WHERE pId = '" + pId + "' and date = '" + oldDate + "'", obj.con);
                    obj.cmd.ExecuteNonQuery();
                    obj.con.Close();
                    MessageBox.Show("Stock Inforamtion is Updated", "Sucssesfully");
                    reset();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void txtSalePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEditStock_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btnEditStock.Focus();
            }
        }

        void reset()
        {
            cmbProductCtg.Text = "Select a Categorie";
            cmbProductName.Text = "";
            cmbProductSize.Text = "";
            txtSalePrice.Text = "";
            txtBuyingPrice.Text = "";
            txtQuantity.Text = "";
            txtLDate.Text = "";
            txtLPPrice.Text = "";
            txtLQun.Text = "";
            txtLSalePrice.Text = "";
            txtCurentStock.Text = "";
        }

    }
}
