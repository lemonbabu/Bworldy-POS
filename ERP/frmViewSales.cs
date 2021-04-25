using Code4Bugs.SimpleDataGridViewPaging;
using ERP.AppDataTableAdapters;
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
    public partial class frmViewSales : Form
    {
        ConnectionString obj = new ConnectionString();
        int sId;
        public frmViewSales()
        {
            InitializeComponent();
        }


        private void frmViewSales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData1.tblSaleDetailsView' table. You can move, or remove it, as needed.
            //this.tblSaleDetailsViewTableAdapter.Fill(this.appData1.tblSaleDetailsView);
            // TODO: This line of code loads data into the 'appData1.tblSalesView' table. You can move, or remove it, as needed.
            //this.tblSalesViewTableAdapter.Fill(this.appData1.tblSalesView);
            
            tblLayPnlSaleView.Visible = true;
            tblLayPnlSaleDetails.Visible = false;

            DateTime date = DateTime.Now.Date;
            dateTimePickerStart.Value = date;
            dateTimePickerEnd.Value = date;

            btnSearch_Click( sender, e);

            /*
            try
            {
                obj.con.Open();
                obj.cmd = new SqlCommand(" SELECT tblSales.date, tblSales.time, tblSales.SaleId, tblCustomers.cstName, tblCustomers.cstPhone, tblSales.totalAmnt, tblSales.discount, tblSales.overallDiscount, tblSales.payMethod, tblSales.PaidAmnt FROM tblSales INNER JOIN tblCustomers ON tblSales.cstId = tblCustomers.cstId ", obj.con);
                SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewSales.DataSource = dt;
                //dataGridViewPaging1.DataSource = dt;
                //dataGridViewPaging1.DbRequestHandler = DbRequestHandlerHelper.Create( obj.con, "tblSales");

                obj.con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            
            try
            {
                obj.con.Open();
                obj.cmd = new SqlCommand(" SELECT tblSales.date, tblSales.time, tblSales.SaleId, tblCustomers.cstName, tblCustomers.cstPhone, tblSales.totalAmnt, tblSales.discount, tblSales.payMethod, tblSales.PaidAmnt FROM tblSales INNER JOIN tblCustomers ON tblSales.cstId = tblCustomers.cstId ", obj.con);
                SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewSales.DataSource = dt;
                obj.con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            */

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string date1 = dateTimePickerStart.Value.ToString("MM/dd/yyyy");
            string date2 = dateTimePickerEnd.Value.ToString("MM/dd/yyyy");

            if (date1 != "" && date2 != "")
            {
                try
                {
                    obj.cmd = new SqlCommand(" SELECT tblSales.date, tblSales.time, tblSales.saleId, tblCustomers.cstName, tblCustomers.cstPhone, tblSales.totalAmnt, tblSales.discount,  tblSales.overallDiscount, tblSales.payMethod, tblSales.PaidAmnt FROM tblSales INNER JOIN tblCustomers ON tblSales.cstId = tblCustomers.cstId Where tblSales.date >= '" + date1 + "' and tblSales.date <= '" + date2 + "' ", obj.con);
                    SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewSales.DataSource = dt;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // total calculations
                try
                {
                    obj.cmd = new SqlCommand(" SELECT  SUM(tblSales.totalAmnt) as amnt, SUM(tblSales.discount) as disc,  SUM(tblSales.overallDiscount) as ovDis, SUM(tblSales.PaidAmnt) as paid FROM tblSales INNER JOIN tblCustomers ON tblSales.cstId = tblCustomers.cstId Where tblSales.date >= '" + date1 + "' and tblSales.date <= '" + date2 + "' ", obj.con);
                    SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count < 1)
                    {
                       // lblCount.Text = "0";
                        lblTotalAmnt.Text = "0";
                        lblTotalDisc.Text = "0";
                        lblTotalExtDisc.Text = "0";
                        lblTotalPaid.Text = "0";
                    }
                    else
                    {
                       // lblCount.Text = dt.Rows[0]["cunt"].ToString();
                        lblTotalAmnt.Text = dt.Rows[0]["amnt"].ToString();
                        lblTotalDisc.Text = dt.Rows[0]["disc"].ToString();
                        lblTotalExtDisc.Text = dt.Rows[0]["ovDis"].ToString();
                        lblTotalPaid.Text = dt.Rows[0]["paid"].ToString();
                    }
                        
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please select date first", "Error");
                return;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            tblLayPnlSaleDetails.Visible = false;
            tblLayPnlSaleView.Visible = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i,  pId;
            String total, name, phone;
            // This condition for column clik avoiding
            i = Convert.ToInt16(e.RowIndex.ToString());
            if (i < 0)
                return;

            if (e.ColumnIndex >= 0)
            {

                DialogResult result = MessageBox.Show("Do you want to view this sale details?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        sId = Convert.ToInt16(dataGridViewSales.Rows[e.RowIndex].Cells[0].Value.ToString());
                        lblNameSalesView.Text = dataGridViewSales.Rows[e.RowIndex].Cells[1].Value.ToString();
                        lblPhoneSaleView.Text = dataGridViewSales.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtTotalAmount.Text = dataGridViewSales.Rows[e.RowIndex].Cells[3].Value.ToString();


                        obj.cmd = new SqlCommand(" SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblSalesProducts.saleUnitPrice, tblSalesProducts.quantity, tblSalesProducts.discount, tblSalesProducts.subTotal FROM tblSalesProducts FULL OUTER JOIN tblProducts ON tblSalesProducts.pdctId =  tblProducts.pId JOIN tblCategories ON tblCategories.ctgId = tblProducts.pCtgId Where tblSalesProducts.saleId = '" + sId + "' ", obj.con);
                        SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                       // pId = Convert.ToInt16(dt.Rows[0]["pdctId"].ToString());
                        
                        dataGridViewSalesDetails.DataSource = dt;
                        //txtDuePay.Focus();
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
            tblLayPnlSaleDetails.Visible = true;
            tblLayPnlSaleView.Visible = false;
        }


    }
}
