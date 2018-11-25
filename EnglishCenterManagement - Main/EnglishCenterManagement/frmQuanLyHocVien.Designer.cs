namespace EnglishCenterManagement
{
    partial class frmQuanLyHocVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyHocVien));
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.splitCC_quanLyHocVien = new DevExpress.XtraEditors.SplitContainerControl();
            this.btn_dshv = new DevExpress.XtraNavBar.NavBarItem();
            this.btn_diem = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btn_dshvNghi = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitCC_quanLyHocVien)).BeginInit();
            this.splitCC_quanLyHocVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // splitCC_quanLyHocVien
            // 
            this.splitCC_quanLyHocVien.Location = new System.Drawing.Point(12, 12);
            this.splitCC_quanLyHocVien.Name = "splitCC_quanLyHocVien";
            this.splitCC_quanLyHocVien.Panel1.Text = "Panel1";
            this.splitCC_quanLyHocVien.Panel2.Text = "Panel2";
            this.splitCC_quanLyHocVien.Size = new System.Drawing.Size(1161, 537);
            this.splitCC_quanLyHocVien.SplitterPosition = 154;
            this.splitCC_quanLyHocVien.TabIndex = 0;
            this.splitCC_quanLyHocVien.Text = "splitContainerControl1";
            // 
            // btn_dshv
            // 
            this.btn_dshv.Caption = "Danh sách học viên";
            this.btn_dshv.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_dshv.ImageOptions.LargeImage")));
            this.btn_dshv.Name = "btn_dshv";
            this.btn_dshv.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btn_dshv_LinkClicked);
            // 
            // btn_diem
            // 
            this.btn_diem.Caption = "Điểm số";
            this.btn_diem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_diem.ImageOptions.LargeImage")));
            this.btn_diem.Name = "btn_diem";
            this.btn_diem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btn_diem_LinkClicked);
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Thêm học viên";
            this.navBarItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem3.ImageOptions.LargeImage")));
            this.navBarItem3.Name = "navBarItem3";
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Xóa";
            this.navBarItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem4.ImageOptions.LargeImage")));
            this.navBarItem4.Name = "navBarItem4";
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Cập nhật";
            this.navBarItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem5.ImageOptions.LargeImage")));
            this.navBarItem5.Name = "navBarItem5";
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "Làm mới";
            this.navBarItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem6.ImageOptions.LargeImage")));
            this.navBarItem6.Name = "navBarItem6";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Quản lý";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.ImageOptions.LargeImage")));
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btn_dshv),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btn_diem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btn_dshvNghi)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // btn_dshvNghi
            // 
            this.btn_dshvNghi.Caption = "Danh sách học viên đã nghỉ";
            this.btn_dshvNghi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_dshvNghi.ImageOptions.LargeImage")));
            this.btn_dshvNghi.Name = "btn_dshvNghi";
            this.btn_dshvNghi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btn_dshvNghi_LinkClicked);
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btn_dshv,
            this.btn_diem,
            this.navBarItem3,
            this.navBarItem4,
            this.navBarItem5,
            this.navBarItem6,
            this.btn_dshvNghi});
            this.navBarControl1.Location = new System.Drawing.Point(12, 15);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 155;
            this.navBarControl1.Size = new System.Drawing.Size(155, 531);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Office 2016 Dark");
            // 
            // frmQuanLyHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 561);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.splitCC_quanLyHocVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyHocVien";
            this.Text = "frmQuanLyHocVien";
            ((System.ComponentModel.ISupportInitialize)(this.splitCC_quanLyHocVien)).EndInit();
            this.splitCC_quanLyHocVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraEditors.SplitContainerControl splitCC_quanLyHocVien;
        private DevExpress.XtraNavBar.NavBarItem btn_dshv;
        private DevExpress.XtraNavBar.NavBarItem btn_diem;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarItem btn_dshvNghi;
    }
}