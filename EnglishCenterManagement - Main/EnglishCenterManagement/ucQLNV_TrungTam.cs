using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ECM_DTO;
using ECM_BUS;

namespace EnglishCenterManagement
{
    public partial class ucQLNV_TrungTam : DevExpress.XtraEditors.XtraUserControl
    {
        List<NhanVien_DTO> lsNhanVien;
        List<ChucVu_DTO> lsChucVu;

        NhanVien_BUS nvBUS = new NhanVien_BUS();
        NhanVien_DTO nvDTO = new NhanVien_DTO();

        ChucVu_BUS cvBUS = new ChucVu_BUS();
        ChucVu_DTO cvDTO = new ChucVu_DTO();

        public ucQLNV_TrungTam()
        {
            InitializeComponent();           
        }
        private void ucQLNV_TrungTam_Load(object sender, EventArgs e)
        {
            LoadDSNV_TT();
            LoadDSCV();
        }
        private void LoadDSNV_TT()
        {
            List<NhanVien_DTO> lsNhanVien = new List<NhanVien_DTO>();
            lsNhanVien = nvBUS.danhsachNV();
            dgcontrol_nhanVien.DataSource = lsNhanVien;
        }
        private void LoadDSCV()
        {
            lsChucVu = new List<ChucVu_DTO>();
            lsChucVu = cvBUS.DanhSachCV();           

            lke_timNhanVienChucVu.Properties.DataSource = lsChucVu;
            lke_timNhanVienChucVu.Properties.DisplayMember = "MaCV";
            lke_timNhanVienChucVu.Properties.ValueMember = "MaCV";

            lke_timNhanVienChucVu.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaCV", "Mã Chức Vụ", 10));
            lke_timNhanVienChucVu.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenCV", "Tên Chức Vụ", 20));
        }
        private void LoadDSNVTheoMaNV()
        {
            lsNhanVien = new List<NhanVien_DTO>();
            lsNhanVien = nvBUS.danhsachNVTheoMaNV(txt_timNhanVienMaNV.Text);
            dgcontrol_nhanVien.DataSource = lsNhanVien;
        }
        private void LoadDSNVTheoHoTen()
        {
            lsNhanVien = new List<NhanVien_DTO>();
            lsNhanVien = nvBUS.danhsachNVTheoHoTen(txt_timNhanVienHoTen.Text);
            dgcontrol_nhanVien.DataSource = lsNhanVien;
        }
        private void LoadDSNVTheoSDT()
        {
            lsNhanVien = new List<NhanVien_DTO>();
            lsNhanVien = nvBUS.danhsachNVTheoSDT(txt_timNhanVienSDT.Text);
            dgcontrol_nhanVien.DataSource = lsNhanVien;
        }
        private void LoadDSNVTheoChucVu()
        {
            lsNhanVien = new List<NhanVien_DTO>();
            lsNhanVien = nvBUS.danhsachNVTheoChucVu(lke_timNhanVienChucVu.Text);
            dgcontrol_nhanVien.DataSource = lsNhanVien;
        }
        private void btn_xoaNhanVien_Click(object sender, EventArgs e)
        {
            if (dgview_nhanVien.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Chưa chọn đối tượng để xóa");
            }
            else
            {
                DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == result)
                {
                    int[] selectedRows = dgview_nhanVien.GetSelectedRows();
                    foreach (int rowHandle in selectedRows)
                    {
                        if (rowHandle >= 0)
                        {
                            string manv = dgview_nhanVien.GetRowCellValue(rowHandle, cl_manv).ToString();
                            nvBUS.DeleteNV(manv);
                        }
                        LoadDSNV_TT();
                    }
                    XtraMessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dgview_nhanVien.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Chưa chọn đối tượng để sửa", "Thông báo");
            }
            else
            {
                frmSuaNhanVien f = new frmSuaNhanVien();
                int[] selectedRows = dgview_nhanVien.GetSelectedRows();
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                    {

                        f.txt_manv.Text = this.dgview_nhanVien.GetRowCellValue(rowHandle, cl_manv).ToString().Trim();
                        f.txt_ho.Text = this.dgview_nhanVien.GetRowCellValue(rowHandle, cl_ho).ToString();
                        f.txt_ten.Text = this.dgview_nhanVien.GetRowCellValue(rowHandle, cl_ten).ToString();
                        f.cbo_gioiTinh.Text = this.dgview_nhanVien.GetRowCellValue(rowHandle, cl_gioiTinh).ToString();
                        f.dt_ngaySinh.EditValue = this.dgview_nhanVien.GetRowCellValue(rowHandle, cl_ngaySinh).ToString();
                        f.dt_ngayLamViec.EditValue = this.dgview_nhanVien.GetRowCellValue(rowHandle, cl_ngayLamViec).ToString();
                        f.txt_sdt.Text = this.dgview_nhanVien.GetRowCellValue(rowHandle, cl_sdt).ToString();
                        f.txt_email.Text = this.dgview_nhanVien.GetRowCellValue(rowHandle, cl_email).ToString();
                        f.txt_diaChi.Text = this.dgview_nhanVien.GetRowCellValue(rowHandle, cl_diaChi).ToString();
                        f.lke_chucVu.EditValue = this.dgview_nhanVien.GetRowCellDisplayText(rowHandle, cl_chucVu).ToString();
                    }
                }
                f.ShowDialog();
            }
        }
        private void btn_themGiaoVien_Click(object sender, EventArgs e)
        {
            frmThemNhanVien f = new frmThemNhanVien();
            f.ShowDialog();
        }

        private void btn_lamMoiNhanVien_Click(object sender, EventArgs e)
        {
            LoadDSNV_TT();
        }

        private void btn_timNhanVienMaNV_Click(object sender, EventArgs e)
        {           
                LoadDSNVTheoMaNV();
        }

        private void btn_timNhanVienHoTen_Click(object sender, EventArgs e)
        {
            LoadDSNVTheoHoTen();
        }

        private void btn_timNhanVienChucVu_Click(object sender, EventArgs e)
        {
            LoadDSNVTheoChucVu();
        }

        private void btn_timNhanVienSDT_Click(object sender, EventArgs e)
        {
            LoadDSNVTheoSDT();
        }        
    }
}
