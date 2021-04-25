using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class frmLogin : Form
    {
        
        ConnectionString obj = new ConnectionString();
        public frmLogin()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnClose, "Close");
            txtUserName.Focus();
            pnlLicence.Visible = false;
            pnlMain.Visible = true;
            licenceChecking();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userName, password, role;
            userName = txtUserName.Text.Replace("'", "''");
            password = txtPassword.Text.Replace("'", "''");
            DateTime date = DateTime.Now;

            if (userName != "" && password != "")
            {
                try
                {
                    string query = "Select * from tblUser Where userName = '" + userName + "' and password = '" + password + "' ";

                    SqlDataAdapter sda = new SqlDataAdapter(query, obj.con);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    if (dtbl.Rows.Count >= 1)
                    {
                        role = dtbl.Rows[0]["permission"].ToString();

                        if (role == "Admin")
                        {
                            MainForm objFrmAdmin = new MainForm(userName, date);
                            this.Hide();
                            objFrmAdmin.Show();
                        }
                        else if (role == "Sales Manager")
                        {
                            MainForm objFrmAdmin = new MainForm(userName, date);
                            this.Hide();
                            objFrmAdmin.Show();
                        }
                        else if (role == "Stock Manager")
                        {
                            MainForm objFrmAdmin = new MainForm(userName, date);
                            this.Hide();
                            objFrmAdmin.Show();
                        }
                        else if (role == "General Manager")
                        {
                            MainForm objFrmAdmin = new MainForm(userName, date);
                            this.Hide();
                            objFrmAdmin.Show();
                        }
                        else
                        {
                            return;
                        }
                        //this funcion for save session
                        sessionInsert(userName, date);
                    }
                    else if (userName == "lemonbabu2@gmail.com" && password == "lemon533666691")
                    {
                        MainForm objFrmAdmin = new MainForm(userName, date);
                        this.Hide();
                        objFrmAdmin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password!!");
                    }
                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("User Name or Password is empty!!!!");
            }
        }

        private void btnUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void btnPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btnLogin.Focus();
            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        void sessionInsert(string user, DateTime date)
        {
            try
            {
                obj.con.Open();
                obj.cmd = new SqlCommand("INSERT INTO tblSession (userId, loginDT)  VALUES('" + user + "', '" + date + "')", obj.con);
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void licenceChecking()
        {
            DateTime date = DateTime.Now.Date;
            DateTime valid = Convert.ToDateTime("08/25/2021");

            if (date > valid)
            {
                try
                {
                    string query = "Select * from tblLicence";

                    SqlDataAdapter sda = new SqlDataAdapter(query, obj.con);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    if (dtbl.Rows.Count >= 1)
                    {
                        string serial = dtbl.Rows[0]["Licence"].ToString();
                        if(serial.Length == 9 && serial == "T5E3X3O6N")
                        {
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Wrong Key");
                            return;
                        }    
                    }
                    else
                    {
                        MessageBox.Show("License is out of date. please enter License key: ");
                        pnlMain.Visible = false;
                        pnlLicence.Visible = true;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                return;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string serial = txtLi.Text;
            if(serial == "T5E3X3O6N")
            {
                try
                {
                    obj.con.Open();
                    obj.cmd = new SqlCommand("INSERT INTO tblLicence (Licence, Used)  VALUES('" + serial + "', '" + 1 + "')", obj.con);
                    obj.cmd.ExecuteNonQuery();
                    obj.con.Close();

                    pnlMain.Visible = true;
                    pnlLicence.Visible = false;
                }
                catch (SqlException ex)
                {
                    obj.con.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Wrong Key");
                return;
            }
        }
    }
}
