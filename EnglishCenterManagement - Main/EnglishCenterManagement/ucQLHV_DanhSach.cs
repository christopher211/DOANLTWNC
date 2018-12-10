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
using DevExpress.XtraGrid.Views.Grid;

namespace EnglishCenterManagement
{
    public partial class ucQLHV_DanhSach : DevExpress.XtraEditors.XtraUserControl
    {
        List<KhoaHoc_DTO> lsKhoaHoc;
        List<Lop_DTO> lsLop;
        //List<HocVien_DTO> lsHocVienCopy = new List<HocVien_DTO>();

        HocVien_BUS hvBUS = new HocVien_BUS();
        HocVien_DTO hvDTO = new HocVien_DTO();

        KhoaHoc_BUS khBUS = new KhoaHoc_BUS();
        KhoaHoc_DTO khDTO = new KhoaHoc_DTO();

        Lop_BUS lopBUS = new Lop_BUS();
        Lop_DTO lopDTO = new Lop_DTO();

        public ucQLHV_DanhSach()
        {
            InitializeComponent();           
        }
        private void ucQLHV_DanhSach_Load(object sender, EventArgs e)
        {
            LoadDSHV();
        }
        private void dgcontrol_hocVien_Load(object sender, EventArgs e)
        {
            dgview_hocVien.ClearSelection();
        }
        public void LoadDSHV()
        {
            List<HocVien_DTO> lsHocVien = new List<HocVien_DTO>();
            lsHocVien = hvBUS.danhSachHV();
            dgcontrol_hocVien.DataSource = lsHocVien;
        }
        private void btn_themHocVien_Click(object sender, EventArgs e)
        {
            frmThemHocVien f = new frmThemHocVien(this);
            f.ShowDialog();
        }
        private void btn_themKhoaHoc_Click(object sender, EventArgs e)
        {
            if (dgview_hocVien.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Chưa chọn đối tượng để thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmThemKhoaHocChoHocVien f = new frmThemKhoaHocChoHocVien(this);
                int[] selectedRows = dgview_hocVien.GetSelectedRows();
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                    {

                        f.txt_mshv.Text = this.dgview_hocVien.GetRowCellValue(rowHandle, cl_mshv).ToString().Trim();
                        f.txt_ho.Text = this.dgview_hocVien.GetRowCellValue(rowHandle, cl_ho).ToString();
                        f.txt_ten.Text = this.dgview_hocVien.GetRowCellValue(rowHandle, cl_ten).ToString();
                        f.cbo_gioiTinh.Text = this.dgview_hocVien.GetRowCellValue(rowHandle, cl_gioiTinh).ToString();
                        f.dt_ngaySinh.EditValue = this.dgview_hocVien.GetRowCellValue(rowHandle, cl_ngaySinh).ToString();
                        f.txt_sdt.Text = this.dgview_hocVien.GetRowCellValue(rowHandle, cl_sdt).ToString();
                        f.txt_email.Text = this.dgview_hocVien.GetRowCellValue(rowHandle, cl_email).ToString();
                        f.txt_diaChi.Text = this.dgview_hocVien.GetRowCellValue(rowHandle, cl_diaChi).ToString();
                        f.lke_khoaHoc.EditValue = this.dgview_hocVien.GetRowCellDisplayText(rowHandle, cl_makh).ToString();
                        f.lke_lopHoc.EditValue = this.dgview_hocVien.GetRowCellDisplayText(rowHandle, cl_maLop).ToString();
                    }
                }
                f.ShowDialog();
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(dgview_hocVien.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Chưa chọn đối tượng để sửa", "Thông báo");
            }
            else
            {
                frmSuaHocVien f = new frmSuaHocVien(this);
                int[] selectedRows = dgview_hocVien.GetSelectedRows();                
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                    {
                        f.txt_mshv.Text = this.dgview_hocVien.GetRowCellValue(rowHandle, cl_mshv).ToString().Trim();
                        f.txt_ho.Text = this.dgview_hocVien.GetRowCellValue(rowHandle, cl_ho).ToString();
                        f.txt_ten.Text = this.dgview_hocVien.GetRowCellValue(rowHandle, cl_ten).ToString();
                        f.cbo_gioiTinh.Text = this.dgview_hocVien.GetRowCellValue(rowHandle, cl_gioiTinh).ToString();
                        f.dt_ngaySinh.EditValue = this.dgview_hocVien.GetRowCellValue(rowHandle, cl_ngaySinh).ToString();
                        f.txt_sdt.Text = this.dgview_hocVien.GetRowCellValue(rowHandle, cl_sdt).ToString();
                        f.txt_email.Text = this.dgview_hocVien.GetRowCellValue(rowHandle, cl_email).ToString();
                        f.txt_diaChi.Text = this.dgview_hocVien.GetRowCellValue(rowHandle, cl_diaChi).ToString();                        
                        f.lke_khoaHoc.EditValue = this.dgview_hocVien.GetRowCellDisplayText(rowHandle, cl_makh).ToString();
                        f.lke_lopHoc.EditValue = this.dgview_hocVien.GetRowCellDisplayText(rowHandle, cl_maLop).ToString();
                    }                    
                }                
                f.ShowDialog();
            }
        }
        private void btn_xoaHocVien_Click(object sender, EventArgs e)
        {
            if(dgview_hocVien.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Chưa chọn đối tượng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa học viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(DialogResult.Yes == result)
                {
                    int[] selectedRows = dgview_hocVien.GetSelectedRows();
                    foreach (int rowHandle in selectedRows)
                    {
                        if (rowHandle >= 0)
                        {
                            string mshv = this.dgview_hocVien.GetRowCellValue(rowHandle, cl_mshv).ToString().Trim();
                            string makh = this.dgview_hocVien.GetRowCellDisplayText(rowHandle, cl_makh).ToString().Trim();
                            hvBUS.DeleteHV(mshv, makh);
                        }
                        LoadDSHV();
                    }
                    XtraMessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                }               
            }
        }
        private void btn_lamMoiHocVien_Click(object sender, EventArgs e)
        {
            LoadDSHV();
        }        
    }
}
