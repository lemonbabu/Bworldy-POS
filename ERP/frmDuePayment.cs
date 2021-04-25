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
    public partial class frmDuePayment : Form
    {
        ConnectionString obj = new ConnectionString();
        int saleId;
        public frmDuePayment()
        {
            InitializeComponent();
        }

        private void frmDuePayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tblDuePayment' table. You can move, or remove it, as needed.
            this.tblDuePaymentTableAdapter.Fill(this.appData.tblDuePayment);
            dataGridViewReload();

            obj.cmd = new SqlCommand("select cstName from tblCustomers", obj.con);
            obj.con.Open();
            SqlDataReader dr = obj.cmd.ExecuteReader();
            AutoCompleteStringCollection mycollaction = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                mycollaction.Add(dr.GetString(0));
            }
            txtCstName.AutoCompleteCustomSource = mycollaction;
            obj.con.Close();

            obj.cmd = new SqlCommand("select cstPhone from tblCustomers", obj.con);
            obj.con.Open();
            SqlDataReader dr2 = obj.cmd.ExecuteReader();
            AutoCompleteStringCollection mycollaction2 = new AutoCompleteStringCollection();
            while (dr2.Read())
            {
                mycollaction2.Add(dr2.GetString(0));
            }
            txtCstPhone.AutoCompleteCustomSource = mycollaction2;
            obj.con.Close();

        }

        private void txtCstName_KeyDown(object sender, KeyEventArgs e)
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

        private void txtCstPhone_KeyDown(object sender, KeyEventArgs e)
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
            string name = txtCstName.Text.Replace("'", "''");
            string phone = txtCstPhone.Text;

            if(name != "" && phone == "")
            {
                try
                {
                    obj.cmd = new SqlCommand(" SELECT tblSales.saleId, tblSales.cstId, tblCustomers.cstName, tblCustomers.cstPhone, tblSales.totalAmnt, tblSales.discount, tblSales.overallDiscount, tblSales.PaidAmnt,  ((tblSales.totalAmnt - tblSales.discount - tblSales.overallDiscount) - tblSales.PaidAmnt) as dueAmnt FROM  tblCustomers INNER JOIN tblSales ON tblCustomers.cstId = tblSales.cstId where tblCustomers.cstName like '" + name + "%' and ((tblSales.totalAmnt - tblSales.discount - tblSales.overallDiscount) - tblSales.PaidAmnt) > '" + 0 + "'  ", obj.con);
                    SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewDuePayment.DataSource = dt;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (name == "" && phone != "")
            {
                try
                {
                    obj.cmd = new SqlCommand(" SELECT tblSales.saleId, tblSales.cstId, tblCustomers.cstName, tblCustomers.cstPhone, tblSales.totalAmnt, tblSales.discount, tblSales.overallDiscount, tblSales.PaidAmnt,  ((tblSales.totalAmnt - tblSales.discount - tblSales.overallDiscount) - tblSales.PaidAmnt) as dueAmnt FROM  tblCustomers INNER JOIN tblSales ON tblCustomers.cstId = tblSales.cstId where tblCustomers.cstPhone like '" + phone + "%' and ((tblSales.totalAmnt - tblSales.discount - tblSales.overallDiscount) - tblSales.PaidAmnt) > '" + 0 + "' ", obj.con);
                    SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewDuePayment.DataSource = dt;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (name != "" && phone != "")
            {
                try
                {
                    obj.cmd = new SqlCommand(" SELECT tblSales.saleId, tblSales.cstId, tblCustomers.cstName, tblCustomers.cstPhone, tblSales.totalAmnt, tblSales.discount, tblSales.overallDiscount, tblSales.PaidAmnt,  ((tblSales.totalAmnt - tblSales.discount - tblSales.overallDiscount) - tblSales.PaidAmnt) as dueAmnt FROM  tblCustomers INNER JOIN tblSales ON tblCustomers.cstId = tblSales.cstId where tblCustomers.cstName like '" + name + "%' and tblCustomers.cstPhone like '" + phone + "%' and ((tblSales.totalAmnt - tblSales.discount - tblSales.overallDiscount) - tblSales.PaidAmnt) > '" + 0 + "' ", obj.con);
                    SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewDuePayment.DataSource = dt;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fillup name or phone number first!","Warning");
                return;
            }
            reset();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnDueSubmit_Click(object sender, EventArgs e)
        {
            if (txtDue.Text != "" && txtDuePay.Text != "")
            {
                double due = Convert.ToDouble(txtDue.Text);
                double duePay = Convert.ToDouble(txtDuePay.Text);
                double pay = Convert.ToDouble(txtPayment.Text);
                double total = duePay + pay;
                DateTime date = DateTime.Now.Date;
                DateTime time = Convert.ToDateTime(DateTime.Now.ToString("HH:mm").Trim());

                if (due >= duePay)
                {
                    try
                    {
                        DialogResult confirm = MessageBox.Show("Do you want to payment your Due.", "Confirmation", MessageBoxButtons.YesNo);
                        if (confirm == DialogResult.Yes)
                        {
                            obj.con.Open();
                            obj.cmd = new SqlCommand("UPDATE tblSales SET paidAmnt = '" + total + "' WHERE saleId = '" + saleId + "' ", obj.con);
                            obj.cmd.ExecuteNonQuery();

                            obj.cmd = new SqlCommand("INSERT INTO tblDuePaymentHistory (saleId, duePayAmnt, date, time)  VALUES('" + saleId + "', '" + duePay + "', '" + date + "', '" + time + "')", obj.con);
                            obj.cmd.ExecuteNonQuery();
                            obj.con.Close();
                            btnSearch_Click(sender, e);
                        }
                        else if (confirm == DialogResult.No)
                        {
                            return;
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Due Pay can't geter then due!", "Help");
            }
            else
                MessageBox.Show("Please select a sale and pay due amount!", "Help");
        }

        void dataGridViewReload()
        {
            try
            {
                obj.cmd = new SqlCommand(" SELECT tblSales.saleId, tblSales.cstId, tblCustomers.cstName, tblCustomers.cstPhone, tblSales.totalAmnt, tblSales.discount, tblSales.overallDiscount, tblSales.PaidAmnt,  ((tblSales.totalAmnt - tblSales.discount - tblSales.overallDiscount) - tblSales.PaidAmnt) as dueAmnt FROM  tblCustomers INNER JOIN tblSales ON tblCustomers.cstId = tblSales.cstId where ((tblSales.totalAmnt - tblSales.discount - tblSales.overallDiscount) - tblSales.PaidAmnt) > '" + 0 + "' ", obj.con);
                SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewDuePayment.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void reset()
        {
            txtCstPhone.Text = "";
            txtCstName.Text = "";
            txtTotalAmount.Text = "";
            txtDiscount.Text = "";
            txtPayment.Text = "";
            txtDue.Text = "";
            txtDuePay.Text = "";
        }

        private void dataGridViewDuePayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            String total, disc, pay, due;
            // This condition for column clik avoiding
            i = Convert.ToInt16(e.RowIndex.ToString());
            if (i < 0)
                return;

            if (e.ColumnIndex >= 0)
            {
               
                DialogResult result = MessageBox.Show("Are you sure to Pay Due this sale?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        saleId = Convert.ToInt16(dataGridViewDuePayment.Rows[e.RowIndex].Cells[0].Value.ToString());
                        txtCstName.Text = dataGridViewDuePayment.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtCstPhone.Text = dataGridViewDuePayment.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtTotalAmount.Text = dataGridViewDuePayment.Rows[e.RowIndex].Cells[4].Value.ToString();
                        txtDiscount.Text = dataGridViewDuePayment.Rows[e.RowIndex].Cells[5].Value.ToString();
                        txtPayment.Text = dataGridViewDuePayment.Rows[e.RowIndex].Cells[7].Value.ToString();
                        txtDue.Text = dataGridViewDuePayment.Rows[e.RowIndex].Cells[8].Value.ToString();
                        txtDuePay.Focus();
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

        private void txtDuePay_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(txtDuePay.Text, out parsedValue))
            {
                txtDuePay.Text = "";
                return;
            }
        }

        private void txtDuePay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDueSubmit_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btnDueSubmit.Focus();
            }
        }

        private void txtCstPhone_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txtCstPhone.Text, out parsedValue))
            {
                txtCstPhone.Text = "";
                return;
            }
        }


    }
}
