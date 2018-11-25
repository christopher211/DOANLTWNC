namespace EnglishCenterManagement
{
    partial class subForm_TaoTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subForm_TaoTK));
            this.txt_taoTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.txt_taoMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_luuTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.btn_dong = new DevExpress.XtraEditors.SimpleButton();
            this.txt_manv = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_taoTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_taoMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manv.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_taoTenDangNhap
            // 
            this.txt_taoTenDangNhap.Location = new System.Drawing.Point(117, 63);
            this.txt_taoTenDangNhap.Name = "txt_taoTenDangNhap";
            this.txt_taoTenDangNhap.Size = new System.Drawing.Size(182, 20);
            this.txt_taoTenDangNhap.TabIndex = 0;
            // 
            // txt_taoMatKhau
            // 
            this.txt_taoMatKhau.Location = new System.Drawing.Point(117, 106);
            this.txt_taoMatKhau.Name = "txt_taoMatKhau";
            this.txt_taoMatKhau.Size = new System.Drawing.Size(182, 20);
            this.txt_taoMatKhau.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 109);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // btn_luuTaiKhoan
            // 
            this.btn_luuTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luuTaiKhoan.ImageOptions.Image")));
            this.btn_luuTaiKhoan.Location = new System.Drawing.Point(76, 167);
            this.btn_luuTaiKhoan.Name = "btn_luuTaiKhoan";
            this.btn_luuTaiKhoan.Size = new System.Drawing.Size(83, 42);
            this.btn_luuTaiKhoan.TabIndex = 4;
            this.btn_luuTaiKhoan.Text = "Lưu";
            this.btn_luuTaiKhoan.Click += new System.EventHandler(this.btn_luuTaiKhoan_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_dong.ImageOptions.Image")));
            this.btn_dong.Location = new System.Drawing.Point(178, 167);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(83, 42);
            this.btn_dong.TabIndex = 5;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(0, 223);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(134, 20);
            this.txt_manv.TabIndex = 6;
            // 
            // subForm_TaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 249);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_luuTaiKhoan);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_taoMatKhau);
            this.Controls.Add(this.txt_taoTenDangNhap);
            this.Name = "subForm_TaoTK";
            ((System.ComponentModel.ISupportInitialize)(this.txt_taoTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_taoMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manv.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_taoTenDangNhap;
        private DevExpress.XtraEditors.TextEdit txt_taoMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_luuTaiKhoan;
        private DevExpress.XtraEditors.SimpleButton btn_dong;
        public DevExpress.XtraEditors.TextEdit txt_manv;
    }
}
