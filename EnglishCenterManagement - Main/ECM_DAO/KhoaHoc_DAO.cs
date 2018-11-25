using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DTO;
using System.Data.SqlClient;

namespace ECM_DAO
{
    public class KhoaHoc_DAO
    {
        public List<KhoaHoc_DTO> LoadDSKhoaHoc()
        {
            List<KhoaHoc_DTO> lsKhoaHoc = new List<KhoaHoc_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            string strTruyVan = "SELECT * FROM KhoaHoc WHERE NgayBatDau > GETDATE() AND TrangThai = 1";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            while (reader.Read())
            {
                KhoaHoc_DTO loai = new KhoaHoc_DTO()
                {
                    MaKH = reader["MaKH"].ToString(),
                    TenKH = reader["TenKH"].ToString(),
                    NgayBatDau = DateTime.Parse(reader["NgayBatDau"].ToString()),
                    NgayKetThuc = DateTime.Parse(reader["NgayKetThuc"].ToString()),
                    HocPhi = int.Parse(reader["HocPhi"].ToString()),
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                lsKhoaHoc.Add(loai);
            }
            reader.Close();
            conn.Close();

            return lsKhoaHoc;
        }
        public List<KhoaHoc_DTO> LoadDSKhoaHocTheoMaKH(string makh)
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<KhoaHoc_DTO> khoaHoc = new List<KhoaHoc_DTO>();

            string truyVan = "SELECT * FROM KhoaHoc WHERE MaKH LIKE N'%{0}%' AND NgayBatDau > GETDATE() AND TrangThai = 1";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(string.Format(truyVan, makh), connect);

            while (reader.Read())
            {
                KhoaHoc_DTO kh = new KhoaHoc_DTO()
                {
                    MaKH = reader["MaKH"].ToString(),
                    TenKH = reader["TenKH"].ToString(),
                    NgayBatDau = DateTime.Parse(reader["NgayBatDau"].ToString()),
                    NgayKetThuc = DateTime.Parse(reader["NgayKetThuc"].ToString()),
                    HocPhi = int.Parse(reader["HocPhi"].ToString()),
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                khoaHoc.Add(kh);
            }
            reader.Close();
            connect.Close();

            return khoaHoc;
        }
        public List<KhoaHoc_DTO> LoadDSKhoaHocTheoTen(string tenkh)
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<KhoaHoc_DTO> khoaHoc = new List<KhoaHoc_DTO>();

            string truyVan = "SELECT * FROM KhoaHoc WHERE TenKH LIKE N'%{0}%' AND NgayBatDau > GETDATE() AND TrangThai = 1";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(string.Format(truyVan, tenkh), connect);

            while (reader.Read())
            {
                KhoaHoc_DTO kh = new KhoaHoc_DTO()
                {
                    MaKH = reader["MaKH"].ToString(),
                    TenKH = reader["TenKH"].ToString(),
                    NgayBatDau = DateTime.Parse(reader["NgayBatDau"].ToString()),
                    NgayKetThuc = DateTime.Parse(reader["NgayKetThuc"].ToString()),
                    HocPhi = int.Parse(reader["HocPhi"].ToString()),
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                khoaHoc.Add(kh);
            }
            reader.Close();
            connect.Close();

            return khoaHoc;
        }
        public string LayMaKHLonNhat()
        {
            string strTruyVan = "SELECT MAX(MaKH) FROM KhoaHoc";
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
        public int AddKhoaHoc(KhoaHoc_DTO khDTO)
        {
            string insert = "INSERT INTO KhoaHoc(MaKH, TenKH, NgayBatDau, NgayKetThuc, HocPhi, TrangThai) VALUES(@MaKH, @TenKH, @NgayBatDau, @NgayKetThuc, @HocPhi, 1)";

            SqlParameter[] parameter = new SqlParameter[5];
            parameter[0] = new SqlParameter("@MaKH", khDTO.MaKH);
            parameter[1] = new SqlParameter("@TenKH", khDTO.TenKH);
            parameter[2] = new SqlParameter("@NgayBatDau", khDTO.NgayBatDau);
            parameter[3] = new SqlParameter("@NgayKetThuc", khDTO.NgayKetThuc);
            parameter[4] = new SqlParameter("@HocPhi", khDTO.HocPhi);
            
            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteInsertQuery(insert, parameter, connect);
            connect.Close();
            return ketQua;
        }
        public int UpdateKhoaHoc(KhoaHoc_DTO khDTO)
        {
            string update = "UPDATE KhoaHoc SET  TenKH = @TenKH, NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc, HocPhi = @HocPhi WHERE MaKH = @MaKH";

            SqlParameter[] parameter = new SqlParameter[5];
            parameter[0] = new SqlParameter("@MaKH", khDTO.MaKH);
            parameter[1] = new SqlParameter("@TenKH", khDTO.TenKH);
            parameter[2] = new SqlParameter("@NgayBatDau", khDTO.NgayBatDau);
            parameter[3] = new SqlParameter("@NgayKetThuc", khDTO.NgayKetThuc);
            parameter[4] = new SqlParameter("@HocPhi", khDTO.HocPhi);

            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteUpdateQuery(update, parameter, connect);
            connect.Close();
            return ketQua;
        }
        public int DeleteKhoaHoc(string makh)
        {
            string delete = "UPDATE KhoaHoc SET TrangThai = 0 WHERE MaKH = @makh";

            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@makh", makh);

            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteUpdateQuery(delete, parameter, connect);
            connect.Close();
            return ketQua;
        }
    }      
}

