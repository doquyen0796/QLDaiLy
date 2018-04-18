using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDaiLy
{
    public partial class reportBaoCaoDoanhSo : DevExpress.XtraReports.UI.XtraReport
    {
        public reportBaoCaoDoanhSo(DateTime FromDate, DateTime ToDate)
        {
            InitializeComponent();

            //  https://www.youtube.com/watch?v=EYDBrdxR3A0
            // truyền parameters vào Store procedure
            this.sp_BaoCaoDoanhSoTableAdapter.Fill(this.baoCaoDataSet1.sp_BaoCaoDoanhSo, FromDate, ToDate);
        }
    }
}
