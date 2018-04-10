namespace QLDaiLy
{
    partial class frmThuTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThuTien));
            this.txtTuKhoa = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navbarQuanLy = new DevExpress.XtraNavBar.NavBarGroup();
            this.navbarThem = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarChucNangKhac = new DevExpress.XtraNavBar.NavBarGroup();
            this.dgvThuTien = new DevExpress.XtraGrid.GridControl();
            this.phieuThuTiensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewThuTien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPhieuThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDaiLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTienThu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuThuTiensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThuTien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(424, 43);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(305, 20);
            this.txtTuKhoa.TabIndex = 5;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDaiLy.Properties.Resources.Find;
            this.pictureBox1.Location = new System.Drawing.Point(318, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(367, 46);
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
            this.navBarControl1.Location = new System.Drawing.Point(45, 105);
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
            this.navbarThem.Caption = "Lập Phiếu Thu Tiền";
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
            // dgvThuTien
            // 
            this.dgvThuTien.DataSource = this.phieuThuTiensBindingSource;
            this.dgvThuTien.Location = new System.Drawing.Point(318, 105);
            this.dgvThuTien.MainView = this.gridViewThuTien;
            this.dgvThuTien.Name = "dgvThuTien";
            this.dgvThuTien.Size = new System.Drawing.Size(735, 317);
            this.dgvThuTien.TabIndex = 10;
            this.dgvThuTien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewThuTien});
            // 
            // phieuThuTiensBindingSource
            // 
            this.phieuThuTiensBindingSource.DataSource = typeof(DAL.PhieuThuTien);
            // 
            // gridViewThuTien
            // 
            this.gridViewThuTien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPhieuThu,
            this.colTenDaiLy,
            this.colNgayThu,
            this.colSoTienThu});
            this.gridViewThuTien.GridControl = this.dgvThuTien;
            this.gridViewThuTien.Name = "gridViewThuTien";
            this.gridViewThuTien.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMaPhieuThu
            // 
            this.colMaPhieuThu.AppearanceCell.Options.UseTextOptions = true;
            this.colMaPhieuThu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaPhieuThu.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMaPhieuThu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaPhieuThu.AppearanceHeader.Options.UseFont = true;
            this.colMaPhieuThu.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaPhieuThu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaPhieuThu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMaPhieuThu.Caption = "Mã Phiếu Thu";
            this.colMaPhieuThu.FieldName = "MaPhieuThu";
            this.colMaPhieuThu.Name = "colMaPhieuThu";
            this.colMaPhieuThu.OptionsColumn.AllowEdit = false;
            this.colMaPhieuThu.OptionsColumn.ReadOnly = true;
            this.colMaPhieuThu.Visible = true;
            this.colMaPhieuThu.VisibleIndex = 0;
            // 
            // colTenDaiLy
            // 
            this.colTenDaiLy.AppearanceCell.Options.UseTextOptions = true;
            this.colTenDaiLy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenDaiLy.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTenDaiLy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenDaiLy.AppearanceHeader.Options.UseFont = true;
            this.colTenDaiLy.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenDaiLy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenDaiLy.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTenDaiLy.Caption = "Tên Đại Lý";
            this.colTenDaiLy.FieldName = "DaiLy.TenDaiLy";
            this.colTenDaiLy.Name = "colTenDaiLy";
            this.colTenDaiLy.OptionsColumn.AllowEdit = false;
            this.colTenDaiLy.OptionsColumn.ReadOnly = true;
            this.colTenDaiLy.Visible = true;
            this.colTenDaiLy.VisibleIndex = 1;
            // 
            // colNgayThu
            // 
            this.colNgayThu.AppearanceCell.Options.UseTextOptions = true;
            this.colNgayThu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayThu.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNgayThu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNgayThu.AppearanceHeader.Options.UseFont = true;
            this.colNgayThu.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgayThu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayThu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNgayThu.Caption = "Ngày Thu";
            this.colNgayThu.FieldName = "NgayThu";
            this.colNgayThu.Name = "colNgayThu";
            this.colNgayThu.OptionsColumn.AllowEdit = false;
            this.colNgayThu.OptionsColumn.ReadOnly = true;
            this.colNgayThu.Visible = true;
            this.colNgayThu.VisibleIndex = 2;
            // 
            // colSoTienThu
            // 
            this.colSoTienThu.AppearanceCell.Options.UseTextOptions = true;
            this.colSoTienThu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoTienThu.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSoTienThu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSoTienThu.AppearanceHeader.Options.UseFont = true;
            this.colSoTienThu.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoTienThu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoTienThu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSoTienThu.Caption = "Số Tiền Thu";
            this.colSoTienThu.DisplayFormat.FormatString = "{0:N0}";
            this.colSoTienThu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSoTienThu.FieldName = "SoTienThu";
            this.colSoTienThu.Name = "colSoTienThu";
            this.colSoTienThu.OptionsColumn.AllowEdit = false;
            this.colSoTienThu.OptionsColumn.ReadOnly = true;
            this.colSoTienThu.Visible = true;
            this.colSoTienThu.VisibleIndex = 3;
            // 
            // frmThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 460);
            this.Controls.Add(this.dgvThuTien);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmThuTien";
            this.Text = "Thu Tiền";
            this.Load += new System.EventHandler(this.frmThuTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuThuTiensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThuTien)).EndInit();
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
        private DevExpress.XtraGrid.GridControl dgvThuTien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewThuTien;
        private System.Windows.Forms.BindingSource phieuThuTiensBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieuThu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDaiLy;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayThu;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTienThu;
    }
}