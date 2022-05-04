using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOCTChucVu
    {
        public string _manv;
        public int _macv;
        public DateTime _ngaybd;
        public DateTime _ngaykt;
        public string _lydo;
        public string MANV
        {
            get => _manv;
            set => _manv = value;
        }
        public int MACV
        {
            get => _macv;
            set => _macv = value;
        }
        public DateTime NGAYBD
        {
            get => _ngaybd;
            set => _ngaybd = value;
        }
        public DateTime NGAYKT
        {
            get => NGAYKT;
            set => NGAYKT = value;
        }
        public string LYDO
        {
            get => _lydo;
            set => _lydo = value;
        }
        public DTOCTChucVu()
        {

        }
        public DTOCTChucVu(string manv, int macv, DateTime ngaybd, DateTime ngaykt, string lydo)
        {
            this.MANV = manv;
            this.MACV = macv;
            this.NGAYBD = ngaybd;
            this.NGAYKT = ngaykt;
            this.LYDO = lydo;
        }
    }
}
