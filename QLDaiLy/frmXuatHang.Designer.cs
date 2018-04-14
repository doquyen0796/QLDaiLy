namespace QLDaiLy
{
    partial class frmXuatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatHang));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.txtTuKhoa = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navbarQuanLy = new DevExpress.XtraNavBar.NavBarGroup();
            this.navbarThem = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarChucNangKhac = new DevExpress.XtraNavBar.NavBarGroup();
            this.dgvPhieuXuatHang = new DevExpress.XtraGrid.GridControl();
            this.phieuXuatHangsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPhieuXuatHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPhieuXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDaiLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChiTiet = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatHangsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhieuXuatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(440, 42);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(305, 20);
            this.txtTuKhoa.TabIndex = 5;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDaiLy.Properties.Resources.Find;
            this.pictureBox1.Location = new System.Drawing.Point(334, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(383, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tìm kiếm";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navbarQuanLy;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navbarQuanLy,
            this.navbarChucNangKhac});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navbarThem});
            this.navBarControl1.Location = new System.Drawing.Point(36, 97);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 224;
            this.navBarControl1.Size = new System.Drawing.Size(224, 225);
            this.navBarControl1.TabIndex = 9;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navbarQuanLy
            // 
            this.navbarQuanLy.Caption = "Quản Lý";
            this.navbarQuanLy.Expanded = true;
            this.navbarQuanLy.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarThem)});
            this.navbarQuanLy.Name = "navbarQuanLy";
            // 
            // navbarThem
            // 
            this.navbarThem.Caption = "Lập Phiếu Xuất Hàng";
            this.navbarThem.Name = "navbarThem";
            this.navbarThem.SmallImage = ((System.Drawing.Image)(resources.GetObject("navbarThem.SmallImage")));
            this.navbarThem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navbarThem_LinkClicked);
            // 
            // navbarChucNangKhac
            // 
            this.navbarChucNangKhac.Caption = "Chức Năng Khác";
            this.navbarChucNangKhac.Expanded = true;
            this.navbarChucNangKhac.Name = "navbarChucNangKhac";
            // 
            // dgvPhieuXuatHang
            // 
            this.dgvPhieuXuatHang.DataSource = this.phieuXuatHangsBindingSource;
            this.dgvPhieuXuatHang.Location = new System.Drawing.Point(302, 97);
            this.dgvPhieuXuatHang.MainView = this.gridViewPhieuXuatHang;
            this.dgvPhieuXuatHang.Name = "dgvPhieuXuatHang";
            this.dgvPhieuXuatHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnChiTiet});
            this.dgvPhieuXuatHang.Size = new System.Drawing.Size(871, 315);
            this.dgvPhieuXuatHang.TabIndex = 10;
            this.dgvPhieuXuatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPhieuXuatHang});
            // 
            // phieuXuatHangsBindingSource
            // 
            this.phieuXuatHangsBindingSource.DataSource = typeof(DAL.PhieuXuatHang);
            // 
            // gridViewPhieuXuatHang
            // 
            this.gridViewPhieuXuatHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPhieuXuat,
            this.colNhanVien,
            this.colMaDaiLy,
            this.colNgayXuat,
            this.colTongTien,
            this.gridColumn1});
            this.gridViewPhieuXuatHang.GridControl = this.dgvPhieuXuatHang;
            this.gridViewPhieuXuatHang.Name = "gridViewPhieuXuatHang";
            this.gridViewPhieuXuatHang.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
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
            this.colMaPhieuXuat.Visible = true;
            this.colMaPhieuXuat.VisibleIndex = 0;
            // 
            // colMaDaiLy
            // 
            this.colMaDaiLy.AppearanceCell.Options.UseTextOptions = true;
            this.colMaDaiLy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaDaiLy.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMaDaiLy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaDaiLy.AppearanceHeader.Options.UseFont = true;
            this.colMaDaiLy.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaDaiLy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaDaiLy.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMaDaiLy.Caption = "Tên Đại Lý";
            this.colMaDaiLy.FieldName = "DaiLy.TenDaiLy";
            this.colMaDaiLy.Name = "colMaDaiLy";
            this.colMaDaiLy.OptionsColumn.AllowEdit = false;
            this.colMaDaiLy.OptionsColumn.ReadOnly = true;
            this.colMaDaiLy.Visible = true;
            this.colMaDaiLy.VisibleIndex = 2;
            // 
            // colNgayXuat
            // 
            this.colNgayXuat.AppearanceCell.Options.UseTextOptions = true;
            this.colNgayXuat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayXuat.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNgayXuat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNgayXuat.AppearanceHeader.Options.UseFont = true;
            this.colNgayXuat.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgayXuat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayXuat.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNgayXuat.Caption = "Ngày Xuất";
            this.colNgayXuat.FieldName = "NgayXuat";
            this.colNgayXuat.Name = "colNgayXuat";
            this.colNgayXuat.OptionsColumn.AllowEdit = false;
            this.colNgayXuat.OptionsColumn.ReadOnly = true;
            this.colNgayXuat.Visible = true;
            this.colNgayXuat.VisibleIndex = 3;
            // 
            // colTongTien
            // 
            this.colTongTien.AppearanceCell.Options.UseTextOptions = true;
            this.colTongTien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTongTien.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTongTien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTongTien.AppearanceHeader.Options.UseFont = true;
            this.colTongTien.AppearanceHeader.Options.UseTextOptions = true;
            this.colTongTien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTongTien.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTongTien.Caption = "Tổng Tiền";
            this.colTongTien.DisplayFormat.FormatString = "{0:N0}";
            this.colTongTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.OptionsColumn.AllowEdit = false;
            this.colTongTien.OptionsColumn.ReadOnly = true;
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "Xem Chi Tiết";
            this.gridColumn1.ColumnEdit = this.btnChiTiet;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.AutoHeight = false;
            this.btnChiTiet.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnChiTiet.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnChiTiet.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnChiTiet_ButtonClick);
            // 
            // colNhanVien
            // 
            this.colNhanVien.AppearanceCell.Options.UseTextOptions = true;
            this.colNhanVien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNhanVien.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNhanVien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNhanVien.AppearanceHeader.Options.UseFont = true;
            this.colNhanVien.AppearanceHeader.Options.UseTextOptions = true;
            this.colNhanVien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNhanVien.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNhanVien.Caption = "Nhân Viên Lập Phiếu";
            this.colNhanVien.FieldName = "NguoiDung.TenDangNhap";
            this.colNhanVien.Name = "colNhanVien";
            this.colNhanVien.OptionsColumn.AllowEdit = false;
            this.colNhanVien.OptionsColumn.ReadOnly = true;
            this.colNhanVien.Visible = true;
            this.colNhanVien.VisibleIndex = 1;
            // 
            // frmXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 484);
            this.Controls.Add(this.dgvPhieuXuatHang);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmXuatHang";
            this.Text = "Xuất Hàng";
            this.Load += new System.EventHandler(this.frmXuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatHangsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhieuXuatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTuKhoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navbarQuanLy;
        private DevExpress.XtraNavBar.NavBarItem navbarThem;
        private DevExpress.XtraNavBar.NavBarGroup navbarChucNangKhac;
        private DevExpress.XtraGrid.GridControl dgvPhieuXuatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPhieuXuatHang;
        private System.Windows.Forms.BindingSource phieuXuatHangsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieuXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDaiLy;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanVien;
    }
}