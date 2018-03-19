using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HangHoa
    {
        DAL.QLDaiLyEntities db;

        public BUS_HangHoa()
        {
            db = new DAL.QLDaiLyEntities();
        }


        /// <summary>
        /// Thêm hàng hóa
        /// </summary>
        /// <param name="tenhanghoa"></param>
        /// <param name="dvt"></param>
        /// <param name="soluong"></param>
        /// <param name="dongia"></param>
        /// <returns></returns>
        public bool ThemHangHoa(string tenhanghoa, int dvt, int soluong, float dongia)
        {
            try
            {
                DAL.HangHoa h = new DAL.HangHoa
                {
                    TenHangHoa = tenhanghoa,
                    DVT = dvt,
                    SoLuong = soluong,
                    DonGia = dongia
                };

                db.HangHoas.Add(h);
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