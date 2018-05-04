using QuanLyHocSinh.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.BLL
{
    public class ConductController
    {
        private QuanLyHocSinhEntities _QuanLyHocSinhEntities = new QuanLyHocSinhEntities();
        public List<CONDUCT> GetAll(decimal semesterID, string classID, string yearID)
        {
            var listResult = (from student in _QuanLyHocSinhEntities.STUDENT
                              join
                              studentClass in _QuanLyHocSinhEntities.STUDENTINCLASS
                              on student.MSHOCSINH equals studentClass.MSHOCSINH
                              join conduct in _QuanLyHocSinhEntities.LEARNINGOUTCOMES
                              on studentClass.MSHOCSINH equals conduct.MSHOCSINH
                              join testScore in _QuanLyHocSinhEntities.TESTSCORES
                              on studentClass.MSHOCSINH equals testScore.MSHOCSINH
                              where ((semesterID == testScore.SEMESTERID) && (classID == studentClass.IDCLASS) && (yearID == studentClass.SCHOOLYEARID))
                              select new CONDUCT
                              {
                                  MSHOCSINH = student.MSHOCSINH,
                                  NAME = student.NAME,
                                  CONDUCTNAME = conduct.CONDUCT
                              }).Distinct().ToList();
            return listResult;
        }
        public bool UpdateListScores(List<CONDUCT> listConduct, string schoolYearID, decimal semesterID)
        {
            bool flag = true;
            for (int i = 0; i < listConduct.Count; i++)
            {
                string mshs = listConduct[i].MSHOCSINH;
                var findConductUpdate = (from conduct in _QuanLyHocSinhEntities.LEARNINGOUTCOMES join testScore in _QuanLyHocSinhEntities.TESTSCORES on conduct.MSHOCSINH equals testScore.MSHOCSINH where ((conduct.MSHOCSINH == mshs) && (conduct.SCHOOLYEARID == schoolYearID) && (testScore.SEMESTERID == semesterID)) select conduct).Take(1).ToList();


                if (findConductUpdate.Count > 0)
                {
                    findConductUpdate[0].CONDUCT = listConduct[i].CONDUCTNAME;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                try
                {
                    _QuanLyHocSinhEntities.SaveChanges();
                }
                catch (Exception ex)
                {
                    flag = false;
                    return flag;
                }
            }
            return flag;
        }
    }
}
