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
    public partial class ucQLTK : DevExpress.XtraEditors.XtraUserControl
    {
        List<TaiKhoan_DTO> lsTaiKhoan;

        TaiKhoan_BUS tkBUS = new TaiKhoan_BUS();
        TaiKhoan_DTO tkDTO = new TaiKhoan_DTO();

        public ucQLTK()
        {
            InitializeComponent();
        }
        private void ucQLTK_Load(object sender, EventArgs e)
        {
            LoadTK();
        }
        private void LoadTK()
        {
            lsTaiKhoan = new List<TaiKhoan_DTO>();
            lsTaiKhoan = tkBUS.danhsachTK();

            dgcontrol_taiKhoan.DataSource = lsTaiKhoan;
        }
        private void btn_themTaiKhoan_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan f = new frmThemTaiKhoan();
            f.ShowDialog();
        }

        private void btn_doiMatKhau_Click(object sender, EventArgs e)
        {
            if (dgview_taiKhoan.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Chưa chọn đối tượng để sửa", "Thông báo");
            }
            else
            {
                frmDoiMatKhau f = new frmDoiMatKhau();
                int[] selectedRows = dgview_taiKhoan.GetSelectedRows();
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                    {
                        f.txt_tenDangNhap.Text = this.dgview_taiKhoan.GetRowCellValue(rowHandle, cl_tenDangNhap).ToString().Trim();
                    }
                }
                f.ShowDialog();
            }
        }

        private void btn_xoaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (dgview_taiKhoan.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Chưa chọn đối tượng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {                
                DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == result)
                {
                    int[] selectedRows = dgview_taiKhoan.GetSelectedRows();
                    foreach (int rowHandle in selectedRows)
                    {
                        if (rowHandle >= 0)
                        {
                            if(this.dgview_taiKhoan.GetRowCellValue(rowHandle, cl_loaiTK).ToString().Trim() == "CV01")
                            {
                                XtraMessageBox.Show("Không thể xóa tài khoản này!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                string manv = this.dgview_taiKhoan.GetRowCellValue(rowHandle, cl_manv).ToString().Trim();
                                string tenDangNhap = this.dgview_taiKhoan.GetRowCellValue(rowHandle, cl_tenDangNhap).ToString().Trim();
                                tkBUS.DeleteNVDaCoTK(manv);
                                tkBUS.DeleteTK(tenDangNhap);
                                XtraMessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                            }                           
                        }
                        LoadTK();
                    }                   
                }
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            LoadTK();
        }
    }
}
