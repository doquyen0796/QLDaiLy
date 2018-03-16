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
    public partial class frmDaiLy : DevExpress.XtraEditors.XtraForm
    {
        DAL.QLDaiLyEntities db = new DAL.QLDaiLyEntities();

        public frmDaiLy()
        {
            InitializeComponent();
        }


        private void navbarThem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThemDaiLy frm = new frmThemDaiLy();
            frm.XuLyThemDaiLy += frmDaiLy_Load;
            frm.ShowDialog();
        }


        private void frmDaiLy_Load(object sender, EventArgs e)
        {
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            DAL.QLDaiLyEntities dbContext = new DAL.QLDaiLyEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.DaiLies.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                daiLiesBindingSource.DataSource = dbContext.DaiLies.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


            // Make the grid read-only.
            gridView1.OptionsBehavior.Editable = false;
            // Prevent the focused cell from being highlighted.
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // Draw a dotted focus rectangle around the entire row.
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
        }


        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            var tukhoa = txtTuKhoa.Text;
            var query = db.DaiLies.Where(dl => dl.TenDaiLy.ToLower().Contains(tukhoa.ToLower())).ToList();

            daiLiesBindingSource.DataSource = query;

            if (string.IsNullOrEmpty(txtTuKhoa.Text))
            {
                daiLiesBindingSource.DataSource = db.DaiLies.Local.ToBindingList();
            }
        }
    }
}