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
<<<<<<< HEAD
using System.Text.RegularExpressions;
=======
>>>>>>> bb602afa7db4af3d52e74dcc9ee1b93f092c3425

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
<<<<<<< HEAD
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
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
=======
>>>>>>> bb602afa7db4af3d52e74dcc9ee1b93f092c3425
        }
    }
}