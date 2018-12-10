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
    public partial class frmThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private bool mouseDown;
        private Point lastLocation;
        #region MoveFormWithoutBorder

        private void frmThemNhanVien_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void frmThemNhanVien_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmThemNhanVien_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        ChucVu_BUS cvBUS = new ChucVu_BUS();
        ChucVu_DTO cvDTO = new ChucVu_DTO();

        NhanVien_BUS nvBUS = new NhanVien_BUS();
        NhanVien_DTO nvDTO = new NhanVien_DTO();
        private ucQLNV_TrungTam ucQLNV_TrungTam;

        //public frmThemNhanVien()
        //{
        //    InitializeComponent();
        //}

        public frmThemNhanVien(ucQLNV_TrungTam ucQLNV_TrungTam)
        {
            InitializeComponent();
            this.ucQLNV_TrungTam = ucQLNV_TrungTam;
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            string maTiepTheo = nvBUS.maNhanVienTiepTheo();
            txt_manv.Text = maTiepTheo;
            LoadDSCV();
        }
        private void LoadDSCV()
        {
            List<ChucVu_DTO> lsChucVu = new List<ChucVu_DTO>();
            lsChucVu = cvBUS.DanhSachCV();

            lke_chucVu.Properties.DataSource = lsChucVu;
            lke_chucVu.Properties.DisplayMember = "MaCV";
            lke_chucVu.Properties.ValueMember = "MaCV";          
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            ucQLNV_TrungTam.LoadDSNV_TT();
            this.Close();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_ho.Text.Trim() == "" || txt_ten.Text.Trim() == "" ||
                cbo_gioiTinh.Text.Trim() == "" || dt_ngaySinh.EditValue == null || dt_ngayLamViec.EditValue == null ||
                txt_email.Text.Trim() == "" || txt_sdt.Text.Trim() == "" || txt_diaChi.Text.Trim() == "" ||
                lke_chucVu.EditValue == null)
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
                                    if(chk_giamDoc.Checked == false && lke_chucVu.ItemIndex == 0)
                                    {
                                        XtraMessageBox.Show("Không thể thêm chức vụ giám đốc cho nhân viên này!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        if (nvDTO != null)
                                        {
                                            GetDetail();

                                            int kq = nvBUS.AddNV(nvDTO);
                                            if (kq == 1)
                                            {
                                                XtraMessageBox.Show(string.Format("Thêm nhân viên mã {0} thành công!", nvDTO.MaNV), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                ucQLNV_TrungTam.LoadDSNV_TT();
                                                RefreshTextBox();
                                            }
                                            else
                                            {
                                                XtraMessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
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
            if (nvDTO != null)
            {
                nvDTO = new NhanVien_DTO();
            }
            nvDTO.MaNV = txt_manv.Text;
            nvDTO.HoNV = txt_ho.Text;
            nvDTO.TenNV = txt_ten.Text;
            nvDTO.GioiTinh = cbo_gioiTinh.Text;
            nvDTO.NgaySinh = DateTime.Parse(dt_ngaySinh.EditValue.ToString());
            nvDTO.NgayLamViec = DateTime.Parse(dt_ngayLamViec.EditValue.ToString());
            nvDTO.SDT = txt_sdt.Text;
            nvDTO.Email = txt_email.Text;
            nvDTO.DiaChi = txt_diaChi.Text;
            nvDTO.ChucVu = lke_chucVu.EditValue.ToString();
        }
        public void RefreshTextBox()
        {
            string maTiepTheo = nvBUS.maNhanVienTiepTheo();
            txt_manv.Text = maTiepTheo;
            txt_ho.Text = string.Empty;
            txt_ten.Text = string.Empty;
            cbo_gioiTinh.Text = string.Empty;
            dt_ngaySinh.EditValue = DateTime.Now;
            dt_ngayLamViec.EditValue = DateTime.Now;
            txt_sdt.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_diaChi.Text = string.Empty;
            lke_chucVu.EditValue = string.Empty;
        }
        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                //&& (e.KeyChar != '.' || (e.KeyChar == '.' &&
                //        (txt_sdt.Text.Length == 0 || txt_sdt.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }
        private void btn_lamLai_Click(object sender, EventArgs e)
        {
            RefreshTextBox();
        }       
    }
}