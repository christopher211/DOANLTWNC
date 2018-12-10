namespace EnglishCenterManagement
{
    partial class frmThemTaiKhoan
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
            this.dgcontrol_chuaCoTK = new DevExpress.XtraGrid.GridControl();
            this.dgview_chuaCoTK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cl_manv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_honv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_tennv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_chucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_chuaCoTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_chuaCoTK)).BeginInit();
            this.SuspendLayout();
            // 
            // dgcontrol_chuaCoTK
            // 
            this.dgcontrol_chuaCoTK.Location = new System.Drawing.Point(12, 111);
            this.dgcontrol_chuaCoTK.MainView = this.dgview_chuaCoTK;
            this.dgcontrol_chuaCoTK.Name = "dgcontrol_chuaCoTK";
            this.dgcontrol_chuaCoTK.Size = new System.Drawing.Size(677, 349);
            this.dgcontrol_chuaCoTK.TabIndex = 0;
            this.dgcontrol_chuaCoTK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgview_chuaCoTK});
            this.dgcontrol_chuaCoTK.DoubleClick += new System.EventHandler(this.dgcontrol_chuaCoTK_DoubleClick);
            // 
            // dgview_chuaCoTK
            // 
            this.dgview_chuaCoTK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cl_manv,
            this.cl_honv,
            this.cl_tennv,
            this.cl_chucVu});
            this.dgview_chuaCoTK.GridControl = this.dgcontrol_chuaCoTK;
            this.dgview_chuaCoTK.Name = "dgview_chuaCoTK";
            this.dgview_chuaCoTK.OptionsBehavior.ReadOnly = true;
            this.dgview_chuaCoTK.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // cl_manv
            // 
            this.cl_manv.Caption = "Mã nhân viên";
            this.cl_manv.FieldName = "MaNV";
            this.cl_manv.Name = "cl_manv";
            this.cl_manv.OptionsColumn.AllowEdit = false;
            this.cl_manv.OptionsColumn.ReadOnly = true;
            this.cl_manv.Visible = true;
            this.cl_manv.VisibleIndex = 0;
            // 
            // cl_honv
            // 
            this.cl_honv.Caption = "Họ";
            this.cl_honv.FieldName = "HoNV";
            this.cl_honv.Name = "cl_honv";
            this.cl_honv.OptionsColumn.AllowEdit = false;
            this.cl_honv.OptionsColumn.ReadOnly = true;
            this.cl_honv.Visible = true;
            this.cl_honv.VisibleIndex = 1;
            // 
            // cl_tennv
            // 
            this.cl_tennv.Caption = "Tên";
            this.cl_tennv.FieldName = "TenNV";
            this.cl_tennv.Name = "cl_tennv";
            this.cl_tennv.OptionsColumn.AllowEdit = false;
            this.cl_tennv.OptionsColumn.ReadOnly = true;
            this.cl_tennv.Visible = true;
            this.cl_tennv.VisibleIndex = 2;
            // 
            // cl_chucVu
            // 
            this.cl_chucVu.Caption = "Chức vụ";
            this.cl_chucVu.FieldName = "ChucVu";
            this.cl_chucVu.Name = "cl_chucVu";
            this.cl_chucVu.OptionsColumn.AllowEdit = false;
            this.cl_chucVu.OptionsColumn.ReadOnly = true;
            this.cl_chucVu.Visible = true;
            this.cl_chucVu.VisibleIndex = 3;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Myriad Pro", 20F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(209, 12);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(294, 66);
            this.labelControl8.TabIndex = 60;
            this.labelControl8.Text = "DANH SÁCH NHÂN VIÊN \r\n    CHƯA CÓ TÀI KHOẢN";
            // 
            // frmThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 472);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.dgcontrol_chuaCoTK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmThemTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThemTaiKhoan_FormClosing);
            this.Load += new System.EventHandler(this.frmThemTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_chuaCoTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_chuaCoTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgcontrol_chuaCoTK;
        private DevExpress.XtraGrid.Views.Grid.GridView dgview_chuaCoTK;
        private DevExpress.XtraGrid.Columns.GridColumn cl_manv;
        private DevExpress.XtraGrid.Columns.GridColumn cl_honv;
        private DevExpress.XtraGrid.Columns.GridColumn cl_tennv;
        private DevExpress.XtraGrid.Columns.GridColumn cl_chucVu;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}