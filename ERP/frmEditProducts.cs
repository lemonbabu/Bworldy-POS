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
    public partial class frmEditProducts : Form
    {
        ConnectionString obj = new ConnectionString();
        int ctId;
        public frmEditProducts()
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
            String pName = cmbProductName.Text.Trim().Replace("'", "''"); ;
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

            txtProcutSize.Text = cmbProductSize.Text.Trim();
            txtProductName.Text = cmbProductName.Text.Trim();
            
        }

        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProcutSize.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtProcutSize.Focus();
            }
        }

        private void txtProcutSize_KeyDown(object sender, KeyEventArgs e)
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
                btnEditProduct_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btnEditProduct.Focus();
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            String pName = cmbProductName.Text.Trim().Replace("'", "''");
            String pSize = cmbProductSize.Text.Trim().Replace("'", "''");
            String newName = txtProductName.Text.Replace("'", "''");
            String newSize = txtProcutSize.Text.Replace("'", "''");
            String newDeatails = txtProductDetails.Text.Replace("'", "''");

            if (newName == "" && newSize == "")
            {
                MessageBox.Show("Please Insert Name and size!!");
                return;
            }
                
            try
            {
                string query = "select * from tblProducts where pCtgId = '" + ctId + "' and pName = '" + pName + "' and pSize = '" + pSize + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, obj.con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                {
                    MessageBox.Show("This Product " + pName + " is not available!!");
                    return;
                }

                else
                {
                    try
                    {
                        DialogResult confirm = MessageBox.Show("Do you want to Update Product Informations? \nProduct Name: " + pName + " to " + newName + "\nSize: " + pSize + " to " + newSize, "Confirmation", MessageBoxButtons.YesNo);
                        if (confirm == DialogResult.Yes)
                        {
                            obj.con.Open();
                            obj.cmd = new SqlCommand("UPDATE tblProducts SET pName = '" + newName + "', pSize = '" + newSize + "', pDetails = '" + newDeatails + "'  WHERE pCtgId = '" + ctId + "' and pName = '" + pName + "' and pSize = '" + pSize + "'", obj.con);
                            obj.cmd.ExecuteNonQuery();
                            obj.con.Close();
                            MessageBox.Show("Procut inforamtion is updated", "Sucssesfully");
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
                        obj.con.Close();
                    }
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


        void reset()
        {
            cmbProductSize.Text = "";
            cmbProductName.Text = "";
            cmbProductCtg.Text = "Please Select Categorie";
            txtProductDetails.Text = "";
            txtProcutSize.Text = "";
            txtProductName.Text = "";
            cmbProductCtg.Focus();
        }

        private void cmbProductSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtProductName.Focus();
        }
    }
}
