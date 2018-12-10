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
        private ucQLTK ucQLTK;

        //public frmThemTaiKhoan()
        //{
        //    InitializeComponent();
        //}

        public frmThemTaiKhoan(ucQLTK ucQLTK)
        {
            InitializeComponent();
            this.ucQLTK = ucQLTK;
        }

        private void frmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadDSNVChuaCoTaiKhoan();
        }

        public void LoadDSNVChuaCoTaiKhoan()
        {
            lsNhanVien = new List<NhanVien_DTO>();
            lsNhanVien = nvBUS.danhsachNVChuaCoTaiKhoan();

            dgcontrol_chuaCoTK.DataSource = lsNhanVien;
        }

        private void dgcontrol_chuaCoTK_DoubleClick(object sender, EventArgs e)
        {
            subForm_TaoTK sf = new subForm_TaoTK(this);
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

        private void frmThemTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            ucQLTK.LoadTK();
        }
    }
}