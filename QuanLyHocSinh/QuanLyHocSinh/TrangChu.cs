using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void hocSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHocSinh f = new QuanLyHocSinh();
            f.Show();
        }

        private void DiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void hanhKiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHanhKiem f = new QuanLyHanhKiem();
            f.Show();
        }

        private void xemDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDiem f = new XemDiem();
            f.Show();
        }

        private void DoiPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMatKhau f = new DoiMatKhau();
            f.Show();
        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
