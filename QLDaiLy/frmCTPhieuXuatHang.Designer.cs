namespace QLDaiLy
{
    partial class frmCTPhieuXuatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTPhieuXuatHang));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbMaPhieuXuat = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbNhanVien = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbNgayLap = new DevExpress.XtraEditors.LabelControl();
            this.dgvHangHoa = new DevExpress.XtraGrid.GridControl();
            this.gridViewHangHoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lbTongTien = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lbTenDaiLy = new DevExpress.XtraEditors.LabelControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(63, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã phiếu xuất";
            // 
            // lbMaPhieuXuat
            // 
            this.lbMaPhieuXuat.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhieuXuat.Location = new System.Drawing.Point(184, 46);
            this.lbMaPhieuXuat.Name = "lbMaPhieuXuat";
            this.lbMaPhieuXuat.Size = new System.Drawing.Size(92, 14);
            this.lbMaPhieuXuat.TabIndex = 1;
            this.lbMaPhieuXuat.Text = "lbMaPhieuXuat";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(391, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nhân viên lập phiếu";
            // 
            // lbNhanVien
            // 
            this.lbNhanVien.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhanVien.Location = new System.Drawing.Point(515, 87);
            this.lbNhanVien.Name = "lbNhanVien";
            this.lbNhanVien.Size = new System.Drawing.Size(68, 14);
            this.lbNhanVien.TabIndex = 3;
            this.lbNhanVien.Text = "lbNhanVien";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(391, 46);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Ngày lập phiếu";
            // 
            // lbNgayLap
            // 
            this.lbNgayLap.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayLap.Location = new System.Drawing.Point(515, 46);
            this.lbNgayLap.Name = "lbNgayLap";
            this.lbNgayLap.Size = new System.Drawing.Size(63, 14);
            this.lbNgayLap.TabIndex = 5;
            this.lbNgayLap.Text = "lbNgayLap";
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.Location = new System.Drawing.Point(39, 132);
            this.dgvHangHoa.MainView = this.gridViewHangHoa;
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.Size = new System.Drawing.Size(728, 200);
            this.dgvHangHoa.TabIndex = 6;
            this.dgvHangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHangHoa});
            // 
            // gridViewHangHoa
            // 
            this.gridViewHangHoa.GridControl = this.dgvHangHoa;
            this.gridViewHangHoa.Name = "gridViewHangHoa";
            this.gridViewHangHoa.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(68, 371);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Tổng tiền";
            // 
            // lbTongTien
            // 
            this.lbTongTien.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbTongTien.Location = new System.Drawing.Point(156, 370);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(67, 14);
            this.lbTongTien.TabIndex = 8;
            this.lbTongTien.Text = "lbTongTien";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(62, 87);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Đại lý";
            // 
            // lbTenDaiLy
            // 
            this.lbTenDaiLy.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDaiLy.Location = new System.Drawing.Point(184, 87);
            this.lbTenDaiLy.Name = "lbTenDaiLy";
            this.lbTenDaiLy.Size = new System.Drawing.Size(66, 14);
            this.lbTenDaiLy.TabIndex = 10;
            this.lbTenDaiLy.Text = "lbTenDaiLy";
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(615, 370);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(115, 23);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            // 
            // frmCTPhieuXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 434);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lbTenDaiLy);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.dgvHangHoa);
            this.Controls.Add(this.lbNgayLap);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lbNhanVien);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lbMaPhieuXuat);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCTPhieuXuatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Phiếu Xuất Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl dgvHangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHangHoa;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        public DevExpress.XtraEditors.LabelControl lbMaPhieuXuat;
        public DevExpress.XtraEditors.LabelControl lbNhanVien;
        public DevExpress.XtraEditors.LabelControl lbNgayLap;
        public DevExpress.XtraEditors.LabelControl lbTongTien;
        public DevExpress.XtraEditors.LabelControl lbTenDaiLy;
    }
}