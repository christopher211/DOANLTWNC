using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DTO;
using System.Data.SqlClient;

namespace ECM_DAO
{
    public class BienLai_DAO
    {
        public List<BienLai_DTO> LoadDSBienLai()
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<BienLai_DTO> bienLai = new List<BienLai_DTO>();

            string truyVan = "SELECT BienLai.MaBL, BienLai.MaNV, BienLai.MSHV, BienLai.MaKH, BienLai.Malop, BienLai.HocPhi, BienLai.NgayLapBienLai, BienLai.TrangThai,"
                            + "HocVien.Ho + ' ' + HocVien.Ten as HoTen, HocVien.GioiTinh, HocVien.DiaChi, HocVien.SDT, HocVien.NgaySinh, HocVien.Email, "
		                    + "KhoaHoc.TenKH, KhoaHoc.NgayBatDau, "
		                    + "Lop.LichHoc, Lop.MaNV, Lop.GioBatDau, "
		                    + "NhanVien.HoNV + ' ' + NhanVien.TenNV as HoTenNV "
                            + "FROM BienLai, HocVien, KhoaHoc, Lop, NhanVien "
                            + "WHERE BienLai.MSHV = HocVien.MSHV AND BienLai.MaKH = HocVien.MaKH AND BienLai.MaNV = NhanVien.MaNV AND "
                            + "BienLai.MaKH = KhoaHoc.MaKH AND BienLai.MaLop = Lop.MaLop AND BienLai.TrangThai = 1";

            SqlDataReader reader = DataProvider.TruyVanDuLieu(truyVan, connect);

            while (reader.Read())
            {
                BienLai_DTO bl = new BienLai_DTO()
                {
                    MaBL = reader["MaBL"].ToString(),
                    MaNV = reader["MaNV"].ToString(),
                    HoTenNV = reader["HoTenNV"].ToString(),
                    MSHV = reader["MSHV"].ToString(),
                    HoTen = reader["HoTen"].ToString(),
                    GioiTinh = reader["GioiTinh"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    SDT = reader["SDT"].ToString(),
                    NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                    Email = reader["Email"].ToString(),
                    MaKH = reader["MaKH"].ToString(),
                    TenKH = reader["TenKH"].ToString(),
                    MaLop = reader["MaLop"].ToString(),
                    LichHoc = reader["LichHoc"].ToString(),
                    NgayBatDau = DateTime.Parse(reader["NgayBatDau"].ToString()),
                    GioBatDau = reader["GioBatDau"].ToString(),
                    HocPhi = int.Parse(reader["HocPhi"].ToString()),
                    //NguoiLap = reader["HoTenNV"].ToString(),
                    NgayLapBienLai = DateTime.Parse(reader["NgayLapBienLai"].ToString()),
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                bienLai.Add(bl);
            }
            reader.Close();
            connect.Close();

            return bienLai;
        }
        public string LayMaBLLonNhat()
        {
            string strTruyVan = "SELECT MAX(MaBL) FROM BienLai";
            SqlConnection connect = DataProvider.TaoKetNoi();
            SqlDataReader reader = DataProvider.TruyVanDuLieu(strTruyVan, connect);
            string strKetQua = null;
            if (reader.Read())
            {
                strKetQua = reader[0].ToString();
            }
            reader.Close();
            connect.Close();
            return strKetQua;
        }
        public int SaveBienLai(BienLai_DTO blDTO)
        {
            string insert = "INSERT INTO BienLai(MaBL, MaNV, MSHV, MaKH, MaLop, HocPhi, NgayLapBienLai, TrangThai) VALUES(@MaBL, @MaNV, @MSHV, @MaKH, @MaLop, @HocPhi, @NgayLapBienLai, 1)";

            SqlParameter[] parameter = new SqlParameter[7];
            parameter[0] = new SqlParameter("@MaBL", blDTO.MaBL);
            parameter[1] = new SqlParameter("@MaNV", blDTO.MaNV);
            parameter[2] = new SqlParameter("@MSHV", blDTO.MSHV);
            parameter[3] = new SqlParameter("@MaKH", blDTO.MaKH);
            parameter[4] = new SqlParameter("@MaLop", blDTO.MaLop);
            parameter[5] = new SqlParameter("@HocPhi", blDTO.HocPhi);
            parameter[6] = new SqlParameter("@NgayLapBienLai", blDTO.NgayLapBienLai);

            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteInsertQuery(insert, parameter, connect);
            connect.Close();
            return ketQua;
        }
    }
}
