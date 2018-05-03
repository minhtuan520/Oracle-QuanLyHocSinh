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
            this.SlidePanel = new System.Windows.Forms.Panel();
            this.bntManageConduct = new System.Windows.Forms.Button();
            this.bntManageScore = new System.Windows.Forms.Button();
            this.bntManageStudent = new System.Windows.Forms.Button();
            this.logoschool = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.titleSchool = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoschool)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.SlidePanel);
            this.bunifuGradientPanel2.Controls.Add(this.bntManageConduct);
            this.bunifuGradientPanel2.Controls.Add(this.bntManageScore);
            this.bunifuGradientPanel2.Controls.Add(this.bntManageStudent);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.SystemColors.HotTrack;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.SteelBlue;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 92);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(179, 483);
            this.bunifuGradientPanel2.TabIndex = 0;
            // 
            // SlidePanel
            // 
            this.SlidePanel.BackColor = System.Drawing.Color.Navy;
            this.SlidePanel.Location = new System.Drawing.Point(3, 3);
            this.SlidePanel.Name = "SlidePanel";
            this.SlidePanel.Size = new System.Drawing.Size(10, 43);
            this.SlidePanel.TabIndex = 2;
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
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystem});
            this.menuStrip1.Location = new System.Drawing.Point(727, 63);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(36, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSystem
            // 
            this.menuSystem.BackColor = System.Drawing.Color.Lavender;
            this.menuSystem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemChangePassword,
            this.ItemLogOut});
            this.menuSystem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuSystem.Image = ((System.Drawing.Image)(resources.GetObject("menuSystem.Image")));
            this.menuSystem.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.menuSystem.ImageTransparentColor = System.Drawing.Color.DarkRed;
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.Size = new System.Drawing.Size(28, 20);
            // 
            // ItemChangePassword
            // 
            this.ItemChangePassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ItemChangePassword.Name = "ItemChangePassword";
            this.ItemChangePassword.Size = new System.Drawing.Size(160, 22);
            this.ItemChangePassword.Text = "Đổi Password";
            this.ItemChangePassword.Click += new System.EventHandler(this.ItemChangePassword_Click);
            // 
            // ItemLogOut
            // 
            this.ItemLogOut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ItemLogOut.Name = "ItemLogOut";
            this.ItemLogOut.Size = new System.Drawing.Size(160, 22);
            this.ItemLogOut.Text = "Đăng Xuất";
            this.ItemLogOut.Click += new System.EventHandler(this.ItemLogOut_Click);
            // 
            // titleSchool
            // 
            this.titleSchool.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleSchool.AutoSize = true;
            this.titleSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSchool.Location = new System.Drawing.Point(308, 22);
            this.titleSchool.Name = "titleSchool";
            this.titleSchool.Size = new System.Drawing.Size(382, 42);
            this.titleSchool.TabIndex = 1;
            this.titleSchool.Text = "TRƯỜNG TIỂU HỌC";
            this.titleSchool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleSchool.UseMnemonic = false;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelName.Location = new System.Drawing.Point(606, 69);
            this.labelName.Name = "labelName";
            this.labelName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelName.Size = new System.Drawing.Size(118, 18);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Tên đăng nhập";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.labelName);
            this.bunifuGradientPanel1.Controls.Add(this.titleSchool);
            this.bunifuGradientPanel1.Controls.Add(this.menuStrip1);
            this.bunifuGradientPanel1.Controls.Add(this.logoschool);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.SystemColors.HotTrack;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SteelBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(763, 92);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(763, 575);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoschool)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Button bntManageConduct;
        private System.Windows.Forms.Button bntManageScore;
        private System.Windows.Forms.Button bntManageStudent;
        private System.Windows.Forms.Panel SlidePanel;
        private System.Windows.Forms.PictureBox logoschool;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem ItemChangePassword;
        private System.Windows.Forms.ToolStripMenuItem ItemLogOut;
        private System.Windows.Forms.Label titleSchool;
        private System.Windows.Forms.Label labelName;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
    }
}