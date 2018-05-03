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
        public string GetID(string schoolYearName)
        {
            var results = _QuanLyHocSinhEntities.SCHOOLYEAR.Where(s => s.NAME == schoolYearName).Select(s => s.SCHOOLYEARID).Take(1).ToList();
            return results[0];
        }
    }
}
