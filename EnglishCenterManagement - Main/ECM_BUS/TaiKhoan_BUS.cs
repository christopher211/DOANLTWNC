using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DAO;
using ECM_DTO;

namespace ECM_BUS
{
    public class TaiKhoan_BUS
    {       
        public int AdminLogin(string tenDangNhap, string matKhau)
        {
            TaiKhoan_DAO user_DAO = new TaiKhoan_DAO();            
            if(user_DAO.CheckAdminLogin(tenDangNhap, matKhau) == 1)
            {
                return 1;
            }
            return 0;
        }
        public int ModLogin(string tenDangNhap, string matKhau)
        {
            TaiKhoan_DAO user_DAO = new TaiKhoan_DAO();
            if (user_DAO.CheckModLogin(tenDangNhap, matKhau) == 1)
            {
                return 1;
            }
            return 0;
        }
        public int UserLogin(string tenDangNhap, string matKhau)
        {
            TaiKhoan_DAO user_DAO = new TaiKhoan_DAO();
            if (user_DAO.CheckUserLogin(tenDangNhap, matKhau) == 1)
            {
                return 1;
            }
            return 0;
        }
        public  List<TaiKhoan_DTO> danhsachTK()
        {
            TaiKhoan_DAO tkDAO = new TaiKhoan_DAO();
            return tkDAO.LoadDSTaiKhoan();
        }
        public int AddTK(TaiKhoan_DTO tkDTO)
        {
            TaiKhoan_DAO tkDAO = new TaiKhoan_DAO();
            return tkDAO.AddTaiKhoan(tkDTO);
        }
        public int UpdateTK(string manv)
        {
            TaiKhoan_DAO tkDAO = new TaiKhoan_DAO();
            return tkDAO.UpdateTaiKhoan(manv);
        }
    }
}
