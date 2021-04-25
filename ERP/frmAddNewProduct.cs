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
    public partial class frmAddNewProduct : Form
    {
        String pCategorie;
        ConnectionString obj = new ConnectionString();
        public frmAddNewProduct()
        {
            InitializeComponent();

            obj.cmd = new SqlCommand("select ctgName from tblCategories", obj.con);
            obj.con.Open();
            SqlDataReader dr = obj.cmd.ExecuteReader();
            AutoCompleteStringCollection mycollaction = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                mycollaction.Add(dr.GetString(0));
            }
            txtProductCtg.AutoCompleteCustomSource = mycollaction;
            obj.con.Close();
            txtProductCtg.Text = "sffs";
            reset();
        }



        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            String pName = txtProductName.Text.Replace("'", "''");
            String pSize = txtProductSize.Text.Replace("'", "''");
            String pDetails = txtProductDetails.Text.Replace("'", "''");
            String pCtg = txtProductCtg.Text.Replace("'", "''");
            //Call categories id funtions 
            int ctId = obj.funCtgId(pCtg);
            if (ctId == 0)
            {
                MessageBox.Show("Please select a categorie!!");
                return;
            }


            if (pName != "" && pSize != "")
            {
                string query = "select * from tblProducts where pCtgId = '" + ctId + "' and pName = '" + pName + "' and pSize = '" + pSize + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, obj.con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                {
                    //Insertions Medicine
                    DialogResult confirm = MessageBox.Show("Do you want to Add New Product? \nProduct Name: " + pName + "\nSize: " + pSize, "Confirmation", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        try
                        {
                            obj.con.Open();
                            obj.cmd = new SqlCommand("INSERT INTO tblProducts (pCtgId, pName, pSize, pDetails)  VALUES('" + ctId + "', '" + pName + "', '" + pSize + "', '" + pDetails + "')", obj.con);
                            obj.cmd.ExecuteNonQuery();
                            reset();
                            obj.con.Close();
                            MessageBox.Show("Add Product", "Sucssesfully");
                            obj.funIncCtgUsed(ctId.ToString());
                            txtProductCtg.Focus();
                            barcode(ctId, pName, pSize);
                            return;
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
                else
                {
                    obj.msg("This product is Allready added!!");
                }
            }
            else
            {
                obj.msg("Please fillup Prodcut information.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            txtProductDetails.Text = "";
            txtProductName.Text = "";
            txtProductSize.Text = "";
            txtProductCtg.Text = "";
        }


        private void txtProductSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProductDetails.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtProductDetails.Focus();
            }
        }

        private void txtProductDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddNewProduct_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btnAddNewProduct.Focus();
            }
        }

        
        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProductSize.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtProductSize.Focus();
            }
        }

        private void txtProductName_Click(object sender, EventArgs e)
        { /*
            String ctgName = txtProductCtg.Text;
            int ctId = obj.funCtgId(ctgName);
            if (ctId == 0)
            {
                MessageBox.Show("Please select a categorie!!");
                return;
            }
            
            obj.cmd = new SqlCommand("select pName from tblProducts where pCtId = '" + ctId + "' ", obj.con);
            obj.con.Open();
            SqlDataReader dr = obj.cmd.ExecuteReader();
            AutoCompleteStringCollection mycollaction = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                mycollaction.Add(dr.GetString(0));
            }
            txtProductName.AutoCompleteCustomSource = mycollaction;
            obj.con.Close();
            */
        }


        void barcode(int ctId, string pName, string pSize)
        {
            string query = "select pId from tblProducts where pCtgId = '" + ctId + "' and pName = '" + pName + "' and pSize = '" + pSize + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, obj.con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            int pId = Convert.ToInt16(dtbl.Rows[0]["pId"].ToString());

            long barcode = 202000000000 + pId;
            String Brcode = barcode.ToString();

            obj.con.Open();
            obj.cmd = new SqlCommand("INSERT INTO tblBarcode (pId, barcode)  VALUES('" + pId + "', '" + Brcode + "')", obj.con);
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();

        }

        private void txtProductCtg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProductName.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtProductName.Focus();
            }
        }
    }
}
