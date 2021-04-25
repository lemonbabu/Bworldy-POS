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
    public partial class frmLowStock : Form
    {
        ConnectionString obj = new ConnectionString();
        public frmLowStock()
        {
            InitializeComponent();
        }

        private void frnLowStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tblLowStock' table. You can move, or remove it, as needed.
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT tblCategories.ctgName, tblProducts.pName, tblProducts.pSize, tblStock.stock FROM tblStock JOIN tblProducts ON tblStock.pId = tblProducts.pId JOIN tblCategories ON tblProducts.pCtgId = tblCategories.ctgId where tblStock.stock <= '"+ 5 +"' ", obj.con);
            adapt.Fill(dt);
            dataGridViewLowStock.DataSource = dt;
            
        }


    }
}
