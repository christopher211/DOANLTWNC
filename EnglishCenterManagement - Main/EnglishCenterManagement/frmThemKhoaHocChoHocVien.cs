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
    public partial class frmThemKhoaHocChoHocVien : DevExpress.XtraEditors.XtraForm
    {
        private bool mouseDown;
        private Point lastLocation;
        #region MoveFormWithoutBorder
      
        private void frmThemKhoaHocChoHocVien_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmThemKhoaHocChoHocVien_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmThemKhoaHocChoHocVien_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        //List<HocVien_DTO> lsHocVien;
        List<Lop_DTO> lsLop;
        List<KhoaHoc_DTO> lsKhoaHoc;

        HocVien_BUS hvBUS = new HocVien_BUS();
        HocVien_DTO hvDTO = new HocVien_DTO();

        Lop_BUS lopBUS = new Lop_BUS();
        Lop_DTO lopDTO = new Lop_DTO();

        KhoaHoc_BUS khBUS = new KhoaHoc_BUS();
        KhoaHoc_DTO khDTO = new KhoaHoc_DTO();
        private ucQLHV_DanhSach ucQLHV_DanhSach;

        //public frmThemKhoaHocChoHocVien()
        //{
        //    InitializeComponent();
        //}

        public frmThemKhoaHocChoHocVien(ucQLHV_DanhSach ucQLHV_DanhSach)
        {
            InitializeComponent();
            this.ucQLHV_DanhSach = ucQLHV_DanhSach;
        }

        private void lke_khoaHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (lke_khoaHoc.EditValue != null)
            {
                lke_lopHoc.Enabled = true;
                lsLop = lopBUS.DanhSachLop2(lke_khoaHoc.EditValue.ToString());
                lke_lopHoc.Properties.DataSource = lsLop;
                lke_lopHoc.Properties.DisplayMember = "MaLop";
                lke_lopHoc.Properties.ValueMember = "MaLop";
            }
        }
        private void frmThemKhoaHocChoHocVien_Load(object sender, EventArgs e)
        {
            lke_lopHoc.Enabled = false;
            btn_lamLai.Enabled = false;
            LoadDSKhoaHoc();
        }
        private void LoadDSKhoaHoc()
        {
            KhoaHoc_BUS khBUS = new KhoaHoc_BUS();
            KhoaHoc_DTO khDTO = new KhoaHoc_DTO();
            lsKhoaHoc = khBUS.DanhSachKH();

            lke_khoaHoc.Properties.DataSource = lsKhoaHoc;
            lke_khoaHoc.Properties.DisplayMember = "MaKH";
            lke_khoaHoc.Properties.ValueMember = "MaKH";

            //lke_khoaHoc.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKH", "Mã Khóa Học", 10));
            //lke_khoaHoc.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKH", "Tên Khóa Học", 20));
        }
        private void GetDetail()
        {
            if (hvDTO != null)
            {
                hvDTO = new HocVien_DTO();
            }
            hvDTO.MSHV = txt_mshv.Text;
            hvDTO.Ho = txt_ho.Text;
            hvDTO.Ten = txt_ten.Text;
            hvDTO.GioiTinh = cbo_gioiTinh.Text;
            hvDTO.NgaySinh = DateTime.Parse(dt_ngaySinh.EditValue.ToString());
            hvDTO.SDT = txt_sdt.Text;
            hvDTO.Email = txt_email.Text;
            hvDTO.DiaChi = txt_diaChi.Text;
            hvDTO.MaKH = lke_khoaHoc.Text;
            hvDTO.MaLop = lke_lopHoc.Text;
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (lke_khoaHoc.Text == "" || lke_lopHoc.Text == "")
            {
                XtraMessageBox.Show("Chưa điền đầy đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (hvDTO != null)
                {
                    GetDetail();

                    int kq = hvBUS.AddHV(hvDTO);
                    if (kq == 1)
                    {
                        frmLapBienLai f = new frmLapBienLai();
                        XtraMessageBox.Show(string.Format("Thêm khóa học cho học viên mã {0} thành công!", hvDTO.MSHV), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        f.lb_mahv.Text = this.txt_mshv.Text.Trim();
                        f.lb_tenhv.Text = this.txt_ho.Text + ' ' + this.txt_ten.Text;
                        f.lb_gioiTinh.Text = this.cbo_gioiTinh.Text.Trim();
                        f.lb_sdt.Text = this.txt_sdt.Text.Trim();
                        f.lb_diaChi.Text = this.txt_diaChi.Text.Trim();
                        f.lb_ngaySinh.Text = this.dt_ngaySinh.Text.Trim();
                        f.lb_email.Text = this.txt_email.Text.Trim();
                        f.lb_maLop.Text = this.lke_lopHoc.Text.Trim();
                        f.lb_khoahoc.Text = this.lke_khoaHoc.Text.Trim();
                        f.lb_tenkh.Text = this.lke_khoaHoc.GetColumnValue("TenKH").ToString().Trim();
                        f.lb_hocPhi.Text = this.lke_khoaHoc.GetColumnValue("HocPhi").ToString().Trim();
                        f.lb_ngayBatDau.Text = DateTime.Parse(this.lke_khoaHoc.GetColumnValue("NgayBatDau").ToString()).ToShortDateString();
                        f.lb_lichHoc.Text = this.lke_lopHoc.GetColumnValue("LichHoc").ToString().Trim();
                        f.lb_thoiGian.Text = this.lke_lopHoc.GetColumnValue("GioBatDau").ToString().Trim();
                        f.lb_manv.Text = this.lke_lopHoc.GetColumnValue("MaNV").ToString().Trim();
                        //f.lb_nguoiLapBL.Text = "";

                        f.dgcontrol_bienLai.Enabled = false;
                        f.btn_thoat.Visible = true;
                        f.BackColor = Color.FromArgb(224, 224, 224);
                        f.FormBorderEffect = FormBorderEffect.Shadow;

                        Loading.ShowReportLoading();
                        f.ShowDialog();
                        Loading.HideLoading();

                        ucQLHV_DanhSach.LoadDSHV();
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Học viên đang học khóa học này!!\n Vui lòng chọn khóa học khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            ucQLHV_DanhSach.LoadDSHV();
        }
        
    }
}