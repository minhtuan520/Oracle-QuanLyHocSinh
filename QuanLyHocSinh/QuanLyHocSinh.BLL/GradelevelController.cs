using QuanLyHocSinh.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.BLL
{
    public class GradelevelController
    {
        private QuanLyHocSinhEntities _QuanLyHocSinhEntities = new QuanLyHocSinhEntities();
        public List<GRADELEVEL> GetAll()
        {
            List<GRADELEVEL> results = _QuanLyHocSinhEntities.GRADELEVELS.ToList();
            return results;
        }
    }
}
