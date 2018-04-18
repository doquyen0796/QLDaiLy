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
using System.Data.SqlClient;
using System.Configuration;
using DevExpress.Utils.OAuth.Provider;
using DevExpress.XtraReports.UI;

namespace QLDaiLy
{
    public partial class frmBaoCaoDS : DevExpress.XtraEditors.XtraForm
    {
        DAL.QLDaiLyEntities db = new DAL.QLDaiLyEntities();

        public frmBaoCaoDS()
        {
            InitializeComponent();

            dtTuNgay.EditValue = "01-01-2018";
            dtDenNgay.EditValue = DateTime.Now;
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            //  string query = $"Exec sp_BaoCaoDoanhSo '{dtTuNgay.EditValue}', '{dtDenNgay.EditValue}'";

            //  https://www.youtube.com/watch?v=EYDBrdxR3A0
            DateTime FromDate = DateTime.Parse(dtTuNgay.EditValue.ToString());
            DateTime ToDate = DateTime.Parse(dtDenNgay.EditValue.ToString());
            reportBaoCaoDoanhSo rpt = new reportBaoCaoDoanhSo(FromDate, ToDate);
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}