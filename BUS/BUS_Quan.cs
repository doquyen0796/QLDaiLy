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
    }
}