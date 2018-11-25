using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DAO;
using ECM_DTO;

namespace ECM_BUS
{
    public class PhongHoc_BUS
    {
        public List<PhongHoc_DTO> DanhSachPH()
        {
            PhongHoc_DAO phDAO = new PhongHoc_DAO();
            return phDAO.LoadDSPhongHoc();
        }
    }
}
