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

namespace QLDaiLy
{
    public partial class frmSoDaiLyToiDa : DevExpress.XtraEditors.XtraForm
    {
        public frmSoDaiLyToiDa()
        {
            InitializeComponent();
        }


        private void txtSoDLToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            BUS_Quan q = new BUS_Quan();
            int oldmax = q.LaySoDaiLyToiDa();
            int newmax = int.Parse(txtSoDLToiDa.Text);
            if (oldmax != newmax)
            {
                var tb = MessageBox.Show(string.Format("Hiện tại, số đại lý tối đa trong một quận là {0}.\nBạn có chắc chắn muốn chỉnh sửa thành {1} ?", oldmax.ToString(), newmax.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (tb == DialogResult.Yes)
                {
                    q.LuuSoDaiLyToiDa(newmax);
                    MessageBox.Show("Bạn đã lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                this.Close();
            }
        }


        private void frmSoDaiLyToiDa_Load(object sender, EventArgs e)
        {
            BUS_Quan q = new BUS_Quan();
            txtSoDLToiDa.Text = q.LaySoDaiLyToiDa().ToString();
        }
    }
}