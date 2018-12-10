using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DTO;
using System.Data.SqlClient;

namespace ECM_DAO
{
    public class HocVien_DAO
    {      
        public List<HocVien_DTO> LoadDanhSachHV()
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<HocVien_DTO> hocVien = new List<HocVien_DTO>();

            string truyVan = "SELECT * from HocVien, KhoaHoc, Lop WHERE HocVien.MaKH = KhoaHoc.MaKH AND HocVien.MaLop = Lop.MaLop AND HocVien.TrangThai = 1";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(truyVan, connect);
            
            while(reader.Read())
            {
                HocVien_DTO hv = new HocVien_DTO()
                {
                    MSHV = reader["MSHV"].ToString(),
                    Ho = reader["Ho"].ToString(),
                    Ten = reader["Ten"].ToString(),
                    GioiTinh = reader["GioiTinh"].ToString(),
                    NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                    SDT = reader["SDT"].ToString(),
                    Email = reader["Email"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    TenKH = reader["TenKH"].ToString(),
                    MaKH = reader["MaKH"].ToString(),
                    MaLop = reader["MaLop"].ToString(),
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                hocVien.Add(hv);
            }
            reader.Close();
            connect.Close();

            return hocVien;
        }
        public List<HocVien_DTO> LoadDanhSachHVDaNghi()
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<HocVien_DTO> hocVien = new List<HocVien_DTO>();

            string truyVan = "SELECT * from HocVien, KhoaHoc, Lop WHERE HocVien.MaKH = KhoaHoc.MaKH AND HocVien.MaLop = Lop.MaLop AND HocVien.TrangThai = 0";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(truyVan, connect);

            while (reader.Read())
            {
                HocVien_DTO hv = new HocVien_DTO()
                {
                    MSHV = reader["MSHV"].ToString(),
                    Ho = reader["Ho"].ToString(),
                    Ten = reader["Ten"].ToString(),
                    GioiTinh = reader["GioiTinh"].ToString(),
                    NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                    SDT = reader["SDT"].ToString(),
                    Email = reader["Email"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    TenKH = reader["TenKH"].ToString(),
                    MaKH = reader["MaKH"].ToString(),
                    MaLop = reader["MaLop"].ToString(),
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                hocVien.Add(hv);
            }
            reader.Close();
            connect.Close();

            return hocVien;
        }
        
        public string LayMaHVLonNhat()
        {
            string strTruyVan = "SELECT MAX(MSHV) FROM HocVien";
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
        public int AddHocVien(HocVien_DTO hvDTO)
        {
            string insert = "INSERT INTO HocVien(MSHV, Ho, Ten, GioiTinh, NgaySinh, SDT, Email, DiaChi, MaKH, MaLop, TrangThai) VALUES(@MSHV, @Ho, @Ten, @GioiTinh, @NgaySinh, @SDT, @Email, @DiaChi, @MaKH, @MaLop, 1)";

            SqlParameter[] parameter = new SqlParameter[10];
            parameter[0] = new SqlParameter("@MSHV", hvDTO.MSHV);
            parameter[1] = new SqlParameter("@Ho", hvDTO.Ho);
            parameter[2] = new SqlParameter("@Ten", hvDTO.Ten);
            parameter[3] = new SqlParameter("@GioiTinh", hvDTO.GioiTinh);
            parameter[4] = new SqlParameter("@NgaySinh", hvDTO.NgaySinh);
            parameter[5] = new SqlParameter("@SDT", hvDTO.SDT);
            parameter[6] = new SqlParameter("@Email", hvDTO.Email);
            parameter[7] = new SqlParameter("@DiaChi", hvDTO.DiaChi);
            parameter[8] = new SqlParameter("@MaKH", hvDTO.MaKH);
            parameter[9] = new SqlParameter("@MaLop", hvDTO.MaLop);

            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteInsertQuery(insert, parameter, connect);
            connect.Close();
            return ketQua;
        }
        public int UpdateHocVien(HocVien_DTO hvDTO)
        {
            string update = "UPDATE HocVien SET  Ho = @Ho, Ten = @Ten, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, SDT = @SDT, Email = @Email, DiaChi = @DiaChi, MaKH = @MaKH, MaLop = @MaLop WHERE MSHV = @MSHV";

            SqlParameter[] parameter = new SqlParameter[10];
            parameter[0] = new SqlParameter("@MSHV", hvDTO.MSHV);
            parameter[1] = new SqlParameter("@Ho", hvDTO.Ho);
            parameter[2] = new SqlParameter("@Ten", hvDTO.Ten);
            parameter[3] = new SqlParameter("@GioiTinh", hvDTO.GioiTinh);
            parameter[4] = new SqlParameter("@NgaySinh", hvDTO.NgaySinh);
            parameter[5] = new SqlParameter("@SDT", hvDTO.SDT);
            parameter[6] = new SqlParameter("@Email", hvDTO.Email);
            parameter[7] = new SqlParameter("@DiaChi", hvDTO.DiaChi);
            parameter[8] = new SqlParameter("@MaKH", hvDTO.MaKH);
            parameter[9] = new SqlParameter("@MaLop", hvDTO.MaLop);

            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteUpdateQuery(update, parameter, connect);
            connect.Close();
            return ketQua;
        }
        public int DeleteHocVien(string mshv, string makh)
        {
            string delete = "UPDATE HocVien SET TrangThai = 0 WHERE MSHV = @MSHV AND MaKH = @MaKH";

            SqlParameter[] parameter = new SqlParameter[2];
            parameter[0] = new SqlParameter("@MSHV", mshv);
            parameter[1] = new SqlParameter("@MaKH", makh);

            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteUpdateQuery(delete, parameter, connect);
            connect.Close();
            return ketQua;
        }
        public int RestoreHocVien(string mshv)
        {
            string restore = "UPDATE HocVien SET TrangThai = 1 WHERE MSHV = @mshv";

            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@mshv", mshv);

            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteUpdateQuery(restore, parameter, connect);
            connect.Close();
            return ketQua;
        }



        //public List<HocVien_DTO> LoadDanhSachHVTheoLop_Diem(string lop)
        //{
        //    SqlConnection connect = DataProvider.TaoKetNoi();
        //    List<HocVien_DTO> hocVien = new List<HocVien_DTO>();

        //    string truyVan = "SELECT HocVien.MSHV, HocVien.Ho, HocVien.Ten, HocVien.MaKH, HocVien.MaLop from HocVien, KhoaHoc, Lop where HocVien.MaLop LIKE N'%{0}%' AND HocVien.MaKH = KhoaHoc.MaKH AND HocVien.MaLop = Lop.MaLop AND HocVien.TrangThai = 1";
        //    SqlDataReader reader = DataProvider.TruyVanDuLieu(string.Format(truyVan, lop), connect);

        //    while (reader.Read())
        //    {
        //        HocVien_DTO hv = new HocVien_DTO()
        //        {
        //            MSHV = reader["MSHV"].ToString(),
        //            Ho = reader["Ho"].ToString(),
        //            Ten = reader["Ten"].ToString(),                    
        //            MaKH = reader["MaKH"].ToString(),
        //            MaLop = reader["MaLop"].ToString()                    
        //        };
        //        hocVien.Add(hv);
        //    }
        //    reader.Close();
        //    connect.Close();

        //    return hocVien;
        //}
    }
}
