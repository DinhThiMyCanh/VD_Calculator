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
    public partial class frm_Calculator : Form
    {
        public frm_Calculator()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtSo1.Text);
            int b = Convert.ToInt32(txtSo2.Text);
            int c = a + b;
            txtKQ.Text = c.ToString();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            txtKQ.Clear();

            txtSo1.Focus();
        }

        private void frm_Calculator_Load(object sender, EventArgs e)
        {
            txtSo1.Text = "0";
            txtSo2.Text = "0";
            txtKQ.Text = "0";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
