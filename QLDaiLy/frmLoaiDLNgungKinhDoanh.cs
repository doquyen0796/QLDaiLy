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

namespace QLDaiLy
{
    public partial class frmLoaiDLNgungKinhDoanh : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiDLNgungKinhDoanh()
        {
            InitializeComponent();
        }


        private void FormLoad()
        {
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            DAL.QLDaiLyEntities dbContext = new DAL.QLDaiLyEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.LoaiDaiLies.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                //loaiDaiLiesBindingSource.DataSource = dbContext.LoaiDaiLies.Local.ToBindingList();

                loaiDaiLiesBindingSource.DataSource = dbContext.LoaiDaiLies.Where(l => l.TinhTrang == 0).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


            // Prevent the focused cell from being highlighted.
            gridViewLDLNgungKD.OptionsSelection.EnableAppearanceFocusedCell = false;
            // Draw a dotted focus rectangle around the entire row.
            gridViewLDLNgungKD.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
        }


        private void frmLoaiDLNgungKinhDoanh_Load(object sender, EventArgs e)
        {
            this.FormLoad();
        }


        private void btnKinhDoanh_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }


        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}