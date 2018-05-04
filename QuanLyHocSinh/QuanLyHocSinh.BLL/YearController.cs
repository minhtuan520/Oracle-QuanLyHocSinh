using QuanLyHocSinh.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.BLL
{
    public class YearController
    {
        private QuanLyHocSinhEntities _QuanLyHocSinhEntities = new QuanLyHocSinhEntities();
        public List<SCHOOLYEAR> GetAll()
        {
            List<SCHOOLYEAR> results = _QuanLyHocSinhEntities.SCHOOLYEAR.ToList();
            return results;
        }
        public List<SCHOOLYEAR> GetListYear(string MSHS)
        {
            List<SCHOOLYEAR> results = new List<SCHOOLYEAR>();
            var findListCLass = _QuanLyHocSinhEntities.STUDENTINCLASS.Where(c => c.MSHOCSINH == MSHS).ToList();
            if (findListCLass.Count > 0)
            {
                for (int i = 0; i < findListCLass.Count; i++)
                {
                    string schoolYearId = findListCLass[i].SCHOOLYEARID;
                    var findYear = _QuanLyHocSinhEntities.SCHOOLYEAR.Where(y => y.SCHOOLYEARID == schoolYearId).Take(1).ToList();
                    if (findYear.Count > 0)
                    {
                        results.Add(findYear[0]);
                    }
                }
                
            }

            return results;
        }
        public bool AddYear(string schoolYearName)
        {
            SCHOOLYEAR schoolYear = new SCHOOLYEAR();
            int dem = _QuanLyHocSinhEntities.SCHOOLYEAR.Count();
            schoolYear.SCHOOLYEARID = schoolYearName.Substring(0, 4);
            schoolYear.NAME = schoolYearName;
            _QuanLyHocSinhEntities.SCHOOLYEAR.Add(schoolYear);
            _QuanLyHocSinhEntities.SaveChanges();
            return true;
        }
        public string GetID(string schoolYearName)
        {
            var results = _QuanLyHocSinhEntities.SCHOOLYEAR.Where(s => s.NAME == schoolYearName).Select(s => s.SCHOOLYEARID).Take(1).ToList();
            if (results.Count == 0)
                return null;
            return results[0];
        }
    }
}
