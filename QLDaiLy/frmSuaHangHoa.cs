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
using DevExpress.XtraEditors.Controls;

namespace QLDaiLy
{
    public partial class frmSuaHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler XuLySuaHangHoa;

        private void KhiSuaHangHoa(EventArgs e)
        {
            var handler = XuLySuaHangHoa;
            if (handler != null)
            {
                handler(this, e);
            }
        }


        public frmSuaHangHoa()
        {
            InitializeComponent();
        }


        private void frmSuaHangHoa_Load(object sender, EventArgs e)
        {
            //  https://www.devexpress.com/Support/Center/Question/Details/Q20064/comboboxedit-how-do-you-set-the-datasource

            //  Lookup-edit Đơn vị tính
            BUS_DonViTinh dl = new BUS_DonViTinh();
            cbDVT.Properties.DataSource = dl.DanhSachDVT();

            cbDVT.Properties.DisplayMember = "TenDVT";
            cbDVT.Properties.ValueMember = "MaDVT";
            cbDVT.Properties.Columns.Add(new LookUpColumnInfo("TenDVT", "Đơn vị tính"));


            //  Text-edit đơn giá
            //  https://www.devexpress.com/Support/Center/Question/Details/T227028/how-can-i-format-a-textbox-to-show-currency-and-percent-with-currentculture

            txtDonGia.Properties.DisplayFormat.FormatString = "{0:N0}";
            txtDonGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            txtDonGia.Properties.Mask.EditMask = "n0";
            txtDonGia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
        }


        private bool KiemTraDuLieu()
        {
            ErrorChecker.Clear();  //  giả sử ban đầu mọi dữ liệu là đúng

            if (string.IsNullOrWhiteSpace(txtTenHangHoa.Text) || string.IsNullOrEmpty(txtTenHangHoa.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtTenHangHoa, "Không được để trống.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDonGia.Text) || string.IsNullOrEmpty(txtDonGia.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtDonGia, "Không được để trống.");
                return false;
            }
            if (float.Parse(txtDonGia.Text) < 500)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtDonGia, "Đơn giá không hợp lệ.");
                return false;
            }
            if (cbDVT.EditValue == null)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(cbDVT, "Không được để trống.");
                return false;
            }
            else
            {
                ErrorChecker.Clear();
            }

            return true;
        }


        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }


            //  https://www.devexpress.com/Support/Center/Question/Details/T227028/how-can-i-format-a-textbox-to-show-currency-and-percent-with-currentculture

            txtDonGia.Properties.DisplayFormat.FormatString = "{0:N0}";
            txtDonGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            txtDonGia.Properties.Mask.EditMask = "n0";
            txtDonGia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                var tb = MessageBox.Show("Bạn có chắc chắn muốn chỉnh sửa thông tin của hàng hóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (tb == DialogResult.Yes)
                {
                    BUS_HangHoa hh = new BUS_HangHoa();
                    var flag = hh.SuaHangHoa(int.Parse(txtMaHH.Text), txtTenHangHoa.Text, int.Parse(cbDVT.EditValue.ToString()), float.Parse(txtDonGia.Text));
                    if (flag == true)
                    {
                        MessageBox.Show("Bạn đã chỉnh sửa thông tin hàng hóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        KhiSuaHangHoa(EventArgs.Empty);   //  https://msdn.microsoft.com/en-us/library/9aackb16(v=vs.110).aspx
                    }
                }
                else
                {
                    return;
                }
            }
        }


        private void btnThemDVT_Click(object sender, EventArgs e)
        {
            frmThemDVT frm = new frmThemDVT();
            frm.XuLyThemDVT += frmSuaHangHoa_Load;
            frm.ShowDialog();
        }
    }
}