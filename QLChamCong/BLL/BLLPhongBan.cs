using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLPhongBan
    {
        DALPhongBan dalPB = new DALPhongBan();

        public DataTable getPB()
        {
            return dalPB.getPB();
        }
        public bool themPB(DTOPhongBan pb)
        {
            return dalPB.themPB(pb);
        }
        public bool suaPB(DTOPhongBan pb)
        {
            return dalPB.suaPB(pb);
        }
        public bool xoaThanhVien(int maPB)
        {
            return dalPB.xoaPB(maPB);
        }
    }
}
