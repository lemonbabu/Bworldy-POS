using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class MsgBox : Form
    {
        String msg;
        public MsgBox(String s)
        {
            InitializeComponent();
            msg = s;
            lblMsg1.Text = s;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
