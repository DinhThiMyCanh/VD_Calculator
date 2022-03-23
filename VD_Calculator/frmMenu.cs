using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VD_Calculator
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tínhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Calculator f = new frm_Calculator();
            f.MdiParent = this;
            f.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Filter = "C# source code|*.cs";
            if (oFile.ShowDialog()==DialogResult.OK)
            {
                Stream stream = oFile.OpenFile();
                StreamReader reader = new StreamReader(stream);
                txtFile.Text = reader.ReadToEnd();
                stream.Close();
                reader.Close();
            }    
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            sFile = new SaveFileDialog();
            sFile.Filter = "Lưu dưới dạng file *.txt|*.txt";
            if (sFile.ShowDialog()==DialogResult.OK)
            {
                Stream stream = sFile.OpenFile();
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(txtFile.Text);
                writer.Close();
                stream.Close();
                
            }    
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowColor = true;
            font.Font = txtFile.Font;
            font.Color = txtFile.ForeColor;

            if (font.ShowDialog()==DialogResult.OK)
            {
                txtFile.Font = font.Font;
                txtFile.ForeColor = font.Color;
            }    
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult rd = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rd ==DialogResult.Yes)
            {
                txtFile.Clear();
            }    

        }
    }
}
