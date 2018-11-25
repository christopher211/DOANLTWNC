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
    public partial class frmSuaNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private bool mouseDown;
        private Point lastLocation;
        #region MoveFormWithoutBorder

        private void frmSuaNhanVien_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmSuaNhanVien_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmSuaNhanVien_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion

        List<ChucVu_DTO> lsChucVu;

        ChucVu_BUS cvBUS = new ChucVu_BUS();
        ChucVu_DTO cvDTO = new ChucVu_DTO();

        NhanVien_BUS nvBUS = new NhanVien_BUS();
        NhanVien_DTO nvDTO = new NhanVien_DTO();

        public frmSuaNhanVien()
        {
            InitializeComponent();
        }

        private void frmSuaNhanVien_Load(object sender, EventArgs e)
        {
            LoadDSCV();
        }
        private void LoadDSCV()
        {
            lsChucVu = new List<ChucVu_DTO>();
            lsChucVu = cvBUS.DanhSachCV();

            lke_chucVu.Properties.DataSource = lsChucVu;
            lke_chucVu.Properties.DisplayMember = "MaCV";
            lke_chucVu.Properties.ValueMember = "MaCV";

            lke_chucVu.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaCV", "Mã Chức Vụ", 10));
            lke_chucVu.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenCV", "Tên Chức Vụ", 20));
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
                if (nvDTO != null)
                {
                    GetDetail();

                    int kq = nvBUS.UpdateNV(nvDTO);
                    if (kq == 1)
                    {
                        XtraMessageBox.Show(string.Format("Sửa nhân viên mã {0} thành công!", nvDTO.MaNV), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}