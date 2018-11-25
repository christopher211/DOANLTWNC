using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DTO;
using System.Data.SqlClient;

namespace ECM_DAO
{
    public class PhongHoc_DAO
    {
        public List<PhongHoc_DTO> LoadDSPhongHoc()
        {
            List<PhongHoc_DTO> lsPhongHoc = new List<PhongHoc_DTO>();
            SqlConnection connect = DataProvider.TaoKetNoi();

            string strTruyVan = "SELECT * FROM PhongHoc WHERE TrangThai = 1";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(strTruyVan, connect);
            while (reader.Read())
            {
                PhongHoc_DTO ph = new PhongHoc_DTO()
                {
                    MaPhong = reader["MaPhong"].ToString(),
                    TenPhong = reader["TenPhong"].ToString(),                  
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                lsPhongHoc.Add(ph);
            }
            reader.Close();
            connect.Close();

            return lsPhongHoc;
        }
    }
}
