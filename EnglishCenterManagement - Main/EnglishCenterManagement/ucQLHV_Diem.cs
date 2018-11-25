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
    public partial class ucQLHV_Diem : DevExpress.XtraEditors.XtraUserControl
    {
        List<HocVien_DTO> lsHocVien;
        List<Lop_DTO> lsLop;
        List<KhoaHoc_DTO> lsKhoaHoc;
        List<Diem_DTO> lsDiem;

        HocVien_BUS hvBUS = new HocVien_BUS();
        HocVien_DTO hvDTO = new HocVien_DTO();

        Lop_BUS lopBUS = new Lop_BUS();
        Lop_DTO lopDTO = new Lop_DTO();

        KhoaHoc_BUS khBUS = new KhoaHoc_BUS();
        KhoaHoc_DTO khDTO = new KhoaHoc_DTO();

        Diem_BUS diemBUS = new Diem_BUS();
        Diem_DTO diemDTO = new Diem_DTO();
        #region TextBoxDiem

        private void txt_diemNghe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.' || (e.KeyChar == '.' &&
                        (txt_diemNghe.Text.Length == 0 || txt_diemNghe.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }

        private void txt_diemNoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.' || (e.KeyChar == '.' &&
                        (txt_diemNoi.Text.Length == 0 || txt_diemNoi.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }

        private void txt_diemDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.' || (e.KeyChar == '.' &&
                        (txt_diemDoc.Text.Length == 0 || txt_diemDoc.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }

        private void txt_diemViet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.' || (e.KeyChar == '.' &&
                        (txt_diemViet.Text.Length == 0 || txt_diemViet.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }
        #endregion

        float TinhDiemTB(float nghe, float noi, float doc, float viet)
        {
            float diemTB = (nghe + noi + doc + viet) / 4;
            return diemTB;
        }
        public ucQLHV_Diem()
        {
            InitializeComponent();
        }

        private void ucQLHV_Diem_Load(object sender, EventArgs e)
        {
            LoadDSLop();
            gp_thongTinChiTiet.Enabled = false;
            gp_timKiem.Enabled = false;
            dgcontrol_diemHocVien.Enabled = false;
        }
        private void LoadDSLop()
        {
            lsLop = new List<Lop_DTO>();
            lsLop = lopBUS.DanhSachLop();

            lke_maLop.Properties.DataSource = lsLop;
            lke_maLop.Properties.DisplayMember = "MaLop";
            lke_maLop.Properties.ValueMember = "MaLop";
        }
        private void LoadDSDiem()
        {
            lsDiem = new List<Diem_DTO>();
            lsDiem = diemBUS.danhSachDiemHV(lke_maLop.Text.Trim());
            dgcontrol_diemHocVien.DataSource = lsDiem;
        }       
        private void LoadDSDiemTheoHoTen()
        {
            lsDiem = new List<Diem_DTO>();
            lsDiem = diemBUS.danhSachDiemHVTheoHoTen(lke_maLop.Text.Trim(), txt_timTenHV.Text.Trim());
            dgcontrol_diemHocVien.DataSource = lsDiem;
        }
        private void LoadDSDiemTheoMaHV()
        {
            lsDiem = new List<Diem_DTO>();
            lsDiem = diemBUS.danhSachDiemHVTheoMaHV(lke_maLop.Text.Trim(), txt_timMaHV.Text.Trim());
            dgcontrol_diemHocVien.DataSource = lsDiem;
        }
        private void btn_timLop_Click(object sender, EventArgs e)
        {
            LoadDSDiem();
            gp_thongTinChiTiet.Enabled = true;
            gp_timKiem.Enabled = true;
            dgcontrol_diemHocVien.Enabled = true;
        }
        private void btn_timTenHV_Click(object sender, EventArgs e)
        {
            LoadDSDiemTheoHoTen();
        }
        private void btn_timMaHV_Click(object sender, EventArgs e)
        {
            LoadDSDiemTheoMaHV();
        }
        private void btn_luuDiem_Click(object sender, EventArgs e)
        {
            if (txt_diemNghe.Text.Trim() == "" || txt_diemNoi.Text.Trim() == "" ||
                txt_diemDoc.Text.Trim() == "" || txt_diemViet.Text.Trim() == "")
            {
                XtraMessageBox.Show("Chưa thêm điểm đầy đủ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(int.Parse(txt_diemNghe.Text.Trim()) > 10 || int.Parse(txt_diemNoi.Text.Trim()) > 10 ||
                   int.Parse(txt_diemDoc.Text.Trim()) > 10 || int.Parse(txt_diemViet.Text.Trim()) > 10)
                {
                    XtraMessageBox.Show("Điểm không được quá 10", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (diemDTO != null)
                    {
                        GetDiem();
                        if (diemBUS.checkDiem(txt_mshv.Text, txt_makh.Text) == 1)
                        {
                            int kq = diemBUS.updateDiem(diemDTO);
                            if (kq == 1)
                            {
                                XtraMessageBox.Show(string.Format("Sửa điểm cho học viên {0} thành công!", diemDTO.MSHV), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                RefreshTextbox();
                                LoadDSDiem();
                                //btn_themLopHoc.Enabled = false;
                                //btn_suaLopHoc.Enabled = true;
                                //dgcontrol_lopHoc.Enabled = true;
                            }
                            else
                            {
                                XtraMessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            int kq = diemBUS.addDiem(diemDTO);
                            if (kq == 1)
                            {
                                XtraMessageBox.Show(string.Format("Thêm điểm cho học viên {0} thành công!", diemDTO.MSHV), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                RefreshTextbox();
                                LoadDSDiem();
                                //btn_themLopHoc.Enabled = false;
                                //btn_suaLopHoc.Enabled = true;
                                //dgcontrol_lopHoc.Enabled = true;
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
        private void dgview_diemHocVien_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //try
            //{
            //    if(dgview_diemHocVien.SelectedRowsCount > 0)
            //    {
            //        int[] selectedRows = dgview_diemHocVien.GetSelectedRows();
            //        foreach (int rowHandle in selectedRows)
            //        {
            //            if (rowHandle >= 0)
            //            {
            //                diemDTO.MSHV = this.dgview_diemHocVien.GetRowCellValue(rowHandle, cl_mahv).ToString().Trim();
            //                diemDTO.MaKH = this.dgview_diemHocVien.GetRowCellValue(rowHandle, cl_maKH).ToString().Trim();
            //                diemDTO.Nghe = (float)this.dgview_diemHocVien.GetRowCellValue(rowHandle, cl_diemNghe);
            //                diemDTO.Noi = (float)this.dgview_diemHocVien.GetRowCellValue(rowHandle, cl_diemNoi);
            //                diemDTO.Doc = (float)this.dgview_diemHocVien.GetRowCellValue(rowHandle, cl_diemDoc);
            //                diemDTO.Viet = (float)this.dgview_diemHocVien.GetRowCellValue(rowHandle, cl_diemViet);
            //                diemBUS.updateDiem(diemDTO);
            //            }
            //        }
            //    }
            //}
            //catch (Exception er)
            //{
            //    XtraMessageBox.Show(er.Message);
            //}
        }
        private void GetDiem()
        {
            if (diemDTO != null)
            {
                diemDTO = new Diem_DTO();
            }
            diemDTO.MSHV = txt_mshv.Text;
            diemDTO.MaKH = txt_makh.Text;
            diemDTO.MaLop = txt_maLop.Text;
            diemDTO.Nghe = float.Parse(txt_diemNghe.Text);
            diemDTO.Noi = float.Parse(txt_diemNoi.Text);
            diemDTO.Doc = float.Parse(txt_diemDoc.Text);
            diemDTO.Viet = float.Parse(txt_diemViet.Text);
            diemDTO.DiemTB = TinhDiemTB(float.Parse(txt_diemNghe.Text), float.Parse(txt_diemNoi.Text), float.Parse(txt_diemDoc.Text), float.Parse(txt_diemViet.Text));
        }       
        private void BindingChiTiet()
        {
            if (diemDTO != null)
            {
                txt_mshv.Text = diemDTO.MSHV;
                txt_makh.Text = diemDTO.MaKH;
                txt_maLop.Text = diemDTO.MaLop;
                txt_diemNghe.EditValue = diemDTO.Nghe;
                txt_diemNoi.EditValue = diemDTO.Noi;
                txt_diemDoc.EditValue = diemDTO.Doc;
                txt_diemViet.EditValue = diemDTO.Viet;
            }
            else
            {
                txt_mshv.Text = string.Empty;
                txt_makh.Text = string.Empty;
                txt_maLop.Text = string.Empty;
                txt_diemNghe.EditValue = string.Empty;
                txt_diemNoi.EditValue = string.Empty;
                txt_diemDoc.EditValue = string.Empty;
                txt_diemViet.EditValue = string.Empty;
            }
        }
        private void RefreshTextbox()
        {
            txt_mshv.Text = string.Empty;
            txt_makh.Text = string.Empty;
            txt_maLop.Text = string.Empty;
            txt_diemNghe.Text = string.Empty;
            txt_diemNoi.Text = string.Empty;
            txt_diemDoc.Text = string.Empty;
            txt_diemViet.Text = string.Empty;
        }
        private void dgcontrol_diemHocVien_Click(object sender, EventArgs e)
        {
            if (dgview_diemHocVien.SelectedRowsCount > 0)
            {
                int[] selectedRows = dgview_diemHocVien.GetSelectedRows();
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                    {
                        diemDTO.MSHV = dgview_diemHocVien.GetRowCellValue(rowHandle, cl_mahv).ToString().Trim();
                        diemDTO.MaKH = dgview_diemHocVien.GetRowCellValue(rowHandle, cl_maKH).ToString().Trim();
                        diemDTO.MaLop = dgview_diemHocVien.GetRowCellValue(rowHandle, cl_maLop).ToString().Trim();
                        diemDTO.Nghe = (float)dgview_diemHocVien.GetRowCellValue(rowHandle, cl_diemNghe);
                        diemDTO.Noi = (float)dgview_diemHocVien.GetRowCellValue(rowHandle, cl_diemNoi);
                        diemDTO.Doc = float.Parse(dgview_diemHocVien.GetRowCellValue(rowHandle, cl_diemDoc).ToString());
                        diemDTO.Viet = float.Parse(dgview_diemHocVien.GetRowCellValue(rowHandle, cl_diemViet).ToString());
                    }
                }
            }
            else
            {
                khDTO = null;
            }
            BindingChiTiet();
        }
    }
}
