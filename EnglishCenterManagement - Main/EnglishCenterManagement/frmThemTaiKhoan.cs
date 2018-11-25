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
    public partial class frmThemTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        List<NhanVien_DTO> lsNhanVien;

        NhanVien_BUS nvBUS = new NhanVien_BUS();
        NhanVien_DTO nvDTO = new NhanVien_DTO();
        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadDSNVChuaCoTaiKhoan();
        }

        private void LoadDSNVChuaCoTaiKhoan()
        {
            lsNhanVien = new List<NhanVien_DTO>();
            lsNhanVien = nvBUS.danhsachNVChuaCoTaiKhoan();

            dgcontrol_chuaCoTK.DataSource = lsNhanVien;
        }

        private void dgcontrol_chuaCoTK_DoubleClick(object sender, EventArgs e)
        {
            subForm_TaoTK sf = new subForm_TaoTK();
            int[] selectedRows = dgview_chuaCoTK.GetSelectedRows();
            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                {
                    sf.txt_manv.Text = dgview_chuaCoTK.GetRowCellValue(rowHandle, cl_manv).ToString();
                }               
            }
            sf.ShowDialog();
        }
    }
}