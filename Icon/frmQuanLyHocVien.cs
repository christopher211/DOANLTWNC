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
using DevExpress.XtraBars.Customization;

namespace EnglishCenterManagement
{
    public partial class frmQuanLyHocVien : DevExpress.XtraEditors.XtraForm
    {
        public int index;
        

        List<KhoaHoc_DTO> lsKhoaHoc;
        List<Lop_DTO> lsLop;
        List<HocVien_DTO> lsHocVien;

        HocVien_BUS hvBUS = new HocVien_BUS();
        HocVien_DTO hvDTO = new HocVien_DTO();

        KhoaHoc_BUS khBUS = new KhoaHoc_BUS();
        KhoaHoc_DTO khDTO = new KhoaHoc_DTO();

        Lop_BUS lopBUS = new Lop_BUS();
        Lop_DTO lopDTO = new Lop_DTO();

        public frmQuanLyHocVien()
        {
            InitializeComponent();
            LoadDSHV();
        }

        public void LoadDSHV()
        {
            List<HocVien_DTO> lsHocVien = new List<HocVien_DTO>();
            
                lsHocVien = hvBUS.DanhSachHV();
                dgcontrol_hocVien.DataSource = lsHocVien;
           
            
        }
        private void LoadDSKhoaHoc()
        {
            KhoaHoc_BUS khBUS = new KhoaHoc_BUS();
            KhoaHoc_DTO khDTO = new KhoaHoc_DTO();
            lsKhoaHoc = khBUS.DanhSachKH();
            

            //cbo_khoaHoc.DataSource = lsKhoaHoc;
            //cbo_khoaHoc.DisplayMember = "TenKH";
            //cbo_khoaHoc.ValueMember = "MaKH";

            //cbo_searchKhoaHoc.DataSource = lsKhoaHoc;
            //cbo_searchKhoaHoc.DisplayMember = "TenKH";
            //cbo_searchKhoaHoc.ValueMember = "MaKH";
        }
        private void LoadDSLop()
        {
            Lop_BUS lopBUS = new Lop_BUS();
            Lop_DTO lopDAO = new Lop_DTO();
            lsLop = lopBUS.DanhSachLop();
            
            //cbo_maLop.DataSource = lsLop;
            //cbo_maLop.DisplayMember = "MaLop";
            //cbo_maLop.ValueMember = "MaLop";

            //cbo_searchLop.DataSource = lsLop;
            //cbo_searchLop.DisplayMember = "MaLop";
            //cbo_searchLop.ValueMember = "MaLop";
        }
        
        private void btn_themHocVien_Click(object sender, EventArgs e)
        {
            hvBUS = new HocVien_BUS();
            if (hvDTO!=null)
            {
                formThem frmt = new formThem();
                frmt.Show();
                if(frmt.them==1)
                {
                    frmt.Close();
                    LoadDSHV();
                }
            }
           
            
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            
        }

        private void frmQuanLyHocVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trungTamNgoaiNguDataSet.HocVien' table. You can move, or remove it, as needed.
            this.hocVienTableAdapter.Fill(this.trungTamNgoaiNguDataSet.HocVien);

        }

        private void btn_xoaHocVien_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount> 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa học viên này ?","Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if(result==DialogResult.Yes)
                {

                    if (hvBUS.XoaHV(hvDTO.MSHV))
                    {
                        MessageBox.Show("Xóa thành công !", "Thông báo");
                        LoadDSHV();
                    }
                }
                else
                {
                    MessageBox.Show("Xóa thất bại ");
                }
                
            }
        }

        private void dgcontrol_hocVien_ProcessGridKey(object sender, KeyEventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            formThem frmThem = new formThem();
            frmThem.luu = false;
            frmThem.mshv = gridView1.GetRowCellValue(index,"cl_mshv").ToString();
            XtraMessageBox.Show(gridView1.GetRowCellValue(index,"cl_mshv").ToString());
            frmThem.Show();  
        }
    }
}