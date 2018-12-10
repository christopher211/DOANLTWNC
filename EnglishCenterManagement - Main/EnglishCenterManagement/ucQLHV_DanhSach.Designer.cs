namespace EnglishCenterManagement
{
    partial class ucQLHV_DanhSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQLHV_DanhSach));
            this.dgcontrol_hocVien = new DevExpress.XtraGrid.GridControl();
            this.dgview_hocVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cl_mshv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_ho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_gioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbo_gioiTinh = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.cl_ngaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_sdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_diaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_khoaHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_maLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_makh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbo_khoaHoc = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.cbo_maLop = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_themKhoaHoc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_lamMoiHocVien = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoaHocVien = new DevExpress.XtraEditors.SimpleButton();
            this.btn_themHocVien = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_hocVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_hocVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_gioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_khoaHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_maLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgcontrol_hocVien
            // 
            this.dgcontrol_hocVien.Location = new System.Drawing.Point(3, 161);
            this.dgcontrol_hocVien.MainView = this.dgview_hocVien;
            this.dgcontrol_hocVien.Name = "dgcontrol_hocVien";
            this.dgcontrol_hocVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbo_gioiTinh,
            this.cbo_khoaHoc,
            this.cbo_maLop});
            this.dgcontrol_hocVien.Size = new System.Drawing.Size(989, 370);
            this.dgcontrol_hocVien.TabIndex = 10;
            this.dgcontrol_hocVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgview_hocVien});
            this.dgcontrol_hocVien.Load += new System.EventHandler(this.dgcontrol_hocVien_Load);
            // 
            // dgview_hocVien
            // 
            this.dgview_hocVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cl_mshv,
            this.cl_ho,
            this.cl_ten,
            this.cl_gioiTinh,
            this.cl_ngaySinh,
            this.cl_sdt,
            this.cl_email,
            this.cl_diaChi,
            this.cl_khoaHoc,
            this.cl_maLop,
            this.cl_makh});
            this.dgview_hocVien.GridControl = this.dgcontrol_hocVien;
            this.dgview_hocVien.Name = "dgview_hocVien";
            this.dgview_hocVien.OptionsEditForm.BindingMode = DevExpress.XtraGrid.Views.Grid.EditFormBindingMode.Direct;
            this.dgview_hocVien.OptionsFind.AlwaysVisible = true;
            this.dgview_hocVien.OptionsFind.FindFilterColumns = "*ID;MSHV;Ho;Ten;GioiTinh;NgaySinh;SDT;Email;DiaChi;KhoaHoc;MaLop;";
            this.dgview_hocVien.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // cl_mshv
            // 
            this.cl_mshv.Caption = "MSHV";
            this.cl_mshv.FieldName = "MSHV";
            this.cl_mshv.Name = "cl_mshv";
            this.cl_mshv.OptionsColumn.AllowEdit = false;
            this.cl_mshv.OptionsColumn.AllowFocus = false;
            this.cl_mshv.Visible = true;
            this.cl_mshv.VisibleIndex = 0;
            this.cl_mshv.Width = 55;
            // 
            // cl_ho
            // 
            this.cl_ho.Caption = "Họ";
            this.cl_ho.FieldName = "Ho";
            this.cl_ho.Name = "cl_ho";
            this.cl_ho.OptionsColumn.AllowEdit = false;
            this.cl_ho.OptionsColumn.AllowFocus = false;
            this.cl_ho.OptionsColumn.ReadOnly = true;
            this.cl_ho.Visible = true;
            this.cl_ho.VisibleIndex = 1;
            this.cl_ho.Width = 110;
            // 
            // cl_ten
            // 
            this.cl_ten.Caption = "Tên";
            this.cl_ten.FieldName = "Ten";
            this.cl_ten.Name = "cl_ten";
            this.cl_ten.OptionsColumn.AllowEdit = false;
            this.cl_ten.OptionsColumn.AllowFocus = false;
            this.cl_ten.OptionsColumn.ReadOnly = true;
            this.cl_ten.Visible = true;
            this.cl_ten.VisibleIndex = 2;
            this.cl_ten.Width = 93;
            // 
            // cl_gioiTinh
            // 
            this.cl_gioiTinh.Caption = "Giới Tính";
            this.cl_gioiTinh.ColumnEdit = this.cbo_gioiTinh;
            this.cl_gioiTinh.FieldName = "GioiTinh";
            this.cl_gioiTinh.Name = "cl_gioiTinh";
            this.cl_gioiTinh.OptionsColumn.AllowEdit = false;
            this.cl_gioiTinh.OptionsColumn.AllowFocus = false;
            this.cl_gioiTinh.OptionsColumn.ReadOnly = true;
            this.cl_gioiTinh.Visible = true;
            this.cl_gioiTinh.VisibleIndex = 3;
            this.cl_gioiTinh.Width = 56;
            // 
            // cbo_gioiTinh
            // 
            this.cbo_gioiTinh.AutoHeight = false;
            this.cbo_gioiTinh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_gioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_gioiTinh.Name = "cbo_gioiTinh";
            // 
            // cl_ngaySinh
            // 
            this.cl_ngaySinh.Caption = "Ngày Sinh";
            this.cl_ngaySinh.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.cl_ngaySinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.cl_ngaySinh.FieldName = "NgaySinh";
            this.cl_ngaySinh.Name = "cl_ngaySinh";
            this.cl_ngaySinh.OptionsColumn.AllowEdit = false;
            this.cl_ngaySinh.OptionsColumn.AllowFocus = false;
            this.cl_ngaySinh.OptionsColumn.ReadOnly = true;
            this.cl_ngaySinh.Visible = true;
            this.cl_ngaySinh.VisibleIndex = 4;
            this.cl_ngaySinh.Width = 97;
            // 
            // cl_sdt
            // 
            this.cl_sdt.Caption = "SĐT";
            this.cl_sdt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cl_sdt.FieldName = "SDT";
            this.cl_sdt.Name = "cl_sdt";
            this.cl_sdt.OptionsColumn.AllowEdit = false;
            this.cl_sdt.OptionsColumn.AllowFocus = false;
            this.cl_sdt.OptionsColumn.ReadOnly = true;
            this.cl_sdt.Visible = true;
            this.cl_sdt.VisibleIndex = 5;
            this.cl_sdt.Width = 97;
            // 
            // cl_email
            // 
            this.cl_email.Caption = "Email";
            this.cl_email.FieldName = "Email";
            this.cl_email.Name = "cl_email";
            this.cl_email.OptionsColumn.AllowEdit = false;
            this.cl_email.OptionsColumn.AllowFocus = false;
            this.cl_email.OptionsColumn.ReadOnly = true;
            this.cl_email.Visible = true;
            this.cl_email.VisibleIndex = 6;
            this.cl_email.Width = 116;
            // 
            // cl_diaChi
            // 
            this.cl_diaChi.Caption = "Địa Chỉ";
            this.cl_diaChi.FieldName = "DiaChi";
            this.cl_diaChi.Name = "cl_diaChi";
            this.cl_diaChi.OptionsColumn.AllowEdit = false;
            this.cl_diaChi.OptionsColumn.AllowFocus = false;
            this.cl_diaChi.OptionsColumn.ReadOnly = true;
            this.cl_diaChi.Visible = true;
            this.cl_diaChi.VisibleIndex = 7;
            this.cl_diaChi.Width = 153;
            // 
            // cl_khoaHoc
            // 
            this.cl_khoaHoc.Caption = "Khóa Học";
            this.cl_khoaHoc.FieldName = "TenKH";
            this.cl_khoaHoc.Name = "cl_khoaHoc";
            this.cl_khoaHoc.OptionsColumn.AllowEdit = false;
            this.cl_khoaHoc.OptionsColumn.AllowFocus = false;
            this.cl_khoaHoc.OptionsColumn.ReadOnly = true;
            this.cl_khoaHoc.Visible = true;
            this.cl_khoaHoc.VisibleIndex = 8;
            this.cl_khoaHoc.Width = 100;
            // 
            // cl_maLop
            // 
            this.cl_maLop.Caption = "Mã Lớp";
            this.cl_maLop.FieldName = "MaLop";
            this.cl_maLop.Name = "cl_maLop";
            this.cl_maLop.OptionsColumn.AllowEdit = false;
            this.cl_maLop.OptionsColumn.AllowFocus = false;
            this.cl_maLop.OptionsColumn.ReadOnly = true;
            this.cl_maLop.Visible = true;
            this.cl_maLop.VisibleIndex = 9;
            this.cl_maLop.Width = 91;
            // 
            // cl_makh
            // 
            this.cl_makh.FieldName = "MaKH";
            this.cl_makh.Name = "cl_makh";
            this.cl_makh.OptionsColumn.AllowEdit = false;
            this.cl_makh.OptionsColumn.AllowFocus = false;
            // 
            // cbo_khoaHoc
            // 
            this.cbo_khoaHoc.AutoHeight = false;
            this.cbo_khoaHoc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_khoaHoc.Name = "cbo_khoaHoc";
            // 
            // cbo_maLop
            // 
            this.cbo_maLop.AutoHeight = false;
            this.cbo_maLop.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_maLop.Name = "cbo_maLop";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_themKhoaHoc);
            this.groupControl1.Controls.Add(this.btn_lamMoiHocVien);
            this.groupControl1.Controls.Add(this.btn_sua);
            this.groupControl1.Controls.Add(this.btn_xoaHocVien);
            this.groupControl1.Controls.Add(this.btn_themHocVien);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(212, 62);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(555, 73);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Chức năng";
            // 
            // btn_themKhoaHoc
            // 
            this.btn_themKhoaHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_themKhoaHoc.ImageOptions.Image")));
            this.btn_themKhoaHoc.Location = new System.Drawing.Point(131, 25);
            this.btn_themKhoaHoc.Name = "btn_themKhoaHoc";
            this.btn_themKhoaHoc.Size = new System.Drawing.Size(119, 38);
            this.btn_themKhoaHoc.TabIndex = 40;
            this.btn_themKhoaHoc.Text = "Thêm khóa học";
            this.btn_themKhoaHoc.Click += new System.EventHandler(this.btn_themKhoaHoc_Click);
            // 
            // btn_lamMoiHocVien
            // 
            this.btn_lamMoiHocVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_lamMoiHocVien.ImageOptions.Image")));
            this.btn_lamMoiHocVien.Location = new System.Drawing.Point(454, 25);
            this.btn_lamMoiHocVien.Name = "btn_lamMoiHocVien";
            this.btn_lamMoiHocVien.Size = new System.Drawing.Size(93, 38);
            this.btn_lamMoiHocVien.TabIndex = 3;
            this.btn_lamMoiHocVien.Text = "Làm mới";
            this.btn_lamMoiHocVien.Click += new System.EventHandler(this.btn_lamMoiHocVien_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.ImageOptions.Image")));
            this.btn_sua.Location = new System.Drawing.Point(256, 25);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(93, 38);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoaHocVien
            // 
            this.btn_xoaHocVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoaHocVien.ImageOptions.Image")));
            this.btn_xoaHocVien.Location = new System.Drawing.Point(355, 25);
            this.btn_xoaHocVien.Name = "btn_xoaHocVien";
            this.btn_xoaHocVien.Size = new System.Drawing.Size(93, 38);
            this.btn_xoaHocVien.TabIndex = 1;
            this.btn_xoaHocVien.Text = "Xóa";
            this.btn_xoaHocVien.Click += new System.EventHandler(this.btn_xoaHocVien_Click);
            // 
            // btn_themHocVien
            // 
            this.btn_themHocVien.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btn_themHocVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_themHocVien.ImageOptions.Image")));
            this.btn_themHocVien.Location = new System.Drawing.Point(5, 25);
            this.btn_themHocVien.Name = "btn_themHocVien";
            this.btn_themHocVien.Size = new System.Drawing.Size(120, 38);
            this.btn_themHocVien.TabIndex = 0;
            this.btn_themHocVien.Text = "Thêm học viên";
            this.btn_themHocVien.Click += new System.EventHandler(this.btn_themHocVien_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Myriad Pro", 25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(327, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(333, 42);
            this.labelControl2.TabIndex = 31;
            this.labelControl2.Text = "DANH SÁCH HỌC VIÊN";
            // 
            // ucQLHV_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dgcontrol_hocVien);
            this.Name = "ucQLHV_DanhSach";
            this.Size = new System.Drawing.Size(995, 534);
            this.Load += new System.EventHandler(this.ucQLHV_DanhSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_hocVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_hocVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_gioiTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_khoaHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_maLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl dgcontrol_hocVien;
        private DevExpress.XtraGrid.Views.Grid.GridView dgview_hocVien;
        private DevExpress.XtraGrid.Columns.GridColumn cl_ho;
        private DevExpress.XtraGrid.Columns.GridColumn cl_ten;
        private DevExpress.XtraGrid.Columns.GridColumn cl_gioiTinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbo_gioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn cl_ngaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn cl_sdt;
        private DevExpress.XtraGrid.Columns.GridColumn cl_email;
        private DevExpress.XtraGrid.Columns.GridColumn cl_diaChi;
        private DevExpress.XtraGrid.Columns.GridColumn cl_khoaHoc;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbo_khoaHoc;
        private DevExpress.XtraGrid.Columns.GridColumn cl_maLop;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbo_maLop;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_themHocVien;
        private DevExpress.XtraEditors.SimpleButton btn_lamMoiHocVien;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private DevExpress.XtraEditors.SimpleButton btn_xoaHocVien;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn cl_mshv;
        private DevExpress.XtraGrid.Columns.GridColumn cl_makh;
        private DevExpress.XtraEditors.SimpleButton btn_themKhoaHoc;
    }
}
