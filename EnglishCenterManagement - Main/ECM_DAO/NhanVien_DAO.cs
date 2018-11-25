using ECM_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM_DAO
{
    public class NhanVien_DAO
    {
        #region GiaoVien

        public string LayMaNVLonNhat()
        {
            string strTruyVan = "SELECT MAX(MaNV) FROM NhanVien";
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
        public List<NhanVien_DTO> LoadDSGV()
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<NhanVien_DTO> listGV = new List<NhanVien_DTO>();
            string truyvan = @"SELECT * FROM NhanVien WHERE TrangThai = 1 AND ChucVu = 'CV04'";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(truyvan, connect);
            while(reader.Read())
            {
                NhanVien_DTO giaovien = new NhanVien_DTO()
                {
                     MaNV = reader["MaNV"].ToString(),
                     HoNV = reader["HoNV"].ToString(),
                     TenNV = reader["TenNV"].ToString(),
                     GioiTinh = reader["GioiTinh"].ToString(),
                     NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                     NgayLamViec = DateTime.Parse(reader["NgayLamViec"].ToString()),
                     SDT = reader["SDT"].ToString(),
                     Email = reader["Email"].ToString(),
                     DiaChi = reader["DiaChi"].ToString(),
                     //Luong = int.Parse(reader["Luong"].ToString()),
                     TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                listGV.Add(giaovien);
            }
            reader.Close();
            connect.Close();
            return listGV;
        }
        public List<NhanVien_DTO> LoadDSGVTheoMaGV(string manv)
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<NhanVien_DTO> giaovien = new List<NhanVien_DTO>();

            string truyVan = "SELECT * from NhanVien WHERE MaNV LIKE N'%{0}%' AND TrangThai = 1 AND ChucVu = 'CV04'";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(string.Format(truyVan, manv), connect);

            while (reader.Read())
            {
                NhanVien_DTO gv = new NhanVien_DTO()
                {
                    MaNV = reader["MaNV"].ToString(),
                    HoNV = reader["HoNV"].ToString(),
                    TenNV = reader["TenNV"].ToString(),
                    GioiTinh = reader["GioiTinh"].ToString(),
                    NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                    NgayLamViec = DateTime.Parse(reader["NgayLamViec"].ToString()),
                    SDT = reader["SDT"].ToString(),
                    Email = reader["Email"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    //Luong = int.Parse(reader["Luong"].ToString()),
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                giaovien.Add(gv);
            }
            reader.Close();
            connect.Close();

            return giaovien;
        }        
        public List<NhanVien_DTO> LoadDSGVTheoSDT(string sdt)
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<NhanVien_DTO> giaovien = new List<NhanVien_DTO>();

            string truyVan = "SELECT * from NhanVien WHERE SDT LIKE N'%{0}%' AND TrangThai = 1 AND ChucVu = 'CV04'";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(string.Format(truyVan, sdt), connect);

            while (reader.Read())
            {
                NhanVien_DTO gv = new NhanVien_DTO()
                {
                    MaNV = reader["MaNV"].ToString(),
                    HoNV = reader["HoNV"].ToString(),
                    TenNV = reader["TenNV"].ToString(),
                    GioiTinh = reader["GioiTinh"].ToString(),
                    NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                    NgayLamViec = DateTime.Parse(reader["NgayLamViec"].ToString()),
                    SDT = reader["SDT"].ToString(),
                    Email = reader["Email"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    //Luong = int.Parse(reader["Luong"].ToString()),
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                giaovien.Add(gv);
            }
            reader.Close();
            connect.Close();

            return giaovien;
        }
        public List<NhanVien_DTO> LoadDSGVTheoHoTen(string hoten)
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<NhanVien_DTO> giaovien = new List<NhanVien_DTO>();

            string truyVan = "SELECT * from NhanVien WHERE HoNV+' '+TenNV LIKE N'%{0}%' AND TrangThai = 1 AND ChucVu = 'CV04'";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(string.Format(truyVan, hoten), connect);

            while (reader.Read())
            {
                NhanVien_DTO gv = new NhanVien_DTO()
                {
                    MaNV = reader["MaNV"].ToString(),
                    HoNV = reader["HoNV"].ToString(),
                    TenNV = reader["TenNV"].ToString(),
                    GioiTinh = reader["GioiTinh"].ToString(),
                    NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                    NgayLamViec = DateTime.Parse(reader["NgayLamViec"].ToString()),
                    SDT = reader["SDT"].ToString(),
                    Email = reader["Email"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    //Luong = int.Parse(reader["Luong"].ToString()),
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                giaovien.Add(gv);
            }
            reader.Close();
            connect.Close();

            return giaovien;
        }
        public int AddGiaoVien(NhanVien_DTO gvDTO)
        {
            string insert = "INSERT INTO NhanVien(MaNV, HoNV, TenNV, GioiTinh, NgaySinh, NgayLamViec, SDT, Email, DiaChi, ChucVu, Luong, TrangThai, TrangThaiTK) VALUES(@MaNV, @HoNV, @TenNV, @GioiTinh, @NgaySinh, @NgayLamViec, @SDT, @Email, @DiaChi, 'CV04', NULL, 1, 0)";

            SqlParameter[] parameter = new SqlParameter[9];
            parameter[0] = new SqlParameter("@MaNV", gvDTO.MaNV);
            parameter[1] = new SqlParameter("@HoNV", gvDTO.HoNV);
            parameter[2] = new SqlParameter("@TenNV", gvDTO.TenNV);
            parameter[3] = new SqlParameter("@GioiTinh", gvDTO.GioiTinh);
            parameter[4] = new SqlParameter("@NgaySinh", gvDTO.NgaySinh);
            parameter[5] = new SqlParameter("@NgayLamViec", gvDTO.NgayLamViec);
            parameter[6] = new SqlParameter("@SDT", gvDTO.SDT);
            parameter[7] = new SqlParameter("@Email", gvDTO.Email);
            parameter[8] = new SqlParameter("@DiaChi", gvDTO.DiaChi);
            

            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteInsertQuery(insert, parameter, connect);
            connect.Close();
            return ketQua;
        }
        public int DeleteGiaoVien(string manv)
        {
            string delete = "UPDATE NhanVien SET TrangThai = 0 WHERE MaNV = @manv AND ChucVu = 'CV04'";

            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@manv", manv);

            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteUpdateQuery(delete, parameter, connect);
            connect.Close();
            return ketQua;
        }
        public int UpdateGiaoVien(NhanVien_DTO gvDTO)
        {
            string update = "UPDATE NhanVien SET HoNV = @HoNV, TenNV = @TenNV, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, NgayLamViec = @NgayLamViec, SDT = @SDT, Email = @Email, DiaChi = @DiaChi WHERE MaNV = @MaNV";

            SqlParameter[] parameter = new SqlParameter[9];
            parameter[0] = new SqlParameter("@MaNV", gvDTO.MaNV);
            parameter[1] = new SqlParameter("@HoNV", gvDTO.HoNV);
            parameter[2] = new SqlParameter("@TenNV", gvDTO.TenNV);
            parameter[3] = new SqlParameter("@GioiTinh", gvDTO.GioiTinh);
            parameter[4] = new SqlParameter("@NgaySinh", gvDTO.NgaySinh);
            parameter[5] = new SqlParameter("@NgayLamViec", gvDTO.NgayLamViec);
            parameter[6] = new SqlParameter("@SDT", gvDTO.SDT);
            parameter[7] = new SqlParameter("@Email", gvDTO.Email);
            parameter[8] = new SqlParameter("@DiaChi", gvDTO.DiaChi);

            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteUpdateQuery(update, parameter, connect);
            connect.Close();
            return ketQua;
        }

        #endregion


        #region NhanVien

        public List<NhanVien_DTO> LoadDSNV()
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<NhanVien_DTO> listNV = new List<NhanVien_DTO>();
            string truyvan = "SELECT * FROM NhanVien WHERE TrangThai = 1 AND ChucVu in ('CV02', 'CV03')";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(truyvan, connect);
            while (reader.Read())
            {
                NhanVien_DTO nhanvien = new NhanVien_DTO()
                {
                    MaNV = reader["MaNV"].ToString(),
                    HoNV = reader["HoNV"].ToString(),
                    TenNV = reader["TenNV"].ToString(),
                    GioiTinh = reader["GioiTinh"].ToString(),
                    NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                    NgayLamViec = DateTime.Parse(reader["NgayLamViec"].ToString()),
                    SDT = reader["SDT"].ToString(),
                    Email = reader["Email"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    ChucVu = reader["ChucVu"].ToString(),
                    //Luong = int.Parse(reader["Luong"].ToString()),
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                listNV.Add(nhanvien);
            }
            reader.Close();
            connect.Close();
            return listNV;
        }
        public List<NhanVien_DTO> LoadDSNVChuaCoTaiKhoan()
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<NhanVien_DTO> listNV = new List<NhanVien_DTO>();
            string truyvan = @"SELECT * FROM NhanVien WHERE TrangThai = 1 AND TrangThaiTK = 0 AND ChucVu in ('CV01', 'CV02', 'CV03')";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(truyvan, connect);
            while (reader.Read())
            {
                NhanVien_DTO nhanvien = new NhanVien_DTO()
                {
                    MaNV = reader["MaNV"].ToString(),
                    HoNV = reader["HoNV"].ToString(),
                    TenNV = reader["TenNV"].ToString(),
                    GioiTinh = reader["GioiTinh"].ToString(),
                    NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                    NgayLamViec = DateTime.Parse(reader["NgayLamViec"].ToString()),
                    SDT = reader["SDT"].ToString(),
                    Email = reader["Email"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    ChucVu = reader["ChucVu"].ToString(),
                    //Luong = int.Parse(reader["Luong"].ToString()),
                    TrangThai = int.Parse(reader["TrangThai"].ToString()),
                    TrangThaiTK = int.Parse(reader["TrangThaiTK"].ToString())
                };
                listNV.Add(nhanvien);
            }
            reader.Close();
            connect.Close();
            return listNV;
        }       
        public List<NhanVien_DTO> LoadDSNVDaNghi()
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<NhanVien_DTO> listGV = new List<NhanVien_DTO>();
            string truyvan = @"SELECT * FROM NhanVien WHERE TrangThai = 0";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(truyvan, connect);
            while (reader.Read())
            {
                NhanVien_DTO giaovien = new NhanVien_DTO()
                {
                    MaNV = reader["MaNV"].ToString(),
                    HoNV = reader["HoNV"].ToString(),
                    TenNV = reader["TenNV"].ToString(),
                    GioiTinh = reader["GioiTinh"].ToString(),
                    NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                    NgayLamViec = DateTime.Parse(reader["NgayLamViec"].ToString()),
                    SDT = reader["SDT"].ToString(),
                    Email = reader["Email"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    ChucVu = reader["ChucVu"].ToString(),
                    //Luong = int.Parse(reader["Luong"].ToString()),
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                listGV.Add(giaovien);
            }
            reader.Close();
            connect.Close();
            return listGV;
        }
        public List<NhanVien_DTO> LoadDSNVTheoMaNV(string manv)
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<NhanVien_DTO> nhanvien = new List<NhanVien_DTO>();

            string truyVan = "SELECT * from NhanVien WHERE MaNV LIKE N'%{0}%' AND TrangThai = 1 AND ChucVu IN ('CV02', 'CV03')";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(string.Format(truyVan, manv), connect);

            while (reader.Read())
            {
                NhanVien_DTO nv = new NhanVien_DTO()
                {
                    MaNV = reader["MaNV"].ToString(),
                    HoNV = reader["HoNV"].ToString(),
                    TenNV = reader["TenNV"].ToString(),
                    GioiTinh = reader["GioiTinh"].ToString(),
                    NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                    NgayLamViec = DateTime.Parse(reader["NgayLamViec"].ToString()),
                    SDT = reader["SDT"].ToString(),
                    Email = reader["Email"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    ChucVu = reader["ChucVu"].ToString(),
                    //Luong = int.Parse(reader["Luong"].ToString()),
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                nhanvien.Add(nv);
            }
            reader.Close();
            connect.Close();

            return nhanvien;
        }
        public List<NhanVien_DTO> LoadDSNVTheoHoTen(string hoten)
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<NhanVien_DTO> nhanvien = new List<NhanVien_DTO>();

            string truyVan = "SELECT * from NhanVien WHERE HoNV+' '+TenNV LIKE N'%{0}%' AND TrangThai = 1 AND ChucVu IN ('CV02', 'CV03')";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(string.Format(truyVan, hoten), connect);

            while (reader.Read())
            {
                NhanVien_DTO nv = new NhanVien_DTO()
                {
                    MaNV = reader["MaNV"].ToString(),
                    HoNV = reader["HoNV"].ToString(),
                    TenNV = reader["TenNV"].ToString(),
                    GioiTinh = reader["GioiTinh"].ToString(),
                    NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                    NgayLamViec = DateTime.Parse(reader["NgayLamViec"].ToString()),
                    SDT = reader["SDT"].ToString(),
                    Email = reader["Email"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    //Luong = int.Parse(reader["Luong"].ToString()),
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                nhanvien.Add(nv);
            }
            reader.Close();
            connect.Close();

            return nhanvien;
        }
        public List<NhanVien_DTO> LoadDSNVTheoSDT(string sdt)
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<NhanVien_DTO> nhanvien = new List<NhanVien_DTO>();

            string truyVan = "SELECT * from NhanVien WHERE SDT LIKE N'%{0}%' AND TrangThai = 1 AND ChucVu IN ('CV02', 'CV03')";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(string.Format(truyVan, sdt), connect);

            while (reader.Read())
            {
                NhanVien_DTO nv = new NhanVien_DTO()
                {
                    MaNV = reader["MaNV"].ToString(),
                    HoNV = reader["HoNV"].ToString(),
                    TenNV = reader["TenNV"].ToString(),
                    GioiTinh = reader["GioiTinh"].ToString(),
                    NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                    NgayLamViec = DateTime.Parse(reader["NgayLamViec"].ToString()),
                    SDT = reader["SDT"].ToString(),
                    Email = reader["Email"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    ChucVu = reader["ChucVu"].ToString(),
                    //Luong = int.Parse(reader["Luong"].ToString()),
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                nhanvien.Add(nv);
            }
            reader.Close();
            connect.Close();

            return nhanvien;
        }
        public List<NhanVien_DTO> LoadDSNVTheoChucVu(string chucvu)
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<NhanVien_DTO> nhanvien = new List<NhanVien_DTO>();

            string truyVan = "SELECT * from NhanVien WHERE ChucVu = '{0}' AND TrangThai = 1 AND ChucVu IN ('CV02', 'CV03')";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(string.Format(truyVan, chucvu), connect);

            while (reader.Read())
            {
                NhanVien_DTO nv = new NhanVien_DTO()
                {
                    MaNV = reader["MaNV"].ToString(),
                    HoNV = reader["HoNV"].ToString(),
                    TenNV = reader["TenNV"].ToString(),
                    GioiTinh = reader["GioiTinh"].ToString(),
                    NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                    NgayLamViec = DateTime.Parse(reader["NgayLamViec"].ToString()),
                    SDT = reader["SDT"].ToString(),
                    Email = reader["Email"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    ChucVu = reader["ChucVu"].ToString(),
                    //Luong = int.Parse(reader["Luong"].ToString()),
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                nhanvien.Add(nv);
            }
            reader.Close();
            connect.Close();

            return nhanvien;
        }
        public int DeleteNhanVien(string manv)
        {
            string delete = "UPDATE NhanVien SET TrangThai = 0 WHERE MaNV = @manv AND ChucVu in ('CV01', 'CV02', 'CV03')";

            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@manv", manv);

            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteUpdateQuery(delete, parameter, connect);
            connect.Close();
            return ketQua;
        }
        public int AddNhanVien(NhanVien_DTO nvDTO)
        {
            string insert = "INSERT INTO NhanVien(MaNV, HoNV, TenNV, GioiTinh, NgaySinh, NgayLamViec, SDT, Email, DiaChi, ChucVu, Luong, TrangThai, TrangThaiTK) VALUES(@MaNV, @HoNV, @TenNV, @GioiTinh, @NgaySinh, @NgayLamViec, @SDT, @Email, @DiaChi, @ChucVu, NULL, 1, 0)";

            SqlParameter[] parameter = new SqlParameter[10];
            parameter[0] = new SqlParameter("@MaNV", nvDTO.MaNV);
            parameter[1] = new SqlParameter("@HoNV", nvDTO.HoNV);
            parameter[2] = new SqlParameter("@TenNV", nvDTO.TenNV);
            parameter[3] = new SqlParameter("@GioiTinh", nvDTO.GioiTinh);
            parameter[4] = new SqlParameter("@NgaySinh", nvDTO.NgaySinh);
            parameter[5] = new SqlParameter("@NgayLamViec", nvDTO.NgayLamViec);
            parameter[6] = new SqlParameter("@SDT", nvDTO.SDT);
            parameter[7] = new SqlParameter("@Email", nvDTO.Email);
            parameter[8] = new SqlParameter("@DiaChi", nvDTO.DiaChi);
            parameter[9] = new SqlParameter("@ChucVu", nvDTO.ChucVu);


            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteInsertQuery(insert, parameter, connect);
            connect.Close();
            return ketQua;
        }
        public int UpdateNhanVien(NhanVien_DTO nvDTO)
        {
            string update = "UPDATE NhanVien SET HoNV = @HoNV, TenNV = @TenNV, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, NgayLamViec = @NgayLamViec, SDT = @SDT, Email = @Email, DiaChi = @DiaChi, ChucVu = @ChucVu WHERE MaNV = @MaNV";

            SqlParameter[] parameter = new SqlParameter[10];
            parameter[0] = new SqlParameter("@MaNV", nvDTO.MaNV);
            parameter[1] = new SqlParameter("@HoNV", nvDTO.HoNV);
            parameter[2] = new SqlParameter("@TenNV", nvDTO.TenNV);
            parameter[3] = new SqlParameter("@GioiTinh", nvDTO.GioiTinh);
            parameter[4] = new SqlParameter("@NgaySinh", nvDTO.NgaySinh);
            parameter[5] = new SqlParameter("@NgayLamViec", nvDTO.NgayLamViec);
            parameter[6] = new SqlParameter("@SDT", nvDTO.SDT);
            parameter[7] = new SqlParameter("@Email", nvDTO.Email);
            parameter[8] = new SqlParameter("@DiaChi", nvDTO.DiaChi);
            parameter[9] = new SqlParameter("@ChucVu", nvDTO.ChucVu);

            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteUpdateQuery(update, parameter, connect);
            connect.Close();
            return ketQua;
        }      

        #endregion


        #region NhanVienDaNghi

        public List<NhanVien_DTO> LoadDSNVDaNghiTheoMaNV(string manv)
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<NhanVien_DTO> nhanvien = new List<NhanVien_DTO>();

            string truyVan = "SELECT * from NhanVien WHERE MaNV LIKE N'%{0}%' AND TrangThai = 0";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(string.Format(truyVan, manv), connect);

            while (reader.Read())
            {
                NhanVien_DTO nv = new NhanVien_DTO()
                {
                    MaNV = reader["MaNV"].ToString(),
                    HoNV = reader["HoNV"].ToString(),
                    TenNV = reader["TenNV"].ToString(),
                    GioiTinh = reader["GioiTinh"].ToString(),
                    NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                    NgayLamViec = DateTime.Parse(reader["NgayLamViec"].ToString()),
                    SDT = reader["SDT"].ToString(),
                    Email = reader["Email"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    //Luong = int.Parse(reader["Luong"].ToString()),
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                nhanvien.Add(nv);
            }
            reader.Close();
            connect.Close();

            return nhanvien;
        }
        public List<NhanVien_DTO> LoadDSNVDaNghiTheoHoTen(string hoten)
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<NhanVien_DTO> nhanvien = new List<NhanVien_DTO>();

            string truyVan = "SELECT * from NhanVien WHERE HoNV+' '+TenNV LIKE N'%{0}%' AND TrangThai = 0";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(string.Format(truyVan, hoten), connect);

            while (reader.Read())
            {
                NhanVien_DTO nv = new NhanVien_DTO()
                {
                    MaNV = reader["MaNV"].ToString(),
                    HoNV = reader["HoNV"].ToString(),
                    TenNV = reader["TenNV"].ToString(),
                    GioiTinh = reader["GioiTinh"].ToString(),
                    NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                    NgayLamViec = DateTime.Parse(reader["NgayLamViec"].ToString()),
                    SDT = reader["SDT"].ToString(),
                    Email = reader["Email"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    //Luong = int.Parse(reader["Luong"].ToString()),
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                nhanvien.Add(nv);
            }
            reader.Close();
            connect.Close();

            return nhanvien;
        }
        public List<NhanVien_DTO> LoadDSNVDaNghiTheoSDT(string sdt)
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<NhanVien_DTO> nhanvien = new List<NhanVien_DTO>();

            string truyVan = "SELECT * from NhanVien WHERE SDT LIKE N'%{0}%' AND TrangThai = 0";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(string.Format(truyVan, sdt), connect);

            while (reader.Read())
            {
                NhanVien_DTO nv = new NhanVien_DTO()
                {
                    MaNV = reader["MaNV"].ToString(),
                    HoNV = reader["HoNV"].ToString(),
                    TenNV = reader["TenNV"].ToString(),
                    GioiTinh = reader["GioiTinh"].ToString(),
                    NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                    NgayLamViec = DateTime.Parse(reader["NgayLamViec"].ToString()),
                    SDT = reader["SDT"].ToString(),
                    Email = reader["Email"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    //Luong = int.Parse(reader["Luong"].ToString()),
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                nhanvien.Add(nv);
            }
            reader.Close();
            connect.Close();

            return nhanvien;
        }
        public int RestoreNhanVien(string manv)
        {
            string restore = "UPDATE NhanVien SET TrangThai = 1 WHERE MaNV = @manv";

            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@manv", manv);

            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteUpdateQuery(restore, parameter, connect);
            connect.Close();
            return ketQua;
        }

        #endregion
    }
}
