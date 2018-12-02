namespace EnglishCenterManagement
{
    partial class frmQuanLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTaiKhoan));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btn_qlTaiKhoan = new DevExpress.XtraNavBar.NavBarItem();
            this.btn_khoiPhucTK = new DevExpress.XtraNavBar.NavBarItem();
            this.splitCC_quanLyTaiKhoan = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitCC_quanLyTaiKhoan)).BeginInit();
            this.splitCC_quanLyTaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btn_qlTaiKhoan,
            this.btn_khoiPhucTK});
            this.navBarControl1.Location = new System.Drawing.Point(3, 3);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.Size = new System.Drawing.Size(155, 531);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Springtime");
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Quản lý";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.ImageOptions.LargeImage")));
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btn_qlTaiKhoan),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btn_khoiPhucTK)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // btn_qlTaiKhoan
            // 
            this.btn_qlTaiKhoan.Caption = "Quản lý tài khoản";
            this.btn_qlTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_qlTaiKhoan.ImageOptions.LargeImage")));
            this.btn_qlTaiKhoan.Name = "btn_qlTaiKhoan";
            this.btn_qlTaiKhoan.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btn_qlTaiKhoan_LinkClicked);
            // 
            // btn_khoiPhucTK
            // 
            this.btn_khoiPhucTK.Caption = "Khôi phục tài khoản";
            this.btn_khoiPhucTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_khoiPhucTK.ImageOptions.LargeImage")));
            this.btn_khoiPhucTK.Name = "btn_khoiPhucTK";
            this.btn_khoiPhucTK.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btn_khoiPhucTK_LinkClicked);
            // 
            // splitCC_quanLyTaiKhoan
            // 
            this.splitCC_quanLyTaiKhoan.Location = new System.Drawing.Point(12, 12);
            this.splitCC_quanLyTaiKhoan.Name = "splitCC_quanLyTaiKhoan";
            this.splitCC_quanLyTaiKhoan.Panel1.Controls.Add(this.navBarControl1);
            this.splitCC_quanLyTaiKhoan.Panel1.Text = "Panel1";
            this.splitCC_quanLyTaiKhoan.Panel2.Text = "Panel2";
            this.splitCC_quanLyTaiKhoan.Size = new System.Drawing.Size(1165, 537);
            this.splitCC_quanLyTaiKhoan.SplitterPosition = 163;
            this.splitCC_quanLyTaiKhoan.TabIndex = 1;
            this.splitCC_quanLyTaiKhoan.Text = "splitContainerControl1";
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 561);
            this.Controls.Add(this.splitCC_quanLyTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyTaiKhoan";
            this.Text = "Quản lý tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitCC_quanLyTaiKhoan)).EndInit();
            this.splitCC_quanLyTaiKhoan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem btn_qlTaiKhoan;
        private DevExpress.XtraNavBar.NavBarItem btn_khoiPhucTK;
        private DevExpress.XtraEditors.SplitContainerControl splitCC_quanLyTaiKhoan;
    }
}