using iTextSharp.text;
using iTextSharp.text.pdf;
using MoreLinq;
using QuanLyHocSinh.BLL;
using QuanLyHocSinh.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class ManageScore : Form
    {
        public ManageScore()
        {
            InitializeComponent();
        }
        private void ManageScore_Load(object sender, EventArgs e)
        {
            LoadCmb();
            ScoresController scoresController = new ScoresController();
            var listScores = scoresController.GetAll(cmbSubject.SelectedValue.ToString(), (decimal)cmbSemester.SelectedValue, cmbClass.SelectedValue.ToString(), cmbYear.SelectedValue.ToString());
            DataTable db = new DataTable();
            db = listScores.ToDataTable();
            GridView_Diem.DataSource = db;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            FindStudent frmFindStudent = new FindStudent();
            frmFindStudent.MdiParent = this.MdiParent;
            frmFindStudent.Show();
        }

        #region Load Combobox
        private void LoadCmb()
        {
            LoadCmbYear();
            LoadCmbSemester();
            LoadCmbGrade();
            LoadCmbClass();
            LoadCmbSubject();
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
        private void LoadCmbYear()
        {
            YearController yearController = new YearController();
            List<SCHOOLYEAR> schoolYears = yearController.GetAll();
            cmbYear.ValueMember = "SCHOOLYEARID";
            cmbYear.DisplayMember = "NAME";
            cmbYear.DataSource = schoolYears;
        }
        #endregion
        #region Combobox Event
        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScoresController scoresController = new ScoresController();
            if (cmbYear.SelectedValue == null || cmbSemester.SelectedValue == null || cmbClass.SelectedValue == null || cmbSubject.SelectedValue == null) ;
            else
            {
                var listScores = scoresController.GetAll(cmbSubject.SelectedValue.ToString(), (decimal)cmbSemester.SelectedValue, cmbClass.SelectedValue.ToString(), cmbYear.SelectedValue.ToString());
                DataTable db = new DataTable();
                db = listScores.ToDataTable();
                GridView_Diem.DataSource = db;
            }
        }
        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScoresController scoresController = new ScoresController();
            if (cmbClass.SelectedValue == null || cmbSubject.SelectedValue == null ||
                cmbSemester.SelectedValue == null || cmbYear.SelectedValue == null) ;
            else
            {
                var listScores = scoresController.GetAll(cmbSubject.SelectedValue.ToString(), (decimal)cmbSemester.SelectedValue, cmbClass.SelectedValue.ToString(), cmbYear.SelectedValue.ToString());
                DataTable db = new DataTable();
                db = listScores.ToDataTable();
                GridView_Diem.DataSource = db;
            }
        }
        private void cmbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassController classController = new ClassController();
            if (cmbGrade.SelectedValue == null) ;
            else
            {
                var listClass = classController.GetClassByGradeLevelId((decimal)cmbGrade.SelectedValue);
                if (listClass.Count > 0)
                {
                    cmbClass.DataSource = listClass;
                }
            }
        }
        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScoresController scoresController = new ScoresController();
            if (cmbClass.SelectedValue == null || cmbSemester.SelectedValue == null || cmbSubject.SelectedValue == null || cmbYear.SelectedValue == null) ;
            else
            {
                var listScores = scoresController.GetAll(cmbSubject.SelectedValue.ToString(), (decimal)cmbSemester.SelectedValue, cmbClass.SelectedValue.ToString(), cmbYear.SelectedValue.ToString());
                DataTable db = new DataTable();
                db = listScores.ToDataTable();
                GridView_Diem.DataSource = db;
            }
        }
        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScoresController scoresController = new ScoresController();
            if (cmbSemester.SelectedValue == null || cmbClass.SelectedValue == null || cmbSubject.SelectedValue == null || cmbYear.SelectedValue == null) ;
            else
            {
                var listScores = scoresController.GetAll(cmbSubject.SelectedValue.ToString(), (decimal)cmbSemester.SelectedValue, cmbClass.SelectedValue.ToString(), cmbYear.SelectedValue.ToString());
                DataTable db = new DataTable();
                db = listScores.ToDataTable();
                GridView_Diem.DataSource = db;
            }
        }
        #endregion
        private void bntPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog fsave = new SaveFileDialog();
            fsave.Filter = "(Tất cả các tệp)|*.*|(Các tệp pdf)|*.pdf";
            fsave.ShowDialog();
            if (fsave.FileName != "")
            {
                try
                {
                    Document doc = new Document(PageSize.LETTER, 5, 5, 42, 35);
                    PdfWriter pdfWriter = PdfWriter.GetInstance(doc, new FileStream(fsave.FileName, FileMode.Create));
                    doc.Open();
                    PdfPTable pdfPTable = new PdfPTable(GridView_Diem.Columns.Count + 1);
                    #region Font for VN
                    string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALUNI.TTF");
                    //Create a base font object making sure to specify IDENTITY-H
                    BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    //font for body
                    iTextSharp.text.Font f = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL); 
                    #endregion                    
                    #region get title
                    for (int col = 0; col < GridView_Diem.Columns.Count; col++)
                    {
                        if (col != 0)
                            pdfPTable.AddCell(new Phrase(GridView_Diem.Columns
                        [col].HeaderText, f));
                        else
                        {
                            pdfPTable.AddCell(new Phrase("STT", f));
                            pdfPTable.AddCell(new Phrase(GridView_Diem.Columns[col].HeaderText, f));
                        }
                    }
                    pdfPTable.HeaderRows = 1;
                    #endregion
                    #region get data in gridview
                    for (int row = 0; row < GridView_Diem.Rows.Count; row++)
                    {
                        for (int col = 0; col < GridView_Diem.Columns.Count; col++)
                        {
                            if (GridView_Diem[col, row].Value != null)
                            {
                                if (col != 0)
                                {
                                    pdfPTable.AddCell(new Phrase(GridView_Diem[col, row].Value.ToString(), f));
                                }
                                else
                                {
                                    pdfPTable.AddCell(new Phrase((row + 1).ToString(), f));
                                    pdfPTable.AddCell(new Phrase(GridView_Diem[col, row].Value.ToString(), f));
                                }
                            }
                            else
                            {
                                pdfPTable.AddCell(new Phrase("", f));
                            }
                        }
                    }
                    #endregion
                    #region Create different text
                    Paragraph title_1, title_2, title_3, endParagraph;
                    iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.NORMAL);
                    title_1 = new Paragraph("BẢNG ĐIỂM HỌC KỲ " + cmbSemester.Text + " Năm " + cmbYear.Text, titleFont);
                    title_1.Alignment = Element.ALIGN_CENTER;
                    title_2 = new Paragraph("BỘ MÔN " + cmbSubject.Text, titleFont);
                    title_2.Alignment = Element.ALIGN_CENTER;
                    title_3 = new Paragraph("LỚP " + cmbClass.Text, titleFont);
                    title_3.Alignment = Element.ALIGN_CENTER;
                    endParagraph = new Paragraph("Thời gian in " + DateTime.Now.ToString(), titleFont);
                    endParagraph.Alignment = Element.ALIGN_RIGHT;
                    #endregion
                    #region Add text to doc

                    doc.Add(title_1);
                    doc.Add(new Phrase("\n"));
                    doc.Add(title_2);
                    doc.Add(new Phrase("\n"));
                    doc.Add(title_3);
                    doc.Add(new Phrase("\n"));
                    doc.Add(pdfPTable);
                    doc.Add(new Phrase("\n"));
                    doc.Add(endParagraph); 
#endregion

                    doc.Close();
                    MessageBox.Show("In thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Quá trình in bị lỗi, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nơi lưu file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bntImport_Click(object sender, EventArgs e)
        {
            Import frmImport = new Import();
            frmImport.MdiParent = this.MdiParent;
            frmImport.Show();
        }
    }
}
