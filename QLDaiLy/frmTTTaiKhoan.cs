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
            BUS_NguoiDung u = new BUS_NguoiDung();
            var user = u.GetUser(BUS_NguoiDung.CurUser.MaNguoiDung);

            txtTenDangNhap.Text = user.TenDangNhap.ToString();
            txtEmail.Text = user.Email.ToString();
            txtSDT.Text = user.SoDienThoai.ToString();
            txtDiaChi.Text = user.DiaChi.ToString();
        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                var tb = MessageBox.Show("Bạn có chắc chắn muốn lưu thông tin ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (tb == DialogResult.Yes)
                {
                    BUS_NguoiDung nd = new BUS_NguoiDung();
                    var flag = nd.DoiThongTin(BUS_NguoiDung.CurUser.MaNguoiDung, txtEmail.Text, txtSDT.Text, txtDiaChi.Text);

                    if (flag == true)
                    {
                        MessageBox.Show("Lưu thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Email đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
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
                if (txtEmail.Text.Length == 0)
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
}