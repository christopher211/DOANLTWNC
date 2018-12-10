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
        public List<HocVien_DTO> danhSachHV()
        {
            HocVien_DAO hvDAO = new HocVien_DAO();
            return hvDAO.LoadDanhSachHV();
        }        
        public List<HocVien_DTO> danhSachHVDaNghi()
        {
            HocVien_DAO hvDAO = new HocVien_DAO();
            return hvDAO.LoadDanhSachHVDaNghi();
        }
       
        public string maHocVienTiepTheo()
        {
            HocVien_DAO hvDAO = new HocVien_DAO();
            string MaHVLonNhat = hvDAO.LayMaHVLonNhat();
            if (string.IsNullOrEmpty(MaHVLonNhat))
            {
                return "HV001";
            }
            else
            {               
                int maso = int.Parse(MaHVLonNhat.Substring(2));               
                return "HV" + (maso + 1).ToString("000");
            }
        }
        public int AddHV(HocVien_DTO hvDTO)
        {
            HocVien_DAO hvDAO = new HocVien_DAO();
            return hvDAO.AddHocVien(hvDTO);
        }
        public int UpdateHV(HocVien_DTO hvDTO)
        {
            HocVien_DAO hvDAO = new HocVien_DAO();
            return hvDAO.UpdateHocVien(hvDTO);
        }
        public int DeleteHV(string mshv, string makh)
        {
            HocVien_DAO hvDAO = new HocVien_DAO();
            return hvDAO.DeleteHocVien(mshv, makh);
        }
        public int RestoreHV(string mshv)
        {
            HocVien_DAO hvDAO = new HocVien_DAO();
            return hvDAO.RestoreHocVien(mshv);
        }


        //public List<HocVien_DTO> danhsachHVTheoLop_Diem(string lop)
        //{
        //    HocVien_DAO hvDAO = new HocVien_DAO();
        //    return hvDAO.LoadDanhSachHVTheoLop_Diem(lop);
        //}
    }
}
