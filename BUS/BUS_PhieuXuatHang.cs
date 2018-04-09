using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_PhieuXuatHang
    {
        DAL.QLDaiLyEntities db;

        public BUS_PhieuXuatHang()
        {
            db = new DAL.QLDaiLyEntities();
        }


        /// <summary>
        /// Thêm vào bảng PhieuXuatHang
        /// </summary>
        /// <param name="madaily"></param>
        /// <param name="manhanvien"></param>
        /// <param name="ngayxuat"></param>
        /// <param name="tongtien"></param>
        /// <returns></returns>
        public int PhieuXuatHang(int madaily, int manhanvien, DateTime ngayxuat, double tongtien)
        {
            try
            {
                DAL.PhieuXuatHang pxh = new DAL.PhieuXuatHang
                {
                    MaDaiLy = madaily,
                    MaNhanVien = manhanvien,
                    NgayXuat = ngayxuat,
                    TongTien = tongtien
                };

                db.PhieuXuatHangs.Add(pxh);

                //  cộng nợ
                var daily = db.DaiLies
                              .Where(d => d.MaDaiLy == madaily)
                              .FirstOrDefault();

                daily.TienNo = daily.TienNo + tongtien;

                var loai = db.LoaiDaiLies
                             .Where(l => l.MaLoai == daily.Loai && daily.MaDaiLy == madaily)
                             .FirstOrDefault();

                if (daily.TienNo > loai.TienNoToiDa)  //  vượt quá tiền nợ tối đa
                {
                    return -1;
                }
                else
                {
                    db.SaveChanges();

                    return pxh.MaPhieuXuat;  // lấy mã phiếu xuất để thêm vào bảng CTPhieuXuatHang
                }
            }
            catch
            {
                return 0;
            }
        }


        /// <summary>
        /// Thêm vào bảng CTPhieuXuatHang
        /// </summary>
        /// <param name="maphieuxuat"></param>
        /// <param name="mahh"></param>
        /// <param name="soluongxuat"></param>
        /// <param name="dongia"></param>
        /// <param name="thanhtien"></param>
        public void CTPhieuXuatHang (int maphieuxuat, int mahh, int soluongxuat, double dongia, double thanhtien)
        {
            try
            {
                DAL.CTPhieuXuatHang ct = new DAL.CTPhieuXuatHang
                {
                    MaPhieuXuat = maphieuxuat,
                    MaHangHoa = mahh,
                    SoLuongXuat = soluongxuat,
                    DonGia = dongia,
                    ThanhTien = thanhtien
                };

                db.CTPhieuXuatHangs.Add(ct);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
