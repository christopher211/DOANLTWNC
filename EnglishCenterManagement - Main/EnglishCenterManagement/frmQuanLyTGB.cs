using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ECM_BUS;
using ECM_DTO;

namespace EnglishCenterManagement
{
    public partial class frmQuanLyTGB : DevExpress.XtraEditors.XtraForm
    {
        List<TKB_DTO> lsTKB;
        List<Lop_DTO> lsLop;

        Lop_BUS lopBUS = new Lop_BUS();
        Lop_DTO lopDTO = new Lop_DTO();

        TKB_BUS tkbBUS = new TKB_BUS();
        TKB_DTO tkbDTO = new TKB_DTO();

        public frmQuanLyTGB()
        {
            InitializeComponent();
        }

        private void frmQuanLyTGB_Load(object sender, EventArgs e)
        {
            LoadDSLop();
        }
        private void LoadDSLop()
        {
            lsLop = new List<Lop_DTO>();
            lsLop = lopBUS.DanhSachLop();

            lke_maLop.Properties.DataSource = lsLop;
            lke_maLop.Properties.DisplayMember = "MaLop";
            lke_maLop.Properties.ValueMember = "MaLop";
        }
        private void LoadTKB()
        {
            lsTKB = new List<TKB_DTO>();
            lsTKB = tkbBUS.DSThoiKhoaBieu(lke_maLop.Text.Trim());
            dgcontrol_thoiKhoaBieu.DataSource = lsTKB;
        }

        private void btn_timLop_Click(object sender, EventArgs e)
        {
            LoadTKB();
        }

        private void dgcontrol_thoiKhoaBieu_Click(object sender, EventArgs e)
        {
            if (dgview_thoiKhoaBieu.SelectedRowsCount > 0)
            {
                int[] selectedRows = dgview_thoiKhoaBieu.GetSelectedRows();
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                    {
                        tkbDTO.MaLop = dgview_thoiKhoaBieu.GetRowCellValue(rowHandle, cl_malop).ToString().Trim();
                        tkbDTO.MaPhg = dgview_thoiKhoaBieu.GetRowCellValue(rowHandle, cl_maphg).ToString().Trim();
                        tkbDTO.MaNV = dgview_thoiKhoaBieu.GetRowCellValue(rowHandle, cl_manv).ToString().Trim();
                        tkbDTO.Thu = dgview_thoiKhoaBieu.GetRowCellValue(rowHandle, cl_thu).ToString().Trim();
                        tkbDTO.Ngay = dgview_thoiKhoaBieu.GetRowCellValue(rowHandle, cl_ngay).ToString().Trim();
                        tkbDTO.Thang = dgview_thoiKhoaBieu.GetRowCellValue(rowHandle, cl_thang).ToString().Trim();
                        tkbDTO.Nam = dgview_thoiKhoaBieu.GetRowCellValue(rowHandle, cl_nam).ToString().Trim();
                    }
                }
            }
            else
            {
                tkbDTO = null;
            }
            BindingChiTiet();
        }
        private void GetTKB()
        {
            if (tkbDTO != null)
            {
                tkbDTO = new TKB_DTO();
            }
            tkbDTO.MaLop = lke_maLop.Text;
            tkbDTO.MaPhg = txt_maphg.Text;
            tkbDTO.MaNV = txt_manv.Text;
            tkbDTO.Thu = cb_thu.Text;
            tkbDTO.Ngay = cb_ngay.Text;
            tkbDTO.Thang = cb_thang.Text;
            tkbDTO.Nam = txt_nam.Text;
        }
        private void BindingChiTiet()
        {
            if (tkbDTO != null)
            {
                lke_maLop.Text = tkbDTO.MaLop;
                txt_maphg.Text = tkbDTO.MaPhg;
                txt_manv.Text = tkbDTO.MaNV;
                cb_thu.Text = tkbDTO.Thu;
                cb_ngay.Text = tkbDTO.Ngay;
                cb_thang.Text = tkbDTO.Thang;
                txt_nam.Text = tkbDTO.Nam;
            }
            else
            {
                lke_maLop.Text = string.Empty;
                txt_maphg.Text = string.Empty;
                txt_manv.Text = string.Empty;
                cb_thu.Text = string.Empty;
                cb_ngay.Text = string.Empty;
                cb_thang.Text = string.Empty;
                txt_nam.Text = string.Empty;
            }
        }
        private void RefreshTextbox()
        {
            lke_maLop.Text = string.Empty;
            txt_maphg.Text = string.Empty;
            txt_manv.Text = string.Empty;
            cb_thu.Text = string.Empty;
            cb_ngay.Text = string.Empty;
            cb_thang.Text = string.Empty;
            txt_nam.Text = string.Empty;
        }

        private void btn_themTKB_Click(object sender, EventArgs e)
        {
            if (cb_thu.Text.Trim() == "" || cb_ngay.Text.Trim() == "" || cb_thang.Text.Trim() == "" || txt_nam.Text.Trim() == "")
            {
                XtraMessageBox.Show("Chưa chọn đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (tkbDTO != null)
                {
                    GetTKB();
                    int kq = tkbBUS.AddTKB(tkbDTO);
                    if (kq == 1)
                    {
                        XtraMessageBox.Show(string.Format("Thêm thời khóa biểu cho lớp {0} thành công!", tkbDTO.MaLop), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshTextbox();

                        //btn_themLopHoc.Enabled = false;
                        //btn_suaLopHoc.Enabled = true;
                        //dgcontrol_lopHoc.Enabled = true;
                    }
                    else
                    {
                        XtraMessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }
    }
}