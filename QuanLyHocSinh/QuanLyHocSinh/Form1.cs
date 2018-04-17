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
    public partial class Form1 : Form
    {
        QuanLyHocSinhEntities QuanLyHocSinh = new QuanLyHocSinhEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ACCOUNT account = new ACCOUNT();
            account.USERNAME = txtbxUserName.Text;
            account.PASSWORD = txtbxPassWord.Text;
            if (radioHocSinh.Checked == true)
                account.IDTYPE = 0;
            else
            {
                account.IDTYPE = 1;
            }                        
            if (account.USERNAME == "" || account.PASSWORD == "")
                MessageBox.Show("Không được để trống tên đăng nhập và mật khẩu", "Thông báo");
            else
            {
                AccountController accountController = new AccountController();
                if (accountController.Login(account)==0)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai, vui lòng nhập lại", "Thông báo");
                }
                else
                    MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công", "Thông báo");
            }
        }
    }
}
