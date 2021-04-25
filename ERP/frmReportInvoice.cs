using Microsoft.Reporting.WinForms;
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
    public partial class frmReportInvoice : Form
    {
        ConnectionString obj = new ConnectionString();
        int sId;

        public frmReportInvoice()
        {
            InitializeComponent();
            pnlSaleReport.Visible = true;
            pnlPrinting.Visible = false;
        }

        private void frmReportInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AppData.tblInvoice' table. You can move, or remove it, as needed.
           // this.tblInvoiceTableAdapter.Fill(this.AppData.tblInvoice);
            // TODO: This line of code loads data into the 'AppData.tblSaleDetailsView' table. You can move, or remove it, as needed.
            //this.tblSaleDetailsViewTableAdapter.Fill(this.AppData.tblSaleDetailsView);

            try
            {
                obj.cmd = new SqlCommand(" SELECT tblSales.payMethod, tblSales.date, tblSales.totalAmnt, tblSales.saleId, tblSales.PaidAmnt, tblSales.discount, tblSales.time, tblCustomers.cstName, tblCustomers.cstPhone FROM tblSales INNER JOIN tblCustomers ON tblSales.cstId = tblCustomers.cstId ", obj.con);
                SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewInvoice.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


            obj.cmd = new SqlCommand("select cstName from tblCustomers", obj.con);
            obj.con.Open();
            SqlDataReader dr = obj.cmd.ExecuteReader();
            AutoCompleteStringCollection mycollaction = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                mycollaction.Add(dr.GetString(0));
            }
            txtSearch.AutoCompleteCustomSource = mycollaction;
            obj.con.Close();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btnSearch.Focus();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string data = txtSearch.Text.Replace("'", "''");

            if (data != "")
            {
                try
                {
                    obj.cmd = new SqlCommand(" SELECT tblSales.payMethod, tblSales.date, tblSales.totalAmnt, tblSales.saleId, tblSales.PaidAmnt, tblSales.discount, tblSales.time, tblCustomers.cstName, tblCustomers.cstPhone FROM tblSales INNER JOIN tblCustomers ON tblSales.cstId = tblCustomers.cstId where cstName like '" + data + "%' ", obj.con);
                    SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewInvoice.DataSource = dt;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                return;
            }
        }

        private void dataGridViewInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            // This condition for column clik avoiding
            i = Convert.ToInt16(e.RowIndex.ToString());
            if (i < 0)
                return;

            if (e.ColumnIndex == 6)
            {

                DialogResult result = MessageBox.Show("Do you want to Print sales invoice?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string name = dataGridViewInvoice.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string phone = dataGridViewInvoice.Rows[e.RowIndex].Cells[2].Value.ToString();
                    pnlSaleReport.Visible = false;
                    pnlPrinting.Visible = true;

                    try
                    {
                        sId = Convert.ToInt16(dataGridViewInvoice.Rows[e.RowIndex].Cells[0].Value.ToString());

                        obj.cmd = new SqlCommand("SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblSalesProducts.saleUnitPrice, tblSalesProducts.quantity, tblSalesProducts.discount, tblSalesProducts.subTotal, tblSalesProducts.saleId FROM tblSalesProducts INNER JOIN tblProducts ON tblSalesProducts.pdctId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId Where tblSalesProducts.saleId = '" + sId + "' ", obj.con);
                        SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(rds);
                        reportViewer1.RefreshReport();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    try
                    {
                        obj.cmd = new SqlCommand("SELECT * FROM tblSales Where saleId = '" + sId + "' ", obj.con);
                        SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        ReportDataSource rds = new ReportDataSource("DataSet2", dt);
                        reportViewer1.LocalReport.DataSources.Add(rds);
                        reportViewer1.RefreshReport();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    try
                    {
                        obj.cmd = new SqlCommand("SELECT * FROM tblCustomers Where cstName = '" + name + "' and cstPhone = '" + phone + "' ", obj.con);
                        SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        ReportDataSource rds = new ReportDataSource("DataSet3", dt);
                        reportViewer1.LocalReport.DataSources.Add(rds);
                        reportViewer1.RefreshReport();
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


    }
}
