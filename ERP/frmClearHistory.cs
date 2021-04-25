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
    public partial class frmClearHistory : Form
    {
        string flg = "0", userName;
        ConnectionString obj = new ConnectionString();
        public frmClearHistory()
        {
            InitializeComponent();
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            checkPassword();
            flg = "stock";
        }

        private void btnDeleteSales_Click(object sender, EventArgs e)
        {
            checkPassword();
            flg = "sale";
        }

        private void btnDeleteSession_Click(object sender, EventArgs e)
        {
            checkPassword();
            flg = "session";
        }

        private void btnDeleteActivitys_Click(object sender, EventArgs e)
        {
            checkPassword();
            flg = "acctiviy";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string pass = txtPassword.Text;
            if (pass == "")
                return;

            DialogResult confirm = MessageBox.Show("This is permanent deletion process. \nAre you confirm to delete ?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No)
            {
                return;
            }


            try
            {
                string query = "Select * from tblUser Where password = '" + pass + "' and permission = '"+ "Admin" +"' ";

                SqlDataAdapter sda = new SqlDataAdapter(query, obj.con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count >= 1)
                {
                    if (flg == "stock")
                    {
                        try
                        {
                            obj.con.Open();
                            obj.cmd = new SqlCommand("DELETE FROM tblStock", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("DELETE FROM tblStockHistory", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("DELETE FROM tblDeposit", obj.con);
                            obj.cmd.ExecuteNonQuery();
                            obj.con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("SQL error" + ex);
                        }
                    }
                    else if (flg == "sale")
                    {
                        try
                        {
                            obj.con.Open();
                            obj.cmd = new SqlCommand("DELETE FROM tblSales", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("DELETE FROM tblSalesProducts", obj.con);
                            obj.cmd.ExecuteNonQuery();
                            obj.con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("SQL error" + ex);
                        }
                    }
                    else if (flg == "session")
                    {
                        try
                        {
                            obj.con.Open();
                            obj.cmd = new SqlCommand("DELETE FROM tblSession", obj.con);
                            obj.cmd.ExecuteNonQuery();
                            obj.con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("SQL error" + ex);
                        }
                    }
                    else if (flg == "acctiviy")
                    {
                        try
                        {
                            obj.con.Open();
                            obj.cmd = new SqlCommand("DELETE FROM tblActivity", obj.con);
                            obj.cmd.ExecuteNonQuery();
                            obj.con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("SQL error" + ex);
                        }
                    }
                    else if (flg == "all")
                    {
                        try
                        {
                            obj.con.Open();
                            obj.cmd = new SqlCommand("DELETE FROM tblActivity", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("DELETE FROM tblBarcode", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("DELETE FROM tblCategories", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("DELETE FROM tblCustomers", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("DELETE FROM tblDefectProduct", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("DELETE FROM tblDeposit", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("DELETE FROM tblDuePaymentHistory", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("DELETE FROM tblExpense", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("DELETE FROM tblOffer", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("DELETE FROM tblPaymentHistory", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("DELETE FROM tblProducts", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("DELETE FROM tblReturn", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("DELETE FROM tblSales", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("DELETE FROM tblSalesProducts", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("DELETE FROM tblSession", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("DELETE FROM tblStock", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("DELETE FROM tblStockHistory", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("DELETE FROM tblTempSale", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("SQL error" + ex);
                        }
                    }
                    else
                    {
                        return;
                    }
                    MessageBox.Show("Delete sucessfully. Now close this application.");
                    Application.Exit();

                }
                else
                {
                    MessageBox.Show("Wrong Password", "Alart");
                    return;
                }

            }
            catch (SqlException ex)
            {
                obj.con.Close();
                MessageBox.Show(ex.Message);
            }



        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            checkPassword();
            flg = "all";
        }

        void checkPassword()
        {
            pnlClearHistoryMain.Visible = false;
            pnlConfirmationPassword.Visible = true;
            txtPassword.Focus();
        }




    }
}
