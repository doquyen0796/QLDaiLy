﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using BUS;

namespace QLDaiLy
{
    public partial class frmDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        DAL.QLDaiLyEntities db = new DAL.QLDaiLyEntities();


        public frmDonViTinh()
        {
            InitializeComponent();
        }


        private void FormLoad()
        {
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            DAL.QLDaiLyEntities dbContext = new DAL.QLDaiLyEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.DonViTinhs.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                //donViTinhsBindingSource.DataSource = dbContext.DonViTinhs.Local.ToBindingList();

                donViTinhsBindingSource.DataSource = dbContext.DonViTinhs.Where(dvt => dvt.TinhTrang == 1).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


            // Make the grid read-only.
            gridViewDVT.OptionsBehavior.Editable = false;
            // Prevent the focused cell from being highlighted.
            gridViewDVT.OptionsSelection.EnableAppearanceFocusedCell = false;
            // Draw a dotted focus rectangle around the entire row.
            gridViewDVT.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
        }


        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            this.FormLoad();
        }


        private void navbarThem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThemDVT frm = new frmThemDVT();
            frm.XuLyThemDVT += frmDonViTinh_Load;
            frm.ShowDialog();
        }


        private void navbarSua_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmSuaDVT frm = new frmSuaDVT();
            frm.txtTenDVT.Text = gridViewDVT.GetFocusedRowCellValue("TenDVT").ToString();
            frm.txtMaDVT.Text = gridViewDVT.GetFocusedRowCellValue("MaDVT").ToString();
            frm.XuLySuaDVT += frmDonViTinh_Load;
            frm.ShowDialog();
        }


        private void navbarXoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string tendvt = gridViewDVT.GetFocusedRowCellValue("TenDVT").ToString();
            var tb = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa đơn vị tính <{0}> ?", tendvt), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (tb == DialogResult.Yes)
            {
                int madvt = int.Parse(gridViewDVT.GetFocusedRowCellValue("MaDVT").ToString());
                BUS_DonViTinh dvt = new BUS_DonViTinh();
                var flag = dvt.XoaDonViTinh(madvt);

                if (flag == true)
                {
                    MessageBox.Show(string.Format("Bạn đã xóa đơn vị tính <{0}> thành công.", tendvt), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.FormLoad();
                }
            }
            else
            {
                return;
            }
        }


        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            var tukhoa = txtTuKhoa.Text;
            var query = db.DonViTinhs
                          .Where(d => d.TenDVT.ToLower().Contains(tukhoa.ToLower()) && d.TinhTrang == 1)
                          .ToList();

            donViTinhsBindingSource.DataSource = query;

            if (string.IsNullOrEmpty(txtTuKhoa.Text))
            {
                donViTinhsBindingSource.DataSource = db.DonViTinhs.Where(d => d.TinhTrang == 1).ToList();
            }
        }


        private void navBarUndo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmDVTNgungKinhDoanh frm = new frmDVTNgungKinhDoanh();
            frm.XuLySuDungLaiDVT += frmDonViTinh_Load;
            frm.ShowDialog();
        }
    }
}