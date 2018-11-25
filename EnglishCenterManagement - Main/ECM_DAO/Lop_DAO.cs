using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DTO;
using System.Data.SqlClient;

namespace ECM_DAO
{
    public class Lop_DAO
    {
        public List<Lop_DTO> LoadDSLop()
        {
            List<Lop_DTO> lsLop = new List<Lop_DTO>();
            SqlConnection connect = DataProvider.TaoKetNoi();

            string strTruyVan = "SELECT * FROM Lop WHERE TrangThai = 1";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(strTruyVan, connect);
            while (reader.Read())
            {
                Lop_DTO loai = new Lop_DTO()
                {
                    MaLop = reader["MaLop"].ToString(),
                    TenLop = reader["TenLop"].ToString(),
                    MaNV = reader["MaNV"].ToString(),
                    MaPhg = reader["MaPhg"].ToString(),
                    MaKhoaHoc = reader["MaKhoaHoc"].ToString(),
                    LichHoc = reader["LichHoc"].ToString(),
                    GioBatDau = reader["GioBatDau"].ToString(),
                    GioKetThuc = reader["GioKetThuc"].ToString(),
                    //SoHV = int.Parse(reader["SoHV"].ToString()),
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                lsLop.Add(loai);
            }
            reader.Close();
            connect.Close();

            return lsLop;
        }       
        public List<Lop_DTO> loadDSLop2(string MaKhoa)
        {
            List<Lop_DTO> lsLop = new List<Lop_DTO>();
            SqlConnection connect = DataProvider.TaoKetNoi();

            string strTruyVan = "SELECT MaLop, TenLop FROM Lop WHERE MaKhoaHoc = @MaKhoaHoc GROUP BY MaLop, TenLop, MaKhoaHoc";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@MaKhoaHoc", MaKhoa);
            SqlDataReader reader = DataProvider.TruyVanDuLieu(strTruyVan, parameter, connect);
            while (reader.Read())
            {
                Lop_DTO loai = new Lop_DTO()
                {
                    MaLop = reader["MaLop"].ToString(),
                    TenLop = reader["TenLop"].ToString()
                };
                lsLop.Add(loai);
            }
            reader.Close();
            connect.Close();

            return lsLop;
        }
        public List<Lop_DTO> LoadDSLopTheoMaLop(string malop)
        {
            List<Lop_DTO> lsLop = new List<Lop_DTO>();
            SqlConnection connect = DataProvider.TaoKetNoi();

            string strTruyVan = "SELECT * FROM Lop WHERE MaLop = @MaLop AND TrangThai = 1";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@MaLop", malop);
            SqlDataReader reader = DataProvider.TruyVanDuLieu(strTruyVan, parameter, connect);
            while (reader.Read())
            {
                Lop_DTO loai = new Lop_DTO()
                {
                    MaLop = reader["MaLop"].ToString(),
                    TenLop = reader["TenLop"].ToString(),
                    MaNV = reader["MaNV"].ToString(),
                    MaPhg = reader["MaPhg"].ToString(),
                    MaKhoaHoc = reader["MaKhoaHoc"].ToString(),
                    LichHoc = reader["LichHoc"].ToString(),
                    GioBatDau = reader["GioBatDau"].ToString(),
                    GioKetThuc = reader["GioKetThuc"].ToString(),
                    //SoHV = int.Parse(reader["SoHV"].ToString()),
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                lsLop.Add(loai);
            }
            reader.Close();
            connect.Close();

            return lsLop;
        }

        public string LayMaLopLonNhat()
        {
            string strTruyVan = "SELECT MAX(MaLop) FROM Lop";
            SqlConnection connect = DataProvider.TaoKetNoi();
            SqlDataReader reader = DataProvider.TruyVanDuLieu(strTruyVan, connect);
            string strKetQua = null;
            if (reader.Read())
            {
                strKetQua = reader[0].ToString().Trim();
            }
            reader.Close();
            connect.Close();
            return strKetQua;
        }
        public string LaySoLopLonNhat(string makh)
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            string strTruyVan = "SELECT MAX(TenLop) FROM Lop WHERE MaKhoaHoc = @MaKhoaHoc GROUP BY MaKhoaHoc";

            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@MaKhoaHoc", makh);

            SqlDataReader reader = DataProvider.TruyVanDuLieu(strTruyVan, par, connect);

            string strKetQua = null;
            if (reader.Read())
            {
                strKetQua = reader[0].ToString().Trim();
            }
            reader.Close();
            connect.Close();
            return strKetQua;
        }

        public int AddLopHoc(Lop_DTO lopDTO)
        {
            string insert = "INSERT INTO Lop (MaLop, TenLop, MaNV, MaPhg, MaKhoaHoc, LichHoc, GioBatDau, GioKetThuc, SoHV, TrangThai) VALUES (@MaLop, @TenLop, @MaNV, @MaPhg, @MaKhoaHoc, @LichHoc, @GioBatDau, @GioKetThuc, NULL, 1)";

            SqlParameter[] parameter = new SqlParameter[8];
            parameter[0] = new SqlParameter("@MaLop", lopDTO.MaLop);
            parameter[1] = new SqlParameter("@TenLop", lopDTO.TenLop);
            parameter[2] = new SqlParameter("@MaNV", lopDTO.MaNV);
            parameter[3] = new SqlParameter("@MaPhg", lopDTO.MaPhg);
            parameter[4] = new SqlParameter("@MaKhoaHoc", lopDTO.MaKhoaHoc);
            parameter[5] = new SqlParameter("@LichHoc", lopDTO.LichHoc);
            parameter[6] = new SqlParameter("@GioBatDau", lopDTO.GioBatDau);
            parameter[7] = new SqlParameter("@GioKetThuc", lopDTO.GioKetThuc);            
            
            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteInsertQuery(insert, parameter, connect);
            connect.Close();
            return ketQua;
        }
        public int UpdateLopHoc(Lop_DTO lopDTO)
        {
            string update = "UPDATE Lop SET MaLop = @MaLop, TenLop = @TenLop, MaNV = @MaNV, MaPhg = @MaPhg, MaKhoaHoc = @MaKhoaHoc, LichHoc = @LichHoc, GioBatDau = @GioBatDau, GioKetThuc = @GioKetThuc WHERE MaLop = @MaLop";

            SqlParameter[] parameter = new SqlParameter[8];
            parameter[0] = new SqlParameter("@MaLop", lopDTO.MaLop);
            parameter[1] = new SqlParameter("@TenLop", lopDTO.TenLop);
            parameter[2] = new SqlParameter("@MaNV", lopDTO.MaNV);
            parameter[3] = new SqlParameter("@MaPhg", lopDTO.MaPhg);
            parameter[4] = new SqlParameter("@MaKhoaHoc", lopDTO.MaKhoaHoc);
            parameter[5] = new SqlParameter("@LichHoc", lopDTO.LichHoc);
            parameter[6] = new SqlParameter("@GioBatDau", lopDTO.GioBatDau);
            parameter[7] = new SqlParameter("@GioKetThuc", lopDTO.GioKetThuc);

            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteUpdateQuery(update, parameter, connect);
            connect.Close();
            return ketQua;
        }
        public int DeleteLopHoc(string malop)
        {
            string delete = "UPDATE Lop SET TrangThai = 0 WHERE MaLop = @malop";

            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@malop", malop);

            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteUpdateQuery(delete, parameter, connect);
            connect.Close();
            return ketQua;
        }

    }
}
