using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DAO;
using ECM_DTO;

namespace ECM_BUS
{
    public class KhoaHoc_BUS
    {
        public List<KhoaHoc_DTO> DanhSachKH()
        {
            KhoaHoc_DAO khDAO = new KhoaHoc_DAO();
            return khDAO.LoadDSKhoaHoc();
        }
        public List<KhoaHoc_DTO> DanhSachKHTheoMaKH(string makh)
        {
            KhoaHoc_DAO khDAO = new KhoaHoc_DAO();
            return khDAO.LoadDSKhoaHocTheoMaKH(makh);
        }
        public List<KhoaHoc_DTO> DanhSachKHTheoTen(string tenkh)
        {
            KhoaHoc_DAO khDAO = new KhoaHoc_DAO();
            return khDAO.LoadDSKhoaHocTheoTen(tenkh);
        }
        public string maKhoaHocTiepTheo()
        {
            KhoaHoc_DAO khDAO = new KhoaHoc_DAO();
            string MaKHLonNhat = khDAO.LayMaKHLonNhat();
            if (string.IsNullOrEmpty(MaKHLonNhat))
            {
                return "KH01";
            }
            else
            {
                //int maso = int.Parse(MaLonNhat.Replace('HV', ' '));
                int maso = int.Parse(MaKHLonNhat.Substring(2));

                //return string.Format("S{0:3}", maso + 1);
                return "KH" + (maso + 1).ToString("00");
            }
        }
        public int AddKH(KhoaHoc_DTO khDTO)
        {
            KhoaHoc_DAO khDAO = new KhoaHoc_DAO();
            return khDAO.AddKhoaHoc(khDTO);
        }
        public int UpdateKH(KhoaHoc_DTO khDTO)
        {
            KhoaHoc_DAO khDAO = new KhoaHoc_DAO();
            return khDAO.UpdateKhoaHoc(khDTO);
        }
        public int DeleteKH(string makh)
        {
            KhoaHoc_DAO khDAO = new KhoaHoc_DAO();
            return khDAO.DeleteKhoaHoc(makh);
        }        
    }

}
