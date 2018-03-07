using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDaiLy
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var thongbao = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình ?", "Thoát ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (thongbao == DialogResult.Yes)
            {
                e.Cancel = false;
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTTPhanMem thongtin = new frmTTPhanMem();
            thongtin.ShowDialog();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var thongbao = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất ?", "Đăng xuất ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (thongbao == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap dangnhap = new frmDangNhap();
                dangnhap.Show();
            }
            else
            {
                return;
            }
        }

        private void btnTTTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTTTaiKhoan frmTT = new frmTTTaiKhoan();
            frmTT.ShowDialog();
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhau frmDMK = new frmDoiMatKhau();
            frmDMK.ShowDialog();
        }
    }
}