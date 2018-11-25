namespace EnglishCenterManagement
{
    partial class frmThemNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNhanVien));
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.dt_ngayLamViec = new DevExpress.XtraEditors.DateEdit();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.txt_diaChi = new DevExpress.XtraEditors.MemoEdit();
            this.btn_lamLai = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.txt_email = new DevExpress.XtraEditors.TextEdit();
            this.txt_sdt = new DevExpress.XtraEditors.TextEdit();
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
            this.txt_manv = new DevExpress.XtraEditors.TextEdit();
            this.cbo_gioiTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dt_ngaySinh = new DevExpress.XtraEditors.DateEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lke_chucVu = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngayLamViec.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngayLamViec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_gioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lke_chucVu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(362, 89);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(81, 13);
            this.labelControl12.TabIndex = 87;
            this.labelControl12.Text = "Ngày Làm Việc";
            // 
            // dt_ngayLamViec
            // 
            this.dt_ngayLamViec.EditValue = null;
            this.dt_ngayLamViec.Location = new System.Drawing.Point(458, 86);
            this.dt_ngayLamViec.Name = "dt_ngayLamViec";
            this.dt_ngayLamViec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngayLamViec.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngayLamViec.Properties.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.dt_ngayLamViec.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_ngayLamViec.Properties.EditFormat.FormatString = "";
            this.dt_ngayLamViec.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_ngayLamViec.Properties.Mask.EditMask = "";
            this.dt_ngayLamViec.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dt_ngayLamViec.Size = new System.Drawing.Size(191, 20);
            this.dt_ngayLamViec.TabIndex = 86;
            // 
            // btn_thoat
            // 
            this.btn_thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.ImageOptions.Image")));
            this.btn_thoat.Location = new System.Drawing.Point(407, 284);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(93, 38);
            this.btn_thoat.TabIndex = 83;
            this.btn_thoat.Text = "Đóng";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(458, 164);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_diaChi.Size = new System.Drawing.Size(191, 46);
            this.txt_diaChi.TabIndex = 75;
            // 
            // btn_lamLai
            // 
            this.btn_lamLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_lamLai.ImageOptions.Image")));
            this.btn_lamLai.Location = new System.Drawing.Point(308, 284);
            this.btn_lamLai.Name = "btn_lamLai";
            this.btn_lamLai.Size = new System.Drawing.Size(93, 38);
            this.btn_lamLai.TabIndex = 80;
            this.btn_lamLai.Text = "Làm lại";
            this.btn_lamLai.Click += new System.EventHandler(this.btn_lamLai_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.ImageOptions.Image")));
            this.btn_luu.Location = new System.Drawing.Point(209, 284);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(93, 38);
            this.btn_luu.TabIndex = 79;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(458, 138);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(191, 20);
            this.txt_email.TabIndex = 72;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(458, 112);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Properties.MaxLength = 10;
            this.txt_sdt.Size = new System.Drawing.Size(191, 20);
            this.txt_sdt.TabIndex = 71;
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdt_KeyPress);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(362, 167);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(39, 13);
            this.labelControl9.TabIndex = 84;
            this.labelControl9.Text = "Địa Chỉ";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(362, 141);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(30, 13);
            this.labelControl8.TabIndex = 82;
            this.labelControl8.Text = "Email";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(362, 115);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(23, 13);
            this.labelControl7.TabIndex = 81;
            this.labelControl7.Text = "SĐT";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(38, 193);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 13);
            this.labelControl6.TabIndex = 78;
            this.labelControl6.Text = "Ngày Sinh";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(38, 167);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 13);
            this.labelControl5.TabIndex = 77;
            this.labelControl5.Text = "Giới Tính";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(38, 141);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(21, 13);
            this.labelControl4.TabIndex = 76;
            this.labelControl4.Text = "Tên";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(38, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(15, 13);
            this.labelControl3.TabIndex = 74;
            this.labelControl3.Text = "Họ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(38, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 73;
            this.labelControl2.Text = "MSNV";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(112, 138);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(191, 20);
            this.txt_ten.TabIndex = 68;
            // 
            // txt_ho
            // 
            this.txt_ho.Location = new System.Drawing.Point(112, 112);
            this.txt_ho.Name = "txt_ho";
            this.txt_ho.Size = new System.Drawing.Size(191, 20);
            this.txt_ho.TabIndex = 67;
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(112, 86);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Properties.ReadOnly = true;
            this.txt_manv.Size = new System.Drawing.Size(191, 20);
            this.txt_manv.TabIndex = 66;
            // 
            // cbo_gioiTinh
            // 
            this.cbo_gioiTinh.Location = new System.Drawing.Point(112, 164);
            this.cbo_gioiTinh.Name = "cbo_gioiTinh";
            this.cbo_gioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_gioiTinh.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_gioiTinh.Size = new System.Drawing.Size(191, 20);
            this.cbo_gioiTinh.TabIndex = 69;
            // 
            // dt_ngaySinh
            // 
            this.dt_ngaySinh.EditValue = null;
            this.dt_ngaySinh.Location = new System.Drawing.Point(112, 190);
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
            this.dt_ngaySinh.Size = new System.Drawing.Size(191, 20);
            this.dt_ngaySinh.TabIndex = 70;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(224, 235);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(45, 13);
            this.labelControl10.TabIndex = 89;
            this.labelControl10.Text = "Chức Vụ";
            // 
            // lke_chucVu
            // 
            this.lke_chucVu.Location = new System.Drawing.Point(293, 232);
            this.lke_chucVu.Name = "lke_chucVu";
            this.lke_chucVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lke_chucVu.Properties.NullText = "";
            this.lke_chucVu.Size = new System.Drawing.Size(183, 20);
            this.lke_chucVu.TabIndex = 90;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Myriad Pro", 25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(237, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(263, 41);
            this.labelControl1.TabIndex = 91;
            this.labelControl1.Text = "THÊM NHÂN VIÊN";
            // 
            // frmThemNhanVien
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 359);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lke_chucVu);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.dt_ngayLamViec);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.txt_diaChi);
            this.Controls.Add(this.btn_lamLai);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_sdt);
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
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.cbo_gioiTinh);
            this.Controls.Add(this.dt_ngaySinh);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemNhanVien";
            this.Load += new System.EventHandler(this.frmThemNhanVien_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmThemNhanVien_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmThemNhanVien_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmThemNhanVien_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngayLamViec.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngayLamViec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_gioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lke_chucVu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.DateEdit dt_ngayLamViec;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.MemoEdit txt_diaChi;
        private DevExpress.XtraEditors.SimpleButton btn_lamLai;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
        private DevExpress.XtraEditors.TextEdit txt_email;
        private DevExpress.XtraEditors.TextEdit txt_sdt;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_ten;
        private DevExpress.XtraEditors.TextEdit txt_ho;
        private DevExpress.XtraEditors.TextEdit txt_manv;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_gioiTinh;
        private DevExpress.XtraEditors.DateEdit dt_ngaySinh;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LookUpEdit lke_chucVu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}