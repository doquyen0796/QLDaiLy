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
    }
}