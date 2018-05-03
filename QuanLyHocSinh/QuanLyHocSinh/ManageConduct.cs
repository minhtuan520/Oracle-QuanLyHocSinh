using MoreLinq;
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
    public partial class ManageConduct : Form
    {
        public ManageConduct()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            FindStudent frmFindStudent = new FindStudent();
            frmFindStudent.MdiParent = this.MdiParent;
            frmFindStudent.Show();
        }

        private void bntImport_Click(object sender, EventArgs e)
        {
            Import frmImport = new Import();
            frmImport.MdiParent = this.MdiParent;
            frmImport.Show();
        }

        private void ManageConduct_Load(object sender, EventArgs e)
        {
            LoadCmb();
        }
        #region Load Combobox
        private void LoadCmb()
        {
            LoadCmbYear();
            LoadCmbSemester();
            LoadCmbGrade();
            LoadCmbClass();        
        }
        private void LoadCmbGrade()
        {
            GradelevelController gradeLevelController = new GradelevelController();
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
      
        private void LoadCmbSemester()
        {
            SemesterController semesterController = new SemesterController();
            List<SEMESTER> semesters = semesterController.GetAll();
            cmbSemester.ValueMember = "SEMESTERID";
            cmbSemester.DisplayMember = "NAME";
            cmbSemester.DataSource = semesters;
        }
        private void LoadCmbYear()
        {
            YearController yearController = new YearController();
            List<SCHOOLYEAR> schoolYears = yearController.GetAll();
            cmbYear.ValueMember = "SCHOOLYEARID";
            cmbYear.DisplayMember = "NAME";
            cmbYear.DataSource = schoolYears;
        }
        #endregion

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConductController conductController = new ConductController();
            if (cmbClass.SelectedValue == null || cmbSemester.SelectedValue == null || cmbYear.SelectedValue == null) ;
            else
            {
                var listConduct = conductController.GetAll((decimal)cmbSemester.SelectedValue, cmbClass.SelectedValue.ToString(), cmbYear.SelectedValue.ToString());
                DataTable db = new DataTable();
                db = listConduct.ToDataTable();
                GridView_Conduct.DataSource = db;
            }
        }
        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConductController conductController = new ConductController();
            if (cmbClass.SelectedValue == null || cmbSemester.SelectedValue == null || cmbYear.SelectedValue == null) ;
            else
            {
                var listConduct = conductController.GetAll((decimal)cmbSemester.SelectedValue, cmbClass.SelectedValue.ToString(), cmbYear.SelectedValue.ToString());
                DataTable db = new DataTable();
                db = listConduct.ToDataTable();
                GridView_Conduct.DataSource = db;
            }
        }
        private void cmbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassController classController = new ClassController();
            if (cmbGrade.SelectedValue == null) ;
            else
            {
                var listClass = classController.GetClass((decimal)cmbGrade.SelectedValue);
                if (listClass.Count > 0)
                {
                    cmbClass.DataSource = listClass;
                }
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConductController conductController = new ConductController();
            if (cmbClass.SelectedValue == null || cmbSemester.SelectedValue == null || cmbYear.SelectedValue == null) ;
            else
            {
                var listConduct = conductController.GetAll( (decimal)cmbSemester.SelectedValue, cmbClass.SelectedValue.ToString(), cmbYear.SelectedValue.ToString());
                DataTable db = new DataTable();
                db = listConduct.ToDataTable();
                GridView_Conduct.DataSource = db;
            }
        }

        
    }
}
