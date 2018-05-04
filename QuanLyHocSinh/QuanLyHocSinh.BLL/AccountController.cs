using QuanLyHocSinh.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        public bool CreateAccount(string Username)
        {           
            try
            {
                MD5 cryp = new MD5CryptoServiceProvider();
                ACCOUNT account = new ACCOUNT();
                account.USERNAME = Username;
                //var xxx = Encoding.ASCII.GetBytes(Username);
                //var xxxxxxx = cryp.ComputeHash(xxx);

                account.PASSWORD = Username;//defaul password
                account.IDTYPE = 0;
                _QuanLyHocSinhEntities.ACCOUNT.Add(account);
                _QuanLyHocSinhEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;                
            }
        }
        public bool RemoveAccount(string Username)
        {
            try
            {
                var findAccount = _QuanLyHocSinhEntities.ACCOUNT.Where(ac => ac.USERNAME == Username).Take(1).ToList();
                if (findAccount.Count > 0)
                {
                    _QuanLyHocSinhEntities.ACCOUNT.Remove(findAccount[0]);
                    _QuanLyHocSinhEntities.SaveChanges();                    
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
