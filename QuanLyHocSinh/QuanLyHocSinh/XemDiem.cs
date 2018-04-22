using QuanLyHocSinh.BLL;
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
    public partial class XemDiem : Form
    {
        public XemDiem()
        {
            InitializeComponent();
        }
        private void LoadCmbYear()
        {
            YearController yearController = new YearController();
            List<SCHOOLYEAR> year = yearController.GetAll();
            cmbYear.ValueMember = "SCHOOLYEARID";
            cmbYear.DisplayMember = "NAME";
            cmbYear.DataSource = year;
        }
        private void LoadCmb()
        {
            LoadCmbYear();
        }

        private void XemDiem_Load(object sender, EventArgs e)
        {
            LoadCmb();
        }
    }
}
