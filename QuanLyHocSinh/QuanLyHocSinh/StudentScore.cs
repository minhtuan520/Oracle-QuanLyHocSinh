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
    public partial class StudentScore : Form
    {
        string _username, _password;

        public StudentScore()
        {
            InitializeComponent();
            // hide background of logo
           var a = PointToScreen(picturelogo.Location);
            a = bunifuGradientPanel1.PointToClient(a);
            picturelogo.Parent = bunifuGradientPanel1;
            picturelogo.Location = a;
            picturelogo.BackColor = Color.Transparent;

          //hide background of tittle
            var b = PointToScreen(titleSchool.Location);
            a = bunifuGradientPanel1.PointToClient(b);
            titleSchool.Parent = bunifuGradientPanel1;           
            titleSchool.BackColor = Color.Transparent;

           //hide background of Username
            var c = PointToScreen(labelName.Location);
            c = bunifuGradientPanel1.PointToClient(c);
            labelName.Parent = bunifuGradientPanel1;            
            labelName.BackColor = Color.Transparent;

            menuStrip1.BackColor = Color.Transparent;
        }

        public StudentScore(string pusername, string ppassword)
        {
            this._username = pusername;
            this._password = ppassword;
            labelName.Text = pusername;
        }

        private void itemChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword frmChangePassword = new ChangePassword();
            frmChangePassword.MdiParent = this;
            frmChangePassword.Show();
        }

        private void itemLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.ActiveForm.Show();
        }
    }
}
