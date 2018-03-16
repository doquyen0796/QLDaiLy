namespace QLDaiLy
{
    partial class frmDaiLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDaiLy));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTuKhoa = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navbarQuanLy = new DevExpress.XtraNavBar.NavBarGroup();
            this.navbarThem = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarSua = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarXoa = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarChucNangKhac = new DevExpress.XtraNavBar.NavBarGroup();
            this.dgvDaiLy = new DevExpress.XtraGrid.GridControl();
            this.daiLiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDaiLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDaiLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiDaiLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTiepNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaiLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daiLiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(371, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tìm kiếm";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(428, 37);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(305, 20);
            this.txtTuKhoa.TabIndex = 2;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDaiLy.Properties.Resources.Find;
            this.pictureBox1.Location = new System.Drawing.Point(322, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navbarQuanLy;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navbarQuanLy,
            this.navbarChucNangKhac});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navbarThem,
            this.navbarSua,
            this.navbarXoa});
            this.navBarControl1.Location = new System.Drawing.Point(43, 88);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 224;
            this.navBarControl1.Size = new System.Drawing.Size(224, 225);
            this.navBarControl1.TabIndex = 8;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navbarQuanLy
            // 
            this.navbarQuanLy.Caption = "Quản Lý";
            this.navbarQuanLy.Expanded = true;
            this.navbarQuanLy.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarThem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarSua),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarXoa)});
            this.navbarQuanLy.Name = "navbarQuanLy";
            // 
            // navbarThem
            // 
            this.navbarThem.Caption = "Thêm Đại Lý";
            this.navbarThem.Name = "navbarThem";
            this.navbarThem.SmallImage = ((System.Drawing.Image)(resources.GetObject("navbarThem.SmallImage")));
            this.navbarThem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navbarThem_LinkClicked);
            // 
            // navbarSua
            // 
            this.navbarSua.Caption = "Sửa Thông Tin Đại Lý";
            this.navbarSua.Name = "navbarSua";
            this.navbarSua.SmallImage = ((System.Drawing.Image)(resources.GetObject("navbarSua.SmallImage")));
            // 
            // navbarXoa
            // 
            this.navbarXoa.Caption = "Xóa Đại Lý";
            this.navbarXoa.Name = "navbarXoa";
            this.navbarXoa.SmallImage = ((System.Drawing.Image)(resources.GetObject("navbarXoa.SmallImage")));
            // 
            // navbarChucNangKhac
            // 
            this.navbarChucNangKhac.Caption = "Chức Năng Khác";
            this.navbarChucNangKhac.Expanded = true;
            this.navbarChucNangKhac.Name = "navbarChucNangKhac";
            // 
            // dgvDaiLy
            // 
            this.dgvDaiLy.DataSource = this.daiLiesBindingSource;
            this.dgvDaiLy.Location = new System.Drawing.Point(305, 88);
            this.dgvDaiLy.MainView = this.gridView1;
            this.dgvDaiLy.Name = "dgvDaiLy";
            this.dgvDaiLy.Size = new System.Drawing.Size(967, 286);
            this.dgvDaiLy.TabIndex = 9;
            this.dgvDaiLy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // daiLiesBindingSource
            // 
            this.daiLiesBindingSource.DataSource = typeof(DAL.DaiLy);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDaiLy,
            this.colTenDaiLy,
            this.colLoaiDaiLy,
            this.colDiaChi,
            this.colQuan,
            this.colEmail,
            this.colNgayTiepNhan,
            this.colTienNo});
            this.gridView1.GridControl = this.dgvDaiLy;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMaDaiLy
            // 
            this.colMaDaiLy.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colMaDaiLy.AppearanceHeader.Options.UseFont = true;
            this.colMaDaiLy.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaDaiLy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaDaiLy.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMaDaiLy.Caption = "Mã Đại Lý";
            this.colMaDaiLy.FieldName = "MaDaiLy";
            this.colMaDaiLy.Name = "colMaDaiLy";
            this.colMaDaiLy.OptionsColumn.AllowEdit = false;
            this.colMaDaiLy.OptionsColumn.ReadOnly = true;
            // 
            // colTenDaiLy
            // 
            this.colTenDaiLy.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colTenDaiLy.AppearanceHeader.Options.UseFont = true;
            this.colTenDaiLy.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenDaiLy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenDaiLy.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTenDaiLy.Caption = "Tên Đại Lý";
            this.colTenDaiLy.FieldName = "TenDaiLy";
            this.colTenDaiLy.Name = "colTenDaiLy";
            this.colTenDaiLy.OptionsColumn.AllowEdit = false;
            this.colTenDaiLy.OptionsColumn.ReadOnly = true;
            this.colTenDaiLy.Visible = true;
            this.colTenDaiLy.VisibleIndex = 0;
            this.colTenDaiLy.Width = 130;
            // 
            // colLoaiDaiLy
            // 
            this.colLoaiDaiLy.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colLoaiDaiLy.AppearanceHeader.Options.UseFont = true;
            this.colLoaiDaiLy.AppearanceHeader.Options.UseTextOptions = true;
            this.colLoaiDaiLy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoaiDaiLy.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLoaiDaiLy.Caption = "Loại Đại Lý";
            this.colLoaiDaiLy.FieldName = "LoaiDaiLy.TenLoai";
            this.colLoaiDaiLy.Name = "colLoaiDaiLy";
            this.colLoaiDaiLy.OptionsColumn.AllowEdit = false;
            this.colLoaiDaiLy.OptionsColumn.ReadOnly = true;
            this.colLoaiDaiLy.Visible = true;
            this.colLoaiDaiLy.VisibleIndex = 1;
            this.colLoaiDaiLy.Width = 157;
            // 
            // colDiaChi
            // 
            this.colDiaChi.AppearanceCell.Options.UseTextOptions = true;
            this.colDiaChi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiaChi.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDiaChi.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colDiaChi.AppearanceHeader.Options.UseFont = true;
            this.colDiaChi.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiaChi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiaChi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDiaChi.Caption = "Địa Chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.OptionsColumn.AllowEdit = false;
            this.colDiaChi.OptionsColumn.ReadOnly = true;
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 2;
            this.colDiaChi.Width = 140;
            // 
            // colQuan
            // 
            this.colQuan.AppearanceCell.Options.UseTextOptions = true;
            this.colQuan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuan.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQuan.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colQuan.AppearanceHeader.Options.UseFont = true;
            this.colQuan.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuan.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQuan.Caption = "Quận";
            this.colQuan.FieldName = "Quan";
            this.colQuan.Name = "colQuan";
            this.colQuan.OptionsColumn.AllowEdit = false;
            this.colQuan.OptionsColumn.ReadOnly = true;
            this.colQuan.Visible = true;
            this.colQuan.VisibleIndex = 3;
            this.colQuan.Width = 130;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceCell.Options.UseTextOptions = true;
            this.colEmail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmail.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEmail.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colEmail.AppearanceHeader.Options.UseFont = true;
            this.colEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmail.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.OptionsColumn.ReadOnly = true;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            this.colEmail.Width = 130;
            // 
            // colNgayTiepNhan
            // 
            this.colNgayTiepNhan.AppearanceCell.Options.UseTextOptions = true;
            this.colNgayTiepNhan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayTiepNhan.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNgayTiepNhan.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colNgayTiepNhan.AppearanceHeader.Options.UseFont = true;
            this.colNgayTiepNhan.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgayTiepNhan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayTiepNhan.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNgayTiepNhan.Caption = "Ngày Tiếp Nhận";
            this.colNgayTiepNhan.FieldName = "NgayTiepNhan";
            this.colNgayTiepNhan.Name = "colNgayTiepNhan";
            this.colNgayTiepNhan.OptionsColumn.AllowEdit = false;
            this.colNgayTiepNhan.OptionsColumn.ReadOnly = true;
            this.colNgayTiepNhan.Visible = true;
            this.colNgayTiepNhan.VisibleIndex = 5;
            this.colNgayTiepNhan.Width = 100;
            // 
            // colTienNo
            // 
            this.colTienNo.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colTienNo.AppearanceHeader.Options.UseFont = true;
            this.colTienNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colTienNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTienNo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTienNo.Caption = "Tiền Nợ";
            this.colTienNo.FieldName = "TienNo";
            this.colTienNo.Name = "colTienNo";
            this.colTienNo.OptionsColumn.AllowEdit = false;
            this.colTienNo.OptionsColumn.ReadOnly = true;
            this.colTienNo.Visible = true;
            this.colTienNo.VisibleIndex = 6;
            this.colTienNo.Width = 110;
            // 
            // frmDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 419);
            this.Controls.Add(this.dgvDaiLy);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmDaiLy";
            this.Text = "Quản Lý Đại Lý";
            this.Load += new System.EventHandler(this.frmDaiLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaiLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daiLiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTuKhoa;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navbarQuanLy;
        private DevExpress.XtraNavBar.NavBarItem navbarThem;
        private DevExpress.XtraNavBar.NavBarItem navbarSua;
        private DevExpress.XtraNavBar.NavBarItem navbarXoa;
        private DevExpress.XtraNavBar.NavBarGroup navbarChucNangKhac;
        private DevExpress.XtraGrid.GridControl dgvDaiLy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource daiLiesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDaiLy;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDaiLy;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colQuan;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTiepNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colTienNo;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiDaiLy;
    }
}