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
    }
}
