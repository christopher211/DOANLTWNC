using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM_DTO
{
    public class NhanVien_DTO
    {
        public string MaNV { get; set; }
        public string HoNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public DateTime NgayLamViec { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string ChucVu { get; set; }
        public int Luong { get; set; }
        public int TrangThai { get; set; }
        public int TrangThaiTK { get; set; }
    }
}
