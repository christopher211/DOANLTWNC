using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DTO;
using System.Data.SqlClient;

namespace ECM_DAO
{
    public class Diem_DAO
    {        
        public List<Diem_DTO> LoadDiemHV(string malop)
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<Diem_DTO> lsDiem = new List<Diem_DTO>();
            string truyVan = "SELECT HocVien.MSHV, HocVien.Ho, HocVien.Ten, HocVien.MaKH, HocVien.MaLop, Diem.Nghe, Diem.Noi, Diem.Doc, Diem.Viet, Diem.DiemTB FROM Diem RIGHT JOIN HocVien ON Diem.MSHV = HocVien.MSHV AND Diem.MaKH = HocVien.MaKH WHERE HocVien.MaLop = @MaLop";

            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@MaLop", malop);

            SqlDataReader reader = DataProvider.TruyVanDuLieu(truyVan, par, connect);
            while (reader.Read())
            {
                Diem_DTO diem = new Diem_DTO();

                diem.MSHV = reader["MSHV"].ToString().Trim();
                diem.MaKH = reader["MaKH"].ToString().Trim();
                diem.Ho = reader["Ho"].ToString().Trim();
                diem.Ten = reader["Ten"].ToString().Trim();
                diem.MaLop = reader["MaLop"].ToString().Trim();
                diem.Nghe = float.Parse(Utilities.ConvertToString(reader["Nghe"].ToString(), "0"));
                diem.Noi = float.Parse(Utilities.ConvertToString(reader["Noi"].ToString(), "0"));
                diem.Doc = float.Parse(Utilities.ConvertToString(reader["Doc"].ToString(), "0"));
                diem.Viet = float.Parse(Utilities.ConvertToString(reader["Viet"].ToString(), "0"));
                diem.DiemTB = float.Parse(Utilities.ConvertToString(reader["DiemTB"].ToString(), "0"));

                lsDiem.Add(diem);
            }
            reader.Close();
            connect.Close();
            return lsDiem;
        }
        public int AddDiem(Diem_DTO diem)
        {
            string insert = "INSERT INTO Diem (MSHV, MaKH, MaLop, Nghe, Noi, Doc, Viet, DiemTB, TrangThai) VALUES(@MSHV, @MaKH, @MaLop, @Nghe, @Noi, @Doc, @Viet, @DiemTB, 1)";

            SqlParameter[] par = new SqlParameter[8];
            par[0] = new SqlParameter("@MSHV", diem.MSHV);
            par[1] = new SqlParameter("@MaKH", diem.MaKH);
            par[2] = new SqlParameter("@MaLop", diem.MaLop);
            par[3] = new SqlParameter("@Nghe", diem.Nghe);
            par[4] = new SqlParameter("@Noi", diem.Noi);
            par[5] = new SqlParameter("@Doc", diem.Doc);
            par[6] = new SqlParameter("@Viet", diem.Viet);
            par[7] = new SqlParameter("@DiemTB", diem.DiemTB);

            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteInsertQuery(insert, par, connect);
            connect.Close();
            return ketQua;
        }
        public int UpdateDiem(Diem_DTO diem)
        {
            string update = "UPDATE Diem SET Nghe = @Nghe, Noi = @Noi, Doc = @Doc, Viet = @Viet, DiemTB = @DiemTB WHERE MSHV = @MSHV AND MaKH = @MaKH";

            SqlParameter[] par = new SqlParameter[7];
            par[0] = new SqlParameter("@MSHV", diem.MSHV);
            par[1] = new SqlParameter("@MaKH", diem.MaKH);            
            par[2] = new SqlParameter("@Nghe", diem.Nghe);
            par[3] = new SqlParameter("@Noi", diem.Noi);
            par[4] = new SqlParameter("@Doc", diem.Doc);
            par[5] = new SqlParameter("@Viet", diem.Viet);
            par[6] = new SqlParameter("@DiemTB", diem.DiemTB);

            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteUpdateQuery(update, par, connect);
            connect.Close();
            return ketQua;
        }
        public int CheckDiem(string mshv, string makh)
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            string strTruyVan = "SELECT COUNT(1) FROM Diem WHERE MSHV = @MSHV AND MaKH = @MaKH";

            SqlParameter[] par = new SqlParameter[2];
            par[0] = new SqlParameter("@MSHV", mshv);
            par[1] = new SqlParameter("@MaKH", makh);

            SqlDataReader reader = DataProvider.TruyVanDuLieu(strTruyVan, par, connect);
            int strKetQua = 0;
            if (reader.Read())
            {
                strKetQua = int.Parse(reader[0].ToString());
            }
            reader.Close();
            connect.Close();
            return strKetQua;
        }
    }
}
