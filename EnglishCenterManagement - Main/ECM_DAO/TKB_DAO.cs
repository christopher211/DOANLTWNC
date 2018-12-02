using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DTO;
using System.Data.SqlClient;

namespace ECM_DAO
{
    public class TKB_DAO
    {
        public List<TKB_DTO> LoadTKB(string malop)
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<TKB_DTO> lsTKB = new List<TKB_DTO>();
            string truyVan = "SELECT Lop.MaLop, Lop.MaPhg, Lop.MaNV, ThoiKhoaBieu.Thu, ThoiKhoaBieu.Ngay, ThoiKhoaBieu.Thang, ThoiKhoaBieu.Nam FROM ThoiKhoaBieu RIGHT JOIN Lop ON ThoiKhoaBieu.MaLop = Lop.MaLop WHERE Lop.MaLop = @MaLop";

            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@MaLop", malop);

            SqlDataReader reader = DataProvider.TruyVanDuLieu(truyVan, par, connect);
            while (reader.Read())
            {
                TKB_DTO tkb = new TKB_DTO();

                tkb.MaLop = reader["MaLop"].ToString().Trim();
                tkb.MaPhg = reader["MaPhg"].ToString().Trim();
                tkb.MaNV = reader["MaNV"].ToString().Trim();
                tkb.Thu = Utilities.ConvertToString(reader["Thu"].ToString(), "0");
                tkb.Ngay = Utilities.ConvertToString(reader["Ngay"].ToString(), "0");
                tkb.Thang = Utilities.ConvertToString(reader["Thang"].ToString(), "0");
                tkb.Nam = Utilities.ConvertToString(reader["Nam"].ToString(), "0");
                
                lsTKB.Add(tkb);
            }
            reader.Close();
            connect.Close();
            return lsTKB;
        }
        public int AddTKB(TKB_DTO tkb)
        {
            string insert = "INSERT INTO ThoiKhoaBieu (MaLop, MaPhg, MaNV, Thu, Ngay, Thang, Nam, TrangThai) VALUES(@MaLop, @MaPhg, @MaNV, @Thu, @Ngay, @Thang, @Nam, 1)";

            SqlParameter[] par = new SqlParameter[7];
            par[0] = new SqlParameter("@MaLop", tkb.MaLop);
            par[1] = new SqlParameter("@MaPhg", tkb.MaPhg);
            par[2] = new SqlParameter("@MaNV", tkb.MaNV);
            par[3] = new SqlParameter("@Thu", tkb.Thu);
            par[4] = new SqlParameter("@Ngay", tkb.Ngay);
            par[5] = new SqlParameter("@Thang", tkb.Thang);
            par[6] = new SqlParameter("@Nam", tkb.Nam);

            SqlConnection connect = DataProvider.TaoKetNoi();
            int ketQua = DataProvider.ExecuteInsertQuery(insert, par, connect);
            connect.Close();
            return ketQua;
        }
    }
}
