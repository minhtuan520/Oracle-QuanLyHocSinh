using QuanLyHocSinh.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.BLL
{
    public class SemesterController
    {
        private QuanLyHocSinhEntities _QuanLyHocSinhEntities = new QuanLyHocSinhEntities();
        public List<SEMESTER> GetAll()
        {
            List<SEMESTER> results = _QuanLyHocSinhEntities.SEMESTERS.ToList();
            return results;
        }
    }
}
