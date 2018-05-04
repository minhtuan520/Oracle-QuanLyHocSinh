namespace QuanLyHocSinh
{
    partial class ManageStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudent));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();

            //this.dataGridView1 = new System.Windows.Forms.DataGridView();

            this.GridStudent = new System.Windows.Forms.DataGridView();

            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bntInsert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bntExport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bntImport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bntUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bntPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bntDelete = new Bunifu.Framework.UI.BunifuFlatButton();

            this.bntSearch = new System.Windows.Forms.Button();

            this.MSHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIRTHDAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.radioNu = new System.Windows.Forms.RadioButton();

            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.GridStudent)).BeginInit();

            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bntSearch, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 601);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(62, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1059, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ HỌC SINH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(62, 93);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1059, 174);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioNu);
            this.groupBox1.Controls.Add(this.radioNam);
            this.groupBox1.Controls.Add(this.dateTimeBirthday);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 151);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin:";
            // 
            // dateTimeBirthday
            // 
            this.dateTimeBirthday.CustomFormat = "";
            this.dateTimeBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBirthday.Location = new System.Drawing.Point(114, 52);
            this.dateTimeBirthday.Name = "dateTimeBirthday";
            this.dateTimeBirthday.Size = new System.Drawing.Size(135, 22);
            this.dateTimeBirthday.TabIndex = 15;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(114, 110);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(135, 22);
            this.txtPhone.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(114, 81);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(310, 22);
            this.txtAddress.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(114, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 22);
            this.txtName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày Sinh: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giới Tính: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Điện Thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ Tên: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbClass);
            this.groupBox2.Controls.Add(this.cmbGrade);
            this.groupBox2.Controls.Add(this.cmbYear);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(691, 3);

            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 118);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khóa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Lớp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Khối:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Niên Khóa;";
            // 
            // cmbClass
            // 
            this.cmbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(90, 84);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(137, 24);
            this.cmbClass.TabIndex = 2;

            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);

            // 
            // cmbGrade
            // 
            this.cmbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(90, 52);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(137, 24);
            this.cmbGrade.TabIndex = 1;

            this.cmbGrade.SelectedIndexChanged += new System.EventHandler(this.cmbGrade_SelectedIndexChanged);

            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(90, 21);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(137, 24);
            this.cmbYear.TabIndex = 0;

            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);

            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.GridStudent, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(62, 273);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1059, 312);
            this.tableLayoutPanel3.TabIndex = 13;
            // 

            // dataGridView1
            //// 
            //this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            //this.dataGridView1.Name = "dataGridView1";
            //this.dataGridView1.Size = new System.Drawing.Size(788, 306);
            //this.dataGridView1.TabIndex = 4;

            // GridStudent
            // 
            this.GridStudent.AllowUserToAddRows = false;
            this.GridStudent.AllowUserToDeleteRows = false;
            this.GridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSHS,
            this.NAME,
            this.BIRTHDAY,
            this.ADDRESS,
            this.SEX,
            this.PHONE});
            this.GridStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridStudent.Location = new System.Drawing.Point(3, 3);
            this.GridStudent.Name = "GridStudent";
            this.GridStudent.ReadOnly = true;
            this.GridStudent.Size = new System.Drawing.Size(517, 295);
            this.GridStudent.TabIndex = 4;
            this.GridStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);

            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.bntInsert);
            this.groupBox3.Controls.Add(this.bntExport);
            this.groupBox3.Controls.Add(this.bntImport);
            this.groupBox3.Controls.Add(this.bntUpdate);
            this.groupBox3.Controls.Add(this.bntPrint);
            this.groupBox3.Controls.Add(this.bntDelete);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(856, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(141, 295);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng:";
            // 
            // bntInsert
            // 
            this.bntInsert.Activecolor = System.Drawing.Color.DarkCyan;
            this.bntInsert.BackColor = System.Drawing.Color.CadetBlue;
            this.bntInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntInsert.BorderRadius = 0;
            this.bntInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bntInsert.ButtonText = "  Thêm";
            this.bntInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntInsert.DisabledColor = System.Drawing.Color.Gray;
            this.bntInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntInsert.Iconcolor = System.Drawing.Color.Transparent;
            this.bntInsert.Iconimage = ((System.Drawing.Image)(resources.GetObject("bntInsert.Iconimage")));
            this.bntInsert.Iconimage_right = null;
            this.bntInsert.Iconimage_right_Selected = null;
            this.bntInsert.Iconimage_Selected = null;
            this.bntInsert.IconMarginLeft = 0;
            this.bntInsert.IconMarginRight = 0;
            this.bntInsert.IconRightVisible = true;
            this.bntInsert.IconRightZoom = 0D;
            this.bntInsert.IconVisible = true;
            this.bntInsert.IconZoom = 60D;
            this.bntInsert.IsTab = false;
            this.bntInsert.Location = new System.Drawing.Point(19, 28);
            this.bntInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntInsert.Name = "bntInsert";
            this.bntInsert.Normalcolor = System.Drawing.Color.CadetBlue;
            this.bntInsert.OnHovercolor = System.Drawing.Color.CadetBlue;
            this.bntInsert.OnHoverTextColor = System.Drawing.Color.Lavender;
            this.bntInsert.selected = false;
            this.bntInsert.Size = new System.Drawing.Size(116, 36);
            this.bntInsert.TabIndex = 5;
            this.bntInsert.Text = "  Thêm";
            this.bntInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntInsert.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bntInsert.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntInsert.Click += new System.EventHandler(this.bntInsert_Click);
            // 
            // bntExport
            // 
            this.bntExport.Activecolor = System.Drawing.Color.DarkCyan;
            this.bntExport.BackColor = System.Drawing.Color.CadetBlue;
            this.bntExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntExport.BorderRadius = 1;
            this.bntExport.ButtonText = "  Xuất";
            this.bntExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntExport.DisabledColor = System.Drawing.Color.Gray;
            this.bntExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bntExport.Location = new System.Drawing.Point(19, 236);
            this.bntExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntExport.Name = "bntExport";
            this.bntExport.Normalcolor = System.Drawing.Color.CadetBlue;
            this.bntExport.OnHovercolor = System.Drawing.Color.CadetBlue;
            this.bntExport.OnHoverTextColor = System.Drawing.Color.Lavender;
            this.bntExport.selected = false;
            this.bntExport.Size = new System.Drawing.Size(116, 36);
            this.bntExport.TabIndex = 4;
            this.bntExport.Text = "  Xuất";
            this.bntExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntExport.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bntExport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExport.Click += new System.EventHandler(this.bntExport_Click);
            // 
            // bntImport
            // 
            this.bntImport.Activecolor = System.Drawing.Color.DarkCyan;
            this.bntImport.BackColor = System.Drawing.Color.CadetBlue;
            this.bntImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntImport.BorderRadius = 1;
            this.bntImport.ButtonText = "  Nhập ";
            this.bntImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntImport.DisabledColor = System.Drawing.Color.Gray;
            this.bntImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntImport.Iconcolor = System.Drawing.Color.Transparent;
            this.bntImport.Iconimage = ((System.Drawing.Image)(resources.GetObject("bntImport.Iconimage")));
            this.bntImport.Iconimage_right = null;
            this.bntImport.Iconimage_right_Selected = null;
            this.bntImport.Iconimage_Selected = null;
            this.bntImport.IconMarginLeft = 0;
            this.bntImport.IconMarginRight = 0;
            this.bntImport.IconRightVisible = true;
            this.bntImport.IconRightZoom = 0D;
            this.bntImport.IconVisible = true;
            this.bntImport.IconZoom = 60D;
            this.bntImport.IsTab = false;
            this.bntImport.Location = new System.Drawing.Point(19, 194);
            this.bntImport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntImport.Name = "bntImport";
            this.bntImport.Normalcolor = System.Drawing.Color.CadetBlue;
            this.bntImport.OnHovercolor = System.Drawing.Color.CadetBlue;
            this.bntImport.OnHoverTextColor = System.Drawing.Color.Lavender;
            this.bntImport.selected = false;
            this.bntImport.Size = new System.Drawing.Size(116, 36);
            this.bntImport.TabIndex = 3;
            this.bntImport.Text = "  Nhập ";
            this.bntImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntImport.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bntImport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntImport.Click += new System.EventHandler(this.bntImport_Click);
            // 
            // bntUpdate
            // 
            this.bntUpdate.Activecolor = System.Drawing.Color.DarkCyan;
            this.bntUpdate.BackColor = System.Drawing.Color.CadetBlue;
            this.bntUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntUpdate.BorderRadius = 1;
            this.bntUpdate.ButtonText = "Cập Nhật";
            this.bntUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.bntUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.bntUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("bntUpdate.Iconimage")));
            this.bntUpdate.Iconimage_right = null;
            this.bntUpdate.Iconimage_right_Selected = null;
            this.bntUpdate.Iconimage_Selected = null;
            this.bntUpdate.IconMarginLeft = 0;
            this.bntUpdate.IconMarginRight = 0;
            this.bntUpdate.IconRightVisible = true;
            this.bntUpdate.IconRightZoom = 0D;
            this.bntUpdate.IconVisible = true;
            this.bntUpdate.IconZoom = 80D;
            this.bntUpdate.IsTab = false;
            this.bntUpdate.Location = new System.Drawing.Point(19, 110);
            this.bntUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntUpdate.Name = "bntUpdate";
            this.bntUpdate.Normalcolor = System.Drawing.Color.CadetBlue;
            this.bntUpdate.OnHovercolor = System.Drawing.Color.CadetBlue;
            this.bntUpdate.OnHoverTextColor = System.Drawing.Color.Lavender;
            this.bntUpdate.selected = false;
            this.bntUpdate.Size = new System.Drawing.Size(116, 36);
            this.bntUpdate.TabIndex = 2;
            this.bntUpdate.Text = "Cập Nhật";
            this.bntUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntUpdate.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bntUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bntPrint
            // 
            this.bntPrint.Activecolor = System.Drawing.Color.DarkCyan;
            this.bntPrint.BackColor = System.Drawing.Color.CadetBlue;
            this.bntPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntPrint.BorderRadius = 1;
            this.bntPrint.ButtonText = "  In";
            this.bntPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntPrint.DisabledColor = System.Drawing.Color.Gray;
            this.bntPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bntPrint.Location = new System.Drawing.Point(19, 152);
            this.bntPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntPrint.Name = "bntPrint";
            this.bntPrint.Normalcolor = System.Drawing.Color.CadetBlue;
            this.bntPrint.OnHovercolor = System.Drawing.Color.CadetBlue;
            this.bntPrint.OnHoverTextColor = System.Drawing.Color.Lavender;
            this.bntPrint.selected = false;
            this.bntPrint.Size = new System.Drawing.Size(116, 36);
            this.bntPrint.TabIndex = 1;
            this.bntPrint.Text = "  In";
            this.bntPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntPrint.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bntPrint.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPrint.Click += new System.EventHandler(this.bntPrint_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Activecolor = System.Drawing.Color.DarkCyan;
            this.bntDelete.BackColor = System.Drawing.Color.CadetBlue;
            this.bntDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntDelete.BorderRadius = 1;
            this.bntDelete.ButtonText = "  Xóa";
            this.bntDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntDelete.DisabledColor = System.Drawing.Color.Gray;
            this.bntDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.bntDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("bntDelete.Iconimage")));
            this.bntDelete.Iconimage_right = null;
            this.bntDelete.Iconimage_right_Selected = null;
            this.bntDelete.Iconimage_Selected = null;
            this.bntDelete.IconMarginLeft = 0;
            this.bntDelete.IconMarginRight = 0;
            this.bntDelete.IconRightVisible = true;
            this.bntDelete.IconRightZoom = 0D;
            this.bntDelete.IconVisible = true;
            this.bntDelete.IconZoom = 60D;
            this.bntDelete.IsTab = false;
            this.bntDelete.Location = new System.Drawing.Point(19, 68);
            this.bntDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Normalcolor = System.Drawing.Color.CadetBlue;
            this.bntDelete.OnHovercolor = System.Drawing.Color.CadetBlue;
            this.bntDelete.OnHoverTextColor = System.Drawing.Color.Lavender;
            this.bntDelete.selected = false;
            this.bntDelete.Size = new System.Drawing.Size(116, 36);
            this.bntDelete.TabIndex = 0;
            this.bntDelete.Text = "  Xóa";
            this.bntDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntDelete.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bntDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            // 
            // bntSearch
            // 
            this.bntSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.bntSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bntSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bntSearch.Location = new System.Drawing.Point(1127, 46);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(54, 41);
            this.bntSearch.TabIndex = 30;
            this.bntSearch.Text = "Tìm";
            this.bntSearch.UseVisualStyleBackColor = false;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);

            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // MSHS
            // 
            this.MSHS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MSHS.DataPropertyName = "MSHOCSINH";
            this.MSHS.HeaderText = "MSHS";
            this.MSHS.Name = "MSHS";
            this.MSHS.ReadOnly = true;
            // 
            // NAME
            // 
            this.NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "Họ và tên";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // BIRTHDAY
            // 
            this.BIRTHDAY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BIRTHDAY.DataPropertyName = "BIRTHDAY";
            this.BIRTHDAY.HeaderText = "Ngày sinh";
            this.BIRTHDAY.Name = "BIRTHDAY";
            this.BIRTHDAY.ReadOnly = true;
            // 
            // ADDRESS
            // 
            this.ADDRESS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ADDRESS.DataPropertyName = "ADDRESS";
            this.ADDRESS.HeaderText = "Địa chỉ";
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.ReadOnly = true;
            // 
            // SEX
            // 
            this.SEX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SEX.DataPropertyName = "SEX";
            this.SEX.HeaderText = "Giới tính";
            this.SEX.Name = "SEX";
            this.SEX.ReadOnly = true;
            // 
            // PHONE
            // 
            this.PHONE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PHONE.DataPropertyName = "PHONE";
            this.PHONE.HeaderText = "SDT";
            this.PHONE.Name = "PHONE";
            this.PHONE.ReadOnly = true;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Checked = true;
            this.radioNam.Location = new System.Drawing.Point(322, 49);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(61, 22);
            this.radioNam.TabIndex = 16;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Location = new System.Drawing.Point(383, 49);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(47, 22);
            this.radioNu.TabIndex = 17;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;

            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 601);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageStudent";
            this.Text = "ManageStudent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.GridStudent)).EndInit();

            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimeBirthday;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView GridStudent;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuFlatButton bntInsert;
        private Bunifu.Framework.UI.BunifuFlatButton bntExport;
        private Bunifu.Framework.UI.BunifuFlatButton bntImport;
        private Bunifu.Framework.UI.BunifuFlatButton bntUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton bntPrint;
        private Bunifu.Framework.UI.BunifuFlatButton bntDelete;

        private System.Windows.Forms.Button bntSearch;

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIRTHDAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEX;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.RadioButton radioNam;

    }
}