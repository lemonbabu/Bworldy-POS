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
    public partial class frmNewSale : Form
    {
        ConnectionString obj = new ConnectionString();
        long barcode;
        int pId, custId, ctgId, saleId, quantity;
        String cstName, cstPhone, name, ctg, size, sPrice, disc, stock, userName;
        double totl, pay, due, discnt, overallDiscount, unitPrice, unitDiscount;

        private void frmNewSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.tblTempSale' table. You can move, or remove it, as needed.
            //this.tblTempSaleTableAdapter.Fill(this.mainDataSet.tblTempSale);
            dltAllDataTblNewSells();
            pnlPrinting.Visible = false;
            tblLyPnlMain.Visible = true;

        }

        private void dataGridViewSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            // This condition for column clik avoiding
            i = Convert.ToInt16(e.RowIndex.ToString());
            if (i < 0)
                return;

            if (e.ColumnIndex == 10)
            {
                DialogResult result = MessageBox.Show("Are you sure to Remove?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        i = Convert.ToInt16(dataGridViewSale.Rows[e.RowIndex].Cells[0].Value.ToString());
                        BindingSource a = new BindingSource();
                        deleteItem(a, i);
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

        public frmNewSale( string name)
        {
            InitializeComponent();
            userName = name;
            txtBarcode.Focus();
            tblPnlSales.Visible = true;
            tblPnlCustomer.Visible = false;

            /*
            if (e.KeyCode == Keys.Enter)
            {
                btnEditStock_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btnEditStock.Focus();
            }
            */
        }

        private void btnSaleConfirm_Click(object sender, EventArgs e)
        {
            cstName = txtCustomerName.Text.Replace("'", "''");
            cstPhone = txtCustomerPhone.Text;
            string cAddress = txtCusAddress.Text.Replace("'", "''");

            if (cstName != "" && cstPhone != "" && txtPayment.Text != "" && txtOverallDiscount.Text != "")
            {
                pay = Convert.ToDouble(txtPayment.Text);
                totl = Convert.ToDouble(txtTotalAmount.Text);
                discnt = Convert.ToDouble(txtDiscount.Text);
                due = Convert.ToDouble(txtDiscount.Text);
                overallDiscount = Convert.ToDouble(txtOverallDiscount.Text);
                DialogResult confirm = MessageBox.Show("Are you sure to confirm this sale?", "Sale Confirmation", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (obj.funCustomerId(cstName, cstPhone) == 0)
                        {
                            //new customer insertion
                            try
                            {
                                obj.con.Open();
                                obj.cmd = new SqlCommand("INSERT INTO tblCustomers (cstName, cstPhone, cstAddress)  VALUES('" + cstName + "', '" + cstPhone + "', '" + cAddress + "')", obj.con);
                                obj.cmd.ExecuteNonQuery();
                                obj.con.Close();
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        // new sale insertion also call from saleinseion funtion to product insertion in salesprodcut table
                        salesInsertion(cstName, cstPhone);
                        confirm = MessageBox.Show("Sale confirmed.\nDo you went to print invoice?", "Successfully", MessageBoxButtons.YesNo);
                        if (confirm == DialogResult.Yes)
                        {
                            tblLyPnlMain.Visible = false;
                            pnlPrinting.Visible = true;
                            printInvoice();
                        }
                        else if (confirm == DialogResult.No)
                        {
                            reset();
                            tblPnlCustomer.Visible = false;
                            tblPnlSales.Visible = true;
                            resetDetails();
                            return;
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (confirm == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please fillup customer and Payment Informaion!!", "Warning");
                return;
            }
        }

        void salesInsertion(string cName, string cPhone)
        {
            int id = obj.funCustomerId(cName, cPhone);
            DateTime date = DateTime.Now.Date;
            String time = DateTime.Now.ToString("HH:mm").Trim();
            string payMethod = cmbPayMethod.Text.Trim();
            //new sale insertion
            try
            {
                obj.con.Open();
                obj.cmd = new SqlCommand("INSERT INTO tblSales (cstId, totalAmnt, paidAmnt, discount, overallDiscount, payMethod, date, time, author)  VALUES('" + id + "', '" + totl + "', '" + pay + "', '" + discnt + "', '" + overallDiscount + "', '" + payMethod + "', '" + date + "', '" + time + "', '" + userName + "' )", obj.con);
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            saleId = obj.funSaleId(id, date, Convert.ToDateTime(time));
            // sales history add in this sections
            try
            {
                obj.con.Open();
                obj.cmd = new SqlCommand("INSERT INTO tblPaymentHistory (saleId, total, discount, overallDiscount, payment, date, time)  VALUES('" + saleId + "', '" + totl + "', '" + discnt + "', '" + overallDiscount + "', '" + pay + "', '" + date + "', '" + time + "')", obj.con);
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Product copy grom temp table to main saleProcudt tabe
            saleProdcutInsertion(id, date, Convert.ToDateTime(time));
        }

        //Sales Product Insetion 
        void saleProdcutInsertion(int cId, DateTime date, DateTime time)
        {
            saleId = obj.funSaleId(cId, date, time);

            // temp table checking and 
            try
            {
                obj.con.Open();
                SqlDataAdapter sd = new SqlDataAdapter("SELECT * FROM tblTempSale ", obj.con);
                DataTable dtbl = new DataTable();
                sd.Fill(dtbl);
                int n = dtbl.Rows.Count;
                for(int i = 0; i < n; i++)
                {
                    string pId = dtbl.Rows[i]["pId"].ToString();
                    int quantity = Convert.ToInt16(dtbl.Rows[i]["quantity"].ToString());
                    double unitPrice = Convert.ToDouble(dtbl.Rows[i]["unitPrice"].ToString());
                    double indDiscount = Convert.ToDouble(dtbl.Rows[i]["discount"].ToString());
                    double subTotal = Convert.ToDouble(dtbl.Rows[i]["subTotal"].ToString());

                    //Insertion of main saleproduct table
                    obj.cmd = new SqlCommand("INSERT INTO tblSalesProducts (saleId, pdctId, quantity, saleUnitPrice, discount, subTotal)  VALUES('" + saleId + "', '" + pId + "', '" + quantity + "', '" + unitPrice + "', '" + indDiscount + "', '" + subTotal + "')", obj.con);
                    obj.cmd.ExecuteNonQuery();

                    // decrise product quantity from stock table 
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblStock where pId = '"+ pId +"' ", obj.con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    int stk = Convert.ToInt16(dt.Rows[0]["stock"].ToString());

                    stk = stk - quantity;
                    obj.cmd = new SqlCommand("UPDATE tblStock SET stock = '" + stk + "' WHERE pId = '" + pId + "' ", obj.con);
                    obj.cmd.ExecuteNonQuery();
                }
                obj.con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Activity insertion 
            try
            {
                obj.con.Open();
                obj.cmd = new SqlCommand("INSERT INTO tblActivity (type, id, details, author)  VALUES('" + "New Sales" + "', '" + saleId + "', '" + "New Sales" + "', '" + userName + "')", obj.con);
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tblPnlSales.Visible = true;
            tblPnlCustomer.Visible = false;
            resetDetails();
        }

        private void txtCustomerPhone_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txtCusAddress.Text, out parsedValue))
            {
                txtCusAddress.Text = "";
                return;
            }
        }

        private void txtOverallDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSaleConfirm_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btnSaleConfirm.Focus();
            }
        }

        private void txtCusAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPayment.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtPayment.Focus();
            }
        }

        private void txtOverallDiscount_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(txtOverallDiscount.Text, out parsedValue))
            {
                txtOverallDiscount.Text = "";
                return;
            }
            overallDiscount = Convert.ToDouble(txtOverallDiscount.Text);

            pay = totl - overallDiscount;
            txtPayment.Text = pay.ToString();
        }

        private void txtPayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtOverallDiscount.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtOverallDiscount.Focus();
            }
        }

        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCustomerPhone.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtCustomerPhone.Focus();
            }
        }

        private void txtCustomerPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCusAddress.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtCusAddress.Focus();
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            long parsedValue;
            if (!long.TryParse(txtBarcode.Text, out parsedValue))
            {
                txtBarcode.Text = "";
                return;
            }

            string brcd = txtBarcode.Text;

            int len = brcd.Length;
            if (len != 12 || brcd == "")
                return;
            else 
            {
                try
                {
                    barcode = Convert.ToInt64(brcd);
                    //this for get pId from barcode table 
                    SqlDataAdapter sd = new SqlDataAdapter("SELECT pId FROM tblBarcode where barcode = '" + barcode + "'", obj.con);
                    DataTable dtbl = new DataTable();
                    sd.Fill(dtbl);
                    if (dtbl.Rows.Count < 1)
                    {
                        MessageBox.Show("This product is not found");
                        resetDetails();
                        return;
                    }
                    else
                    {
                        pId = Convert.ToInt16(dtbl.Rows[0]["pId"].ToString());
                        sd = new SqlDataAdapter("SELECT * FROM tblProducts where pId = '" + pId + "'", obj.con);
                        dtbl = new DataTable();
                        sd.Fill(dtbl);

                        ctgId = Convert.ToInt16(dtbl.Rows[0]["pCtgId"].ToString());
                        name = dtbl.Rows[0]["pName"].ToString();
                        size = dtbl.Rows[0]["pSize"].ToString();
                        string details = dtbl.Rows[0]["pDetails"].ToString();

                        lblPdcName.Text = name;
                        lblPdcSize.Text = size;
                        lblPdcDetails.Text = details;

                        sd = new SqlDataAdapter("SELECT * FROM tblCategories where ctgId = '" + ctgId + "'", obj.con);
                        dtbl = new DataTable();
                        sd.Fill(dtbl);
                        ctg = dtbl.Rows[0]["ctgName"].ToString();
                        lblCtgName.Text = ctg;

                        sd = new SqlDataAdapter("SELECT * FROM tblStock where pId = '" + pId + "'", obj.con);
                        dtbl = new DataTable();
                        sd.Fill(dtbl);
                        sPrice = dtbl.Rows[0]["sPrice"].ToString();
                        disc = dtbl.Rows[0]["discount"].ToString();
                        stock = dtbl.Rows[0]["stock"].ToString();

                        lblDiscount.Text = disc;
                        lblSalePrice.Text = sPrice;
                        lblStock.Text = stock;

                        btnAddCart_Click( sender, e);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            pnlProductDetails.Visible = true;
            
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "")
                return;
            double total = Convert.ToDouble(txtTotal.Text);
            if (total == 0)
            {
                MessageBox.Show("Add some items' first!", "Welcome");
                return;
            }
            tblPnlSales.Visible = false;
            tblPnlCustomer.Visible = true;
            txtTotalAmount.Text = total.ToString();
            txtPayment.Text = total.ToString();  
            txtDue.Text = "0";
            txtOverallDiscount.Text = "0";
            try
            {
                SqlDataAdapter sd = new SqlDataAdapter("SELECT SUM(discount) as dis FROM tblTempSale ", obj.con);
                DataTable dtbl = new DataTable();
                sd.Fill(dtbl);
                txtDiscount.Text = dtbl.Rows[0]["dis"].ToString();
                discnt = Convert.ToDouble(dtbl.Rows[0]["dis"].ToString());
                txtInTotal.Text = (discnt + total).ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtCustomerName.Focus();
            txtCustomerName.Text = "Mr";
            txtCustomerPhone.Text = "01";
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(txtPayment.Text, out parsedValue))
            {
                txtPayment.Text = "";
                return;
            }
            pay = Convert.ToDouble(txtPayment.Text);

            due = totl - pay - overallDiscount;
            txtDue.Text = due.ToString();

        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBarcode.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btnCheckOut.Focus();
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text == "")
                return;
            barcode = Convert.ToInt64(txtBarcode.Text);
            //Barcode validity checking 
            //this for chek bar code for privious add int chart 
            SqlDataAdapter sd = new SqlDataAdapter("SELECT barcode FROM tblBarcode where barcode = '" + barcode + "' ", obj.con);
            DataTable dtbl = new DataTable();
            sd.Fill(dtbl);
            if (dtbl.Rows.Count < 1)
            {
                MessageBox.Show("This barcode is not valid!", "Warning");
                resetDetails();
                return;
            }
            
            string ctgName = lblCtgName.Text.Replace("'", "''");
            string pName = lblPdcName.Text.Replace("'", "''");
            string pSize = lblPdcSize.Text.Replace("'", "''");
            int qnt = Convert.ToInt16(lblStock.Text);
            double unitPrice = Convert.ToDouble(lblSalePrice.Text);
            double discount = Convert.ToDouble(lblDiscount.Text);
            double subTotal;
            int pId = obj.funPrdId(obj.funCtgId(ctgName), pName, pSize);

            //quantity cheking 
            if (qnt == 0)
            {
                MessageBox.Show("Quantity is not sufficient for sale.", "Warning");
                return;
            }

            //this for chek bar code for privious add int chart 
            sd = new SqlDataAdapter("SELECT * FROM tblTempSale where barcode = '" + barcode + "' ", obj.con);
            dtbl = new DataTable();
            sd.Fill(dtbl);
            if (dtbl.Rows.Count < 1)
            {
                //insertion new product in chart
                subTotal = unitPrice - discount;
                try
                {
                    obj.con.Open();
                    obj.cmd = new SqlCommand("INSERT INTO tblTempSale (pId, barcode, ctgName, pName, pSize, quantity, unitPrice, discount, subTotal)  VALUES('" + pId + "', '" + barcode + "', '" + ctgName + "', '" + pName + "', '" + pSize + "', '" + 1 + "', '" + unitPrice + "', '" + discount + "', '" + subTotal + "')", obj.con);
                    obj.cmd.ExecuteNonQuery();
                    tempGridViewRefash();
                    txtBarcode.Text = "";
                    obj.con.Close();
                    txtBarcode.Focus();
                    //resetDetails();
                }
                catch (SqlException ex)
                {
                    obj.con.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                qnt = qnt - Convert.ToInt16(dtbl.Rows[0]["quantity"].ToString());
                if (qnt == 0)
                {
                    MessageBox.Show("Quantity is not sufficient for sale.", "Warning");
                    return;
                }

                try
                {
                    // update quantity in chart
                    int quantity = Convert.ToInt16(dtbl.Rows[0]["quantity"].ToString());
                    quantity = quantity + 1;
                    subTotal = (unitPrice - discount) * quantity;
                    obj.con.Open();
                    obj.cmd = new SqlCommand("UPDATE tblTempSale SET quantity = '" + quantity + "', subTotal = '" + subTotal + "' WHERE barcode = '" + barcode + "' ", obj.con);
                    obj.cmd.ExecuteNonQuery();
                    obj.con.Close();
                    tempGridViewRefash();
                    txtBarcode.Text = "";
                    txtBarcode.Focus();

                    //resetDetails();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // total calcualtion
            totalCalculation();
        }

        void tempGridViewRefash()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from tblTempSale", obj.con);
                adapt.Fill(dt);
                dataGridViewSale.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Delete 1 item from graidview in the tbleNewSells
        void deleteItem(BindingSource a, int i)
        {
            try
            {
                obj.con.Open();
                obj.cmd = new SqlCommand("DELETE FROM tblTempSale WHERE Id = '" + i + "'", obj.con);
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
                tempGridViewRefash();
            }
            catch (Exception e)
            {
                MessageBox.Show("SQL error" + e);
            }
            totalCalculation();
        }

        //this function work on delete all data from tblNewSells table
        void dltAllDataTblNewSells()
        {
            obj.cmd = new SqlCommand("DELETE FROM tblTempSale", obj.con);

            try
            {
                obj.con.Open();
                obj.cmd.ExecuteNonQuery();
                obj.con.Close();
                tempGridViewRefash();
            }
            catch (Exception e)
            {
                MessageBox.Show("SQL error" + e);
            }
            txtTotal.Text = "";
        }

        void totalCalculation()
        {
            try
            {
                SqlDataAdapter sd = new SqlDataAdapter("SELECT SUM(subTotal) as total FROM tblTempSale ", obj.con);
                DataTable dtbl = new DataTable();
                sd.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                    return;
                txtTotal.Text = dtbl.Rows[0]["total"].ToString();
                if(txtTotal.Text != "")
                    totl = Convert.ToDouble(txtTotal.Text);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void reset()
        {
            txtCusAddress.Text = "";
            txtCustomerName.Text = "";
            txtCustomerPhone.Text = "";
            txtDiscount.Text = "";
            txtDue.Text = "";
            txtTotalAmount.Text = "";
            txtPayment.Text = "";
            txtBarcode.Text = "";
            txtOverallDiscount.Text = "";
            dltAllDataTblNewSells();
        }

        void printInvoice()
        {
            try
            {
                obj.cmd = new SqlCommand("SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblSalesProducts.saleUnitPrice, tblSalesProducts.quantity, tblSalesProducts.discount, tblSalesProducts.subTotal, tblSalesProducts.saleId FROM tblSalesProducts INNER JOIN tblProducts ON tblSalesProducts.pdctId = tblProducts.pId INNER JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId Where tblSalesProducts.saleId = '" + saleId + "' ", obj.con);
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
                obj.cmd = new SqlCommand("SELECT * FROM tblSales Where saleId = '" + saleId + "' ", obj.con);
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
                obj.cmd = new SqlCommand("SELECT * FROM tblCustomers Where cstName = '" + cstName + "' and cstPhone = '" + cstPhone + "' ", obj.con);
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

        void resetDetails()
        {
            lblCtgName.Text = "0";
            lblDiscount.Text = "0";
            lblPdcDetails.Text = "";
            lblPdcName.Text = "0";
            lblPdcSize.Text = "0";
            lblSalePrice.Text = "0";
            lblStock.Text = "0";
            txtBarcode.Text = "";
            txtBarcode.Focus();
        }


    }
}
