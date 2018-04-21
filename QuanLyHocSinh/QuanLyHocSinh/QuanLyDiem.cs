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
    public partial class QuanLyDiem : Form
    {
        public QuanLyDiem()
        {
            InitializeComponent();
        }

        private void QuanLyDiem_Load(object sender, EventArgs e)
        {
            LoadCmb();
            ScoresController scoresController = new ScoresController();
            var listScores = scoresController.GetAll(cmbSubject.SelectedValue.ToString(), (decimal)cmbSemester.SelectedValue, cmbClass.SelectedValue.ToString());
            DataTable db = new DataTable();
            db = listScores.ToDataTable();
            GridView_Diem.DataSource = db;
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
        private void LoadCmbSubject()
        {
            SubjectController subjectController = new SubjectController();
            List<SUBJECT> subjects = subjectController.GetAll();
            cmbSubject.ValueMember = "SUBJECTID";
            cmbSubject.DisplayMember = "NAME";
            cmbSubject.DataSource = subjects;
        }
        private void LoadCmbSemester()
        {
            SemesterController semesterController = new SemesterController();
            List<SEMESTER> semesters = semesterController.GetAll();
            cmbSemester.ValueMember = "SEMESTERID";
            cmbSemester.DisplayMember = "NAME";
            cmbSemester.DataSource = semesters;
        }
        private void LoadCmb()
        {
            LoadCmbGrade();
            LoadCmbClass();
            LoadCmbSubject();
            LoadCmbSemester();
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScoresController scoresController = new ScoresController();
            if (cmbSemester.SelectedValue == null || cmbClass.SelectedValue == null || cmbSubject.SelectedValue == null) ;
            else
            {
                var listScores = scoresController.GetAll(cmbSubject.SelectedValue.ToString(), (decimal)cmbSemester.SelectedValue, cmbClass.SelectedValue.ToString());
                DataTable db = new DataTable();
                db = listScores.ToDataTable();
                GridView_Diem.DataSource = db;
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScoresController scoresController = new ScoresController();
            if (cmbClass.SelectedValue == null || cmbSemester.SelectedValue == null || cmbSubject.SelectedValue == null) ;
            else
            {
                var listScores = scoresController.GetAll(cmbSubject.SelectedValue.ToString(), (decimal)cmbSemester.SelectedValue, cmbClass.SelectedValue.ToString());
                DataTable db = new DataTable();
                db = listScores.ToDataTable();
                GridView_Diem.DataSource = db;
            }
        }

        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScoresController scoresController = new ScoresController();
            if (cmbClass.SelectedValue == null || cmbSubject.SelectedValue == null ||
                cmbSemester.SelectedValue == null) ;
            else
            {
                var listScores = scoresController.GetAll(cmbSubject.SelectedValue.ToString(), (decimal)cmbSemester.SelectedValue, cmbClass.SelectedValue.ToString());
                DataTable db = new DataTable();
                db = listScores.ToDataTable();
                GridView_Diem.DataSource = db;
            }
        }
    }
}
