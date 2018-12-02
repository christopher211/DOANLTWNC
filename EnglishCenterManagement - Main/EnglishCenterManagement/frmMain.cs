using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace EnglishCenterManagement
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public bool isAdminDangNhap;
        public bool isModDangNhap;
        public bool isUserDangNhap;      

        #region DisableFormCloseButton

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        #endregion

        public frmMain()
        {
            InitializeComponent();
            this.Enabled = false;                         
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
           
        }
        public Form CheckExist(Type fType)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == fType)
                {
                    return frm;
                }
            }
            return null;
        }
        private void CloseAllForm()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }
        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseAllForm();
        }
        private void btn_thoatChuongTrinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isAdminDangNhap = false;
            isModDangNhap = false;
            isUserDangNhap = false;
            DialogResult result = XtraMessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
        private void btn_dangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có muốn đăng xuất chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                isAdminDangNhap = false;
                isModDangNhap = false;
                isUserDangNhap = false;
                this.Close();
                frmDangNhap f = new frmDangNhap();
                f.Show();
            }      
        }
        private void btn_quanLyHocVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(isAdminDangNhap || isModDangNhap)
            {
                Loading.ShowLoading();
                Form frm = this.CheckExist(typeof(frmQuanLyHocVien));
                if (frm != null)
                {
                    frm.Activate();
                }
                else
                {
                    frmQuanLyHocVien frmQLHocVien = new frmQuanLyHocVien();
                    frmQLHocVien.MdiParent = this;
                    frmQLHocVien.Dock = DockStyle.Fill;
                    frmQLHocVien.Show();
                }
                Loading.HideLoading();
            }
            else
            {
                XtraMessageBox.Show("Không đủ quyền để truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_quanLyNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(isAdminDangNhap)
            {
                Loading.ShowLoading();
                Form frm = this.CheckExist(typeof(frmQuanLyNhanVien));
                if (frm != null)
                {
                    frm.Activate();
                }
                else
                {
                    frmQuanLyNhanVien frmQLNhanVien = new frmQuanLyNhanVien();
                    frmQLNhanVien.MdiParent = this;
                    frmQLNhanVien.Dock = DockStyle.Fill;
                    frmQLNhanVien.Show();
                }
                Loading.HideLoading();
            }
            else
            {
                XtraMessageBox.Show("Không đủ quyền để truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_quanLyKhoaHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Loading.ShowLoading();
            if (isModDangNhap || isAdminDangNhap)
            {
                Form frm = this.CheckExist(typeof(frmQuanLyKhoaHoc));
                if (frm != null)
                {
                    frm.Activate();
                }
                else
                {
                    frmQuanLyKhoaHoc f = new frmQuanLyKhoaHoc();
                    f.MdiParent = this;
                    f.Dock = DockStyle.Fill;
                    f.Show();
                }
                Loading.HideLoading();
            }
            else
            {
                XtraMessageBox.Show("Không đủ quyền để truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void btn_quanLyTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            if (isAdminDangNhap)
            {
                Loading.ShowLoading();
                Form frm = this.CheckExist(typeof(frmQuanLyTaiKhoan));
                if (frm != null)
                {
                    frm.Activate();
                }
                else
                {
                    frmQuanLyTaiKhoan f = new frmQuanLyTaiKhoan();
                    f.MdiParent = this;
                    f.Dock = DockStyle.Fill;
                    f.Show();
                }
                Loading.HideLoading();
            }
            else
            {
                XtraMessageBox.Show("Không đủ quyền để truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_quanLyLopHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAdminDangNhap || isUserDangNhap || isModDangNhap)
            {
                Loading.ShowLoading();
                Form frm = this.CheckExist(typeof(frmQuanLyLopHoc));
                if (frm != null)
                {
                    frm.Activate();
                }
                else
                {
                    frmQuanLyLopHoc f = new frmQuanLyLopHoc();
                    f.MdiParent = this;
                    f.Dock = DockStyle.Fill;
                    f.Show();
                }
                Loading.HideLoading();
            }
            else
            {
                XtraMessageBox.Show("Không đủ quyền để truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_lich_tkb_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAdminDangNhap || isModDangNhap)
            {
                Loading.ShowLoading();
                Form frm = this.CheckExist(typeof(frmQuanLyTGB));
                if (frm != null)
                {
                    frm.Activate();
                }
                else
                {
                    frmQuanLyTGB f = new frmQuanLyTGB();
                    f.MdiParent = this;
                    f.Dock = DockStyle.Fill;
                    f.Show();
                }
                Loading.HideLoading();
            }
            else
            {
                XtraMessageBox.Show("Không đủ quyền để truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_bienLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_help_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHelp f = new frmHelp();
            f.ShowDialog();
        }
    }
}
