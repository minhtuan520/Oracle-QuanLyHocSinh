using QuanLyHocSinh.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.BLL
{
    public class ClassController
    {
        private QuanLyHocSinhEntities _QuanLyHocSinhEntities = new QuanLyHocSinhEntities();
        public List<CLASS> GetAll()
        {
            List<CLASS> results = _QuanLyHocSinhEntities.CLASS.ToList();
            return results;
        }
    }
}
