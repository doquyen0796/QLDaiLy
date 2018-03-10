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
            if (txtSDT.Text.Length > 0 && txtSDT.Text.Length < 10)
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

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            //  https://stackoverflow.com/a/19475049/7385686
            //  https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
            //  https://docs.microsoft.com/en-us/dotnet/standard/base-types/anchors-in-regular-expressions

            string pattern = @"\A[a-z0-9]+([-._][a-z0-9]+)*@([a-z0-9]+(-[a-z0-9]+)*\.)+[a-z]{2,4}\z";
            if (Regex.IsMatch(txtEmail.Text, pattern))
            {
                ErrorChecker.Clear();
                btnLuuTT.Enabled = true;
            }
            else
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtEmail, "Email không hợp lệ.");
                btnLuuTT.Enabled = false;
                return;
            }
        }
    }
}