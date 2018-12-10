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
    public partial class ucKhoiPhucTK : DevExpress.XtraEditors.XtraUserControl
    {
        List<TaiKhoan_DTO> lsTaiKhoan;

        TaiKhoan_BUS tkBUS = new TaiKhoan_BUS();
        TaiKhoan_DTO tkDTO = new TaiKhoan_DTO();
        public ucKhoiPhucTK()
        {
            InitializeComponent();
        }

        private void ucKhoiPhucTK_Load(object sender, EventArgs e)
        {
            LoadTKDaXoa();
        }
        public void LoadTKDaXoa()
        {
            lsTaiKhoan = new List<TaiKhoan_DTO>();
            lsTaiKhoan = tkBUS.danhsachTKDaXoa();

            dgcontrol_khoiPhucTK.DataSource = lsTaiKhoan;
        }

        private void btn_khoiPhucTK_Click(object sender, EventArgs e)
        {
            if (dgview_khoiPhucTK.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Chưa chọn đối tượng để khôi phục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = XtraMessageBox.Show("Bạn có muốn khôi phục tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == result)
                {
                    int[] selectedRows = dgview_khoiPhucTK.GetSelectedRows();
                    foreach (int rowHandle in selectedRows)
                    {
                        if (rowHandle >= 0)
                        {
                            string manv = dgview_khoiPhucTK.GetRowCellValue(rowHandle, cl_manv).ToString();
                            string tenDangNhap = dgview_khoiPhucTK.GetRowCellValue(rowHandle, cl_tenDangNhap).ToString();
                            tkBUS.UpdateNVChuaCoTK(manv);
                            tkBUS.RestoreTK(tenDangNhap);
                        }
                        LoadTKDaXoa();
                    }
                    XtraMessageBox.Show("Khôi phục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            LoadTKDaXoa();
        }
    }
}
