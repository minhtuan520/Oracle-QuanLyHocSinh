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
    public partial class QuanLyHocSinh : Form
    {
        public QuanLyHocSinh()
        {
            InitializeComponent();
        }
        private void LoadCmbGrade()
        {
            GradelevelController gradeLevelController = new BLL.GradelevelController();
            List<GRADELEVEL> listGradeLevel = gradeLevelController.GetAll();
            cmbGrade.ValueMember = "GRADELEVELID";
            cmbGrade.DisplayMember = "NAME";
            cmbGrade.DataSource = listGradeLevel;
        }
        private void LoadCmbClass()
        {

            ClassController classController = new ClassController();
            List<CLASS> classes = classController.GetAll();
            cmbClass.ValueMember = "IDCLASS";
            cmbClass.DisplayMember = "NAME";
            cmbClass.DataSource = classes;
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
            LoadCmbGrade();
            LoadCmbClass();
            LoadCmbYear();
        }

        private void QuanLyHocSinh_Load(object sender, EventArgs e)
        {
            LoadCmb();
        }
    }
}
