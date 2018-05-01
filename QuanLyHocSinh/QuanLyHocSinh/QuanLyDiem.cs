using MoreLinq;
using QuanLyHocSinh.BLL;
using QuanLyHocSinh.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Text;
using System.Drawing;

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

        private void bntPrint_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Excel.Application xlexcel;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
        private void copyAlltoClipboard()
        {
            GridView_Diem.SelectAll();
            DataObject dataObj = GridView_Diem.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog fopen = new OpenFileDialog();
            fopen.Filter = "(Tất cả các tệp)|*.*|(Các tệp excel)|*.xlsx";
            fopen.ShowDialog();

            if (fopen.FileName != "")
            {
                DataTable db = new DataTable();
                string PathConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fopen.FileName + ";Extended Properties=Excel 12.0;";
                OleDbConnection conn = new OleDbConnection(PathConn);
                OleDbDataAdapter myAdapter = new OleDbDataAdapter("Select * from[Sheet1$]", conn);
                myAdapter.Fill(db);
                // dataGridView1.DataSource = db;             
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tập tin nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            SaveFileDialog fsave = new SaveFileDialog();
            fsave.Filter = "(Tất cả các tệp)|*.*|(Các tệp pdf)|*.pdf";
            fsave.ShowDialog();
            if (fsave.FileName != "")
            {
                Document doc = new Document(PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter pdfWriter = PdfWriter.GetInstance(doc, new FileStream(fsave.FileName, FileMode.Create));
                doc.Open();
                string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALUNI.TTF");

                //Create a base font object making sure to specify IDENTITY-H
                BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                //Create a specific font object unicode
                iTextSharp.text.Font f = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                PdfPTable pdfPTable = new PdfPTable(GridView_Diem.Columns.Count);
                for (int col = 1; col < GridView_Diem.Columns.Count; col++)
                {
                    pdfPTable.AddCell(new Phrase(GridView_Diem.Columns[col].HeaderText, f));
                }
                pdfPTable.AddCell(new Phrase(GridView_Diem.Columns[0].HeaderText, f));
                pdfPTable.HeaderRows = 1;
                for (int row = 0; row < GridView_Diem.Rows.Count; row++)
                {
                    for (int col = 0; col < GridView_Diem.Columns.Count; col++)
                    {

                        if (GridView_Diem[col, row].Value != null)
                        {
                            if (col != 0 || row != 0)
                            {
                                pdfPTable.AddCell(new Phrase(GridView_Diem[col, row].Value.ToString(), f));
                            }
                        }
                    }
                }
                pdfPTable.AddCell(new Phrase(GridView_Diem[0, 0].Value.ToString(), f));
                doc.Add(pdfPTable);
                doc.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nơi lưu file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
