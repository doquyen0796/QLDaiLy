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
    public partial class frmQuiDinh : DevExpress.XtraEditors.XtraForm
    {
        public frmQuiDinh()
        {
            InitializeComponent();
        }


        private Form f;

        private void treeViewOptions_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeViewOptions.SelectedNode;
            switch (node.Name)
            {
                case "NodeSoDaiLyToiDa":
                    f.Dispose();
                    f = new frmSoDaiLyToiDa();
                    f.TopLevel = false;

                    MainPanel.Controls.Add(f);
                    f.Dock = DockStyle.Fill;
                    f.Show();
                    break;


                case "NodeTienNoToiDa":
                    f.Dispose();
                    f = new frmTienNoToiDa();
                    f.TopLevel = false;

                    MainPanel.Controls.Add(f);
                    f.Dock = DockStyle.Fill;
                    f.Show();
                    break;
            }
        }


        private void frmQuiDinh_Load(object sender, EventArgs e)
        {
            treeViewOptions.Nodes[0].ExpandAll();
            treeViewOptions.Nodes[1].ExpandAll();

            f = new frmSoDaiLyToiDa();
            f.TopLevel = false;

            MainPanel.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }
    }
}