namespace QLDaiLy
{
    partial class frmHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangHoa));
            this.txtTuKhoa = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navbarQuanLy = new DevExpress.XtraNavBar.NavBarGroup();
            this.navbarThem = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarSua = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarXoa = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarChucNangKhac = new DevExpress.XtraNavBar.NavBarGroup();
            this.dgvHangHoa = new DevExpress.XtraGrid.GridControl();
            this.hangHoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewHangHoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(450, 47);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(305, 20);
            this.txtTuKhoa.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDaiLy.Properties.Resources.Find;
            this.pictureBox1.Location = new System.Drawing.Point(344, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(393, 50);
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
            this.navBarControl1.Location = new System.Drawing.Point(43, 95);
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
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarThem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarSua),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarXoa)});
            this.navbarQuanLy.Name = "navbarQuanLy";
            // 
            // navbarThem
            // 
            this.navbarThem.Caption = "Thêm Hàng Hóa";
            this.navbarThem.Name = "navbarThem";
            this.navbarThem.SmallImage = ((System.Drawing.Image)(resources.GetObject("navbarThem.SmallImage")));
            this.navbarThem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navbarThem_LinkClicked);
            // 
            // navbarSua
            // 
            this.navbarSua.Caption = "Sửa Thông Tin Hàng Hóa";
            this.navbarSua.Name = "navbarSua";
            this.navbarSua.SmallImage = ((System.Drawing.Image)(resources.GetObject("navbarSua.SmallImage")));
            this.navbarSua.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navbarSua_LinkClicked);
            // 
            // navbarXoa
            // 
            this.navbarXoa.Caption = "Ngừng Kinh Doanh";
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
            // dgvHangHoa
            // 
            this.dgvHangHoa.DataSource = this.hangHoasBindingSource;
            this.dgvHangHoa.Location = new System.Drawing.Point(306, 95);
            this.dgvHangHoa.MainView = this.gridViewHangHoa;
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.Size = new System.Drawing.Size(845, 325);
            this.dgvHangHoa.TabIndex = 10;
            this.dgvHangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHangHoa});
            // 
            // hangHoasBindingSource
            // 
            this.hangHoasBindingSource.DataSource = typeof(DAL.HangHoa);
            // 
            // gridViewHangHoa
            // 
            this.gridViewHangHoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHangHoa,
            this.colTenHangHoa,
            this.colDVT,
            this.colSoLuong,
            this.colDonGia,
            this.colLoaiDVT});
            this.gridViewHangHoa.GridControl = this.dgvHangHoa;
            this.gridViewHangHoa.Name = "gridViewHangHoa";
            this.gridViewHangHoa.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMaHangHoa
            // 
            this.colMaHangHoa.AppearanceCell.Options.UseTextOptions = true;
            this.colMaHangHoa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaHangHoa.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMaHangHoa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaHangHoa.AppearanceHeader.Options.UseFont = true;
            this.colMaHangHoa.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaHangHoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaHangHoa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMaHangHoa.Caption = "Mã Hàng Hóa";
            this.colMaHangHoa.FieldName = "MaHangHoa";
            this.colMaHangHoa.Name = "colMaHangHoa";
            // 
            // colTenHangHoa
            // 
            this.colTenHangHoa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenHangHoa.AppearanceHeader.Options.UseFont = true;
            this.colTenHangHoa.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenHangHoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenHangHoa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTenHangHoa.Caption = "Tên Hàng Hóa";
            this.colTenHangHoa.FieldName = "TenHangHoa";
            this.colTenHangHoa.Name = "colTenHangHoa";
            this.colTenHangHoa.Visible = true;
            this.colTenHangHoa.VisibleIndex = 0;
            this.colTenHangHoa.Width = 250;
            // 
            // colDVT
            // 
            this.colDVT.AppearanceCell.Options.UseTextOptions = true;
            this.colDVT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDVT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDVT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDVT.AppearanceHeader.Options.UseFont = true;
            this.colDVT.AppearanceHeader.Options.UseTextOptions = true;
            this.colDVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDVT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDVT.Caption = "Đơn Vị Tính";
            this.colDVT.FieldName = "DonViTinh.TenDVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 1;
            this.colDVT.Width = 176;
            // 
            // colSoLuong
            // 
            this.colSoLuong.AppearanceCell.Options.UseTextOptions = true;
            this.colSoLuong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoLuong.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSoLuong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSoLuong.AppearanceHeader.Options.UseFont = true;
            this.colSoLuong.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoLuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoLuong.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSoLuong.Caption = "Số Lượng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 2;
            this.colSoLuong.Width = 176;
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
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 3;
            this.colDonGia.Width = 179;
            // 
            // colLoaiDVT
            // 
            this.colLoaiDVT.AppearanceCell.Options.UseTextOptions = true;
            this.colLoaiDVT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoaiDVT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLoaiDVT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colLoaiDVT.AppearanceHeader.Options.UseFont = true;
            this.colLoaiDVT.AppearanceHeader.Options.UseTextOptions = true;
            this.colLoaiDVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoaiDVT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLoaiDVT.Caption = "Mã DVT";
            this.colLoaiDVT.FieldName = "DVT";
            this.colLoaiDVT.Name = "colLoaiDVT";
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 456);
            this.Controls.Add(this.dgvHangHoa);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmHangHoa";
            this.Text = "Hàng Hóa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHangHoa)).EndInit();
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
        private DevExpress.XtraGrid.GridControl dgvHangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHangHoa;
        private System.Windows.Forms.BindingSource hangHoasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiDVT;
    }
}