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
    public partial class adminSetOffer : Form
    {
        ConnectionString obj = new ConnectionString();
        int ctId, pId;

        public adminSetOffer()
        {
            InitializeComponent();
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
                    txtLPPrice.Text = "0";
                    txtLSalePrice.Text = "0";
                    txtCurentStock.Text = "0";
                    txtOffer.Text = "";
                    return;
                }
                else
                {
                    txtCurentStock.Text = dtbl.Rows[0]["stock"].ToString();
                    txtLPPrice.Text = dtbl.Rows[0]["pPrice"].ToString();
                    txtLSalePrice.Text = dtbl.Rows[0]["sPrice"].ToString();
                    txtOffer.Text = dtbl.Rows[0]["discount"].ToString();
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
            cmbProductCtg.Text = "Select a Categorie";
            cmbProductName.Text = "";
            cmbProductSize.Text = "";
            txtLPPrice.Text = "";
            txtOfferValue.Text = "";
            txtLSalePrice.Text = "";
            txtCurentStock.Text = "";
            txtOffer.Text = "";
            cmbType.Text = "";
        }

        private void btnSetOffer_Click(object sender, EventArgs e)
        {
            string type = cmbType.Text.Trim().Replace("'", "''");

            if (txtOfferValue.Text == "" || type == "")
            {
                MessageBox.Show("Please Set Offer and type !!", "Warning");
                return;
            }

            double offer;
            double sPrice;

            String ctg = cmbProductCtg.Text.Trim().Replace("'", "''");
            String name = cmbProductName.Text.Trim().Replace("'", "''");
            String size = cmbProductSize.Text.Trim().Replace("'", "''");

            if (ctg != "" && name != "" && size != "" && size != "Size")
            {
                offer = Convert.ToDouble(txtOfferValue.Text);
                sPrice = Convert.ToDouble(txtLSalePrice.Text);
                if (type == "%")
                {
                    offer = (sPrice * offer) / 100;
                }

                //Call categories id funtions 
                pId = obj.funPrdId(ctId, name, size);
                if (pId == 0)
                {
                    MessageBox.Show("Please select Product first !!", "Warning");
                    return;
                }

                try
                {
                    DialogResult confirm = MessageBox.Show("Do you want to set New Offer?", "Confirmation", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        obj.con.Open();
                        obj.cmd = new SqlCommand("UPDATE tblStock SET discount = '" + offer + "' WHERE pId = '" + pId + "' ", obj.con);
                        obj.cmd.ExecuteNonQuery();
                        obj.con.Close();
                        MessageBox.Show("Offer Inforamtion is Updated", "Sucssesfully");
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
            else if (ctg != "" && name != "" && size == "Size")
            {
                int cId = obj.funCtgId(ctg);
                try
                {
                    string query = "select * from tblProducts where pCtgId = '" + cId + "' and pName = '" + name + "' ";
                    SqlDataAdapter sda = new SqlDataAdapter(query, obj.con);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    if (dtbl.Rows.Count >= 1)
                    {
                        DialogResult confirm = MessageBox.Show("Do you want to set New Offer?", "Confirmation", MessageBoxButtons.YesNo);
                        if (confirm == DialogResult.Yes)
                        {
                            DataTable dtl = new DataTable();
                            for (int i = 0; i < dtbl.Rows.Count; i++)
                            {
                                int id = Convert.ToInt16(dtbl.Rows[i]["pId"].ToString());

                                SqlDataAdapter sd = new SqlDataAdapter("SELECT * FROM tblStock where pId = '" + id + "' ", obj.con);
                                DataTable dt = new DataTable();
                                sd.Fill(dt);
                                if (dt.Rows.Count < 1)
                                {
                                    MessageBox.Show("No product found");
                                    return;
                                }
                                else
                                {
                                    offer = Convert.ToDouble(txtOfferValue.Text);
                                    sPrice = Convert.ToDouble(dt.Rows[0]["sPrice"].ToString());
                                    if (type == "%")
                                    {
                                        offer = (sPrice * offer) / 100;
                                    }
                                }


                                obj.con.Open();
                                obj.cmd = new SqlCommand("UPDATE tblStock SET discount = '" + offer + "' WHERE pId = '" + id + "' ", obj.con);
                                obj.cmd.ExecuteNonQuery();
                                obj.con.Close();
                            
                            }
                            MessageBox.Show("Offer Inforamtion is Updated", "Sucssesfully");
                            reset();

                        }
                        else if (confirm == DialogResult.No)
                        {
                            obj.con.Close();
                            return;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Please select Product first !!", "Warning");
                        return;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void txtOfferValue_TextChange(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(txtOfferValue.Text, out parsedValue))
            {
                txtOfferValue.Text = "";
                return;
            }
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
    }
}
