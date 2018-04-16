using QuanLyHocSinh.DAL;
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
    public partial class Form1 : Form
    {
        QuanLyHocSinhEntities QuanLyHocSinh = new QuanLyHocSinhEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridview.DataSource = QuanLyHocSinh.TYPEACCOUNT.ToList();
        }
    }
}
