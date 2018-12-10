namespace EnglishCenterManagement
{
    partial class ucQLNV_DSNhanVienNghi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQLNV_DSNhanVienNghi));
            this.btn_khoiPhuc = new DevExpress.XtraEditors.SimpleButton();
            this.cl_chucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_diaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_sdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_ngayLamViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_ngaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_gioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_ho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_manv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgview_nvNghi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgcontrol_nvNghi = new DevExpress.XtraGrid.GridControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_lamMoi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_nvNghi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_nvNghi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_khoiPhuc
            // 
            this.btn_khoiPhuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_khoiPhuc.ImageOptions.Image")));
            this.btn_khoiPhuc.Location = new System.Drawing.Point(32, 37);
            this.btn_khoiPhuc.Name = "btn_khoiPhuc";
            this.btn_khoiPhuc.Size = new System.Drawing.Size(93, 38);
            this.btn_khoiPhuc.TabIndex = 2;
            this.btn_khoiPhuc.Text = "Khôi phục";
            this.btn_khoiPhuc.Click += new System.EventHandler(this.btn_khoiPhuc_Click);
            // 
            // cl_chucVu
            // 
            this.cl_chucVu.Caption = "Chức vụ";
            this.cl_chucVu.FieldName = "ChucVu";
            this.cl_chucVu.Name = "cl_chucVu";
            this.cl_chucVu.OptionsColumn.AllowEdit = false;
            this.cl_chucVu.OptionsColumn.AllowFocus = false;
            this.cl_chucVu.Visible = true;
            this.cl_chucVu.VisibleIndex = 9;
            this.cl_chucVu.Width = 129;
            // 
            // cl_diaChi
            // 
            this.cl_diaChi.Caption = "Địa chỉ";
            this.cl_diaChi.FieldName = "DiaChi";
            this.cl_diaChi.Name = "cl_diaChi";
            this.cl_diaChi.OptionsColumn.AllowEdit = false;
            this.cl_diaChi.OptionsColumn.AllowFocus = false;
            this.cl_diaChi.Visible = true;
            this.cl_diaChi.VisibleIndex = 8;
            this.cl_diaChi.Width = 93;
            // 
            // cl_email
            // 
            this.cl_email.Caption = "Email";
            this.cl_email.FieldName = "Email";
            this.cl_email.Name = "cl_email";
            this.cl_email.OptionsColumn.AllowEdit = false;
            this.cl_email.OptionsColumn.AllowFocus = false;
            this.cl_email.Visible = true;
            this.cl_email.VisibleIndex = 7;
            this.cl_email.Width = 93;
            // 
            // cl_sdt
            // 
            this.cl_sdt.Caption = "SĐT";
            this.cl_sdt.FieldName = "SDT";
            this.cl_sdt.Name = "cl_sdt";
            this.cl_sdt.OptionsColumn.AllowEdit = false;
            this.cl_sdt.OptionsColumn.AllowFocus = false;
            this.cl_sdt.Visible = true;
            this.cl_sdt.VisibleIndex = 6;
            this.cl_sdt.Width = 93;
            // 
            // cl_ngayLamViec
            // 
            this.cl_ngayLamViec.Caption = "Ngảy làm việc";
            this.cl_ngayLamViec.FieldName = "NgayLamViec";
            this.cl_ngayLamViec.Name = "cl_ngayLamViec";
            this.cl_ngayLamViec.OptionsColumn.AllowEdit = false;
            this.cl_ngayLamViec.OptionsColumn.AllowFocus = false;
            this.cl_ngayLamViec.Visible = true;
            this.cl_ngayLamViec.VisibleIndex = 5;
            this.cl_ngayLamViec.Width = 93;
            // 
            // cl_ngaySinh
            // 
            this.cl_ngaySinh.Caption = "Ngày sinh";
            this.cl_ngaySinh.FieldName = "NgaySinh";
            this.cl_ngaySinh.Name = "cl_ngaySinh";
            this.cl_ngaySinh.OptionsColumn.AllowEdit = false;
            this.cl_ngaySinh.OptionsColumn.AllowFocus = false;
            this.cl_ngaySinh.Visible = true;
            this.cl_ngaySinh.VisibleIndex = 4;
            this.cl_ngaySinh.Width = 93;
            // 
            // cl_gioiTinh
            // 
            this.cl_gioiTinh.Caption = "Giới tính";
            this.cl_gioiTinh.FieldName = "GioiTinh";
            this.cl_gioiTinh.Name = "cl_gioiTinh";
            this.cl_gioiTinh.OptionsColumn.AllowEdit = false;
            this.cl_gioiTinh.OptionsColumn.AllowFocus = false;
            this.cl_gioiTinh.Visible = true;
            this.cl_gioiTinh.VisibleIndex = 3;
            this.cl_gioiTinh.Width = 93;
            // 
            // cl_ten
            // 
            this.cl_ten.Caption = "Tên";
            this.cl_ten.FieldName = "TenNV";
            this.cl_ten.Name = "cl_ten";
            this.cl_ten.OptionsColumn.AllowEdit = false;
            this.cl_ten.OptionsColumn.AllowFocus = false;
            this.cl_ten.Visible = true;
            this.cl_ten.VisibleIndex = 2;
            this.cl_ten.Width = 93;
            // 
            // cl_ho
            // 
            this.cl_ho.Caption = "Họ";
            this.cl_ho.FieldName = "HoNV";
            this.cl_ho.Name = "cl_ho";
            this.cl_ho.OptionsColumn.AllowEdit = false;
            this.cl_ho.OptionsColumn.AllowFocus = false;
            this.cl_ho.Visible = true;
            this.cl_ho.VisibleIndex = 1;
            this.cl_ho.Width = 90;
            // 
            // cl_manv
            // 
            this.cl_manv.Caption = "Mã nhân viên";
            this.cl_manv.FieldName = "MaNV";
            this.cl_manv.Name = "cl_manv";
            this.cl_manv.OptionsColumn.AllowEdit = false;
            this.cl_manv.OptionsColumn.AllowFocus = false;
            this.cl_manv.Visible = true;
            this.cl_manv.VisibleIndex = 0;
            this.cl_manv.Width = 94;
            // 
            // dgview_nvNghi
            // 
            this.dgview_nvNghi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cl_manv,
            this.cl_ho,
            this.cl_ten,
            this.cl_gioiTinh,
            this.cl_ngaySinh,
            this.cl_ngayLamViec,
            this.cl_sdt,
            this.cl_email,
            this.cl_diaChi,
            this.cl_chucVu});
            this.dgview_nvNghi.GridControl = this.dgcontrol_nvNghi;
            this.dgview_nvNghi.Name = "dgview_nvNghi";
            this.dgview_nvNghi.OptionsFind.AlwaysVisible = true;
            this.dgview_nvNghi.OptionsFind.FindFilterColumns = "*ID;MaNV;HoNV;TenNV;GioiTinh;NgaySinh;NgayLamViec;SDT;Email;DiaChi;ChucVu;";
            this.dgview_nvNghi.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // dgcontrol_nvNghi
            // 
            this.dgcontrol_nvNghi.Location = new System.Drawing.Point(3, 192);
            this.dgcontrol_nvNghi.MainView = this.dgview_nvNghi;
            this.dgcontrol_nvNghi.Name = "dgcontrol_nvNghi";
            this.dgcontrol_nvNghi.Size = new System.Drawing.Size(989, 339);
            this.dgcontrol_nvNghi.TabIndex = 37;
            this.dgcontrol_nvNghi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgview_nvNghi});
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Myriad Pro", 25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(296, 18);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(443, 42);
            this.labelControl6.TabIndex = 40;
            this.labelControl6.Text = "DANH SÁCH NHÂN VIÊN NGHỈ";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_lamMoi);
            this.groupControl2.Controls.Add(this.btn_khoiPhuc);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl2.Location = new System.Drawing.Point(377, 78);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(256, 94);
            this.groupControl2.TabIndex = 39;
            this.groupControl2.Text = "Tìm kiếm";
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_lamMoi.ImageOptions.Image")));
            this.btn_lamMoi.Location = new System.Drawing.Point(131, 37);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(93, 38);
            this.btn_lamMoi.TabIndex = 45;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // ucQLNV_DSNhanVienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.dgcontrol_nvNghi);
            this.Controls.Add(this.labelControl6);
            this.Name = "ucQLNV_DSNhanVienNghi";
            this.Size = new System.Drawing.Size(995, 534);
            this.Load += new System.EventHandler(this.ucQLNV_DSNhanVienNghi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgview_nvNghi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_nvNghi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_khoiPhuc;
        private DevExpress.XtraGrid.Columns.GridColumn cl_chucVu;
        private DevExpress.XtraGrid.Columns.GridColumn cl_diaChi;
        private DevExpress.XtraGrid.Columns.GridColumn cl_email;
        private DevExpress.XtraGrid.Columns.GridColumn cl_sdt;
        private DevExpress.XtraGrid.Columns.GridColumn cl_ngayLamViec;
        private DevExpress.XtraGrid.Columns.GridColumn cl_ngaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn cl_gioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn cl_ten;
        private DevExpress.XtraGrid.Columns.GridColumn cl_ho;
        private DevExpress.XtraGrid.Columns.GridColumn cl_manv;
        private DevExpress.XtraGrid.Views.Grid.GridView dgview_nvNghi;
        private DevExpress.XtraGrid.GridControl dgcontrol_nvNghi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btn_lamMoi;
    }
}
