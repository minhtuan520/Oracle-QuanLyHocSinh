﻿namespace QuanLyHocSinh
{
    partial class ManageConduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageConduct));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bntInport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bntExport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bntSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbSemester);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbClass);
            this.groupBox2.Controls.Add(this.cmbYear);
            this.groupBox2.Controls.Add(this.cmbGrade);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 94);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Học Kì:";
            // 
            // cmbSemester
            // 
            this.cmbSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(303, 58);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(121, 24);
            this.cmbSemester.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Niên Khóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Khối:";
            // 
            // cmbClass
            // 
            this.cmbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(303, 26);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 24);
            this.cmbClass.TabIndex = 2;
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(99, 58);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 24);
            this.cmbYear.TabIndex = 1;
            // 
            // cmbGrade
            // 
            this.cmbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(100, 26);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(121, 24);
            this.cmbGrade.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "QUẢN LÝ HẠNH KIỂM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntPrint);
            this.groupBox1.Controls.Add(this.bntInport);
            this.groupBox1.Controls.Add(this.bntExport);
            this.groupBox1.Controls.Add(this.bntSave);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(500, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 124);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng: ";
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
            this.bntPrint.Location = new System.Drawing.Point(135, 26);
            this.bntPrint.Name = "bntPrint";
            this.bntPrint.Normalcolor = System.Drawing.Color.CadetBlue;
            this.bntPrint.OnHovercolor = System.Drawing.Color.CadetBlue;
            this.bntPrint.OnHoverTextColor = System.Drawing.Color.Lavender;
            this.bntPrint.selected = false;
            this.bntPrint.Size = new System.Drawing.Size(92, 38);
            this.bntPrint.TabIndex = 11;
            this.bntPrint.Text = "In";
            this.bntPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntPrint.Textcolor = System.Drawing.Color.White;
            this.bntPrint.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bntInport.Location = new System.Drawing.Point(19, 73);
            this.bntInport.Name = "bntInport";
            this.bntInport.Normalcolor = System.Drawing.Color.CadetBlue;
            this.bntInport.OnHovercolor = System.Drawing.Color.CadetBlue;
            this.bntInport.OnHoverTextColor = System.Drawing.Color.Lavender;
            this.bntInport.selected = false;
            this.bntInport.Size = new System.Drawing.Size(92, 38);
            this.bntInport.TabIndex = 10;
            this.bntInport.Text = "Nhập";
            this.bntInport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntInport.Textcolor = System.Drawing.Color.White;
            this.bntInport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bntExport.Location = new System.Drawing.Point(134, 73);
            this.bntExport.Name = "bntExport";
            this.bntExport.Normalcolor = System.Drawing.Color.CadetBlue;
            this.bntExport.OnHovercolor = System.Drawing.Color.CadetBlue;
            this.bntExport.OnHoverTextColor = System.Drawing.Color.Lavender;
            this.bntExport.selected = false;
            this.bntExport.Size = new System.Drawing.Size(92, 38);
            this.bntExport.TabIndex = 9;
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
            this.bntSave.Location = new System.Drawing.Point(20, 26);
            this.bntSave.Name = "bntSave";
            this.bntSave.Normalcolor = System.Drawing.Color.CadetBlue;
            this.bntSave.OnHovercolor = System.Drawing.Color.CadetBlue;
            this.bntSave.OnHoverTextColor = System.Drawing.Color.Lavender;
            this.bntSave.selected = false;
            this.bntSave.Size = new System.Drawing.Size(92, 38);
            this.bntSave.TabIndex = 8;
            this.bntSave.Text = "Lưu";
            this.bntSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSave.Textcolor = System.Drawing.Color.White;
            this.bntSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(725, 298);
            this.dataGridView1.TabIndex = 21;
            // 
            // ManageConduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 507);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageConduct";
            this.Text = "ManageConduct";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bntPrint;
        private Bunifu.Framework.UI.BunifuFlatButton bntInport;
        private Bunifu.Framework.UI.BunifuFlatButton bntExport;
        private Bunifu.Framework.UI.BunifuFlatButton bntSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbYear;
    }
}