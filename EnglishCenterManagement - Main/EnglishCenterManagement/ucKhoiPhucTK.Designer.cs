namespace EnglishCenterManagement
{
    partial class ucKhoiPhucTK
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucKhoiPhucTK));
            this.dgcontrol_khoiPhucTK = new DevExpress.XtraGrid.GridControl();
            this.dgview_khoiPhucTK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cl_manv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_honv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_tennv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_tenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_matKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_loaiTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_lamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_khoiPhucTK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_khoiPhucTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_khoiPhucTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgcontrol_khoiPhucTK
            // 
            this.dgcontrol_khoiPhucTK.Location = new System.Drawing.Point(3, 184);
            this.dgcontrol_khoiPhucTK.MainView = this.dgview_khoiPhucTK;
            this.dgcontrol_khoiPhucTK.Name = "dgcontrol_khoiPhucTK";
            this.dgcontrol_khoiPhucTK.Size = new System.Drawing.Size(984, 347);
            this.dgcontrol_khoiPhucTK.TabIndex = 33;
            this.dgcontrol_khoiPhucTK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgview_khoiPhucTK});
            // 
            // dgview_khoiPhucTK
            // 
            this.dgview_khoiPhucTK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cl_manv,
            this.cl_honv,
            this.cl_tennv,
            this.cl_tenDangNhap,
            this.cl_matKhau,
            this.cl_loaiTK});
            this.dgview_khoiPhucTK.GridControl = this.dgcontrol_khoiPhucTK;
            this.dgview_khoiPhucTK.Name = "dgview_khoiPhucTK";
            this.dgview_khoiPhucTK.OptionsFind.FindFilterColumns = "*MaNV;TenNV;HoNV;TenDangNhap;MatKhau;ChucVu;";
            this.dgview_khoiPhucTK.OptionsFind.ShowFindButton = false;
            this.dgview_khoiPhucTK.OptionsSelection.EnableAppearanceFocusedCell = false;
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
            this.groupControl1.Controls.Add(this.btn_lamMoi);
            this.groupControl1.Controls.Add(this.btn_khoiPhucTK);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(408, 91);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(204, 70);
            this.groupControl1.TabIndex = 34;
            this.groupControl1.Text = "Chức năng";
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_lamMoi.ImageOptions.Image")));
            this.btn_lamMoi.Location = new System.Drawing.Point(104, 24);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(93, 38);
            this.btn_lamMoi.TabIndex = 3;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // btn_khoiPhucTK
            // 
            this.btn_khoiPhucTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_khoiPhucTK.ImageOptions.Image")));
            this.btn_khoiPhucTK.Location = new System.Drawing.Point(5, 24);
            this.btn_khoiPhucTK.Name = "btn_khoiPhucTK";
            this.btn_khoiPhucTK.Size = new System.Drawing.Size(93, 38);
            this.btn_khoiPhucTK.TabIndex = 1;
            this.btn_khoiPhucTK.Text = "Khôi phục";
            this.btn_khoiPhucTK.Click += new System.EventHandler(this.btn_khoiPhucTK_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Myriad Pro", 25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(256, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(522, 42);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "KHÔI PHỤC TÀI KHOẢN NHÂN VIÊN";
            // 
            // ucKhoiPhucTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgcontrol_khoiPhucTK);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl2);
            this.Name = "ucKhoiPhucTK";
            this.Size = new System.Drawing.Size(995, 534);
            this.Load += new System.EventHandler(this.ucKhoiPhucTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_khoiPhucTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_khoiPhucTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgcontrol_khoiPhucTK;
        private DevExpress.XtraGrid.Views.Grid.GridView dgview_khoiPhucTK;
        private DevExpress.XtraGrid.Columns.GridColumn cl_manv;
        private DevExpress.XtraGrid.Columns.GridColumn cl_honv;
        private DevExpress.XtraGrid.Columns.GridColumn cl_tennv;
        private DevExpress.XtraGrid.Columns.GridColumn cl_tenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn cl_matKhau;
        private DevExpress.XtraGrid.Columns.GridColumn cl_loaiTK;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_lamMoi;
        private DevExpress.XtraEditors.SimpleButton btn_khoiPhucTK;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}
