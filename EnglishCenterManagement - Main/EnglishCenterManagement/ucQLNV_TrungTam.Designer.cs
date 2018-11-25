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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txt_timNhanVienSDT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lke_timNhanVienChucVu = new DevExpress.XtraEditors.LookUpEdit();
            this.btn_timNhanVienSDT = new DevExpress.XtraEditors.SimpleButton();
            this.btn_timNhanVienChucVu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_timNhanVienHoTen = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_timNhanVienHoTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_timNhanVienMaNV = new DevExpress.XtraEditors.TextEdit();
            this.btn_timNhanVienMaNV = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_nhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_nhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timNhanVienSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lke_timNhanVienChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timNhanVienHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timNhanVienMaNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgcontrol_nhanVien
            // 
            this.dgcontrol_nhanVien.Location = new System.Drawing.Point(3, 230);
            this.dgcontrol_nhanVien.MainView = this.dgview_nhanVien;
            this.dgcontrol_nhanVien.Name = "dgcontrol_nhanVien";
            this.dgcontrol_nhanVien.Size = new System.Drawing.Size(989, 301);
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
            this.groupControl1.Location = new System.Drawing.Point(57, 86);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(204, 118);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Chức năng";
            // 
            // btn_lamMoiNhanVien
            // 
            this.btn_lamMoiNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_lamMoiNhanVien.ImageOptions.Image")));
            this.btn_lamMoiNhanVien.Location = new System.Drawing.Point(104, 72);
            this.btn_lamMoiNhanVien.Name = "btn_lamMoiNhanVien";
            this.btn_lamMoiNhanVien.Size = new System.Drawing.Size(93, 38);
            this.btn_lamMoiNhanVien.TabIndex = 3;
            this.btn_lamMoiNhanVien.Text = "Làm mới";
            this.btn_lamMoiNhanVien.Click += new System.EventHandler(this.btn_lamMoiNhanVien_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.ImageOptions.Image")));
            this.btn_sua.Location = new System.Drawing.Point(5, 72);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(93, 38);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoaNhanVien
            // 
            this.btn_xoaNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoaNhanVien.ImageOptions.Image")));
            this.btn_xoaNhanVien.Location = new System.Drawing.Point(104, 25);
            this.btn_xoaNhanVien.Name = "btn_xoaNhanVien";
            this.btn_xoaNhanVien.Size = new System.Drawing.Size(93, 38);
            this.btn_xoaNhanVien.TabIndex = 1;
            this.btn_xoaNhanVien.Text = "Xóa";
            this.btn_xoaNhanVien.Click += new System.EventHandler(this.btn_xoaNhanVien_Click);
            // 
            // btn_themGiaoVien
            // 
            this.btn_themGiaoVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_themGiaoVien.ImageOptions.Image")));
            this.btn_themGiaoVien.Location = new System.Drawing.Point(5, 25);
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
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txt_timNhanVienSDT);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.lke_timNhanVienChucVu);
            this.groupControl2.Controls.Add(this.btn_timNhanVienSDT);
            this.groupControl2.Controls.Add(this.btn_timNhanVienChucVu);
            this.groupControl2.Controls.Add(this.btn_timNhanVienHoTen);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.txt_timNhanVienHoTen);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.txt_timNhanVienMaNV);
            this.groupControl2.Controls.Add(this.btn_timNhanVienMaNV);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl2.Location = new System.Drawing.Point(305, 86);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(639, 118);
            this.groupControl2.TabIndex = 93;
            this.groupControl2.Text = "Tìm kiếm";
            // 
            // txt_timNhanVienSDT
            // 
            this.txt_timNhanVienSDT.Location = new System.Drawing.Point(398, 74);
            this.txt_timNhanVienSDT.Name = "txt_timNhanVienSDT";
            this.txt_timNhanVienSDT.Size = new System.Drawing.Size(148, 20);
            this.txt_timNhanVienSDT.TabIndex = 44;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(367, 76);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(25, 16);
            this.labelControl5.TabIndex = 43;
            this.labelControl5.Text = "SĐT";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(339, 39);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 17);
            this.labelControl4.TabIndex = 42;
            this.labelControl4.Text = "Chức vụ";
            // 
            // lke_timNhanVienChucVu
            // 
            this.lke_timNhanVienChucVu.Location = new System.Drawing.Point(398, 38);
            this.lke_timNhanVienChucVu.Name = "lke_timNhanVienChucVu";
            this.lke_timNhanVienChucVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lke_timNhanVienChucVu.Properties.NullText = "";
            this.lke_timNhanVienChucVu.Size = new System.Drawing.Size(148, 20);
            this.lke_timNhanVienChucVu.TabIndex = 37;
            // 
            // btn_timNhanVienSDT
            // 
            this.btn_timNhanVienSDT.Location = new System.Drawing.Point(552, 74);
            this.btn_timNhanVienSDT.Name = "btn_timNhanVienSDT";
            this.btn_timNhanVienSDT.Size = new System.Drawing.Size(66, 20);
            this.btn_timNhanVienSDT.TabIndex = 41;
            this.btn_timNhanVienSDT.Text = "Tìm";
            this.btn_timNhanVienSDT.Click += new System.EventHandler(this.btn_timNhanVienSDT_Click);
            // 
            // btn_timNhanVienChucVu
            // 
            this.btn_timNhanVienChucVu.Location = new System.Drawing.Point(552, 38);
            this.btn_timNhanVienChucVu.Name = "btn_timNhanVienChucVu";
            this.btn_timNhanVienChucVu.Size = new System.Drawing.Size(66, 20);
            this.btn_timNhanVienChucVu.TabIndex = 40;
            this.btn_timNhanVienChucVu.Text = "Tìm";
            this.btn_timNhanVienChucVu.Click += new System.EventHandler(this.btn_timNhanVienChucVu_Click);
            // 
            // btn_timNhanVienHoTen
            // 
            this.btn_timNhanVienHoTen.Location = new System.Drawing.Point(251, 74);
            this.btn_timNhanVienHoTen.Name = "btn_timNhanVienHoTen";
            this.btn_timNhanVienHoTen.Size = new System.Drawing.Size(66, 20);
            this.btn_timNhanVienHoTen.TabIndex = 37;
            this.btn_timNhanVienHoTen.Text = "Tìm";
            this.btn_timNhanVienHoTen.Click += new System.EventHandler(this.btn_timNhanVienHoTen_Click);
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
            // txt_timNhanVienHoTen
            // 
            this.txt_timNhanVienHoTen.Location = new System.Drawing.Point(85, 74);
            this.txt_timNhanVienHoTen.Name = "txt_timNhanVienHoTen";
            this.txt_timNhanVienHoTen.Size = new System.Drawing.Size(158, 20);
            this.txt_timNhanVienHoTen.TabIndex = 35;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(35, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 16);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "Mã NV";
            // 
            // txt_timNhanVienMaNV
            // 
            this.txt_timNhanVienMaNV.EditValue = "NV";
            this.txt_timNhanVienMaNV.Location = new System.Drawing.Point(85, 36);
            this.txt_timNhanVienMaNV.Name = "txt_timNhanVienMaNV";
            this.txt_timNhanVienMaNV.Properties.MaxLength = 4;
            this.txt_timNhanVienMaNV.Size = new System.Drawing.Size(158, 20);
            this.txt_timNhanVienMaNV.TabIndex = 32;
            // 
            // btn_timNhanVienMaNV
            // 
            this.btn_timNhanVienMaNV.Location = new System.Drawing.Point(251, 36);
            this.btn_timNhanVienMaNV.Name = "btn_timNhanVienMaNV";
            this.btn_timNhanVienMaNV.Size = new System.Drawing.Size(66, 20);
            this.btn_timNhanVienMaNV.TabIndex = 33;
            this.btn_timNhanVienMaNV.Text = "Tìm";
            this.btn_timNhanVienMaNV.Click += new System.EventHandler(this.btn_timNhanVienMaNV_Click);
            // 
            // ucQLNV_TrungTam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timNhanVienSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lke_timNhanVienChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timNhanVienHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timNhanVienMaNV.Properties)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lke_timNhanVienChucVu;
        private DevExpress.XtraEditors.SimpleButton btn_timNhanVienSDT;
        private DevExpress.XtraEditors.SimpleButton btn_timNhanVienChucVu;
        private DevExpress.XtraEditors.SimpleButton btn_timNhanVienHoTen;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_timNhanVienHoTen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_timNhanVienMaNV;
        private DevExpress.XtraEditors.SimpleButton btn_timNhanVienMaNV;
        private DevExpress.XtraEditors.TextEdit txt_timNhanVienSDT;
    }
}
