using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD_Calculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_Calculator_Click(object sender, EventArgs e)
        {
            frm_Calculator f1 = new frm_Calculator();
            this.Hide();
            f1.ShowDialog();
            //f1.show();
           

        }

        private void btnTTSV_Click(object sender, EventArgs e)
        {
            frm_ThongTinSV f = new frm_ThongTinSV();
            f.Show();
        }
    }
}
