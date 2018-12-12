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
    public partial class subFormQuenMatKhau : DevExpress.XtraEditors.XtraForm
    {
        private bool mouseDown;
        private Point lastLocation;
        #region MoveFormWithoutBorder

        private void subFormQuenMatKhau_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void subFormQuenMatKhau_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void subFormQuenMatKhau_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion

        TaiKhoan_BUS tkBUS = new TaiKhoan_BUS();
        TaiKhoan_DTO tkDTO = new TaiKhoan_DTO();
        public subFormQuenMatKhau()
        {
            InitializeComponent();
        }

        private void subFormQuenMatKhau_Load(object sender, EventArgs e)
        {
            lb_nhapMKM.Visible = false;
            txt_matKhauMoi.Visible = false;
        }

        private void btn_resetMatKhau_Click(object sender, EventArgs e)
        {
            if (txt_tenDangNhap.Text.Trim() == "")
            {
                XtraMessageBox.Show("Chưa nhập tên đăng nhập!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(tkBUS.CheckUsername(txt_tenDangNhap.Text.Trim()) != 1)
                {
                    XtraMessageBox.Show("Tên đăng nhập không tồn tại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (tkDTO != null)
                    {
                        int kq = tkBUS.ResetPassword(txt_tenDangNhap.Text.Trim());
                        if (kq == 1)
                        {
                            XtraMessageBox.Show("Reset mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lb_nhapMKM.Visible = true;
                            txt_matKhauMoi.Visible = true;
                            txt_tenDangNhap.ReadOnly = true;
                            btn_resetMatKhau.SendToBack();
                        }
                        else
                        {
                            XtraMessageBox.Show("Reset mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }             
            }
        }

        private void btn_luuMatKhau_Click(object sender, EventArgs e)
        {
            if (txt_matKhauMoi.Text.Trim() == "")
            {
                XtraMessageBox.Show("Chưa nhập mật khẩu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (tkDTO != null)
                {
                    tkDTO.TenDangNhap = txt_tenDangNhap.Text.Trim();
                    tkDTO.MatKhau = txt_matKhauMoi.Text.Trim();
                    int kq = tkBUS.ChangePassword(tkDTO);
                    if (kq == 1)
                    {
                        XtraMessageBox.Show("Lưu mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Lưu mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}