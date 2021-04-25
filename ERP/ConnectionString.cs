using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    class ConnectionString
    {
         public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\erpDatabase.mdf;Integrated Security=True");
         //public SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Orange\Desktop\ERP\ERP\erpDatabase.mdf;Integrated Security = True");
        //private sqlQuery(SET CHARACTER, SET utf8);


        public SqlCommand cmd = new SqlCommand();
        public void appClose(FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure to close this Application?", "Exit", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        // Warning Messages 
        public void msg(String s)
        {
            MsgBox msgBox = new MsgBox(s);
            msgBox.Show();
        }

        // this funtion for check product categories and send product Categories id
        String pCtgId, pCtgName, pCtgUsed;
        public int funCtgId(String name)
        {
            int id = 0;
            pCtgName = name;
            try
            {
                string query = "select * from tblCategories where ctgName = '" + name + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                    return 0;
                else
                {
                    pCtgId = dtbl.Rows[0]["ctgId"].ToString();
                    pCtgUsed = dtbl.Rows[0]["ctgUsed"].ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            id = Convert.ToInt16(pCtgId);
            return id;
        }

        // This function for incresee ctg value for referances 
        public void funIncCtgUsed(String id)
        {
            if (pCtgId == id)
            {
                try
                {
                    int ctgUsed = Convert.ToInt16(pCtgUsed);
                    ctgUsed = ctgUsed + 1;
                    con.Open();
                    cmd = new SqlCommand("UPDATE tblCategories SET ctgUsed = '" + ctgUsed + "' WHERE ctgId = '" + id + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                return;
        }

        ///product id return by this functions
        public int funPrdId(int ctgId, String name, string size)
        {
            int id = 0;
            pCtgName = name;

            try
            {
                string query = "select * from tblProducts where pCtgId = '" + ctgId + "' and pName = '" + name + "' and pSize = '" + size + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count < 1)
                    return 0;
                else
                {
                    id =Convert.ToInt16(dtbl.Rows[0]["pId"].ToString());
                    pCtgUsed = dtbl.Rows[0]["pRef"].ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return id;
        }


        public void funPrdIdDec(int pId)
        {
            try
            {
                SqlDataAdapter sd = new SqlDataAdapter("SELECT * FROM tblProducts where pId = '" + pId + "' ", con);
                DataTable dtl = new DataTable();
                sd.Fill(dtl);
                int pref = Convert.ToInt16(dtl.Rows[0]["pRef"].ToString());
                pref = pref - 1;

                con.Open();
                cmd = new SqlCommand("UPDATE tblProducts SET pRef = '" + pref + "' WHERE pId = '" + pId + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Return customer id 
        public int funCustomerId(string name, string phone)
        {
            int id;
            SqlDataAdapter sd = new SqlDataAdapter("SELECT cstId FROM tblCustomers where cstName = '" + name + "' and cstPhone = '" + phone + "'", con);
            DataTable dtbl = new DataTable();
            sd.Fill(dtbl);
            if (dtbl.Rows.Count < 1)
            {
                return 0;
            }
            else
                id = Convert.ToInt32(dtbl.Rows[0]["cstId"].ToString());
            return id;
        }

        //Return sale id 
        public int funSaleId(int cId, DateTime date, DateTime time)
        {
            int id;
            SqlDataAdapter sd = new SqlDataAdapter("SELECT saleId FROM tblSales where cstId = '" + cId + "' and date = '" + date + "' and time = '" + time + "'", con);
            DataTable dtbl = new DataTable();
            sd.Fill(dtbl);
            if (dtbl.Rows.Count < 1)
            {
                return 0;
            }
            else
                id = Convert.ToInt32(dtbl.Rows[0]["saleId"].ToString());
            return id;
        }


    }
}
