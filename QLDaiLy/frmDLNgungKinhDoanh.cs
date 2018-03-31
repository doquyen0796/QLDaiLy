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
    public partial class frmDLNgungKinhDoanh : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler XuLyKinhDoanhLaiDaiLy;

        private void KhiKinhDoanhLaiDaiLy(EventArgs e)
        {
            var handler = XuLyKinhDoanhLaiDaiLy;
            if (handler != null)
            {
                handler(this, e);
            }
        }


        DAL.QLDaiLyEntities db = new DAL.QLDaiLyEntities();


        public frmDLNgungKinhDoanh()
        {
            InitializeComponent();
        }


        private void FormLoad()
        {
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            DAL.QLDaiLyEntities dbContext = new DAL.QLDaiLyEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.DaiLies.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                //daiLiesBindingSource.DataSource = dbContext.DaiLies.Local.ToBindingList();

                daiLiesBindingSource.DataSource = dbContext.DaiLies.Where(d => d.TinhTrang == 0).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


            // Prevent the focused cell from being highlighted.
            gridViewDLNgungKD.OptionsSelection.EnableAppearanceFocusedCell = false;
            // Draw a dotted focus rectangle around the entire row.
            gridViewDLNgungKD.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
        }


        private void frmDLNgungKinhDoanh_Load(object sender, EventArgs e)
        {
            this.FormLoad();
        }


        private void btnKinhDoanh_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int madl = int.Parse(gridViewDLNgungKD.GetFocusedRowCellValue("MaDaiLy").ToString());
            string tendl = gridViewDLNgungKD.GetFocusedRowCellValue("TenDaiLy").ToString();
            string quan = gridViewDLNgungKD.GetFocusedRowCellValue("Quan").ToString();

            var tb = MessageBox.Show(string.Format("Bạn có chắc chắn muốn tiếp tục kinh doanh đại lý <{0}> ?", tendl), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (tb == DialogResult.Yes)
            {
                BUS_DaiLy daily = new BUS_DaiLy();
                var flag = daily.TiepTucKinhDoanh(madl, quan);
                if (flag == true)
                {
                    MessageBox.Show(string.Format("Bạn đã tiếp tục kinh doanh đại lý <{0}> thành công.", tendl), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.FormLoad();
                    KhiKinhDoanhLaiDaiLy(EventArgs.Empty);   //  https://msdn.microsoft.com/en-us/library/9aackb16(v=vs.110).aspx
                }
                else
                {
                    MessageBox.Show(string.Format("Thao tác không thành công. {0} đã đạt đến số đại lý tối đa.", quan), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var query = db.DaiLies
                          .Where(dl => dl.TenDaiLy.ToLower().Contains(tukhoa.ToLower()) && dl.TinhTrang == 0)
                          .ToList();

            daiLiesBindingSource.DataSource = query;

            if (string.IsNullOrEmpty(txtTuKhoa.Text))
            {
                daiLiesBindingSource.DataSource = db.DaiLies.Where(dl => dl.TinhTrang == 0).ToList();
            }
        }
    }
}