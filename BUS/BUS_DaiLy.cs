using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DaiLy
    {
        DAL.QLDaiLyEntities db;

        public BUS_DaiLy()
        {
            db = new DAL.QLDaiLyEntities();
        }


        public List<DAL.LoaiDaiLy> DanhSachLoaiDL()
        {
            var loai = db.LoaiDaiLies.ToList();

            return loai;
        }


        /// <summary>
        /// Kiểm tra email đã tồn tại chưa
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool KTEmailTonTai(string email)
        {
            var user = db.DaiLies
                         .Where(u => u.Email == email)
                         .FirstOrDefault();

            if (user != null && !string.IsNullOrEmpty(email))  // email đã tồn tại
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Kiểm tra email đã tồn tại chưa
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool KTEmailTonTai(int madl, string email)
        {
            var user = db.DaiLies
                         .Where(u => u.Email == email && u.MaDaiLy != madl)
                         .FirstOrDefault();

            if (user != null && !string.IsNullOrEmpty(email))  // email đã tồn tại
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Thêm mới đại lý
        /// </summary>
        /// <param name="tendaily"></param>
        /// <param name="loai"></param>
        /// <param name="diachi"></param>
        /// <param name="quan"></param>
        /// <param name="email"></param>
        /// <param name="ngaytiepnhan"></param>
        public bool ThemDaiLy(string tendaily, int loai, string diachi, string quan, string email, DateTime ngaytiepnhan)
        {
            try
            {
                if (KTEmailTonTai(email))
                {
                    DAL.DaiLy u = new DAL.DaiLy
                    {
                        TenDaiLy = tendaily,
                        Loai = loai,
                        DiaChi = diachi,
                        Quan = quan,
                        Email = email,
                        TienNo = 0,
                        NgayTiepNhan = ngaytiepnhan
                    };

                    db.DaiLies.Add(u);
                    db.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// Chỉnh sửa thông tin đại lý
        /// </summary>
        /// <param name="madaily"></param>
        /// <param name="tendaily"></param>
        /// <param name="loai"></param>
        /// <param name="diachi"></param>
        /// <param name="quan"></param>
        /// <param name="email"></param>
        /// <param name="ngaytiepnhan"></param>
        public bool SuaDaiLy(int madaily, string tendaily, int loai, string diachi, string quan, string email, DateTime ngaytiepnhan)
        {
            try
            {
                if (KTEmailTonTai(madaily, email))
                {
                    var dl = db.DaiLies
                               .Where(u => u.MaDaiLy == madaily)
                               .FirstOrDefault();

                    dl.TenDaiLy = tendaily;
                    dl.Loai = loai;
                    dl.DiaChi = diachi;
                    dl.Quan = quan;
                    dl.Email = email;
                    dl.NgayTiepNhan = ngaytiepnhan;

                    db.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// Xóa đại lý
        /// </summary>
        /// <param name="madaily"></param>
        /// <returns></returns>
        public bool XoaDaiLy(int madaily)
        {
            try
            {
                var dl = db.DaiLies
                           .Where(u => u.MaDaiLy == madaily)
                           .FirstOrDefault();

                db.DaiLies.Remove(dl);
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