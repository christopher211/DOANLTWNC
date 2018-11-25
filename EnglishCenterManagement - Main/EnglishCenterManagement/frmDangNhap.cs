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
using DevExpress.XtraLayout;
using ECM_BUS;
using ECM_DTO;

namespace EnglishCenterManagement
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private bool mouseDown;
        private Point lastLocation;
        #region MoveFormWithoutBorder


        private void frmDangNhap_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmDangNhap_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmDangNhap_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        #endregion

        TaiKhoan_BUS user_BUS = new TaiKhoan_BUS();
        TaiKhoan_DTO user_DTO = new TaiKhoan_DTO();
        frmMain f = new frmMain();


        public frmDangNhap()
        {
            InitializeComponent();
            txt_matKhau.Properties.UseSystemPasswordChar = true;
            f.Show();      
        }

        private void chk_showHide_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_showHide.Checked)
            {
                txt_matKhau.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matKhau.Properties.UseSystemPasswordChar = true;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có muốn thoát không?", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            
            if (txt_tenDangNhap.Text == "" || txt_matKhau.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (user_BUS.AdminLogin(txt_tenDangNhap.Text, txt_matKhau.Text) == 1)
                {
                   
                    f.isAdminDangNhap = true;
                    XtraMessageBox.Show(this, "Đăng nhập thành công với quyền Administrator", "Thông báo");
                    this.WindowState = FormWindowState.Minimized;
                    f.Enabled = true;
                    f.BringToFront();        
                }
                else if(user_BUS.ModLogin(txt_tenDangNhap.Text , txt_matKhau.Text) == 1)
                {
                    
                    f.isModDangNhap = true;
                    XtraMessageBox.Show(this, "Đăng nhập thành công với quyền Moderator", "Thông báo");
                    this.WindowState = FormWindowState.Minimized;
                    f.Enabled = true;
                    f.BringToFront();
                }
                else if(user_BUS.UserLogin(txt_tenDangNhap.Text, txt_matKhau.Text) == 1)
                {
                    
                    f.isUserDangNhap = true;
                    XtraMessageBox.Show(this, "Đăng nhập thành công với quyền User", "Thông báo");
                    this.WindowState = FormWindowState.Minimized;
                    f.Enabled = true;
                    f.BringToFront();
                }
                else
                {                    
                    f.isAdminDangNhap = false;
                    f.isModDangNhap = false;
                    f.isUserDangNhap = false;
                    XtraMessageBox.Show(this, "Đăng nhập thất bại", "Thông báo");
                }
            }
        }
    }
}