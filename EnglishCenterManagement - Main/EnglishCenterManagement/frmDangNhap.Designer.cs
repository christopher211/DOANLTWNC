namespace EnglishCenterManagement
{
    partial class frmDangNhap
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
            this.btn_dangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btn_exit = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txt_tenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.txt_matKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chk_showHide = new DevExpress.XtraEditors.CheckEdit();
            this.lb_quenMatKhau = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lb_doiMatKhau = new DevExpress.XtraEditors.HyperlinkLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_matKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_showHide.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.Location = new System.Drawing.Point(125, 277);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(75, 23);
            this.btn_dangNhap.TabIndex = 3;
            this.btn_dangNhap.Text = "OK";
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(206, 277);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Location = new System.Drawing.Point(297, 147);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(8, 8);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(20, 20);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // txt_tenDangNhap
            // 
            this.txt_tenDangNhap.Location = new System.Drawing.Point(12, 50);
            this.txt_tenDangNhap.Name = "txt_tenDangNhap";
            this.txt_tenDangNhap.Size = new System.Drawing.Size(269, 20);
            this.txt_tenDangNhap.TabIndex = 0;
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.Location = new System.Drawing.Point(12, 95);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Size = new System.Drawing.Size(269, 20);
            this.txt_matKhau.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // chk_showHide
            // 
            this.chk_showHide.Location = new System.Drawing.Point(221, 121);
            this.chk_showHide.Name = "chk_showHide";
            this.chk_showHide.Properties.Caption = "Hiện/Ẩn";
            this.chk_showHide.Size = new System.Drawing.Size(60, 19);
            this.chk_showHide.TabIndex = 2;
            this.chk_showHide.CheckedChanged += new System.EventHandler(this.chk_showHide_CheckedChanged);
            // 
            // lb_quenMatKhau
            // 
            this.lb_quenMatKhau.Location = new System.Drawing.Point(12, 127);
            this.lb_quenMatKhau.Name = "lb_quenMatKhau";
            this.lb_quenMatKhau.Size = new System.Drawing.Size(78, 13);
            this.lb_quenMatKhau.TabIndex = 7;
            this.lb_quenMatKhau.Text = "Quên mật khẩu?";
            this.lb_quenMatKhau.Click += new System.EventHandler(this.lb_quenMatKhau_Click);
            // 
            // lb_doiMatKhau
            // 
            this.lb_doiMatKhau.Location = new System.Drawing.Point(12, 146);
            this.lb_doiMatKhau.Name = "lb_doiMatKhau";
            this.lb_doiMatKhau.Size = new System.Drawing.Size(63, 13);
            this.lb_doiMatKhau.TabIndex = 8;
            this.lb_doiMatKhau.Text = "Đổi mật khẩu";
            this.lb_doiMatKhau.Click += new System.EventHandler(this.lb_doiMatKhau_Click);
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btn_dangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 312);
            this.Controls.Add(this.lb_doiMatKhau);
            this.Controls.Add(this.lb_quenMatKhau);
            this.Controls.Add(this.chk_showHide);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_matKhau);
            this.Controls.Add(this.txt_tenDangNhap);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_dangNhap);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDangNhap_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmDangNhap_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmDangNhap_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_matKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_showHide.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_dangNhap;
        private DevExpress.XtraEditors.SimpleButton btn_exit;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txt_tenDangNhap;
        private DevExpress.XtraEditors.TextEdit txt_matKhau;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit chk_showHide;
        private DevExpress.XtraEditors.HyperlinkLabelControl lb_quenMatKhau;
        private DevExpress.XtraEditors.HyperlinkLabelControl lb_doiMatKhau;
    }
}