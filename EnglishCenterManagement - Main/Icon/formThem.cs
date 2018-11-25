using ECM_BUS;
using ECM_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EnglishCenterManagement
{
    public partial class formThem : Form
    {
        HocVien_DTO HV_DTO = null;
        HocVien_BUS HV_BUS = new HocVien_BUS();
        frmQuanLyHocVien f;
        public string mshv;
        public bool luu;
        
        public formThem()
        {
            InitializeComponent();
            
        }
        public int them;
        private void barButtonItem_thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem_luulai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if(HV_DTO==null)
            {
                GetDetail();
            }
            bool kq = HV_BUS.AddHV(HV_DTO);
            if(kq)
            {
                //HV_DTO = null;
                MessageBox.Show(string.Format(" Thêm mới học viên {0} thành công ", HV_DTO.MSHV));
                them = 1;
            }
            else
            {
                MessageBox.Show("Thêm thất bại !");
            }
            //if(HV_DTO!=null)
            //{
            //    HV_DTO = new HocVien_DTO();
            //}
           
            //RESET();
        }
        private void RESET()
        {
            //HV_DTO.MSHV = null;
            //HV_DTO.Ho = null;
            //HV_DTO.Ten = null;
            //HV_DTO.GioiTinh = null;
            //HV_DTO.NgaySinh = DateTime.Now;
            //HV_DTO.SDT = null;
            //HV_DTO.Email = null;
            //HV_DTO.DiaChi = null;
            //HV_DTO.KhoaHoc = null;
            //HV_DTO.MaLop = null;
            txt_ma.Text = string.Empty;
            txt_ho.Text = string.Empty;
            txt_ten.Text = string.Empty;
            cb_gioitinh.EditValue = string.Empty;
            dt_ngaysinh.EditValue = string.Empty;
            txt_sdt.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_diachi.Text = string.Empty;
            cb_khoahoc.EditValue = string.Empty;
            cb_malop.EditValue = string.Empty;    
        }
        
        private void GetDetail()
        {
            if(HV_DTO==null)
            {
                HV_DTO = new HocVien_DTO();
            }
            HV_DTO.MSHV = txt_ma.Text;
            HV_DTO.Ho = txt_ho.Text;
            HV_DTO.Ten = txt_ten.Text;
            if(cb_gioitinh.EditValue.ToString()=="Nam")
            {
                HV_DTO.GioiTinh = "Nam";
            }
            else
            {
                HV_DTO.GioiTinh = "Nữ";
            }

            HV_DTO.NgaySinh =  DateTime.Parse(dt_ngaysinh.EditValue.ToString());
            HV_DTO.SDT = txt_sdt.Text;
            HV_DTO.Email = txt_email.Text;
            HV_DTO.DiaChi = txt_diachi.Text;
            if(cb_khoahoc.EditValue.ToString()=="IELTS")
            {
                HV_DTO.KhoaHoc = "KH01";
            }
            else if(cb_khoahoc.EditValue.ToString()=="IELTS_ADVANCED")
            {
                HV_DTO.KhoaHoc = "KH02";
            }else if(cb_khoahoc.EditValue.ToString()=="TOEFL-IBT")
            {
                HV_DTO.KhoaHoc = "KH03";
            }else if(cb_khoahoc.EditValue.ToString()=="TOEFL-IBT_ADVANCED")
            {
                HV_DTO.KhoaHoc = "KH04";
            }else if(cb_khoahoc.EditValue.ToString()=="TOEIC")
            {
                HV_DTO.KhoaHoc = "KH05";
            }else if(cb_khoahoc.EditValue.ToString()=="TOEIC_ADVANCED")
            {
                HV_DTO.KhoaHoc = "KH06";
            }

            if(cb_malop.EditValue.ToString()=="LH01")
            {
                HV_DTO.MaLop = "LH01";
            }else if(cb_malop.EditValue.ToString()=="LH02")
            {
                HV_DTO.MaLop = "LH02";
            }else if(cb_malop.EditValue.ToString()=="LH03")
            {
                HV_DTO.MaLop = "LH03";
            }else if(cb_malop.EditValue.ToString()=="LH04")
            {
                HV_DTO.MaLop = "LH04";
            }else if(cb_malop.EditValue.ToString()=="LH05")
            {
                HV_DTO.MaLop = "LH05";
            }else if(cb_malop.EditValue.ToString()=="LH06")
            {
                HV_DTO.MaLop = "LH06";
            }

            //HV_DTO = new HocVien_DTO();
        }

        private void txt_ma_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void formThem_Load(object sender, EventArgs e)
        {
          
        }

    }
}
