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
    public partial class MainForm : Form
    {
        ConnectionString obj = new ConnectionString();
        string userName, role;
        DateTime dateTime;

        public MainForm()
        {
            InitializeComponent();
            toolTip.SetToolTip(btnMainFormResize, "Maximize");
            customDesign();
        }

        public MainForm(string user, DateTime dateTime)
        {
            InitializeComponent();
            toolTip.SetToolTip(btnMainFormResize, "Maximize");
            customDesign();
            this.userName = user;
            this.dateTime = dateTime;
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContainCenter.Controls.Add(childForm);
            pnlContainCenter.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnMainFormClose_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Hi " + userName + ",\nAre you sure to exit ?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (confirm == DialogResult.No)
            {
                return;
            }
        }

        private void btnMainFormResize_Click(object sender, EventArgs e)
        {
            
            
            if(FormWindowState.Normal == this.WindowState)
            {
                this.WindowState = FormWindowState.Maximized;
                toolTip.SetToolTip(btnMainFormResize, "Restore Down");
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                toolTip.SetToolTip(btnMainFormResize, "Maximize");
            }
                

        }

        private void btnMainFormMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            
        }


        private void customDesign()
        {
            pnlProductsMenu.Visible = false;
            pnlReportMenu.Visible = false;
            pnlAccountMenu.Visible = false;
            pnlManageUserMenu.Visible = false;
            pnlStocksMenu.Visible = false;
            pnlSalesMenu.Visible = false;
            pnlProfile.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnlProductsMenu.Visible == true)
                pnlProductsMenu.Visible = false;

            if (pnlStocksMenu.Visible == true)
                pnlStocksMenu.Visible = false;

            if (pnlReportMenu.Visible == true)
                pnlReportMenu.Visible = false;

            if (pnlAccountMenu.Visible == true)
                pnlAccountMenu.Visible = false;

            if (pnlManageUserMenu.Visible == true)
                pnlManageUserMenu.Visible = false;

            if (pnlSalesMenu.Visible == true)
                pnlSalesMenu.Visible = false;

            if (pnlProfile.Visible == true)
                pnlProfile.Visible = false;

        }

        private void ShowSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btnMenuDashboard_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildFormInPanel(new frmDeshboard());
        }

        private void btnMenuProduct_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnlProductsMenu);
        }

        private void btnMenuStocks_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnlStocksMenu);
        }

        private void btnMenuReport_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnlReportMenu);
        }

        private void btnMenuAccounts_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnlAccountMenu);
        }

        private void btnMenuManageUser_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnlManageUserMenu);
        }

        private void btnMenuAddNewProduct_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmAddNewProduct());
        }

        private void btnCtg_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmCategories());
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmViewProducts());
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmEditProducts());
        }

        private void btnAddStockMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmAddStocks(userName));
        }

        private void btnStockEditMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmEditStocks());
        }

        private void btnViewStockHistoryMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmViewStockHistorys());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmBarcodeGenerate());
        }

        private void btnSalesMenu_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnlSalesMenu);
        }

        private void btnNewSaleMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmNewSale(userName));
        }

        private void btnSalesViewMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmViewSales());
        }


        private void btnSalesAccountMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmSalesAccount());
        }

        private void btnCustomersMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmViewCustomers());
        }
        private void btnDuePaymentMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmDuePayment());
        }

        private void btnHistoryDuePay_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmViewDuePayHistory());
        }

        private void btnLowStockMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmLowStock());
        }

        private void btnStockViewMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmViewStock());
        }

        private void btnDefectProduct_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmDefectProduct());
        }

        private void btnSalesReportMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmReportSales());
        }

        private void btnStockReportMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmReportStocks());
        }

        private void btnDefectReportMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmReportDefectProduct());
        }

        private void btnCustomerReportMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmReportCustomer());
        }

        private void btnOverallReportMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmReportOverallAccount());
        }

        private void btnPrintInvoiceMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmReportInvoice());
        }

        private void btnUsersMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new adminUserManagement());
        }

        private void btnSessionHistoryMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new adminSessionHistory());
        }

        private void btnSalesActivityMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new adminSalesActivity());
        }

        private void btnStockActivityMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new adminStockActivity());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            DateTime date = DateTime.Now;
            try
            {
                obj.con.Open();
                obj.cmd = new SqlCommand("UPDATE tblSession SET logoutDT = '" + date + "' WHERE userId = '" + userName + "' and loginDT = '" + dateTime + "'", obj.con);
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //lblUserName.Text = userName;
            pnlProfile.Visible = false;
            accessUser(userName);
            lblUserName.Text = userName;


            /*
            try { 
            SqlDataAdapter sd = new SqlDataAdapter("SELECT * FROM tblUser where userName = '" + userName + "' ", obj.con);
            DataTable dtl = new DataTable();
            sd.Fill(dtl);
                if (dtl.Rows.Count < 1)
                {
                    return;
                }
                else
                {

                    if (dtl.Rows[0]["fullName"].ToString() == "")
                    {
                        lblUserName.Text = dtl.Rows[0]["userName"].ToString();
                    }
                    else
                    {
                        lblUserName.Text = dtl.Rows[0]["fullName"].ToString();
                       /* string ss = dtl.Rows[0]["pic"].ToString();
                        if (ss == "")
                            pitureBoxProfilePic.Image = null;
                        else
                        {
                            MemoryStream ms = new MemoryStream();
                            byte[] images = (byte[])dtl.Rows[0]["pic"];
                            ms.Write(images, 0, images.Length);
                            pitureBoxProfilePic.Image = new Bitmap(ms);
                        }
        }
                }
                
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
                    */
            /*
             obj.con.Open();
             string qu = "SELECT fullName, pic FROM tblUser where userName = '" + userName + "'";
             obj.cmd = new SqlCommand(qu, obj.con);
             SqlDataReader dataReader = obj.cmd.ExecuteReader();
             dataReader.Read();

             if (dataReader.HasRows)
             {
                 lblUserName.Text = dataReader[0].ToString();
                 if (dataReader[1].ToString() == "")
                 {
                     pitureBoxProfilePic.Image = null;
                 }
                 else
                 {
                     byte[] image = (byte[])dataReader[1];
                     MemoryStream ms = new MemoryStream(image);
                     pitureBoxProfilePic.Image = Image.FromStream(ms);
                 }
             }
             obj.con.Close();
              */
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = true;
            lblWelcome.Visible = false;
            if (activeForm != null)
                activeForm.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            try
            {
                obj.con.Open();
                obj.cmd = new SqlCommand("UPDATE tblSession SET logoutDT = '" + date + "' WHERE userId = '" + userName + "' and loginDT = '" + dateTime + "'", obj.con);
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            frmLogin objFrmAdmin = new frmLogin();
            this.Hide();
            objFrmAdmin.Show();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new userProfile(userName));
        }

        private void btnDiscountReportMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmReportDiscount());
        }

        private void btnSetOfferMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new adminSetOffer());
        }

        private void btnStocksMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmStockAccount());
        }

        private void btnOverAllAccountsMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmOverallAccount());
        }

        private void btnExpensesMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmExpense(userName));
        }

        private void btnDepositMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmSalerDeposit(userName));
        }

        private void btnReportDepositMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmReportDeposit());
        }

        private void btnProductPrice_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmPricesView());
        }


        private void btnMenuHelp_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildFormInPanel(new Help());
        }

        private void btnSalesDetailsReportMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmSalesDetailsReport());
        }

        private void btnClearDataMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmClearHistory());
        }

        private void btnStockDetailsReportMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmStockDetailsReport());
        }

        void accessUser(string name)
        {
            try
            {
                string query = "Select * from tblUser Where UserName = '" + userName + "' ";

                SqlDataAdapter sda = new SqlDataAdapter(query, obj.con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count >= 1)
                {
                    role = dtbl.Rows[0]["permission"].ToString();

                    if (role == "Admin")
                    {
                        return;
                    }
                    else if (role == "Sales Manager")
                    {
                        btnMenuManageUser.Visible = false;
                        pnlManageUserMenu.Visible = false;
                        pnlStocksMenu.Visible = false;
                        btnMenuStocks.Visible = false;
                        pnlProductsMenu.Visible = false;
                        btnMenuProduct.Visible = false;
                        btnStockReportMenu.Visible = false;
                        btnStocksAccountsMenu.Visible = false;
                        btnOverAllAccountsMenu.Visible = false;
                    }
                    else if (role == "Stock Manager")
                    {
                        btnMenuManageUser.Visible = false;
                        pnlManageUserMenu.Visible = false;
                        pnlSalesMenu.Visible = false;
                        btnMenuSales.Visible = false;
                    }
                    else if (role == "General Manager")
                    {
                        btnMenuManageUser.Visible = false;
                        pnlManageUserMenu.Visible = false;
                    }
                    else
                    {
                        return;
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
