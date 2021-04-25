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
    public partial class frmViewProducts : Form
    {
        ConnectionString obj = new ConnectionString();
        public frmViewProducts()
        {
            InitializeComponent();
        }

        private void btnReloadView_Click(object sender, EventArgs e)
        {
            gridViewRefash();
        }

        void gridViewRefash()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT tblProducts.pName, tblProducts.pSize, tblProducts.pDetails, tblCategories.ctgName, tblProducts.pId, tblProducts.pRef FROM  tblProducts INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId", obj.con);
            adapt.Fill(dt);
            dataGridViewPrdts.DataSource = dt;
        }


        private void dataGridViewPrdts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i, product;
            String pName, pSize, pCtg;
            if (e.ColumnIndex == 6)
            {
                // This condition for column clik avoiding
                i = Convert.ToInt16(e.RowIndex.ToString());
                if (i < 0)
                    return;
                DialogResult result = MessageBox.Show("Are you sure to delete?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        pName = dataGridViewPrdts.Rows[e.RowIndex].Cells[2].Value.ToString();
                        pCtg = dataGridViewPrdts.Rows[e.RowIndex].Cells[1].Value.ToString();
                        pSize = dataGridViewPrdts.Rows[e.RowIndex].Cells[3].Value.ToString();
                        product = Convert.ToInt16(dataGridViewPrdts.Rows[e.RowIndex].Cells[5].Value.ToString());
                        if (product > 0)
                        {
                            MessageBox.Show("You can't delete this Product because of it's used in Sale and Stocks.");
                            return;
                        }
                        else
                        {
                            BindingSource a = new BindingSource();
                            deleteItem(a, pName, pCtg, pSize);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
        }


        //Delete 1 item from graidview in the tbleNewSells
        void deleteItem(BindingSource a, String name, String ctg, String size)
        {
            int ctgId = obj.funCtgId(ctg);
            obj.cmd = new SqlCommand("DELETE FROM tblProducts WHERE pCtgId = '" + ctgId + "' and pName = '" + name + "' and pSize = '" + size + "'  ", obj.con);
            try
            {
                obj.con.Open();
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
                gridViewRefash();
                // chek referacne and decress catagoris referance
                funDecProductUsed(ctgId);
            }
            catch (Exception e)
            {
                MessageBox.Show("SQL error" + e);
            }
        }


        //this function for decrice cetegories referacnes 
        void funDecProductUsed(int ctgId)
        {
            try
            {
                SqlDataAdapter sd = new SqlDataAdapter("SELECT * FROM tblCategories where ctgId = '" + ctgId + "' ", obj.con);
                DataTable dtl = new DataTable();
                sd.Fill(dtl);
                int pref = Convert.ToInt16(dtl.Rows[0]["ctgUsed"].ToString());
                pref = pref - 1;
                obj.con.Open();
                obj.cmd = new SqlCommand("UPDATE tblCategories SET ctgUsed = '" + pref + "' WHERE ctgId = '" + ctgId + "' ", obj.con);
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmViewProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tblProductView' table. You can move, or remove it, as needed.
            //this.tblProductViewTableAdapter.Fill(this.appData.tblProductView);
            gridViewRefash();
        }
    }
}
