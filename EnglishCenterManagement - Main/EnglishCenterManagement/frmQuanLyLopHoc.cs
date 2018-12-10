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
    public partial class frmQuanLyLopHoc : DevExpress.XtraEditors.XtraForm
    {
        bool isClick = true;
        List<Lop_DTO> lsLop;
        List<KhoaHoc_DTO> lsKhoaHoc;
        List<NhanVien_DTO> lsNhanVien;
        List<PhongHoc_DTO> lsPhongHoc;

        Lop_BUS lopBUS = new Lop_BUS();
        Lop_DTO lopDTO = new Lop_DTO();

        KhoaHoc_BUS khBUS = new KhoaHoc_BUS();
        KhoaHoc_DTO khDTO = new KhoaHoc_DTO();

        NhanVien_BUS nvBUS = new NhanVien_BUS();
        NhanVien_DTO nvDTO = new NhanVien_DTO();

        PhongHoc_BUS phBUS = new PhongHoc_BUS();
        PhongHoc_DTO phDTO = new PhongHoc_DTO();

        public frmQuanLyLopHoc()
        {
            InitializeComponent();
        }

        private void frmQuanLyLopHoc_Load(object sender, EventArgs e)
        {
            btn_themLopHoc.Enabled = false;
            LoadDSLop();
            LoadDSKhoaHoc();
            LoadDSGiaoVien();
            LoadDSPhongHoc();
        }
        private void LoadDSLop()
        {
            lsLop = new List<Lop_DTO>();
            lsLop = lopBUS.DanhSachLop();
            dgcontrol_lopHoc.DataSource = lsLop;
        }
        private void LoadDSKhoaHoc()
        {
            lsKhoaHoc = new List<KhoaHoc_DTO>();
            lsKhoaHoc = khBUS.DanhSachKH();

            lke_makh.Properties.DataSource = lsKhoaHoc;
            lke_makh.Properties.DisplayMember = "MaKH";
            lke_makh.Properties.ValueMember = "MaKH";
        }
        private void LoadDSGiaoVien()
        {
            lsNhanVien = new List<NhanVien_DTO>();
            lsNhanVien = nvBUS.danhsachGV();

            lke_maNhanVien.Properties.DataSource = lsNhanVien;
            lke_maNhanVien.Properties.DisplayMember = "MaNV";
            lke_maNhanVien.Properties.ValueMember = "MaNV";
        }
        private void LoadDSPhongHoc()
        {
            lsPhongHoc = new List<PhongHoc_DTO>();
            lsPhongHoc = phBUS.DanhSachPH();

            lke_phongHoc.Properties.DataSource = lsPhongHoc;
            lke_phongHoc.Properties.DisplayMember = "MaPhong";
            lke_phongHoc.Properties.ValueMember = "MaPhong";

        }
        private void BindingChiTiet()
        {
            if(lopDTO != null)
            {
                txt_maLop.Text = lopDTO.MaLop;
                lke_makh.Text = lopDTO.MaKhoaHoc;
                txt_tenLop.Text = lopDTO.TenLop;
                lke_maNhanVien.Text = lopDTO.MaNV;
                lke_phongHoc.Text = lopDTO.MaPhg;
                cbo_lichHoc.Text = lopDTO.LichHoc;
                time_gioBatDau.EditValue = lopDTO.GioBatDau;
                time_gioKetThuc.EditValue = lopDTO.GioKetThuc;
            }
            else
            {
                txt_maLop.Text = string.Empty;
                lke_makh.Text = string.Empty;
                txt_tenLop.Text = string.Empty;
                lke_maNhanVien.Text = string.Empty;
                lke_phongHoc.Text = string.Empty;
                cbo_lichHoc.Text = string.Empty;
                time_gioBatDau.Text = string.Empty;
                time_gioKetThuc.Text = string.Empty;
            }
        }
        private void dgcontrol_lopHoc_Click(object sender, EventArgs e)
        {
            LoadDSKhoaHoc();
            LoadDSGiaoVien();
            if (dgview_lopHoc.SelectedRowsCount > 0)
            {
                int[] selectedRows = dgview_lopHoc.GetSelectedRows();
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                    {
                        lopDTO.MaLop = dgview_lopHoc.GetRowCellValue(rowHandle, cl_malop).ToString().Trim();
                        lopDTO.MaKhoaHoc = dgview_lopHoc.GetRowCellValue(rowHandle, cl_makhoahoc).ToString().Trim();
                        lopDTO.TenLop = dgview_lopHoc.GetRowCellValue(rowHandle, cl_tenlop).ToString().Trim();
                        lopDTO.MaNV = dgview_lopHoc.GetRowCellValue(rowHandle, cl_manv).ToString().Trim();
                        lopDTO.MaPhg = dgview_lopHoc.GetRowCellValue(rowHandle, cl_maphg).ToString().Trim();
                        lopDTO.LichHoc = dgview_lopHoc.GetRowCellValue(rowHandle, cl_lichhoc).ToString().Trim();
                        lopDTO.GioBatDau = dgview_lopHoc.GetRowCellValue(rowHandle, cl_giobatdau).ToString().Trim();
                        lopDTO.GioKetThuc = dgview_lopHoc.GetRowCellValue(rowHandle, cl_gioketthuc).ToString().Trim();
                    }
                }
            }
            else
            {
                lopDTO = null;
            }
            BindingChiTiet();
        }
        private void btn_lamMoiLopHoc_Click(object sender, EventArgs e)
        {
            if (isClick)
            {
                isClick = false;
                string maTiepTheo = lopBUS.maLopTiepTheo();
                txt_maLop.Text = maTiepTheo;
                lke_makh.EditValue = string.Empty;
                txt_tenLop.Text = string.Empty;
                lke_maNhanVien.EditValue = string.Empty;
                lke_phongHoc.Text = string.Empty;
                cbo_lichHoc.Text = string.Empty;
                time_gioBatDau.EditValue = string.Empty;
                time_gioKetThuc.EditValue = string.Empty;
                btn_themLopHoc.Enabled = true;
                btn_suaLopHoc.Enabled = false;
                btn_xoaLopHoc.Enabled = false;
                dgcontrol_lopHoc.Enabled = false;
                btn_lamMoiLopHoc.Text = "Hủy";
                btn_lamMoiLopHoc.ImageOptions.Image = EnglishCenterManagement.Properties.Resources.close;
            }
            else
            {
                isClick = true;
                txt_maLop.Text = string.Empty;
                lke_makh.EditValue = string.Empty;
                txt_tenLop.Text = string.Empty;
                lke_maNhanVien.EditValue = string.Empty;
                lke_phongHoc.Text = string.Empty;
                cbo_lichHoc.Text = string.Empty;
                time_gioBatDau.EditValue = string.Empty;
                time_gioKetThuc.EditValue = string.Empty;
                btn_themLopHoc.Enabled = false;
                btn_suaLopHoc.Enabled = true;
                btn_xoaLopHoc.Enabled = true;
                dgcontrol_lopHoc.Enabled = true;
                btn_lamMoiLopHoc.Text = "Làm mới";
                btn_lamMoiLopHoc.ImageOptions.Image = EnglishCenterManagement.Properties.Resources.refresh;
            }
        }

        private void lke_makh_EditValueChanged(object sender, EventArgs e)
        {
            string soTiepTheo = lopBUS.soLopTiepTheo(lke_makh.Text.Trim());
            if(lke_makh.EditValue != null)
            {
                txt_tenLop.Text = lke_makh.GetColumnValue("TenKH") + "_" + soTiepTheo;
            }
        }

        private void GetDetail()
        {
            if (lopDTO != null)
            {
                lopDTO = new Lop_DTO();
            }
            lopDTO.MaLop = txt_maLop.Text.Trim();
            lopDTO.MaKhoaHoc = lke_makh.Text.Trim();
            lopDTO.TenLop = txt_tenLop.Text.Trim();
            lopDTO.MaNV = lke_maNhanVien.Text.Trim();
            lopDTO.MaPhg = lke_phongHoc.Text.Trim();
            lopDTO.LichHoc = cbo_lichHoc.Text.Trim();
            lopDTO.GioBatDau = time_gioBatDau.Text.Trim();
            lopDTO.GioKetThuc = time_gioKetThuc.Text.Trim();
        }
        private void btn_themLopHoc_Click(object sender, EventArgs e)
        {
            if (lke_makh.Text.Trim() == "" || lke_maNhanVien.Text.Trim() == "" || lke_phongHoc.Text.Trim() == "" ||
                cbo_lichHoc.Text.Trim() == "" || time_gioBatDau.Text.Trim() == "" || time_gioKetThuc.Text.Trim() == "")
            {
                XtraMessageBox.Show("Chưa điền đầy đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (lopDTO != null)
                {
                    GetDetail();

                    int kq = lopBUS.AddLop(lopDTO);
                    if (kq == 1)
                    {
                        XtraMessageBox.Show(string.Format("Thêm lớp học {0} thành công!", lopDTO.TenLop), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSLop();
                        btn_themLopHoc.Enabled = false;
                        btn_suaLopHoc.Enabled = true;
                        dgcontrol_lopHoc.Enabled = true;
                    }
                    else
                    {
                        XtraMessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_suaLopHoc_Click(object sender, EventArgs e)
        {
            if (lke_makh.Text.Trim() == "" || lke_maNhanVien.Text.Trim() == "" || lke_phongHoc.Text.Trim() == "" ||
                cbo_lichHoc.Text.Trim() == "" || time_gioBatDau.Text.Trim() == "" || time_gioKetThuc.Text.Trim() == "")
            {
                XtraMessageBox.Show("Chưa điền đầy đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (lopDTO != null)
                {
                    GetDetail();

                    int kq = lopBUS.UpdateLop(lopDTO);
                    if (kq == 1)
                    {
                        XtraMessageBox.Show(string.Format("Sửa lớp học {0} thành công!", lopDTO.TenLop), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSLop();
                        RefreshTextBox();
                    }
                    else
                    {
                        XtraMessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_xoaLopHoc_Click(object sender, EventArgs e)
        {
            if (dgview_lopHoc.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Chưa chọn đối tượng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa lớp này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == result)
                {
                    int[] selectedRows = dgview_lopHoc.GetSelectedRows();
                    foreach (int rowHandle in selectedRows)
                    {
                        if (rowHandle >= 0)
                        {
                            string malop = dgview_lopHoc.GetRowCellValue(rowHandle, cl_malop).ToString();
                            lopBUS.DeleteLop(malop);
                        }
                        LoadDSLop();
                    }
                    XtraMessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        void RefreshTextBox()
        {
            lopDTO.MaLop = string.Empty;
            lopDTO.MaKhoaHoc = string.Empty;
            lopDTO.TenLop = string.Empty;
            lopDTO.MaNV = string.Empty;
            lopDTO.MaPhg = string.Empty;
            lopDTO.LichHoc = string.Empty;
            lopDTO.GioBatDau = string.Empty;
            lopDTO.GioKetThuc = string.Empty;
        }
    }
}