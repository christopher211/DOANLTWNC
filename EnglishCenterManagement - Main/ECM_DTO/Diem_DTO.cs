using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM_DTO
{
    public class Diem_DTO
    {
        public int ID { get; set; }
        public string MSHV { get; set; }
        public string MaKH { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string MaLop { get; set; }
        public float Nghe { get; set; }
        public float Noi { get; set; }
        public float Doc { get; set; }
        public float Viet { get; set; }
        public float DiemTB { get; set; }
        public int TrangThai { get; set; }
    }
}
