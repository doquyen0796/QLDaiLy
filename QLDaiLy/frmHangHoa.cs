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
using Microsoft.Office.Interop.Excel;
using System.Threading;

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
                //hangHoasBindingSource.DataSource = dbContext.HangHoas.Local.ToBindingList();

                dgvHangHoa.DataSource = dbContext.HangHoas.Where(hh => hh.TinhTrang == 1).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


            // Make the grid read-only.
            gridViewHangHoa.OptionsBehavior.Editable = false;
            // Prevent the focused cell from being highlighted.
            gridViewHangHoa.OptionsSelection.EnableAppearanceFocusedCell = false;
            // Draw a dotted focus rectangle around the entire row.
            gridViewHangHoa.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
        }

        //private List<string> st = new List<string> { "Tất Cả", "5", "10", "15", "20" };
        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            BUS_HangHoa hh = new BUS_HangHoa();
            this.FormLoad();
            //cbsoluongtrang.DataSource = st;

            cbsoluongtrang.SelectedIndex = 4;
            if (cbsoluongtrang.Text == "Tất Cả")
            {
                dgvHangHoa.DataSource = hh.DSHH();
                lbtrang.Text = "";
                btnlui.Enabled = false;
                btntien.Enabled = false;
                cbtrang.Enabled = false;
            }
            else
            {
                int t = hh.SoLuongTrang(int.Parse(cbsoluongtrang.Text));
                cbtrang.DataSource = hh.DStrang(t);
                lbtrang.Text = "Trang " + cbtrang.Text + "/" + t.ToString();
                dgvHangHoa.DataSource = hh.DShanghoa(int.Parse(cbtrang.Text), int.Parse(cbsoluongtrang.Text));
                if (int.Parse(cbtrang.Text) == 1)
                {
                    btnlui.Enabled = false;
                }
                else
                    btnlui.Enabled = true;
                if (int.Parse(cbtrang.Text) == t)
                {
                    btntien.Enabled = false;
                }
                else
                    btntien.Enabled = true;
            }  
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


        private void navbarXoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string tenhh = gridViewHangHoa.GetFocusedRowCellValue("TenHangHoa").ToString();

            var tb = MessageBox.Show(string.Format("Bạn có chắc chắn muốn ngừng kinh doanh \n {0} ?", tenhh),
                     "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (tb == DialogResult.Yes)
            {
                BUS_HangHoa hh = new BUS_HangHoa();
                int mahh = int.Parse(gridViewHangHoa.GetFocusedRowCellValue("MaHangHoa").ToString());
                var flag = hh.XoaHangHoa(mahh);

                if (flag == true)
                {
                    MessageBox.Show(string.Format("Bạn đã ngừng kinh doanh \n {0} \n thành công.", tenhh),
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            var query = db.HangHoas
                          .Where(hh => hh.TenHangHoa.ToLower().Contains(tukhoa.ToLower()) && hh.TinhTrang == 1)
                          .ToList();

            //hangHoasBindingSource.DataSource = query;
            dgvHangHoa.DataSource = query;

            if (string.IsNullOrEmpty(txtTuKhoa.Text))
            {
                //hangHoasBindingSource.DataSource = db.HangHoas.Where(hh => hh.TinhTrang == 1).ToList();
                dgvHangHoa.DataSource = db.HangHoas.Where(hh => hh.TinhTrang == 1).ToList();
            }
        }


        private void cbsoluongtrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            BUS_HangHoa dl = new BUS_HangHoa();
            if (cbsoluongtrang.Text == "Tất Cả")
            {
                dgvHangHoa.DataSource = dl.DSHH();
                lbtrang.Text = "";
                btnlui.Enabled = false;
                btntien.Enabled = false;
                cbtrang.Enabled = false;
            }
            else
            {
                cbtrang.Enabled = true;
                int t = dl.SoLuongTrang(int.Parse(cbsoluongtrang.Text));
                cbtrang.DataSource = dl.DStrang(t);
                if (int.Parse(cbtrang.Text) == 1)
                {
                    btnlui.Enabled = false;
                }
                else
                    btnlui.Enabled = true;
                if (int.Parse(cbtrang.Text) == t)
                {
                    btntien.Enabled = false;
                }
                else
                    btntien.Enabled = true;
                dgvHangHoa.DataSource = dl.DShanghoa(int.Parse(cbtrang.Text), int.Parse(cbsoluongtrang.Text));
            }
        }


        private void cbtrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            BUS_HangHoa dl = new BUS_HangHoa();
            int t = dl.SoLuongTrang(int.Parse(cbsoluongtrang.Text));
            if (int.Parse(cbtrang.Text) == 1)
            {
                btnlui.Enabled = false;
            }
            else
                btnlui.Enabled = true;
            if (int.Parse(cbtrang.Text) == t)
            {
                btntien.Enabled = false;
            }
            else
                btntien.Enabled = true;
            lbtrang.Text = "Trang " + cbtrang.Text + "/" + t.ToString();
            dgvHangHoa.DataSource = dl.DShanghoa(int.Parse(cbtrang.Text), int.Parse(cbsoluongtrang.Text));
        }


        private void btnlui_Click(object sender, EventArgs e)
        {
            BUS_HangHoa dl = new BUS_HangHoa();
            cbtrang.Text = cbtrang.Text = (int.Parse(cbtrang.Text) - 1).ToString(); ;
            dgvHangHoa.DataSource = dl.DShanghoa(int.Parse(cbtrang.Text), int.Parse(cbsoluongtrang.Text));
        }


        private void btntien_Click(object sender, EventArgs e)
        {
            BUS_HangHoa dl = new BUS_HangHoa();
            cbtrang.Text = (int.Parse(cbtrang.Text) + 1).ToString();
            dgvHangHoa.DataSource = dl.DShanghoa(int.Parse(cbtrang.Text), int.Parse(cbsoluongtrang.Text));
        }


        private void navBarUndo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmHHNgungKinhDoanh frm = new frmHHNgungKinhDoanh();
            frm.XuLyKinhDoanhLaiHangHoa += frmHangHoa_Load;
            frm.ShowDialog();
        }



        struct Data
        {
            public List<BUS_HangHoa.HH> HangHoa;
            public string FileName { get; set; }
        }
        Data DSHH;
        /// <summary>
        /// Xuất danh sách hàng hóa dưới định dạng Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarXuatDSExcel_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var flag = MessageBox.Show("Bạn muốn xuất danh sách hàng hóa dưới định dạng Excel ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (flag == DialogResult.Yes)
            {           
                progressBar1.Visible = true;
                label1.Visible = true;
                if (backgroundWorker1.IsBusy)
                    return;
                using (SaveFileDialog sf = new SaveFileDialog() { Filter = "Excel workbook|*.xls" })
                {
                    BUS_HangHoa ds = new BUS_HangHoa();
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        DSHH.FileName = sf.FileName;
                        DSHH.HangHoa = ds.DanhSachHH();
                        progressBar1.Minimum = 0;
                        progressBar1.Value = 0;
                        backgroundWorker1.RunWorkerAsync(DSHH);
                    }
                };
            }
            else
            {
                return;
            }
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<BUS_HangHoa.HH> ds = ((Data)e.Argument).HangHoa;
            string filename = ((Data)e.Argument).FileName;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;
            excel.Visible = false;
            int index = 1;
            int process = ds.Count();
            ws.Cells[1, 1] = "Mã Hàng Hóa";
            ws.Cells[1, 2] = "Tên Hàng Hóa";
            ws.Cells[1, 3] = "Đơn Vị Tính";
            ws.Cells[1, 4] = "Số Lượng";      
            ws.Cells[1, 5] = "Đơn Giá";

            foreach (BUS_HangHoa.HH dl in ds)
            {
                if (!backgroundWorker1.CancellationPending)
                {
                    backgroundWorker1.ReportProgress(index++ * 100 / process);
                    ws.Cells[index, 1] = dl.MaHH.ToString();
                    ws.Cells[index, 2] = dl.TenHH.ToString();             
                    ws.Cells[index, 3] = dl.DVT.ToString();
                    ws.Cells[index, 4] = dl.sl.ToString();
                    ws.Cells[index, 5] = dl.DonGia.ToString();              
                }
            }
            ws.SaveAs(filename, XlFileFormat.xlWorkbookDefault, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
            excel.Quit();
        }


        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label1.Text = string.Format("Processing ... {0} %", e.ProgressPercentage);
            progressBar1.Update();
        }


        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Thread.Sleep(100);
                label1.Text = "Successful!";
            }
        }


        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text == "Successful!")
            {
                var tb = MessageBox.Show("Xuất file thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (tb == DialogResult.OK)
                {
                    progressBar1.Visible = false;
                    label1.Visible = false;
                }
            }
        }
    }
}