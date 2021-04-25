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
    public partial class frmDefectProduct : Form
    {
        ConnectionString obj = new ConnectionString();
        long barcode;
        int pId, custId, ctgId, saleId, quantity;
        String name, ctg, size, sPrice, disc, stock;

        private void frmDefectProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tblDefectProducts' table. You can move, or remove it, as needed.
           // this.tblDefectProductsTableAdapter.Fill(this.appData.tblDefectProducts);

        }

        private void btnViewDefects_Click(object sender, EventArgs e)
        {
            pnlDefectProductView.Visible = true;
            tblPnlDefectProduct.Visible = false;
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(" SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblDefectProduct.quantity, tblDefectProduct.details, tblDefectProduct.date FROM tblDefectProduct INNER JOIN tblProducts ON tblDefectProduct.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId ", obj.con);
                adapt.Fill(dt);
                dataGridViewDefectProductView.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public frmDefectProduct()
        {
            InitializeComponent();
            pnlDefectProductView.Visible = false;
            tblPnlDefectProduct.Visible = true;
        }

        private void txtDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirm_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btnConfirm.Focus();
            }
        }

        private void txtDetails_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDetails.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtDetails.Focus();
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(txtBarcode.Text, out parsedValue))
            {
                txtBarcode.Text = "";
                return;
            }

            string brcd = txtBarcode.Text;

            int len = brcd.Length;
            if (len != 12 || brcd == "")
                return;
            else
            {
                try
                {
                    barcode = Convert.ToInt64(brcd);
                    //this for get pId from barcode table 
                    SqlDataAdapter sd = new SqlDataAdapter("SELECT pId FROM tblBarcode where barcode = '" + barcode + "'", obj.con);
                    DataTable dtbl = new DataTable();
                    sd.Fill(dtbl);
                    if (dtbl.Rows.Count < 1)
                    {
                        MessageBox.Show("This product is not found");
                        resetDetails();
                        return;
                    }
                    else
                    {
                        pId = Convert.ToInt16(dtbl.Rows[0]["pId"].ToString());
                        sd = new SqlDataAdapter("SELECT * FROM tblProducts where pId = '" + pId + "'", obj.con);
                        dtbl = new DataTable();
                        sd.Fill(dtbl);

                        ctgId = Convert.ToInt16(dtbl.Rows[0]["pCtgId"].ToString());
                        name = dtbl.Rows[0]["pName"].ToString();
                        size = dtbl.Rows[0]["pSize"].ToString();
                        string details = dtbl.Rows[0]["pDetails"].ToString();

                        lblPdcName.Text = name;
                        lblPdcSize.Text = size;
                        lblPdcDetails.Text = details;

                        sd = new SqlDataAdapter("SELECT * FROM tblCategories where ctgId = '" + ctgId + "'", obj.con);
                        dtbl = new DataTable();
                        sd.Fill(dtbl);
                        ctg = dtbl.Rows[0]["ctgName"].ToString();
                        lblCtgName.Text = ctg;

                        sd = new SqlDataAdapter("SELECT * FROM tblStock where pId = '" + pId + "'", obj.con);
                        dtbl = new DataTable();
                        sd.Fill(dtbl);
                        sPrice = dtbl.Rows[0]["sPrice"].ToString();
                        disc = dtbl.Rows[0]["discount"].ToString();
                        stock = dtbl.Rows[0]["stock"].ToString();

                        lblDiscount.Text = disc;
                        lblSalePrice.Text = sPrice;
                        lblStock.Text = stock;


                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string detls = txtDetails.Text.Replace("'", "''");
            DateTime date = DateTime.Now.Date;
            obj.con.Open();
            if (detls == "")
            {
                MessageBox.Show("Please write details of defects!!","Warning");
                return;
            }
            else
            {
                try
                {
                    SqlDataAdapter sd = new SqlDataAdapter("SELECT * FROM tblDefectProduct where pId = '" + pId + "' ", obj.con);
                    DataTable dtbl = new DataTable();
                    sd.Fill(dtbl);
                    if (dtbl.Rows.Count < 1)
                    {
                        obj.cmd = new SqlCommand("INSERT INTO tblDefectProduct (pId, quantity, details, date)  VALUES('" + pId + "', '" + 1 + "', '" + detls + "', '" + date + "')", obj.con);
                        obj.cmd.ExecuteNonQuery();
                        txtBarcode.Text = "";
                    }
                    else
                    {
                        int quantity = Convert.ToInt16(dtbl.Rows[0]["quantity"].ToString());
                        quantity = quantity + 1;
                        obj.cmd = new SqlCommand("UPDATE tblDefectProduct SET quantity = '" + quantity + "' where pId = '" + pId + "' ", obj.con);
                        obj.cmd.ExecuteNonQuery();
                    }

                    // decrise product quantity from stock table 
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblStock where pId = '" + pId + "' ", obj.con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    int stk = Convert.ToInt16(dt.Rows[0]["stock"].ToString());

                    stk = stk - 1;
                    obj.cmd = new SqlCommand("UPDATE tblStock SET stock = '" + stk + "' WHERE pId = '" + pId + "' ", obj.con);
                    obj.cmd.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            resetDetails();
            obj.con.Close();
        }

        void resetDetails()
        {
            lblCtgName.Text = "0";
            lblDiscount.Text = "0";
            lblPdcDetails.Text = "";
            lblPdcName.Text = "0";
            lblPdcSize.Text = "0";
            lblSalePrice.Text = "0";
            lblStock.Text = "0";
            txtBarcode.Text = "";
            txtBarcode.Focus();
        }
    }
}
