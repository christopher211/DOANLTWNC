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
            this.btn_timNVMaNV = new DevExpress.XtraEditors.SimpleButton();
            this.txt_timNVMaNV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_timNVHoTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_timNVHoTen = new DevExpress.XtraEditors.SimpleButton();
            this.btn_timNVSDT = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_timNVSDT = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_lamMoi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_nvNghi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_nvNghi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timNVMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timNVHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timNVSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_khoiPhuc
            // 
            this.btn_khoiPhuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_khoiPhuc.ImageOptions.Image")));
            this.btn_khoiPhuc.Location = new System.Drawing.Point(410, 66);
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
            this.dgview_nvNghi.OptionsFind.FindFilterColumns = "*ID;MaNV;HoNV;TenNV;GioiTinh;NgaySinh;NgayLamViec;SDT;Email;DiaChi;ChucVu;";
            this.dgview_nvNghi.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // dgcontrol_nvNghi
            // 
            this.dgcontrol_nvNghi.Location = new System.Drawing.Point(3, 230);
            this.dgcontrol_nvNghi.MainView = this.dgview_nvNghi;
            this.dgcontrol_nvNghi.Name = "dgcontrol_nvNghi";
            this.dgcontrol_nvNghi.Size = new System.Drawing.Size(989, 301);
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
            // btn_timNVMaNV
            // 
            this.btn_timNVMaNV.Location = new System.Drawing.Point(258, 36);
            this.btn_timNVMaNV.Name = "btn_timNVMaNV";
            this.btn_timNVMaNV.Size = new System.Drawing.Size(75, 20);
            this.btn_timNVMaNV.TabIndex = 33;
            this.btn_timNVMaNV.Text = "Tìm";
            this.btn_timNVMaNV.Click += new System.EventHandler(this.btn_timNVMaNV_Click);
            // 
            // txt_timNVMaNV
            // 
            this.txt_timNVMaNV.EditValue = "NV";
            this.txt_timNVMaNV.Location = new System.Drawing.Point(85, 36);
            this.txt_timNVMaNV.Name = "txt_timNVMaNV";
            this.txt_timNVMaNV.Properties.MaxLength = 4;
            this.txt_timNVMaNV.Size = new System.Drawing.Size(167, 20);
            this.txt_timNVMaNV.TabIndex = 32;
            this.txt_timNVMaNV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_timNVMaNV_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(35, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 16);
            this.labelControl2.TabIndex = 34;
            this.labelControl2.Text = "Mã NV";
            // 
            // txt_timNVHoTen
            // 
            this.txt_timNVHoTen.Location = new System.Drawing.Point(85, 74);
            this.txt_timNVHoTen.Name = "txt_timNVHoTen";
            this.txt_timNVHoTen.Size = new System.Drawing.Size(167, 20);
            this.txt_timNVHoTen.TabIndex = 35;
            this.txt_timNVHoTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_timNVHoTen_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(31, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 17);
            this.labelControl3.TabIndex = 36;
            this.labelControl3.Text = "Họ tên";
            // 
            // btn_timNVHoTen
            // 
            this.btn_timNVHoTen.Location = new System.Drawing.Point(258, 74);
            this.btn_timNVHoTen.Name = "btn_timNVHoTen";
            this.btn_timNVHoTen.Size = new System.Drawing.Size(75, 20);
            this.btn_timNVHoTen.TabIndex = 37;
            this.btn_timNVHoTen.Text = "Tìm";
            this.btn_timNVHoTen.Click += new System.EventHandler(this.btn_timNVHoTen_Click);
            // 
            // btn_timNVSDT
            // 
            this.btn_timNVSDT.Location = new System.Drawing.Point(258, 112);
            this.btn_timNVSDT.Name = "btn_timNVSDT";
            this.btn_timNVSDT.Size = new System.Drawing.Size(75, 20);
            this.btn_timNVSDT.TabIndex = 40;
            this.btn_timNVSDT.Text = "Tìm";
            this.btn_timNVSDT.Click += new System.EventHandler(this.btn_timNVSDT_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(47, 115);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(25, 16);
            this.labelControl5.TabIndex = 43;
            this.labelControl5.Text = "SĐT";
            // 
            // txt_timNVSDT
            // 
            this.txt_timNVSDT.Location = new System.Drawing.Point(85, 112);
            this.txt_timNVSDT.Name = "txt_timNVSDT";
            this.txt_timNVSDT.Size = new System.Drawing.Size(167, 20);
            this.txt_timNVSDT.TabIndex = 44;
            this.txt_timNVSDT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_timNVSDT_KeyDown);
            this.txt_timNVSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_timNVSDT_KeyPress);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_lamMoi);
            this.groupControl2.Controls.Add(this.btn_khoiPhuc);
            this.groupControl2.Controls.Add(this.txt_timNVSDT);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.btn_timNVSDT);
            this.groupControl2.Controls.Add(this.btn_timNVHoTen);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.txt_timNVHoTen);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.txt_timNVMaNV);
            this.groupControl2.Controls.Add(this.btn_timNVMaNV);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl2.Location = new System.Drawing.Point(179, 76);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(640, 148);
            this.groupControl2.TabIndex = 39;
            this.groupControl2.Text = "Tìm kiếm";
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_lamMoi.ImageOptions.Image")));
            this.btn_lamMoi.Location = new System.Drawing.Point(509, 66);
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
            ((System.ComponentModel.ISupportInitialize)(this.txt_timNVMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timNVHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timNVSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
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
        private DevExpress.XtraEditors.SimpleButton btn_timNVMaNV;
        private DevExpress.XtraEditors.TextEdit txt_timNVMaNV;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_timNVHoTen;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_timNVHoTen;
        private DevExpress.XtraEditors.SimpleButton btn_timNVSDT;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_timNVSDT;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btn_lamMoi;
    }
}
