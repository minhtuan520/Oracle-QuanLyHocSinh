using QuanLyHocSinh.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.BLL
{
    public class ScoresController
    {
        private QuanLyHocSinhEntities _QuanLyHocSinhEntities = new QuanLyHocSinhEntities();
        public List<SCORES> GetAll(string subjectID, decimal semesterID, string classID)
        {
            var listResult = (from student in _QuanLyHocSinhEntities.STUDENTS
                              join
                              classes in _QuanLyHocSinhEntities.STUDENTINCLASS
                              on student.MSHOCSINH equals classes.MSHOCSINH
                              join testCores in _QuanLyHocSinhEntities.TESTSCORES
                              on student.MSHOCSINH equals testCores.MSHOCSINH
                              where testCores.SUBJECTID == subjectID && testCores.SEMESTERID == semesterID && classes.IDCLASS == classID
                              select new SCORES
                              {
                                  MSHOCSINH = student.MSHOCSINH,
                                  NAME = student.NAME,
                                  SCORE_5M = testCores.SCORE_5M,
                                  SCORE_15M = testCores.SCORE_15M,
                                  SCORE_45M = testCores.SCORE_45M,
                                  SCORE_MIDYEAR = testCores.SCORE_MIDYEAR,
                                  SCORE_ENDYEAR = testCores.SCORE_ENDYEAR,
                                  MEDIUMSCORE = null
                              }).ToList();
            foreach (SCORES score in listResult)
            {
                if (score.SCORE_ENDYEAR == null || score.SCORE_MIDYEAR == null || score.SCORE_45M == null || score.SCORE_15M == null || score.SCORE_5M == null)
                    continue;
                else
                {
                    score.MEDIUMSCORE = (score.SCORE_5M + score.SCORE_15M + score.SCORE_45M * 2 + score.SCORE_MIDYEAR * 2 + score.SCORE_ENDYEAR * 3) / 9;
                    score.MEDIUMSCORE = decimal.Round((decimal)(score.MEDIUMSCORE), 2);
                }
            }
            return listResult;
        }


    }
}
