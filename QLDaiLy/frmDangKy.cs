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
    public partial class frmDangKy : DevExpress.XtraEditors.XtraForm
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap dangnhap = new frmDangNhap();
            this.Hide();
            dangnhap.Show();
        }


        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                BUS_NguoiDung nd = new BUS_NguoiDung();
                var flag = nd.DangKy(txtTenDangNhap.Text, txtMatKhau.Text, txtEmail.Text, txtSDT.Text, txtDiaChi.Text);

                if (flag == true)
                {
                    MessageBox.Show("Bạn đã đăng ký tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại trong hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public bool KiemTraDuLieu()
        {
            ErrorChecker.Clear();  // giả sử ban đầu mọi dữ liệu là đúng
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtTenDangNhap, "Không được để trống.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtMatKhau, "Không được để trống.");
                return false;
            }
            if (txtMatKhau.Text.Length < 6)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtMatKhau, "Mật khẩu phải lớn hơn hoặc bằng 6 ký tự.");
                return false;
            }
            if (txtMatKhau.Text != txtXacNhanMK.Text)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtXacNhanMK, "Mật khẩu phải trùng nhau.");
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