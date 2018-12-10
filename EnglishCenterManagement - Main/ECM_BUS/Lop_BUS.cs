using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM_DAO;
using ECM_DTO;
using System.Text.RegularExpressions;

namespace ECM_BUS
{
    public class Lop_BUS
    {
        public List<Lop_DTO> DanhSachLop()
        {
            Lop_DAO lopDAO = new Lop_DAO();
            return lopDAO.LoadDSLop();
        }
        public List<Lop_DTO> DanhSachLop2(string makhoa)
        {
            Lop_DAO lopDao = new Lop_DAO();
            return lopDao.loadDSLop2(makhoa);
        }
        public string maLopTiepTheo()
        {
            Lop_DAO hvDAO = new Lop_DAO();
            string MaLopLonNhat = hvDAO.LayMaLopLonNhat();
            if (string.IsNullOrEmpty(MaLopLonNhat))
            {
                return "LH01";
            }
            else
            {                
                int maso = int.Parse(MaLopLonNhat.Substring(2));
                return "LH" + (maso + 1).ToString("00");
            }
        }
        public string soLopTiepTheo(string makh)
        {
            Lop_DAO hvDAO = new Lop_DAO();
            string MaLopLonNhat = hvDAO.LaySoLopLonNhat(makh);
            if (string.IsNullOrEmpty(MaLopLonNhat))
            {
                return "1";
            }

            //cách khác:      
            //var getNumbers = (from t in MaLopLonNhat
            //                  where char.IsDigit(t)
            //                  select t).ToArray();
            //string strMaMax = new string(getNumbers);

            string strMaMax = Regex.Replace(MaLopLonNhat, @"\D", "");
            int soMax = int.Parse(strMaMax);
            int maTiepTheo = soMax + 1;
            return maTiepTheo.ToString();
            
        }

        public int AddLop(Lop_DTO lopDTO)
        {
            Lop_DAO lopDAO = new Lop_DAO();
            return lopDAO.AddLopHoc(lopDTO);
        }
        public int UpdateLop(Lop_DTO lopDTO)
        {
            Lop_DAO lopDAO = new Lop_DAO();
            return lopDAO.UpdateLopHoc(lopDTO);
        }
        public int DeleteLop(string malop)
        {
            Lop_DAO lopDAO = new Lop_DAO();
            return lopDAO.DeleteLopHoc(malop);
        }

    }
}
