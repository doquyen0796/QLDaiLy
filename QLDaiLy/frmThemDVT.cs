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
    public partial class frmThemDVT : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler XuLyThemDVT;

        private void KhiThemDVT(EventArgs e)
        {
            var handler = XuLyThemDVT;
            if (handler != null)
            {
                handler(this, e);
            }
        }


        public frmThemDVT()
        {
            InitializeComponent();
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
            if (dvt.KiemTraTenDVT(txtTenDVT.Text) == false)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtTenDVT, "Đơn vị tính đã tồn tại.");
                return false;
            }
            else
            {
                ErrorChecker.Clear();
            }
            
            return true;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                string tendvt = txtTenDVT.Text;
                BUS_DonViTinh dvt = new BUS_DonViTinh();
                var tb = dvt.ThemDonViTinh(tendvt);
                if (tb == true)
                {
                    MessageBox.Show(string.Format("Bạn đã thêm đơn vị <{0}> thành công.", tendvt), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    KhiThemDVT(EventArgs.Empty);   //  https://msdn.microsoft.com/en-us/library/9aackb16(v=vs.110).aspx
                }
            }
        }
    }
}