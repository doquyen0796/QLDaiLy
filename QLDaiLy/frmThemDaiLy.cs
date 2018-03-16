using System;
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

namespace QLDaiLy
{
    public partial class frmThemDaiLy : DevExpress.XtraEditors.XtraForm
    {
        public frmThemDaiLy()
        {
            InitializeComponent();
        }


        private void frmThemDaiLy_Load(object sender, EventArgs e)
        {
            //  https://www.devexpress.com/Support/Center/Question/Details/Q20064/comboboxedit-how-do-you-set-the-datasource

            //  Lookup-edit Đại lý
            BUS_DaiLy dl = new BUS_DaiLy();
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


        private void txtTenDaiLy_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDaiLy.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtTenDaiLy, "Không được để trống.");
                btnThem.Enabled = false;
                return;
            }
            ErrorChecker.Clear();
            btnThem.Enabled = true;
        }


        private void cbLoaiDL_Properties_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbLoaiDL.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(cbLoaiDL, "Không được để trống.");
                btnThem.Enabled = false;
                return;
            }
            ErrorChecker.Clear();
            btnThem.Enabled = true;
        }
    }
}