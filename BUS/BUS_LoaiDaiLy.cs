using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_LoaiDaiLy
    {
        DAL.QLDaiLyEntities db;

        public BUS_LoaiDaiLy()
        {
            db = new DAL.QLDaiLyEntities();
        }


        public List<DAL.LoaiDaiLy> DanhSachLoaiDL()
        {
            var loai = db.LoaiDaiLies
                         .Where(l => l.TinhTrang == 1)
                         .ToList();

            return loai;
        }


        /// <summary>
        /// Kiểm tra loại đại lý đã tồn tại hay chưa
        /// </summary>
        /// <param name="tenloai"></param>
        /// <returns></returns>
        public bool KiemTraTonTai(string tenloai)
        {
            var loai = db.LoaiDaiLies
                         .Where(l => l.TenLoai == tenloai)
                         .FirstOrDefault();

            if (loai != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Kiểm tra loại đại lý đã tồn tại hay chưa
        /// </summary>
        /// <param name="maloai"></param>
        /// <param name="tenloai"></param>
        /// <returns></returns>
        public bool KiemTraTonTai(int maloai, string tenloai)
        {
            var loai = db.LoaiDaiLies
                         .Where(l => l.TenLoai == tenloai && l.MaLoai != maloai)
                         .FirstOrDefault();

            if (loai != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Thêm loại đại lý
        /// </summary>
        /// <param name="tenloai"></param>
        /// <param name="TienNoToiDa"></param>
        /// <returns></returns>
        public bool ThemLoaiDaiLy(string tenloai, float TienNoToiDa)
        {
            try
            {
                DAL.LoaiDaiLy loai = new DAL.LoaiDaiLy
                {
                    TenLoai = tenloai,
                    TienNoToiDa = TienNoToiDa,
                    TinhTrang = 1
                };

                db.LoaiDaiLies.Add(loai);
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// Sửa thông tin loại đại lý
        /// </summary>
        /// <param name="maloai"></param>
        /// <param name="tenloai"></param>
        /// <param name="tiennotoida"></param>
        /// <returns></returns>
        public bool SuaLoaiDaiLy(int maloai, string tenloai, float tiennotoida)
        {
            var loai = db.LoaiDaiLies
                         .Where(l => l.MaLoai == maloai)
                         .FirstOrDefault();

            loai.TenLoai = tenloai;
            loai.TienNoToiDa = tiennotoida;

            db.SaveChanges();

            return true;
        }


        /// <summary>
        /// Xóa (ngừng kinh doanh) loại đại lý
        /// </summary>
        /// <param name="maloai"></param>
        /// <returns></returns>
        public bool XoaLoaiDaiLy(int maloai)
        {
            var loai = db.LoaiDaiLies
                         .Where(l => l.MaLoai == maloai)
                         .FirstOrDefault();

            loai.TinhTrang = 0;

            db.SaveChanges();
            return true;
        }


        /// <summary>
        /// Tiếp tục kinh doanh loại đại lý
        /// </summary>
        /// <param name="maloai"></param>
        /// <returns></returns>
        public bool TiepTucKinhDoanh(int maloai)
        {
            try
            {
                var loai = db.LoaiDaiLies
                            .Where(l => l.MaLoai == maloai)
                            .FirstOrDefault();

                loai.TinhTrang = 1;
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
