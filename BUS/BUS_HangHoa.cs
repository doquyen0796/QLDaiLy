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
                    DonGia = dongia,
                    TinhTrang = 1
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


        /// <summary>
        /// Chỉnh sửa thông tin hàng hóa
        /// </summary>
        /// <param name="mahh"></param>
        /// <param name="tenhh"></param>
        /// <param name="dvt"></param>
        /// <param name="dongia"></param>
        /// <returns></returns>
        public bool SuaHangHoa(int mahh, string tenhh, int dvt, float dongia)
        {
            try
            {
                var dl = db.HangHoas
                           .Where(u => u.MaHangHoa == mahh)
                           .FirstOrDefault();

                dl.TenHangHoa = tenhh;
                dl.DVT = dvt;
                dl.DonGia = dongia;

                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// Xóa (ngừng kinh doanh) hàng hóa
        /// </summary>
        /// <param name="mahh"></param>
        /// <returns></returns>
        public bool XoaHangHoa(int mahh)
        {
            try
            {
                var hh = db.HangHoas
                           .Where(p => p.MaHangHoa == mahh)
                           .FirstOrDefault();

                hh.TinhTrang = 0;
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int SoLuongTrang(int sl)
        {
            int st = 0;
            try
            {
                var ds = db.HangHoas.Where(h => h.TinhTrang == 1).ToList().Count;

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


        //lay danh sach
        public List<DAL.HangHoa> DShanghoa(int curpage, int sl)
        {

            int t = (curpage - 1) * sl;
            var hh = db.HangHoas.Where(h => h.TinhTrang == 1).ToList();
            var ds = hh.Skip(t).Take(sl).ToList();
            return ds;
        }


        public List<DAL.HangHoa> DSHH()
        {
            var ds = db.HangHoas.Where(hh => hh.TinhTrang == 1).ToList();
            return ds;
        }


        /// <summary>
        /// Tiếp tục kinh doanh hàng hóa
        /// </summary>
        /// <param name="mahh"></param>
        /// <returns></returns>
        public bool TiepTucKinhDoanh(int mahh)
        {
            try
            {
                var hanghoa = db.HangHoas
                                .Where(h => h.MaHangHoa == mahh)
                                .FirstOrDefault();

                hanghoa.TinhTrang = 1;
                
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



       public struct HH
        {
            public string MaHH { get; set; }
            public string TenHH { get; set; }
            public string DVT { get; set; }
            public string DonGia { get; set; }
            public string sl { get; set; }
        }
        HH hh;
        public List<HH>DanhSachHH ()
        {
            var ds = db.HangHoas.ToList();
            List<HH> dshh = new List<HH>();
            foreach (DAL.HangHoa h in ds)
            {
               
                hh.MaHH = h.MaHangHoa.ToString();
                hh.TenHH = h.TenHangHoa;
                hh.DonGia = h.DonGia.ToString();
                hh.sl = h.SoLuong.ToString();

                var donvi = db.DonViTinhs
                              .Where(dv => dv.MaDVT == h.DVT)
                              .FirstOrDefault();
                hh.DVT = donvi.TenDVT;

                dshh.Add(hh);
            }
            return dshh;
        }
    }
}