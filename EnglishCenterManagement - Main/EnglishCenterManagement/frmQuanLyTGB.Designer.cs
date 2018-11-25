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
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_thoiKhoaBieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_thoiKhoaBieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lke_maLop.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgcontrol_thoiKhoaBieu
            // 
            this.dgcontrol_thoiKhoaBieu.Location = new System.Drawing.Point(12, 188);
            this.dgcontrol_thoiKhoaBieu.MainView = this.dgview_thoiKhoaBieu;
            this.dgcontrol_thoiKhoaBieu.Name = "dgcontrol_thoiKhoaBieu";
            this.dgcontrol_thoiKhoaBieu.Size = new System.Drawing.Size(1001, 323);
            this.dgcontrol_thoiKhoaBieu.TabIndex = 0;
            this.dgcontrol_thoiKhoaBieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgview_thoiKhoaBieu});
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
            this.btn_timLop.Location = new System.Drawing.Point(383, 91);
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
            this.labelControl5.Location = new System.Drawing.Point(136, 92);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 17);
            this.labelControl5.TabIndex = 44;
            this.labelControl5.Text = "Chọn lớp";
            // 
            // lke_maLop
            // 
            this.lke_maLop.Location = new System.Drawing.Point(209, 91);
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
            // frmQuanLyTGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 523);
            this.Controls.Add(this.btn_timLop);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lke_maLop);
            this.Controls.Add(this.dgcontrol_thoiKhoaBieu);
            this.Name = "frmQuanLyTGB";
            this.Text = "frmQuanLyTGB";
            this.Load += new System.EventHandler(this.frmQuanLyTGB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_thoiKhoaBieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_thoiKhoaBieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lke_maLop.Properties)).EndInit();
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
    }
}