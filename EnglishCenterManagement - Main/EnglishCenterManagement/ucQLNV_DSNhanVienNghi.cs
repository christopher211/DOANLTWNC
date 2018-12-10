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
    public partial class ucQLNV_DSNhanVienNghi : DevExpress.XtraEditors.XtraUserControl
    {
        NhanVien_BUS nvBUS = new NhanVien_BUS();
        NhanVien_DTO nvDTO = new NhanVien_DTO();
        public ucQLNV_DSNhanVienNghi()
        {
            InitializeComponent();
        }

        private void ucQLNV_DSNhanVienNghi_Load(object sender, EventArgs e)
        {
            LoadDSNVDaNghi();
        }

        public void LoadDSNVDaNghi()
        {
            List<NhanVien_DTO> lsGiaoVien = new List<NhanVien_DTO>();
            lsGiaoVien = nvBUS.danhsachGVDaNghi();
            dgcontrol_nvNghi.DataSource = lsGiaoVien;
        }
        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            LoadDSNVDaNghi();
        }

        private void btn_khoiPhuc_Click(object sender, EventArgs e)
        {
            if (dgview_nvNghi.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Chưa chọn đối tượng để khôi phục");
            }
            else
            {
                DialogResult result = XtraMessageBox.Show("Bạn có muốn khôi phục nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == result)
                {
                    int[] selectedRows = dgview_nvNghi.GetSelectedRows();
                    foreach (int rowHandle in selectedRows)
                    {
                        if (rowHandle >= 0)
                        {
                            string manv = dgview_nvNghi.GetRowCellValue(rowHandle, cl_manv).ToString();
                            nvBUS.RestoreNV(manv);
                        }
                        LoadDSNVDaNghi();
                    }
                    XtraMessageBox.Show("Khôi phục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
