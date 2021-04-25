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
    public partial class frmViewStock : Form
    {
        ConnectionString obj = new ConnectionString();
        public frmViewStock()
        {
            InitializeComponent();
        }

        private void frmViewStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tblLowStock' table. You can move, or remove it, as needed.
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ctg = txtCategorie.Text.Replace("'", "''");

            if (ctg == "")
            {
                reload();
                return;
            }

            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStock.stock FROM tblStock JOIN tblProducts ON tblStock.pId = tblProducts.pId JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId  where tblCategories.ctgName = '"+ ctg +"' ", obj.con);
            adapt.Fill(dt);
            dataGridViewStock.DataSource = dt;

            dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT SUM(tblStock.stock) as sum FROM tblStock JOIN tblProducts ON tblStock.pId = tblProducts.pId JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId  where tblCategories.ctgName = '" + ctg + "' ", obj.con);
            adapt.Fill(dt);
            if (dt.Rows.Count < 1)
                lblTotal.Text = "0";
            else
                lblTotal.Text = dt.Rows[0]["sum"].ToString();
        }

        void reload()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStock.stock FROM tblStock JOIN tblProducts ON tblStock.pId = tblProducts.pId JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId ", obj.con);
            adapt.Fill(dt);
            dataGridViewStock.DataSource = dt;

            dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT SUM(tblStock.stock) as sum FROM tblStock JOIN tblProducts ON tblStock.pId = tblProducts.pId JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId ", obj.con);
            adapt.Fill(dt);
            if (dt.Rows.Count < 1)
                lblTotal.Text = "0";
            else
                lblTotal.Text = dt.Rows[0]["sum"].ToString();

        }


    }
}
