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
            List<SUBJECT> results = _QuanLyHocSinhEntities.SUBJECT.ToList();
            return results;
        }
        public string GetId(string subjectName)
        {
            var results = _QuanLyHocSinhEntities.SUBJECT.Where(s => s.NAME == subjectName).Select(s => s.SUBJECTID).Take(1).ToList();
            return results[0];
        }
    }
}
