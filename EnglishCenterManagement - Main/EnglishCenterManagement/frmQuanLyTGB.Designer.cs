namespace EnglishCenterManagement
{
    partial class frmQuanLyTGB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTGB));
            this.dgcontrol_thoiKhoaBieu = new DevExpress.XtraGrid.GridControl();
            this.dgview_thoiKhoaBieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cl_malop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_maphg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_manv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_thu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_thang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_nam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_timLop = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lke_maLop = new DevExpress.XtraEditors.LookUpEdit();
            this.txt_maphg = new DevExpress.XtraEditors.TextEdit();
            this.txt_manv = new DevExpress.XtraEditors.TextEdit();
            this.txt_nam = new DevExpress.XtraEditors.TextEdit();
            this.cb_thu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cb_ngay = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cb_thang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btn_lamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoaGiaoVien = new DevExpress.XtraEditors.SimpleButton();
            this.btn_themTKB = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_thoiKhoaBieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_thoiKhoaBieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lke_maLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maphg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_thu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_ngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_thang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgcontrol_thoiKhoaBieu
            // 
            this.dgcontrol_thoiKhoaBieu.Location = new System.Drawing.Point(12, 220);
            this.dgcontrol_thoiKhoaBieu.MainView = this.dgview_thoiKhoaBieu;
            this.dgcontrol_thoiKhoaBieu.Name = "dgcontrol_thoiKhoaBieu";
            this.dgcontrol_thoiKhoaBieu.Size = new System.Drawing.Size(1001, 323);
            this.dgcontrol_thoiKhoaBieu.TabIndex = 0;
            this.dgcontrol_thoiKhoaBieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgview_thoiKhoaBieu});
            this.dgcontrol_thoiKhoaBieu.Click += new System.EventHandler(this.dgcontrol_thoiKhoaBieu_Click);
            // 
            // dgview_thoiKhoaBieu
            // 
            this.dgview_thoiKhoaBieu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cl_malop,
            this.cl_maphg,
            this.cl_manv,
            this.cl_thu,
            this.cl_ngay,
            this.cl_thang,
            this.cl_nam});
            this.dgview_thoiKhoaBieu.GridControl = this.dgcontrol_thoiKhoaBieu;
            this.dgview_thoiKhoaBieu.Name = "dgview_thoiKhoaBieu";
            // 
            // cl_malop
            // 
            this.cl_malop.Caption = "Mã lớp";
            this.cl_malop.FieldName = "MaLop";
            this.cl_malop.Name = "cl_malop";
            this.cl_malop.OptionsColumn.AllowEdit = false;
            this.cl_malop.OptionsColumn.AllowFocus = false;
            this.cl_malop.OptionsColumn.ReadOnly = true;
            this.cl_malop.Visible = true;
            this.cl_malop.VisibleIndex = 0;
            this.cl_malop.Width = 140;
            // 
            // cl_maphg
            // 
            this.cl_maphg.Caption = "Mã phòng";
            this.cl_maphg.FieldName = "MaPhg";
            this.cl_maphg.Name = "cl_maphg";
            this.cl_maphg.OptionsColumn.AllowEdit = false;
            this.cl_maphg.OptionsColumn.AllowFocus = false;
            this.cl_maphg.OptionsColumn.ReadOnly = true;
            this.cl_maphg.Visible = true;
            this.cl_maphg.VisibleIndex = 1;
            this.cl_maphg.Width = 140;
            // 
            // cl_manv
            // 
            this.cl_manv.Caption = "Mã nhân viên";
            this.cl_manv.FieldName = "MaNV";
            this.cl_manv.Name = "cl_manv";
            this.cl_manv.OptionsColumn.AllowEdit = false;
            this.cl_manv.OptionsColumn.AllowFocus = false;
            this.cl_manv.OptionsColumn.ReadOnly = true;
            this.cl_manv.Visible = true;
            this.cl_manv.VisibleIndex = 2;
            this.cl_manv.Width = 140;
            // 
            // cl_thu
            // 
            this.cl_thu.Caption = "Thứ";
            this.cl_thu.FieldName = "Thu";
            this.cl_thu.Name = "cl_thu";
            this.cl_thu.OptionsColumn.AllowEdit = false;
            this.cl_thu.OptionsColumn.AllowFocus = false;
            this.cl_thu.OptionsColumn.ReadOnly = true;
            this.cl_thu.Visible = true;
            this.cl_thu.VisibleIndex = 3;
            this.cl_thu.Width = 137;
            // 
            // cl_ngay
            // 
            this.cl_ngay.Caption = "Ngày";
            this.cl_ngay.FieldName = "Ngay";
            this.cl_ngay.Name = "cl_ngay";
            this.cl_ngay.OptionsColumn.AllowEdit = false;
            this.cl_ngay.OptionsColumn.AllowFocus = false;
            this.cl_ngay.OptionsColumn.ReadOnly = true;
            this.cl_ngay.Visible = true;
            this.cl_ngay.VisibleIndex = 4;
            this.cl_ngay.Width = 140;
            // 
            // cl_thang
            // 
            this.cl_thang.Caption = "Tháng";
            this.cl_thang.FieldName = "Thang";
            this.cl_thang.Name = "cl_thang";
            this.cl_thang.OptionsColumn.AllowEdit = false;
            this.cl_thang.OptionsColumn.AllowFocus = false;
            this.cl_thang.OptionsColumn.ReadOnly = true;
            this.cl_thang.Visible = true;
            this.cl_thang.VisibleIndex = 5;
            this.cl_thang.Width = 140;
            // 
            // cl_nam
            // 
            this.cl_nam.Caption = "Năm";
            this.cl_nam.FieldName = "Nam";
            this.cl_nam.Name = "cl_nam";
            this.cl_nam.OptionsColumn.AllowEdit = false;
            this.cl_nam.OptionsColumn.AllowFocus = false;
            this.cl_nam.OptionsColumn.ReadOnly = true;
            this.cl_nam.Visible = true;
            this.cl_nam.VisibleIndex = 6;
            this.cl_nam.Width = 143;
            // 
            // btn_timLop
            // 
            this.btn_timLop.Location = new System.Drawing.Point(276, 33);
            this.btn_timLop.Name = "btn_timLop";
            this.btn_timLop.Size = new System.Drawing.Size(53, 20);
            this.btn_timLop.TabIndex = 45;
            this.btn_timLop.Text = "Tìm";
            this.btn_timLop.Click += new System.EventHandler(this.btn_timLop_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(20, 35);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 17);
            this.labelControl5.TabIndex = 44;
            this.labelControl5.Text = "Chọn lớp";
            // 
            // lke_maLop
            // 
            this.lke_maLop.Location = new System.Drawing.Point(102, 33);
            this.lke_maLop.Name = "lke_maLop";
            this.lke_maLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lke_maLop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaLop", "Mã lớp"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenLop", "Tên lớp")});
            this.lke_maLop.Properties.NullText = "";
            this.lke_maLop.Size = new System.Drawing.Size(161, 20);
            this.lke_maLop.TabIndex = 43;
            // 
            // txt_maphg
            // 
            this.txt_maphg.Location = new System.Drawing.Point(102, 59);
            this.txt_maphg.Name = "txt_maphg";
            this.txt_maphg.Size = new System.Drawing.Size(161, 20);
            this.txt_maphg.TabIndex = 47;
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(102, 85);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(161, 20);
            this.txt_manv.TabIndex = 48;
            // 
            // txt_nam
            // 
            this.txt_nam.Location = new System.Drawing.Point(239, 72);
            this.txt_nam.Name = "txt_nam";
            this.txt_nam.Size = new System.Drawing.Size(106, 20);
            this.txt_nam.TabIndex = 51;
            // 
            // cb_thu
            // 
            this.cb_thu.Location = new System.Drawing.Point(56, 46);
            this.cb_thu.Name = "cb_thu";
            this.cb_thu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_thu.Properties.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "CN"});
            this.cb_thu.Size = new System.Drawing.Size(106, 20);
            this.cb_thu.TabIndex = 53;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(20, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 16);
            this.labelControl1.TabIndex = 54;
            this.labelControl1.Text = "Mã phòng";
            // 
            // cb_ngay
            // 
            this.cb_ngay.Location = new System.Drawing.Point(56, 72);
            this.cb_ngay.Name = "cb_ngay";
            this.cb_ngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_ngay.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cb_ngay.Size = new System.Drawing.Size(106, 20);
            this.cb_ngay.TabIndex = 49;
            // 
            // cb_thang
            // 
            this.cb_thang.Location = new System.Drawing.Point(239, 46);
            this.cb_thang.Name = "cb_thang";
            this.cb_thang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_thang.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_thang.Size = new System.Drawing.Size(106, 20);
            this.cb_thang.TabIndex = 50;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lke_maLop);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btn_timLop);
            this.groupControl1.Controls.Add(this.txt_maphg);
            this.groupControl1.Controls.Add(this.txt_manv);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(48, 94);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(345, 120);
            this.groupControl1.TabIndex = 56;
            this.groupControl1.Text = "Thông tin lớp";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(20, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 16);
            this.labelControl2.TabIndex = 55;
            this.labelControl2.Text = "Mã nhân viên";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.cb_thang);
            this.groupControl2.Controls.Add(this.cb_ngay);
            this.groupControl2.Controls.Add(this.cb_thu);
            this.groupControl2.Controls.Add(this.txt_nam);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl2.Location = new System.Drawing.Point(399, 94);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(372, 120);
            this.groupControl2.TabIndex = 57;
            this.groupControl2.Text = "Thời gian";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(197, 47);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 16);
            this.labelControl7.TabIndex = 59;
            this.labelControl7.Text = "Tháng";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(22, 75);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 16);
            this.labelControl6.TabIndex = 58;
            this.labelControl6.Text = "Ngày";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(207, 73);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 16);
            this.labelControl4.TabIndex = 57;
            this.labelControl4.Text = "Năm";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(25, 47);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 14);
            this.labelControl3.TabIndex = 56;
            this.labelControl3.Text = "Thứ";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btn_lamMoi);
            this.groupControl3.Controls.Add(this.btn_sua);
            this.groupControl3.Controls.Add(this.btn_xoaGiaoVien);
            this.groupControl3.Controls.Add(this.btn_themTKB);
            this.groupControl3.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl3.Location = new System.Drawing.Point(777, 94);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(203, 120);
            this.groupControl3.TabIndex = 58;
            this.groupControl3.Text = "Chức năng";
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_lamMoi.ImageOptions.Image")));
            this.btn_lamMoi.Location = new System.Drawing.Point(104, 73);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(93, 38);
            this.btn_lamMoi.TabIndex = 3;
            this.btn_lamMoi.Text = "Làm mới";
            // 
            // btn_sua
            // 
            this.btn_sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.ImageOptions.Image")));
            this.btn_sua.Location = new System.Drawing.Point(5, 73);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(93, 38);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            // 
            // btn_xoaGiaoVien
            // 
            this.btn_xoaGiaoVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoaGiaoVien.ImageOptions.Image")));
            this.btn_xoaGiaoVien.Location = new System.Drawing.Point(104, 26);
            this.btn_xoaGiaoVien.Name = "btn_xoaGiaoVien";
            this.btn_xoaGiaoVien.Size = new System.Drawing.Size(93, 38);
            this.btn_xoaGiaoVien.TabIndex = 1;
            this.btn_xoaGiaoVien.Text = "Xóa";
            // 
            // btn_themTKB
            // 
            this.btn_themTKB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_themTKB.ImageOptions.Image")));
            this.btn_themTKB.Location = new System.Drawing.Point(5, 26);
            this.btn_themTKB.Name = "btn_themTKB";
            this.btn_themTKB.Size = new System.Drawing.Size(93, 38);
            this.btn_themTKB.TabIndex = 0;
            this.btn_themTKB.Text = "Thêm";
            this.btn_themTKB.Click += new System.EventHandler(this.btn_themTKB_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Myriad Pro", 25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(388, 22);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(251, 42);
            this.labelControl8.TabIndex = 59;
            this.labelControl8.Text = "THỜI KHÓA BIỂU";
            // 
            // frmQuanLyTGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 555);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dgcontrol_thoiKhoaBieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyTGB";
            this.Text = "frmQuanLyTGB";
            this.Load += new System.EventHandler(this.frmQuanLyTGB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_thoiKhoaBieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_thoiKhoaBieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lke_maLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maphg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_thu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_ngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_thang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgcontrol_thoiKhoaBieu;
        private DevExpress.XtraGrid.Views.Grid.GridView dgview_thoiKhoaBieu;
        private DevExpress.XtraGrid.Columns.GridColumn cl_malop;
        private DevExpress.XtraGrid.Columns.GridColumn cl_maphg;
        private DevExpress.XtraGrid.Columns.GridColumn cl_manv;
        private DevExpress.XtraGrid.Columns.GridColumn cl_thu;
        private DevExpress.XtraGrid.Columns.GridColumn cl_ngay;
        private DevExpress.XtraGrid.Columns.GridColumn cl_thang;
        private DevExpress.XtraGrid.Columns.GridColumn cl_nam;
        private DevExpress.XtraEditors.SimpleButton btn_timLop;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lke_maLop;
        private DevExpress.XtraEditors.TextEdit txt_maphg;
        private DevExpress.XtraEditors.TextEdit txt_manv;
        private DevExpress.XtraEditors.TextEdit txt_nam;
        private DevExpress.XtraEditors.ComboBoxEdit cb_thu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cb_ngay;
        private DevExpress.XtraEditors.ComboBoxEdit cb_thang;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btn_lamMoi;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private DevExpress.XtraEditors.SimpleButton btn_xoaGiaoVien;
        private DevExpress.XtraEditors.SimpleButton btn_themTKB;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}