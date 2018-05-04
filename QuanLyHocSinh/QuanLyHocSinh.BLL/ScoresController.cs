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
            #region Check rand value (0-10)
            foreach (SCORES score in listScores)
            {
                if (score.SCORE_5M != null && (score.SCORE_5M > 10 || score.SCORE_5M < 0))
                {
                    flag = false;
                }
                if (score.SCORE_15M != null && (score.SCORE_15M > 10 || score.SCORE_15M < 0))
                {
                    flag = false;
                }
                if (score.SCORE_45M != null && (score.SCORE_45M > 10 || score.SCORE_45M < 0))
                {
                    flag = false;
                }
                if (score.SCORE_MIDYEAR != null && (score.SCORE_MIDYEAR > 10 || score.SCORE_MIDYEAR < 0))
                {
                    flag = false;
                }
                if (score.SCORE_ENDYEAR != null && (score.SCORE_ENDYEAR > 10 || score.SCORE_ENDYEAR < 0))
                {
                    flag = false;
                }
                if (flag == false)
                    return flag;
            }
            #endregion
            for (int i = 0; i < listScores.Count; i++)
            {
                string mshs = listScores[i].MSHOCSINH;
                List<TESTSCORES> findScoreUpdate = _QuanLyHocSinhEntities.TESTSCORES.Where(testScore => testScore.MSHOCSINH == mshs && testScore.SCHOOLYEARID == schoolYearID && testScore.SEMESTERID == semesterID && testScore.SUBJECTID == subjectID).Take(1).ToList();
                if (findScoreUpdate.Count > 0)
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
        public bool CreateListCores(string schoolYearId, string MSHS)
        {
            try
            {
                AddScoreHKI(schoolYearId, MSHS);
                AddScoreHKII(schoolYearId, MSHS);
                _QuanLyHocSinhEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;                
            }
        }
        private bool AddScoreHKI(string schoolYearId, string MSHS)
        {          
            CreateTestScore(schoolYearId, MSHS, "Toan", 1);
            CreateTestScore(schoolYearId, MSHS, "TiengViet", 1);
            CreateTestScore(schoolYearId, MSHS, "TuNhien", 1);
            CreateTestScore(schoolYearId, MSHS, "DaoDuc", 1);
            CreateTestScore(schoolYearId, MSHS, "AnhVan", 1);
            CreateTestScore(schoolYearId, MSHS, "TinHoc", 1);
            CreateTestScore(schoolYearId, MSHS, "AmNhac", 1);
            CreateTestScore(schoolYearId, MSHS, "Ve", 1);
            return true;
        }
        private bool AddScoreHKII(string schoolYearId, string MSHS)
        {
            CreateTestScore(schoolYearId, MSHS, "Toan", 2);
            CreateTestScore(schoolYearId, MSHS, "TiengViet", 2);
            CreateTestScore(schoolYearId, MSHS, "TuNhien", 2);
            CreateTestScore(schoolYearId, MSHS, "DaoDuc", 2);
            CreateTestScore(schoolYearId, MSHS, "AnhVan", 2);
            CreateTestScore(schoolYearId, MSHS, "TinHoc", 2);
            CreateTestScore(schoolYearId, MSHS, "AmNhac", 2);
            CreateTestScore(schoolYearId, MSHS, "Ve", 2);
            return true;
        }
        private TESTSCORES CreateTestScore(string schoolYearId, string MSHS, string SubjectID, decimal semesterID)
        {
            TESTSCORES result = new TESTSCORES();
            result.SCHOOLYEARID = schoolYearId;
            result.MSHOCSINH = MSHS;
            result.SUBJECTID = SubjectID;
            result.SEMESTERID = semesterID;
            _QuanLyHocSinhEntities.TESTSCORES.Add(result);
            return result;
        }
        public bool RemoveTestScore(string MSHS, string SubjectId,decimal semesterId,string schoolYearId)
        {
            var findTestScore = _QuanLyHocSinhEntities.TESTSCORES.Where(t => t.MSHOCSINH == MSHS && t.SUBJECTID == SubjectId && t.SEMESTERID == semesterId && t.SCHOOLYEARID == schoolYearId).Take(1).ToList();
            if (findTestScore.Count > 0)
            {
                try
                {
                    _QuanLyHocSinhEntities.TESTSCORES.Remove(findTestScore[0]);
                    
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }                
            }
            return false;
        }
        public bool RemoveListTestScore(string MSHS, string schoolYearId)
        {
            RemoveTestScore(MSHS, "Toan", 1, schoolYearId);
            RemoveTestScore(MSHS, "TiengViet", 1, schoolYearId);
            RemoveTestScore(MSHS, "TuNhien", 1, schoolYearId);
            RemoveTestScore(MSHS, "DaoDuc", 1, schoolYearId);
            RemoveTestScore(MSHS, "AnhVan", 1, schoolYearId);
            RemoveTestScore(MSHS, "TinHoc", 1, schoolYearId);
            RemoveTestScore(MSHS, "AmNhac", 1, schoolYearId);
            RemoveTestScore(MSHS, "Ve", 1, schoolYearId);

            RemoveTestScore(MSHS, "Toan", 2, schoolYearId);
            RemoveTestScore(MSHS, "TiengViet", 2, schoolYearId);
            RemoveTestScore(MSHS, "TuNhien", 2, schoolYearId);
            RemoveTestScore(MSHS, "DaoDuc", 2, schoolYearId);
            RemoveTestScore(MSHS, "AnhVan", 2, schoolYearId);
            RemoveTestScore(MSHS, "TinHoc", 2, schoolYearId);
            RemoveTestScore(MSHS, "AmNhac", 2, schoolYearId);
            RemoveTestScore(MSHS, "Ve", 2, schoolYearId);
            try
            {
                _QuanLyHocSinhEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
