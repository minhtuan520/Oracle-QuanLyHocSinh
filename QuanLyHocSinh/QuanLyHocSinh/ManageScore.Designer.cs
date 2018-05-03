namespace QuanLyHocSinh
{
    partial class ManageScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageScore));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntInport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bntPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bntExport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bntSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.GridView_Diem = new System.Windows.Forms.DataGridView();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.MSHOCSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCORE_5M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCORE_15M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCORE_45M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCORE_MIDYEAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCORE_ENDYEAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDIUMSCORE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Diem)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.bunifuImageButton1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.GridView_Diem, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(767, 504);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(731, 39);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(33, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 16;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(41, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(684, 75);
            this.label7.TabIndex = 28;
            this.label7.Text = "QUẢN LÝ ĐIỂM";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(41, 78);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(684, 170);
            this.tableLayoutPanel2.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSemester);
            this.groupBox2.Controls.Add(this.cmbClass);
            this.groupBox2.Controls.Add(this.cmbSubject);
            this.groupBox2.Controls.Add(this.cmbGrade);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbYear);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 164);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Môn Học:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Học Kì:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Niên Khóa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Khối:";
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(96, 63);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(138, 24);
            this.cmbYear.TabIndex = 1;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntInport);
            this.groupBox1.Controls.Add(this.bntPrint);
            this.groupBox1.Controls.Add(this.bntExport);
            this.groupBox1.Controls.Add(this.bntSave);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(447, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 164);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng: ";
            // 
            // bntInport
            // 
            this.bntInport.Activecolor = System.Drawing.Color.DarkCyan;
            this.bntInport.BackColor = System.Drawing.Color.CadetBlue;
            this.bntInport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntInport.BorderRadius = 0;
            this.bntInport.ButtonText = "Nhập";
            this.bntInport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntInport.DisabledColor = System.Drawing.Color.Gray;
            this.bntInport.Iconcolor = System.Drawing.Color.Transparent;
            this.bntInport.Iconimage = ((System.Drawing.Image)(resources.GetObject("bntInport.Iconimage")));
            this.bntInport.Iconimage_right = null;
            this.bntInport.Iconimage_right_Selected = null;
            this.bntInport.Iconimage_Selected = null;
            this.bntInport.IconMarginLeft = 0;
            this.bntInport.IconMarginRight = 0;
            this.bntInport.IconRightVisible = true;
            this.bntInport.IconRightZoom = 0D;
            this.bntInport.IconVisible = true;
            this.bntInport.IconZoom = 60D;
            this.bntInport.IsTab = false;
            this.bntInport.Location = new System.Drawing.Point(8, 87);
            this.bntInport.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bntInport.Name = "bntInport";
            this.bntInport.Normalcolor = System.Drawing.Color.CadetBlue;
            this.bntInport.OnHovercolor = System.Drawing.Color.CadetBlue;
            this.bntInport.OnHoverTextColor = System.Drawing.Color.Lavender;
            this.bntInport.selected = false;
            this.bntInport.Size = new System.Drawing.Size(92, 53);
            this.bntInport.TabIndex = 13;
            this.bntInport.Text = "Nhập";
            this.bntInport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntInport.Textcolor = System.Drawing.Color.White;
            this.bntInport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bntPrint
            // 
            this.bntPrint.Activecolor = System.Drawing.Color.DarkCyan;
            this.bntPrint.BackColor = System.Drawing.Color.CadetBlue;
            this.bntPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntPrint.BorderRadius = 0;
            this.bntPrint.ButtonText = "In";
            this.bntPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntPrint.DisabledColor = System.Drawing.Color.Gray;
            this.bntPrint.Iconcolor = System.Drawing.Color.Transparent;
            this.bntPrint.Iconimage = ((System.Drawing.Image)(resources.GetObject("bntPrint.Iconimage")));
            this.bntPrint.Iconimage_right = null;
            this.bntPrint.Iconimage_right_Selected = null;
            this.bntPrint.Iconimage_Selected = null;
            this.bntPrint.IconMarginLeft = 0;
            this.bntPrint.IconMarginRight = 0;
            this.bntPrint.IconRightVisible = true;
            this.bntPrint.IconRightZoom = 0D;
            this.bntPrint.IconVisible = true;
            this.bntPrint.IconZoom = 60D;
            this.bntPrint.IsTab = false;
            this.bntPrint.Location = new System.Drawing.Point(117, 29);
            this.bntPrint.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bntPrint.Name = "bntPrint";
            this.bntPrint.Normalcolor = System.Drawing.Color.CadetBlue;
            this.bntPrint.OnHovercolor = System.Drawing.Color.CadetBlue;
            this.bntPrint.OnHoverTextColor = System.Drawing.Color.Lavender;
            this.bntPrint.selected = false;
            this.bntPrint.Size = new System.Drawing.Size(97, 53);
            this.bntPrint.TabIndex = 12;
            this.bntPrint.Text = "In";
            this.bntPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntPrint.Textcolor = System.Drawing.Color.White;
            this.bntPrint.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPrint.Click += new System.EventHandler(this.bntPrint_Click);
            // 
            // bntExport
            // 
            this.bntExport.Activecolor = System.Drawing.Color.DarkCyan;
            this.bntExport.BackColor = System.Drawing.Color.CadetBlue;
            this.bntExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntExport.BorderRadius = 0;
            this.bntExport.ButtonText = "Xuất";
            this.bntExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntExport.DisabledColor = System.Drawing.Color.Gray;
            this.bntExport.Iconcolor = System.Drawing.Color.Transparent;
            this.bntExport.Iconimage = ((System.Drawing.Image)(resources.GetObject("bntExport.Iconimage")));
            this.bntExport.Iconimage_right = null;
            this.bntExport.Iconimage_right_Selected = null;
            this.bntExport.Iconimage_Selected = null;
            this.bntExport.IconMarginLeft = 0;
            this.bntExport.IconMarginRight = 0;
            this.bntExport.IconRightVisible = true;
            this.bntExport.IconRightZoom = 0D;
            this.bntExport.IconVisible = true;
            this.bntExport.IconZoom = 60D;
            this.bntExport.IsTab = false;
            this.bntExport.Location = new System.Drawing.Point(117, 87);
            this.bntExport.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bntExport.Name = "bntExport";
            this.bntExport.Normalcolor = System.Drawing.Color.CadetBlue;
            this.bntExport.OnHovercolor = System.Drawing.Color.CadetBlue;
            this.bntExport.OnHoverTextColor = System.Drawing.Color.Lavender;
            this.bntExport.selected = false;
            this.bntExport.Size = new System.Drawing.Size(100, 54);
            this.bntExport.TabIndex = 27;
            this.bntExport.Text = "Xuất";
            this.bntExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntExport.Textcolor = System.Drawing.Color.White;
            this.bntExport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bntSave
            // 
            this.bntSave.Activecolor = System.Drawing.Color.DarkCyan;
            this.bntSave.BackColor = System.Drawing.Color.CadetBlue;
            this.bntSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntSave.BorderRadius = 0;
            this.bntSave.ButtonText = "Lưu";
            this.bntSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSave.DisabledColor = System.Drawing.Color.Gray;
            this.bntSave.Iconcolor = System.Drawing.Color.Transparent;
            this.bntSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("bntSave.Iconimage")));
            this.bntSave.Iconimage_right = null;
            this.bntSave.Iconimage_right_Selected = null;
            this.bntSave.Iconimage_Selected = null;
            this.bntSave.IconMarginLeft = 0;
            this.bntSave.IconMarginRight = 0;
            this.bntSave.IconRightVisible = true;
            this.bntSave.IconRightZoom = 0D;
            this.bntSave.IconVisible = true;
            this.bntSave.IconZoom = 60D;
            this.bntSave.IsTab = false;
            this.bntSave.Location = new System.Drawing.Point(8, 29);
            this.bntSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bntSave.Name = "bntSave";
            this.bntSave.Normalcolor = System.Drawing.Color.CadetBlue;
            this.bntSave.OnHovercolor = System.Drawing.Color.CadetBlue;
            this.bntSave.OnHoverTextColor = System.Drawing.Color.Lavender;
            this.bntSave.selected = false;
            this.bntSave.Size = new System.Drawing.Size(92, 53);
            this.bntSave.TabIndex = 9;
            this.bntSave.Text = "Lưu";
            this.bntSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSave.Textcolor = System.Drawing.Color.White;
            this.bntSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // GridView_Diem
            // 
            this.GridView_Diem.AllowUserToAddRows = false;
            this.GridView_Diem.AllowUserToDeleteRows = false;
            this.GridView_Diem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Diem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSHOCSINH,
            this.NAME,
            this.SCORE_5M,
            this.SCORE_15M,
            this.SCORE_45M,
            this.SCORE_MIDYEAR,
            this.SCORE_ENDYEAR,
            this.MEDIUMSCORE});
            this.GridView_Diem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView_Diem.Location = new System.Drawing.Point(41, 254);
            this.GridView_Diem.Name = "GridView_Diem";
            this.GridView_Diem.Size = new System.Drawing.Size(684, 247);
            this.GridView_Diem.TabIndex = 31;
            // 
            // cmbGrade
            // 
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(96, 31);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(138, 26);
            this.cmbGrade.TabIndex = 16;
            this.cmbGrade.SelectedIndexChanged += new System.EventHandler(this.cmbGrade_SelectedIndexChanged);
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(96, 93);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(138, 26);
            this.cmbSubject.TabIndex = 17;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(303, 31);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(134, 26);
            this.cmbClass.TabIndex = 18;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(302, 63);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(135, 26);
            this.cmbSemester.TabIndex = 23;
            this.cmbSemester.SelectedIndexChanged += new System.EventHandler(this.cmbSemester_SelectedIndexChanged);
            // 
            // MSHOCSINH
            // 
            this.MSHOCSINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MSHOCSINH.DataPropertyName = "MSHOCSINH";
            this.MSHOCSINH.HeaderText = "MSHS";
            this.MSHOCSINH.Name = "MSHOCSINH";
            this.MSHOCSINH.ReadOnly = true;
            // 
            // NAME
            // 
            this.NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "Họ và tên";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // SCORE_5M
            // 
            this.SCORE_5M.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SCORE_5M.DataPropertyName = "SCORE_5M";
            this.SCORE_5M.HeaderText = "5 phút";
            this.SCORE_5M.Name = "SCORE_5M";
            // 
            // SCORE_15M
            // 
            this.SCORE_15M.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SCORE_15M.DataPropertyName = "SCORE_15M";
            this.SCORE_15M.HeaderText = "15 phút";
            this.SCORE_15M.Name = "SCORE_15M";
            // 
            // SCORE_45M
            // 
            this.SCORE_45M.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SCORE_45M.DataPropertyName = "SCORE_45M";
            this.SCORE_45M.HeaderText = "45 phút";
            this.SCORE_45M.Name = "SCORE_45M";
            // 
            // SCORE_MIDYEAR
            // 
            this.SCORE_MIDYEAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SCORE_MIDYEAR.DataPropertyName = "SCORE_MIDYEAR";
            this.SCORE_MIDYEAR.HeaderText = "Giữa kỳ";
            this.SCORE_MIDYEAR.Name = "SCORE_MIDYEAR";
            // 
            // SCORE_ENDYEAR
            // 
            this.SCORE_ENDYEAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SCORE_ENDYEAR.DataPropertyName = "SCORE_ENDYEAR";
            this.SCORE_ENDYEAR.HeaderText = "Cuối kỳ";
            this.SCORE_ENDYEAR.Name = "SCORE_ENDYEAR";
            // 
            // MEDIUMSCORE
            // 
            this.MEDIUMSCORE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MEDIUMSCORE.DataPropertyName = "MEDIUMSCORE";
            this.MEDIUMSCORE.HeaderText = "Trung bình";
            this.MEDIUMSCORE.Name = "MEDIUMSCORE";
            this.MEDIUMSCORE.ReadOnly = true;
            // 
            // ManageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 504);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageScore";
            this.Text = "ManageScore";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageScore_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Diem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bntInport;
        private Bunifu.Framework.UI.BunifuFlatButton bntPrint;
        private Bunifu.Framework.UI.BunifuFlatButton bntExport;
        private Bunifu.Framework.UI.BunifuFlatButton bntSave;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.DataGridView GridView_Diem;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSHOCSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCORE_5M;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCORE_15M;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCORE_45M;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCORE_MIDYEAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCORE_ENDYEAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDIUMSCORE;
    }
}