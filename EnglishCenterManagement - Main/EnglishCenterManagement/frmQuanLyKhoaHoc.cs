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
    public partial class frmQuanLyKhoaHoc : DevExpress.XtraEditors.XtraForm
    {
        bool isClick = true;
        KhoaHoc_BUS khBUS = new KhoaHoc_BUS();
        KhoaHoc_DTO khDTO = new KhoaHoc_DTO();
        TimeSpan ts1 = TimeSpan.FromDays(181);
        TimeSpan ts2 = TimeSpan.FromDays(186);
        TimeSpan ts3 = TimeSpan.FromDays(90);
        TimeSpan ts4 = TimeSpan.FromDays(95);

        public frmQuanLyKhoaHoc()
        {
            InitializeComponent();
        }
        private void frmQuanLyKhoaHoc_Load(object sender, EventArgs e)
        {
            btn_themKhoaHoc.Enabled = false;
            LoadDSKhoaHoc();
        }

        private void LoadDSKhoaHoc()
        {
            List<KhoaHoc_DTO> lsKhoaHoc = new List<KhoaHoc_DTO>();
            lsKhoaHoc = khBUS.DanhSachKH();
            dgcontrol_khoaHoc.DataSource = lsKhoaHoc;   
        }
        private void txt_hocPhi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                //&& (e.KeyChar != '.' || (e.KeyChar == '.' &&
                //        (txt_sdt.Text.Length == 0 || txt_sdt.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }

        private void BindingChiTiet()
        {
            if (khDTO != null)
            {
                txt_makh.Text = khDTO.MaKH;
                txt_tenkh.Text = khDTO.TenKH;
                dt_ngayBatDau.EditValue = khDTO.NgayBatDau;
                dt_ngayKetThuc.EditValue = khDTO.NgayKetThuc;
                txt_hocPhi.Text = khDTO.HocPhi.ToString();               
            }
            else
            {
                txt_makh.Text = string.Empty;
                txt_tenkh.Text = string.Empty;
                dt_ngayBatDau.EditValue = DateTime.Now;
                dt_ngayKetThuc.EditValue = DateTime.Now;
                txt_hocPhi.Text = string.Empty;
            }
        }

        private void dgview_khoaHoc_DoubleClick(object sender, EventArgs e)
        {
            if (dgview_khoaHoc.SelectedRowsCount > 0)
            {
                int[] selectedRows = dgview_khoaHoc.GetSelectedRows();
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                    {
                        khDTO.MaKH = dgview_khoaHoc.GetRowCellValue(rowHandle, cl_makh).ToString().Trim();
                        khDTO.TenKH = dgview_khoaHoc.GetRowCellValue(rowHandle, cl_tenkh).ToString();
                        khDTO.NgayBatDau = DateTime.Parse(dgview_khoaHoc.GetRowCellValue(rowHandle, cl_ngayBatDau).ToString());
                        khDTO.NgayKetThuc = DateTime.Parse(dgview_khoaHoc.GetRowCellValue(rowHandle, cl_ngayKetThuc).ToString());
                        khDTO.HocPhi = int.Parse(dgview_khoaHoc.GetRowCellValue(rowHandle, cl_hocPhi).ToString());
                    }
                }
            }
            else
            {
                khDTO = null;
            }
            BindingChiTiet();
        }
        private void dgcontrol_khoaHoc_Click(object sender, EventArgs e)
        {
            if (dgview_khoaHoc.SelectedRowsCount > 0)
            {
                int[] selectedRows = dgview_khoaHoc.GetSelectedRows();
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                    {
                        khDTO.MaKH = dgview_khoaHoc.GetRowCellValue(rowHandle, cl_makh).ToString().Trim();
                        khDTO.TenKH = dgview_khoaHoc.GetRowCellValue(rowHandle, cl_tenkh).ToString();
                        khDTO.NgayBatDau = DateTime.Parse(dgview_khoaHoc.GetRowCellValue(rowHandle, cl_ngayBatDau).ToString());
                        khDTO.NgayKetThuc = DateTime.Parse(dgview_khoaHoc.GetRowCellValue(rowHandle, cl_ngayKetThuc).ToString());
                        khDTO.HocPhi = int.Parse(dgview_khoaHoc.GetRowCellValue(rowHandle, cl_hocPhi).ToString());
                    }
                }
            }
            else
            {
                khDTO = null;
            }
            BindingChiTiet();
        }
        private void btn_themKhoaHoc_Click(object sender, EventArgs e)
        {                       
            TimeSpan date = ((DateTime)dt_ngayKetThuc.EditValue).Subtract((DateTime)dt_ngayBatDau.EditValue);

            if (txt_tenkh.Text == "" || dt_ngayBatDau.EditValue == null || 
                dt_ngayKetThuc.EditValue == null || txt_hocPhi.Text == "")
            {
                XtraMessageBox.Show("Chưa điền đầy đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if((DateTime)dt_ngayBatDau.EditValue < DateTime.Now)
                {
                    XtraMessageBox.Show("Ngày bắt đầu phải lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if ((DateTime)dt_ngayKetThuc.EditValue < (DateTime)dt_ngayBatDau.EditValue)
                    {
                        XtraMessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if(date >= ts3 && date <= ts4 || 
                           date >= ts1 && date <= ts2)
                        {
                            if (khDTO != null)
                            {
                                GetDetail();

                                int kq = khBUS.AddKH(khDTO);
                                if (kq == 1)
                                {
                                    XtraMessageBox.Show(string.Format("Thêm khóa học {0} thành công!", khDTO.TenKH), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadDSKhoaHoc();
                                    btn_themKhoaHoc.Enabled = false;
                                    btn_suaKhoaHoc.Enabled = true;
                                    dgcontrol_khoaHoc.Enabled = true;
                                }
                                else
                                {
                                    XtraMessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }                            
                        }
                        else
                        {
                            XtraMessageBox.Show("Khóa học không dưới 3 tháng và không quá 6 tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }                      
                    }                  
                }
            }
        }

        private void GetDetail()
        {
            if (khDTO != null)
            {
                khDTO = new KhoaHoc_DTO();
            }
            khDTO.MaKH = txt_makh.Text;
            khDTO.TenKH = txt_tenkh.Text;
            khDTO.NgayBatDau = DateTime.Parse(dt_ngayBatDau.EditValue.ToString());
            khDTO.NgayKetThuc = DateTime.Parse(dt_ngayKetThuc.EditValue.ToString());
            khDTO.HocPhi = int.Parse(txt_hocPhi.Text);
        }

        private void btn_suaKhoaHoc_Click(object sender, EventArgs e)
        {
            TimeSpan date = ((DateTime)dt_ngayKetThuc.EditValue).Subtract((DateTime)dt_ngayBatDau.EditValue);

            if (txt_tenkh.Text == "" || dt_ngayBatDau.EditValue == null ||
                dt_ngayKetThuc.EditValue == null || txt_hocPhi.Text == "")
            {
                XtraMessageBox.Show("Chưa điền đầy đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if ((DateTime)dt_ngayBatDau.EditValue < DateTime.Now)
                {
                    XtraMessageBox.Show("Ngày bắt đầu phải lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if ((DateTime)dt_ngayKetThuc.EditValue < (DateTime)dt_ngayBatDau.EditValue)
                    {
                        XtraMessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (date >= ts3 && date <= ts4 ||
                            date >= ts1 && date <= ts2)
                        {
                            if (khDTO != null)
                            {
                                GetDetail();

                                int kq = khBUS.UpdateKH(khDTO);
                                if (kq == 1)
                                {
                                    XtraMessageBox.Show(string.Format("Sửa khóa học mã {0} thành công!", khDTO.MaKH), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadDSKhoaHoc();
                                    RefreshTextBox();
                                }
                                else
                                {
                                    XtraMessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Khóa học không dưới 3 tháng và không quá 6 tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void btn_xoaKhoaHoc_Click(object sender, EventArgs e)
        {
            if (dgview_khoaHoc.SelectedRowsCount == 0)
            {
                XtraMessageBox.Show("Chưa chọn đối tượng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa học viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == result)
                {
                    int[] selectedRows = dgview_khoaHoc.GetSelectedRows();
                    foreach (int rowHandle in selectedRows)
                    {
                        if (rowHandle >= 0)
                        {
                            string makh = dgview_khoaHoc.GetRowCellValue(rowHandle, cl_makh).ToString();
                            khBUS.DeleteKH(makh);
                        }
                        LoadDSKhoaHoc();
                    }
                    XtraMessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_lamMoiKhoaHoc_Click(object sender, EventArgs e)
        {
            if(isClick)
            {
                isClick = false;
                btn_themKhoaHoc.Enabled = true;
                btn_suaKhoaHoc.Enabled = false;
                btn_xoaKhoaHoc.Enabled = false;
                btn_capNhatTGKH.Enabled = false;
                string maTiepTheo = khBUS.maKhoaHocTiepTheo();
                txt_makh.Text = maTiepTheo;
                txt_tenkh.Text = string.Empty;
                dt_ngayBatDau.EditValue = DateTime.Now;
                dt_ngayKetThuc.EditValue = DateTime.Now;
                txt_hocPhi.Text = string.Empty;
                dgcontrol_khoaHoc.Enabled = false;
                btn_lamMoiKhoaHoc.Text = "Hủy";
                btn_lamMoiKhoaHoc.ImageOptions.Image = EnglishCenterManagement.Properties.Resources.close;
            }
            else
            {
                isClick = true;
                btn_themKhoaHoc.Enabled = false;
                btn_suaKhoaHoc.Enabled = true;
                btn_xoaKhoaHoc.Enabled = true;
                btn_capNhatTGKH.Enabled = true;
                dgcontrol_khoaHoc.Enabled = true;
                string maTiepTheo = string.Empty;
                txt_makh.Text = string.Empty;
                txt_tenkh.Text = string.Empty;
                dt_ngayBatDau.EditValue = string.Empty;
                dt_ngayKetThuc.EditValue = string.Empty;
                txt_hocPhi.Text = string.Empty;
                btn_lamMoiKhoaHoc.Text = "Làm mới";
                btn_lamMoiKhoaHoc.ImageOptions.Image = EnglishCenterManagement.Properties.Resources.refresh;
            }
        } 
        void RefreshTextBox()
        {
            dgcontrol_khoaHoc.Enabled = true;
            string maTiepTheo = string.Empty;
            txt_makh.Text = string.Empty;
            txt_tenkh.Text = string.Empty;
            dt_ngayBatDau.EditValue = string.Empty;
            dt_ngayKetThuc.EditValue = string.Empty;
            txt_hocPhi.Text = string.Empty;
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            frmHelp f = new frmHelp();
            f.ShowDialog();
        }
    }
}