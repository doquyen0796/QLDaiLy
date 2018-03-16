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

            if (user != null)  // email đã tồn tại
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public void ThemDaiLy(string tendaily, int loai, string diachi, string quan, string email)
        {
            try
            {
                DAL.DaiLy u = new DAL.DaiLy
                {
                    TenDaiLy = tendaily,
                    Loai = loai,
                    DiaChi = diachi,
                    Quan = quan,
                    Email = email,
                    TienNo = 0
                };

                db.DaiLies.Add(u);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}