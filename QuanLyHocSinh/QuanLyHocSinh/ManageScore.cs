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
    public partial class ManageScore : Form
    {
        public ManageScore()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            FindStudent frmFindStudent = new FindStudent();
            frmFindStudent.MdiParent = this.MdiParent;
            frmFindStudent.Show();
        }

        private void bntImport_Click(object sender, EventArgs e)
        {
            Import frmImport = new Import();
            frmImport.MdiParent = this.MdiParent;
            frmImport.Show();
        }
    }
}
