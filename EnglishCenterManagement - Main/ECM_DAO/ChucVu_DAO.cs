using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DTO;
using System.Data.SqlClient;

namespace ECM_DAO
{
    public class ChucVu_DAO
    {
        public List<ChucVu_DTO> LoadDSChucVu()
        {
            List<ChucVu_DTO> lsChucVu = new List<ChucVu_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            string strTruyVan = "SELECT * FROM ChucVu WHERE TrangThai = 1";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            while (reader.Read())
            {
                ChucVu_DTO chucvu = new ChucVu_DTO()
                {
                    MaCV = reader["MaCV"].ToString(),
                    TenCV = reader["TenCV"].ToString(),                    
                    TrangThai = int.Parse(reader["TrangThai"].ToString())
                };
                lsChucVu.Add(chucvu);
            }
            reader.Close();
            conn.Close();

            return lsChucVu;
        }
    }
}
