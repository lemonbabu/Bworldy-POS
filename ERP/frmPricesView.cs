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
    public partial class frmPricesView : Form
    {
        ConnectionString obj = new ConnectionString();
        public frmPricesView()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ctg = txtCategorie.Text.Replace("'", "''");

            if (ctg == "")
            {
                reload();
                return;
            }

            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStock.stock, tblStock.pPrice, tblStock.sPrice, tblStock.discount FROM tblStock JOIN tblProducts ON tblStock.pId = tblProducts.pId JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId  where tblCategories.ctgName = '" + ctg + "' ", obj.con);
            adapt.Fill(dt);
            dataGridviewPriceView.DataSource = dt;

            dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT SUM(tblStock.stock) as stock, SUM(tblStock.pPrice * tblStock.stock) as pPrice, SUM(tblStock.sPrice * tblStock.stock) as sPrice, SUM(tblStock.discount) as discount  FROM tblStock JOIN tblProducts ON tblStock.pId = tblProducts.pId JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId  where tblCategories.ctgName = '" + ctg + "' ", obj.con);
            adapt.Fill(dt);
            if (dt.Rows.Count < 1)
            {
                lblTotalDisc.Text = "0";
                lblTotalPPrice.Text = "0";
                lblTotalQun.Text = "0";
                lblTotalSPrice.Text = "0";
            }
            else
            {
                lblTotalDisc.Text = dt.Rows[0]["discount"].ToString();
                lblTotalPPrice.Text = dt.Rows[0]["pPrice"].ToString();
                lblTotalQun.Text = dt.Rows[0]["stock"].ToString();
                lblTotalSPrice.Text = dt.Rows[0]["sPrice"].ToString();
            }
        }

        private void frmPricesView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tblPriceView' table. You can move, or remove it, as needed.
            //this.tblPriceViewTableAdapter.Fill(this.appData.tblPriceView);
            reload();

            obj.cmd = new SqlCommand("select ctgName from tblCategories", obj.con);
            obj.con.Open();
            SqlDataReader dr = obj.cmd.ExecuteReader();
            AutoCompleteStringCollection mycollaction = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                mycollaction.Add(dr.GetString(0));
            }
            txtCategorie.AutoCompleteCustomSource = mycollaction;
            obj.con.Close();
            txtCategorie.Text = "sffs";
            txtCategorie.Text = "";
        }

        private void txtCategorie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btnSearch.Focus();
            }
        }


        void reload()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStock.stock, tblStock.pPrice, tblStock.sPrice, tblStock.discount FROM tblStock JOIN tblProducts ON tblStock.pId = tblProducts.pId JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId ", obj.con);
            adapt.Fill(dt);
            dataGridviewPriceView.DataSource = dt;

            dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT SUM(tblStock.stock) as stock, SUM(tblStock.pPrice * tblStock.stock) as pPrice, SUM(tblStock.sPrice * tblStock.stock) as sPrice, SUM(tblStock.discount) as discount  FROM tblStock JOIN tblProducts ON tblStock.pId = tblProducts.pId JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId ", obj.con);
            adapt.Fill(dt);
            if (dt.Rows.Count < 1)
            {
                lblTotalDisc.Text = "0";
                lblTotalPPrice.Text = "0";
                lblTotalQun.Text = "0";
                lblTotalSPrice.Text = "0";
            }
            else
            {
                lblTotalDisc.Text = dt.Rows[0]["discount"].ToString();
                lblTotalPPrice.Text = dt.Rows[0]["pPrice"].ToString();
                lblTotalQun.Text = dt.Rows[0]["stock"].ToString();
                lblTotalSPrice.Text = dt.Rows[0]["sPrice"].ToString();
            }

        }

    }
}
