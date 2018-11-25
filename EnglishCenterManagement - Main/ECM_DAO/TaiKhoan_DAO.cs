using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DTO;
using System.Data.SqlClient;

namespace ECM_DAO
{
    public class TaiKhoan_DAO
    {        
        public int CheckAdminLogin(string tenDangNhap, string matKhau)
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            string strTruyVan = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @username and MatKhau = @password and MaNV in(SELECT MaNV FROM NhanVien WHERE ChucVu = 'CV01')";

            SqlParameter[] par = new SqlParameter[2];
            par[0] = new SqlParameter("@username", tenDangNhap);
            par[1] = new SqlParameter("@password", Utilities.GetMD5(matKhau));

            SqlDataReader reader = DataProvider.TruyVanDuLieu(strTruyVan, par, connect);
            int ketQua = 0;

            if(reader.Read())
            {
                ketQua = 1;
            }
            reader.Close();
            connect.Close();
            return ketQua;
        }
        public int CheckModLogin(string tenDangNhap, string matKhau)
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            string strTruyVan = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @username and MatKhau = @password and MaNV in(SELECT MaNV FROM NhanVien WHERE ChucVu = 'CV02')";

            SqlParameter[] par = new SqlParameter[2];
            par[0] = new SqlParameter("@username", tenDangNhap);
            par[1] = new SqlParameter("@password", Utilities.GetMD5(matKhau));

            SqlDataReader reader = DataProvider.TruyVanDuLieu(strTruyVan, par, connect);
            int ketQua = 0;

            if (reader.Read())
            {
                ketQua = 1;
            }
            reader.Close();
            connect.Close();
            return ketQua;
        }
        public int CheckUserLogin(string tenDangNhap, string matKhau)
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            string strTruyVan = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @username and MatKhau = @password and MaNV in(SELECT MaNV FROM NhanVien WHERE ChucVu = 'CV03')";

            SqlParameter[] par = new SqlParameter[2];
            par[0] = new SqlParameter("@username", tenDangNhap);
            par[1] = new SqlParameter("@password", Utilities.GetMD5(matKhau));

            SqlDataReader reader = DataProvider.TruyVanDuLieu(strTruyVan, par, connect);
            int ketQua = 0;

            if (reader.Read())
            {
                ketQua = 1;
            }
            reader.Close();
            connect.Close();
            return ketQua;
        }
        public List<TaiKhoan_DTO> LoadDSTaiKhoan()
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<TaiKhoan_DTO> ListTK = new List<TaiKhoan_DTO>();
            string truyvan = @"SELECT NhanVien.MaNV, NhanVien.HoNV, NhanVien.TenNV, NhanVien.ChucVu, TaiKhoan.TenDangNhap, TaiKhoan.MatKhau FROM TaiKhoan, NhanVien WHERE TaiKhoan.MaNV = NhanVien.MaNV AND TaiKhoan.TrangThai = 1";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(truyvan, connect);
            while (reader.Read())
            {
                TaiKhoan_DTO taikhoan = new TaiKhoan_DTO()
                {
                    MaNV = reader["MaNV"].ToString(),
                    HoNV = reader["HoNV"].ToString(),
                    TenNV = reader["TenNV"].ToString(),
                    TenDangNhap = reader["TenDangNhap"].ToString(),
                    MatKhau = reader["MatKhau"].ToString(),  
                    ChucVu = reader["ChucVu"].ToString(),
                    //TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                ListTK.Add(taikhoan);
            }
            reader.Close();
            connect.Close();
            return ListTK;
        }
        public int AddTaiKhoan(TaiKhoan_DTO tkDTO)
        {
            string insert = "INSERT INTO TaiKhoan(TenDangNhap, MatKhau, MaNV, TrangThai) VALUES(@TenDangNhap, @MatKhau, @MaNV, 1)";

            SqlParameter[] parameter = new SqlParameter[3];
            parameter[0] = new SqlParameter("@TenDangNhap", tkDTO.TenDangNhap);
            parameter[1] = new SqlParameter("@MatKhau", Utilities.GetMD5(tkDTO.MatKhau));
            parameter[2] = new SqlParameter("@MaNV", tkDTO.MaNV);
            
            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteInsertQuery(insert, parameter, connect);
            connect.Close();
            return ketQua;
        }
        public int UpdateTaiKhoan(string manv)
        {
            string delete = "UPDATE NhanVien SET TrangThaiTK = 1 WHERE MaNV = @manv";

            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@manv", manv);

            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteUpdateQuery(delete, parameter, connect);
            connect.Close();
            return ketQua;
        }
    }
}
