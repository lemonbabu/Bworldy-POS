using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class frmAddStocks : Form
    {
        ConnectionString obj = new ConnectionString();
        int ctId, pId, quantity, refUsed;
        string date, userName;
        bool flg = false;
        DateTime dt;
        String brCodetxt;

        AppData.BarcodeDataTable _barcode;

        public frmAddStocks(string name)
        {
            InitializeComponent();
            userName = name;
            tblPnlBarcodeGenerate.Visible = false;
            tblPnlStocks.Visible = true;
            pnlReport.Visible = false;
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
                MessageBox.Show("Please select a categorie!!");
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
                        return;

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

        private void txtSalePrice_TextChange(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(txtSalePrice.Text, out parsedValue))
            {
                txtSalePrice.Text = "";
                return;
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            string pCtg = cmbProductCtg.Text.Trim().Replace("'", "''");
            string pName = cmbProductName.Text.Trim().Replace("'", "''");
            string psize = cmbProductSize.Text.Trim().Replace("'", "''");
            dt = DateTime.Now;
            //Call categories id funtions 
            pId = obj.funPrdId(ctId, pName, psize);
            if (pId == 0)
            {
                MessageBox.Show("Please select Product first !!", "Warning");
                return;
            }

            if (txtQuantity.Text == "" || txtBuyingPrice.Text == "" || txtSalePrice.Text == "")
            {
                MessageBox.Show("Please Fillup Quantity, Purchase and Sale Price!!", "Warning");
                return;
            }

            int qunt = Convert.ToInt16(txtQuantity.Text);
            double bPrice = Convert.ToDouble(txtBuyingPrice.Text);
            double sPrice = Convert.ToDouble(txtSalePrice.Text);


            //Check flg for update stock data or add new stock data  
            if (flg)
            {
                try
                {
                    DialogResult confirm = MessageBox.Show("Do you want to Add New Stocks? \nQuantity: " + qunt + "\nPurchase Price: " + bPrice + "\nSale Price: " + sPrice, "Confirmation", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        int qnt = qunt + quantity;
                        
                        obj.con.Open();
                        obj.cmd = new SqlCommand("UPDATE tblStock SET stock = '" + qnt + "', pPrice = '" + bPrice + "', sPrice = '" + sPrice + "', lastDate = '" + dt + "'  WHERE pId = '" + pId + "' ", obj.con);
                        obj.cmd.ExecuteNonQuery();
                        obj.con.Close();
                        insertStcokHistory(qunt, bPrice, sPrice, dt);
                        funIncProductUsed(ctId, pName, psize);
                        cmbProductSize.Text = "";
                    }
                    else if (confirm == DialogResult.No)
                    {
                        return;
                    }
                }
                catch (SqlException ex)
                {
                    obj.con.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //Insertions confimrations
                DialogResult confirm = MessageBox.Show("Do you want to Add New Stocks? \nQuantity: " + qunt + "\nPurchase Price: " + bPrice + "\nSale Price: " + sPrice, "Confirmation", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        obj.con.Open();
                        obj.cmd = new SqlCommand("INSERT INTO tblStock (pId, stock, pPrice, sPrice, lastDate)  VALUES('" + pId + "', '" + qunt + "', '" + bPrice + "', '" + sPrice + "', '" + dt + "')", obj.con);
                        obj.cmd.ExecuteNonQuery();
                        obj.con.Close();
                        //History table insertion query
                        insertStcokHistory(qunt, bPrice, sPrice, dt);
                        funIncProductUsed(ctId, pName, psize);
                        cmbProductSize.Text = "";
                    }
                    catch (SqlException ex)
                    {
                        obj.con.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (confirm == DialogResult.No)
                {
                    return;
                }
            }

            //Barcode Printing
            DialogResult conf = MessageBox.Show("Stock succesfully add. \nDo you want to Print Barcode?", "Confirmation", MessageBoxButtons.YesNo);
            if (conf == DialogResult.Yes)
            {
                try
                {
                    tblPnlBarcodeGenerate.Visible = true;
                    tblPnlStocks.Visible = false;
                    pnlReport.Visible = false;
                    pnlBarcode.Visible = false;

                    txtBarcodeQuantity.Text = qunt.ToString();
                    txtCtgProductBarcode.Text = pCtg.Replace("''", "'");
                    txtNameProductBarcode.Text = pName.Replace("''", "'");
                    txtSizeProductBarcode.Text = psize.Replace("''", "'");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (conf == DialogResult.No)
            {
                return;
            }

        }

        private void txtSalePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddStock_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btnAddStock.Focus();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            
            //this query for last quant
            SqlDataAdapter sd = new SqlDataAdapter("SELECT tblBarcode.pId as pId, tblBarcode.barcode as barcode, tblStock.sPrice as Price, tblProducts.pSize as Size FROM tblBarcode INNER JOIN tblStock ON tblBarcode.pId = tblStock.pId INNER JOIN tblProducts ON tblStock.pId = tblProducts.pId where tblBarcode.pId = '" + pId + "' ", obj.con);
            DataTable dtl = new DataTable();
            sd.Fill(dtl);
            if (dtl.Rows.Count < 1)
            {
                MessageBox.Show("This product is not available", "Warning");
                return;
            }
            else
            {
                pnlBarcode.Visible = true;

                brCodetxt = dtl.Rows[0]["barcode"].ToString();
                double price = Convert.ToDouble(dtl.Rows[0]["Price"].ToString());
                string sz = dtl.Rows[0]["Size"].ToString();

                BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
                Image img = barcode.Encode(BarcodeLib.TYPE.CODE128, brCodetxt, Color.Black, Color.White, 150, 60);
                pictureBox1.Image = img;

                this.appData1.Clear();
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, ImageFormat.Png);
                    int n = Convert.ToInt16(txtBarcodeQuantity.Text);
                    if (n < 4)
                        n = 1;
                    else
                    {
                        if (n % 4 == 0)
                            n = (n / 4);
                        else
                            n = (n / 4) + 1;
                    }
                    for (int i = 0; i < n; i++)
                        this.appData1.Barcode.AddBarcodeRow(brCodetxt, ms.ToArray(), price, sz);
                }

                barcodeInitaialization(this.appData1.Barcode);
            }

        }

        void barcodeInitaialization(AppData.BarcodeDataTable barcode)
        {
            this._barcode = barcode;
        }

        private void btnBarcodePrint_Click(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            reportDataSource.Value = _barcode;
            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();

            tblPnlBarcodeGenerate.Visible = false;
            tblPnlStocks.Visible = false;
            pnlReport.Visible = true;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            reset();
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


        void insertStcokHistory(int quantity, double pPrice, double sPrice, DateTime dt)
        {
            string dateOnly = DateTime.Now.Date.ToString();
            string s = "tblStockHistory";
            obj.con.Open();
            obj.cmd = new SqlCommand("INSERT INTO " + s + " (pId, quantity, pPrice, sPrice, date, dt, authUser)  VALUES('" + pId + "', '" + quantity + "', '" + pPrice + "', '" + sPrice + "', '" + dt + "', '" + dateOnly + "', '" + userName + "')", obj.con);
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
        }


        // This function for incresee product refurence value for referances 
        void funIncProductUsed(int ctgId, string name, string size)
        {
            try
            {
                SqlDataAdapter sd = new SqlDataAdapter("SELECT * FROM tblProducts where pCtgId = '" + ctgId + "' and pName = '" + name + "' and pSize = '" + size + "' ", obj.con);
                DataTable dtl = new DataTable();
                sd.Fill(dtl);
                int pref = Convert.ToInt16(dtl.Rows[0]["pRef"].ToString());
                pref = pref + 1;
                obj.con.Open();
                obj.cmd = new SqlCommand("UPDATE tblProducts SET pRef = '" + pref + "' WHERE pCtgId = '" + ctgId + "' and pName = '" + name + "' and pSize = '" + size + "'", obj.con);
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
            }
            catch (SqlException ex)
            {
                obj.con.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
