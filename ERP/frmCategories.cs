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
    public partial class frmCategories : Form
    {
        ConnectionString obj = new ConnectionString();
        public frmCategories()
        {
            InitializeComponent();
            gridViewRefash();
        }

        private void btnAddCtg_Click(object sender, EventArgs e)
        {
            String cName = txtCtgName.Text.Replace("'", "''");

            if (cName != "")
            {
                try
                {
                    string query = "select * from tblCategories where ctgName = '" + cName + "' ";
                    SqlDataAdapter sda = new SqlDataAdapter(query, obj.con);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    if (dtbl.Rows.Count < 1)
                    {
                        //Insertions Medicine
                        DialogResult confirm = MessageBox.Show("Do you want to Add New Categorie? \nCategories Name: " + cName, "Confirmation", MessageBoxButtons.YesNo);
                        if (confirm == DialogResult.Yes)
                        {
                            try
                            {
                                obj.con.Open();
                                obj.cmd = new SqlCommand("INSERT INTO tblCategories (ctgName)  VALUES('" + cName + "')", obj.con);
                                obj.cmd.ExecuteNonQuery();
                                obj.con.Close();
                                txtCtgName.Text = "";
                                gridViewRefash();
                                return;
                            }
                            catch (SqlException ex)
                            {
                                obj.con.Close();
                                MessageBox.Show(ex.Message + " Please Enter correct categorie name.");
                            }
                        }
                        else if (confirm == DialogResult.No)
                        {
                            return;
                        }
                    }
                    else
                    {
                        obj.msg("This Categorie is allready added!!");
                    }
                }
                catch (SqlException ex)
                {
                    obj.con.Close();
                    MessageBox.Show(ex.Message + " Please Enter correct categorie name.");
                }

            }
            else
            {
                obj.msg("Please fillup Categorie Name.");
            }
        }


        void gridViewRefash()
        {
            obj.con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from tblCategories", obj.con);
            adapt.Fill(dt);
            dataGrdViewCtg.DataSource = dt;
            obj.con.Close();
        }

        private void dataGrdViewCtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i, product;
            if (e.ColumnIndex == 3)
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
                        i = Convert.ToInt16(dataGrdViewCtg.Rows[e.RowIndex].Cells[0].Value.ToString());
                        product = Convert.ToInt16(dataGrdViewCtg.Rows[e.RowIndex].Cells[2].Value.ToString());
                        if (product > 0)
                        {
                            MessageBox.Show("You can't delete this categories because of used in products.");
                            return;
                        }
                        else
                        {
                            BindingSource a = new BindingSource();
                            deleteItem(a, i);
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
        void deleteItem(BindingSource a, int i)
        {
            obj.cmd = new SqlCommand("DELETE FROM tblCategories WHERE ctgId = '" + i + "'", obj.con);
            try
            {
                obj.con.Open();
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
                gridViewRefash();
            }
            catch (Exception e)
            {
                MessageBox.Show("SQL error" + e);
            }
        }

        private void txtCtgName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddCtg_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btnAddCtg.Focus();
            }
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.tblCategories' table. You can move, or remove it, as needed.
            this.tblCategoriesTableAdapter.Fill(this.mainDataSet.tblCategories);

        }
    }
}
