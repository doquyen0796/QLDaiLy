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

                dgvDaiLy.DataSource = dbContext.DaiLies.Where(dl => dl.TinhTrang == 1).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


            // Make the grid read-only.
            gridViewDaiLy.OptionsBehavior.Editable = false;
            // Prevent the focused cell from being highlighted.
            gridViewDaiLy.OptionsSelection.EnableAppearanceFocusedCell = false;
            // Draw a dotted focus rectangle around the entire row.
            gridViewDaiLy.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
        }


        private List<int> st = new List<int> { 5, 10, 15, 20 };
        private void frmDaiLy_Load(object sender, EventArgs e)
        {
            BUS_DaiLy dl = new BUS_DaiLy();
            this.FormLoad();
            cbSoLuongSP.DataSource = st;
            int t = dl.SoLuongTrang(int.Parse(cbSoLuongSP.Text));
            cbTrang.DataSource = dl.DStrang(t);
            lbtrang.Text = "Trang " + cbTrang.Text + "/" + t.ToString();
            dgvDaiLy.DataSource = dl.DSdaili(int.Parse(cbTrang.Text), int.Parse(cbSoLuongSP.Text));
            if (int.Parse(cbTrang.Text) == 1)
            {
                btnlui.Enabled = false;
            }
            else
            {
                btnlui.Enabled = true;
            }
            if (int.Parse(cbTrang.Text) == t)
            {
                btntien.Enabled = false;
            }
            else
            {
                btntien.Enabled = true;
            }
        }


        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            var tukhoa = txtTuKhoa.Text;
            var query = db.DaiLies
                          .Where(dl => dl.TenDaiLy.ToLower().Contains(tukhoa.ToLower()) && dl.TinhTrang == 1)
                          .ToList();

            //daiLiesBindingSource.DataSource = query;
            dgvDaiLy.DataSource = query;

            if (string.IsNullOrEmpty(txtTuKhoa.Text))
            {
                //daiLiesBindingSource.DataSource = db.DaiLies.Where(dl => dl.TinhTrang == 1).ToList();
                dgvDaiLy.DataSource = db.DaiLies.Where(dl => dl.TinhTrang == 1).ToList();
            }
        }


        private void navbarSua_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //  https://stackoverflow.com/questions/12762617/how-to-get-the-selected-row-values-of-devexpress-xtragrid

            frmSuaDaiLy frm = new frmSuaDaiLy();
            frm.txtMaDaiLy.Text = gridViewDaiLy.GetFocusedRowCellValue("MaDaiLy").ToString();
            frm.dtpNgayTiepNhan.EditValue = gridViewDaiLy.GetFocusedRowCellValue("NgayTiepNhan").ToString();
            frm.txtTenDaiLy.Text = gridViewDaiLy.GetFocusedRowCellValue("TenDaiLy").ToString();
            frm.cbLoaiDL.EditValue = gridViewDaiLy.GetFocusedRowCellValue("Loai").ToString();
            frm.cbQuan.EditValue = gridViewDaiLy.GetFocusedRowCellValue("Quan").ToString();
            frm.txtDiaChi.Text = gridViewDaiLy.GetFocusedRowCellValue("DiaChi").ToString();
            frm.txtEmail.Text = gridViewDaiLy.GetFocusedRowCellValue("Email").ToString();
            frm.XuLySuaDaiLy += frmDaiLy_Load;
            frm.ShowDialog();
        }


        private void navbarXoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var flag = MessageBox.Show(string.Format("Bạn có chắc chắn muốn ngừng kinh doanh đại lý {0} ?", gridViewDaiLy.GetFocusedRowCellValue("TenDaiLy").ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (flag == DialogResult.Yes)
            {
                BUS_DaiLy dl = new BUS_DaiLy();
                int madl = int.Parse(gridViewDaiLy.GetFocusedRowCellValue("MaDaiLy").ToString());
                string tenquan = gridViewDaiLy.GetFocusedRowCellValue("Quan").ToString();
                var tb = dl.XoaDaiLy(madl, tenquan);

                if (tb == true)
                {
                    MessageBox.Show("Bạn đã ngừng kinh doanh đại lý thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.FormLoad();
                }
            }
            else
            {
                return;
            }
        }


        private void btnlui_Click(object sender, EventArgs e)
        {
            BUS_DaiLy dl = new BUS_DaiLy();
            cbTrang.Text = cbTrang.Text = (int.Parse(cbTrang.Text) - 1).ToString(); ;
            dgvDaiLy.DataSource = dl.DSdaili(int.Parse(cbTrang.Text), int.Parse(cbSoLuongSP.Text));
        }


        private void btntien_Click(object sender, EventArgs e)
        {
            BUS_DaiLy dl = new BUS_DaiLy();
            cbTrang.Text = (int.Parse(cbTrang.Text) + 1).ToString();
            dgvDaiLy.DataSource = dl.DSdaili(int.Parse(cbTrang.Text), int.Parse(cbSoLuongSP.Text));
        }


        private void cbSoLuongSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            BUS_DaiLy dl = new BUS_DaiLy();
            int t = dl.SoLuongTrang(int.Parse(cbSoLuongSP.Text));
            cbTrang.DataSource = dl.DStrang(t);
            if (int.Parse(cbTrang.Text) == 1)
            {
                btnlui.Enabled = false;
            }
            else
                btnlui.Enabled = true;
            if (int.Parse(cbTrang.Text) == t)
            {
                btntien.Enabled = false;
            }
            else
                btntien.Enabled = true;
            dgvDaiLy.DataSource = dl.DSdaili(int.Parse(cbTrang.Text), int.Parse(cbSoLuongSP.Text));
        }


        private void cbTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            BUS_DaiLy dl = new BUS_DaiLy();
            int t = dl.SoLuongTrang(int.Parse(cbSoLuongSP.Text));
            if (int.Parse(cbTrang.Text) == 1)
            {
                btnlui.Enabled = false;
            }
            else
                btnlui.Enabled = true;
            if (int.Parse(cbTrang.Text) == t)
            {
                btntien.Enabled = false;
            }
            else
                btntien.Enabled = true;
            lbtrang.Text = "Trang " + cbTrang.Text + "/" + t.ToString();
            dgvDaiLy.DataSource = dl.DSdaili(int.Parse(cbTrang.Text), int.Parse(cbSoLuongSP.Text));
        }


        private void navBarSoDaiLyToiDa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmSoDaiLyToiDa frm = new frmSoDaiLyToiDa();
            frm.ShowDialog();
        }


        private void navBarUndo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmDLNgungKinhDoanh frm = new frmDLNgungKinhDoanh();
            frm.ShowDialog();
        }
    }
}