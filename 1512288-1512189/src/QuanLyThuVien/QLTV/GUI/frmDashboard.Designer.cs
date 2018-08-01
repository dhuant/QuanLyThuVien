namespace QLTV
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HTtool = new System.Windows.Forms.ToolStripMenuItem();
            this.DoiMKtool = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutTool = new System.Windows.Forms.ToolStripMenuItem();
            this.QLNVTool = new System.Windows.Forms.ToolStripMenuItem();
            this.roleTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DSNVTool = new System.Windows.Forms.ToolStripMenuItem();
            this.QLBDTool = new System.Windows.Forms.ToolStripMenuItem();
            this.QLSachTool = new System.Windows.Forms.ToolStripMenuItem();
            this.SachTool = new System.Windows.Forms.ToolStripMenuItem();
            this.LoaiSachTool = new System.Windows.Forms.ToolStripMenuItem();
            this.NXBTool = new System.Windows.Forms.ToolStripMenuItem();
            this.MuonSachTool = new System.Windows.Forms.ToolStripMenuItem();
            this.TraSachTool = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HTtool,
            this.QLNVTool,
            this.QLBDTool,
            this.QLSachTool,
            this.MuonSachTool,
            this.TraSachTool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HTtool
            // 
            this.HTtool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DoiMKtool,
            this.logoutTool});
            this.HTtool.Name = "HTtool";
            this.HTtool.Size = new System.Drawing.Size(86, 24);
            this.HTtool.Text = "Hệ Thống";
            // 
            // DoiMKtool
            // 
            this.DoiMKtool.Name = "DoiMKtool";
            this.DoiMKtool.Size = new System.Drawing.Size(175, 26);
            this.DoiMKtool.Text = "Đổi Mật Khẩu";
            this.DoiMKtool.Click += new System.EventHandler(this.DoiMKtool_Click);
            // 
            // logoutTool
            // 
            this.logoutTool.Name = "logoutTool";
            this.logoutTool.Size = new System.Drawing.Size(175, 26);
            this.logoutTool.Text = "Logout";
            this.logoutTool.Click += new System.EventHandler(this.logoutTool_Click);
            // 
            // QLNVTool
            // 
            this.QLNVTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roleTool,
            this.DSNVTool});
            this.QLNVTool.Name = "QLNVTool";
            this.QLNVTool.Size = new System.Drawing.Size(145, 24);
            this.QLNVTool.Text = "Quản Lý Nhân Viên";
            this.QLNVTool.Click += new System.EventHandler(this.QLNVTool_Click);
            // 
            // roleTool
            // 
            this.roleTool.Name = "roleTool";
            this.roleTool.Size = new System.Drawing.Size(226, 26);
            this.roleTool.Text = "Role";
            this.roleTool.Click += new System.EventHandler(this.roleTool_Click);
            // 
            // DSNVTool
            // 
            this.DSNVTool.Name = "DSNVTool";
            this.DSNVTool.Size = new System.Drawing.Size(226, 26);
            this.DSNVTool.Text = "Danh Sách Nhân Viên";
            this.DSNVTool.Click += new System.EventHandler(this.DSNVTool_Click);
            // 
            // QLBDTool
            // 
            this.QLBDTool.Name = "QLBDTool";
            this.QLBDTool.Size = new System.Drawing.Size(133, 24);
            this.QLBDTool.Text = "Quản Lý Bạn Đọc";
            this.QLBDTool.Click += new System.EventHandler(this.QLBDTool_Click);
            // 
            // QLSachTool
            // 
            this.QLSachTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SachTool,
            this.LoaiSachTool,
            this.NXBTool});
            this.QLSachTool.Name = "QLSachTool";
            this.QLSachTool.Size = new System.Drawing.Size(108, 24);
            this.QLSachTool.Text = "Quản Lý Sách";
            // 
            // SachTool
            // 
            this.SachTool.Name = "SachTool";
            this.SachTool.Size = new System.Drawing.Size(174, 26);
            this.SachTool.Text = "Sách";
            this.SachTool.Click += new System.EventHandler(this.SachTool_Click);
            // 
            // LoaiSachTool
            // 
            this.LoaiSachTool.Name = "LoaiSachTool";
            this.LoaiSachTool.Size = new System.Drawing.Size(174, 26);
            this.LoaiSachTool.Text = "Loại Sách";
            this.LoaiSachTool.Click += new System.EventHandler(this.LoaiSachTool_Click);
            // 
            // NXBTool
            // 
            this.NXBTool.Name = "NXBTool";
            this.NXBTool.Size = new System.Drawing.Size(174, 26);
            this.NXBTool.Text = "Nhà Xuất Bản";
            this.NXBTool.Click += new System.EventHandler(this.NXBTool_Click);
            // 
            // MuonSachTool
            // 
            this.MuonSachTool.Name = "MuonSachTool";
            this.MuonSachTool.Size = new System.Drawing.Size(95, 24);
            this.MuonSachTool.Text = "Mượn Sách";
            this.MuonSachTool.Click += new System.EventHandler(this.MuonSachTool_Click);
            // 
            // TraSachTool
            // 
            this.TraSachTool.Name = "TraSachTool";
            this.TraSachTool.Size = new System.Drawing.Size(76, 24);
            this.TraSachTool.Text = "Trả Sách";
            this.TraSachTool.Click += new System.EventHandler(this.TraSachTool_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(208, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lý Thư Viện";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLTV.Properties.Resources.DSCN0122;
            this.pictureBox1.Location = new System.Drawing.Point(100, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 425);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DASHBOARD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDashboard_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HTtool;
        private System.Windows.Forms.ToolStripMenuItem DoiMKtool;
        private System.Windows.Forms.ToolStripMenuItem logoutTool;
        private System.Windows.Forms.ToolStripMenuItem QLNVTool;
        private System.Windows.Forms.ToolStripMenuItem roleTool;
        private System.Windows.Forms.ToolStripMenuItem DSNVTool;
        private System.Windows.Forms.ToolStripMenuItem QLBDTool;
        private System.Windows.Forms.ToolStripMenuItem QLSachTool;
        private System.Windows.Forms.ToolStripMenuItem SachTool;
        private System.Windows.Forms.ToolStripMenuItem LoaiSachTool;
        private System.Windows.Forms.ToolStripMenuItem NXBTool;
        private System.Windows.Forms.ToolStripMenuItem MuonSachTool;
        private System.Windows.Forms.ToolStripMenuItem TraSachTool;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}