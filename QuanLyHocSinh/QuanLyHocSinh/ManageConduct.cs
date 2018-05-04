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
using Excel = Microsoft.Office.Interop.Excel;
namespace QuanLyHocSinh
{
    public partial class ManageConduct : Form
    {
        public ManageConduct()
        {
            InitializeComponent();
        }        

        private void bntImport_Click(object sender, EventArgs e)
        {
            Import frmImport = new Import(2);
            frmImport.MdiParent = this.MdiParent;
            frmImport.Show();
        }

        private void ManageConduct_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
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
                var listClass = classController.GetListClass((decimal)cmbGrade.SelectedValue);
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
                    PdfPTable pdfPTable = new PdfPTable(GridView_Conduct.Columns.Count + 1);
                    #region Font for VN
                    string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALUNI.TTF");
                    //Create a base font object making sure to specify IDENTITY-H
                    BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    //font for body
                    iTextSharp.text.Font f = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                    #endregion
                    #region get title
                    for (int col = 0; col < GridView_Conduct.Columns.Count; col++)
                    {
                        if (col != 0)
                            pdfPTable.AddCell(new Phrase(GridView_Conduct.Columns
                        [col].HeaderText, f));
                        else
                        {
                            pdfPTable.AddCell(new Phrase("STT", f));
                            pdfPTable.AddCell(new Phrase(GridView_Conduct.Columns[col].HeaderText, f));
                        }
                    }
                    pdfPTable.HeaderRows = 1;
                    #endregion
                    #region get data in gridview
                    for (int row = 0; row < GridView_Conduct.Rows.Count; row++)
                    {
                        for (int col = 0; col < GridView_Conduct.Columns.Count; col++)
                        {
                            if (GridView_Conduct[col, row].Value != null)
                            {
                                if (col != 0)
                                {
                                    pdfPTable.AddCell(new Phrase(GridView_Conduct[col, row].Value.ToString(), f));
                                }
                                else
                                {
                                    pdfPTable.AddCell(new Phrase((row + 1).ToString(), f));
                                    pdfPTable.AddCell(new Phrase(GridView_Conduct[col, row].Value.ToString(), f));
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
                    Paragraph title_1, title_3, endParagraph;
                    iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.NORMAL);
                    title_1 = new Paragraph("BẢNG HẠNH KIỂM HỌC KỲ " + cmbSemester.Text + " Năm " + cmbYear.Text, titleFont);
                    title_1.Alignment = Element.ALIGN_CENTER;                    
                    title_3 = new Paragraph("LỚP " + cmbClass.Text, titleFont);
                    title_3.Alignment = Element.ALIGN_CENTER;
                    endParagraph = new Paragraph("Thời gian in " + DateTime.Now.ToString(), titleFont);
                    endParagraph.Alignment = Element.ALIGN_RIGHT;
                    #endregion
                    #region Add text to doc

                    doc.Add(title_1);
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

        private void bntExport_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application excel = new Excel.Application();
                excel.Visible = true;
                Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Excel.Worksheet sheet1 = (Excel.Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                int j = 0, i = 0;

                //Write Headers
                for (j = 0; j < GridView_Conduct.Columns.Count; j++)
                {
                    Excel.Range myRange = (Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = GridView_Conduct.Columns[j].HeaderText;
                }
                StartRow++;
                //Write datagridview content
                for (i = 0; i < GridView_Conduct.Rows.Count; i++)
                {
                    for (j = 0; j < GridView_Conduct.Columns.Count; j++)
                    {
                        try
                        {
                            Excel.Range myRange = (Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = GridView_Conduct[j, i].Value == null ? "" : GridView_Conduct[j, i].Value;
                        }
                        catch
                        {
                            MessageBox.Show("Quá trình xuất file bị lỗi, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quá trình xuất file bị lỗi, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void copyAlltoClipboard()
        {
            GridView_Conduct.SelectAll();
            DataObject dataObj = GridView_Conduct.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void bntSearch_Click_1(object sender, EventArgs e)
        {
            FindStudent.Instance.ShowDialog();
        }
    }
}
