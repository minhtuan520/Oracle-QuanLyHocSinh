using QuanLyHocSinh.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.BLL
{
    public class SubjectController
    {
        private QuanLyHocSinhEntities _QuanLyHocSinhEntities = new QuanLyHocSinhEntities();
        public List<SUBJECT> GetAll()
        {
            List<SUBJECT> results = _QuanLyHocSinhEntities.SUBJECTS.ToList();
            return results;
        }
    }
}
