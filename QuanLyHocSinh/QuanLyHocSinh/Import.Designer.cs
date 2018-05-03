namespace QuanLyHocSinh
{
    partial class Import
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntNo = new Bunifu.Framework.UI.BunifuImageButton();
            this.bntYes = new Bunifu.Framework.UI.BunifuImageButton();
            this.GirdviewImport = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GirdviewImport)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GirdviewImport, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 484);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bntNo);
            this.panel1.Controls.Add(this.bntYes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(42, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 56);
            this.panel1.TabIndex = 0;
            // 
            // bntNo
            // 
            this.bntNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntNo.BackColor = System.Drawing.SystemColors.Control;
            this.bntNo.Image = ((System.Drawing.Image)(resources.GetObject("bntNo.Image")));
            this.bntNo.ImageActive = null;
            this.bntNo.Location = new System.Drawing.Point(628, 0);
            this.bntNo.Name = "bntNo";
            this.bntNo.Size = new System.Drawing.Size(74, 54);
            this.bntNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntNo.TabIndex = 9;
            this.bntNo.TabStop = false;
            this.bntNo.Zoom = 10;
            // 
            // bntYes
            // 
            this.bntYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntYes.BackColor = System.Drawing.SystemColors.Control;
            this.bntYes.Image = ((System.Drawing.Image)(resources.GetObject("bntYes.Image")));
            this.bntYes.ImageActive = null;
            this.bntYes.Location = new System.Drawing.Point(531, 2);
            this.bntYes.Name = "bntYes";
            this.bntYes.Size = new System.Drawing.Size(74, 54);
            this.bntYes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntYes.TabIndex = 8;
            this.bntYes.TabStop = false;
            this.bntYes.Zoom = 10;
            this.bntYes.Click += new System.EventHandler(this.bntYes_Click);
            // 
            // GirdviewImport
            // 
            this.GirdviewImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GirdviewImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GirdviewImport.Location = new System.Drawing.Point(42, 99);
            this.GirdviewImport.Name = "GirdviewImport";
            this.GirdviewImport.Size = new System.Drawing.Size(702, 371);
            this.GirdviewImport.TabIndex = 6;
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 484);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Import";
            this.Text = "Import";
            this.Load += new System.EventHandler(this.Import_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bntNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GirdviewImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bntNo;
        private Bunifu.Framework.UI.BunifuImageButton bntYes;
        private System.Windows.Forms.DataGridView GirdviewImport;
    }
}