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
    public partial class frmSalesDetailsReport : Form
    {
        ConnectionString obj = new ConnectionString();
        int ctId, pId, flag;

        public frmSalesDetailsReport()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string date1 = dateTimePickerStart.Value.ToString("MM/dd/yyyy");
            string date2 = dateTimePickerEnd.Value.ToString("MM/dd/yyyy");

            String ctg = cmbProductCtg.Text.Trim().Replace("'", "''");
            String name = cmbProductName.Text.Trim().Replace("'", "''");
            String size = cmbProductSize.Text.Trim().Replace("'", "''");

            if (ctg != "" && name != "" && size != "" && size != "Size")
            {
                int cId = obj.funCtgId(ctg);
                int pId = obj.funPrdId(cId, name, size);

                DataTable dtl = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT tblSalesProducts.saleUnitPrice, tblSalesProducts.pdctId, tblSalesProducts.quantity, tblSalesProducts.discount, tblSalesProducts.subTotal, tblStockHistory.pPrice, tblProducts.pName, tblProducts.pSize, tblCategories.ctgName, tblSales.saleId FROM tblSales INNER JOIN tblSalesProducts ON tblSales.saleId = tblSalesProducts.saleId INNER JOIN tblStockHistory ON tblSalesProducts.pdctId = tblStockHistory.pId AND tblSalesProducts.saleUnitPrice = tblStockHistory.sPrice INNER JOIN tblProducts ON tblStockHistory.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId Where tblSales.date >= '" + date1 + "' and tblSales.date <= '" + date2 + "' and tblSalesProducts.pdctId = '" + pId + "'", obj.con);
                adp.Fill(dtl);
                dataGridViewSales.DataSource = dtl;

                return;
            }
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
                        double qun = 0, pPrice = 0, sPrice = 0;
                        for (int i = 0; i < dtbl.Rows.Count; i++)
                        {

                            int id = Convert.ToInt16(dtbl.Rows[i]["pId"].ToString());
                            SqlDataAdapter adp = new SqlDataAdapter("SELECT tblSalesProducts.saleUnitPrice, tblSalesProducts.pdctId, tblSalesProducts.quantity, tblSalesProducts.discount, tblSalesProducts.subTotal, tblStockHistory.pPrice, tblProducts.pName, tblProducts.pSize, tblCategories.ctgName, tblSales.saleId FROM tblSales INNER JOIN tblSalesProducts ON tblSales.saleId = tblSalesProducts.saleId INNER JOIN tblStockHistory ON tblSalesProducts.pdctId = tblStockHistory.pId AND tblSalesProducts.saleUnitPrice = tblStockHistory.sPrice INNER JOIN tblProducts ON tblStockHistory.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId Where tblSales.date >= '" + date1 + "' and tblSales.date <= '" + date2 + "' and tblSalesProducts.pdctId = '" + id + "' ", obj.con);
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
                        double qun = 0, pPrice = 0, sPrice = 0;
                        for (int i = 0; i < dtbl.Rows.Count; i++)
                        {
                            int id = Convert.ToInt16(dtbl.Rows[i]["pId"].ToString());
                            SqlDataAdapter adp = new SqlDataAdapter("SELECT tblSalesProducts.saleUnitPrice, tblSalesProducts.pdctId, tblSalesProducts.quantity, tblSalesProducts.discount, tblSalesProducts.subTotal, tblStockHistory.pPrice, tblProducts.pName, tblProducts.pSize, tblCategories.ctgName, tblSales.saleId FROM tblSales INNER JOIN tblSalesProducts ON tblSales.saleId = tblSalesProducts.saleId INNER JOIN tblStockHistory ON tblSalesProducts.pdctId = tblStockHistory.pId AND tblSalesProducts.saleUnitPrice = tblStockHistory.sPrice INNER JOIN tblProducts ON tblStockHistory.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId Where tblSales.date >= '" + date1 + "' and tblSales.date <= '" + date2 + "' and tblSalesProducts.pdctId = '" + id + "' ", obj.con);
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

            else
            {
                try
                {
                    obj.cmd = new SqlCommand("SELECT tblSalesProducts.saleUnitPrice, tblSalesProducts.pdctId, tblSalesProducts.quantity, tblSalesProducts.discount, tblSalesProducts.subTotal, tblStockHistory.pPrice, tblProducts.pName, tblProducts.pSize, tblCategories.ctgName, tblSales.saleId FROM tblSales INNER JOIN tblSalesProducts ON tblSales.saleId = tblSalesProducts.saleId INNER JOIN tblStockHistory ON tblSalesProducts.pdctId = tblStockHistory.pId AND tblSalesProducts.saleUnitPrice = tblStockHistory.sPrice INNER JOIN tblProducts ON tblStockHistory.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId Where tblSales.date >= '" + date1 + "' and tblSales.date <= '" + date2 + "' ", obj.con);
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

        private void frmSalesDetailsReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tblSaleProductViewReport' table. You can move, or remove it, as needed.
            //this.tblSaleProductViewReportTableAdapter.Fill(this.appData.tblSaleProductViewReport);
            // TODO: This line of code loads data into the 'mainDataSet.tblSales' table. You can move, or remove it, as needed.
           // this.tblSalesTableAdapter.Fill(this.mainDataSet.tblSales);
            // TODO: This line of code loads data into the 'appData.tblSaleProductViewReport' table. You can move, or remove it, as needed.
            ////this.tblSaleProductViewReportTableAdapter.Fill(this.appData.tblSaleProductViewReport);
            // TODO: This line of code loads data into the 'mainDataSet.tblSales' table. You can move, or remove it, as needed.
            //this.tblSalesTableAdapter.Fill(this.mainDataSet.tblSales);
            // TODO: This line of code loads data into the 'appData.tblSaleProductViewReport' table. You can move, or remove it, as needed.
            //
            //this.tblSaleProductViewReportTableAdapter.Fill(this.appData.tblSaleProductViewReport);

            pnlSaleReport.Visible = true;
            pnlPrinting.Visible = false;
            pnlPrint2.Visible = false;

            DateTime date = DateTime.Now.Date;
            dateTimePickerStart.Value = date;
            dateTimePickerEnd.Value = date;
            btnSearch_Click(sender, e);

        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            string date1 = dateTimePickerStart.Value.ToString("MM/dd/yyyy");
            string date2 = dateTimePickerEnd.Value.ToString("MM/dd/yyyy");

            String ctg = cmbProductCtg.Text.Trim().Replace("'", "''");
            String name = cmbProductName.Text.Trim().Replace("'", "''");
            String size = cmbProductSize.Text.Trim().Replace("'", "''");

            if (ctg != "" && name != "" && size != "" && size != "Size")
            {
                int cId = obj.funCtgId(ctg);
                int pId = obj.funPrdId(cId, name, size);

                DataTable dtl = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT tblSalesProducts.saleUnitPrice, tblSalesProducts.pdctId, tblSalesProducts.quantity, tblSalesProducts.discount, tblSalesProducts.subTotal, tblStockHistory.pPrice, tblProducts.pName, tblProducts.pSize, tblCategories.ctgName, tblSales.saleId FROM tblSales INNER JOIN tblSalesProducts ON tblSales.saleId = tblSalesProducts.saleId INNER JOIN tblStockHistory ON tblSalesProducts.pdctId = tblStockHistory.pId AND tblSalesProducts.saleUnitPrice = tblStockHistory.sPrice INNER JOIN tblProducts ON tblStockHistory.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId Where tblSales.date >= '" + date1 + "' and tblSales.date <= '" + date2 + "' and tblSalesProducts.pdctId = '" + pId + "'", obj.con);
                adp.Fill(dtl);
                ReportDataSource rds = new ReportDataSource("DataSet1", dtl);
                reportViewer2.LocalReport.DataSources.Clear();
                reportViewer2.LocalReport.DataSources.Add(rds);
                reportViewer2.RefreshReport();

                pnlSaleReport.Visible = false;
                pnlPrinting.Visible = false;
                pnlPrint2.Visible = true;

                obj.cmd = new SqlCommand(" SELECT * FROM tblSales Where date >= '" + date1 + "' and date <= '" + date2 + "' ", obj.con);
                SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                rds = new ReportDataSource("DataSet2", dt);
                reportViewer2.LocalReport.DataSources.Add(rds);
                reportViewer2.RefreshReport();
                return;

            }

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
                            SqlDataAdapter adp = new SqlDataAdapter("SELECT tblSalesProducts.saleUnitPrice, tblSalesProducts.pdctId, tblSalesProducts.quantity, tblSalesProducts.discount, tblSalesProducts.subTotal, tblStockHistory.pPrice, tblProducts.pName, tblProducts.pSize, tblCategories.ctgName, tblSales.saleId FROM tblSales INNER JOIN tblSalesProducts ON tblSales.saleId = tblSalesProducts.saleId INNER JOIN tblStockHistory ON tblSalesProducts.pdctId = tblStockHistory.pId AND tblSalesProducts.saleUnitPrice = tblStockHistory.sPrice INNER JOIN tblProducts ON tblStockHistory.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId Where tblSales.date >= '" + date1 + "' and tblSales.date <= '" + date2 + "' and tblSalesProducts.pdctId = '" + id + "' ", obj.con);
                            adp.Fill(dtl);
                        }
                        ReportDataSource rds = new ReportDataSource("DataSet1", dtl);
                        reportViewer2.LocalReport.DataSources.Clear();
                        reportViewer2.LocalReport.DataSources.Add(rds);
                        reportViewer2.RefreshReport();

                        pnlSaleReport.Visible = false;
                        pnlPrinting.Visible = false;
                        pnlPrint2.Visible = true;

                        obj.cmd = new SqlCommand(" SELECT * FROM tblSales Where date >= '" + date1 + "' and date <= '" + date2 + "' ", obj.con);
                        sda = new SqlDataAdapter(obj.cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        rds = new ReportDataSource("DataSet2", dt);
                        reportViewer2.LocalReport.DataSources.Add(rds);
                        reportViewer2.RefreshReport();
                        return;

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
                            SqlDataAdapter adp = new SqlDataAdapter("SELECT tblSalesProducts.saleUnitPrice, tblSalesProducts.pdctId, tblSalesProducts.quantity, tblSalesProducts.discount, tblSalesProducts.subTotal, tblStockHistory.pPrice, tblProducts.pName, tblProducts.pSize, tblCategories.ctgName, tblSales.saleId FROM tblSales INNER JOIN tblSalesProducts ON tblSales.saleId = tblSalesProducts.saleId INNER JOIN tblStockHistory ON tblSalesProducts.pdctId = tblStockHistory.pId AND tblSalesProducts.saleUnitPrice = tblStockHistory.sPrice INNER JOIN tblProducts ON tblStockHistory.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId Where tblSales.date >= '" + date1 + "' and tblSales.date <= '" + date2 + "' and tblSalesProducts.pdctId = '" + id + "' ", obj.con);
                            adp.Fill(dtl);
                        }
                        ReportDataSource rds = new ReportDataSource("DataSet1", dtl);
                        reportViewer2.LocalReport.DataSources.Clear();
                        reportViewer2.LocalReport.DataSources.Add(rds);
                        reportViewer2.RefreshReport();

                        pnlSaleReport.Visible = false;
                        pnlPrinting.Visible = false;
                        pnlPrint2.Visible = true;

                        obj.cmd = new SqlCommand(" SELECT * FROM tblSales Where date >= '" + date1 + "' and date <= '" + date2 + "' ", obj.con);
                        sda = new SqlDataAdapter(obj.cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        rds = new ReportDataSource("DataSet2", dt);
                        reportViewer2.LocalReport.DataSources.Add(rds);
                        reportViewer2.RefreshReport();

                        return;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                try
                {
                    obj.cmd = new SqlCommand("SELECT tblSalesProducts.saleUnitPrice, tblSalesProducts.pdctId, tblSalesProducts.quantity, tblSalesProducts.discount, tblSalesProducts.subTotal, tblStockHistory.pPrice, tblProducts.pName, tblProducts.pSize, tblCategories.ctgName, tblSales.saleId FROM tblSales INNER JOIN tblSalesProducts ON tblSales.saleId = tblSalesProducts.saleId INNER JOIN tblStockHistory ON tblSalesProducts.pdctId = tblStockHistory.pId AND tblSalesProducts.saleUnitPrice = tblStockHistory.sPrice INNER JOIN tblProducts ON tblStockHistory.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId Where tblSales.date >= '" + date1 + "' and tblSales.date <= '" + date2 + "' ", obj.con);
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
                    obj.cmd = new SqlCommand(" SELECT * FROM tblSales Where date >= '" + date1 + "' and date <= '" + date2 + "' ", obj.con);
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


            }

            pnlSaleReport.Visible = false;
            pnlPrinting.Visible = true;
            pnlPrint2.Visible = false;
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
