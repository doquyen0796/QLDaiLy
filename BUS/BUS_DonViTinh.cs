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
            var loai = db.DonViTinhs.ToList();

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
    }
}
