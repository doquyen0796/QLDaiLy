using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_LoaiDaiLy
    {
        DAL.QLDaiLyEntities db;

        public BUS_LoaiDaiLy()
        {
            db = new DAL.QLDaiLyEntities();
        }


        public List<DAL.LoaiDaiLy> DanhSachLoaiDL()
        {
            var loai = db.LoaiDaiLies
                         .Where(l => l.TinhTrang == 1)
                         .ToList();

            return loai;
        }
    }
}
