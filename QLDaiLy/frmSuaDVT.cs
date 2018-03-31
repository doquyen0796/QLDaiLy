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
    public partial class frmSuaDVT : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler XuLySuaDVT;

        private void KhiSuaDVT(EventArgs e)
        {
            var handler = XuLySuaDVT;
            if (handler != null)
            {
                handler(this, e);
            }
        }


        public frmSuaDVT()
        {
            InitializeComponent();
        }


        private bool KiemTraDuLieu()
        {
            ErrorChecker.Clear();  //  giả sử ban đầu mọi dữ liệu là đúng

            if (string.IsNullOrWhiteSpace(txtTenDVT.Text) || string.IsNullOrEmpty(txtTenDVT.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtTenDVT, "Không được để trống.");
                return false;
            }
            BUS_DonViTinh dvt = new BUS_DonViTinh();
            int madvt = int.Parse(txtMaDVT.Text);
            if (dvt.KiemTraTenDVT(madvt, txtTenDVT.Text) == false)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtTenDVT, "Đơn vị tính đã tồn tại.\nGợi ý: Bạn hãy kiểm tra danh sách đơn vị tính ngừng kinh doanh.");
                return false;
            }
            else
            {
                ErrorChecker.Clear();
            }

            return true;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                var tb = MessageBox.Show("Bạn có chắc chắn muốn chỉnh sửa tên đơn vị tính ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (tb == DialogResult.Yes)
                {
                    BUS_DonViTinh dvt = new BUS_DonViTinh();
                    int madvt = int.Parse(txtMaDVT.Text);
                    string tendvt = txtTenDVT.Text;
                    dvt.SuaDonViTinh(madvt, tendvt);

                    MessageBox.Show("Bạn đã chỉnh sửa tên đơn vị tính thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    KhiSuaDVT(EventArgs.Empty);   //  https://msdn.microsoft.com/en-us/library/9aackb16(v=vs.110).aspx
                }
                else
                {
                    return;
                }
            }
        }


        private void txtTenDVT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true
                || char.IsWhiteSpace(e.KeyChar) == true)
            {
                e.Handled = false;
            }
        }
    }
}