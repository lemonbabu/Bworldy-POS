
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class frmBarcodeGenerate : Form
    {
        ConnectionString obj = new ConnectionString();
        int ctId, pId;
        String brCodetxt;

        AppData.BarcodeDataTable _barcode;

        public frmBarcodeGenerate()
        {
            InitializeComponent();
            pnlReport.Visible = false;
            pnlBarcode.Visible = false;
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
        }

        private void cmbProductName_Click(object sender, EventArgs e)
        {
            String pCtgName = cmbProductCtg.Text.Trim().Replace("'", "''");
            //Call categories id funtions 
            ctId = obj.funCtgId(pCtgName);
            if (ctId == 0)
            {
                MessageBox.Show("Please select a categorie!!", "Warning");
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void cmbProductSize_SelectedValueChanged(object sender, EventArgs e)
        {
            String pName = cmbProductName.Text.Trim().Replace("'", "''");
            string psize = cmbProductSize.Text.Trim().Replace("'", "''");
            //Call categories id funtions 
            pId = obj.funPrdId(ctId, pName, psize);
            if (pId == 0)
            {
                return;
            }
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblStock where pId = '" + pId + "' ", obj.con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                {
                    MessageBox.Show("This product is not exist!", "Warning");
                    return;
                }
                else
                {
                    DateTime date = Convert.ToDateTime(dtbl.Rows[0]["lastDate"].ToString());
                    //this query for last quant
                    SqlDataAdapter sd = new SqlDataAdapter("SELECT * FROM tblStockHistory where pId = '" + pId + "' and date = '" + date + "' ", obj.con);
                    DataTable dtl = new DataTable();
                    sd.Fill(dtl);
                    if (dtl.Rows.Count < 1)
                    {
                        MessageBox.Show("This product stock add first", "Warning");
                        return;
                    }
                    txtCurentStock.Text = dtl.Rows[0]["quantity"].ToString();

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

           // btnGenerate.Focus();
        }
              
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string ctg = cmbProductCtg.Text.Trim().Replace("'", "''");
            string name = cmbProductName.Text.Trim().Replace("'", "''");
            string size = cmbProductSize.Text.Trim().Replace("'", "''");

            pId = obj.funPrdId(obj.funCtgId(ctg), name, size);
            //this query for last quant
            SqlDataAdapter sd = new SqlDataAdapter("SELECT tblBarcode.pId as pId, tblBarcode.barcode as barcode, tblStock.sPrice as Price, tblProducts.pSize as Size FROM tblBarcode INNER JOIN tblStock ON tblBarcode.pId = tblStock.pId INNER JOIN tblProducts ON tblStock.pId = tblProducts.pId where tblBarcode.pId = '" + pId + "' ", obj.con);
            DataTable dtl = new DataTable();
            sd.Fill(dtl);
            if (dtl.Rows.Count < 1)
            {
                MessageBox.Show("This product is not available", "Warning");
                return;
            }
            else
            {
                pnlBarcode.Visible = true;
                brCodetxt = dtl.Rows[0]["barcode"].ToString();
                double price= Convert.ToDouble(dtl.Rows[0]["Price"].ToString());
                string sz = dtl.Rows[0]["Size"].ToString();

                BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
                Image img = barcode.Encode(BarcodeLib.TYPE.CODE128 , brCodetxt, Color.Black, Color.White, 150, 60);
                pictureBox1.Image = img;

                this.appData1.Clear();
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, ImageFormat.Png);
                    int n = Convert.ToInt16(txtCurentStock.Text);
                    if (n < 4)
                        n = 1;
                    else
                    {
                        if(n % 4 == 0)
                            n = (n / 4);
                        else
                            n = (n / 4) + 1;
                    }
                    for (int i = 0; i < n; i++)
                        this.appData1.Barcode.AddBarcodeRow(brCodetxt, ms.ToArray(), price, sz);
                }

                barcodeInitaialization(this.appData1.Barcode);
            }

        }

        private void txtCurentStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGenerate_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btnGenerate.Focus();
            }
        }

        private void frmBarcodeGenerate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.Barcode' table. You can move, or remove it, as needed.
           // this.BarcodeTableAdapter.Fill(this.AppData.Barcode);
           // this.reportViewer1.RefreshReport();
        }

        private void btnBarcodePrint_Click(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            reportDataSource.Value = _barcode;
            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();

            /*
            try
            {
                obj.cmd = new SqlCommand("SELECT * FROM tblStock Where pId = '" + pId + "' ", obj.con);
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
                obj.cmd = new SqlCommand("SELECT * FROM tblProducts Where pId = '" + pId + "' ", obj.con);
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
            */
            pnlReport.Visible = true;
            tblLyPnlMain.Visible = false;
        }

        void reset()
        {
            cmbProductCtg.Text = "Select a Categorie";
            cmbProductName.Text = "";
            cmbProductSize.Text = "";
            txtCurentStock.Text = "";
        }

        void barcodeInitaialization(AppData.BarcodeDataTable barcode)
        {
            this._barcode = barcode;
        }


    }
}
