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
    public partial class frmThemGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        private bool mouseDown;
        private Point lastLocation;
        #region MoveFormWithoutBorder
       
        private void frmThemGiaoVien_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmThemGiaoVien_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmThemGiaoVien_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion

        //List<NhanVien_DTO> lsGiaoVien;

        NhanVien_BUS gvBUS = new NhanVien_BUS();
        NhanVien_DTO gvDTO = new NhanVien_DTO();

        public frmThemGiaoVien()
        {
            InitializeComponent();
        }
        private void frmThemGiaoVien_Load(object sender, EventArgs e)
        {
            string maTiepTheo = gvBUS.maNhanVienTiepTheo();
            txt_manv.Text = maTiepTheo;
        }
        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                //&& (e.KeyChar != '.' || (e.KeyChar == '.' &&
                //        (txt_sdt.Text.Length == 0 || txt_sdt.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_ho.Text == "" || txt_ten.Text == "" ||
                cbo_gioiTinh.Text == "" || dt_ngaySinh.EditValue == null || dt_ngayLamViec.EditValue == null ||
                txt_email.Text == "" || txt_sdt.Text == "" || txt_diaChi.Text == "")
            {
                XtraMessageBox.Show("Chưa điền đầy đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (dt_ngaySinh.DateTime.Year >= DateTime.Now.Year)
                {
                    XtraMessageBox.Show("Năm sinh không được lớn hơn hoặc bằng năm hiện tại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (dt_ngayLamViec.DateTime < DateTime.Now)
                    {
                        XtraMessageBox.Show("Ngày bắt đầu làm việc không được nhỏ hơn ngày hiện tại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (txt_sdt.Text.Length < 10)
                        {
                            XtraMessageBox.Show("Số điện thoại phải đủ 10 số!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (!txt_sdt.Text.StartsWith("0"))
                            {
                                XtraMessageBox.Show("Số điện thoại phải bắt đầu bằng số 0!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                            else
                            {
                                if (Utilities.IsValidEmail(txt_email.Text.Trim()) == false)
                                {
                                    XtraMessageBox.Show("Địa chỉ email sai định dạng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    if (gvDTO != null)
                                    {
                                        GetDetail();

                                        int kq = gvBUS.AddGV(gvDTO);
                                        if (kq == 1)
                                        {
                                            XtraMessageBox.Show(string.Format("Thêm giáo viên mã {0} thành công!", gvDTO.MaNV), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            RefreshTextBox();
                                        }
                                        else
                                        {
                                            XtraMessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            gvDTO = null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void GetDetail()
        {
            if (gvDTO != null)
            {
                gvDTO = new NhanVien_DTO();
            }
            gvDTO.MaNV = txt_manv.Text;
            gvDTO.HoNV = txt_ho.Text;
            gvDTO.TenNV = txt_ten.Text;
            gvDTO.GioiTinh = cbo_gioiTinh.Text;
            gvDTO.NgaySinh = DateTime.Parse(dt_ngaySinh.EditValue.ToString());
            gvDTO.NgayLamViec = DateTime.Parse(dt_ngayLamViec.EditValue.ToString());
            gvDTO.SDT = txt_sdt.Text;
            gvDTO.Email = txt_email.Text;
            gvDTO.DiaChi = txt_diaChi.Text;            
        }
        public void RefreshTextBox()
        {
            string maTiepTheo = gvBUS.maNhanVienTiepTheo();
            txt_manv.Text = maTiepTheo;
            txt_ho.Text = string.Empty;
            txt_ten.Text = string.Empty;
            cbo_gioiTinh.Text = string.Empty;
            dt_ngaySinh.EditValue = DateTime.Now;
            dt_ngayLamViec.EditValue = DateTime.Now;
            txt_sdt.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_diaChi.Text = string.Empty;          
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_lamLai_Click(object sender, EventArgs e)
        {
            RefreshTextBox();
        }
    }
}