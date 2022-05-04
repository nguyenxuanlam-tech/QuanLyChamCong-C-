using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOPhongBan
    {
        public class DTOPhongBan
        {
            private int _maPB;
            private string _tenPB;

            public int MaPB
            {
                get => _maPB;
                set => _maPB = value;
            }

            public string TenPB
            {
                get => _tenPB;
                set => _tenPB = value;
            }

            public DTOPhongBan()
            {

            }

            public DTOPhongBan(int maPB)
            {

            }

            public DTOPhongBan(int maPB, string tenPB)
            {
                this.MaPB = maPB;
                this.TenPB = tenPB;
            }
        }
}
