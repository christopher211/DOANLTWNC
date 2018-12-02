namespace EnglishCenterManagement
{
    partial class frmQuanLyKhoaHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyKhoaHoc));
            this.btn_lamMoiKhoaHoc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_suaKhoaHoc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoaKhoaHoc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_themKhoaHoc = new DevExpress.XtraEditors.SimpleButton();
            this.dgcontrol_khoaHoc = new DevExpress.XtraGrid.GridControl();
            this.dgview_khoaHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cl_makh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_tenkh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_ngayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_ngayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_hocPhi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_hocPhi = new DevExpress.XtraEditors.TextEdit();
            this.txt_tenkh = new DevExpress.XtraEditors.TextEdit();
            this.txt_makh = new DevExpress.XtraEditors.TextEdit();
            this.dt_ngayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.dt_ngayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_help = new DevExpress.XtraEditors.SimpleButton();
            this.btn_capNhatTGKH = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btn_timTenKH = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btn_timMakh = new DevExpress.XtraEditors.SimpleButton();
            this.txt_timTenKH = new DevExpress.XtraEditors.TextEdit();
            this.txt_timMaKH = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_khoaHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_khoaHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hocPhi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenkh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_makh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timMaKH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_lamMoiKhoaHoc
            // 
            this.btn_lamMoiKhoaHoc.ImageOptions.Image = global::EnglishCenterManagement.Properties.Resources.refresh;
            this.btn_lamMoiKhoaHoc.Location = new System.Drawing.Point(405, 24);
            this.btn_lamMoiKhoaHoc.Name = "btn_lamMoiKhoaHoc";
            this.btn_lamMoiKhoaHoc.Size = new System.Drawing.Size(93, 38);
            this.btn_lamMoiKhoaHoc.TabIndex = 3;
            this.btn_lamMoiKhoaHoc.Text = "Làm mới";
            this.btn_lamMoiKhoaHoc.ToolTip = "Làm mới: Để kích hoạt chức năng \"Thêm\" và đồng thời tạo ra mã khóa học mới";
            this.btn_lamMoiKhoaHoc.Click += new System.EventHandler(this.btn_lamMoiKhoaHoc_Click);
            // 
            // btn_suaKhoaHoc
            // 
            this.btn_suaKhoaHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_suaKhoaHoc.ImageOptions.Image")));
            this.btn_suaKhoaHoc.Location = new System.Drawing.Point(161, 25);
            this.btn_suaKhoaHoc.Name = "btn_suaKhoaHoc";
            this.btn_suaKhoaHoc.Size = new System.Drawing.Size(93, 38);
            this.btn_suaKhoaHoc.TabIndex = 2;
            this.btn_suaKhoaHoc.Text = "Sửa";
            this.btn_suaKhoaHoc.ToolTip = "Sửa: chọn 1 khóa học muốn chỉnh sửa trong danh sách, khóa học sẽ hiện lên các ô t" +
    "rống phía trên,\r\nchỉnh sửa thông tin cần thiết và ấn lại 1 lần nữa để lưu thông " +
    "tin vừa chỉnh sửa";
            this.btn_suaKhoaHoc.Click += new System.EventHandler(this.btn_suaKhoaHoc_Click);
            // 
            // btn_xoaKhoaHoc
            // 
            this.btn_xoaKhoaHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoaKhoaHoc.ImageOptions.Image")));
            this.btn_xoaKhoaHoc.Location = new System.Drawing.Point(283, 24);
            this.btn_xoaKhoaHoc.Name = "btn_xoaKhoaHoc";
            this.btn_xoaKhoaHoc.Size = new System.Drawing.Size(93, 38);
            this.btn_xoaKhoaHoc.TabIndex = 1;
            this.btn_xoaKhoaHoc.Text = "Xóa";
            this.btn_xoaKhoaHoc.ToolTip = "Xóa: chọn 1 khóa học muốn xóa trên danh sách và ấn để xóa";
            this.btn_xoaKhoaHoc.Click += new System.EventHandler(this.btn_xoaKhoaHoc_Click);
            // 
            // btn_themKhoaHoc
            // 
            this.btn_themKhoaHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_themKhoaHoc.ImageOptions.Image")));
            this.btn_themKhoaHoc.Location = new System.Drawing.Point(39, 25);
            this.btn_themKhoaHoc.Name = "btn_themKhoaHoc";
            this.btn_themKhoaHoc.Size = new System.Drawing.Size(93, 38);
            this.btn_themKhoaHoc.TabIndex = 0;
            this.btn_themKhoaHoc.Text = "Thêm";
            this.btn_themKhoaHoc.ToolTip = "Thêm: Để sử dụng, phải nhấn nút \"Làm mới\".\r\nSau khi nhập đầy đủ thông tin trên cá" +
    "c ô trống phía trên, ấn để thêm thông tin khóa học";
            this.btn_themKhoaHoc.Click += new System.EventHandler(this.btn_themKhoaHoc_Click);
            // 
            // dgcontrol_khoaHoc
            // 
            this.dgcontrol_khoaHoc.Location = new System.Drawing.Point(12, 227);
            this.dgcontrol_khoaHoc.MainView = this.dgview_khoaHoc;
            this.dgcontrol_khoaHoc.Name = "dgcontrol_khoaHoc";
            this.dgcontrol_khoaHoc.Size = new System.Drawing.Size(1135, 310);
            this.dgcontrol_khoaHoc.TabIndex = 14;
            this.dgcontrol_khoaHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgview_khoaHoc});
            this.dgcontrol_khoaHoc.Click += new System.EventHandler(this.dgcontrol_khoaHoc_Click);
            // 
            // dgview_khoaHoc
            // 
            this.dgview_khoaHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cl_makh,
            this.cl_tenkh,
            this.cl_ngayBatDau,
            this.cl_ngayKetThuc,
            this.cl_hocPhi});
            this.dgview_khoaHoc.GridControl = this.dgcontrol_khoaHoc;
            this.dgview_khoaHoc.Name = "dgview_khoaHoc";
            this.dgview_khoaHoc.OptionsEditForm.BindingMode = DevExpress.XtraGrid.Views.Grid.EditFormBindingMode.Direct;
            this.dgview_khoaHoc.OptionsFind.FindFilterColumns = "*ID;MSHV;Ho;Ten;GioiTinh;NgaySinh;SDT;Email;DiaChi;KhoaHoc;MaLop;";
            this.dgview_khoaHoc.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgview_khoaHoc.DoubleClick += new System.EventHandler(this.dgview_khoaHoc_DoubleClick);
            // 
            // cl_makh
            // 
            this.cl_makh.Caption = "Mã khóa học";
            this.cl_makh.FieldName = "MaKH";
            this.cl_makh.Name = "cl_makh";
            this.cl_makh.OptionsColumn.AllowEdit = false;
            this.cl_makh.OptionsColumn.AllowFocus = false;
            this.cl_makh.OptionsColumn.ReadOnly = true;
            this.cl_makh.Visible = true;
            this.cl_makh.VisibleIndex = 0;
            this.cl_makh.Width = 159;
            // 
            // cl_tenkh
            // 
            this.cl_tenkh.Caption = "Tên khóa học";
            this.cl_tenkh.FieldName = "TenKH";
            this.cl_tenkh.Name = "cl_tenkh";
            this.cl_tenkh.OptionsColumn.AllowEdit = false;
            this.cl_tenkh.OptionsColumn.AllowFocus = false;
            this.cl_tenkh.OptionsColumn.ReadOnly = true;
            this.cl_tenkh.Visible = true;
            this.cl_tenkh.VisibleIndex = 1;
            this.cl_tenkh.Width = 250;
            // 
            // cl_ngayBatDau
            // 
            this.cl_ngayBatDau.Caption = "Ngày bắt đầu";
            this.cl_ngayBatDau.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.cl_ngayBatDau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.cl_ngayBatDau.FieldName = "NgayBatDau";
            this.cl_ngayBatDau.Name = "cl_ngayBatDau";
            this.cl_ngayBatDau.OptionsColumn.AllowEdit = false;
            this.cl_ngayBatDau.OptionsColumn.AllowFocus = false;
            this.cl_ngayBatDau.OptionsColumn.ReadOnly = true;
            this.cl_ngayBatDau.Visible = true;
            this.cl_ngayBatDau.VisibleIndex = 2;
            this.cl_ngayBatDau.Width = 195;
            // 
            // cl_ngayKetThuc
            // 
            this.cl_ngayKetThuc.Caption = "Ngày kết thúc";
            this.cl_ngayKetThuc.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.cl_ngayKetThuc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.cl_ngayKetThuc.FieldName = "NgayKetThuc";
            this.cl_ngayKetThuc.Name = "cl_ngayKetThuc";
            this.cl_ngayKetThuc.OptionsColumn.AllowEdit = false;
            this.cl_ngayKetThuc.OptionsColumn.AllowFocus = false;
            this.cl_ngayKetThuc.OptionsColumn.ReadOnly = true;
            this.cl_ngayKetThuc.Visible = true;
            this.cl_ngayKetThuc.VisibleIndex = 3;
            this.cl_ngayKetThuc.Width = 249;
            // 
            // cl_hocPhi
            // 
            this.cl_hocPhi.Caption = "Học phí";
            this.cl_hocPhi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cl_hocPhi.FieldName = "HocPhi";
            this.cl_hocPhi.Name = "cl_hocPhi";
            this.cl_hocPhi.OptionsColumn.AllowEdit = false;
            this.cl_hocPhi.OptionsColumn.AllowFocus = false;
            this.cl_hocPhi.OptionsColumn.ReadOnly = true;
            this.cl_hocPhi.Visible = true;
            this.cl_hocPhi.VisibleIndex = 4;
            this.cl_hocPhi.Width = 261;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(379, 89);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Học phí";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(379, 63);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Ngày kết thúc";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(379, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 13);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Ngày bắt đầu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(55, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Tên khóa học";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(55, 50);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 13);
            this.labelControl6.TabIndex = 21;
            this.labelControl6.Text = "Mã khóa học";
            // 
            // txt_hocPhi
            // 
            this.txt_hocPhi.Location = new System.Drawing.Point(470, 86);
            this.txt_hocPhi.Name = "txt_hocPhi";
            this.txt_hocPhi.Properties.MaxLength = 8;
            this.txt_hocPhi.Size = new System.Drawing.Size(199, 20);
            this.txt_hocPhi.TabIndex = 20;
            this.txt_hocPhi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hocPhi_KeyPress);
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(146, 73);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(199, 20);
            this.txt_tenkh.TabIndex = 17;
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(146, 47);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Properties.ReadOnly = true;
            this.txt_makh.Size = new System.Drawing.Size(199, 20);
            this.txt_makh.TabIndex = 16;
            // 
            // dt_ngayBatDau
            // 
            this.dt_ngayBatDau.EditValue = null;
            this.dt_ngayBatDau.Location = new System.Drawing.Point(470, 34);
            this.dt_ngayBatDau.Name = "dt_ngayBatDau";
            this.dt_ngayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngayBatDau.Properties.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.dt_ngayBatDau.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_ngayBatDau.Properties.EditFormat.FormatString = "";
            this.dt_ngayBatDau.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_ngayBatDau.Properties.Mask.EditMask = "";
            this.dt_ngayBatDau.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dt_ngayBatDau.Size = new System.Drawing.Size(199, 20);
            this.dt_ngayBatDau.TabIndex = 18;
            // 
            // dt_ngayKetThuc
            // 
            this.dt_ngayKetThuc.EditValue = null;
            this.dt_ngayKetThuc.Location = new System.Drawing.Point(470, 60);
            this.dt_ngayKetThuc.Name = "dt_ngayKetThuc";
            this.dt_ngayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngayKetThuc.Properties.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.dt_ngayKetThuc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_ngayKetThuc.Properties.EditFormat.FormatString = "";
            this.dt_ngayKetThuc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_ngayKetThuc.Properties.Mask.EditMask = "";
            this.dt_ngayKetThuc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dt_ngayKetThuc.Size = new System.Drawing.Size(199, 20);
            this.dt_ngayKetThuc.TabIndex = 19;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.dt_ngayKetThuc);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.dt_ngayBatDau);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.txt_makh);
            this.groupControl2.Controls.Add(this.txt_tenkh);
            this.groupControl2.Controls.Add(this.txt_hocPhi);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl2.Location = new System.Drawing.Point(413, 28);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(734, 117);
            this.groupControl2.TabIndex = 26;
            this.groupControl2.Text = "Chi tiết khóa học";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_help);
            this.groupControl1.Controls.Add(this.btn_capNhatTGKH);
            this.groupControl1.Controls.Add(this.btn_lamMoiKhoaHoc);
            this.groupControl1.Controls.Add(this.btn_suaKhoaHoc);
            this.groupControl1.Controls.Add(this.btn_themKhoaHoc);
            this.groupControl1.Controls.Add(this.btn_xoaKhoaHoc);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(413, 151);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(734, 70);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Chức năng";
            // 
            // btn_help
            // 
            this.btn_help.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_help.ImageOptions.Image")));
            this.btn_help.Location = new System.Drawing.Point(690, 25);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(39, 38);
            this.btn_help.TabIndex = 5;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_capNhatTGKH
            // 
            this.btn_capNhatTGKH.ImageOptions.Image = global::EnglishCenterManagement.Properties.Resources.rotate;
            this.btn_capNhatTGKH.Location = new System.Drawing.Point(526, 24);
            this.btn_capNhatTGKH.Name = "btn_capNhatTGKH";
            this.btn_capNhatTGKH.Size = new System.Drawing.Size(93, 38);
            this.btn_capNhatTGKH.TabIndex = 4;
            this.btn_capNhatTGKH.Text = "Cập nhật";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Myriad Pro", 25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(37, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(350, 42);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "DANH SÁCH KHÓA HỌC";
            // 
            // groupControl3
            // 
            this.groupControl3.Location = new System.Drawing.Point(288, 104);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(8, 8);
            this.groupControl3.TabIndex = 31;
            this.groupControl3.Text = "groupControl3";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btn_timTenKH);
            this.groupControl4.Controls.Add(this.labelControl7);
            this.groupControl4.Controls.Add(this.labelControl9);
            this.groupControl4.Controls.Add(this.btn_timMakh);
            this.groupControl4.Controls.Add(this.txt_timTenKH);
            this.groupControl4.Controls.Add(this.txt_timMaKH);
            this.groupControl4.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl4.Location = new System.Drawing.Point(12, 104);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(395, 117);
            this.groupControl4.TabIndex = 32;
            this.groupControl4.Text = "Tìm kiếm";
            // 
            // btn_timTenKH
            // 
            this.btn_timTenKH.Location = new System.Drawing.Point(287, 67);
            this.btn_timTenKH.Name = "btn_timTenKH";
            this.btn_timTenKH.Size = new System.Drawing.Size(55, 20);
            this.btn_timTenKH.TabIndex = 30;
            this.btn_timTenKH.Text = "Tìm";
            this.btn_timTenKH.Click += new System.EventHandler(this.btn_timTenKH_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(25, 44);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 13);
            this.labelControl7.TabIndex = 26;
            this.labelControl7.Text = "Mã khóa học";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(25, 70);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(64, 13);
            this.labelControl9.TabIndex = 27;
            this.labelControl9.Text = "Tên khóa học";
            // 
            // btn_timMakh
            // 
            this.btn_timMakh.Location = new System.Drawing.Point(287, 41);
            this.btn_timMakh.Name = "btn_timMakh";
            this.btn_timMakh.Size = new System.Drawing.Size(55, 20);
            this.btn_timMakh.TabIndex = 29;
            this.btn_timMakh.Text = "Tìm";
            this.btn_timMakh.Click += new System.EventHandler(this.btn_timMakh_Click);
            // 
            // txt_timTenKH
            // 
            this.txt_timTenKH.Location = new System.Drawing.Point(109, 67);
            this.txt_timTenKH.Name = "txt_timTenKH";
            this.txt_timTenKH.Size = new System.Drawing.Size(160, 20);
            this.txt_timTenKH.TabIndex = 26;
            // 
            // txt_timMaKH
            // 
            this.txt_timMaKH.EditValue = "KH";
            this.txt_timMaKH.Location = new System.Drawing.Point(109, 41);
            this.txt_timMaKH.Name = "txt_timMaKH";
            this.txt_timMaKH.Size = new System.Drawing.Size(160, 20);
            this.txt_timMaKH.TabIndex = 0;
            // 
            // frmQuanLyKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 552);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dgcontrol_khoaHoc);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyKhoaHoc";
            this.Text = "Quản lý khóa học";
            this.Load += new System.EventHandler(this.frmQuanLyKhoaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_khoaHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_khoaHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hocPhi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenkh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_makh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngayKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timMaKH.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_lamMoiKhoaHoc;
        private DevExpress.XtraEditors.SimpleButton btn_suaKhoaHoc;
        private DevExpress.XtraEditors.SimpleButton btn_xoaKhoaHoc;
        private DevExpress.XtraEditors.SimpleButton btn_themKhoaHoc;
        private DevExpress.XtraGrid.GridControl dgcontrol_khoaHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView dgview_khoaHoc;
        private DevExpress.XtraGrid.Columns.GridColumn cl_makh;
        private DevExpress.XtraGrid.Columns.GridColumn cl_tenkh;
        private DevExpress.XtraGrid.Columns.GridColumn cl_ngayBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn cl_ngayKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn cl_hocPhi;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_hocPhi;
        private DevExpress.XtraEditors.TextEdit txt_tenkh;
        private DevExpress.XtraEditors.TextEdit txt_makh;
        private DevExpress.XtraEditors.DateEdit dt_ngayBatDau;
        private DevExpress.XtraEditors.DateEdit dt_ngayKetThuc;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btn_timTenKH;
        private DevExpress.XtraEditors.SimpleButton btn_timMakh;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txt_timTenKH;
        private DevExpress.XtraEditors.TextEdit txt_timMaKH;
        private DevExpress.XtraEditors.SimpleButton btn_capNhatTGKH;
        private DevExpress.XtraEditors.SimpleButton btn_help;
    }
}