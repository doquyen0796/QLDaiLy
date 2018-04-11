using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

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
                BUS_NguoiDung nd = new BUS_NguoiDung();
                var flag = nd.DangXuat();

                if (flag == true)
                {
                    this.Hide();
                    frmDangNhap dangnhap = new frmDangNhap();
                    dangnhap.Show();
                }
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

        private bool ExistForm(Form f)
        {
            bool isOpen = false;
            if (MdiChildren.Count() > 0)
            {
                foreach (Form child in MdiChildren)
                {
                    if (f.Name == child.Name)
                    {
                        tabManager.Pages[child].MdiChild.Activate();
                        isOpen = true;
                    }
                }
            }
            return isOpen;
        }

        private void ViewForm(Form f)
        {
            if (ExistForm(f) == false)
            {
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDaiLy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDaiLy frm = new frmDaiLy();
            ViewForm(frm);
        }

        private void btnXuatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmXuatHang frm = new frmXuatHang();
            ViewForm(frm);
        }

        private void btnThuTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThuTien frm = new frmThuTien();
            ViewForm(frm);
        }

        private void btnHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHangHoa frm = new frmHangHoa();
            ViewForm(frm);
        }

        private void btnDonViTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDonViTinh frm = new frmDonViTinh();
            ViewForm(frm);
        }

        private void btnBaoCaoDS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBaoCaoDS frm = new frmBaoCaoDS();
            ViewForm(frm);
        }

        private void btnBaoCaoCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBaoCaoCN frm = new frmBaoCaoCN();
            ViewForm(frm);
        }

        private void btnDSNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDSNV frm = new frmDSNV();
            ViewForm(frm);
        }

        private void btnDuyetNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDuyetNV frm = new frmDuyetNV();
            ViewForm(frm);
        }


        private void btnLoaiDaiLy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLoaiDaiLy frm = new frmLoaiDaiLy();
            ViewForm(frm);
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            int flag = (int)BUS_NguoiDung.CurUser.Loai;

            if (flag != 1)
            {
                ribbonPageQuanTri.Visible = false;
                //ribbonGroupQLNV.Enabled = false;
            }
        }
    }
}