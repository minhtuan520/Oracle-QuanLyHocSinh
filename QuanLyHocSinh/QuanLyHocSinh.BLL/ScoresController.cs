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
        public List<SCORES> GetAll(string subjectID, decimal semesterID, string classID, string yearID)
        {
            var listResult = (from student in _QuanLyHocSinhEntities.STUDENT
                              join
                              classes in _QuanLyHocSinhEntities.STUDENTINCLASS
                              on student.MSHOCSINH equals classes.MSHOCSINH
                              join testCores in _QuanLyHocSinhEntities.TESTSCORES
                              on student.MSHOCSINH equals testCores.MSHOCSINH
                              where testCores.SUBJECTID == subjectID && testCores.SEMESTERID == semesterID && classes.IDCLASS == classID && classes.SCHOOLYEARID == yearID
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
        public bool UpdateListScores(List<SCORES> listScores, string schoolYearID, decimal semesterID, string subjectID)
        {
            bool flag = true;
            for (int i = 0; i < listScores.Count; i++)
            {
                string mshs = listScores[i].MSHOCSINH;
                List<TESTSCORES> findScoreUpdate = _QuanLyHocSinhEntities.TESTSCORES.Where(testScore => testScore.MSHOCSINH == mshs && testScore.SCHOOLYEARID == schoolYearID && testScore.SEMESTERID == semesterID && testScore.SUBJECTID == subjectID).Take(1).ToList();
                
                //var findScoreUpdate = (from testScores in _QuanLyHocSinhEntities.TESTSCORES
                //                       where(((testScores.MSHOCSINH == listScores[i].MSHOCSINH) && (testScores.SCHOOLYEARID == schoolYearID) && (testScores.SEMESTERID == semesterID)&&(testScores.SUBJECTID == subjectID))) select testScores ).ToList();
                if (findScoreUpdate != null)
                {
                    if (listScores[i].SCORE_5M != null)
                        findScoreUpdate[0].SCORE_5M = listScores[i].SCORE_5M;
                    if (listScores[i].SCORE_15M != null)
                        findScoreUpdate[0].SCORE_15M = listScores[i].SCORE_15M;
                    if (listScores[i].SCORE_45M != null)
                        findScoreUpdate[0].SCORE_45M = listScores[i].SCORE_45M;
                    if (listScores[i].SCORE_MIDYEAR != null)
                        findScoreUpdate[0].SCORE_MIDYEAR = listScores[i].SCORE_MIDYEAR;
                    if (listScores[i].SCORE_ENDYEAR != null)
                        findScoreUpdate[0].SCORE_ENDYEAR = listScores[i].SCORE_ENDYEAR;
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
