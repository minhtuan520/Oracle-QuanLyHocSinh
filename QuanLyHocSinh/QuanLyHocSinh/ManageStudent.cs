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
    public partial class ManageStudent : Form
    {
        private string _MSHS = "";
        public ManageStudent()
        {
            InitializeComponent();
        }
        
        private void bntImport_Click(object sender, EventArgs e)
        {
            Import frmImport = new Import(3);
            frmImport.MdiParent = this.MdiParent;
            frmImport.Show();
        }


        private void ManageStudent_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadCmb();

        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            FindStudent.Instance.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
        private void LoadCmb()
        {
            LoadCmbYear();
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
        private void LoadCmbYear()
        {
            YearController yearController = new YearController();
            List<SCHOOLYEAR> schoolYears = yearController.GetAll();
            cmbYear.ValueMember = "SCHOOLYEARID";
            cmbYear.DisplayMember = "NAME";
            cmbYear.DataSource = schoolYears;
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentController studentController = new StudentController();
            if (cmbYear.SelectedValue == null || cmbClass.SelectedValue == null) ;
            else
            {
                var listStudent = studentController.GetAll(cmbYear.SelectedValue.ToString(), cmbClass.SelectedValue.ToString());
                DataTable db = new DataTable();
                db = listStudent.ToDataTable();
                GridStudent.DataSource = db;
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
            StudentController studentController = new StudentController();
            if (cmbYear.SelectedValue == null || cmbClass.SelectedValue == null) ;
            else
            {
                var listStudent = studentController.GetAll(cmbYear.SelectedValue.ToString(), cmbClass.SelectedValue.ToString());
                DataTable db = new DataTable();
                db = listStudent.ToDataTable();
                GridStudent.DataSource = db;
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
                    PdfPTable pdfPTable = new PdfPTable(GridStudent.Columns.Count + 1);
                    #region Font for VN
                    string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALUNI.TTF");
                    //Create a base font object making sure to specify IDENTITY-H
                    BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    //font for body
                    iTextSharp.text.Font f = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                    #endregion
                    #region get title
                    for (int col = 0; col < GridStudent.Columns.Count; col++)
                    {
                        if (col != 0)
                            pdfPTable.AddCell(new Phrase(GridStudent.Columns
                        [col].HeaderText, f));
                        else
                        {
                            pdfPTable.AddCell(new Phrase("STT", f));
                            pdfPTable.AddCell(new Phrase(GridStudent.Columns[col].HeaderText, f));
                        }
                    }
                    pdfPTable.HeaderRows = 1;
                    #endregion
                    #region get data in gridview
                    for (int row = 0; row < GridStudent.Rows.Count; row++)
                    {
                        for (int col = 0; col < GridStudent.Columns.Count; col++)
                        {
                            if (GridStudent[col, row].Value != null)
                            {
                                if (col != 0)
                                {
                                    pdfPTable.AddCell(new Phrase(GridStudent[col, row].Value.ToString(), f));
                                }
                                else
                                {
                                    pdfPTable.AddCell(new Phrase((row + 1).ToString(), f));
                                    pdfPTable.AddCell(new Phrase(GridStudent[col, row].Value.ToString(), f));
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
                    Paragraph title_1, title_2, endParagraph;
                    iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.NORMAL);
                    title_1 = new Paragraph("DANH SÁCH HỌC SINH NĂM " +  cmbYear.Text, titleFont);
                    title_1.Alignment = Element.ALIGN_CENTER;
                    title_2 = new Paragraph("LỚP " + cmbClass.Text, titleFont);
                    title_2.Alignment = Element.ALIGN_CENTER;
                    endParagraph = new Paragraph("Thời gian in " + DateTime.Now.ToString(), titleFont);
                    endParagraph.Alignment = Element.ALIGN_RIGHT;
                    #endregion
                    #region Add text to doc

                    doc.Add(title_1);
                    doc.Add(new Phrase("\n"));
                    doc.Add(title_2);
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
                for (j = 0; j < GridStudent.Columns.Count; j++)
                {
                    Excel.Range myRange = (Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = GridStudent.Columns[j].HeaderText;
                }
                StartRow++;
                //Write datagridview content
                for (i = 0; i < GridStudent.Rows.Count; i++)
                {
                    for (j = 0; j < GridStudent.Columns.Count; j++)
                    {
                        try
                        {
                            Excel.Range myRange = (Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = GridStudent[j, i].Value == null ? "" : GridStudent[j, i].Value.ToString();
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

        private void bntInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtAddress.Text == string.Empty || txtPhone.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
            else
            {
                decimal? sex;
                if (radioNam.Checked)
                    sex = 1;
                else
                    sex = 0;
                STUDENT student = new STUDENT();
                student.NAME = txtName.Text;
                student.ADDRESS = txtAddress.Text;
                student.PHONE = txtPhone.Text;
                student.SEX = sex;
                student.BIRTHDAY = dateTimeBirthday.Value;
                StudentController studentController = new StudentController();
                bool isInsert = studentController.AddStudent(student, cmbYear.SelectedValue.ToString(),cmbClass.Text);
                if (isInsert)
                {
                    MessageBox.Show("Nhập thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Nhập thất bại, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (this.GridStudent.SelectedRows.Count > 0)
            {
                int row = GridStudent.SelectedRows[0].Index;
                STUDENTINFORMATION studentInformation = new STUDENTINFORMATION();
                studentInformation.MSHOCSINH = GridStudent[0,row].Value.ToString();
                studentInformation.NAME = GridStudent[1,row].Value.ToString();
                studentInformation.BIRTHDAY = (DateTime)GridStudent[2,row].Value;
                studentInformation.ADDRESS = GridStudent[3,row].Value.ToString();
                if (GridStudent[4,row].Value.ToString() == "1")
                    studentInformation.SEX = "Nam";
                else
                    studentInformation.SEX = "Nữ";
                studentInformation.PHONE = GridStudent[5,row].Value.ToString();
                StudentController studentController = new StudentController();
                bool flag = studentController.RemoveStudent(studentInformation.MSHOCSINH, cmbYear.SelectedValue.ToString(), cmbClass.SelectedValue.ToString());
                if (flag)
                    MessageBox.Show("Xóa thành công", "Thông báo");
                else
                {
                    MessageBox.Show("Nhập thất bại, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            StudentController studentController = new StudentController();
            if (txtName.Text == "" || dateTimeBirthday.Value == null || txtAddress.Text == "" || txtPhone.Text == "" || cmbYear.Text == "") ;
            else
            {
                STUDENTINFORMATION sTUDENTINFORMATION = new STUDENTINFORMATION();
                sTUDENTINFORMATION.MSHOCSINH = _MSHS;
                sTUDENTINFORMATION.NAME = txtName.Text;
                if (radioNam.Checked = true)
                    sTUDENTINFORMATION.SEX = "Nam";
                else
                    sTUDENTINFORMATION.SEX = "Nữ";
                sTUDENTINFORMATION.PHONE = txtPhone.Text;
                sTUDENTINFORMATION.ADDRESS = txtAddress.Text;
                sTUDENTINFORMATION.BIRTHDAY = dateTimeBirthday.Value;
                if (studentController.UpdateStudent(sTUDENTINFORMATION))
                {
                    MessageBox.Show("Update thành công", "Thông báo");
                }
                else
                    MessageBox.Show("Update thất bại", "Thông báo");

            }

           
        }

        private void GridStudent_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _MSHS = GridStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = GridStudent.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimeBirthday.Value = (DateTime)GridStudent.Rows[e.RowIndex].Cells[2].Value;
         
            txtAddress.Text = GridStudent.Rows[e.RowIndex].Cells[4].Value.ToString();
            
            if (GridStudent.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nam")
            {
                radioNam.Checked = true;
               
            }
            else
            {
                radioNu.Checked = true;
                
            }
            txtPhone.Text = GridStudent.Rows[e.RowIndex].Cells[5].Value.ToString();
            
        }
    }
}
