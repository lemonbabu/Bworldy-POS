using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class userProfile : Form
    {
        ConnectionString obj = new ConnectionString();
        string userName, imgLoc;
        public userProfile(string name)
        {
            InitializeComponent();
            userName = name;
            txtUserName.Text = userName;
        }

        /*
        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png | All Files(*.*)|*.*";

                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imgLoc = dialog.FileName;
                    pictureBox1.ImageLocation = imgLoc;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }*/

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string fName = txtFullName.Text.Replace("'", "''");
            string pas = txtCurrentPassword.Text.Replace("'", "''");
            string newPas = txtPassword.Text.Replace("'", "''");
            string conPas = txtConfirmPassword.Text.Replace("'", "''");
            //byte[] img = null;
            //FileStream stream = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
            // BinaryReader brs = new BinaryReader(stream);
            //img = brs.ReadBytes((int) stream.Length);

            if (newPas == "" || conPas == "" || pas == "" || fName == "")
            {
                MessageBox.Show("Fillup all filled first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(newPas == conPas)
            {
                //this query for last quant
                SqlDataAdapter sd = new SqlDataAdapter("SELECT * FROM tblUser where userName = '" + userName + "' and password = '"+ pas +"' ", obj.con);
                DataTable dtl = new DataTable();
                sd.Fill(dtl);
                if (dtl.Rows.Count < 1)
                {
                    MessageBox.Show("Current password is not correct.", "Warning");
                    return;
                }
                else
                {
                    try
                    {
                        obj.con.Open();
                        obj.cmd = new SqlCommand("UPDATE tblUser SET password = '" + newPas + "', fullName = '" + fName + "' WHERE userName = '" + userName + "'", obj.con);
                        obj.cmd.ExecuteNonQuery();
                        obj.con.Close();
                        MessageBox.Show("Update your profile", "Succesfull");
                        this.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
                MessageBox.Show("New password not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtFullName_KeyDown(object sender, KeyEventArgs e)
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
                txtConfirmPassword.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtConfirmPassword.Focus();
            }
        }

        private void txtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCurrentPassword.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtCurrentPassword.Focus();
            }
        }

        private void txtCurrentPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btnUpdate.Focus();
            }
        }

        private void btnUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                lblClear.Focus();
            }
        }

        private void lblClear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblClear_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtFullName.Focus();
            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtCurrentPassword.Text = "";
            txtPassword.Text = "";
            txtFullName.Text = "";
            txtConfirmPassword.Text = "";
        }



    }
}
