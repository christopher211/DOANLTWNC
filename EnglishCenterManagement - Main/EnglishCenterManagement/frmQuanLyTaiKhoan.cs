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
    public partial class frmQuanLyTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        private ucQLTK ucTK;
        private ucKhoiPhucTK ucKPTK;

        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
            UnitForm();
        }

        #region SwitchPanel

        void UnitForm()
        {
            ucTK = new ucQLTK();
            ucTK.Dock = DockStyle.Fill;

            ucKPTK = new ucKhoiPhucTK();
            ucKPTK.Dock = DockStyle.Fill;
            
            //ShowForm(ucQLHV_DS);
        }
        void ShowForm(DevExpress.XtraEditors.XtraUserControl uControl)
        {
            if (splitCC_quanLyTaiKhoan.Panel2.Controls.Count > 0)
            {
                splitCC_quanLyTaiKhoan.Panel2.Controls.RemoveAt(0);
            }
            uControl.Bounds = splitCC_quanLyTaiKhoan.Panel2.DisplayRectangle;
            splitCC_quanLyTaiKhoan.Panel2.Controls.Add(uControl);
        }
        private void btn_qlTaiKhoan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Loading.ShowLoading();
            ShowForm(ucTK);
            Loading.HideLoading();
        }
        private void btn_khoiPhucTK_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Loading.ShowLoading();
            ShowForm(ucKPTK);
            Loading.HideLoading();
        }

        #endregion
    }
}