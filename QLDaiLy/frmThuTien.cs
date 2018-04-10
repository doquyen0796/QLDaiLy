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
    public partial class frmThuTien : DevExpress.XtraEditors.XtraForm
    {
        public frmThuTien()
        {
            InitializeComponent();
        }


        private void FormLoad()
        {
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            DAL.QLDaiLyEntities dbContext = new DAL.QLDaiLyEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.PhieuThuTiens.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                phieuThuTiensBindingSource.DataSource = dbContext.PhieuThuTiens.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


            // Prevent the focused cell from being highlighted.
            gridViewThuTien.OptionsSelection.EnableAppearanceFocusedCell = false;
            // Draw a dotted focus rectangle around the entire row.
            gridViewThuTien.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
        }


        private void frmThuTien_Load(object sender, EventArgs e)
        {
            this.FormLoad();
        }


        private void navbarThem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmLapPhieuThuTien frm = new frmLapPhieuThuTien();
            frm.XuLyThemPhieuThu += frmThuTien_Load;
            frm.ShowDialog();
        }


        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}