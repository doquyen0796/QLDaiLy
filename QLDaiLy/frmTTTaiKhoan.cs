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

namespace QLDaiLy
{
    public partial class frmTTTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmTTTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frmDMK = new frmDoiMatKhau();
            frmDMK.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được bảo trì!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}