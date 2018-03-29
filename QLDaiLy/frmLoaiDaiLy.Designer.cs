namespace QLDaiLy
{
    partial class frmLoaiDaiLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiDaiLy));
            this.txtTuKhoa = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navbarQuanLy = new DevExpress.XtraNavBar.NavBarGroup();
            this.navbarThem = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarSua = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarXoa = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarChucNangKhac = new DevExpress.XtraNavBar.NavBarGroup();
            this.dgvLoaiDaiLy = new DevExpress.XtraGrid.GridControl();
            this.loaiDaiLiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewLoaiDaiLy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienNoToiDa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDaiLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiDaiLiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLoaiDaiLy)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(424, 49);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(305, 20);
            this.txtTuKhoa.TabIndex = 5;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDaiLy.Properties.Resources.Find;
            this.pictureBox1.Location = new System.Drawing.Point(318, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(367, 52);
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
            this.navbarThem,
            this.navbarSua,
            this.navbarXoa});
            this.navBarControl1.Location = new System.Drawing.Point(44, 110);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 224;
            this.navBarControl1.Size = new System.Drawing.Size(224, 225);
            this.navBarControl1.TabIndex = 10;
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
            this.navbarThem.Caption = "Thêm Loại Đại Lý";
            this.navbarThem.Name = "navbarThem";
            this.navbarThem.SmallImage = ((System.Drawing.Image)(resources.GetObject("navbarThem.SmallImage")));
            this.navbarThem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navbarThem_LinkClicked);
            // 
            // navbarSua
            // 
            this.navbarSua.Caption = "Sửa Thông Tin Loại Đại Lý";
            this.navbarSua.Name = "navbarSua";
            this.navbarSua.SmallImage = ((System.Drawing.Image)(resources.GetObject("navbarSua.SmallImage")));
            this.navbarSua.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navbarSua_LinkClicked);
            // 
            // navbarXoa
            // 
            this.navbarXoa.Caption = "Ngừng Kinh Doanh Loại Đại Lý";
            this.navbarXoa.Name = "navbarXoa";
            this.navbarXoa.SmallImage = ((System.Drawing.Image)(resources.GetObject("navbarXoa.SmallImage")));
            this.navbarXoa.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navbarXoa_LinkClicked);
            // 
            // navbarChucNangKhac
            // 
            this.navbarChucNangKhac.Caption = "Chức Năng Khác";
            this.navbarChucNangKhac.Expanded = true;
            this.navbarChucNangKhac.Name = "navbarChucNangKhac";
            // 
            // dgvLoaiDaiLy
            // 
            this.dgvLoaiDaiLy.DataSource = this.loaiDaiLiesBindingSource;
            this.dgvLoaiDaiLy.Location = new System.Drawing.Point(318, 110);
            this.dgvLoaiDaiLy.MainView = this.gridViewLoaiDaiLy;
            this.dgvLoaiDaiLy.Name = "dgvLoaiDaiLy";
            this.dgvLoaiDaiLy.Size = new System.Drawing.Size(581, 237);
            this.dgvLoaiDaiLy.TabIndex = 11;
            this.dgvLoaiDaiLy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLoaiDaiLy});
            // 
            // loaiDaiLiesBindingSource
            // 
            this.loaiDaiLiesBindingSource.DataSource = typeof(DAL.LoaiDaiLy);
            // 
            // gridViewLoaiDaiLy
            // 
            this.gridViewLoaiDaiLy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLoai,
            this.colTenLoai,
            this.colTienNoToiDa});
            this.gridViewLoaiDaiLy.GridControl = this.dgvLoaiDaiLy;
            this.gridViewLoaiDaiLy.Name = "gridViewLoaiDaiLy";
            this.gridViewLoaiDaiLy.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMaLoai
            // 
            this.colMaLoai.AppearanceCell.Options.UseTextOptions = true;
            this.colMaLoai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaLoai.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMaLoai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaLoai.AppearanceHeader.Options.UseFont = true;
            this.colMaLoai.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaLoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaLoai.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMaLoai.Caption = "Mã Loại";
            this.colMaLoai.FieldName = "MaLoai";
            this.colMaLoai.Name = "colMaLoai";
            this.colMaLoai.OptionsColumn.AllowEdit = false;
            this.colMaLoai.OptionsColumn.ReadOnly = true;
            // 
            // colTenLoai
            // 
            this.colTenLoai.AppearanceCell.Options.UseTextOptions = true;
            this.colTenLoai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenLoai.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTenLoai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenLoai.AppearanceHeader.Options.UseFont = true;
            this.colTenLoai.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenLoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenLoai.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTenLoai.Caption = "Tên Loại";
            this.colTenLoai.FieldName = "TenLoai";
            this.colTenLoai.Name = "colTenLoai";
            this.colTenLoai.Visible = true;
            this.colTenLoai.VisibleIndex = 0;
            // 
            // colTienNoToiDa
            // 
            this.colTienNoToiDa.AppearanceCell.Options.UseTextOptions = true;
            this.colTienNoToiDa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTienNoToiDa.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTienNoToiDa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTienNoToiDa.AppearanceHeader.Options.UseFont = true;
            this.colTienNoToiDa.AppearanceHeader.Options.UseTextOptions = true;
            this.colTienNoToiDa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTienNoToiDa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTienNoToiDa.Caption = "Tiền Nợ Tối Đa";
            this.colTienNoToiDa.DisplayFormat.FormatString = "{0:N0}";
            this.colTienNoToiDa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTienNoToiDa.FieldName = "TienNoToiDa";
            this.colTienNoToiDa.Name = "colTienNoToiDa";
            this.colTienNoToiDa.Visible = true;
            this.colTienNoToiDa.VisibleIndex = 1;
            // 
            // frmLoaiDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 430);
            this.Controls.Add(this.dgvLoaiDaiLy);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmLoaiDaiLy";
            this.Text = "Loại Đại Lý";
            this.Load += new System.EventHandler(this.frmLoaiDaiLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDaiLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiDaiLiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLoaiDaiLy)).EndInit();
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
        private DevExpress.XtraNavBar.NavBarItem navbarSua;
        private DevExpress.XtraNavBar.NavBarItem navbarXoa;
        private DevExpress.XtraNavBar.NavBarGroup navbarChucNangKhac;
        private DevExpress.XtraGrid.GridControl dgvLoaiDaiLy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLoaiDaiLy;
        private System.Windows.Forms.BindingSource loaiDaiLiesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colTienNoToiDa;
    }
}