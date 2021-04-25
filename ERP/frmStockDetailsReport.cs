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
    public partial class frmStockDetailsReport : Form
    {
        ConnectionString obj = new ConnectionString();
        int ctId, pId;

        public frmStockDetailsReport()
        {
            InitializeComponent();
        }

        private void frmStockDetailsReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tblStockDetailsReport' table. You can move, or remove it, as needed.
            //this.tblStockDetailsReportTableAdapter.Fill(this.appData.tblStockDetailsReport);

            pnlStockReport.Visible = true;
            pnlPrinting.Visible = false;

            btnSearch_Click(sender, e);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            String ctg = cmbProductCtg.Text.Trim().Replace("'", "''");
            String name = cmbProductName.Text.Trim().Replace("'", "''");
            String size = cmbProductSize.Text.Trim().Replace("'", "''");

            // this for single product
            if (ctg != "" && name != "" && size != "" && size != "Size")
            {
                int cId = obj.funCtgId(ctg);
                int pId = obj.funPrdId(cId, name, size);
                try
                {
                    obj.cmd = new SqlCommand(" SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStock.stock, tblStock.pPrice, tblStock.pPrice * tblStock.stock AS tpPrice, tblStock.sPrice, tblStock.sPrice * tblStock.stock AS tsPrice, tblStock.discount,  tblStock.discount * tblStock.stock AS tDisc, (tblStock.sPrice * tblStock.stock) - (tblStock.pPrice * tblStock.stock) -( tblStock.discount * tblStock.stock) as profit FROM tblStock INNER JOIN tblProducts ON tblStock.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId where tblStock.pId = '" + pId + "' ", obj.con);
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
            }
            // this for multiple product
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
                        DataTable dtl = new DataTable();
                        for (int i = 0; i < dtbl.Rows.Count; i++)
                        {
                            int id = Convert.ToInt16(dtbl.Rows[i]["pId"].ToString());
                            SqlDataAdapter adp = new SqlDataAdapter("SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStock.stock, tblStock.pPrice, tblStock.pPrice * tblStock.stock AS tpPrice, tblStock.sPrice, tblStock.sPrice * tblStock.stock AS tsPrice, tblStock.discount,  tblStock.discount * tblStock.stock AS tDisc, (tblStock.sPrice * tblStock.stock) - (tblStock.pPrice * tblStock.stock) -( tblStock.discount * tblStock.stock) as profit FROM tblStock INNER JOIN tblProducts ON tblStock.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId where tblStock.pId = '" + id + "' ", obj.con);
                            adp.Fill(dtl);
                        }
                        ReportDataSource rds = new ReportDataSource("DataSet1", dtl);
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(rds);
                        reportViewer1.RefreshReport();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // this for categories product
            else if (ctg != "" && name == "Product Name")
            {
                int cId = obj.funCtgId(ctg);
                try
                {
                    string query = "select * from tblProducts where pCtgId = '" + cId + "' ";
                    SqlDataAdapter sda = new SqlDataAdapter(query, obj.con);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    if (dtbl.Rows.Count >= 1)
                    {
                        DataTable dtl = new DataTable();
                        for (int i = 0; i < dtbl.Rows.Count; i++)
                        {
                            int id = Convert.ToInt16(dtbl.Rows[i]["pId"].ToString());
                            SqlDataAdapter adp = new SqlDataAdapter("SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStock.stock, tblStock.pPrice, tblStock.pPrice * tblStock.stock AS tpPrice, tblStock.sPrice, tblStock.sPrice * tblStock.stock AS tsPrice, tblStock.discount,  tblStock.discount * tblStock.stock AS tDisc, (tblStock.sPrice * tblStock.stock) - (tblStock.pPrice * tblStock.stock) -( tblStock.discount * tblStock.stock) as profit FROM tblStock INNER JOIN tblProducts ON tblStock.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId where tblStock.pId = '" + id + "' ", obj.con);
                            adp.Fill(dtl);
                        }
                        ReportDataSource rds = new ReportDataSource("DataSet1", dtl);
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(rds);
                        reportViewer1.RefreshReport();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // this for all product
            else
            {
                try
                {
                    obj.cmd = new SqlCommand(" SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStock.stock, tblStock.pPrice, tblStock.pPrice * tblStock.stock AS tpPrice, tblStock.sPrice, tblStock.sPrice * tblStock.stock AS tsPrice, tblStock.discount,  tblStock.discount * tblStock.stock AS tDisc, (tblStock.sPrice * tblStock.stock) - (tblStock.pPrice * tblStock.stock) -( tblStock.discount * tblStock.stock) as profit FROM tblStock INNER JOIN tblProducts ON tblStock.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId ", obj.con);
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
            }

            pnlStockReport.Visible = false;
            pnlPrinting.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String ctg = cmbProductCtg.Text.Trim().Replace("'", "''");
            String name = cmbProductName.Text.Trim().Replace("'", "''");
            String size = cmbProductSize.Text.Trim().Replace("'", "''");

            // this for single product
            if(ctg != "" && name != "" && size != "" && size != "Size")
            {
                int cId = obj.funCtgId(ctg);
                int pId = obj.funPrdId(cId, name, size);
                try
                {
                    obj.cmd = new SqlCommand(" SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStock.stock, tblStock.pPrice, tblStock.pPrice * tblStock.stock AS tpPrice, tblStock.sPrice, tblStock.sPrice * tblStock.stock AS tsPrice, tblStock.discount,  tblStock.discount * tblStock.stock AS tDisc, (tblStock.sPrice * tblStock.stock) - (tblStock.pPrice * tblStock.stock) -( tblStock.discount * tblStock.stock) as profit FROM tblStock INNER JOIN tblProducts ON tblStock.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId where tblStock.pId = '" + pId + "' ", obj.con);
                    SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewSales.DataSource = dt;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // this for multiple product
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
                        DataTable dtl = new DataTable();
                        for (int i = 0; i < dtbl.Rows.Count; i++)
                        {
                            int id = Convert.ToInt16(dtbl.Rows[i]["pId"].ToString());
                            SqlDataAdapter adp = new SqlDataAdapter("SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStock.stock, tblStock.pPrice, tblStock.pPrice * tblStock.stock AS tpPrice, tblStock.sPrice, tblStock.sPrice * tblStock.stock AS tsPrice, tblStock.discount,  tblStock.discount * tblStock.stock AS tDisc, (tblStock.sPrice * tblStock.stock) - (tblStock.pPrice * tblStock.stock) -( tblStock.discount * tblStock.stock) as profit FROM tblStock INNER JOIN tblProducts ON tblStock.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId where tblStock.pId = '" + id + "' ", obj.con);
                            adp.Fill(dtl);
                        }
                        dataGridViewSales.DataSource = dtl;

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return;
            }
            // this for categories product
            else if (ctg != "" && name == "Product Name")
            {
                int cId = obj.funCtgId(ctg);
                try
                {
                    string query = "select * from tblProducts where pCtgId = '" + cId + "' ";
                    SqlDataAdapter sda = new SqlDataAdapter(query, obj.con);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    if (dtbl.Rows.Count >= 1)
                    {
                        DataTable dtl = new DataTable();
                        for (int i = 0; i < dtbl.Rows.Count; i++)
                        {
                            int id = Convert.ToInt16(dtbl.Rows[i]["pId"].ToString());
                            SqlDataAdapter adp = new SqlDataAdapter("SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStock.stock, tblStock.pPrice, tblStock.pPrice * tblStock.stock AS tpPrice, tblStock.sPrice, tblStock.sPrice * tblStock.stock AS tsPrice, tblStock.discount,  tblStock.discount * tblStock.stock AS tDisc, (tblStock.sPrice * tblStock.stock) - (tblStock.pPrice * tblStock.stock) -( tblStock.discount * tblStock.stock) as profit FROM tblStock INNER JOIN tblProducts ON tblStock.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId where tblStock.pId = '" + id + "' ", obj.con);
                            adp.Fill(dtl);
                        }
                        dataGridViewSales.DataSource = dtl;

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return;
            }
            // this for all product
            else
            {
                try
                {
                    obj.cmd = new SqlCommand(" SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStock.stock, tblStock.pPrice, tblStock.pPrice * tblStock.stock AS tpPrice, tblStock.sPrice, tblStock.sPrice * tblStock.stock AS tsPrice, tblStock.discount,  tblStock.discount * tblStock.stock AS tDisc, (tblStock.sPrice * tblStock.stock) - (tblStock.pPrice * tblStock.stock) -( tblStock.discount * tblStock.stock) as profit FROM tblStock INNER JOIN tblProducts ON tblStock.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId ", obj.con);
                    SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewSales.DataSource = dt;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
            cmbProductSize.Text = "";
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


    }
}
