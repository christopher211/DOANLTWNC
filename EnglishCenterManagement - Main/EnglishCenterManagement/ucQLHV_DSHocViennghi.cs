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
    public partial class ucQLHV_DSHocViennghi : DevExpress.XtraEditors.XtraUserControl
    {
        List<HocVien_DTO> lsHocVien;
        List<Lop_DTO> lsLop;
        List<KhoaHoc_DTO> lsKhoaHoc;

        HocVien_BUS hvBUS = new HocVien_BUS();
        HocVien_DTO hvDTO = new HocVien_DTO();
        public ucQLHV_DSHocViennghi()
        {
            InitializeComponent();
        }

        private void ucQLHV_DSHocViennghi_Load(object sender, EventArgs e)
        {
            LoadDSHVDaNghi();
            LoadDSLop();
            LoadDSKhoaHoc();
        }
        private void LoadDSHVDaNghi()
        {
            lsHocVien = new List<HocVien_DTO>();
            lsHocVien = hvBUS.danhSachHVDaNghi();
            dgcontrol_hocVien.DataSource = lsHocVien;
        }
        private void LoadDSLop()
        {
            Lop_BUS lopBUS = new Lop_BUS();
            Lop_DTO lopDAO = new Lop_DTO();
            lsLop = lopBUS.DanhSachLop();

            lke_lopHoc.Properties.DataSource = lsLop;
            lke_lopHoc.Properties.DisplayMember = "MaLop";
            lke_lopHoc.Properties.ValueMember = "MaLop";

            lke_lopHoc.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaLop", "Mã Lớp Học", 10));
            lke_lopHoc.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenLop", "Tên Lớp Học", 20));
        }
        private void LoadDSKhoaHoc()
        {
            KhoaHoc_BUS khBUS = new KhoaHoc_BUS();
            KhoaHoc_DTO khDTO = new KhoaHoc_DTO();
            lsKhoaHoc = khBUS.DanhSachKH();

            lke_khoaHoc.Properties.DataSource = lsKhoaHoc;
            lke_khoaHoc.Properties.DisplayMember = "MaKH";
            lke_khoaHoc.Properties.ValueMember = "MaKH";

            lke_khoaHoc.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKH", "Mã Khóa Học", 10));
            lke_khoaHoc.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKH", "Tên Khóa Học", 20));
        }
        private void LoadDSHVDaNghiTheoMSHV()
        {
            //List<HocVien_DTO> lsHocVien = new List<HocVien_DTO>();
            lsHocVien = hvBUS.danhsachHVDaNghiTheoMSHV(txt_timHVMSHV.Text);
            dgcontrol_hocVien.DataSource = lsHocVien;
        }
        private void LoadDSHVDaNghiTheoHoTen()
        {
            lsHocVien = hvBUS.danhsachHVDaNghiTheoHoTen(txt_timHVHoTen.Text);
            dgcontrol_hocVien.DataSource = lsHocVien;
        }
        private void LoadDSHVDaNghiTheoKhoaHoc()
        {
            lsHocVien = hvBUS.danhsachHVDaNghiTheoKhoaHoc(lke_khoaHoc.Text);
            dgcontrol_hocVien.DataSource = lsHocVien;
        }
        private void LoadDSHVDaNghiTheoLop()
        {
            lsHocVien = hvBUS.danhsachHVDaNghiTheoLop(lke_lopHoc.Text);
            dgcontrol_hocVien.DataSource = lsHocVien;
        }

        private void btn_timHVMSHV_Click(object sender, EventArgs e)
        {
            LoadDSHVDaNghiTheoMSHV();
        }

        private void btn_timHVHoTen_Click(object sender, EventArgs e)
        {
            LoadDSHVDaNghiTheoHoTen();
        }

        private void btn_timHVLop_Click(object sender, EventArgs e)
        {
            LoadDSHVDaNghiTheoLop();
        }

        private void btn_timHVKhoaHoc_Click(object sender, EventArgs e)
        {
            LoadDSHVDaNghiTheoKhoaHoc();
        }

        private void btn_khoiPhucHV_Click(object sender, EventArgs e)
        {
            if (dgview_hocVien.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Chưa chọn đối tượng để khôi phục");
            }
            else
            {
                DialogResult result = XtraMessageBox.Show("Bạn có muốn khôi phục học viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == result)
                {
                    int[] selectedRows = dgview_hocVien.GetSelectedRows();
                    foreach (int rowHandle in selectedRows)
                    {
                        if (rowHandle >= 0)
                        {
                            string manv = dgview_hocVien.GetRowCellValue(rowHandle, cl_mshv).ToString();
                            hvBUS.RestoreHV(manv);
                        }
                        LoadDSHVDaNghi();
                    }
                    XtraMessageBox.Show("Khôi phục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_lamMoiHV_Click(object sender, EventArgs e)
        {
            LoadDSHVDaNghi();
        }
    }
}
