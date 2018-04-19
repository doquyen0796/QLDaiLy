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
            this.navBarUndo = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarXuatDSExcel = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarCaiDat = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarSoDaiLyToiDa = new DevExpress.XtraNavBar.NavBarItem();
            this.dgvDaiLy = new DevExpress.XtraGrid.GridControl();
            this.daiLiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewDaiLy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDaiLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDaiLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTiepNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnlui = new System.Windows.Forms.Button();
            this.btntien = new System.Windows.Forms.Button();
            this.lbtrang = new System.Windows.Forms.Label();
            this.cbTrang = new System.Windows.Forms.ComboBox();
            this.cbSoLuongSP = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaiLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daiLiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDaiLy)).BeginInit();
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
            this.navbarCaiDat});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navbarThem,
            this.navbarSua,
            this.navbarXoa,
            this.navBarSoDaiLyToiDa,
            this.navBarUndo,
            this.navBarXuatDSExcel});
            this.navBarControl1.Location = new System.Drawing.Point(43, 88);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 224;
            this.navBarControl1.Size = new System.Drawing.Size(224, 274);
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
            new DevExpress.XtraNavBar.NavBarItemLink(this.navbarXoa),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarUndo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarXuatDSExcel)});
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
            this.navbarSua.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navbarSua_LinkClicked);
            // 
            // navbarXoa
            // 
            this.navbarXoa.Caption = "Ngừng Kinh Doanh";
            this.navbarXoa.Name = "navbarXoa";
            this.navbarXoa.SmallImage = ((System.Drawing.Image)(resources.GetObject("navbarXoa.SmallImage")));
            this.navbarXoa.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navbarXoa_LinkClicked);
            // 
            // navBarUndo
            // 
            this.navBarUndo.Caption = "Đại Lý Ngừng Kinh Doanh";
            this.navBarUndo.Name = "navBarUndo";
            this.navBarUndo.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarUndo.SmallImage")));
            this.navBarUndo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarUndo_LinkClicked);
            // 
            // navBarXuatDSExcel
            // 
            this.navBarXuatDSExcel.Caption = "Xuất Danh Sách (Excel)";
            this.navBarXuatDSExcel.Name = "navBarXuatDSExcel";
            this.navBarXuatDSExcel.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarXuatDSExcel.SmallImage")));
            this.navBarXuatDSExcel.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarXuatDSExcel_LinkClicked);
            // 
            // navbarCaiDat
            // 
            this.navbarCaiDat.Caption = "Cài Đặt";
            this.navbarCaiDat.Expanded = true;
            this.navbarCaiDat.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSoDaiLyToiDa)});
            this.navbarCaiDat.Name = "navbarCaiDat";
            // 
            // navBarSoDaiLyToiDa
            // 
            this.navBarSoDaiLyToiDa.Caption = "Số Đại Lý Tối Đa Trong Quận";
            this.navBarSoDaiLyToiDa.Name = "navBarSoDaiLyToiDa";
            this.navBarSoDaiLyToiDa.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarSoDaiLyToiDa.SmallImage")));
            this.navBarSoDaiLyToiDa.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarSoDaiLyToiDa_LinkClicked);
            // 
            // dgvDaiLy
            // 
            this.dgvDaiLy.DataSource = this.daiLiesBindingSource;
            this.dgvDaiLy.Location = new System.Drawing.Point(305, 88);
            this.dgvDaiLy.MainView = this.gridViewDaiLy;
            this.dgvDaiLy.Name = "dgvDaiLy";
            this.dgvDaiLy.Size = new System.Drawing.Size(967, 291);
            this.dgvDaiLy.TabIndex = 9;
            this.dgvDaiLy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDaiLy});
            // 
            // daiLiesBindingSource
            // 
            this.daiLiesBindingSource.DataSource = typeof(DAL.DaiLy);
            // 
            // gridViewDaiLy
            // 
            this.gridViewDaiLy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDaiLy,
            this.colTenDaiLy,
            this.colTenLoai,
            this.colDiaChi,
            this.colQuan,
            this.colEmail,
            this.colNgayTiepNhan,
            this.colTienNo,
            this.colLoai});
            this.gridViewDaiLy.GridControl = this.dgvDaiLy;
            this.gridViewDaiLy.Name = "gridViewDaiLy";
            this.gridViewDaiLy.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
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
            // colTenLoai
            // 
            this.colTenLoai.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colTenLoai.AppearanceHeader.Options.UseFont = true;
            this.colTenLoai.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenLoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenLoai.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTenLoai.Caption = "Loại Đại Lý";
            this.colTenLoai.FieldName = "LoaiDaiLy.TenLoai";
            this.colTenLoai.Name = "colTenLoai";
            this.colTenLoai.OptionsColumn.AllowEdit = false;
            this.colTenLoai.OptionsColumn.ReadOnly = true;
            this.colTenLoai.Visible = true;
            this.colTenLoai.VisibleIndex = 1;
            this.colTenLoai.Width = 157;
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
            this.colTienNo.DisplayFormat.FormatString = "{0:N0}";
            this.colTienNo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTienNo.FieldName = "TienNo";
            this.colTienNo.Name = "colTienNo";
            this.colTienNo.OptionsColumn.AllowEdit = false;
            this.colTienNo.OptionsColumn.ReadOnly = true;
            this.colTienNo.Visible = true;
            this.colTienNo.VisibleIndex = 6;
            this.colTienNo.Width = 110;
            // 
            // colLoai
            // 
            this.colLoai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colLoai.AppearanceHeader.Options.UseFont = true;
            this.colLoai.AppearanceHeader.Options.UseTextOptions = true;
            this.colLoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoai.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLoai.Caption = "Loại";
            this.colLoai.FieldName = "Loai";
            this.colLoai.Name = "colLoai";
            // 
            // btnlui
            // 
            this.btnlui.Location = new System.Drawing.Point(1104, 434);
            this.btnlui.Name = "btnlui";
            this.btnlui.Size = new System.Drawing.Size(45, 23);
            this.btnlui.TabIndex = 17;
            this.btnlui.Text = "<";
            this.btnlui.UseVisualStyleBackColor = true;
            this.btnlui.Click += new System.EventHandler(this.btnlui_Click);
            // 
            // btntien
            // 
            this.btntien.Location = new System.Drawing.Point(1155, 434);
            this.btntien.Name = "btntien";
            this.btntien.Size = new System.Drawing.Size(52, 23);
            this.btntien.TabIndex = 18;
            this.btntien.Text = ">";
            this.btntien.UseVisualStyleBackColor = true;
            this.btntien.Click += new System.EventHandler(this.btntien_Click);
            // 
            // lbtrang
            // 
            this.lbtrang.AutoSize = true;
            this.lbtrang.Location = new System.Drawing.Point(1229, 439);
            this.lbtrang.Name = "lbtrang";
            this.lbtrang.Size = new System.Drawing.Size(35, 13);
            this.lbtrang.TabIndex = 19;
            this.lbtrang.Text = "label1";
            // 
            // cbTrang
            // 
            this.cbTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrang.FormattingEnabled = true;
            this.cbTrang.Location = new System.Drawing.Point(1000, 436);
            this.cbTrang.Name = "cbTrang";
            this.cbTrang.Size = new System.Drawing.Size(75, 21);
            this.cbTrang.TabIndex = 22;
            this.cbTrang.SelectedIndexChanged += new System.EventHandler(this.cbTrang_SelectedIndexChanged);
            // 
            // cbSoLuongSP
            // 
            this.cbSoLuongSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoLuongSP.FormattingEnabled = true;
            this.cbSoLuongSP.Location = new System.Drawing.Point(398, 436);
            this.cbSoLuongSP.Name = "cbSoLuongSP";
            this.cbSoLuongSP.Size = new System.Drawing.Size(75, 21);
            this.cbSoLuongSP.TabIndex = 23;
            this.cbSoLuongSP.SelectedIndexChanged += new System.EventHandler(this.cbSoLuongSP_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(304, 439);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(88, 13);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Số đại lý mỗi trang";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(966, 439);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Trang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1158, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Processing: 0";
            this.label1.Visible = false;
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(304, 396);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(817, 23);
            this.progressBar1.TabIndex = 28;
            this.progressBar1.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged_1);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted_1);
            // 
            // frmDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cbSoLuongSP);
            this.Controls.Add(this.cbTrang);
            this.Controls.Add(this.lbtrang);
            this.Controls.Add(this.btntien);
            this.Controls.Add(this.btnlui);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDaiLy)).EndInit();
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
        private DevExpress.XtraNavBar.NavBarGroup navbarCaiDat;
        private DevExpress.XtraGrid.GridControl dgvDaiLy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDaiLy;
        private System.Windows.Forms.BindingSource daiLiesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDaiLy;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDaiLy;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colQuan;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTiepNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colTienNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai;
        private System.Windows.Forms.Button btnlui;
        private System.Windows.Forms.Button btntien;
        private System.Windows.Forms.Label lbtrang;
        private System.Windows.Forms.ComboBox cbTrang;
        private System.Windows.Forms.ComboBox cbSoLuongSP;
        private DevExpress.XtraNavBar.NavBarItem navBarSoDaiLyToiDa;
        private DevExpress.XtraNavBar.NavBarItem navBarUndo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraNavBar.NavBarItem navBarXuatDSExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}