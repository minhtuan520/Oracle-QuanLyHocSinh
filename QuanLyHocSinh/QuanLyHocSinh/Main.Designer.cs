namespace QuanLyHocSinh
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bntManageStudent = new System.Windows.Forms.Button();
            this.bntManageScore = new System.Windows.Forms.Button();
            this.bntManageConduct = new System.Windows.Forms.Button();
            this.bntSearch = new System.Windows.Forms.Button();
            this.bntChangePassword = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoschool = new System.Windows.Forms.PictureBox();
            this.titleSchool = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoschool)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.panel1);
            this.bunifuGradientPanel2.Controls.Add(this.bntSearch);
            this.bunifuGradientPanel2.Controls.Add(this.bntExit);
            this.bunifuGradientPanel2.Controls.Add(this.bntManageConduct);
            this.bunifuGradientPanel2.Controls.Add(this.bntChangePassword);
            this.bunifuGradientPanel2.Controls.Add(this.bntManageScore);
            this.bunifuGradientPanel2.Controls.Add(this.bntManageStudent);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.SystemColors.HotTrack;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.SteelBlue;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 87);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(179, 488);
            this.bunifuGradientPanel2.TabIndex = 0;
            // 
            // bntManageStudent
            // 
            this.bntManageStudent.BackColor = System.Drawing.Color.SteelBlue;
            this.bntManageStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntManageStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bntManageStudent.Location = new System.Drawing.Point(0, 0);
            this.bntManageStudent.Name = "bntManageStudent";
            this.bntManageStudent.Size = new System.Drawing.Size(179, 46);
            this.bntManageStudent.TabIndex = 0;
            this.bntManageStudent.Text = "Quản Lý Học Sinh";
            this.bntManageStudent.UseVisualStyleBackColor = false;
            this.bntManageStudent.Click += new System.EventHandler(this.bntManageStudent_Click);
            // 
            // bntManageScore
            // 
            this.bntManageScore.BackColor = System.Drawing.Color.SteelBlue;
            this.bntManageScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntManageScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bntManageScore.Location = new System.Drawing.Point(0, 44);
            this.bntManageScore.Name = "bntManageScore";
            this.bntManageScore.Size = new System.Drawing.Size(179, 46);
            this.bntManageScore.TabIndex = 1;
            this.bntManageScore.Text = "Quản Lý Điểm";
            this.bntManageScore.UseVisualStyleBackColor = false;
            this.bntManageScore.Click += new System.EventHandler(this.bntManageScore_Click);
            // 
            // bntManageConduct
            // 
            this.bntManageConduct.BackColor = System.Drawing.Color.SteelBlue;
            this.bntManageConduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntManageConduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bntManageConduct.Location = new System.Drawing.Point(0, 87);
            this.bntManageConduct.Name = "bntManageConduct";
            this.bntManageConduct.Size = new System.Drawing.Size(179, 46);
            this.bntManageConduct.TabIndex = 2;
            this.bntManageConduct.Text = "Quản Lý Hạnh Kiểm";
            this.bntManageConduct.UseVisualStyleBackColor = false;
            this.bntManageConduct.Click += new System.EventHandler(this.bntManageConduct_Click);
            // 
            // bntSearch
            // 
            this.bntSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.bntSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bntSearch.Location = new System.Drawing.Point(0, 175);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(179, 46);
            this.bntSearch.TabIndex = 3;
            this.bntSearch.Text = "Tìm Kiếm";
            this.bntSearch.UseVisualStyleBackColor = false;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // bntChangePassword
            // 
            this.bntChangePassword.BackColor = System.Drawing.Color.SteelBlue;
            this.bntChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bntChangePassword.Location = new System.Drawing.Point(0, 131);
            this.bntChangePassword.Name = "bntChangePassword";
            this.bntChangePassword.Size = new System.Drawing.Size(179, 46);
            this.bntChangePassword.TabIndex = 4;
            this.bntChangePassword.Text = "Đổi Mật Khẩu";
            this.bntChangePassword.UseVisualStyleBackColor = false;
            this.bntChangePassword.Click += new System.EventHandler(this.bntChangePassword_Click);
            // 
            // bntExit
            // 
            this.bntExit.BackColor = System.Drawing.Color.SteelBlue;
            this.bntExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bntExit.Location = new System.Drawing.Point(0, 218);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(179, 46);
            this.bntExit.TabIndex = 6;
            this.bntExit.Text = "Thoát";
            this.bntExit.UseVisualStyleBackColor = false;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 43);
            this.panel1.TabIndex = 2;
            // 
            // logoschool
            // 
            this.logoschool.Image = ((System.Drawing.Image)(resources.GetObject("logoschool.Image")));
            this.logoschool.Location = new System.Drawing.Point(5, -14);
            this.logoschool.Name = "logoschool";
            this.logoschool.Size = new System.Drawing.Size(122, 117);
            this.logoschool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoschool.TabIndex = 0;
            this.logoschool.TabStop = false;
            // 
            // titleSchool
            // 
            this.titleSchool.AutoSize = true;
            this.titleSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSchool.Location = new System.Drawing.Point(308, 22);
            this.titleSchool.Name = "titleSchool";
            this.titleSchool.Size = new System.Drawing.Size(332, 37);
            this.titleSchool.TabIndex = 1;
            this.titleSchool.Text = "TRƯỜNG TIỂU HỌC";
            this.titleSchool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleSchool.UseMnemonic = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.titleSchool);
            this.bunifuGradientPanel1.Controls.Add(this.logoschool);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.SystemColors.HotTrack;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SteelBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(763, 87);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 575);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Main";
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoschool)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.Button bntManageConduct;
        private System.Windows.Forms.Button bntChangePassword;
        private System.Windows.Forms.Button bntManageScore;
        private System.Windows.Forms.Button bntManageStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logoschool;
        private System.Windows.Forms.Label titleSchool;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
    }
}