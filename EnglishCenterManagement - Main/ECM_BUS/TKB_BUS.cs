using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DAO;
using ECM_DTO;

namespace ECM_BUS
{
    public class TKB_BUS
    {
        public List<TKB_DTO> DSThoiKhoaBieu(string malop)
        {
            TKB_DAO tkbDAO = new TKB_DAO();
            return tkbDAO.LoadTKB(malop);
        }
        public int AddTKB(TKB_DTO diem)
        {
            TKB_DAO tkbDAO = new TKB_DAO();
            return tkbDAO.AddTKB(diem);
        }
    }
}
