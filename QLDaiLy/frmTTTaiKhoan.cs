using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;

namespace QLDaiLy
{
    public partial class frmTTTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmTTTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frmDMK = new frmDoiMatKhau();
            frmDMK.ShowDialog();
        }

        private void frmTTTaiKhoan_Load(object sender, EventArgs e)
        {
            txtMaNguoiDung.Text = BUS_NguoiDung.CurUser.MaNguoiDung.ToString();
            txtTenDangNhap.Text = BUS_NguoiDung.CurUser.TenDangNhap.ToString();
            txtEmail.Text = BUS_NguoiDung.CurUser.Email.ToString();
            txtSDT.Text = BUS_NguoiDung.CurUser.SoDienThoai.ToString();
            txtDiaChi.Text = BUS_NguoiDung.CurUser.DiaChi.ToString();
        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                MessageBox.Show("Chức năng đang được bảo trì!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }


        public bool KiemTraDuLieu()
        {
            ErrorChecker.Clear();  // giả sử ban đầu mọi dữ liệu là đúng
            if (txtSDT.Text.Length < 10)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtSDT, "Số điện thoại không hợp lệ.");
                return false;
            }
            else
            {
                ErrorChecker.Clear();
            }

            return true;
        }
    }
}