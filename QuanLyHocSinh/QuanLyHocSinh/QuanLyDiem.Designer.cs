namespace QuanLyHocSinh
{
    partial class QuanLyDiem
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
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.bntPrint = new System.Windows.Forms.Button();
            this.bntSave = new System.Windows.Forms.Button();
            this.GridView_Diem = new System.Windows.Forms.DataGridView();
            this.MSHOCSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCORE_5M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCORE_15M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCORE_45M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCORE_MIDYEAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCORE_ENDYEAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDIUMSCORE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Diem)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "HỌC KỲ:";
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(506, 123);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(159, 21);
            this.cmbSemester.TabIndex = 22;
            this.cmbSemester.SelectedIndexChanged += new System.EventHandler(this.cmbSemester_SelectedIndexChanged);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(552, 392);
            this.bntPrint.Name = "bntPrint";
            this.bntPrint.Size = new System.Drawing.Size(113, 37);
            this.bntPrint.TabIndex = 21;
            this.bntPrint.Text = "IN";
            this.bntPrint.UseVisualStyleBackColor = true;
            this.bntPrint.Click += new System.EventHandler(this.bntPrint_Click);
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(249, 392);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(113, 37);
            this.bntSave.TabIndex = 20;
            this.bntSave.Text = "LƯU";
            this.bntSave.UseVisualStyleBackColor = true;
            // 
            // GridView_Diem
            // 
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
            this.GridView_Diem.Location = new System.Drawing.Point(12, 153);
            this.GridView_Diem.Name = "GridView_Diem";
            this.GridView_Diem.Size = new System.Drawing.Size(821, 229);
            this.GridView_Diem.TabIndex = 19;
            // 
            // MSHOCSINH
            // 
            this.MSHOCSINH.DataPropertyName = "MSHOCSINH";
            this.MSHOCSINH.HeaderText = "MSHS";
            this.MSHOCSINH.Name = "MSHOCSINH";
            this.MSHOCSINH.ReadOnly = true;
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "Họ và tên";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // SCORE_5M
            // 
            this.SCORE_5M.DataPropertyName = "SCORE_5M";
            this.SCORE_5M.HeaderText = "5 phút";
            this.SCORE_5M.Name = "SCORE_5M";
            // 
            // SCORE_15M
            // 
            this.SCORE_15M.DataPropertyName = "SCORE_15M";
            this.SCORE_15M.HeaderText = "15 phút";
            this.SCORE_15M.Name = "SCORE_15M";
            // 
            // SCORE_45M
            // 
            this.SCORE_45M.DataPropertyName = "SCORE_45M";
            this.SCORE_45M.HeaderText = "45 phút";
            this.SCORE_45M.Name = "SCORE_45M";
            // 
            // SCORE_MIDYEAR
            // 
            this.SCORE_MIDYEAR.DataPropertyName = "SCORE_MIDYEAR";
            this.SCORE_MIDYEAR.HeaderText = "Giữa kỳ";
            this.SCORE_MIDYEAR.Name = "SCORE_MIDYEAR";
            // 
            // SCORE_ENDYEAR
            // 
            this.SCORE_ENDYEAR.DataPropertyName = "SCORE_ENDYEAR";
            this.SCORE_ENDYEAR.HeaderText = "Cuối kỳ";
            this.SCORE_ENDYEAR.Name = "SCORE_ENDYEAR";
            // 
            // MEDIUMSCORE
            // 
            this.MEDIUMSCORE.DataPropertyName = "MEDIUMSCORE";
            this.MEDIUMSCORE.HeaderText = "Trung bình";
            this.MEDIUMSCORE.Name = "MEDIUMSCORE";
            this.MEDIUMSCORE.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "LỚP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "MÔN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "KHỐI";
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(211, 123);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(159, 21);
            this.cmbSubject.TabIndex = 15;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(506, 72);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(159, 21);
            this.cmbClass.TabIndex = 14;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // cmbGrade
            // 
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(211, 72);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(159, 21);
            this.cmbGrade.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "QUẢN LÝ ĐIỂM";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(390, 392);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 37);
            this.btnImport.TabIndex = 24;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(12, 20);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 25;
            this.btn_Print.Text = "In Pdf";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // QuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 435);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.bntPrint);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.GridView_Diem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.cmbGrade);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyDiem";
            this.Text = "QuanLyDiem";
            this.Load += new System.EventHandler(this.QuanLyDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Diem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Button bntPrint;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.DataGridView GridView_Diem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSHOCSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCORE_5M;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCORE_15M;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCORE_45M;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCORE_MIDYEAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCORE_ENDYEAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDIUMSCORE;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btn_Print;
    }
}