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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();

            var a = PointToScreen(titleChangePassword.Location);
            a = bunifuGradientPanel1.PointToClient(a);
            titleChangePassword.Parent = bunifuGradientPanel1;
            titleChangePassword.Location = a;
            titleChangePassword.BackColor = Color.Transparent;
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
