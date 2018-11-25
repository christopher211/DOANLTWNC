namespace EnglishCenterManagement
{
    partial class frmQuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNhanVien));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btn_qlnv_tt = new DevExpress.XtraNavBar.NavBarItem();
            this.btn_qlnv_gv = new DevExpress.XtraNavBar.NavBarItem();
            this.btn_qlnv_nghi = new DevExpress.XtraNavBar.NavBarItem();
            this.btn_themNhanVien = new DevExpress.XtraNavBar.NavBarItem();
            this.btn_xoaNhanVien = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.splitCC_quanLyNhanVien = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitCC_quanLyNhanVien)).BeginInit();
            this.splitCC_quanLyNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btn_qlnv_tt,
            this.btn_qlnv_gv,
            this.btn_themNhanVien,
            this.btn_xoaNhanVien,
            this.navBarItem3,
            this.navBarItem4,
            this.navBarItem1,
            this.btn_qlnv_nghi});
            this.navBarControl1.Location = new System.Drawing.Point(3, 3);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
            this.navBarControl1.Size = new System.Drawing.Size(140, 531);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Quản lý";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.ImageOptions.LargeImage")));
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btn_qlnv_tt),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btn_qlnv_gv),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btn_qlnv_nghi)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // btn_qlnv_tt
            // 
            this.btn_qlnv_tt.Caption = "Quản lý nhân viên";
            this.btn_qlnv_tt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_qlnv_tt.ImageOptions.LargeImage")));
            this.btn_qlnv_tt.Name = "btn_qlnv_tt";
            this.btn_qlnv_tt.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btn_qlnv_tt_LinkClicked);
            // 
            // btn_qlnv_gv
            // 
            this.btn_qlnv_gv.Caption = "Quản lý giáo viên";
            this.btn_qlnv_gv.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_qlnv_gv.ImageOptions.LargeImage")));
            this.btn_qlnv_gv.Name = "btn_qlnv_gv";
            this.btn_qlnv_gv.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btn_qlnv_gv_LinkClicked);
            // 
            // btn_qlnv_nghi
            // 
            this.btn_qlnv_nghi.Caption = "Danh sách nhân viên đã nghỉ";
            this.btn_qlnv_nghi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.ImageOptions.LargeImage")));
            this.btn_qlnv_nghi.Name = "btn_qlnv_nghi";
            this.btn_qlnv_nghi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btn_qlnv_nghi_LinkClicked);
            // 
            // btn_themNhanVien
            // 
            this.btn_themNhanVien.Name = "btn_themNhanVien";
            // 
            // btn_xoaNhanVien
            // 
            this.btn_xoaNhanVien.Name = "btn_xoaNhanVien";
            // 
            // navBarItem3
            // 
            this.navBarItem3.Name = "navBarItem3";
            // 
            // navBarItem4
            // 
            this.navBarItem4.Name = "navBarItem4";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "btn_xoaNhanVien";
            this.navBarItem1.Name = "navBarItem1";
            // 
            // splitCC_quanLyNhanVien
            // 
            this.splitCC_quanLyNhanVien.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitCC_quanLyNhanVien.IsSplitterFixed = true;
            this.splitCC_quanLyNhanVien.Location = new System.Drawing.Point(12, 12);
            this.splitCC_quanLyNhanVien.Name = "splitCC_quanLyNhanVien";
            this.splitCC_quanLyNhanVien.Panel1.Controls.Add(this.navBarControl1);
            this.splitCC_quanLyNhanVien.Panel1.Text = "Panel1";
            this.splitCC_quanLyNhanVien.Panel2.Text = "Panel2";
            this.splitCC_quanLyNhanVien.Size = new System.Drawing.Size(1161, 537);
            this.splitCC_quanLyNhanVien.SplitterPosition = 148;
            this.splitCC_quanLyNhanVien.TabIndex = 2;
            this.splitCC_quanLyNhanVien.Text = "splitContainerControl1";
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 561);
            this.Controls.Add(this.splitCC_quanLyNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyNhanVien";
            this.Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitCC_quanLyNhanVien)).EndInit();
            this.splitCC_quanLyNhanVien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem btn_qlnv_tt;
        private DevExpress.XtraNavBar.NavBarItem btn_qlnv_gv;
        private DevExpress.XtraEditors.SplitContainerControl splitCC_quanLyNhanVien;
        private DevExpress.XtraNavBar.NavBarItem btn_themNhanVien;
        private DevExpress.XtraNavBar.NavBarItem btn_xoaNhanVien;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem btn_qlnv_nghi;
    }
}