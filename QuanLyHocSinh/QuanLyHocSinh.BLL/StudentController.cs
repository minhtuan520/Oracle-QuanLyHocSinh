using QuanLyHocSinh.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.BLL
{
    public class StudentController
    {
        private QuanLyHocSinhEntities _QuanLyHocSinhEntities = new QuanLyHocSinhEntities();
        public List<STUDENTINFORMATION> GetAll(string schoolYearID, string ClassID)                
        {
            var results = (from student in _QuanLyHocSinhEntities.STUDENT
                           join studentClass in _QuanLyHocSinhEntities.STUDENTINCLASS on student.MSHOCSINH equals studentClass.MSHOCSINH
                           where studentClass.SCHOOLYEARID == schoolYearID && studentClass.IDCLASS == ClassID
                           select new STUDENTINFORMATION
                           {
                               MSHOCSINH = student.MSHOCSINH,
                               NAME = student.NAME,
                               BIRTHDAY = student.BIRTHDAY,
                               ADDRESS = student.ADDRESS,
                               SEX = student.SEX>0?"Nam":"Nữ",
                               PHONE = student.PHONE
                           }).ToList();
            return results;
        }
        public bool AddStudent(STUDENT student, string schoolYearId, string ClassId)
        {
            bool flag = false;
            try
            {
                student.MSHOCSINH = CreateMSHS();
                _QuanLyHocSinhEntities.STUDENT.Add(student);
                flag = AddStudentClass(student, schoolYearId, ClassId);
                if (flag)
                {
                    AccountController accountController = new AccountController();
                    flag = accountController.CreateAccount(student.MSHOCSINH);
                }
                if (flag)
                {
                    ScoresController scoresController = new ScoresController();
                    flag = scoresController.CreateListCores(schoolYearId,student.MSHOCSINH);
                }
                if (flag)
                {
                    LearningOutComeController learningOutComeController = new LearningOutComeController();
                    learningOutComeController.createListLearningOutCome(student.MSHOCSINH, schoolYearId);
                }      
                _QuanLyHocSinhEntities.SaveChanges();
                flag = true;
            }
            catch (Exception)
            {
                flag = false;
            }
            return flag;
        }
        public bool AddStudentClass(STUDENT student, string schoolYearId, string ClassId)
        {
            bool flag = false;
            try
            {
                STUDENTINCLASS studentClass = new STUDENTINCLASS();
                studentClass.IDCLASS = ClassId;
                studentClass.MSHOCSINH = student.MSHOCSINH;
                studentClass.SCHOOLYEARID = schoolYearId;              
                _QuanLyHocSinhEntities.STUDENTINCLASS.Add(studentClass);
                _QuanLyHocSinhEntities.SaveChanges();
                flag = true;
            }
            catch (Exception)
            {
                flag = false;
            }
            return flag;
        }
        public string CreateMSHS()
        {
            var number = _QuanLyHocSinhEntities.STUDENT.Count();
            string MSHS = "";
            string baseString = "HS";
            if (number < 10)
            {
                MSHS = baseString + "000000" + (number+1);
            }
            else if (number < 100)
            {
                MSHS = baseString + "00000" + (number + 1);
            }            
            else if (number < 1000)
            {
                MSHS = baseString + "0000" + (number + 1);
            }          
            else if (number < 10000)
            {
                MSHS = baseString + "000" + (number + 1);
            }
            else if (number < 100000)
            {
                MSHS = baseString + "00" + (number + 1);
            }
            else if (number < 1000000)
            {
                MSHS = baseString + "0" + (number + 1);
            }
            return MSHS;
        }
        public bool RemoveStudent(string MSHS, string schoolYearId, string ClassId)
        {
            ScoresController scoresController = new ScoresController();
            LearningOutComeController learningOutComeController = new LearningOutComeController();
            AccountController accountController = new AccountController();
            scoresController.RemoveListTestScore(MSHS, schoolYearId);
            learningOutComeController.removeListLearningOutCome(MSHS, schoolYearId);
            RemoveStudentClass(MSHS, schoolYearId, ClassId);
            accountController.RemoveAccount(MSHS);
            _QuanLyHocSinhEntities.SaveChanges();
            return true;           
        }
        public bool AddListStudent(List<STUDENT> studentList, string schoolYearId, string ClassId)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                bool flag = AddStudent(studentList[i], schoolYearId, ClassId);
                if (flag == false)
                {
                    return false;
                }
            }
            return true;

        }
        public bool RemoveStudentClass(string MSHS, string schoolYearId, string ClassId)
        {
            var findStudentClass = _QuanLyHocSinhEntities.STUDENTINCLASS.Where(c => c.IDCLASS == ClassId && c.SCHOOLYEARID == schoolYearId && c.MSHOCSINH == MSHS).Take(1).ToList();
            try
            {
                if (findStudentClass.Count > 0)
                {
                    _QuanLyHocSinhEntities.STUDENTINCLASS.Remove(findStudentClass[0]);
                    _QuanLyHocSinhEntities.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }



        }
    }
}
