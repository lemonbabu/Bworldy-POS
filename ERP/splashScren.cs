using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class splashScren : Form
    {
        ConnectionString obj = new ConnectionString();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );
        public splashScren()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));
            progressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
           // progressBar1.Text = progressBar1.Value.ToString()+ "%";

            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                frmLogin login_form = new frmLogin();
                login_form.Show();
                this.Hide();
            }
        }


        void licence()
        {

        }

    }
}
