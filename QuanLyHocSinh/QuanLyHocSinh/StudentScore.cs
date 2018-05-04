using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class StudentScore : Form
    {
        string _username, _password;

        public StudentScore()
        {
            InitializeComponent();
            // hide background of logo
           var a = PointToScreen(picturelogo.Location);
            a = bunifuGradientPanel1.PointToClient(a);
            picturelogo.Parent = bunifuGradientPanel1;
            picturelogo.Location = a;
            picturelogo.BackColor = Color.Transparent;

          //hide background of tittle
            var b = PointToScreen(titleSchool.Location);
            a = bunifuGradientPanel1.PointToClient(b);
            titleSchool.Parent = bunifuGradientPanel1;           
            titleSchool.BackColor = Color.Transparent;

           //hide background of Username
            var c = PointToScreen(labelName.Location);
            c = bunifuGradientPanel1.PointToClient(c);
            labelName.Parent = bunifuGradientPanel1;            
            labelName.BackColor = Color.Transparent;

            menuStrip1.BackColor = Color.Transparent;
        }

        public StudentScore(string pusername, string ppassword)
        {
            InitializeComponent();
            this._username = pusername;
            this._password = ppassword;
            labelName.Text = pusername;
        }

        private void itemChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword frmChangePassword = new ChangePassword();
            frmChangePassword.MdiParent = this;
            frmChangePassword.Show();
        }

        private void StudentScore_Load(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            StudentController studentController = new StudentController();
            ClassController classController = new ClassController();
            YearController yearController = new YearController();
            SemesterController semesterController = new SemesterController();
            ConductController conductController = new ConductController();
            student = studentController.getStudent(_username);
            txtMSHS.Text = student.MSHOCSINH;
            txtBirthday.Text = student.BIRTHDAY.ToString();
            txtName.Text = student.NAME;
            cmbYear.ValueMember = "SCHOOLYEARID";
            cmbYear.DisplayMember = "NAME";
            cmbYear.DataSource = yearController.GetListYear(student.MSHOCSINH);
            cmbSemester.ValueMember = "SEMESTERID";
            cmbSemester.DisplayMember = "NAME";
            cmbSemester.DataSource = semesterController.GetAll();
            txtClass.Text = classController.GetClass(cmbYear.SelectedValue.ToString(),student.MSHOCSINH);
            if (CaculateScores() != -1)
                txtAverageScore.Text = CaculateScores().ToString();
            if (CaculateScores() <(decimal)3.5)
            {
                txtType.Text = "kém";
            }
            else if (CaculateScores() < (decimal)5)
            {
                txtType.Text = "yếu";
            }
            else if (CaculateScores() < (decimal)6.5)
            {
                txtType.Text = "TB";
            }
            else if (CaculateScores() < (decimal)8)
            {
                txtType.Text = "Khá";
            }
            else 
            {
                txtType.Text = "Giỏi";
            }
            txtConduct.Text = conductController.GetConducName(txtMSHS.Text, (decimal)cmbSemester.SelectedValue, cmbYear.SelectedValue.ToString());
        }

        private void gridDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtMSHS.Text == "" || cmbYear.SelectedValue.ToString() == "" || cmbSemester.SelectedValue == null || txtClass.Text == "")
            {
                txtType.Text = "";
                txtConduct.Text = "";
                txtAverageScore.Text = "";
            }
            else
            {
                ConductController conductController = new ConductController();
                StudentViewScoreController studentViewScoreController = new StudentViewScoreController();
                var sourced = studentViewScoreController.get(txtMSHS.Text, cmbYear.SelectedValue.ToString(), (decimal)cmbSemester.SelectedValue, txtClass.Text);
                gridDiem.DataSource = sourced;
                if (CaculateScores() != -1)
                    txtAverageScore.Text = CaculateScores().ToString();
                if (CaculateScores() < (decimal)3.5)
                {
                    txtType.Text = "kém";
                }
                else if (CaculateScores() < (decimal)5)
                {
                    txtType.Text = "yếu";
                }
                else if (CaculateScores() < (decimal)6.5)
                {
                    txtType.Text = "TB";
                }
                else if (CaculateScores() < (decimal)8)
                {
                    txtType.Text = "Khá";
                }
                else
                {
                    txtType.Text = "Giỏi";
                }
                txtConduct.Text = conductController.GetConducName(txtMSHS.Text, (decimal)cmbSemester.SelectedValue, cmbYear.SelectedValue.ToString());
            }
            

        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConductController conductController = new ConductController();
            StudentViewScoreController studentViewScoreController = new StudentViewScoreController();
            if (cmbYear.SelectedValue == null || cmbSemester.SelectedValue == null || txtClass.Text == string.Empty || txtMSHS == null)
            {
                txtType.Text = "";
                txtConduct.Text = "";
                txtAverageScore.Text = "";
            }
            else
            {                
                var sourced = studentViewScoreController.get(txtMSHS.Text, cmbYear.SelectedValue.ToString(), (decimal)cmbSemester.SelectedValue, txtClass.Text);
                gridDiem.DataSource = sourced;
                if (CaculateScores() != -1)
                    txtAverageScore.Text = CaculateScores().ToString();
                if (CaculateScores() < (decimal)3.5)
                {
                    txtType.Text = "kém";
                }
                else if (CaculateScores() < (decimal)5)
                {
                    txtType.Text = "yếu";
                }
                else if (CaculateScores() < (decimal)6.5)
                {
                    txtType.Text = "TB";
                }
                else if (CaculateScores() < (decimal)8)
                {
                    txtType.Text = "Khá";
                }
                else
                {
                    txtType.Text = "Giỏi";
                }
                txtConduct.Text = conductController.GetConducName(txtMSHS.Text, (decimal)cmbSemester.SelectedValue, cmbYear.SelectedValue.ToString());
            }
        }

        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConductController conductController = new ConductController();
            StudentViewScoreController studentViewScoreController = new StudentViewScoreController();
            if (cmbYear.SelectedValue == null || cmbSemester.SelectedValue == null || txtClass.Text == String.Empty || txtMSHS == null)
            {
                txtType.Text = "";
                txtConduct.Text = "";
                txtAverageScore.Text = "";
            }
            else
            {
                var sourced = studentViewScoreController.get(txtMSHS.Text, cmbYear.SelectedValue.ToString(), (decimal)cmbSemester.SelectedValue, txtClass.Text);
                gridDiem.DataSource = sourced;
                if (CaculateScores() != -1)
                    txtAverageScore.Text = CaculateScores().ToString();
                if (CaculateScores() < (decimal)3.5)
                {
                    txtType.Text = "kém";
                }
                else if (CaculateScores() < (decimal)5)
                {
                    txtType.Text = "yếu";
                }
                else if (CaculateScores() < (decimal)6.5)
                {
                    txtType.Text = "TB";
                }
                else if (CaculateScores() < (decimal)8)
                {
                    txtType.Text = "Khá";
                }
                else
                {
                    txtType.Text = "Giỏi";
                }
                txtConduct.Text = conductController.GetConducName(txtMSHS.Text, (decimal)cmbSemester.SelectedValue, cmbYear.SelectedValue.ToString());
            }
        }
        private decimal CaculateScores()
        {
            if (gridDiem.RowCount < 1 || gridDiem.ColumnCount < 1)
                return -1;
            decimal result = 0;
            if (gridDiem.RowCount == 8 && gridDiem.ColumnCount == 7)
            {
                if (gridDiem[6,0].Value == null || gridDiem[6,1].Value == null
                    || gridDiem[6,2].Value == null || gridDiem[ 6,3].Value == null || gridDiem[6,4].Value == null || gridDiem[6,5].Value == null || gridDiem[ 6,6].Value == null || gridDiem[6,7].Value == null)
                    return -1;
                result = (Convert.ToDecimal(gridDiem[6,0].Value) + Convert.ToDecimal(gridDiem[6,1].Value) + Convert.ToDecimal(gridDiem[ 6,2].Value) + Convert.ToDecimal(gridDiem[ 6,3].Value) + Convert.ToDecimal(gridDiem[6,4].Value) + Convert.ToDecimal(gridDiem[6,5].Value) + Convert.ToDecimal(gridDiem[6, 6].Value) + Convert.ToDecimal(gridDiem[ 6,7].Value)) / 8;
            }
            return result;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
                    PdfPTable pdfPTable = new PdfPTable(gridDiem.Columns.Count + 1);
                    #region Font for VN
                    string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALUNI.TTF");
                    //Create a base font object making sure to specify IDENTITY-H
                    BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    //font for body
                    iTextSharp.text.Font f = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                    #endregion
                    #region get title
                    for (int col = 0; col < gridDiem.Columns.Count; col++)
                    {
                        if (col != 0)
                            pdfPTable.AddCell(new Phrase(gridDiem.Columns
                        [col].HeaderText, f));
                        else
                        {
                            pdfPTable.AddCell(new Phrase("STT", f));
                            pdfPTable.AddCell(new Phrase(gridDiem.Columns[col].HeaderText, f));
                        }
                    }
                    pdfPTable.HeaderRows = 1;
                    #endregion
                    #region get data in gridview
                    for (int row = 0; row < gridDiem.Rows.Count; row++)
                    {
                        for (int col = 0; col < gridDiem.Columns.Count; col++)
                        {
                            if (gridDiem[col, row].Value != null)
                            {
                                if (col != 0)
                                {
                                    pdfPTable.AddCell(new Phrase(gridDiem[col, row].Value.ToString(), f));
                                }
                                else
                                {
                                    pdfPTable.AddCell(new Phrase((row + 1).ToString(), f));
                                    pdfPTable.AddCell(new Phrase(gridDiem[col, row].Value.ToString(), f));
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
                    title_1 = new Paragraph("Bảng điểm học kỳ "+cmbSemester.Text +" năm "+ cmbYear.Text, titleFont);
                    title_1.Alignment = Element.ALIGN_CENTER;
                    
                    endParagraph = new Paragraph("Thời gian in " + DateTime.Now.ToString(), titleFont);
                    endParagraph.Alignment = Element.ALIGN_RIGHT;
                    #endregion
                    #region Add text to doc

                    doc.Add(title_1);
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

        private void itemLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.ActiveForm.Show();
        }
    }
}
