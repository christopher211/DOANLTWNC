using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM_DTO
{
    public class BienLai_DTO
    {
        public string MaBL{ get; set; }
        public string MaNV{ get; set; }
        public string HoTenNV { get; set; }
        public string MSHV{ get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string MaKH{ get; set; }
        public string TenKH { get; set; }
        public string MaLop { get; set; }
        public string LichHoc { get; set; }
        public DateTime NgayBatDau { get; set; }
        public string GioBatDau { get; set; }
        public int HocPhi { get; set; }
        public string NguoiLap { get; set; }
        public DateTime NgayLapBienLai { get; set; }
        public int TrangThai { get; set; }
    }
}
