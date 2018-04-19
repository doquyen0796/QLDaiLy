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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTPhieuXuatHang));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbMaPhieuXuat = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbNhanVien = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbNgayLap = new DevExpress.XtraEditors.LabelControl();
            this.dgvHangHoa = new DevExpress.XtraGrid.GridControl();
            this.cTPhieuXuatHangsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewHangHoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPhieuXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lbTongTien = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lbTenDaiLy = new DevExpress.XtraEditors.LabelControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lbTongHangHoa = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuXuatHangsBindingSource)).BeginInit();
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
            this.lbMaPhieuXuat.Appearance.ForeColor = System.Drawing.Color.Blue;
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
            this.lbNhanVien.Appearance.ForeColor = System.Drawing.Color.Blue;
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
            this.lbNgayLap.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbNgayLap.Location = new System.Drawing.Point(515, 46);
            this.lbNgayLap.Name = "lbNgayLap";
            this.lbNgayLap.Size = new System.Drawing.Size(63, 14);
            this.lbNgayLap.TabIndex = 5;
            this.lbNgayLap.Text = "lbNgayLap";
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.DataSource = this.cTPhieuXuatHangsBindingSource;
            this.dgvHangHoa.Location = new System.Drawing.Point(39, 132);
            this.dgvHangHoa.MainView = this.gridViewHangHoa;
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.Size = new System.Drawing.Size(805, 200);
            this.dgvHangHoa.TabIndex = 6;
            this.dgvHangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHangHoa});
            // 
            // cTPhieuXuatHangsBindingSource
            // 
            this.cTPhieuXuatHangsBindingSource.DataSource = typeof(DAL.CTPhieuXuatHang);
            // 
            // gridViewHangHoa
            // 
            this.gridViewHangHoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPhieuXuat,
            this.colTenHangHoa,
            this.colSoLuongXuat,
            this.colDonGia,
            this.colThanhTien});
            this.gridViewHangHoa.GridControl = this.dgvHangHoa;
            this.gridViewHangHoa.Name = "gridViewHangHoa";
            this.gridViewHangHoa.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMaPhieuXuat
            // 
            this.colMaPhieuXuat.AppearanceCell.Options.UseTextOptions = true;
            this.colMaPhieuXuat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaPhieuXuat.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMaPhieuXuat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaPhieuXuat.AppearanceHeader.Options.UseFont = true;
            this.colMaPhieuXuat.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaPhieuXuat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaPhieuXuat.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMaPhieuXuat.Caption = "Mã Phiếu Xuất";
            this.colMaPhieuXuat.FieldName = "MaPhieuXuat";
            this.colMaPhieuXuat.Name = "colMaPhieuXuat";
            this.colMaPhieuXuat.OptionsColumn.AllowEdit = false;
            this.colMaPhieuXuat.OptionsColumn.ReadOnly = true;
            this.colMaPhieuXuat.Width = 118;
            // 
            // colTenHangHoa
            // 
            this.colTenHangHoa.AppearanceCell.Options.UseTextOptions = true;
            this.colTenHangHoa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenHangHoa.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTenHangHoa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenHangHoa.AppearanceHeader.Options.UseFont = true;
            this.colTenHangHoa.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenHangHoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenHangHoa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTenHangHoa.Caption = "Tên Hàng Hóa";
            this.colTenHangHoa.FieldName = "HangHoa.TenHangHoa";
            this.colTenHangHoa.Name = "colTenHangHoa";
            this.colTenHangHoa.OptionsColumn.AllowEdit = false;
            this.colTenHangHoa.OptionsColumn.ReadOnly = true;
            this.colTenHangHoa.Visible = true;
            this.colTenHangHoa.VisibleIndex = 0;
            this.colTenHangHoa.Width = 260;
            // 
            // colSoLuongXuat
            // 
            this.colSoLuongXuat.AppearanceCell.Options.UseTextOptions = true;
            this.colSoLuongXuat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoLuongXuat.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSoLuongXuat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSoLuongXuat.AppearanceHeader.Options.UseFont = true;
            this.colSoLuongXuat.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoLuongXuat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoLuongXuat.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSoLuongXuat.Caption = "Số Lượng Mua";
            this.colSoLuongXuat.FieldName = "SoLuongXuat";
            this.colSoLuongXuat.Name = "colSoLuongXuat";
            this.colSoLuongXuat.OptionsColumn.AllowEdit = false;
            this.colSoLuongXuat.OptionsColumn.ReadOnly = true;
            this.colSoLuongXuat.Visible = true;
            this.colSoLuongXuat.VisibleIndex = 1;
            this.colSoLuongXuat.Width = 130;
            // 
            // colDonGia
            // 
            this.colDonGia.AppearanceCell.Options.UseTextOptions = true;
            this.colDonGia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDonGia.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDonGia.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDonGia.AppearanceHeader.Options.UseFont = true;
            this.colDonGia.AppearanceHeader.Options.UseTextOptions = true;
            this.colDonGia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDonGia.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDonGia.Caption = "Đơn Giá";
            this.colDonGia.DisplayFormat.FormatString = "{0:N0}";
            this.colDonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.OptionsColumn.AllowEdit = false;
            this.colDonGia.OptionsColumn.ReadOnly = true;
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 2;
            this.colDonGia.Width = 150;
            // 
            // colThanhTien
            // 
            this.colThanhTien.AppearanceCell.Options.UseTextOptions = true;
            this.colThanhTien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colThanhTien.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colThanhTien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colThanhTien.AppearanceHeader.Options.UseFont = true;
            this.colThanhTien.AppearanceHeader.Options.UseTextOptions = true;
            this.colThanhTien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colThanhTien.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colThanhTien.Caption = "Thành Tiền";
            this.colThanhTien.DisplayFormat.FormatString = "{0:N0}";
            this.colThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colThanhTien.FieldName = "ThanhTien";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.OptionsColumn.AllowEdit = false;
            this.colThanhTien.OptionsColumn.ReadOnly = true;
            this.colThanhTien.Visible = true;
            this.colThanhTien.VisibleIndex = 3;
            this.colThanhTien.Width = 129;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(62, 395);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Tổng tiền";
            // 
            // lbTongTien
            // 
            this.lbTongTien.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbTongTien.Location = new System.Drawing.Point(184, 394);
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
            this.lbTenDaiLy.Appearance.ForeColor = System.Drawing.Color.Blue;
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
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(62, 358);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(86, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Tổng số hàng hóa";
            // 
            // lbTongHangHoa
            // 
            this.lbTongHangHoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongHangHoa.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbTongHangHoa.Location = new System.Drawing.Point(184, 358);
            this.lbTongHangHoa.Name = "lbTongHangHoa";
            this.lbTongHangHoa.Size = new System.Drawing.Size(98, 14);
            this.lbTongHangHoa.TabIndex = 13;
            this.lbTongHangHoa.Text = "lbTongHangHoa";
            // 
            // frmCTPhieuXuatHang
            // 
            this.AcceptButton = this.btnDong;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 434);
            this.Controls.Add(this.lbTongHangHoa);
            this.Controls.Add(this.labelControl6);
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
            this.Load += new System.EventHandler(this.frmCTPhieuXuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuXuatHangsBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource cTPhieuXuatHangsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieuXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhTien;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lbTongHangHoa;
    }
}