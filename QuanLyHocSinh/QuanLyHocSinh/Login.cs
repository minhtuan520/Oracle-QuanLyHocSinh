using QuanLyHocSinh.BLL;
using QuanLyHocSinh.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
            var a = PointToScreen(titleLogin.Location);
            a = bunifuGradientPanel1.PointToClient(a);
            titleLogin.Parent = bunifuGradientPanel1;
            titleLogin.Location = a;
            titleLogin.BackColor = Color.Transparent;

            
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            ACCOUNT account = new ACCOUNT();
            account.USERNAME = txtUsername.Text;
            account.PASSWORD = txtPassword.Text;
            if (radioHocSinh.Checked == true)
                account.IDTYPE = 0;
            else
            {
                account.IDTYPE = 1;
            }
            if (account.USERNAME == string.Empty || account.PASSWORD == string.Empty)
                MessageBox.Show("Không được để trống tên đăng nhập và mật khẩu", "Thông báo");
            else
            {
                AccountController accountController = new AccountController();
                if (accountController.Login(account) == 0)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai, vui lòng nhập lại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công", "Thông báo");
                    ChangePassword frmChangePassword = new ChangePassword(txtUsername.Text.ToString(), txtPassword.Text.ToString());
                    if(account.IDTYPE==1)
                    {
                        Main frmMain = new Main();                        
                        frmMain.Show();
                    }
                    else
                    {
                        StudentScore frmStudedntScore = new StudentScore();
                        frmStudedntScore.Show();
                    }
                    
                }
            }
        }        
    }
}
