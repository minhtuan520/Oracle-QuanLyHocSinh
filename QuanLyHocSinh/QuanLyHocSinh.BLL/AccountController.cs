using QuanLyHocSinh.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.BLL
{
    public class AccountController
    {
        private QuanLyHocSinhEntities _QuanLyHocSinhEntities = new QuanLyHocSinhEntities();
        public int Login(ACCOUNT account)
        {
            if (account.USERNAME == null || account.PASSWORD == null || account.IDTYPE == null)//check null value             
                return 0;
            else
            {
                var accountExist = _QuanLyHocSinhEntities.ACCOUNT.Where(ac => ac.USERNAME == account.USERNAME && ac.PASSWORD == account.PASSWORD).Take(1).ToList();//find object correct username and password
                if (accountExist.Count == 0 || accountExist[0].IDTYPE != account.IDTYPE) //check (find object and idtype correct)
                    return 0;
            }
            return 1;
        } 
        public bool CheckPassword(ACCOUNT acc,string oldPassword, string newPassword)
        {
            return true;
        }    
    }
}
