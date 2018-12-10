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
using ECM_BUS;
using ECM_DTO;

namespace EnglishCenterManagement
{
    public partial class ucQLNV_GiaoVien : DevExpress.XtraEditors.XtraUserControl
    {
        //List<NhanVien_DTO> lsGiaoVien;       

        NhanVien_BUS gvBUS = new NhanVien_BUS();
        NhanVien_DTO gvDTO = new NhanVien_DTO();
       
        public ucQLNV_GiaoVien()
        {
            InitializeComponent();
        }
        private void ucQLNV_GiaoVien_Load(object sender, EventArgs e)
        {
            LoadDSNV_GV();
        }
        public void LoadDSNV_GV()
        {
            List<NhanVien_DTO> lsGiaoVien = new List<NhanVien_DTO>();
            lsGiaoVien = gvBUS.danhsachGV();
            dgcontrol_giaoVien.DataSource = lsGiaoVien;
        }
        
        private void btn_themGiaoVien_Click(object sender, EventArgs e)
        {
            frmThemGiaoVien f = new frmThemGiaoVien(this);
            f.ShowDialog();
        }
        private void btn_xoaGiaoVien_Click(object sender, EventArgs e)
        {
            if (dgview_giaoVien.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Chưa chọn đối tượng để xóa", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa giáo viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == result)
                {
                    int[] selectedRows = dgview_giaoVien.GetSelectedRows();
                    foreach (int rowHandle in selectedRows)
                    {
                        if (rowHandle >= 0)
                        {
                            string manv = dgview_giaoVien.GetRowCellValue(rowHandle, cl_manv).ToString();
                            gvBUS.DeleteGV(manv);
                        }
                        LoadDSNV_GV();
                    }
                    XtraMessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            LoadDSNV_GV();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dgview_giaoVien.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Chưa chọn đối tượng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmSuaGiaoVien f = new frmSuaGiaoVien(this);
                int[] selectedRows = dgview_giaoVien.GetSelectedRows();
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                    {

                        f.txt_manv.Text = this.dgview_giaoVien.GetRowCellValue(rowHandle, cl_manv).ToString().Trim();
                        f.txt_ho.Text = this.dgview_giaoVien.GetRowCellValue(rowHandle, cl_ho).ToString();
                        f.txt_ten.Text = this.dgview_giaoVien.GetRowCellValue(rowHandle, cl_ten).ToString();
                        f.cbo_gioiTinh.Text = this.dgview_giaoVien.GetRowCellValue(rowHandle, cl_gioiTinh).ToString();
                        f.dt_ngaySinh.EditValue = this.dgview_giaoVien.GetRowCellValue(rowHandle, cl_ngaySinh).ToString();
                        f.dt_ngayLamViec.EditValue = this.dgview_giaoVien.GetRowCellValue(rowHandle, cl_ngayLamViec).ToString();
                        f.txt_sdt.Text = this.dgview_giaoVien.GetRowCellValue(rowHandle, cl_sdt).ToString();
                        f.txt_email.Text = this.dgview_giaoVien.GetRowCellValue(rowHandle, cl_email).ToString();
                        f.txt_diaChi.Text = this.dgview_giaoVien.GetRowCellValue(rowHandle, cl_diaChi).ToString();                       
                    }
                }
                f.ShowDialog();
            }
        }
    }
}
