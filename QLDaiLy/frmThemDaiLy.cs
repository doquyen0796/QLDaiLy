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
using System.Text.RegularExpressions;

namespace QLDaiLy
{
    public partial class frmThemDaiLy : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler XuLyThemDaiLy;

        private void KhiThemDaiLy(EventArgs e)
        {
            var handler = XuLyThemDaiLy;
            if (handler != null)
            {
                handler(this, e);
            }
        }


        public frmThemDaiLy()
        {
            InitializeComponent();
        }


        private void frmThemDaiLy_Load(object sender, EventArgs e)
        {
            //  https://www.devexpress.com/Support/Center/Question/Details/Q20064/comboboxedit-how-do-you-set-the-datasource

            //  Lookup-edit Đại lý
            BUS_DaiLy dl = new BUS_DaiLy();
            cbLoaiDL.Properties.DataSource = dl.DanhSachLoaiDL();

            cbLoaiDL.Properties.DisplayMember = "TenLoai";
            cbLoaiDL.Properties.ValueMember = "MaLoai";
            cbLoaiDL.Properties.Columns.Add(new LookUpColumnInfo("TenLoai", "Loại Đại Lý"));


            //  Lookup-edit Quận
            BUS_Quan q = new BUS_Quan();
            cbQuan.Properties.DataSource = q.DanhSachQuan();

            cbQuan.Properties.DisplayMember = "TenQuan";
            cbQuan.Properties.ValueMember = "TenQuan";
            cbQuan.Properties.Columns.Add(new LookUpColumnInfo("TenQuan", "Quận"));
        }


        private void txtTenDaiLy_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDaiLy.Text) || string.IsNullOrEmpty(txtTenDaiLy.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtTenDaiLy, "Không được để trống.");
                btnThem.Enabled = false;
                return;
            }
            ErrorChecker.Clear();
            btnThem.Enabled = true;
        }


        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text) || string.IsNullOrEmpty(txtDiaChi.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtDiaChi, "Không được để trống.");
                btnThem.Enabled = false;
                return;
            }
            ErrorChecker.Clear();
            btnThem.Enabled = true;
        }


        private void txtEmail_Leave(object sender, EventArgs e)
        {
            //  https://stackoverflow.com/a/19475049/7385686
            //  https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
            //  https://docs.microsoft.com/en-us/dotnet/standard/base-types/anchors-in-regular-expressions

            string pattern = @"\A[a-z0-9]+([-._][a-z0-9]+)*@([a-z0-9]+(-[a-z0-9]+)*\.)+[a-z]{2,4}\z";
            if (Regex.IsMatch(txtEmail.Text, pattern))
            {
                BUS_DaiLy nd = new BUS_DaiLy();
                if (nd.KTEmailTonTai(txtEmail.Text))
                {
                    ErrorChecker.Clear();
                    btnThem.Enabled = true;
                }
                else
                {
                    ErrorChecker.BlinkRate = 500;
                    ErrorChecker.SetError(txtEmail, "Email đã tồn tại trong hệ thống.");
                    btnThem.Enabled = false;
                    return;
                }
            }
            else
            {
                if (txtEmail.Text.Length == 0)
                {
                    ErrorChecker.Clear();
                    btnThem.Enabled = true;
                }
                else
                {
                    ErrorChecker.BlinkRate = 500;
                    ErrorChecker.SetError(txtEmail, "Email không hợp lệ.");
                    btnThem.Enabled = false;
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


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDaiLy.Text) || string.IsNullOrEmpty(txtTenDaiLy.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtTenDaiLy, "Không được để trống.");
                btnThem.Enabled = false;
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text) || string.IsNullOrEmpty(txtDiaChi.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtDiaChi, "Không được để trống.");
                btnThem.Enabled = false;
                return;
            }
            if (cbLoaiDL.EditValue == null)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(cbLoaiDL, "Không được để trống.");
                return;
            }
            if (cbQuan.EditValue == null)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(cbQuan, "Không được để trống.");
                return;
            }
            ErrorChecker.Clear();

            BUS_DaiLy dl = new BUS_DaiLy();
            dl.ThemDaiLy(txtTenDaiLy.Text, int.Parse(cbLoaiDL.EditValue.ToString()), txtDiaChi.Text, cbQuan.EditValue.ToString(), txtEmail.Text, DateTime.Parse(dtpNgayTiepNhan.EditValue.ToString()));

            var tb = MessageBox.Show("Bạn đã thêm đại lý thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (tb == DialogResult.OK)
            {
                txtTenDaiLy.Text = string.Empty;
                txtDiaChi.Text = string.Empty;
                txtEmail.Text = string.Empty;
                cbLoaiDL.EditValue = null;
                cbQuan.EditValue = null;

                KhiThemDaiLy(EventArgs.Empty);   //  https://msdn.microsoft.com/en-us/library/9aackb16(v=vs.110).aspx
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTenDaiLy.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cbLoaiDL.EditValue = null;
            cbQuan.EditValue = null;
        }
    }
}