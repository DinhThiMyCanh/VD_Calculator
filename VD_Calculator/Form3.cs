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
    public partial class frm_ThongTinSV : Form
    {
        public frm_ThongTinSV()
        {
            InitializeComponent();
        }

        private void btnTTSV_Click(object sender, EventArgs e)
        {
            string ht = txtHoDem.Text + " " + txtTen.Text;
            // string ns = dtpNgaySinh.Text;
            string ns = dtpNgaySinh.Value.ToString();
            //string gt = "Nam";
            //if (rdNu.Checked == true)
            //    gt = "Nữ";
            string gt = rdNam.Checked == true ? "Nam" : "Nữ";

            string nn = "";
            if (chkTiengAnh.Checked == true)
                nn = "Tiếng Anh";
            if (chkTiengNhat.Checked == true)
                nn = nn + ";" + "Tiếng Nhật";

            string qq = "";
            qq = cboQuequan.SelectedItem.ToString();

            string dsmh = "";
            foreach (string mh in lstDSMH.SelectedItems)
                dsmh = dsmh + mh+"\n";

            MessageBox.Show("Họ và tên:" + ht +
                "\nNgày sinh:" + ns +
                "\n Giới tính:" + gt +
                "\n Ngoại ngữ:" + nn +
                "\n Quê quán:" + qq +
                "\n Danh sách môn học:" + dsmh);

        }

        private void frm_ThongTinSV_Load(object sender, EventArgs e)
        {
            cboQuequan.Items.Add("Bình Định");
            cboQuequan.Items.Add("Phú Yên");
            cboQuequan.Items.Add("Gia Lai");
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtHoDem.Clear();
            txtHoDem.Focus();
            txtTen.Clear();

            dtpNgaySinh.Value = DateTime.Now;
            if (rdNu.Checked == false)
                rdNu.Checked = true;

            if (chkTiengAnh.Checked == true)
                chkTiengAnh.Checked = false;
            if (chkTiengNhat.Checked == true)
                chkTiengNhat.Checked = false;

            cboQuequan.SelectedIndex = 0;
            lstDSMH.ClearSelected();

        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Filter = "Tập tin ảnh|*.bmp;*.png;*.jpg|File tùy ý(*.*)|*.*";
            if (oFile.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(oFile.FileName);
        }
    }
}
