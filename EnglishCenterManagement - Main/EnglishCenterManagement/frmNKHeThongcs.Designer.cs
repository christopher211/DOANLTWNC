namespace EnglishCenterManagement
{
    partial class frmNKHeThongcs
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
            this.dgcontrol_nkHeThong = new DevExpress.XtraGrid.GridControl();
            this.dgview_nkHeThong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_nkHeThong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_nkHeThong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgcontrol_nkHeThong
            // 
            this.dgcontrol_nkHeThong.Location = new System.Drawing.Point(12, 83);
            this.dgcontrol_nkHeThong.MainView = this.dgview_nkHeThong;
            this.dgcontrol_nkHeThong.Name = "dgcontrol_nkHeThong";
            this.dgcontrol_nkHeThong.Size = new System.Drawing.Size(875, 419);
            this.dgcontrol_nkHeThong.TabIndex = 0;
            this.dgcontrol_nkHeThong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgview_nkHeThong});
            // 
            // dgview_nkHeThong
            // 
            this.dgview_nkHeThong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.dgview_nkHeThong.GridControl = this.dgcontrol_nkHeThong;
            this.dgview_nkHeThong.Name = "dgview_nkHeThong";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn3";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumn4";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "gridColumn5";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Myriad Pro", 25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(319, 12);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(286, 42);
            this.labelControl8.TabIndex = 60;
            this.labelControl8.Text = "LỊCH SỬ HỆ THỐNG";
            // 
            // frmNKHeThongcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 514);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.dgcontrol_nkHeThong);
            this.Name = "frmNKHeThongcs";
            this.Text = "Lịch sử hệ thống";
            ((System.ComponentModel.ISupportInitialize)(this.dgcontrol_nkHeThong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_nkHeThong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgcontrol_nkHeThong;
        private DevExpress.XtraGrid.Views.Grid.GridView dgview_nkHeThong;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}