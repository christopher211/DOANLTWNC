using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DAO;
using ECM_DTO;

namespace ECM_BUS
{
    public class BienLai_BUS
    {
        public List<BienLai_DTO> DSBienLai()
        {
            BienLai_DAO blDAO = new BienLai_DAO();
            return blDAO.LoadDSBienLai();
        }
        public string maBienLaiTiepTheo()
        {
            BienLai_DAO blDAO = new BienLai_DAO();
            string MaBLLonNhat = blDAO.LayMaBLLonNhat();
            if (string.IsNullOrEmpty(MaBLLonNhat))
            {
                return "BL001";
            }
            else
            {
                int maso = int.Parse(MaBLLonNhat.Substring(2));
                return "BL" + (maso + 1).ToString("000");
            }
        }
        public int SaveBL(BienLai_DTO blDTO)
        {
            BienLai_DAO blDAO = new BienLai_DAO();
            return blDAO.SaveBienLai(blDTO);
        }
    }
}
