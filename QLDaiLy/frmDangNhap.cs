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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                BUS_NguoiDung nd = new BUS_NguoiDung();
                var flag = nd.DangNhap(txtTenDangNhap.Text, txtMatKhau.Text);

                if (flag == false)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frmMain main = new frmMain();
                    this.Hide();
                    main.Show();
                }
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy dangky = new frmDangKy();
            this.Hide();
            dangky.Show();
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
            else
            {
                ErrorChecker.Clear();
            }

            return true;
        }


        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}