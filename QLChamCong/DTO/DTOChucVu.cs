using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOChucVu
    {
        private int _maCV;
        private string _tenCV;

        public int MaCV
        {
            get => _maCV;
            set => _maCV = value;
        }
        public string TenCV
        {
            get => _tenCV;
            set => _tenCV = value;
        }

        public DTOChucVu()
        {

        }

        public DTOChucVu(int maCV)
        {

        }

        public DTOChucVu(string tenCV)
        {
            this.TenCV = tenCV;
        }
    }
}
