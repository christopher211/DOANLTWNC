using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DAO;
using ECM_DTO;

namespace ECM_BUS
{
    public class Diem_BUS
    {
        public List<Diem_DTO> danhSachDiemHV(string malop)
        {
            Diem_DAO dDao = new Diem_DAO();
            return dDao.LoadDiemHV(malop);
        }
        public List<Diem_DTO> danhSachDiemHVTheoHoTen(string malop, string hoten)
        {
            Diem_DAO dDao = new Diem_DAO();
            return dDao.LoadDiemHVTheoHoTen(malop, hoten);
        }
        public List<Diem_DTO> danhSachDiemHVTheoMaHV(string malop, string mahv)
        {
            Diem_DAO dDao = new Diem_DAO();
            return dDao.LoadDiemHVTheoMaHV(malop, mahv);
        }
        public int addDiem(Diem_DTO diem)
        {
            Diem_DAO dDao = new Diem_DAO();
            return dDao.AddDiem(diem);
        }
        public int updateDiem(Diem_DTO diem)
        {
            Diem_DAO dDao = new Diem_DAO();
            return dDao.UpdateDiem(diem);
        }
        public int checkDiem(string mshv, string makh)
        {
            Diem_DAO dDao = new Diem_DAO();
            return dDao.CheckDiem(mshv, makh);
        }

    }
}
