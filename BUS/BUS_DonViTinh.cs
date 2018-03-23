using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DonViTinh
    {
        DAL.QLDaiLyEntities db;

        public BUS_DonViTinh()
        {
            db = new DAL.QLDaiLyEntities();
        }


        public List<DAL.DonViTinh> DanhSachDVT()
        {
            var loai = db.DonViTinhs
                         .Where(dvt => dvt.TinhTrang == 1)
                         .ToList();

            return loai;
        }


        public bool KiemTraTenDVT(string tendvt)
        {
            var dvt = db.DonViTinhs
                        .Where(d => d.TenDVT == tendvt && d.TinhTrang == 1)
                        .FirstOrDefault();

            if (dvt != null)  //  dvt đã tồn tại
            {
                return false;
            }

            return true;
        }


        public bool KiemTraTenDVT(int madvt, string tendvt)
        {
            var dvt = db.DonViTinhs
                        .Where(d => d.TenDVT == tendvt && d.MaDVT != madvt && d.TinhTrang == 1)
                        .FirstOrDefault();

            if (dvt != null)  //  dvt đã tồn tại
            {
                return false;
            }

            return true;
        }


        /// <summary>
        /// Thêm đơn vị tính
        /// </summary>
        /// <param name="tendvt"></param>
        /// <returns></returns>
        public bool ThemDonViTinh(string tendvt)
        {
            try
            {
                DAL.DonViTinh dvt = new DAL.DonViTinh
                {
                    TenDVT = tendvt,
                    TinhTrang = 1
                };

                db.DonViTinhs.Add(dvt);
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// Sửa đơn vị tính
        /// </summary>
        /// <param name="madvt"></param>
        /// <param name="tendvt"></param>
        /// <returns></returns>
        public bool SuaDonViTinh(int madvt, string tendvt)
        {
            try
            {
                var dvt = db.DonViTinhs
                            .Where(d => d.MaDVT == madvt)
                            .FirstOrDefault();

                dvt.TenDVT = tendvt;

                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// Xóa (ẩn) đơn vị tính
        /// </summary>
        /// <param name="madvt"></param>
        /// <returns></returns>
        public bool XoaDonViTinh(int madvt)
        {
            try
            {
                var dvt = db.DonViTinhs
                            .Where(d => d.MaDVT == madvt)
                            .FirstOrDefault();

                dvt.TinhTrang = 0;

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
