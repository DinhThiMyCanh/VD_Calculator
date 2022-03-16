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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex==0)
            {
                double m1 = Convert.ToDouble(txtToanCC.Text);
                double m2 = Convert.ToDouble(txtXacSuatTK.Text);
                double dtb = (m1 + m2) / 2;
                txtDTB1.Text = dtb.ToString();
            }   
            else
                if (tabControl1.SelectedIndex == 1)
                {
                    double m1 = Convert.ToDouble(txtCSDL.Text);
                    double m2 = Convert.ToDouble(txtCTDL.Text);
                    double dtb = (m1 + m2) / 2;
                    txtDTB2.Text = dtb.ToString();
                }

        }
    }
}
