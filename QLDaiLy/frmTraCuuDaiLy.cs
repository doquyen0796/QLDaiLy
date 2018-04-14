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
using BUS;
using DevExpress.XtraEditors.Controls;
using System.Data.Entity;

namespace QLDaiLy
{
    public partial class frmTraCuuDaiLy : DevExpress.XtraEditors.XtraForm
    {
        DAL.QLDaiLyEntities db = new DAL.QLDaiLyEntities();


        public frmTraCuuDaiLy()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            DAL.QLDaiLyEntities dbContext = new DAL.QLDaiLyEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.DaiLies.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                // daiLiesBindingSource.DataSource = dbContext.DaiLies.Local.ToBindingList();

                daiLiesBindingSource.DataSource = dbContext.DaiLies.Where(d => d.TinhTrang == 1).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


            // Make the grid read-only.
            gridViewDaiLy.OptionsBehavior.Editable = false;
            // Prevent the focused cell from being highlighted.
            gridViewDaiLy.OptionsSelection.EnableAppearanceFocusedCell = false;
            // Draw a dotted focus rectangle around the entire row.
            gridViewDaiLy.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
        }


        private void frmTraCuuDaiLy_Load(object sender, EventArgs e)
        {
            //  https://www.devexpress.com/Support/Center/Question/Details/Q20064/comboboxedit-how-do-you-set-the-datasource

            //  Lookup-edit Loại Đại lý
            BUS_LoaiDaiLy dl = new BUS_LoaiDaiLy();
            cbLoaiDL.Properties.DataSource = dl.DanhSachLoaiDL();

            cbLoaiDL.Properties.DisplayMember = "TenLoai";
            cbLoaiDL.Properties.ValueMember = "MaLoai";
            cbLoaiDL.Properties.Columns.Add(new LookUpColumnInfo("TenLoai", "Loại Đại Lý"));


            //  Lookup-edit Quận
            BUS_Quan q = new BUS_Quan();
            cbQuan.Properties.DataSource = q.DanhSachQuan();

            cbQuan.Properties.DisplayMember = "TenQuan";
            cbQuan.Properties.ValueMember = "TenQuan";
            cbQuan.Properties.Columns.Add(new LookUpColumnInfo("TenQuan", "Quận"));
        }


        private void txtNoTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }


            //  https://www.devexpress.com/Support/Center/Question/Details/T227028/how-can-i-format-a-textbox-to-show-currency-and-percent-with-currentculture

            txtNoTu.Properties.DisplayFormat.FormatString = "{0:N0}";
            txtNoTu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            txtNoTu.Properties.Mask.EditMask = "n0";
            txtNoTu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
        }


        private void txtNoDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }


            //  https://www.devexpress.com/Support/Center/Question/Details/T227028/how-can-i-format-a-textbox-to-show-currency-and-percent-with-currentculture

            txtNoDen.Properties.DisplayFormat.FormatString = "{0:N0}";
            txtNoDen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            txtNoDen.Properties.Mask.EditMask = "n0";
            txtNoDen.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
        }


        private void txtTenDaiLy_TextChanged(object sender, EventArgs e)
        {
            var tukhoa = txtTenDaiLy.Text;
            var query = db.DaiLies
                          .Where(dl => dl.TenDaiLy.ToLower().Contains(tukhoa.ToLower()) && dl.TinhTrang == 1)
                          .ToList();

            //daiLiesBindingSource.DataSource = query;
            dgvDaiLy.DataSource = query;

            if (string.IsNullOrEmpty(txtTenDaiLy.Text))
            {
                //daiLiesBindingSource.DataSource = db.DaiLies.Where(dl => dl.TinhTrang == 1).ToList();
                dgvDaiLy.DataSource = db.DaiLies.Where(dl => dl.TinhTrang == 1).ToList();
            }
        }


        private void cbQuan_EditValueChanged(object sender, EventArgs e)
        {
            string quan = cbQuan.EditValue.ToString();

            var query = db.DaiLies
                          .Where(dl => dl.Quan == quan && dl.TinhTrang == 1)
                          .ToList();

            dgvDaiLy.DataSource = query;
        }


        private void cbLoaiDL_EditValueChanged(object sender, EventArgs e)
        {
            int maloai = int.Parse(cbLoaiDL.EditValue.ToString());

            var query = db.DaiLies
                          .Where(dl => dl.Loai == maloai && dl.TinhTrang == 1)
                          .ToList();

            dgvDaiLy.DataSource = query;
        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDaiLy.Text) && cbQuan.EditValue == null && cbLoaiDL.EditValue == null && string.IsNullOrEmpty(txtNoTu.Text) && string.IsNullOrEmpty(txtNoDen.Text))
            {
                MessageBox.Show("Bạn phải nhập ít nhất 1 thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // tìm theo tất cả tiêu chí
                if (!string.IsNullOrEmpty(txtTenDaiLy.Text) && cbQuan.EditValue != null && cbLoaiDL.EditValue != null && !string.IsNullOrEmpty(txtNoTu.Text) && !string.IsNullOrEmpty(txtNoDen.Text))
                {
                    var tukhoa = txtTenDaiLy.Text;
                    string quan = cbQuan.EditValue.ToString();
                    int loai = int.Parse(cbLoaiDL.EditValue.ToString());
                    double NoTu = double.Parse(txtNoTu.Text);
                    double NoDen = double.Parse(txtNoDen.Text);

                    if (NoTu <= NoDen)
                    {
                        var query = db.DaiLies
                                  .Where(dl => dl.TenDaiLy.ToLower().Contains(tukhoa.ToLower()) 
                                        && dl.Quan == quan
                                        && dl.Loai == loai
                                        && dl.TienNo >= NoTu && dl.TienNo <= NoDen 
                                        && dl.TinhTrang == 1)
                                  .ToList();

                        dgvDaiLy.DataSource = query;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Nợ từ phải nhỏ hơn hoặc bằng nợ đến.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Tên - Quận - Loại - Nợ từ
                if (!string.IsNullOrEmpty(txtTenDaiLy.Text) && cbQuan.EditValue != null && cbLoaiDL.EditValue != null && !string.IsNullOrEmpty(txtNoTu.Text))
                {
                    var tukhoa = txtTenDaiLy.Text;
                    string quan = cbQuan.EditValue.ToString();
                    int loai = int.Parse(cbLoaiDL.EditValue.ToString());
                    double NoTu = double.Parse(txtNoTu.Text);

                    var query = db.DaiLies
                                .Where(dl => dl.TenDaiLy.ToLower().Contains(tukhoa.ToLower())
                                    && dl.Quan == quan
                                    && dl.Loai == loai
                                    && dl.TienNo >= NoTu
                                    && dl.TinhTrang == 1)
                                .ToList();

                    dgvDaiLy.DataSource = query;
                    return;
                }

                // Tên - Quận - Loại - Nợ đến
                if (!string.IsNullOrEmpty(txtTenDaiLy.Text) && cbQuan.EditValue != null && cbLoaiDL.EditValue != null && !string.IsNullOrEmpty(txtNoDen.Text))
                {
                    var tukhoa = txtTenDaiLy.Text;
                    string quan = cbQuan.EditValue.ToString();
                    int loai = int.Parse(cbLoaiDL.EditValue.ToString());
                    double NoDen = double.Parse(txtNoDen.Text);

                    var query = db.DaiLies
                                .Where(dl => dl.TenDaiLy.ToLower().Contains(tukhoa.ToLower())
                                    && dl.Quan == quan
                                    && dl.Loai == loai
                                    && dl.TienNo <= NoDen
                                    && dl.TinhTrang == 1)
                                .ToList();

                    dgvDaiLy.DataSource = query;
                    return;
                }

                // Tên - Quận - Nợ từ - Nợ đến
                if (!string.IsNullOrEmpty(txtTenDaiLy.Text) && cbQuan.EditValue != null && !string.IsNullOrEmpty(txtNoTu.Text) && !string.IsNullOrEmpty(txtNoDen.Text))
                {
                    var tukhoa = txtTenDaiLy.Text;
                    string quan = cbQuan.EditValue.ToString();
                    double NoTu = double.Parse(txtNoTu.Text);
                    double NoDen = double.Parse(txtNoDen.Text);

                    if (NoTu <= NoDen)
                    {
                        var query = db.DaiLies
                                  .Where(dl => dl.TenDaiLy.ToLower().Contains(tukhoa.ToLower())
                                        && dl.Quan == quan
                                        && dl.TienNo >= NoTu && dl.TienNo <= NoDen
                                        && dl.TinhTrang == 1)
                                  .ToList();

                        dgvDaiLy.DataSource = query;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Nợ từ phải nhỏ hơn hoặc bằng nợ đến.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Tên - Loại - Nợ từ - Nợ đến
                if (!string.IsNullOrEmpty(txtTenDaiLy.Text) && cbLoaiDL.EditValue != null && !string.IsNullOrEmpty(txtNoTu.Text) && !string.IsNullOrEmpty(txtNoDen.Text))
                {
                    var tukhoa = txtTenDaiLy.Text;
                    int loai = int.Parse(cbLoaiDL.EditValue.ToString());
                    double NoTu = double.Parse(txtNoTu.Text);
                    double NoDen = double.Parse(txtNoDen.Text);

                    if (NoTu <= NoDen)
                    {
                        var query = db.DaiLies
                                  .Where(dl => dl.TenDaiLy.ToLower().Contains(tukhoa.ToLower())
                                        && dl.Loai == loai
                                        && dl.TienNo >= NoTu && dl.TienNo <= NoDen
                                        && dl.TinhTrang == 1)
                                  .ToList();

                        dgvDaiLy.DataSource = query;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Nợ từ phải nhỏ hơn hoặc bằng nợ đến.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Tên - Quận - Loại
                if (!string.IsNullOrEmpty(txtTenDaiLy.Text) && cbQuan.EditValue != null && cbLoaiDL.EditValue != null)
                {
                    var tukhoa = txtTenDaiLy.Text;
                    string quan = cbQuan.EditValue.ToString();
                    int loai = int.Parse(cbLoaiDL.EditValue.ToString());

                    var query = db.DaiLies
                                .Where(dl => dl.TenDaiLy.ToLower().Contains(tukhoa.ToLower())
                                    && dl.Quan == quan
                                    && dl.Loai == loai
                                    && dl.TinhTrang == 1)
                                .ToList();

                    dgvDaiLy.DataSource = query;
                    return;
                }

                // Tên - Quận - Nợ từ
                if (!string.IsNullOrEmpty(txtTenDaiLy.Text) && cbQuan.EditValue != null && !string.IsNullOrEmpty(txtNoTu.Text))
                {
                    var tukhoa = txtTenDaiLy.Text;
                    string quan = cbQuan.EditValue.ToString();
                    double NoTu = double.Parse(txtNoTu.Text);

                    var query = db.DaiLies
                                .Where(dl => dl.TenDaiLy.ToLower().Contains(tukhoa.ToLower())
                                    && dl.Quan == quan
                                    && dl.TienNo >= NoTu
                                    && dl.TinhTrang == 1)
                                .ToList();

                    dgvDaiLy.DataSource = query;
                    return;
                }

                // Tên - Quận - Nợ đến
                if (!string.IsNullOrEmpty(txtTenDaiLy.Text) && cbQuan.EditValue != null && !string.IsNullOrEmpty(txtNoDen.Text))
                {
                    var tukhoa = txtTenDaiLy.Text;
                    string quan = cbQuan.EditValue.ToString();
                    double NoDen = double.Parse(txtNoDen.Text);

                    var query = db.DaiLies
                                .Where(dl => dl.TenDaiLy.ToLower().Contains(tukhoa.ToLower())
                                    && dl.Quan == quan
                                    && dl.TienNo <= NoDen
                                    && dl.TinhTrang == 1)
                                .ToList();

                    dgvDaiLy.DataSource = query;
                    return;
                }

                // Tên - Loại - Nợ từ
                if (!string.IsNullOrEmpty(txtTenDaiLy.Text) && cbLoaiDL.EditValue != null && !string.IsNullOrEmpty(txtNoTu.Text))
                {
                    var tukhoa = txtTenDaiLy.Text;
                    int loai = int.Parse(cbLoaiDL.EditValue.ToString());
                    double NoTu = double.Parse(txtNoTu.Text);

                    var query = db.DaiLies
                                .Where(dl => dl.TenDaiLy.ToLower().Contains(tukhoa.ToLower())
                                    && dl.Loai == loai
                                    && dl.TienNo >= NoTu
                                    && dl.TinhTrang == 1)
                                .ToList();

                    dgvDaiLy.DataSource = query;
                    return;
                }

                // Tên - Loại - Nợ đến
                if (!string.IsNullOrEmpty(txtTenDaiLy.Text) && cbLoaiDL.EditValue != null && !string.IsNullOrEmpty(txtNoDen.Text))
                {
                    var tukhoa = txtTenDaiLy.Text;
                    int loai = int.Parse(cbLoaiDL.EditValue.ToString());
                    double NoDen = double.Parse(txtNoDen.Text);

                    var query = db.DaiLies
                                .Where(dl => dl.TenDaiLy.ToLower().Contains(tukhoa.ToLower())
                                    && dl.Loai == loai
                                    && dl.TienNo <= NoDen
                                    && dl.TinhTrang == 1)
                                .ToList();

                    dgvDaiLy.DataSource = query;
                    return;
                }

                // Quận - Loại - Nợ từ - Nợ đến
                if (cbQuan.EditValue != null && cbLoaiDL.EditValue != null && !string.IsNullOrEmpty(txtNoTu.Text) && !string.IsNullOrEmpty(txtNoDen.Text))
                {
                    string quan = cbQuan.EditValue.ToString();
                    int loai = int.Parse(cbLoaiDL.EditValue.ToString());
                    double NoTu = double.Parse(txtNoTu.Text);
                    double NoDen = double.Parse(txtNoDen.Text);

                    if (NoTu <= NoDen)
                    {
                        var query = db.DaiLies
                                  .Where(dl => dl.Quan == quan
                                        && dl.Loai == loai
                                        && dl.TienNo >= NoTu && dl.TienNo <= NoDen
                                        && dl.TinhTrang == 1)
                                  .ToList();

                        dgvDaiLy.DataSource = query;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Nợ từ phải nhỏ hơn hoặc bằng nợ đến.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Quận - Loại - Nợ từ
                if (cbQuan.EditValue != null && cbLoaiDL.EditValue != null && !string.IsNullOrEmpty(txtNoTu.Text))
                {
                    string quan = cbQuan.EditValue.ToString();
                    int loai = int.Parse(cbLoaiDL.EditValue.ToString());
                    double NoTu = double.Parse(txtNoTu.Text);

                    var query = db.DaiLies
                                .Where(dl => dl.Quan == quan
                                    && dl.Loai == loai
                                    && dl.TienNo >= NoTu
                                    && dl.TinhTrang == 1)
                                .ToList();

                    dgvDaiLy.DataSource = query;
                    return;
                }

                // Quận - Loại - Nợ đến
                if (cbQuan.EditValue != null && cbLoaiDL.EditValue != null && !string.IsNullOrEmpty(txtNoDen.Text))
                {
                    string quan = cbQuan.EditValue.ToString();
                    int loai = int.Parse(cbLoaiDL.EditValue.ToString());
                    double NoDen = double.Parse(txtNoDen.Text);

                    var query = db.DaiLies
                                .Where(dl => dl.Quan == quan
                                    && dl.Loai == loai
                                    && dl.TienNo <= NoDen
                                    && dl.TinhTrang == 1)
                                .ToList();

                    dgvDaiLy.DataSource = query;
                    return;
                }

                // Tên - Quận
                if (!string.IsNullOrEmpty(txtTenDaiLy.Text) && cbQuan.EditValue != null)
                {
                    var tukhoa = txtTenDaiLy.Text;
                    string quan = cbQuan.EditValue.ToString();

                    var query = db.DaiLies
                                  .Where(dl => dl.TenDaiLy.ToLower().Contains(tukhoa.ToLower()) && dl.Quan == quan && dl.TinhTrang == 1)
                                  .ToList();

                    dgvDaiLy.DataSource = query;
                    return;
                }

                // Tên - Loại
                if (!string.IsNullOrEmpty(txtTenDaiLy.Text) && cbLoaiDL.EditValue != null)
                {
                    var tukhoa = txtTenDaiLy.Text;
                    int loai = int.Parse(cbLoaiDL.EditValue.ToString());

                    var query = db.DaiLies
                                  .Where(dl => dl.TenDaiLy.ToLower().Contains(tukhoa.ToLower()) && dl.Loai == loai && dl.TinhTrang == 1)
                                  .ToList();

                    dgvDaiLy.DataSource = query;
                    return;
                }

                // Tên - Nợ
                if (!string.IsNullOrEmpty(txtTenDaiLy.Text) && !string.IsNullOrEmpty(txtNoTu.Text) && !string.IsNullOrEmpty(txtNoDen.Text))
                {
                    var tukhoa = txtTenDaiLy.Text;
                    double NoTu = double.Parse(txtNoTu.Text);
                    double NoDen = double.Parse(txtNoDen.Text);

                    if (NoTu <= NoDen)
                    {
                        var query = db.DaiLies
                                  .Where(dl => dl.TenDaiLy.ToLower().Contains(tukhoa.ToLower())
                                        && dl.TienNo >= NoTu && dl.TienNo <= NoDen
                                        && dl.TinhTrang == 1)
                                  .ToList();

                        dgvDaiLy.DataSource = query;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Nợ từ phải nhỏ hơn hoặc bằng nợ đến.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Tên - Nợ từ
                if (!string.IsNullOrEmpty(txtTenDaiLy.Text) && !string.IsNullOrEmpty(txtNoTu.Text))
                {
                    var tukhoa = txtTenDaiLy.Text;
                    double NoTu = double.Parse(txtNoTu.Text);

                    var query = db.DaiLies
                                .Where(dl => dl.TenDaiLy.ToLower().Contains(tukhoa.ToLower())
                                    && dl.TienNo >= NoTu
                                    && dl.TinhTrang == 1)
                                .ToList();

                    dgvDaiLy.DataSource = query;
                    return;
                }

                // Tên - Nợ đến
                if (!string.IsNullOrEmpty(txtTenDaiLy.Text) && !string.IsNullOrEmpty(txtNoDen.Text))
                {
                    var tukhoa = txtTenDaiLy.Text;
                    double NoDen = double.Parse(txtNoDen.Text);

                    var query = db.DaiLies
                                .Where(dl => dl.TenDaiLy.ToLower().Contains(tukhoa.ToLower())
                                    && dl.TienNo <= NoDen
                                    && dl.TinhTrang == 1)
                                .ToList();

                    dgvDaiLy.DataSource = query;
                    return;
                }

                // Quận - Loại
                if (cbQuan.EditValue != null && cbLoaiDL.EditValue != null)
                {
                    string quan = cbQuan.EditValue.ToString();
                    int loai = int.Parse(cbLoaiDL.EditValue.ToString());

                    var query = db.DaiLies
                                .Where(dl => dl.Quan == quan
                                    && dl.Loai == loai
                                    && dl.TinhTrang == 1)
                                .ToList();

                    dgvDaiLy.DataSource = query;
                    return;
                }

                // Quận - Nợ
                if (cbQuan.EditValue != null && !string.IsNullOrEmpty(txtNoTu.Text) && !string.IsNullOrEmpty(txtNoDen.Text))
                {
                    string quan = cbQuan.EditValue.ToString();
                    double NoTu = double.Parse(txtNoTu.Text);
                    double NoDen = double.Parse(txtNoDen.Text);

                    if (NoTu <= NoDen)
                    {
                        var query = db.DaiLies
                                  .Where(dl => dl.Quan == quan
                                        && dl.TienNo >= NoTu && dl.TienNo <= NoDen
                                        && dl.TinhTrang == 1)
                                  .ToList();

                        dgvDaiLy.DataSource = query;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Nợ từ phải nhỏ hơn hoặc bằng nợ đến.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Quận - Nợ từ
                if (cbQuan.EditValue != null && !string.IsNullOrEmpty(txtNoTu.Text))
                {
                    string quan = cbQuan.EditValue.ToString();
                    double NoTu = double.Parse(txtNoTu.Text);

                    var query = db.DaiLies
                                .Where(dl => dl.Quan == quan
                                    && dl.TienNo >= NoTu
                                    && dl.TinhTrang == 1)
                                .ToList();

                    dgvDaiLy.DataSource = query;
                    return;
                }

                // Quận - Nợ đến
                if (cbQuan.EditValue != null && !string.IsNullOrEmpty(txtNoDen.Text))
                {
                    string quan = cbQuan.EditValue.ToString();
                    double NoDen = double.Parse(txtNoDen.Text);

                    var query = db.DaiLies
                                .Where(dl => dl.Quan == quan
                                    && dl.TienNo <= NoDen
                                    && dl.TinhTrang == 1)
                                .ToList();

                    dgvDaiLy.DataSource = query;
                    return;
                }

                // Loại - Nợ
                if (cbLoaiDL.EditValue != null && !string.IsNullOrEmpty(txtNoTu.Text) && !string.IsNullOrEmpty(txtNoDen.Text))
                {
                    int loai = int.Parse(cbLoaiDL.EditValue.ToString());
                    double NoTu = double.Parse(txtNoTu.Text);
                    double NoDen = double.Parse(txtNoDen.Text);

                    if (NoTu <= NoDen)
                    {
                        var query = db.DaiLies
                                  .Where(dl => dl.Loai == loai
                                        && dl.TienNo >= NoTu && dl.TienNo <= NoDen
                                        && dl.TinhTrang == 1)
                                  .ToList();

                        dgvDaiLy.DataSource = query;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Nợ từ phải nhỏ hơn hoặc bằng nợ đến.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Loại - Nợ từ
                if (cbLoaiDL.EditValue != null && !string.IsNullOrEmpty(txtNoTu.Text))
                {
                    int loai = int.Parse(cbLoaiDL.EditValue.ToString());
                    double NoTu = double.Parse(txtNoTu.Text);

                    var query = db.DaiLies
                                .Where(dl => dl.Loai == loai
                                    && dl.TienNo >= NoTu
                                    && dl.TinhTrang == 1)
                                .ToList();

                    dgvDaiLy.DataSource = query;
                    return;
                }

                // Loại - Nợ đến
                if (cbLoaiDL.EditValue != null && !string.IsNullOrEmpty(txtNoDen.Text))
                {
                    int loai = int.Parse(cbLoaiDL.EditValue.ToString());
                    double NoDen = double.Parse(txtNoDen.Text);

                    var query = db.DaiLies
                                .Where(dl => dl.Loai == loai
                                    && dl.TienNo <= NoDen
                                    && dl.TinhTrang == 1)
                                .ToList();

                    dgvDaiLy.DataSource = query;
                    return;
                }

                // Nợ
                if (!string.IsNullOrEmpty(txtNoTu.Text) && !string.IsNullOrEmpty(txtNoDen.Text))
                {
                    double NoTu = double.Parse(txtNoTu.Text);
                    double NoDen = double.Parse(txtNoDen.Text);

                    if (NoTu <= NoDen)
                    {
                        var query = db.DaiLies
                                  .Where(dl => dl.TienNo >= NoTu && dl.TienNo <= NoDen
                                        && dl.TinhTrang == 1)
                                  .ToList();

                        dgvDaiLy.DataSource = query;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Nợ từ phải nhỏ hơn hoặc bằng nợ đến.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Nợ từ
                if (!string.IsNullOrEmpty(txtNoTu.Text))
                {
                    double NoTu = double.Parse(txtNoTu.Text);

                    var query = db.DaiLies
                                  .Where(dl => dl.TienNo >= NoTu && dl.TinhTrang == 1)
                                  .ToList();

                    dgvDaiLy.DataSource = query;
                    return;
                }

                // Nợ đến
                if (!string.IsNullOrEmpty(txtNoDen.Text))
                {
                    double NoDen = double.Parse(txtNoDen.Text);

                    var query = db.DaiLies
                                  .Where(dl => dl.TienNo <= NoDen && dl.TinhTrang == 1)
                                  .ToList();

                    dgvDaiLy.DataSource = query;
                    return;
                }
            }
        }
    }
}