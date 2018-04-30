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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            var a = PointToScreen(logoschool.Location);
            a = bunifuGradientPanel1.PointToClient(a);
            logoschool.Parent = bunifuGradientPanel1;
            logoschool.Location = a;
            logoschool.BackColor = Color.Transparent;

            var b = PointToScreen(titleSchool.Location);
            a = bunifuGradientPanel1.PointToClient(b);
            titleSchool.Parent = bunifuGradientPanel1;
            titleSchool.Location = a;
            titleSchool.BackColor = Color.Transparent;

            panel1.Height = bntManageStudent.Height;
            panel1.Top = bntManageStudent.Top;
        }

        private bool CheckExistForm(String name)
        {
            bool check = false;
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name==name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void ActiveChildForm(string name)
        {
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name==name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void bntManageStudent_Click(object sender, EventArgs e)
        {
            panel1.Height = bntManageStudent.Height;
            panel1.Top = bntManageStudent.Top;

            if (!CheckExistForm("ManageStudent"))
            {
                ManageStudent frmManageStudent = new ManageStudent();
                frmManageStudent.MdiParent = this;
                frmManageStudent.Show();
            }
            else
                ActiveChildForm("ManageStudent");
        }

        private void bntManageScore_Click(object sender, EventArgs e)
        {
            panel1.Height = bntManageScore.Height;
            panel1.Top = bntManageScore.Top;

            if (!CheckExistForm("ManageScore"))
            {
                ManageScore frmManageScore = new ManageScore();
                frmManageScore.MdiParent = this;
                frmManageScore.Show();
            }
            else
                ActiveChildForm("ManageScore");
        }

        private void bntManageConduct_Click(object sender, EventArgs e)
        {
            panel1.Height = bntManageConduct.Height;
            panel1.Top = bntManageConduct.Top;

            if (!CheckExistForm("ManageConduct"))
            {
                ManageConduct frmManageConduct = new ManageConduct();
                frmManageConduct.MdiParent = this;
                frmManageConduct.Show();
            }
            else
                ActiveChildForm("ManageConduct");
        }

        private void bntChangePassword_Click(object sender, EventArgs e)
        {
            panel1.Height = bntChangePassword.Height;
            panel1.Top = bntChangePassword.Top;

            if (!CheckExistForm("ChangePassword"))
            {
                ChangePassword frmChangePassword = new ChangePassword();
                frmChangePassword.MdiParent = this;
                frmChangePassword.Show();
            }
            else
                ActiveChildForm("ChangePassword");
        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            panel1.Height = bntSearch.Height;
            panel1.Top = bntSearch.Top;

            if (!CheckExistForm("FindStudent"))
            {
                FindStudent frmFindStudent = new FindStudent();
                frmFindStudent.MdiParent = this;
                frmFindStudent.Show();
            }
            else
                ActiveChildForm("FindStudent");
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
