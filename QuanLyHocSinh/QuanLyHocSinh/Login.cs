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
    }
}
