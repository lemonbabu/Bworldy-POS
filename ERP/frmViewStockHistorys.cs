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
    public partial class frmViewStockHistorys : Form
    {
        ConnectionString obj = new ConnectionString();
        int ctId, pId, flag;

        public frmViewStockHistorys()
        {
            InitializeComponent();

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


        private void btnSearch_Click(object sender, EventArgs e)
        {
            flag = 0;
            gridViewRefash();
        }

        private void btnReloadView_Click(object sender, EventArgs e)
        {
            flag = 1;
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter(" SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStockHistory.quantity, tblStockHistory.pPrice,  tblStockHistory.quantity * tblStockHistory.pPrice AS subTotalPPrice, tblStockHistory.sPrice,  tblStockHistory.quantity * tblStockHistory.sPrice AS subTotalSPrice, tblStockHistory.authUser, tblStockHistory.date FROM tblStockHistory INNER JOIN tblProducts ON tblStockHistory.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId ", obj.con);
            adpt.Fill(dt);
            dataGridViewStockHistory.DataSource = dt;

            DataTable dtbl = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("select SUM(quantity) as qun, SUM(pPrice * quantity) as pPrice, SUM(sPrice * quantity) as sPrice from tblStockHistory", obj.con);
            adp.Fill(dtbl);
            if (dtbl.Rows.Count < 1)
            {
                lblTotalQnt.Text = "0";
                lblTotalPurchasePrice.Text = "0";
                lblTotalSalePrice.Text = "0";
            }
            else
            {
                lblTotalQnt.Text = dtbl.Rows[0]["qun"].ToString();
                lblTotalPurchasePrice.Text = dtbl.Rows[0]["pPrice"].ToString();
                lblTotalSalePrice.Text = dtbl.Rows[0]["sPrice"].ToString();
            }

        }

        /*
        //Delete 1 item from graidview in the tbleNewSells
        void deleteItem(BindingSource a, int i)
        {
            obj.cmd = new SqlCommand("DELETE FROM tblStockHistory WHERE sHId = '" + i + "' ", obj.con);
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
        */
        private void frmViewStockHistorys_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.viewStockHistory' table. You can move, or remove it, as needed.
            //this.viewStockHistoryTableAdapter.Fill(this.appData.viewStockHistory);
            // TODO: This line of code loads data into the 'appData.viewStockHistory' table. You can move, or remove it, as needed.
            // this.viewStockHistoryTableAdapter.Fill(this.appData.viewStockHistory);
            // TODO: This line of code loads data into the 'mainDataSet.tblStockHistory' table. You can move, or remove it, as needed.
            //this.tblStockHistoryTableAdapter.Fill(this.mainDataSet.tblStockHistory);

            tblLyPnlViewStockHistory.Visible = true;
            pnlPrinting.Visible = false;

            DateTime date = DateTime.Now.Date;
            dateTimePickerStart.Value = date;
            dateTimePickerEnd.Value = date;
            btnReloadView_Click(sender, e);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adpt = new SqlDataAdapter(" SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStockHistory.quantity, tblStockHistory.pPrice,  tblStockHistory.quantity * tblStockHistory.pPrice AS subTotalPPrice, tblStockHistory.sPrice,  tblStockHistory.quantity * tblStockHistory.sPrice AS subTotalSPrice, tblStockHistory.authUser, tblStockHistory.date FROM tblStockHistory INNER JOIN tblProducts ON tblStockHistory.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId ", obj.con);
                adpt.Fill(dt);
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();

                tblLyPnlViewStockHistory.Visible = false;
                pnlPrinting.Visible = true;
                flag = 0;
                return;
            }

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
                SqlDataAdapter adp = new SqlDataAdapter("SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStockHistory.quantity, tblStockHistory.pPrice,  tblStockHistory.quantity * tblStockHistory.pPrice AS subTotalPPrice, tblStockHistory.sPrice,  tblStockHistory.quantity * tblStockHistory.sPrice AS subTotalSPrice, tblStockHistory.authUser, tblStockHistory.date FROM tblStockHistory INNER JOIN tblProducts ON tblStockHistory.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId where tblStockHistory.pId = '" + pId + "' and tblStockHistory.dt >= '" + date1 + "' and tblStockHistory.dt <= '" + date2 + "' ", obj.con);
                adp.Fill(dtl);
                ReportDataSource rds = new ReportDataSource("DataSet1", dtl);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
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
                            SqlDataAdapter adp = new SqlDataAdapter("SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStockHistory.quantity, tblStockHistory.pPrice,  tblStockHistory.quantity * tblStockHistory.pPrice AS subTotalPPrice, tblStockHistory.sPrice,  tblStockHistory.quantity * tblStockHistory.sPrice AS subTotalSPrice, tblStockHistory.authUser, tblStockHistory.date FROM tblStockHistory INNER JOIN tblProducts ON tblStockHistory.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId where tblStockHistory.pId = '" + id + "' and tblStockHistory.dt >= '" + date1 + "' and tblStockHistory.dt <= '" + date2 + "' ", obj.con);
                            adp.Fill(dtl);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
                        }
                        ReportDataSource rds = new ReportDataSource("DataSet1", dtl);
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(rds);
                        reportViewer1.RefreshReport();
                    }
                    else
                    {

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
                            SqlDataAdapter adp = new SqlDataAdapter("SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStockHistory.quantity, tblStockHistory.pPrice,  tblStockHistory.quantity * tblStockHistory.pPrice AS subTotalPPrice, tblStockHistory.sPrice,  tblStockHistory.quantity * tblStockHistory.sPrice AS subTotalSPrice, tblStockHistory.authUser, tblStockHistory.date FROM tblStockHistory INNER JOIN tblProducts ON tblStockHistory.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId where tblStockHistory.pId = '" + id + "' and tblStockHistory.dt >= '" + date1 + "' and tblStockHistory.dt <= '" + date2 + "' ", obj.con);
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
            else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adpt = new SqlDataAdapter(" SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStockHistory.quantity, tblStockHistory.pPrice,  tblStockHistory.quantity * tblStockHistory.pPrice AS subTotalPPrice, tblStockHistory.sPrice,  tblStockHistory.quantity * tblStockHistory.sPrice AS subTotalSPrice, tblStockHistory.authUser, tblStockHistory.date FROM tblStockHistory INNER JOIN tblProducts ON tblStockHistory.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId where tblStockHistory.dt >= '" + date1 + "' and tblStockHistory.dt <= '" + date2 + "' ", obj.con);
                adpt.Fill(dt);
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }


            tblLyPnlViewStockHistory.Visible = false;
            pnlPrinting.Visible = true;

            
        }

        void gridViewRefash()
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
                SqlDataAdapter adp = new SqlDataAdapter("SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStockHistory.quantity, tblStockHistory.pPrice,  tblStockHistory.quantity * tblStockHistory.pPrice AS subTotalPPrice, tblStockHistory.sPrice,  tblStockHistory.quantity * tblStockHistory.sPrice AS subTotalSPrice, tblStockHistory.authUser, tblStockHistory.date FROM tblStockHistory INNER JOIN tblProducts ON tblStockHistory.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId where tblStockHistory.pId = '" + pId + "' and tblStockHistory.dt >= '" + date1 + "' and tblStockHistory.dt <= '" + date2 + "'", obj.con);
                adp.Fill(dtl);
                dataGridViewStockHistory.DataSource = dtl;

                DataTable dtbl = new DataTable();
                SqlDataAdapter adpt = new SqlDataAdapter("select SUM(quantity) as qun, SUM(pPrice * quantity) as pPrice, SUM(sPrice * quantity) as sPrice from tblStockHistory where pId = '" + pId + "' and tblStockHistory.dt >= '" + date1 + "' and tblStockHistory.dt <= '" + date2 + "'", obj.con);
                adpt.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                {
                    lblTotalQnt.Text = "0";
                    lblTotalPurchasePrice.Text = "0";
                    lblTotalSalePrice.Text = "0";
                }
                else
                {
                    lblTotalQnt.Text = dtbl.Rows[0]["qun"].ToString();
                    lblTotalPurchasePrice.Text = dtbl.Rows[0]["pPrice"].ToString();
                    lblTotalSalePrice.Text = dtbl.Rows[0]["sPrice"].ToString();
                }

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
                        for (int i = 0; i < dtbl.Rows.Count; i++ )
                        {
                            
                            int id = Convert.ToInt16(dtbl.Rows[i]["pId"].ToString());
                            SqlDataAdapter adp = new SqlDataAdapter("SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStockHistory.quantity, tblStockHistory.pPrice,  tblStockHistory.quantity * tblStockHistory.pPrice AS subTotalPPrice, tblStockHistory.sPrice,  tblStockHistory.quantity * tblStockHistory.sPrice AS subTotalSPrice, tblStockHistory.authUser, tblStockHistory.date FROM tblStockHistory INNER JOIN tblProducts ON tblStockHistory.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId where tblStockHistory.pId = '" + id + "' and tblStockHistory.dt >= '" + date1 + "' and tblStockHistory.dt <= '" + date2 + "'", obj.con);
                            adp.Fill(dtl);
                            if(dtl.Rows.Count >= 1)
                            {
                                qun = qun + Convert.ToDouble(dtl.Rows[i]["quantity"].ToString());
                                pPrice = pPrice + Convert.ToDouble(dtl.Rows[i]["subTotalPPrice"].ToString());
                                sPrice = sPrice + Convert.ToDouble(dtl.Rows[i]["subTotalSPrice"].ToString());
                            }
                        }
                        dataGridViewStockHistory.DataSource = dtl;
                        lblTotalQnt.Text = qun.ToString();
                        lblTotalPurchasePrice.Text = pPrice.ToString();
                        lblTotalSalePrice.Text = sPrice.ToString();

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
                            SqlDataAdapter adp = new SqlDataAdapter("SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStockHistory.quantity, tblStockHistory.pPrice,  tblStockHistory.quantity * tblStockHistory.pPrice AS subTotalPPrice, tblStockHistory.sPrice,  tblStockHistory.quantity * tblStockHistory.sPrice AS subTotalSPrice, tblStockHistory.authUser, tblStockHistory.date FROM tblStockHistory INNER JOIN tblProducts ON tblStockHistory.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId where tblStockHistory.pId = '" + id + "' and tblStockHistory.dt >= '" + date1 + "' and tblStockHistory.dt <= '" + date2 + "'", obj.con);
                            adp.Fill(dtl);
                            if (dtl.Rows.Count >= 1)
                            {
                                qun = qun + Convert.ToDouble(dtl.Rows[i]["quantity"].ToString());
                                pPrice = pPrice + Convert.ToDouble(dtl.Rows[i]["subTotalPPrice"].ToString());
                                sPrice = sPrice + Convert.ToDouble(dtl.Rows[i]["subTotalSPrice"].ToString());
                            }
                        }
                        dataGridViewStockHistory.DataSource = dtl;
                        lblTotalQnt.Text = qun.ToString();
                        lblTotalPurchasePrice.Text = pPrice.ToString();
                        lblTotalSalePrice.Text = sPrice.ToString();

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
                DataTable dtl = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStockHistory.quantity, tblStockHistory.pPrice,  tblStockHistory.quantity * tblStockHistory.pPrice AS subTotalPPrice, tblStockHistory.sPrice,  tblStockHistory.quantity * tblStockHistory.sPrice AS subTotalSPrice, tblStockHistory.authUser, tblStockHistory.date FROM tblStockHistory INNER JOIN tblProducts ON tblStockHistory.pId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId where tblStockHistory.dt >= '" + date1 + "' and tblStockHistory.dt <= '" + date2 + "'", obj.con);
                adp.Fill(dtl);
                dataGridViewStockHistory.DataSource = dtl;

                DataTable dtbl = new DataTable();
                SqlDataAdapter adpt = new SqlDataAdapter("select SUM(quantity) as qun, SUM(pPrice * quantity) as pPrice, SUM(sPrice * quantity) as sPrice from tblStockHistory where tblStockHistory.dt >= '" + date1 + "' and tblStockHistory.dt <= '" + date2 + "'", obj.con);
                adpt.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                {
                    lblTotalQnt.Text = "0";
                    lblTotalPurchasePrice.Text = "0";
                    lblTotalSalePrice.Text = "0";
                }
                else
                {
                    lblTotalQnt.Text = dtbl.Rows[0]["qun"].ToString();
                    lblTotalPurchasePrice.Text = dtbl.Rows[0]["pPrice"].ToString();
                    lblTotalSalePrice.Text = dtbl.Rows[0]["sPrice"].ToString();
                }
                return;
            }

        }




    }
}
