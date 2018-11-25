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

        #region textBoxEvent
        private void txt_timNVMaNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_timNVMaNV_Click(this, new EventArgs());
            }
        }

        private void txt_timNVHoTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_timNVHoTen_Click(this, new EventArgs());
            }
        }

        private void txt_timNVSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_timNVSDT_Click(this, new EventArgs());
            }
        }

        private void txt_timNVSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                //&& (e.KeyChar != '.' || (e.KeyChar == '.' &&
                //        (txt_sdt.Text.Length == 0 || txt_sdt.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }

        #endregion
        public void LoadDSNVDaNghi()
        {
            List<NhanVien_DTO> lsGiaoVien = new List<NhanVien_DTO>();
            lsGiaoVien = nvBUS.danhsachGVDaNghi();
            dgcontrol_nvNghi.DataSource = lsGiaoVien;
        }
        public void LoadDSGVDaNghiTheoMaNV()
        {
            List<NhanVien_DTO> lsGiaoVien = new List<NhanVien_DTO>();
            lsGiaoVien = nvBUS.danhsachNVDaNghiTheoMaNV(txt_timNVMaNV.Text);
            dgcontrol_nvNghi.DataSource = lsGiaoVien;
        }
        public void LoadDSGVDaNghiTheoHoTen()
        {
            List<NhanVien_DTO> lsGiaoVien = new List<NhanVien_DTO>();
            lsGiaoVien = nvBUS.danhsachNVDaNghiTheoHoTen(txt_timNVHoTen.Text);
            dgcontrol_nvNghi.DataSource = lsGiaoVien;
        }
        public void LoadDSGVTheoSDT()
        {
            List<NhanVien_DTO> lsGiaoVien = new List<NhanVien_DTO>();
            lsGiaoVien = nvBUS.danhsachNVDaNghiTheoSDT(txt_timNVSDT.Text);
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

        private void btn_timNVMaNV_Click(object sender, EventArgs e)
        {
            LoadDSGVDaNghiTheoMaNV();
        }

        private void btn_timNVHoTen_Click(object sender, EventArgs e)
        {
            LoadDSGVDaNghiTheoHoTen();
        }

        private void btn_timNVSDT_Click(object sender, EventArgs e)
        {
            LoadDSGVTheoSDT();
        }
    }
}
