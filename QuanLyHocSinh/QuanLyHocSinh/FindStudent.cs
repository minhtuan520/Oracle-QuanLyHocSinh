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
    public partial class FindStudent : Form
    {
        public static FindStudent instance;
        public static FindStudent Instance
        {
            get
            {
                if(instance==null||instance.IsDisposed)
                {
                    instance = new FindStudent();
                }
                return instance;

            }
        }

        public FindStudent()
        {
            InitializeComponent();           
        }
    }
}
