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
    public partial class subForm_TaoTK : DevExpress.XtraEditors.XtraForm
    {       
        TaiKhoan_BUS tkBUS = new TaiKhoan_BUS();
        TaiKhoan_DTO tkDTO = new TaiKhoan_DTO();

        NhanVien_BUS nvBUS = new NhanVien_BUS();
        private frmThemTaiKhoan frmThemTaiKhoan;

        //public subForm_TaoTK()
        //{
        //    InitializeComponent();
        //    txt_manv.Hide();
        //}

        public subForm_TaoTK(frmThemTaiKhoan frmThemTaiKhoan)
        {
            InitializeComponent();
            txt_manv.Hide();
            this.frmThemTaiKhoan = frmThemTaiKhoan;
        }

        private void btn_luuTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txt_taoTenDangNhap.Text == "" || txt_taoMatKhau.Text == "")
               
            {
                XtraMessageBox.Show("Chưa điền đầy đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(tkBUS.CheckUsername(txt_taoTenDangNhap.Text) == 1)
                {
                    XtraMessageBox.Show("Tên đăng nhập đã tồn tại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txt_taoMatKhau.Text != txt_nhapLaiMK.Text)
                    {
                        XtraMessageBox.Show("Mật khẩu không khớp!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (tkDTO != null)
                        {
                            GetDetail();

                            int kq = tkBUS.AddTK(tkDTO);
                            if (kq == 1)
                            {
                                XtraMessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                string manv = txt_manv.Text;
                                tkBUS.UpdateNVChuaCoTK(manv);
                                nvBUS.danhsachNVChuaCoTaiKhoan();
                                frmThemTaiKhoan.LoadDSNVChuaCoTaiKhoan();
                                this.Dispose();
                            }
                            else
                            {
                                XtraMessageBox.Show("Tạo không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            tkDTO.TenDangNhap = txt_taoTenDangNhap.Text;
            tkDTO.MatKhau = txt_taoMatKhau.Text;
            tkDTO.MaNV = txt_manv.Text;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void chk_showHide_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_showHide.Checked)
            {
                txt_taoMatKhau.Properties.UseSystemPasswordChar = false;
                txt_nhapLaiMK.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txt_taoMatKhau.Properties.UseSystemPasswordChar = true;
                txt_nhapLaiMK.Properties.UseSystemPasswordChar = true;
            }
        }
    }
}
