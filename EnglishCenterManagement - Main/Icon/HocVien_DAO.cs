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

            string truyVan = "SELECT * from HocVien, KhoaHoc, Lop WHERE HocVien.KhoaHoc = KhoaHoc.MaKH AND HocVien.MaLop = Lop.MaLop AND HocVien.TrangThai = 1";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(truyVan, connect);
            if(hocVien!=null)
            {
                hocVien.Clear();
            }
            
            while(reader.Read())
            {
                HocVien_DTO hv = new HocVien_DTO()
                {
                    ID = int.Parse(reader["ID"].ToString()),
                    MSHV = reader["MSHV"].ToString(),
                    Ho = reader["Ho"].ToString(),
                    Ten = reader["Ten"].ToString(),
                    GioiTinh = reader["GioiTinh"].ToString(),
                    NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                    SDT = reader["SDT"].ToString(),
                    Email = reader["Email"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    TenKH = reader["TenKH"].ToString(),
                    TenLop = reader["MaLop"].ToString(),
                    HocPhi = int.Parse(reader["HocPhi"].ToString()),

                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                hocVien.Add(hv);
            }
            reader.Close();
            connect.Close();

            return hocVien;
        }
        public bool AddHocVien(HocVien_DTO hocVien_DTO)
        {
            string insert = "INSERT INTO HocVien(MSHV, Ho, Ten, GioiTinh, NgaySinh, SDT, Email, DiaChi, KhoaHoc, MaLop, HocPhi, TrangThai) VALUES(@MSHV, @Ho, @Ten, @GioiTinh, @NgaySinh, @SDT, @Email, @DiaChi, @KhoaHoc, @MaLop, 1, 1)";

            List<SqlParameter> lsPara = new List<SqlParameter>();
            lsPara.Add(new SqlParameter("@MSHV", hocVien_DTO.MSHV));
            lsPara.Add(new SqlParameter("@Ho", hocVien_DTO.Ho));
            lsPara.Add(new SqlParameter("@Ten", hocVien_DTO.Ten));
            lsPara.Add(new SqlParameter("@GioiTinh", hocVien_DTO.GioiTinh));
            lsPara.Add(new SqlParameter("@NgaySinh", hocVien_DTO.NgaySinh));
            lsPara.Add(new SqlParameter("@SDT", hocVien_DTO.SDT));
            lsPara.Add(new SqlParameter("@Email", hocVien_DTO.Email));
            lsPara.Add(new SqlParameter("@DiaChi", hocVien_DTO.DiaChi));
            lsPara.Add(new SqlParameter("@KhoaHoc", hocVien_DTO.KhoaHoc));
            lsPara.Add(new SqlParameter("@MaLop", hocVien_DTO.MaLop));

            SqlConnection connect = DataProvider.TaoKetNoi();
            bool ketQua = DataProvider.ThucThiCauLenh(insert, lsPara.ToArray(), connect);
            connect.Close();
            return ketQua;
        }

        public bool EditDSHV(string mshv)
        {
            SqlConnection con = DataProvider.TaoKetNoi();
            string xoa = "UPDATE HocVien SET TrangThai=0 where MSHV='@mahv'";
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@mahv", mshv);
            bool ket_qua = DataProvider.ThucThiCauLenh(xoa, par.ToArray(), con);
            con.Close();
            return ket_qua;

        }

    }
}	  