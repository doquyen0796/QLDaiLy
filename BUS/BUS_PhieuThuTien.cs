using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_PhieuThuTien
    {
        DAL.QLDaiLyEntities db;

        public BUS_PhieuThuTien()
        {
            db = new DAL.QLDaiLyEntities();
        }


        public int LapPhieuThu(int madl, int manv, DateTime ngaythu, double sotienthu)
        {
            try
            {
                var daily = db.DaiLies
                              .Where(d => d.MaDaiLy == madl)
                              .FirstOrDefault();

                double tienno = (double)daily.TienNo;

                if (sotienthu > tienno)  //  số tiền thu vượt quá số tiền đại lý đang nợ
                {
                    return -1;
                }
                else
                {
                    DAL.PhieuThuTien pt = new DAL.PhieuThuTien
                    {
                        MaDaiLy = madl,
                        MaNhanVien = manv,
                        NgayThu = ngaythu,
                        SoTienThu = sotienthu
                    };

                    db.PhieuThuTiens.Add(pt);
                    db.SaveChanges();

                    return 1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
