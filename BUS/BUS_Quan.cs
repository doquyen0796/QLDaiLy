using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Quan
    {
        DAL.QLDaiLyEntities db;

        public BUS_Quan()
        {
            db = new DAL.QLDaiLyEntities();
        }

        public List<DAL.Quan> DanhSachQuan()
        {
            var quan = db.Quans.ToList();

            return quan;
        }


        /// <summary>
        /// Lấy số đại lý tối đa trong quận (HIỆN TẠI)
        /// </summary>
        /// <returns></returns>
        public int LaySoDaiLyToiDa()
        {
            var q = db.Quans.FirstOrDefault();

            return (int)q.SoDaiLyToiDa;
        }


        /// <summary>
        /// Lưu số đại lý tối đa trong quận
        /// </summary>
        /// <param name="newmax"></param>
        /// <returns></returns>
        public bool LuuSoDaiLyToiDa(int newmax)
        {
            //  https://stackoverflow.com/questions/10314552/how-to-update-the-multiple-rows-at-a-time-using-linq-to-sql
            var q = db.Quans.ToList();

            q.ForEach(a => a.SoDaiLyToiDa = newmax);
            db.SaveChanges();

            return true;
        }
    }
}