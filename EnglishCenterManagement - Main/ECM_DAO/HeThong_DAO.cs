using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DTO;
using System.Data.SqlClient;

namespace ECM_DAO
{
    public class HeThong_DAO
    {
        public List<HeThong_DTO> LoadNKHeThong()
        {
            SqlConnection connect = DataProvider.TaoKetNoi();
            List<HeThong_DTO> hethong = new List<HeThong_DTO>();

            string truyVan = "SELECT * FROM NKHeThong";
            SqlDataReader reader = DataProvider.TruyVanDuLieu(truyVan, connect);

            while (reader.Read())
            {
                HeThong_DTO ht = new HeThong_DTO()
                {
                    
                };
                hethong.Add(ht);
            }
            reader.Close();
            connect.Close();

            return hethong;
        }
    }
}
