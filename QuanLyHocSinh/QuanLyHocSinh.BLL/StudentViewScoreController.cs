using QuanLyHocSinh.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.BLL
{
    public class StudentViewScoreController
    {
        private QuanLyHocSinhEntities _QuanLyHocSinhEntities = new QuanLyHocSinhEntities();
        public List<ViewStudentScores> get(string MSHS, string schoolYearId, decimal semesterId, string classId)
        {
            var findData = (from studentClass in _QuanLyHocSinhEntities.STUDENTINCLASS
                            join testScore in _QuanLyHocSinhEntities.TESTSCORES on studentClass.MSHOCSINH equals testScore.MSHOCSINH
                            join subject in _QuanLyHocSinhEntities.SUBJECT on testScore.SUBJECTID equals subject.SUBJECTID
                            where testScore.SCHOOLYEARID == schoolYearId && testScore.MSHOCSINH == MSHS && testScore.SEMESTERID == semesterId && studentClass.IDCLASS == classId
                            select new ViewStudentScores
                            {
                                SubjectName = subject.NAME,
                                SCORE_5M = testScore.SCORE_5M,
                                SCORE_15M = testScore.SCORE_15M,
                                SCORE_45M = testScore.SCORE_45M,
                                SCORE_MIDYEAR = testScore.SCORE_MIDYEAR,
                                SCORE_ENDYEAR = testScore.SCORE_ENDYEAR,
                                MEDIUMSCORE = null
                            }).ToList();
            if (findData.Count > 0)
            {
                foreach (ViewStudentScores score in findData)
                {
                    if (score.SCORE_ENDYEAR == null || score.SCORE_MIDYEAR == null || score.SCORE_45M == null || score.SCORE_15M == null || score.SCORE_5M == null)
                        continue;
                    else
                    {
                        score.MEDIUMSCORE = (score.SCORE_5M + score.SCORE_15M + score.SCORE_45M * 2 + score.SCORE_MIDYEAR * 2 + score.SCORE_ENDYEAR * 3) / 9;
                        score.MEDIUMSCORE = decimal.Round((decimal)(score.MEDIUMSCORE), 2);
                    }
                }
            }
            return findData;

        }
    }
}
