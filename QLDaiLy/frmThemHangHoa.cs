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
    public partial class frmThemHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler XuLyThemHangHoa;

        private void KhiThemHangHoa(EventArgs e)
        {
            var handler = XuLyThemHangHoa;
            if (handler != null)
            {
                handler(this, e);
            }
        }


        public frmThemHangHoa()
        {
            InitializeComponent();
        }


        private void frmThemHangHoa_Load(object sender, EventArgs e)
        {
            //  https://www.devexpress.com/Support/Center/Question/Details/Q20064/comboboxedit-how-do-you-set-the-datasource

            //  Lookup-edit Đơn vị tính
            BUS_DonViTinh dl = new BUS_DonViTinh();
            cbDVT.Properties.DataSource = dl.DanhSachDVT();

            cbDVT.Properties.DisplayMember = "TenDVT";
            cbDVT.Properties.ValueMember = "MaDVT";
            cbDVT.Properties.Columns.Add(new LookUpColumnInfo("TenDVT", "Đơn vị tính"));
        }


        private void txtTenHangHoa_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHangHoa.Text) || string.IsNullOrEmpty(txtTenHangHoa.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtTenHangHoa, "Không được để trống.");
                btnThem.Enabled = false;
                return;
            }
            ErrorChecker.Clear();
            btnThem.Enabled = true;
        }


        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text) || string.IsNullOrEmpty(txtSoLuong.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtSoLuong, "Không được để trống.");
                btnThem.Enabled = false;
                return;
            }
            ErrorChecker.Clear();
            btnThem.Enabled = true;
        }


        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }


        private void txtDonGia_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDonGia.Text) || string.IsNullOrEmpty(txtDonGia.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtDonGia, "Không được để trống.");
                btnThem.Enabled = false;
                return;
            }
            ErrorChecker.Clear();
            btnThem.Enabled = true;
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


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTenHangHoa.Text = string.Empty;
            cbDVT.EditValue = null;
            txtSoLuong.Text = string.Empty;
            txtDonGia.Text = string.Empty;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHangHoa.Text) || string.IsNullOrEmpty(txtTenHangHoa.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtTenHangHoa, "Không được để trống.");
                btnThem.Enabled = false;
                return;
            }
            if (cbDVT.EditValue == null)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(cbDVT, "Không được để trống.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text) || string.IsNullOrEmpty(txtSoLuong.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtSoLuong, "Không được để trống.");
                btnThem.Enabled = false;
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDonGia.Text) || string.IsNullOrEmpty(txtDonGia.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtDonGia, "Không được để trống.");
                btnThem.Enabled = false;
                return;
            }
            ErrorChecker.Clear();

            BUS_HangHoa h = new BUS_HangHoa();
            var flag = h.ThemHangHoa(txtTenHangHoa.Text, int.Parse(cbDVT.EditValue.ToString()), int.Parse(txtSoLuong.Text), float.Parse(txtDonGia.Text));

            if (flag == true)
            {
                var tb = MessageBox.Show("Bạn đã thêm hàng hóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (tb == DialogResult.OK)
                {
                    txtTenHangHoa.Text = string.Empty;
                    cbDVT.EditValue = null;
                    txtSoLuong.Text = string.Empty;
                    txtDonGia.Text = string.Empty;

                    KhiThemHangHoa(EventArgs.Empty);   //  https://msdn.microsoft.com/en-us/library/9aackb16(v=vs.110).aspx
                }
            }
        }
    }
}