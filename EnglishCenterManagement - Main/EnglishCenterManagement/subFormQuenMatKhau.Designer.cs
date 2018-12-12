namespace EnglishCenterManagement
{
    partial class subFormQuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subFormQuenMatKhau));
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lb_nhapMKM = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_matKhauMoi = new DevExpress.XtraEditors.TextEdit();
            this.txt_tenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.btn_dong = new DevExpress.XtraEditors.SimpleButton();
            this.btn_resetMatKhau = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luuMatKhau = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_matKhauMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenDangNhap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Myriad Pro", 15F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(81, 16);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(152, 25);
            this.labelControl8.TabIndex = 73;
            this.labelControl8.Text = "QUÊN MẬT KHẨU";
            // 
            // lb_nhapMKM
            // 
            this.lb_nhapMKM.Location = new System.Drawing.Point(21, 113);
            this.lb_nhapMKM.Name = "lb_nhapMKM";
            this.lb_nhapMKM.Size = new System.Drawing.Size(91, 13);
            this.lb_nhapMKM.TabIndex = 68;
            this.lb_nhapMKM.Text = "Nhập mật khẩu mới";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 67;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // txt_matKhauMoi
            // 
            this.txt_matKhauMoi.Location = new System.Drawing.Point(118, 110);
            this.txt_matKhauMoi.Name = "txt_matKhauMoi";
            this.txt_matKhauMoi.Properties.UseSystemPasswordChar = true;
            this.txt_matKhauMoi.Size = new System.Drawing.Size(166, 20);
            this.txt_matKhauMoi.TabIndex = 64;
            // 
            // txt_tenDangNhap
            // 
            this.txt_tenDangNhap.Location = new System.Drawing.Point(118, 68);
            this.txt_tenDangNhap.Name = "txt_tenDangNhap";
            this.txt_tenDangNhap.Size = new System.Drawing.Size(166, 20);
            this.txt_tenDangNhap.TabIndex = 63;
            // 
            // btn_dong
            // 
            this.btn_dong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_dong.ImageOptions.Image")));
            this.btn_dong.Location = new System.Drawing.Point(183, 160);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(83, 42);
            this.btn_dong.TabIndex = 72;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_resetMatKhau
            // 
            this.btn_resetMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_resetMatKhau.ImageOptions.Image")));
            this.btn_resetMatKhau.Location = new System.Drawing.Point(41, 160);
            this.btn_resetMatKhau.Name = "btn_resetMatKhau";
            this.btn_resetMatKhau.Size = new System.Drawing.Size(136, 42);
            this.btn_resetMatKhau.TabIndex = 71;
            this.btn_resetMatKhau.Text = "Reset mật khẩu";
            this.btn_resetMatKhau.Click += new System.EventHandler(this.btn_resetMatKhau_Click);
            // 
            // btn_luuMatKhau
            // 
            this.btn_luuMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btn_luuMatKhau.Location = new System.Drawing.Point(41, 160);
            this.btn_luuMatKhau.Name = "btn_luuMatKhau";
            this.btn_luuMatKhau.Size = new System.Drawing.Size(136, 42);
            this.btn_luuMatKhau.TabIndex = 74;
            this.btn_luuMatKhau.Text = "Lưu mật khẩu";
            this.btn_luuMatKhau.Click += new System.EventHandler(this.btn_luuMatKhau_Click);
            // 
            // subFormQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 231);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.lb_nhapMKM);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_matKhauMoi);
            this.Controls.Add(this.txt_tenDangNhap);
            this.Controls.Add(this.btn_resetMatKhau);
            this.Controls.Add(this.btn_luuMatKhau);
            this.Name = "subFormQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.subFormQuenMatKhau_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.subFormQuenMatKhau_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.subFormQuenMatKhau_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.subFormQuenMatKhau_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.txt_matKhauMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenDangNhap.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btn_dong;
        private DevExpress.XtraEditors.SimpleButton btn_resetMatKhau;
        private DevExpress.XtraEditors.LabelControl lb_nhapMKM;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit txt_matKhauMoi;
        public DevExpress.XtraEditors.TextEdit txt_tenDangNhap;
        private DevExpress.XtraEditors.SimpleButton btn_luuMatKhau;
    }
}