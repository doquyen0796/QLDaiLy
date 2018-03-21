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
using System.Text.RegularExpressions;

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


        private bool KiemTraDuLieu()
        {
            ErrorChecker.Clear();  //  giả sử ban đầu mọi dữ liệu là đúng

            BUS_NguoiDung nd = new BUS_NguoiDung();
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtTenDangNhap, "Không được để trống.");
                return false;
            }
            if (nd.KTTaiKhoanTonTai(txtTenDangNhap.Text) == false)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtTenDangNhap, "Tên đăng nhập đã tồn tại trong hệ thống.");
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
            if (txtSDT.Text.Length > 0 && txtSDT.Text.Length < 10)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtSDT, "Số điện thoại không hợp lệ.");
                return false;
            }


            //  Kiểm tra Email hợp lệ
            //  https://stackoverflow.com/a/19475049/7385686
            //  https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
            //  https://docs.microsoft.com/en-us/dotnet/standard/base-types/anchors-in-regular-expressions

            string pattern = @"\A[a-z0-9]+([-._][a-z0-9]+)*@([a-z0-9]+(-[a-z0-9]+)*\.)+[a-z]{2,4}\z";

            if (txtEmail.Text.Length == 0)
            {
                ErrorChecker.Clear();
                return true;
            }
            if (Regex.IsMatch(txtEmail.Text, pattern))
            {
                if (nd.KTEmailTonTai(txtEmail.Text) == false)
                {
                    ErrorChecker.BlinkRate = 500;
                    ErrorChecker.SetError(txtEmail, "Email đã tồn tại trong hệ thống.");
                    return false;
                }
            }
            if (Regex.IsMatch(txtEmail.Text, pattern) == false)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtEmail, "Email không hợp lệ.");
                return false;
            }
            else
            {
                ErrorChecker.Clear();
            }

            return true;
        }


        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                BUS_NguoiDung nd = new BUS_NguoiDung();
                nd.DangKy(txtTenDangNhap.Text, txtMatKhau.Text, txtEmail.Text, txtSDT.Text, txtDiaChi.Text);

                var tb = MessageBox.Show("Bạn đã đăng ký tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (tb == DialogResult.OK)
                {
                    frmDangNhap dangnhap = new frmDangNhap();
                    this.Hide();
                    dangnhap.Show();
                }
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


        private void frmDangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDangNhap dangnhap = new frmDangNhap();
            this.Hide();
            dangnhap.Show();
        }
    }
}