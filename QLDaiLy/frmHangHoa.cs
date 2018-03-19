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
    public partial class frmHangHoa : DevExpress.XtraEditors.XtraForm
    {
        DAL.QLDaiLyEntities db = new DAL.QLDaiLyEntities();

        public frmHangHoa()
        {
            InitializeComponent();
        }


        private void FormLoad()
        {
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            DAL.QLDaiLyEntities dbContext = new DAL.QLDaiLyEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.HangHoas.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                hangHoasBindingSource.DataSource = dbContext.HangHoas.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


            // Make the grid read-only.
            gridViewHangHoa.OptionsBehavior.Editable = false;
            // Prevent the focused cell from being highlighted.
            gridViewHangHoa.OptionsSelection.EnableAppearanceFocusedCell = false;
            // Draw a dotted focus rectangle around the entire row.
            gridViewHangHoa.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
        }


        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            this.FormLoad();
        }


        private void navbarThem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThemHangHoa frm = new frmThemHangHoa();
            frm.XuLyThemHangHoa += frmHangHoa_Load;
            frm.ShowDialog();
        }


        private void navbarSua_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //  https://stackoverflow.com/questions/12762617/how-to-get-the-selected-row-values-of-devexpress-xtragrid

            frmSuaHangHoa frm = new frmSuaHangHoa();
            frm.txtMaHH.Text = gridViewHangHoa.GetFocusedRowCellValue("MaHangHoa").ToString();
            frm.txtTenHangHoa.Text = gridViewHangHoa.GetFocusedRowCellValue("TenHangHoa").ToString();
            frm.cbDVT.EditValue = gridViewHangHoa.GetFocusedRowCellValue("DVT").ToString();
            frm.txtDonGia.Text = gridViewHangHoa.GetFocusedRowCellValue("DonGia").ToString();
            frm.XuLySuaHangHoa += frmHangHoa_Load;
            frm.ShowDialog();
        }
    }
}