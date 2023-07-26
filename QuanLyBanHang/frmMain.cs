using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Class;

namespace QuanLyBanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuTroGiupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Functions.Connect(); // gọi đến class trong Functions

        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect(); //// gọi đến class trong Functions
            Application.Exit();
        }

        private void mnuMayTinh_Click(object sender, EventArgs e)
        {
            frmDMMayTinh frm = new frmDMMayTinh();
            frm.ShowDialog();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHangHoa frm = new frmDMHangHoa();
            frm.MdiParent = this; // this trỏ đến frmMain // đặt form con nằm trong form cha 
            frm.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien frm = new frmDMNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frm = new frmDMKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frm = new frmHoaDonBan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuFindHoaDon_Click(object sender, EventArgs e)
        {
            frmTimKiemHD frm = new frmTimKiemHD();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
