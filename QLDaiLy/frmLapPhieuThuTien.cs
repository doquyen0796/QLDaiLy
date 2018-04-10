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
using System.Globalization;

namespace QLDaiLy
{
    public partial class frmLapPhieuThuTien : DevExpress.XtraEditors.XtraForm
    {
        DAL.QLDaiLyEntities db = new DAL.QLDaiLyEntities();

        public event EventHandler XuLyThemPhieuThu;

        private void KhiThemPhieuThu(EventArgs e)
        {
            var handler = XuLyThemPhieuThu;
            if (handler != null)
            {
                handler(this, e);
            }
        }


        public frmLapPhieuThuTien()
        {
            InitializeComponent();
        }


        private void FormLoad()
        {
            //  https://www.devexpress.com/Support/Center/Question/Details/Q20064/comboboxedit-how-do-you-set-the-datasource

            //  Lookup-edit Đại lý
            BUS_DaiLy dl = new BUS_DaiLy();
            cbDaiLy.Properties.DataSource = dl.DanhSachDaiLy();

            cbDaiLy.Properties.DisplayMember = "TenDaiLy";
            cbDaiLy.Properties.ValueMember = "MaDaiLy";
            cbDaiLy.Properties.Columns.Add(new LookUpColumnInfo("TenDaiLy", "Tên Đại Lý"));
            cbDaiLy.Properties.Columns.Add(new LookUpColumnInfo("Quan", "Quận"));
            cbDaiLy.Properties.Columns.Add(new LookUpColumnInfo("DiaChi", "Địa Chỉ"));

            //  Date edit
            dtpNgayLap.EditValue = DateTime.Now;
        }


        private void frmLapPhieuThuTien_Load(object sender, EventArgs e)
        {
            this.FormLoad();
        }


        private void cbDaiLy_EditValueChanged(object sender, EventArgs e)
        {
            if (cbDaiLy.EditValue == null)
            {
                lbDiaChi.Visible = false;
                lbEmail.Visible = false;
                lbTienNo.Visible = false;
            }
            else
            {
                DAL.QLDaiLyEntities db = new DAL.QLDaiLyEntities();

                int madl = int.Parse(cbDaiLy.EditValue.ToString());

                var daily = db.DaiLies
                              .Where(d => d.MaDaiLy == madl)
                              .FirstOrDefault();

                lbDiaChi.Text = daily.DiaChi;
                lbEmail.Text = daily.Email;
                lbTienNo.Text = string.Format("{0:N0}", daily.TienNo);

                lbDiaChi.Visible = true;
                lbEmail.Visible = true;
                lbTienNo.Visible = true;
            }
        }


        private bool KiemTraDuLieu()
        {
            ErrorChecker.Clear();  //  giả sử ban đầu mọi dữ liệu là đúng

            if (cbDaiLy.EditValue == null)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(cbDaiLy, "Không được để trống.");
                return false;
            }
            if (string.IsNullOrEmpty(txtSoTienThu.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtSoTienThu, "Không được để trống.");
                return false;
            }
            if (float.Parse(txtSoTienThu.Text) <= 0)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtSoTienThu, "Số tiền thu không hợp lệ.");
                return false;
            }
            else
            {
                ErrorChecker.Clear();
            }

            return true;
        }


        private void txtSoTienThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }


            //  https://www.devexpress.com/Support/Center/Question/Details/T227028/how-can-i-format-a-textbox-to-show-currency-and-percent-with-currentculture

            txtSoTienThu.Properties.DisplayFormat.FormatString = "{0:N0}";
            txtSoTienThu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            txtSoTienThu.Properties.Mask.EditMask = "n0";
            txtSoTienThu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                BUS_PhieuThuTien pt = new BUS_PhieuThuTien();

                int madaily = int.Parse(cbDaiLy.EditValue.ToString());
                int manhanvien = BUS_NguoiDung.CurUser.MaNguoiDung;
                DateTime ngaythu = DateTime.Parse(dtpNgayLap.EditValue.ToString());
                double sotienthu = double.Parse(txtSoTienThu.Text, NumberStyles.Currency);

                int flag = pt.LapPhieuThu(madaily, manhanvien, ngaythu, sotienthu);

                if (flag == 1)
                {
                    KhiThemPhieuThu(EventArgs.Empty);   //  https://msdn.microsoft.com/en-us/library/9aackb16(v=vs.110).aspx

                    MessageBox.Show("Bạn đã lập phiếu thu tiền thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.ResetForm();
                }
                else
                {
                    MessageBox.Show("Số tiền thu không được vượt quá số tiền đại lý đang nợ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void ResetForm()
        {
            cbDaiLy.EditValue = null;
        }
    }
}