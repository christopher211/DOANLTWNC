namespace EnglishCenterManagement
{
    partial class frmThemKhoaHocChoHocVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemKhoaHocChoHocVien));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lke_lopHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.lke_khoaHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.txt_diaChi = new DevExpress.XtraEditors.MemoEdit();
            this.btn_lamLai = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.txt_email = new DevExpress.XtraEditors.TextEdit();
            this.txt_sdt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ten = new DevExpress.XtraEditors.TextEdit();
            this.txt_ho = new DevExpress.XtraEditors.TextEdit();
            this.txt_mshv = new DevExpress.XtraEditors.TextEdit();
            this.cbo_gioiTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dt_ngaySinh = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lke_lopHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lke_khoaHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mshv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_gioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaySinh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Myriad Pro", 25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(179, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(486, 42);
            this.labelControl1.TabIndex = 94;
            this.labelControl1.Text = "THÊM KHÓA HỌC CHO HỌC VIÊN";
            // 
            // lke_lopHoc
            // 
            this.lke_lopHoc.Location = new System.Drawing.Point(665, 117);
            this.lke_lopHoc.Name = "lke_lopHoc";
            this.lke_lopHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lke_lopHoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaLop", "Mã lớp"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenLop", "Tên lớp")});
            this.lke_lopHoc.Properties.NullText = "";
            this.lke_lopHoc.Size = new System.Drawing.Size(121, 20);
            this.lke_lopHoc.TabIndex = 93;
            // 
            // lke_khoaHoc
            // 
            this.lke_khoaHoc.Location = new System.Drawing.Point(665, 87);
            this.lke_khoaHoc.Name = "lke_khoaHoc";
            this.lke_khoaHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lke_khoaHoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKH", "Mã khóa học"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKH", "Tên khóa học")});
            this.lke_khoaHoc.Properties.NullText = "";
            this.lke_khoaHoc.Size = new System.Drawing.Size(121, 20);
            this.lke_khoaHoc.TabIndex = 92;
            this.lke_khoaHoc.EditValueChanged += new System.EventHandler(this.lke_khoaHoc_EditValueChanged);
            // 
            // btn_thoat
            // 
            this.btn_thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.ImageOptions.Image")));
            this.btn_thoat.Location = new System.Drawing.Point(471, 237);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(93, 38);
            this.btn_thoat.TabIndex = 88;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(387, 169);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Properties.ReadOnly = true;
            this.txt_diaChi.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_diaChi.Size = new System.Drawing.Size(191, 46);
            this.txt_diaChi.TabIndex = 80;
            // 
            // btn_lamLai
            // 
            this.btn_lamLai.Enabled = false;
            this.btn_lamLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_lamLai.ImageOptions.Image")));
            this.btn_lamLai.Location = new System.Drawing.Point(372, 237);
            this.btn_lamLai.Name = "btn_lamLai";
            this.btn_lamLai.Size = new System.Drawing.Size(93, 38);
            this.btn_lamLai.TabIndex = 85;
            this.btn_lamLai.Text = "Làm lại";
            // 
            // btn_luu
            // 
            this.btn_luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.ImageOptions.Image")));
            this.btn_luu.Location = new System.Drawing.Point(273, 237);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(93, 38);
            this.btn_luu.TabIndex = 84;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(387, 143);
            this.txt_email.Name = "txt_email";
            this.txt_email.Properties.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(191, 20);
            this.txt_email.TabIndex = 77;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(387, 117);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Properties.MaxLength = 10;
            this.txt_sdt.Properties.ReadOnly = true;
            this.txt_sdt.Size = new System.Drawing.Size(191, 20);
            this.txt_sdt.TabIndex = 76;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(603, 120);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(20, 13);
            this.labelControl11.TabIndex = 91;
            this.labelControl11.Text = "Lớp";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(603, 94);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(52, 13);
            this.labelControl10.TabIndex = 90;
            this.labelControl10.Text = "Khóa Học";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(315, 172);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(39, 13);
            this.labelControl9.TabIndex = 89;
            this.labelControl9.Text = "Địa Chỉ";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(315, 146);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(30, 13);
            this.labelControl8.TabIndex = 87;
            this.labelControl8.Text = "Email";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(315, 120);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(23, 13);
            this.labelControl7.TabIndex = 86;
            this.labelControl7.Text = "SĐT";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(315, 94);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 13);
            this.labelControl6.TabIndex = 83;
            this.labelControl6.Text = "Ngày Sinh";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(31, 172);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 13);
            this.labelControl5.TabIndex = 82;
            this.labelControl5.Text = "Giới Tính";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(31, 146);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(21, 13);
            this.labelControl4.TabIndex = 81;
            this.labelControl4.Text = "Tên";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(31, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(15, 13);
            this.labelControl3.TabIndex = 79;
            this.labelControl3.Text = "Họ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(31, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 78;
            this.labelControl2.Text = "MSHV";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(93, 143);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Properties.ReadOnly = true;
            this.txt_ten.Size = new System.Drawing.Size(191, 20);
            this.txt_ten.TabIndex = 73;
            // 
            // txt_ho
            // 
            this.txt_ho.Location = new System.Drawing.Point(93, 117);
            this.txt_ho.Name = "txt_ho";
            this.txt_ho.Properties.ReadOnly = true;
            this.txt_ho.Size = new System.Drawing.Size(191, 20);
            this.txt_ho.TabIndex = 72;
            // 
            // txt_mshv
            // 
            this.txt_mshv.Location = new System.Drawing.Point(93, 91);
            this.txt_mshv.Name = "txt_mshv";
            this.txt_mshv.Properties.ReadOnly = true;
            this.txt_mshv.Size = new System.Drawing.Size(191, 20);
            this.txt_mshv.TabIndex = 71;
            // 
            // cbo_gioiTinh
            // 
            this.cbo_gioiTinh.Location = new System.Drawing.Point(93, 169);
            this.cbo_gioiTinh.Name = "cbo_gioiTinh";
            this.cbo_gioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_gioiTinh.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_gioiTinh.Properties.ReadOnly = true;
            this.cbo_gioiTinh.Size = new System.Drawing.Size(191, 20);
            this.cbo_gioiTinh.TabIndex = 74;
            // 
            // dt_ngaySinh
            // 
            this.dt_ngaySinh.EditValue = null;
            this.dt_ngaySinh.Location = new System.Drawing.Point(387, 91);
            this.dt_ngaySinh.Name = "dt_ngaySinh";
            this.dt_ngaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngaySinh.Properties.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.dt_ngaySinh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_ngaySinh.Properties.EditFormat.FormatString = "";
            this.dt_ngaySinh.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_ngaySinh.Properties.Mask.EditMask = "";
            this.dt_ngaySinh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dt_ngaySinh.Properties.ReadOnly = true;
            this.dt_ngaySinh.Size = new System.Drawing.Size(191, 20);
            this.dt_ngaySinh.TabIndex = 75;
            // 
            // frmThemKhoaHocChoHocVien
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 301);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lke_lopHoc);
            this.Controls.Add(this.lke_khoaHoc);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.txt_diaChi);
            this.Controls.Add(this.btn_lamLai);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_ho);
            this.Controls.Add(this.txt_mshv);
            this.Controls.Add(this.cbo_gioiTinh);
            this.Controls.Add(this.dt_ngaySinh);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThemKhoaHocChoHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemKhoaHocChoHocVien";
            this.Load += new System.EventHandler(this.frmThemKhoaHocChoHocVien_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmThemKhoaHocChoHocVien_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmThemKhoaHocChoHocVien_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmThemKhoaHocChoHocVien_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.lke_lopHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lke_khoaHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mshv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_gioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaySinh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.LookUpEdit lke_lopHoc;
        public DevExpress.XtraEditors.LookUpEdit lke_khoaHoc;
        public DevExpress.XtraEditors.SimpleButton btn_thoat;
        public DevExpress.XtraEditors.MemoEdit txt_diaChi;
        public DevExpress.XtraEditors.SimpleButton btn_lamLai;
        public DevExpress.XtraEditors.SimpleButton btn_luu;
        public DevExpress.XtraEditors.TextEdit txt_email;
        public DevExpress.XtraEditors.TextEdit txt_sdt;
        public DevExpress.XtraEditors.LabelControl labelControl11;
        public DevExpress.XtraEditors.LabelControl labelControl10;
        public DevExpress.XtraEditors.LabelControl labelControl9;
        public DevExpress.XtraEditors.LabelControl labelControl8;
        public DevExpress.XtraEditors.LabelControl labelControl7;
        public DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.TextEdit txt_ten;
        public DevExpress.XtraEditors.TextEdit txt_ho;
        public DevExpress.XtraEditors.TextEdit txt_mshv;
        public DevExpress.XtraEditors.ComboBoxEdit cbo_gioiTinh;
        public DevExpress.XtraEditors.DateEdit dt_ngaySinh;
    }
}