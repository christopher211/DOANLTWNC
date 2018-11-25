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
    public partial class frmQuanLyNhanVien : DevExpress.XtraEditors.XtraForm
    {      
        private ucQLNV_TrungTam ucQLNV;
        private ucQLNV_GiaoVien ucQLGV;
        private ucQLNV_DSNhanVienNghi ucQLNVNghi;

        NhanVien_BUS nvBUS = new NhanVien_BUS();
        NhanVien_DTO nvDTO = new NhanVien_DTO();
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            UnitForm();
        }
        #region SwitchPanel
        void UnitForm()
        {
            ucQLNV = new ucQLNV_TrungTam();
            ucQLNV.Dock = DockStyle.Fill;

            ucQLGV = new ucQLNV_GiaoVien();
            ucQLGV.Dock = DockStyle.Fill;

            ucQLNVNghi = new ucQLNV_DSNhanVienNghi();
            ucQLNVNghi.Dock = DockStyle.Fill;

        }
        void ShowForm(DevExpress.XtraEditors.XtraUserControl uControl)
        {
            if (splitCC_quanLyNhanVien.Panel2.Controls.Count > 0)
            {
                splitCC_quanLyNhanVien.Panel2.Controls.RemoveAt(0);
            }
            uControl.Bounds = splitCC_quanLyNhanVien.Panel2.DisplayRectangle;            
            splitCC_quanLyNhanVien.Panel2.Controls.Add(uControl);
        }
        
        private void btn_qlnv_tt_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowForm(ucQLNV);           
        }

        private void btn_qlnv_gv_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowForm(ucQLGV);           
        }

        private void btn_qlnv_nghi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowForm(ucQLNVNghi);           
        }

        #endregion

        
    }
}