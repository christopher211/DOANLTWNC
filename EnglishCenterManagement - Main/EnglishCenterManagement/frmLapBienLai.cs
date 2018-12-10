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
using DevExpress.XtraReports.UI;
using ECM_BUS;
using ECM_DTO;

namespace EnglishCenterManagement
{
    public partial class frmLapBienLai : DevExpress.XtraEditors.XtraForm
    {

        private bool mouseDown;
        private Point lastLocation;
        #region MoveFormWithoutBorder
        
        private void frmLapBienLai_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmLapBienLai_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmLapBienLai_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        List<BienLai_DTO> lsBienLai;
        BienLai_BUS blBUS = new BienLai_BUS();
        BienLai_DTO blDTO = new BienLai_DTO();

        public bool isSave;
        public frmLapBienLai()
        {
            InitializeComponent();
        }

        private void frmLapBienLai_Load(object sender, EventArgs e)
        {
            lb_maBL.Text = blBUS.maBienLaiTiepTheo();
            lb_ngayLapBL.Text = DateTime.Now.ToShortDateString();
            LoadDSBienLai();
        }
        public void LoadDSBienLai()
        {
            lsBienLai = new List<BienLai_DTO>();
            lsBienLai = blBUS.DSBienLai();
            dgcontrol_bienLai.DataSource = lsBienLai;
        }
        private void btn_inBienLai_Click(object sender, EventArgs e)
        {
            if(isSave == false)
            {
                XtraMessageBox.Show("Vui lòng lưu biên lai trước khi in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                rptInHoaDon rp = new rptInHoaDon();

                rp.lb_maBL.Text = blBUS.maBienLaiTiepTheo();
                rp.lb_mahv.Text = lb_mahv.Text;
                rp.lb_tenhv.Text = lb_tenhv.Text;
                rp.lb_maLop.Text = lb_maLop.Text;
                rp.lb_khoaHoc.Text = lb_khoahoc.Text;
                rp.lb_tenKH.Text = lb_tenkh.Text;
                rp.lb_ngayBatDau.Text = lb_ngayBatDau.Text;
                rp.lb_lichHoc.Text = lb_lichHoc.Text;
                rp.lb_thoiGian.Text = lb_thoiGian.Text;
                rp.lb_hocPhi.Text = lb_hocPhi.Text;
                rp.lb_nguoiLapBL.Text = lb_nguoiLapBL.Text;
                rp.lb_ngayLapBL.Text = "Ngày " + lb_ngayLapBL.Text;

                rp.CreateDocument();

                Loading.ShowReportLoading();
                rp.ShowPreviewDialog();
                Loading.HideLoading();
            }           
        }

        private void btn_luuBL_Click(object sender, EventArgs e)
        {
            if (blDTO != null)
            {
                GetDetail();

                int kq = blBUS.SaveBL(blDTO);
                if (kq == 1)
                {
                    XtraMessageBox.Show(string.Format("Lưu biên lai {0} thành công!", blDTO.MaBL), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isSave = true;
                    btn_luuBL.Enabled = false;
                    LoadDSBienLai();
                }
                else
                {
                    XtraMessageBox.Show("Lưu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void GetDetail()
        {
            if (blDTO != null)
            {
                blDTO = new BienLai_DTO();
            }
            blDTO.MaBL = lb_maBL.Text.Trim();
            blDTO.MaNV = lb_manv.Text.Trim();
            blDTO.MSHV = lb_mahv.Text.Trim();
            blDTO.MaKH = lb_khoahoc.Text.Trim();
            blDTO.MaLop = lb_maLop.Text.Trim();
            blDTO.HocPhi = int.Parse(lb_hocPhi.Text.Trim());
            blDTO.NgayLapBienLai = DateTime.Parse(lb_ngayLapBL.Text.Trim());
        }

        private void dgcontrol_bienLai_Click(object sender, EventArgs e)
        {
            if (dgview_bienLai.SelectedRowsCount > 0)
            {
                int[] selectedRows = dgview_bienLai.GetSelectedRows();
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                    {
                        blDTO.MaBL = dgview_bienLai.GetRowCellValue(rowHandle, cl_maBL).ToString().Trim();
                        blDTO.MSHV = dgview_bienLai.GetRowCellValue(rowHandle, cl_mahv).ToString().Trim();
                        blDTO.HoTen = dgview_bienLai.GetRowCellValue(rowHandle, cl_hoten).ToString().Trim();
                        blDTO.GioiTinh = dgview_bienLai.GetRowCellValue(rowHandle, cl_gioiTinh).ToString().Trim();
                        blDTO.SDT = dgview_bienLai.GetRowCellValue(rowHandle, cl_sdt).ToString().Trim();
                        blDTO.NgaySinh = DateTime.Parse(dgview_bienLai.GetRowCellValue(rowHandle, cl_ngaySinh).ToString().Trim());
                        blDTO.Email = dgview_bienLai.GetRowCellValue(rowHandle, cl_email).ToString().Trim();
                        blDTO.MaKH = dgview_bienLai.GetRowCellValue(rowHandle, cl_maKH).ToString().Trim();
                        blDTO.TenKH = dgview_bienLai.GetRowCellValue(rowHandle, cl_tenkh).ToString().Trim();
                        blDTO.MaLop = dgview_bienLai.GetRowCellValue(rowHandle, cl_maLop).ToString().Trim();
                        blDTO.LichHoc = dgview_bienLai.GetRowCellValue(rowHandle, cl_lichHoc).ToString().Trim();
                        blDTO.NgayBatDau = DateTime.Parse(dgview_bienLai.GetRowCellValue(rowHandle, cl_ngayBatDau).ToString().Trim());
                        blDTO.GioBatDau = dgview_bienLai.GetRowCellValue(rowHandle, cl_gioBatDau).ToString().Trim();
                        blDTO.HocPhi = int.Parse(dgview_bienLai.GetRowCellValue(rowHandle, cl_hocPhi).ToString().Trim());
                        blDTO.NgayLapBienLai = DateTime.Parse(dgview_bienLai.GetRowCellValue(rowHandle, cl_ngayLapBL).ToString().Trim());
                        blDTO.MaNV = dgview_bienLai.GetRowCellValue(rowHandle, cl_manv).ToString().Trim();
                        blDTO.HoTenNV = dgview_bienLai.GetRowCellValue(rowHandle, cl_nguoiLapBL).ToString().Trim();
                    }
                }
            }
            else
            {
                blDTO = null;
            }
            BindingChiTiet();
        }

        private void BindingChiTiet()
        {
            if (blDTO != null)
            {
                lb_maBL.Text = blDTO.MaBL;
                lb_nguoiLapBL.Text = blDTO.HoTenNV;
                lb_manv.Text = blDTO.MaNV;
                lb_mahv.Text = blDTO.MSHV;
                lb_tenhv.Text = blDTO.HoTen;
                lb_gioiTinh.Text = blDTO.GioiTinh;
                lb_sdt.Text = blDTO.SDT;
                lb_ngaySinh.Text = DateTime.Parse(blDTO.NgaySinh.ToString()).ToShortDateString();
                lb_email.Text = blDTO.Email;
                lb_khoahoc.Text = blDTO.MaKH;
                lb_tenkh.Text = blDTO.TenKH;
                lb_maLop.Text = blDTO.MaLop;
                lb_lichHoc.Text = blDTO.LichHoc;
                lb_ngayBatDau.Text = DateTime.Parse(blDTO.NgayBatDau.ToString()).ToShortDateString();
                lb_thoiGian.Text = blDTO.GioBatDau;
                lb_hocPhi.Text = blDTO.HocPhi.ToString();
                lb_ngayLapBL.Text = DateTime.Parse(blDTO.NgayLapBienLai.ToString()).ToShortDateString();
            }
            else
            {
                lb_maBL.Text = "Chi Tiết";
                lb_nguoiLapBL.Text = "Chi Tiết";
                lb_manv.Text = "Chi Tiết";
                lb_mahv.Text = "Chi Tiết";
                lb_tenhv.Text = "Chi Tiết";
                lb_gioiTinh.Text = "Chi Tiết";
                lb_sdt.Text = "Chi Tiết";
                lb_ngaySinh.Text = "Chi Tiết";
                lb_email.Text = "Chi Tiết";
                lb_khoahoc.Text = "Chi Tiết";
                lb_tenkh.Text = "Chi Tiết";
                lb_maLop.Text = "Chi Tiết";
                lb_lichHoc.Text = "Chi Tiết";
                lb_ngayBatDau.Text = "Chi Tiết";
                lb_thoiGian.Text = "Chi Tiết";
                lb_hocPhi.Text = "Chi Tiết";
                lb_ngayLapBL.Text = "Chi Tiết";
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
    }
}