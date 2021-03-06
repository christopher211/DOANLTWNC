﻿using System;
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
    public partial class subFormDoiMatKhau_2 : DevExpress.XtraEditors.XtraForm
    {
        private bool mouseDown;
        private Point lastLocation;
        #region MoveFormWithoutBorder

        private void subFormDoiMatKhau_2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void subFormDoiMatKhau_2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void subFormDoiMatKhau_2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion

        TaiKhoan_BUS tkBUS = new TaiKhoan_BUS();
        TaiKhoan_DTO tkDTO = new TaiKhoan_DTO();

        public subFormDoiMatKhau_2()
        {
            InitializeComponent();
        }

        private void btn_luuTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txt_matKhauCu.Text.Trim() == "" || txt_matKhauMoi.Text.Trim() == "" || txt_nhapLaiMKMoi.Text.Trim() == "")

            {
                XtraMessageBox.Show("Chưa điền đầy đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (tkBUS.CheckPassword(txt_tenDangNhap.Text, txt_matKhauCu.Text) != 1)
                {
                    XtraMessageBox.Show("Mật khẩu cũ không khớp!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txt_matKhauMoi.Text.Trim() != txt_nhapLaiMKMoi.Text.Trim())
                    {
                        XtraMessageBox.Show("Mật khẩu mới không khớp!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (txt_matKhauMoi.Text == txt_matKhauCu.Text)
                        {
                            XtraMessageBox.Show("Mật khẩu mới không không được trùng với mật khẩu cũ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (tkDTO != null)
                            {
                                GetDetail();

                                int kq = tkBUS.ChangePassword(tkDTO);
                                if (kq == 1)
                                {
                                    XtraMessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    XtraMessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
            }
        }
        private void GetDetail()
        {
            if (tkDTO != null)
            {
                tkDTO = new TaiKhoan_DTO();
            }
            tkDTO.TenDangNhap = txt_tenDangNhap.Text;
            tkDTO.MatKhau = txt_matKhauMoi.Text;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chk_showHide_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_showHide.Checked == true)
            {
                txt_matKhauMoi.Properties.UseSystemPasswordChar = false;
                txt_nhapLaiMKMoi.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matKhauMoi.Properties.UseSystemPasswordChar = true;
                txt_nhapLaiMKMoi.Properties.UseSystemPasswordChar = true;
            }
        }

        
    }
}