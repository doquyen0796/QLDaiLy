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
    public partial class frmThemLoaiDaiLy : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler XuLyThemLoaiDaiLy;

        private void KhiThemLoaiDaiLy(EventArgs e)
        {
            var handler = XuLyThemLoaiDaiLy;
            if (handler != null)
            {
                handler(this, e);
            }
        }


        public frmThemLoaiDaiLy()
        {
            InitializeComponent();
        }


        private void txtTenLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true
                || char.IsWhiteSpace(e.KeyChar) == true)
            {
                e.Handled = false;
            }
        }


        private void txtTienNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }

            //  https://www.devexpress.com/Support/Center/Question/Details/T227028/how-can-i-format-a-textbox-to-show-currency-and-percent-with-currentculture

            txtTienNo.Properties.DisplayFormat.FormatString = "{0:N0}";
            txtTienNo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            txtTienNo.Properties.Mask.EditMask = "n0";
            txtTienNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
        }


        private bool KiemTraDuLieu()
        {
            ErrorChecker.Clear();  //  giả sử ban đầu mọi dữ liệu là đúng

            if (string.IsNullOrWhiteSpace(txtTenLoai.Text) || string.IsNullOrEmpty(txtTenLoai.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtTenLoai, "Không được để trống.");
                return false;
            }
            BUS_LoaiDaiLy loai = new BUS_LoaiDaiLy();
            if (loai.KiemTraTonTai(txtTenLoai.Text) == false)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtTenLoai, "Loại đại lý đã tồn tại.\nGợi ý: Bạn hãy kiểm tra danh sách loại đại lý ngừng kinh doanh.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTienNo.Text) || string.IsNullOrEmpty(txtTienNo.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtTienNo, "Không được để trống.");
                return false;
            }
            if (float.Parse(txtTienNo.Text) < 10000000)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtTienNo, "Tối thiểu là 10.000.000");
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
                BUS_LoaiDaiLy loai = new BUS_LoaiDaiLy();
                var flag = loai.ThemLoaiDaiLy(txtTenLoai.Text, float.Parse(txtTienNo.Text));
                if (flag == true)
                {
                    MessageBox.Show(string.Format("Bạn đã thêm loại đại lý <{0}> thành công.", txtTenLoai.Text), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    KhiThemLoaiDaiLy(EventArgs.Empty);   //  https://msdn.microsoft.com/en-us/library/9aackb16(v=vs.110).aspx
                }
            }
        }
    }
}