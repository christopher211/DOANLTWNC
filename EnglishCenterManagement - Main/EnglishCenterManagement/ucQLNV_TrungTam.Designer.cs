namespace EnglishCenterManagement
{
    partial class ucQLNV_TrungTam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQLNV_TrungTam));
            this.dgcontrol_nhanVien = new DevExpress.XtraGrid.GridControl();
            this.dgview_nhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cl_manv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_ho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_gioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_ngaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_ngayLamViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_sdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_diaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_chucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_lamMoiNhanVien = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoaNhanVien = new DevExpress.XtraEditors.SimpleButton();
            this.btn_themGiaoVien = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_nhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_nhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgcontrol_nhanVien
            // 
            this.dgcontrol_nhanVien.Location = new System.Drawing.Point(3, 162);
            this.dgcontrol_nhanVien.MainView = this.dgview_nhanVien;
            this.dgcontrol_nhanVien.Name = "dgcontrol_nhanVien";
            this.dgcontrol_nhanVien.Size = new System.Drawing.Size(989, 369);
            this.dgcontrol_nhanVien.TabIndex = 7;
            this.dgcontrol_nhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgview_nhanVien});
            // 
            // dgview_nhanVien
            // 
            this.dgview_nhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.dgview_nhanVien.GridControl = this.dgcontrol_nhanVien;
            this.dgview_nhanVien.Name = "dgview_nhanVien";
            this.dgview_nhanVien.OptionsFind.AlwaysVisible = true;
            this.dgview_nhanVien.OptionsFind.FindFilterColumns = "*ID;MaNV;HoNV;TenNV;GioiTinh;NgaySinh;NgayLamViec;SDT;Email;DiaChi;ChucVu;";
            this.dgview_nhanVien.OptionsSelection.EnableAppearanceFocusedCell = false;
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
            // cl_ngayLamViec
            // 
            this.cl_ngayLamViec.Caption = "Ngày làm việc";
            this.cl_ngayLamViec.FieldName = "NgayLamViec";
            this.cl_ngayLamViec.Name = "cl_ngayLamViec";
            this.cl_ngayLamViec.OptionsColumn.AllowEdit = false;
            this.cl_ngayLamViec.OptionsColumn.AllowFocus = false;
            this.cl_ngayLamViec.Visible = true;
            this.cl_ngayLamViec.VisibleIndex = 5;
            this.cl_ngayLamViec.Width = 93;
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_lamMoiNhanVien);
            this.groupControl1.Controls.Add(this.btn_sua);
            this.groupControl1.Controls.Add(this.btn_xoaNhanVien);
            this.groupControl1.Controls.Add(this.btn_themGiaoVien);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(293, 76);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(423, 73);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Chức năng";
            // 
            // btn_lamMoiNhanVien
            // 
            this.btn_lamMoiNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_lamMoiNhanVien.ImageOptions.Image")));
            this.btn_lamMoiNhanVien.Location = new System.Drawing.Point(315, 24);
            this.btn_lamMoiNhanVien.Name = "btn_lamMoiNhanVien";
            this.btn_lamMoiNhanVien.Size = new System.Drawing.Size(93, 38);
            this.btn_lamMoiNhanVien.TabIndex = 3;
            this.btn_lamMoiNhanVien.Text = "Làm mới";
            this.btn_lamMoiNhanVien.Click += new System.EventHandler(this.btn_lamMoiNhanVien_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.ImageOptions.Image")));
            this.btn_sua.Location = new System.Drawing.Point(117, 24);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(93, 38);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoaNhanVien
            // 
            this.btn_xoaNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoaNhanVien.ImageOptions.Image")));
            this.btn_xoaNhanVien.Location = new System.Drawing.Point(216, 24);
            this.btn_xoaNhanVien.Name = "btn_xoaNhanVien";
            this.btn_xoaNhanVien.Size = new System.Drawing.Size(93, 38);
            this.btn_xoaNhanVien.TabIndex = 1;
            this.btn_xoaNhanVien.Text = "Xóa";
            this.btn_xoaNhanVien.Click += new System.EventHandler(this.btn_xoaNhanVien_Click);
            // 
            // btn_themGiaoVien
            // 
            this.btn_themGiaoVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_themGiaoVien.ImageOptions.Image")));
            this.btn_themGiaoVien.Location = new System.Drawing.Point(18, 24);
            this.btn_themGiaoVien.Name = "btn_themGiaoVien";
            this.btn_themGiaoVien.Size = new System.Drawing.Size(93, 38);
            this.btn_themGiaoVien.TabIndex = 0;
            this.btn_themGiaoVien.Text = "Thêm";
            this.btn_themGiaoVien.Click += new System.EventHandler(this.btn_themGiaoVien_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Myriad Pro", 25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(332, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(357, 41);
            this.labelControl2.TabIndex = 92;
            this.labelControl2.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // ucQLNV_TrungTam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dgcontrol_nhanVien);
            this.Name = "ucQLNV_TrungTam";
            this.Size = new System.Drawing.Size(995, 534);
            this.Load += new System.EventHandler(this.ucQLNV_TrungTam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_nhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_nhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl dgcontrol_nhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView dgview_nhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn cl_manv;
        private DevExpress.XtraGrid.Columns.GridColumn cl_ho;
        private DevExpress.XtraGrid.Columns.GridColumn cl_ten;
        private DevExpress.XtraGrid.Columns.GridColumn cl_gioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn cl_ngaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn cl_ngayLamViec;
        private DevExpress.XtraGrid.Columns.GridColumn cl_sdt;
        private DevExpress.XtraGrid.Columns.GridColumn cl_email;
        private DevExpress.XtraGrid.Columns.GridColumn cl_diaChi;
        private DevExpress.XtraGrid.Columns.GridColumn cl_chucVu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_lamMoiNhanVien;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private DevExpress.XtraEditors.SimpleButton btn_xoaNhanVien;
        private DevExpress.XtraEditors.SimpleButton btn_themGiaoVien;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}
