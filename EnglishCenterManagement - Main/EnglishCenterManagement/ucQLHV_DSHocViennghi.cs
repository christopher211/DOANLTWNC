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
    public partial class ucQLHV_DSHocViennghi : DevExpress.XtraEditors.XtraUserControl
    {
        List<HocVien_DTO> lsHocVien;
        List<Lop_DTO> lsLop;
        List<KhoaHoc_DTO> lsKhoaHoc;

        HocVien_BUS hvBUS = new HocVien_BUS();
        HocVien_DTO hvDTO = new HocVien_DTO();
        public ucQLHV_DSHocViennghi()
        {
            InitializeComponent();
        }

        private void ucQLHV_DSHocViennghi_Load(object sender, EventArgs e)
        {
            LoadDSHVDaNghi();
        }
        public void LoadDSHVDaNghi()
        {
            lsHocVien = new List<HocVien_DTO>();
            lsHocVien = hvBUS.danhSachHVDaNghi();
            dgcontrol_hocVien.DataSource = lsHocVien;
        }

        private void btn_khoiPhucHV_Click(object sender, EventArgs e)
        {
            if (dgview_hocVien.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Chưa chọn đối tượng để khôi phục");
            }
            else
            {
                DialogResult result = XtraMessageBox.Show("Bạn có muốn khôi phục học viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == result)
                {
                    int[] selectedRows = dgview_hocVien.GetSelectedRows();
                    foreach (int rowHandle in selectedRows)
                    {
                        if (rowHandle >= 0)
                        {
                            string manv = dgview_hocVien.GetRowCellValue(rowHandle, cl_mshv).ToString();
                            hvBUS.RestoreHV(manv);
                        }
                        LoadDSHVDaNghi();
                    }
                    XtraMessageBox.Show("Khôi phục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_lamMoiHV_Click(object sender, EventArgs e)
        {
            LoadDSHVDaNghi();
        }
    }
}
