using QuanLyHocSinh.BLL;
using QuanLyHocSinh.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class Import : Form
    {
        private DataTable _db;
        private int _fromFrom;
        public Import()
        {
            InitializeComponent();
        }
        public Import(int fromFrom)
        {
            _fromFrom = fromFrom;
            InitializeComponent();
        }


        private void Import_Load(object sender, EventArgs e)
        {
            OpenFileDialog fopen = new OpenFileDialog();
            fopen.Filter = "(Tất cả các tệp)|*.*|(Các tệp excel)|*.xlsx";
            fopen.ShowDialog();

            if (fopen.FileName != "")
            {
                try
                {
                    DataTable db = new DataTable();
                    string PathConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fopen.FileName + ";Extended Properties=Excel 12.0;";
                    OleDbConnection conn = new OleDbConnection(PathConn);
                    OleDbDataAdapter myAdapter = new OleDbDataAdapter("Select * from[Sheet1$]", conn);
                    myAdapter.Fill(db);
                    _db = new DataTable();
                    _db = db;
                    GirdviewImport.DataSource = db;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Quá trình xuất bị lỗi, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tập tin nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void bntYes_Click(object sender, EventArgs e)
        {
            switch (_fromFrom)
            {
                case 1:
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn nhập từ danh sách này không", "thông báo", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            try
                            {
                                var listScores = convertToListScores(_db);
                                string schooYear = _db.Rows[0]["Năm học"].ToString();
                                decimal semesterId = Convert.ToDecimal(_db.Rows[0]["Học kỳ"]);                            
                                string subject = _db.Rows[0]["Môn học"].ToString();
                                if (schooYear == string.Empty || subject == string.Empty || semesterId < 1 || semesterId > 2)
                                {
                                    MessageBox.Show("thao tác bị lỗi, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    YearController yearController = new YearController();
                                    SubjectController subjectController = new SubjectController();
                                    ScoresController scoresController = new ScoresController();
                                    string schooYearId = yearController.GetID(schooYear);
                                    string subjectId = subjectController.GetId(subject);
                                    bool isUpdate = scoresController.UpdateListScores(listScores, schooYearId, semesterId, subjectId);
                                    if (isUpdate)
                                        MessageBox.Show("Update thành công", "Thông báo");
                                    else
                                        MessageBox.Show("thao tác bị lỗi, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("thao tác bị lỗi, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else
                        }
                        break;
                    }
                case 2:
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn nhập từ danh sách này không", "thông báo", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            try
                            {
                                var listConduct = convertToListConduct(_db);
                                string schooYear = _db.Rows[0]["Năm học"].ToString();
                                decimal semesterId = Convert.ToDecimal(_db.Rows[0]["Học kỳ"]);                             
                                if (schooYear == string.Empty || semesterId < 1 || semesterId > 2)
                                {
                                    MessageBox.Show("thao tác bị lỗi, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    YearController yearController = new YearController();                                    
                                    ConductController conductController = new ConductController();
                                    string schooYearId = yearController.GetID(schooYear);
                                    
                                    bool isUpdate = conductController.UpdateListScores(listConduct, schooYearId, semesterId);
                                    if (isUpdate)
                                        MessageBox.Show("Update thành công", "Thông báo");
                                    else
                                        MessageBox.Show("thao tác bị lỗi, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("thao tác bị lỗi, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else
                        }
                        break;
                    }
                case 3:
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn nhập từ danh sách này không", "thông báo", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            try
                            {
                                var listStudent = convertToListStudent(_db);
                                string schooYear = _db.Rows[0]["Năm học"].ToString();
                                string Class = _db.Rows[0]["Lớp"].ToString();
                               
                                if (schooYear == string.Empty || Class == string.Empty )
                                {
                                    MessageBox.Show("thao tác bị lỗi, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    YearController yearController = new YearController();
                                    SubjectController subjectController = new SubjectController();
                                    StudentController studentController = new StudentController();
                                    string schooYearId = yearController.GetID(schooYear);
                                    
                                    bool isInsert = studentController.AddListStudent(listStudent, schooYearId, Class);
                                    if (isInsert)
                                        MessageBox.Show("Update thành công", "Thông báo");
                                    else
                                        MessageBox.Show("thao tác bị lỗi, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("thao tác bị lỗi, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else
                        }
                        break;
                    }

            }
        }

        private List<SCORES> convertToListScores(DataTable db)
        {
            List<SCORES> listScores = db.AsEnumerable().Select(m => new SCORES()
            {
                MSHOCSINH = m.Field<string>("MSHS"),
                NAME = m.Field<string>("Họ và tên"),
                SCORE_5M = (decimal?)m.Field<double?>("5 phút"),
                SCORE_15M = (decimal?)m.Field<double?>("15 phút"),
                SCORE_45M = (decimal?)m.Field<double?>("45 phút"),
                SCORE_MIDYEAR = (decimal?)m.Field<double?>("Giữa kỳ"),
                SCORE_ENDYEAR = (decimal?)m.Field<double?>("Cuối kỳ"),
                MEDIUMSCORE = null                
            }).ToList();
            return listScores;
        }
        private List<CONDUCT> convertToListConduct(DataTable db)
        {
            List<CONDUCT> listScores = db.AsEnumerable().Select(m => new CONDUCT()
            {
                MSHOCSINH = m.Field<string>("MSHS"),
                NAME = m.Field<string>("Họ và tên"),
                CONDUCTNAME = m.Field<string>("Hạnh kiểm")               
            }).ToList();
            return listScores;
        }
        private List<STUDENT> convertToListStudent(DataTable db)
        {           
            List<STUDENT> listStudent = db.AsEnumerable().Select(m => new STUDENT()
            {
                MSHOCSINH = m.Field<string>("MSHS"),
                NAME = m.Field<string>("Họ và tên"),
                BIRTHDAY = (DateTime?)(m.Field<DateTime>("Ngày sinh")),
                ADDRESS = m.Field<string>("Địa chỉ"),
                SEX = (m.Field<string>("Giới tính"))=="Nam"?1:0,
                PHONE = m.Field<string>("SDT"),
            }).ToList();
            //List<STUDENT> students = new List<STUDENT>();
            //for (int i = 0; i < listStudent.Count; i++)
            //{
            //    STUDENT student = new STUDENT();
            //    student.NAME = listStudent[i].NAME;
            //    student.MSHOCSINH = listStudent[i].MSHOCSINH;
            //    student.PHONE = listStudent[i].PHONE;
            //    if (listStudent[i].SEX == "Nam")
            //        student.SEX = 1;
            //    else
            //        student.SEX = 0;
            //    student.BIRTHDAY = listStudent[i].BIRTHDAY;
            //    student.ADDRESS = listStudent[i].ADDRESS;
            //    students.Add(student);

            //}
                return listStudent;
        }            
    }
}
