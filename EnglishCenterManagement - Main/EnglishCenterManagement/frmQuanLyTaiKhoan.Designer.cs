namespace EnglishCenterManagement
{
    partial class frmQuanLyTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTaiKhoan));
            this.dgcontrol_taiKhoan = new DevExpress.XtraGrid.GridControl();
            this.dgview_taiKhoan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cl_manv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_honv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_tennv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_tenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_matKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_loaiTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_themTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_taiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_taiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgcontrol_taiKhoan
            // 
            this.dgcontrol_taiKhoan.Location = new System.Drawing.Point(54, 176);
            this.dgcontrol_taiKhoan.MainView = this.dgview_taiKhoan;
            this.dgcontrol_taiKhoan.Name = "dgcontrol_taiKhoan";
            this.dgcontrol_taiKhoan.Size = new System.Drawing.Size(1017, 347);
            this.dgcontrol_taiKhoan.TabIndex = 0;
            this.dgcontrol_taiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgview_taiKhoan});
            // 
            // dgview_taiKhoan
            // 
            this.dgview_taiKhoan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cl_manv,
            this.cl_honv,
            this.cl_tennv,
            this.cl_tenDangNhap,
            this.cl_matKhau,
            this.cl_loaiTK});
            this.dgview_taiKhoan.GridControl = this.dgcontrol_taiKhoan;
            this.dgview_taiKhoan.Name = "dgview_taiKhoan";
            this.dgview_taiKhoan.OptionsFind.AlwaysVisible = true;
            this.dgview_taiKhoan.OptionsFind.FindFilterColumns = "*MaNV;TenNV;HoNV;TenDangNhap;MatKhau;ChucVu;";
            this.dgview_taiKhoan.OptionsFind.ShowFindButton = false;
            this.dgview_taiKhoan.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // cl_manv
            // 
            this.cl_manv.Caption = "MaNV";
            this.cl_manv.FieldName = "MaNV";
            this.cl_manv.Name = "cl_manv";
            this.cl_manv.OptionsColumn.AllowEdit = false;
            this.cl_manv.OptionsColumn.ReadOnly = true;
            this.cl_manv.Visible = true;
            this.cl_manv.VisibleIndex = 0;
            this.cl_manv.Width = 67;
            // 
            // cl_honv
            // 
            this.cl_honv.Caption = "Họ";
            this.cl_honv.FieldName = "HoNV";
            this.cl_honv.Name = "cl_honv";
            this.cl_honv.OptionsColumn.AllowEdit = false;
            this.cl_honv.OptionsColumn.ReadOnly = true;
            this.cl_honv.Visible = true;
            this.cl_honv.VisibleIndex = 1;
            this.cl_honv.Width = 153;
            // 
            // cl_tennv
            // 
            this.cl_tennv.Caption = "Tên";
            this.cl_tennv.FieldName = "TenNV";
            this.cl_tennv.Name = "cl_tennv";
            this.cl_tennv.OptionsColumn.AllowEdit = false;
            this.cl_tennv.OptionsColumn.ReadOnly = true;
            this.cl_tennv.Visible = true;
            this.cl_tennv.VisibleIndex = 2;
            this.cl_tennv.Width = 139;
            // 
            // cl_tenDangNhap
            // 
            this.cl_tenDangNhap.Caption = "Tên đăng nhập";
            this.cl_tenDangNhap.FieldName = "TenDangNhap";
            this.cl_tenDangNhap.Name = "cl_tenDangNhap";
            this.cl_tenDangNhap.OptionsColumn.AllowEdit = false;
            this.cl_tenDangNhap.OptionsColumn.ReadOnly = true;
            this.cl_tenDangNhap.Visible = true;
            this.cl_tenDangNhap.VisibleIndex = 3;
            this.cl_tenDangNhap.Width = 186;
            // 
            // cl_matKhau
            // 
            this.cl_matKhau.Caption = "Mật khẩu";
            this.cl_matKhau.FieldName = "MatKhau";
            this.cl_matKhau.Name = "cl_matKhau";
            this.cl_matKhau.OptionsColumn.AllowEdit = false;
            this.cl_matKhau.OptionsColumn.ReadOnly = true;
            this.cl_matKhau.Width = 211;
            // 
            // cl_loaiTK
            // 
            this.cl_loaiTK.Caption = "Loại tài khoản";
            this.cl_loaiTK.FieldName = "ChucVu";
            this.cl_loaiTK.Name = "cl_loaiTK";
            this.cl_loaiTK.OptionsColumn.AllowEdit = false;
            this.cl_loaiTK.OptionsColumn.ReadOnly = true;
            this.cl_loaiTK.Visible = true;
            this.cl_loaiTK.VisibleIndex = 4;
            this.cl_loaiTK.Width = 240;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton4);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.btn_themTaiKhoan);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(376, 81);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(402, 70);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Chức năng";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(302, 24);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(93, 38);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "Làm mới";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(203, 24);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(93, 38);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Cập nhật";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(104, 24);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(93, 38);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Xóa";
            // 
            // btn_themTaiKhoan
            // 
            this.btn_themTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_themTaiKhoan.ImageOptions.Image")));
            this.btn_themTaiKhoan.Location = new System.Drawing.Point(5, 24);
            this.btn_themTaiKhoan.Name = "btn_themTaiKhoan";
            this.btn_themTaiKhoan.Size = new System.Drawing.Size(93, 38);
            this.btn_themTaiKhoan.TabIndex = 0;
            this.btn_themTaiKhoan.Text = "Thêm";
            this.btn_themTaiKhoan.Click += new System.EventHandler(this.btn_themTaiKhoan_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(334, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(488, 35);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "DANH SÁCH TÀI KHOẢN NHÂN VIÊN";
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 568);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dgcontrol_taiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyTaiKhoan";
            this.Text = "frmQuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_taiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_taiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgcontrol_taiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView dgview_taiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn cl_tenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn cl_matKhau;
        private DevExpress.XtraGrid.Columns.GridColumn cl_loaiTK;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btn_themTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn cl_manv;
        private DevExpress.XtraGrid.Columns.GridColumn cl_honv;
        private DevExpress.XtraGrid.Columns.GridColumn cl_tennv;
    }
}