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
    public partial class frmQuanLyHocVien : DevExpress.XtraEditors.XtraForm
    {
        private ucQLHV_DanhSach ucQLHV_DS;
        private ucQLHV_Diem ucQLHV_D;        
        private ucQLHV_DSHocViennghi ucQLHV_Nghi;

        public frmQuanLyHocVien()
        {
            InitializeComponent();
            UnitForm();
        }
        #region SwitchPanel

        void UnitForm()
        {
            ucQLHV_DS = new ucQLHV_DanhSach();
            ucQLHV_DS.Dock = DockStyle.Fill;

            ucQLHV_D = new ucQLHV_Diem();
            ucQLHV_D.Dock = DockStyle.Fill;            

            ucQLHV_Nghi = new ucQLHV_DSHocViennghi();
            ucQLHV_Nghi.Dock = DockStyle.Fill;

            //ShowForm(ucQLHV_DS);
        }
        void ShowForm(DevExpress.XtraEditors.XtraUserControl uControl)
        {
            if (splitCC_quanLyHocVien.Panel2.Controls.Count > 0)
            {
                splitCC_quanLyHocVien.Panel2.Controls.RemoveAt(0);
            }
            uControl.Bounds = splitCC_quanLyHocVien.Panel2.DisplayRectangle;
            splitCC_quanLyHocVien.Panel2.Controls.Add(uControl);
        }

        private void btn_dshv_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Loading.ShowLoading();
            ShowForm(ucQLHV_DS);
            ucQLHV_DS.LoadDSHV();
            Loading.HideLoading();
        }

        private void btn_diem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Loading.ShowLoading();
            ShowForm(ucQLHV_D);
            Loading.HideLoading();
        }        

        private void btn_dshvNghi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Loading.ShowLoading();
            ShowForm(ucQLHV_Nghi);
            ucQLHV_Nghi.LoadDSHVDaNghi();
            Loading.HideLoading();
        }


        #endregion
    }
}