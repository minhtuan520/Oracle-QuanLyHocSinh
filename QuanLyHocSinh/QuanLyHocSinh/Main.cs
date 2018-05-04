﻿using System;
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
        string _username, _password;
        public Main()
        {
            InitializeComponent();

            // hide background of logo
            var a = PointToScreen(logoschool.Location);
            a = bunifuGradientPanel1.PointToClient(a);
            logoschool.Parent = bunifuGradientPanel1;
            logoschool.Location = a;
            logoschool.BackColor = Color.Transparent;

            //hide background of tittle
            var b = PointToScreen(titleSchool.Location);
            a = bunifuGradientPanel1.PointToClient(b);
            titleSchool.Parent = bunifuGradientPanel1;
            titleSchool.Location = a;
            titleSchool.BackColor = Color.Transparent;

            //hide background of Username
            var c = PointToScreen(labelName.Location);
            c = bunifuGradientPanel1.PointToClient(c);
            labelName.Parent = bunifuGradientPanel1;
            labelName.Location = c;
            labelName.BackColor = Color.Transparent;

            menuSystem.BackColor = Color.Transparent;
            
            SlidePanel.Visible=false;
        }

        public Main(string pusername, string ppassword)
        {
            this._username = pusername;
            this._password = ppassword;
                    
            InitializeComponent();
            labelName.Text = _username;
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
            SlidePanel.Visible = true;
            SlidePanel.Height = bntManageStudent.Height;
            SlidePanel.Top = bntManageStudent.Top;
            // delete other form
            foreach (Form frmMdiChidren in this.MdiChildren)
            {
                frmMdiChidren.Close();
            }

            if (!CheckExistForm("ManageStudent"))
            {
                ManageStudent frmManageStudent = new ManageStudent();
                frmManageStudent.TopLevel = false;                                            
                //this.Controls.Add(frmManageStudent);  
                frmManageStudent.MdiParent = this;
                frmManageStudent.Show();              
            }
            else
            {
                ActiveChildForm("ManageStudent");
            }
                
        }

        private void bntManageScore_Click(object sender, EventArgs e)
        {
            SlidePanel.Visible = true;
            SlidePanel.Height = bntManageScore.Height;
            SlidePanel.Top = bntManageScore.Top;
            // delete other form
            foreach (Form frmMdiChidren in this.MdiChildren)
            {
                frmMdiChidren.Close();
            }

            if (!CheckExistForm("ManageScore"))
            {
                ManageScore frmManageScore = new ManageScore();
                frmManageScore.TopLevel = false;
                //this.Controls.Add(frmManageScore);    
                //frmManageScore.Dock = DockStyle.Fill;           
                frmManageScore.MdiParent = this;
                
                frmManageScore.Show();
            }
            else
                ActiveChildForm("ManageScore");
        }

        private void bntManageConduct_Click(object sender, EventArgs e)
        {
            SlidePanel.Visible = true;
            SlidePanel.Height = bntManageConduct.Height;
            SlidePanel.Top = bntManageConduct.Top;
            // delete other form           

            if (!CheckExistForm("ManageConduct"))
            {
                ManageConduct frmManageConduct = new ManageConduct();
                frmManageConduct.TopLevel = false;
                frmManageConduct.MdiParent = this;
                frmManageConduct.Show();
            }
            else
                ActiveChildForm("ManageConduct");
        }
               
        

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemChangePassword_Click(object sender, EventArgs e)
        {
            foreach (Form frmMdiChidren in this.MdiChildren)
            {
                frmMdiChidren.Close();
            }

            if (!CheckExistForm("ChangePassword"))
            {
                ChangePassword frmChangePassword = new ChangePassword();
                frmChangePassword.MdiParent = this;
                frmChangePassword.Anchor = AnchorStyles.Left;
                frmChangePassword.Anchor = AnchorStyles.Top;
                frmChangePassword.Show();
            }
            else
            {
                ActiveChildForm("ChangePassword");
            }
            
        }

        private void ItemLogOut_Click(object sender, EventArgs e)
        {
            this.Close();    
            Login.ActiveForm.Show();            
        }
    }
}
