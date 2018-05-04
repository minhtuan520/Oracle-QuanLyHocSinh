using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocSinh.BLL;
using QuanLyHocSinh.DAL;

namespace QuanLyHocSinh
{
    public partial class ChangePassword : Form
    {
        string _Password, _Username ;

        public ChangePassword()
        {
            InitializeComponent();

            var a = PointToScreen(titleChangePassword.Location);
            a = bunifuGradientPanel1.PointToClient(a);
            titleChangePassword.Parent = bunifuGradientPanel1;
            titleChangePassword.Location = a;
            titleChangePassword.BackColor = Color.Transparent;
        }

        public ChangePassword(string pUsername,string pPassword)
        {
            this._Password = pPassword;
            this._Username = pUsername; 
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntChange_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtOldPassword.Text)|| String.IsNullOrEmpty(txtNewPassword.Text) || String.IsNullOrEmpty(txtComfirm.Text))
            {
                MessageBox.Show("Không được bỏ trống", "Thông báo");            
            }
            else if(txtOldPassword.Text.ToString()==txtNewPassword.Text.ToString())
            {
                MessageBox.Show("Mật khẩu mới không được giống mật khẩu cũ", "Thông báo");
            }
            else if(txtNewPassword.Text.ToString()!=txtComfirm.Text.ToString())
            {
                MessageBox.Show("Xác nhận không chính xác", "Thông báo");
            }
            else
            {
                AccountController accountController = new AccountController();
                ACCOUNT acc = new ACCOUNT();
                acc.USERNAME = _Username;
                acc.PASSWORD = _Password;
                if (accountController.CheckPassword(acc, txtOldPassword.Text.ToString(), txtNewPassword.Text.ToString())==0)
                {
                    MessageBox.Show("Mật khẩu cũ sai", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                }
            }

        }
        
    }
}
