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
    public partial class frmDuyetNV : DevExpress.XtraEditors.XtraForm
    {
        DAL.QLDaiLyEntities db = new DAL.QLDaiLyEntities();

        public frmDuyetNV()
        {
            InitializeComponent();
        }


        private void FormLoad()
        {
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            DAL.QLDaiLyEntities dbContext = new DAL.QLDaiLyEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.NguoiDungs.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                //nguoiDungsBindingSource.DataSource = dbContext.NguoiDungs.Local.ToBindingList();

                nguoiDungsBindingSource.DataSource = dbContext.NguoiDungs.Where(nd => nd.Loai == -1 && nd.TinhTrang == 1).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


            // Make the grid read-only.
            //gridViewNVMoi.OptionsBehavior.Editable = false;
            // Prevent the focused cell from being highlighted.
            gridViewNVMoi.OptionsSelection.EnableAppearanceFocusedCell = false;
            // Draw a dotted focus rectangle around the entire row.
            gridViewNVMoi.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
        }


        private void frmDuyetNV_Load(object sender, EventArgs e)
        {
            this.FormLoad();
        }


        private void btnDuyet_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int mand = int.Parse(gridViewNVMoi.GetFocusedRowCellValue("MaNguoiDung").ToString());
            string tennd = gridViewNVMoi.GetFocusedRowCellValue("TenDangNhap").ToString();
            var tb = MessageBox.Show(string.Format("Bạn có chắc chắn muốn duyệt nhân viên <{0}> ?", tennd), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (tb == DialogResult.Yes)
            {
                BUS_NguoiDung nd = new BUS_NguoiDung();
                var flag = nd.DuyetNguoiDung(mand);
                if (flag == true)
                {
                    MessageBox.Show(string.Format("Bạn đã duyệt nhân viên <{0}> thành công.", tennd), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.FormLoad();
                }
                else
                {
                    MessageBox.Show("Lỗi.\nBạn cần kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var query = db.NguoiDungs
                          .Where(u => u.TenDangNhap.ToLower().Contains(tukhoa.ToLower()) && u.TinhTrang == 1 && u.Loai == -1 || u.Email.ToLower().Contains(tukhoa.ToLower()) && u.TinhTrang == 1 && u.Loai == -1)
                          .ToList();

            nguoiDungsBindingSource.DataSource = query;

            if (string.IsNullOrEmpty(txtTuKhoa.Text))
            {
                nguoiDungsBindingSource.DataSource = db.NguoiDungs.Where(u => u.TinhTrang == 1 && u.Loai == -1).ToList();
            }
        }
    }
}