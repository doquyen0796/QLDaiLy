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


        public bool KiemTraTenDaiLy(string tendl)
        {
            var dl = db.DaiLies
                       .Where(d => d.TenDaiLy == tendl && d.TinhTrang == 1)
                       .FirstOrDefault();

            if (dl != null)  //  đại lý đã tồn tại
            {
                return false;
            }

            return true;
        }


        public bool KiemTraTenDaiLy(int madl, string tendl)
        {
            var dl = db.DaiLies
                       .Where(d => d.MaDaiLy != madl && d.TenDaiLy == tendl && d.TinhTrang == 1)
                       .FirstOrDefault();

            if (dl != null)  //  đại lý đã tồn tại
            {
                return false;
            }

            return true;
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
                        NgayTiepNhan = ngaytiepnhan,
                        TinhTrang = 1
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

                dl.TinhTrang = 0;
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        // Số lượng trang
        public int SoLuongTrang(int sl)
        {
            int st = 0;
            try
            {
                var ds = db.DaiLies.ToList().Count;

                st = ds / sl;
                int du = ds % sl;
                if (du != 0)
                {
                    st++;
                }
            }
            catch
            {

            }
            return st;
        }


        public List<int> DStrang(int sl)
        {
            List<int> ds = new List<int>();
            for (int i = 1; i <= sl; i++)
            {
                ds.Add(i);
            }
            return ds;
        }


        // Lấy danh sách
        public List<DAL.DaiLy> DSdaili(int curpage, int sl)
        {
            int t = (curpage - 1) * sl;
            var dl = db.DaiLies.ToList();
            var ds = dl.Skip(t).Take(sl).ToList();
            return ds;
        }
    }
}