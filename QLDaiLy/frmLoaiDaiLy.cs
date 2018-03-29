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
    public partial class frmLoaiDaiLy : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiDaiLy()
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

                loaiDaiLiesBindingSource.DataSource = dbContext.LoaiDaiLies.Where(l => l.TinhTrang == 1).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


            // Make the grid read-only.
            gridViewLoaiDaiLy.OptionsBehavior.Editable = false;
            // Prevent the focused cell from being highlighted.
            gridViewLoaiDaiLy.OptionsSelection.EnableAppearanceFocusedCell = false;
            // Draw a dotted focus rectangle around the entire row.
            gridViewLoaiDaiLy.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
        }


        private void frmLoaiDaiLy_Load(object sender, EventArgs e)
        {
            this.FormLoad();
        }


        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {

        }


        private void navbarThem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThemLoaiDaiLy frm = new frmThemLoaiDaiLy();
            frm.ShowDialog();
        }


        private void navbarSua_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmSuaLoaiDaiLy frm = new frmSuaLoaiDaiLy();
            frm.ShowDialog();
        }


        private void navbarXoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }
    }
}