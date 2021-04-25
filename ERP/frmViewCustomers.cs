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
    public partial class frmViewCustomers : Form
    {
        ConnectionString obj = new ConnectionString();
        public frmViewCustomers()
        {
            InitializeComponent();
        }

        private void frmViewCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.tblCustomers' table. You can move, or remove it, as needed.
            this.tblCustomersTableAdapter.Fill(this.mainDataSet.tblCustomers);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string data = txtSearch.Text.Replace("'", "''");

            if (data != "")
            {
                try
                {
                    obj.con.Open(); 
                    obj.cmd = new SqlCommand(" SELECT * from tblCustomers where cstName like '" + data + "%' ", obj.con);
                    SqlDataAdapter sda = new SqlDataAdapter(obj.cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewCustomers.DataSource = dt;
                    obj.con.Close();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

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

        private void txtSearch_TextChange(object sender, EventArgs e)
        {

        }
    }
}
