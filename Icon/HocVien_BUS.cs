using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DAO;
using ECM_DTO;

namespace ECM_BUS
{
    public class HocVien_BUS
    {
        HocVien_DAO hvDAO = new HocVien_DAO();
        public List<HocVien_DTO> DanhSachHV()
        {
            
            return hvDAO.LoadDanhSachHV();
        }
        public bool AddHV(HocVien_DTO hvDTO)
        {
            return hvDAO.AddHocVien(hvDTO);
        }
        public bool XoaHV(string mshv)
        {
            return hvDAO.EditDSHV(mshv);
        }        
    }
}
