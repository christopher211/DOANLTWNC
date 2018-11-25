using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DAO;
using ECM_DTO;

namespace ECM_BUS
{
    public class ChucVu_BUS
    {
        public List<ChucVu_DTO> DanhSachCV()
        {
            ChucVu_DAO cvDAO = new ChucVu_DAO();
            return cvDAO.LoadDSChucVu();
        }
    }
}
