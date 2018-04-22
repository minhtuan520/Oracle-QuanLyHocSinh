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
            List<SCHOOLYEAR> results = _QuanLyHocSinhEntities.SCHOOLYEARS.ToList();
            return results;
        }
    }
}
