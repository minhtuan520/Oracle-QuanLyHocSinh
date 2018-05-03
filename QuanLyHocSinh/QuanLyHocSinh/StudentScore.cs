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
            var c = PointToScreen(label2.Location);
            c = bunifuGradientPanel1.PointToClient(c);
            label2.Parent = bunifuGradientPanel1;            
            label2.BackColor = Color.Transparent;

            menuStrip1.BackColor = Color.Transparent;
        }
    }
}
