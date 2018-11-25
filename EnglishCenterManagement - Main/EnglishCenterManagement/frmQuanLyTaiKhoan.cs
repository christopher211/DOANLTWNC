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
    public partial class frmQuanLyTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        List<TaiKhoan_DTO> lsTaiKhoan;

        TaiKhoan_BUS tkBUS = new TaiKhoan_BUS();
        TaiKhoan_DTO tkDTO = new TaiKhoan_DTO();

        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadTK();
        }

        private void LoadTK()
        {
            lsTaiKhoan = new List<TaiKhoan_DTO>();
            lsTaiKhoan = tkBUS.danhsachTK();

            dgcontrol_taiKhoan.DataSource = lsTaiKhoan;
        }
        private void btn_themTaiKhoan_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan f = new frmThemTaiKhoan();
            f.ShowDialog();
        }
    }
}