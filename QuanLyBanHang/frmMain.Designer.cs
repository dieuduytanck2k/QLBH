namespace QuanLyBanHang
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMayTinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngTồnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHienTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVaiNet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuDanhMuc,
            this.mnuHoaDon,
            this.mnuTimKiem,
            this.mnuBaoCao,
            this.mnuTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(69, 24);
            this.mnuFile.Text = "&Tệp tin";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Image = ((System.Drawing.Image)(resources.GetObject("mnuThoat.Image")));
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuThoat.Size = new System.Drawing.Size(183, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMayTinh,
            this.mnuHangHoa,
            this.toolStripMenuItem2,
            this.mnuNhanVien,
            this.mnuKhachHang});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(90, 24);
            this.mnuDanhMuc.Text = "&Danh mục";
            // 
            // mnuMayTinh
            // 
            this.mnuMayTinh.Image = ((System.Drawing.Image)(resources.GetObject("mnuMayTinh.Image")));
            this.mnuMayTinh.Name = "mnuMayTinh";
            this.mnuMayTinh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuMayTinh.Size = new System.Drawing.Size(200, 26);
            this.mnuMayTinh.Text = "&Máy tính";
            this.mnuMayTinh.Click += new System.EventHandler(this.mnuMayTinh_Click);
            // 
            // mnuHangHoa
            // 
            this.mnuHangHoa.Image = ((System.Drawing.Image)(resources.GetObject("mnuHangHoa.Image")));
            this.mnuHangHoa.Name = "mnuHangHoa";
            this.mnuHangHoa.Size = new System.Drawing.Size(200, 26);
            this.mnuHangHoa.Text = "&Hàng hóa";
            this.mnuHangHoa.Click += new System.EventHandler(this.mnuHangHoa_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(197, 6);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("mnuNhanVien.Image")));
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(200, 26);
            this.mnuNhanVien.Text = "&Nhân viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("mnuKhachHang.Image")));
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(200, 26);
            this.mnuKhachHang.Text = "&Khách hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoaDonBan});
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(81, 24);
            this.mnuHoaDon.Text = "&Hóa đơn";
            // 
            // mnuHoaDonBan
            // 
            this.mnuHoaDonBan.Image = ((System.Drawing.Image)(resources.GetObject("mnuHoaDonBan.Image")));
            this.mnuHoaDonBan.Name = "mnuHoaDonBan";
            this.mnuHoaDonBan.Size = new System.Drawing.Size(179, 26);
            this.mnuHoaDonBan.Text = "Hoá đơn bán";
            this.mnuHoaDonBan.Click += new System.EventHandler(this.mnuHoaDonBan_Click);
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFindHoaDon,
            this.mnuFindHang,
            this.mnuFindKhachHang});
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(84, 24);
            this.mnuTimKiem.Text = "&Tìm kiếm";
            // 
            // mnuFindHoaDon
            // 
            this.mnuFindHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("mnuFindHoaDon.Image")));
            this.mnuFindHoaDon.Name = "mnuFindHoaDon";
            this.mnuFindHoaDon.Size = new System.Drawing.Size(169, 26);
            this.mnuFindHoaDon.Text = "Hoá đơn";
            this.mnuFindHoaDon.Click += new System.EventHandler(this.mnuFindHoaDon_Click);
            // 
            // mnuFindHang
            // 
            this.mnuFindHang.Image = ((System.Drawing.Image)(resources.GetObject("mnuFindHang.Image")));
            this.mnuFindHang.Name = "mnuFindHang";
            this.mnuFindHang.Size = new System.Drawing.Size(169, 26);
            this.mnuFindHang.Text = "Hàng";
            // 
            // mnuFindKhachHang
            // 
            this.mnuFindKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("mnuFindKhachHang.Image")));
            this.mnuFindKhachHang.Name = "mnuFindKhachHang";
            this.mnuFindKhachHang.Size = new System.Drawing.Size(169, 26);
            this.mnuFindKhachHang.Text = "Khách hàng";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hàngTồnToolStripMenuItem,
            this.mnuBCDoanhThu});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(77, 24);
            this.mnuBaoCao.Text = "&Báo cáo";
            // 
            // hàngTồnToolStripMenuItem
            // 
            this.hàngTồnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hàngTồnToolStripMenuItem.Image")));
            this.hàngTồnToolStripMenuItem.Name = "hàngTồnToolStripMenuItem";
            this.hàngTồnToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.hàngTồnToolStripMenuItem.Text = "Hàng tồn";
            // 
            // mnuBCDoanhThu
            // 
            this.mnuBCDoanhThu.Image = ((System.Drawing.Image)(resources.GetObject("mnuBCDoanhThu.Image")));
            this.mnuBCDoanhThu.Name = "mnuBCDoanhThu";
            this.mnuBCDoanhThu.Size = new System.Drawing.Size(161, 26);
            this.mnuBCDoanhThu.Text = "Doanh thu";
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHienTroGiup,
            this.mnuVaiNet});
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(78, 24);
            this.mnuTroGiup.Text = "&Trợ giúp";
            // 
            // mnuHienTroGiup
            // 
            this.mnuHienTroGiup.Image = ((System.Drawing.Image)(resources.GetObject("mnuHienTroGiup.Image")));
            this.mnuHienTroGiup.Name = "mnuHienTroGiup";
            this.mnuHienTroGiup.Size = new System.Drawing.Size(147, 26);
            this.mnuHienTroGiup.Text = "Trợ giúp";
            this.mnuHienTroGiup.Click += new System.EventHandler(this.mnuTroGiupToolStripMenuItem_Click);
            // 
            // mnuVaiNet
            // 
            this.mnuVaiNet.Name = "mnuVaiNet";
            this.mnuVaiNet.Size = new System.Drawing.Size(147, 26);
            this.mnuVaiNet.Text = "Vài nét";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(89, 20);
            this.toolStripStatusLabel1.Text = "Đã sẵn sàng";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Chương trình quản lý bán máy tính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuMayTinh;
        private System.Windows.Forms.ToolStripMenuItem mnuHangHoa;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuFindHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuFindHang;
        private System.Windows.Forms.ToolStripMenuItem mnuFindKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem hàngTồnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBCDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuHienTroGiup;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem mnuVaiNet;
    }
}

