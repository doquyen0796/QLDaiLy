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
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            var tb = MessageBox.Show("Bạn có chắc chắn muốn đổi mật khẩu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (tb == DialogResult.Yes)
            {
                BUS_NguoiDung nd = new BUS_NguoiDung();
                var flag = nd.DoiMatKhau(BUS_NguoiDung.CurUser.MaNguoiDung, txtMatKhauCu.Text, txtMatKhauMoi.Text);

                if (flag == true)
                {
                    MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu cũ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }


        private void txtMatKhauCu_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatKhauCu.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtMatKhauCu, "Không được để trống.");
                btnDoiMatKhau.Enabled = false;
                return;
            }
            ErrorChecker.Clear();
            btnDoiMatKhau.Enabled = true;
        }


        private void txtMatKhauMoi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatKhauMoi.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtMatKhauMoi, "Không được để trống.");
                btnDoiMatKhau.Enabled = false;
                return;
            }
            if (txtMatKhauMoi.Text.Length < 6)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtMatKhauMoi, "Mật khẩu phải lớn hơn hoặc bằng 6 ký tự.");
                btnDoiMatKhau.Enabled = false;
                return;
            }
            ErrorChecker.Clear();
            btnDoiMatKhau.Enabled = true;
        }


        private void txtXacNhanMK_Leave(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text != txtXacNhanMK.Text)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtXacNhanMK, "Xác nhận mật khẩu phải trùng với mật khẩu mới.");
                btnDoiMatKhau.Enabled = false;
                return;
            }
            ErrorChecker.Clear();
            btnDoiMatKhau.Enabled = true;
        }


        private void ckbHienMKCu_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienMKCu.Checked)
            {
                txtMatKhauCu.Properties.PasswordChar = '\0';
            }
            else
            {
                txtMatKhauCu.Properties.PasswordChar = '*';
            }
        }


        private void ckbHienMKMoi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienMKMoi.Checked)
            {
                txtMatKhauMoi.Properties.PasswordChar = '\0';
            }
            else
            {
                txtMatKhauMoi.Properties.PasswordChar = '*';
            }
        }
    }
}