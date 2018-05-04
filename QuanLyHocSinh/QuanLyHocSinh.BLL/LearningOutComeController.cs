using QuanLyHocSinh.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.BLL
{
    public class LearningOutComeController
    {

        private QuanLyHocSinhEntities _QuanLyHocSinhEntities = new QuanLyHocSinhEntities();
        public bool createListLearningOutCome(string MSHS, string schoolYearId)
        {
            try
            {
                bool flag = addLearningOutCome("1", MSHS, schoolYearId);
                addLearningOutCome("2", MSHS, schoolYearId);
                addLearningOutCome("3", MSHS, schoolYearId);
                
                return true;
            }
            catch (Exception)
            {
                return false;        
            }
        }
        public bool addLearningOutCome(string typeResultId, string MSHS, string schoolYearId)
        {
            try
            {
                LEARNINGOUTCOMES learnningOutCome = new LEARNINGOUTCOMES();
                learnningOutCome.MSHOCSINH = MSHS;
                learnningOutCome.SCHOOLYEARID = schoolYearId;
                learnningOutCome.TYPERESULTID = typeResultId;
                learnningOutCome.LEARNINGOUTCOMESID = CreateLearnningOutComeID();
                _QuanLyHocSinhEntities.LEARNINGOUTCOMES.Add(learnningOutCome);
                _QuanLyHocSinhEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool removeListLearningOutCome(string MSHS, string schoolYearId)
        {
            try
            {
                removeLearningOutCome("1", MSHS, schoolYearId);
                removeLearningOutCome("2", MSHS, schoolYearId);
                removeLearningOutCome("3", MSHS, schoolYearId);
                _QuanLyHocSinhEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool removeLearningOutCome(string typeResultId, string MSHS, string schoolYearId)
        {
            var findLearningOutCome = _QuanLyHocSinhEntities.LEARNINGOUTCOMES.Where(l => l.TYPERESULTID == typeResultId && l.MSHOCSINH == MSHS && l.SCHOOLYEARID == schoolYearId).Take(1).ToList();
            if(findLearningOutCome.Count >0)
            {

                _QuanLyHocSinhEntities.LEARNINGOUTCOMES.Remove(findLearningOutCome[0]);
            }
            return true;
        }
        public string CreateLearnningOutComeID()
        {
            var number = _QuanLyHocSinhEntities.LEARNINGOUTCOMES.Count();
            string LearnningOutComeID = "";
            string baseString = "KQ";
            if (number < 10)
            {
                LearnningOutComeID = baseString + "000000" + (1+number);
            }
            else if (number < 100)
            {
                LearnningOutComeID = baseString + "00000" + (1+number );
            }
            else if (number < 1000)
            {
                LearnningOutComeID = baseString + "0000" + (1 + number);
            }
            else if (number < 10000)
            {
                LearnningOutComeID = baseString + "000" + (1 + number);
            }
            else if (number < 100000)
            {
                LearnningOutComeID = baseString + "00" + (1 + number);
            }
            else if (number < 1000000)
            {
                LearnningOutComeID = baseString + "0" + (1 + number);
            }
            return LearnningOutComeID;
        }
    }
}
