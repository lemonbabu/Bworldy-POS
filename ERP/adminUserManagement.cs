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
    public partial class adminUserManagement : Form
    {
        ConnectionString obj = new ConnectionString();
        public adminUserManagement()
        {
            InitializeComponent();
            txtUserName.Focus();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
            cmbPermission.Text = "";
        }

        private void adminUserManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.tblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.mainDataSet.tblUser);

        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string permission = cmbPermission.Text.Trim();

            if(userName == "" || password == "" || permission == "")
            {
                MessageBox.Show("Fillup requered data.", "Wrong");
                return;
            }

            try
            {
                string query = "select * from tblUser where userName = '" + userName + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, obj.con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                {
                    //Insertions Medicine
                    DialogResult confirm = MessageBox.Show("Do you want to Add New User?", "Confirmation", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        obj.con.Open();
                        obj.cmd = new SqlCommand("INSERT INTO tblUser (userName, password, permission)  VALUES('" + userName + "', '" + password + "', '" + permission + "')", obj.con);
                        obj.cmd.ExecuteNonQuery();
                        obj.con.Close();
                        dataGridViewRefash();
                    }
                    else if (confirm == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("This user is allready exits", "Wrong");
                    return;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void dataGridViewRefash()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from tblUser", obj.con);
            adapt.Fill(dt);
            dataGridViewUsers.DataSource = dt;
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i ;
            string userName;
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
                        i = Convert.ToInt16(dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
                        userName = dataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                        if (userName == "admin")
                        {
                            MessageBox.Show("You can't admin user.", "Error");
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
            obj.cmd = new SqlCommand("DELETE FROM tblUser WHERE Id = '" + i + "'", obj.con);
            try
            {
                obj.con.Open();
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
                dataGridViewRefash();
            }
            catch (Exception e)
            {
                MessageBox.Show("SQL error" + e);
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbPermission.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                cmbPermission.Focus();
            }
        }

        private void cmbPermission_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddNewUser_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btnAddNewUser.Focus();
            }
        }

        private void btnAddNewUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                lblClear.Focus();
            }
        }

        private void lblClear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                dataGridViewUsers.Focus();
            }
        }
    }
}
