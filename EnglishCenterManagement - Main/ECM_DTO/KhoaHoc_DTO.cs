using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM_DTO
{
    public class KhoaHoc_DTO
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int HocPhi { get; set; }
        public int TrangThai { get; set; }
    }
}
