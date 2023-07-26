using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBanHang.Class;

namespace QuanLyBanHang
{
    public partial class frmDMMayTinh : Form
    {
        DataTable tblMT;
        public frmDMMayTinh()
        {
            InitializeComponent();
        }

        private void frmDMMayTinh_Load(object sender, EventArgs e)
        {
            txtMaMayTinh.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaMayTinh, TenMayTinh FROM tblMayTinh";
            tblMT = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvMayTinh.DataSource = tblMT; //Nguồn dữ liệu            
            dgvMayTinh.Columns[0].HeaderText = "Mã máy tính";
            dgvMayTinh.Columns[1].HeaderText = "Tên máy tính";
            dgvMayTinh.Columns[0].Width = 100;
            dgvMayTinh.Columns[1].Width = 300;
            dgvMayTinh.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvMayTinh.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvMayTinh_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaMayTinh.Focus();
                return;
            }
            if (tblMT.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaMayTinh.Text = dgvMayTinh.CurrentRow.Cells["MaMayTinh"].Value.ToString();
            txtTenMayTinh.Text = dgvMayTinh.CurrentRow.Cells["TenMayTinh"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMaMayTinh.Enabled = true; //cho phép nhập mới
            txtMaMayTinh.Focus();
        }

        private void ResetValue()
        {
            txtMaMayTinh.Text = "";
            txtTenMayTinh.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaMayTinh.Text.Trim().Length == 0) //Nếu chưa nhập mã máy tính
            {
                MessageBox.Show("Bạn phải nhập mã máy tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaMayTinh.Focus();
                return;
            }
            if (txtTenMayTinh.Text.Trim().Length == 0) //Nếu chưa nhập tên máy tính
            {
                MessageBox.Show("Bạn phải nhập tên máy tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenMayTinh.Focus();
                return;
            }
            sql = "Select MaMayTinh From tblMayTinh where MaMayTinh=N'" + txtMaMayTinh.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã máy tính này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaMayTinh.Focus();
                return;
            }

            sql = "INSERT INTO tblMayTinh VALUES(N'" +
                txtMaMayTinh.Text + "',N'" + txtTenMayTinh.Text + "')";
            Class.Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaMayTinh.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblMT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaMayTinh.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenMayTinh.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên máy tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblMayTinh SET TenMayTinh=N'" +
                txtTenMayTinh.Text.ToString() +
                "' WHERE MaMayTinh=N'" + txtMaMayTinh.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();

            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblMT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaMayTinh.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblMayTinh WHERE MaMayTinh=N'" + txtMaMayTinh.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaMayTinh.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaMayTinh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
