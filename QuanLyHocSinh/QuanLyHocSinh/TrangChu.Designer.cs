namespace QuanLyHocSinh
{
    partial class TrangChu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.QuanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hocSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hanhKiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoiPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuanLyToolStripMenuItem,
            this.xemDiemToolStripMenuItem,
            this.xemThongTinToolStripMenuItem,
            this.DoiPasswordToolStripMenuItem,
            this.DangXuatToolStripMenuItem,
            this.ThoatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // QuanLyToolStripMenuItem
            // 
            this.QuanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hocSinhToolStripMenuItem,
            this.DiemToolStripMenuItem,
            this.hanhKiemToolStripMenuItem});
            this.QuanLyToolStripMenuItem.Name = "QuanLyToolStripMenuItem";
            this.QuanLyToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.QuanLyToolStripMenuItem.Text = "Quản lý";
            // 
            // hocSinhToolStripMenuItem
            // 
            this.hocSinhToolStripMenuItem.Name = "hocSinhToolStripMenuItem";
            this.hocSinhToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hocSinhToolStripMenuItem.Text = "Học sinh";
            this.hocSinhToolStripMenuItem.Click += new System.EventHandler(this.hocSinhToolStripMenuItem_Click);
            // 
            // DiemToolStripMenuItem
            // 
            this.DiemToolStripMenuItem.Name = "DiemToolStripMenuItem";
            this.DiemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DiemToolStripMenuItem.Text = "Điểm";
            this.DiemToolStripMenuItem.Click += new System.EventHandler(this.DiemToolStripMenuItem_Click);
            // 
            // hanhKiemToolStripMenuItem
            // 
            this.hanhKiemToolStripMenuItem.Name = "hanhKiemToolStripMenuItem";
            this.hanhKiemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hanhKiemToolStripMenuItem.Text = "Hạnh kiểm";
            this.hanhKiemToolStripMenuItem.Click += new System.EventHandler(this.hanhKiemToolStripMenuItem_Click);
            // 
            // xemDiemToolStripMenuItem
            // 
            this.xemDiemToolStripMenuItem.Name = "xemDiemToolStripMenuItem";
            this.xemDiemToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.xemDiemToolStripMenuItem.Text = "Xem điểm";
            this.xemDiemToolStripMenuItem.Click += new System.EventHandler(this.xemDiemToolStripMenuItem_Click);
            // 
            // xemThongTinToolStripMenuItem
            // 
            this.xemThongTinToolStripMenuItem.Name = "xemThongTinToolStripMenuItem";
            this.xemThongTinToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.xemThongTinToolStripMenuItem.Text = "Xem thông tin";
            // 
            // DoiPasswordToolStripMenuItem
            // 
            this.DoiPasswordToolStripMenuItem.Name = "DoiPasswordToolStripMenuItem";
            this.DoiPasswordToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.DoiPasswordToolStripMenuItem.Text = "Đổi password";
            this.DoiPasswordToolStripMenuItem.Click += new System.EventHandler(this.DoiPasswordToolStripMenuItem_Click);
            // 
            // DangXuatToolStripMenuItem
            // 
            this.DangXuatToolStripMenuItem.Name = "DangXuatToolStripMenuItem";
            this.DangXuatToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.DangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.DangXuatToolStripMenuItem.Click += new System.EventHandler(this.DangXuatToolStripMenuItem_Click);
            // 
            // ThoatToolStripMenuItem
            // 
            this.ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem";
            this.ThoatToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ThoatToolStripMenuItem.Text = "Thoát";
            this.ThoatToolStripMenuItem.Click += new System.EventHandler(this.ThoatToolStripMenuItem_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 279);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TrangChu";
            this.Text = "TrangChu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem QuanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hocSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hanhKiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemDiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThongTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoiPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThoatToolStripMenuItem;
    }
}