﻿using System;
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
                var ds = db.HangHoas.ToList().Count;

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
            var hh = db.HangHoas.ToList();
            var ds = hh.Skip(t).Take(sl).ToList();
            return ds;
        }
    }
}