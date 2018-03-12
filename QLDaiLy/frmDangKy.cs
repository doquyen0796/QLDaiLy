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


        private void btnDangKy_Click(object sender, EventArgs e)
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


        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            BUS_NguoiDung nd = new BUS_NguoiDung();
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtTenDangNhap, "Không được để trống.");
                btnDangKy.Enabled = false;
                return;
            }
            else
            {
                if (nd.KTTaiKhoanTonTai(txtTenDangNhap.Text))
                {
                    ErrorChecker.Clear();
                    btnDangKy.Enabled = true;
                }
                else
                {
                    ErrorChecker.BlinkRate = 500;
                    ErrorChecker.SetError(txtTenDangNhap, "Tên đăng nhập đã tồn tại trong hệ thống.");
                    btnDangKy.Enabled = false;
                    return;
                }
            }
        }


        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtMatKhau, "Không được để trống.");
                btnDangKy.Enabled = false;
                return;
            }
            if (txtMatKhau.Text.Length < 6)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtMatKhau, "Mật khẩu phải lớn hơn hoặc bằng 6 ký tự.");
                btnDangKy.Enabled = false;
                return;
            }
            ErrorChecker.Clear();
            btnDangKy.Enabled = true;
        }


        private void txtXacNhanMK_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != txtXacNhanMK.Text)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtXacNhanMK, "Mật khẩu phải trùng nhau.");
                btnDangKy.Enabled = false;
                return;
            }
            ErrorChecker.Clear();
            btnDangKy.Enabled = true;
        }


        private void txtEmail_Leave(object sender, EventArgs e)
        {
            //  https://stackoverflow.com/a/19475049/7385686
            //  https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
            //  https://docs.microsoft.com/en-us/dotnet/standard/base-types/anchors-in-regular-expressions

            string pattern = @"\A[a-z0-9]+([-._][a-z0-9]+)*@([a-z0-9]+(-[a-z0-9]+)*\.)+[a-z]{2,4}\z";
            if (Regex.IsMatch(txtEmail.Text, pattern))
            {
                BUS_NguoiDung nd = new BUS_NguoiDung();
                if (nd.KTEmailTonTai(txtEmail.Text))
                {
                    ErrorChecker.Clear();
                    btnDangKy.Enabled = true;
                }
                else
                {
                    ErrorChecker.BlinkRate = 500;
                    ErrorChecker.SetError(txtEmail, "Email đã tồn tại trong hệ thống.");
                    btnDangKy.Enabled = false;
                    return;
                }
            }
            else
            {
                if (txtEmail.Text.Length == 0)
                {
                    ErrorChecker.Clear();
                    btnDangKy.Enabled = true;
                }
                else
                {
                    ErrorChecker.BlinkRate = 500;
                    ErrorChecker.SetError(txtEmail, "Email không hợp lệ.");
                    btnDangKy.Enabled = false;
                    return;
                }
            }
        }


        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length > 0 && txtSDT.Text.Length < 10)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtSDT, "Số điện thoại không hợp lệ.");
                btnDangKy.Enabled = false;
                return;
            }
            ErrorChecker.Clear();
            btnDangKy.Enabled = true;
        }


        /// <kiểm tra hiện mật khẩu>
        private void ckbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienMK.Checked)
            {
                txtMatKhau.Properties.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.Properties.PasswordChar = '*';
            }
        }
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

    }
}