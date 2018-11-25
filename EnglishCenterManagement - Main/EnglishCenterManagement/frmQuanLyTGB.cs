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
    public partial class frmQuanLyTGB : DevExpress.XtraEditors.XtraForm
    {
        List<TKB_DTO> lsTKB;
        List<Lop_DTO> lsLop;

        Lop_BUS lopBUS = new Lop_BUS();
        Lop_DTO lopDTO = new Lop_DTO();

        TKB_BUS tkbBUS = new TKB_BUS();
        TKB_DTO tkbDTO = new TKB_DTO();

        public frmQuanLyTGB()
        {
            InitializeComponent();
        }

        private void frmQuanLyTGB_Load(object sender, EventArgs e)
        {
            LoadDSLop();
        }
        private void LoadDSLop()
        {
            lsLop = new List<Lop_DTO>();
            lsLop = lopBUS.DanhSachLop();

            lke_maLop.Properties.DataSource = lsLop;
            lke_maLop.Properties.DisplayMember = "MaLop";
            lke_maLop.Properties.ValueMember = "MaLop";
        }
        private void LoadTKB()
        {
            lsTKB = new List<TKB_DTO>();
            lsTKB = tkbBUS.DSThoiKhoaBieu(lke_maLop.Text.Trim());
            dgcontrol_thoiKhoaBieu.DataSource = lsTKB;
        }

        private void btn_timLop_Click(object sender, EventArgs e)
        {
            LoadTKB();
        }
    }
}