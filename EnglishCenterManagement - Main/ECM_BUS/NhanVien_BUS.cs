using ECM_DAO;
using ECM_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM_BUS
{
    public class NhanVien_BUS
    {
        #region GiaoVien

        public List<NhanVien_DTO> danhsachGV()
        {
            NhanVien_DAO giaovien = new NhanVien_DAO();
            return giaovien.LoadDSGV();
        }
        public List<NhanVien_DTO> danhsachGVTheoMaGV(string manv)
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            return nvDAO.LoadDSGVTheoMaGV(manv);
        }
        public List<NhanVien_DTO> danhsachGVDaNghi()
        {
            NhanVien_DAO nhanvien = new NhanVien_DAO();
            return nhanvien.LoadDSNVDaNghi();
        }
        public List<NhanVien_DTO> danhsachGVTheoHoTen(string hoten)
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            return nvDAO.LoadDSGVTheoHoTen(hoten);
        }
        public List<NhanVien_DTO> danhsachGVTheoSDT(string sdt)
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            return nvDAO.LoadDSGVTheoSDT(sdt);
        }
        public int AddGV(NhanVien_DTO gvDTO)
        {
            NhanVien_DAO gvDAO = new NhanVien_DAO();
            return gvDAO.AddGiaoVien(gvDTO);
        }        
        public int DeleteGV(string manv)
        {
            NhanVien_DAO gvDAO = new NhanVien_DAO();
            return gvDAO.DeleteGiaoVien(manv);
        }
        public int UpdateGV(NhanVien_DTO gvDTO)
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            return nvDAO.UpdateGiaoVien(gvDTO);
        }

        #endregion





        #region NhanVien

        public List<NhanVien_DTO> danhsachNV()
        {
            NhanVien_DAO nhanvien = new NhanVien_DAO();
            return nhanvien.LoadDSNV();
        }
        public List<NhanVien_DTO> danhsachNVChuaCoTaiKhoan()
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            return nvDAO.LoadDSNVChuaCoTaiKhoan();
        }
        public List<NhanVien_DTO> danhsachNVTheoMaNV(string manv)
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            return nvDAO.LoadDSNVTheoMaNV(manv);
        }
        public List<NhanVien_DTO> danhsachNVTheoHoTen(string hoten)
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            return nvDAO.LoadDSNVTheoHoTen(hoten);
        }
        public List<NhanVien_DTO> danhsachNVTheoSDT(string sdt)
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            return nvDAO.LoadDSNVTheoSDT(sdt);
        }
        public List<NhanVien_DTO> danhsachNVTheoChucVu(string chucvu)
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            return nvDAO.LoadDSNVTheoChucVu(chucvu);
        }
        public int AddNV(NhanVien_DTO nvDTO)
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            return nvDAO.AddNhanVien(nvDTO);
        }
        public int DeleteNV(string manv)
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            return nvDAO.DeleteNhanVien(manv);
        }
        public int UpdateNV(NhanVien_DTO nvDTO)
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            return nvDAO.UpdateNhanVien(nvDTO);
        }
        public int RestoreNV(string manv)
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            return nvDAO.RestoreNhanVien(manv);
        }

        #endregion



        #region NhanVienDaNghi

        public List<NhanVien_DTO> danhsachNVDaNghiTheoMaNV(string manv)
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            return nvDAO.LoadDSNVDaNghiTheoMaNV(manv);
        }
        public List<NhanVien_DTO> danhsachNVDaNghiTheoHoTen(string hoten)
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            return nvDAO.LoadDSNVDaNghiTheoHoTen(hoten);
        }
        public List<NhanVien_DTO> danhsachNVDaNghiTheoSDT(string sdt)
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            return nvDAO.LoadDSNVDaNghiTheoSDT(sdt);
        }

        #endregion
        public string maNhanVienTiepTheo()
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            string MaNVLonNhat = nvDAO.LayMaNVLonNhat();
            if (string.IsNullOrEmpty(MaNVLonNhat))
            {
                return "NV01";
            }
            else
            {
                //int maso = int.Parse(MaLonNhat.Replace('HV', ' '));
                int maso = int.Parse(MaNVLonNhat.Substring(2));

                //return string.Format("S{0:3}", maso + 1);
                return "NV" + (maso + 1).ToString("00");
            }
        }


    }
}
