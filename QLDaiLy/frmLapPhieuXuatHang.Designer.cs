namespace QLDaiLy
{
    partial class frmLapPhieuXuatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLapPhieuXuatHang));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbDaiLy = new DevExpress.XtraEditors.LookUpEdit();
            this.dtpNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.groupHangHoa = new DevExpress.XtraEditors.GroupControl();
            this.dgvHangHoa = new DevExpress.XtraGrid.GridControl();
            this.hangHoasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewHangHoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnMua = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.hangHoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTuKhoa = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupGioHang = new DevExpress.XtraEditors.GroupControl();
            this.dgvGioHang = new DevExpress.XtraGrid.GridControl();
            this.gridViewGioHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnTinhTongTien = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.lbTongTien = new DevExpress.XtraEditors.LabelControl();
            this.btnXoaGioHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaHangHoa = new DevExpress.XtraEditors.SimpleButton();
            this.ErrorChecker = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbTienNo = new DevExpress.XtraEditors.LabelControl();
            this.lbTienNoHienTai = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cbDaiLy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupHangHoa)).BeginInit();
            this.groupHangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGioHang)).BeginInit();
            this.groupGioHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGioHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorChecker)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(49, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Đại Lý";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(704, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ngày Lập Phiếu";
            // 
            // cbDaiLy
            // 
            this.cbDaiLy.Location = new System.Drawing.Point(97, 25);
            this.cbDaiLy.Name = "cbDaiLy";
            this.cbDaiLy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDaiLy.Size = new System.Drawing.Size(229, 20);
            this.cbDaiLy.TabIndex = 2;
            this.cbDaiLy.EditValueChanged += new System.EventHandler(this.cbDaiLy_EditValueChanged);
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.EditValue = null;
            this.dtpNgayLap.Location = new System.Drawing.Point(797, 25);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayLap.Size = new System.Drawing.Size(118, 20);
            this.dtpNgayLap.TabIndex = 4;
            // 
            // groupHangHoa
            // 
            this.groupHangHoa.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupHangHoa.AppearanceCaption.Options.UseFont = true;
            this.groupHangHoa.Controls.Add(this.dgvHangHoa);
            this.groupHangHoa.Location = new System.Drawing.Point(46, 107);
            this.groupHangHoa.Name = "groupHangHoa";
            this.groupHangHoa.Size = new System.Drawing.Size(1042, 204);
            this.groupHangHoa.TabIndex = 5;
            this.groupHangHoa.Text = "Chọn Hàng Hóa";
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.DataSource = this.hangHoasBindingSource1;
            this.dgvHangHoa.Location = new System.Drawing.Point(5, 24);
            this.dgvHangHoa.MainView = this.gridViewHangHoa;
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnMua});
            this.dgvHangHoa.Size = new System.Drawing.Size(1032, 174);
            this.dgvHangHoa.TabIndex = 0;
            this.dgvHangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHangHoa});
            // 
            // hangHoasBindingSource1
            // 
            this.hangHoasBindingSource1.DataSource = typeof(DAL.HangHoa);
            // 
            // gridViewHangHoa
            // 
            this.gridViewHangHoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHangHoa,
            this.colTenHangHoa,
            this.colDVT,
            this.colSoLuong,
            this.colDonGia,
            this.gridColumn1});
            this.gridViewHangHoa.GridControl = this.dgvHangHoa;
            this.gridViewHangHoa.Name = "gridViewHangHoa";
            this.gridViewHangHoa.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMaHangHoa
            // 
            this.colMaHangHoa.AppearanceCell.Options.UseTextOptions = true;
            this.colMaHangHoa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaHangHoa.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMaHangHoa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaHangHoa.AppearanceHeader.Options.UseFont = true;
            this.colMaHangHoa.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaHangHoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaHangHoa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMaHangHoa.Caption = "Mã Hàng Hóa";
            this.colMaHangHoa.FieldName = "MaHangHoa";
            this.colMaHangHoa.Name = "colMaHangHoa";
            this.colMaHangHoa.OptionsColumn.AllowEdit = false;
            this.colMaHangHoa.OptionsColumn.ReadOnly = true;
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
            this.colTenHangHoa.FieldName = "TenHangHoa";
            this.colTenHangHoa.Name = "colTenHangHoa";
            this.colTenHangHoa.OptionsColumn.AllowEdit = false;
            this.colTenHangHoa.OptionsColumn.ReadOnly = true;
            this.colTenHangHoa.Visible = true;
            this.colTenHangHoa.VisibleIndex = 0;
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
            this.colDVT.OptionsColumn.AllowEdit = false;
            this.colDVT.OptionsColumn.ReadOnly = true;
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 1;
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
            this.colSoLuong.Caption = "Số Lượng Tồn";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.OptionsColumn.AllowEdit = false;
            this.colSoLuong.OptionsColumn.ReadOnly = true;
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 2;
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
            this.colDonGia.VisibleIndex = 3;
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
            this.gridColumn1.Caption = "Mua";
            this.gridColumn1.ColumnEdit = this.btnMua;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // btnMua
            // 
            this.btnMua.AutoHeight = false;
            this.btnMua.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnMua.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnMua.Name = "btnMua";
            this.btnMua.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnMua.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnMua_ButtonClick);
            // 
            // hangHoasBindingSource
            // 
            this.hangHoasBindingSource.DataSource = typeof(DAL.HangHoa);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(229, 69);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(305, 20);
            this.txtTuKhoa.TabIndex = 8;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDaiLy.Properties.Resources.Find;
            this.pictureBox1.Location = new System.Drawing.Point(123, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(172, 72);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Tìm kiếm";
            // 
            // groupGioHang
            // 
            this.groupGioHang.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupGioHang.Appearance.Options.UseFont = true;
            this.groupGioHang.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupGioHang.AppearanceCaption.Options.UseFont = true;
            this.groupGioHang.Controls.Add(this.dgvGioHang);
            this.groupGioHang.Location = new System.Drawing.Point(46, 341);
            this.groupGioHang.Name = "groupGioHang";
            this.groupGioHang.Size = new System.Drawing.Size(1042, 176);
            this.groupGioHang.TabIndex = 9;
            this.groupGioHang.Text = "Giỏ Hàng";
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.Location = new System.Drawing.Point(5, 23);
            this.dgvGioHang.MainView = this.gridViewGioHang;
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.Size = new System.Drawing.Size(1032, 148);
            this.dgvGioHang.TabIndex = 0;
            this.dgvGioHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGioHang});
            // 
            // gridViewGioHang
            // 
            this.gridViewGioHang.GridControl = this.dgvGioHang;
            this.gridViewGioHang.Name = "gridViewGioHang";
            this.gridViewGioHang.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridViewGioHang.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewGioHang_CellValueChanged);
            // 
            // btnTinhTongTien
            // 
            this.btnTinhTongTien.Image = ((System.Drawing.Image)(resources.GetObject("btnTinhTongTien.Image")));
            this.btnTinhTongTien.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnTinhTongTien.Location = new System.Drawing.Point(75, 596);
            this.btnTinhTongTien.Name = "btnTinhTongTien";
            this.btnTinhTongTien.Size = new System.Drawing.Size(160, 23);
            this.btnTinhTongTien.TabIndex = 10;
            this.btnTinhTongTien.Text = "Tính Tổng Tiền";
            this.btnTinhTongTien.Click += new System.EventHandler(this.btnTinhTongTien_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(873, 596);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(184, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Lập Phiếu Xuất Hàng";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbTongTien
            // 
            this.lbTongTien.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbTongTien.Location = new System.Drawing.Point(280, 596);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(12, 23);
            this.lbTongTien.TabIndex = 13;
            this.lbTongTien.Text = "0";
            // 
            // btnXoaGioHang
            // 
            this.btnXoaGioHang.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaGioHang.Image")));
            this.btnXoaGioHang.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnXoaGioHang.Location = new System.Drawing.Point(75, 549);
            this.btnXoaGioHang.Name = "btnXoaGioHang";
            this.btnXoaGioHang.Size = new System.Drawing.Size(160, 23);
            this.btnXoaGioHang.TabIndex = 14;
            this.btnXoaGioHang.Text = "Xóa Giỏ Hàng";
            this.btnXoaGioHang.ToolTip = "Xóa Tất Cả Hàng Hóa Khỏi Giỏ Hàng";
            this.btnXoaGioHang.Click += new System.EventHandler(this.btnXoaGioHang_Click);
            // 
            // btnXoaHangHoa
            // 
            this.btnXoaHangHoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHangHoa.Image")));
            this.btnXoaHangHoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnXoaHangHoa.Location = new System.Drawing.Point(280, 549);
            this.btnXoaHangHoa.Name = "btnXoaHangHoa";
            this.btnXoaHangHoa.Size = new System.Drawing.Size(160, 23);
            this.btnXoaHangHoa.TabIndex = 15;
            this.btnXoaHangHoa.Text = "Xóa Hàng Hóa";
            this.btnXoaHangHoa.ToolTip = "Xóa Hàng Hóa Đang Chọn Khỏi Giỏ Hàng";
            this.btnXoaHangHoa.Click += new System.EventHandler(this.btnXoaHangHoa_Click);
            // 
            // ErrorChecker
            // 
            this.ErrorChecker.ContainerControl = this;
            // 
            // lbTienNo
            // 
            this.lbTienNo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienNo.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbTienNo.Location = new System.Drawing.Point(514, 28);
            this.lbTienNo.Name = "lbTienNo";
            this.lbTienNo.Size = new System.Drawing.Size(52, 14);
            this.lbTienNo.TabIndex = 16;
            this.lbTienNo.Text = "lbTienNo";
            this.lbTienNo.Visible = false;
            // 
            // lbTienNoHienTai
            // 
            this.lbTienNoHienTai.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienNoHienTai.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbTienNoHienTai.Location = new System.Drawing.Point(395, 28);
            this.lbTienNoHienTai.Name = "lbTienNoHienTai";
            this.lbTienNoHienTai.Size = new System.Drawing.Size(101, 14);
            this.lbTienNoHienTai.TabIndex = 17;
            this.lbTienNoHienTai.Text = "Tiền Nợ Hiện Tại:";
            this.lbTienNoHienTai.Visible = false;
            // 
            // frmLapPhieuXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 637);
            this.Controls.Add(this.lbTienNoHienTai);
            this.Controls.Add(this.lbTienNo);
            this.Controls.Add(this.btnXoaHangHoa);
            this.Controls.Add(this.btnXoaGioHang);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTinhTongTien);
            this.Controls.Add(this.groupGioHang);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.groupHangHoa);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.cbDaiLy);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLapPhieuXuatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Phiếu Xuất Hàng";
            this.Load += new System.EventHandler(this.frmLapPhieuXuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbDaiLy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupHangHoa)).EndInit();
            this.groupHangHoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGioHang)).EndInit();
            this.groupGioHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGioHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorChecker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit cbDaiLy;
        private DevExpress.XtraEditors.DateEdit dtpNgayLap;
        private DevExpress.XtraEditors.GroupControl groupHangHoa;
        private System.Windows.Forms.BindingSource hangHoasBindingSource;
        private DevExpress.XtraEditors.TextEdit txtTuKhoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupGioHang;
        private DevExpress.XtraGrid.GridControl dgvGioHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGioHang;
        private DevExpress.XtraGrid.GridControl dgvHangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHangHoa;
        private System.Windows.Forms.BindingSource hangHoasBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnMua;
        private DevExpress.XtraEditors.SimpleButton btnTinhTongTien;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.LabelControl lbTongTien;
        private DevExpress.XtraEditors.SimpleButton btnXoaGioHang;
        private DevExpress.XtraEditors.SimpleButton btnXoaHangHoa;
        private System.Windows.Forms.ErrorProvider ErrorChecker;
        private DevExpress.XtraEditors.LabelControl lbTienNo;
        private DevExpress.XtraEditors.LabelControl lbTienNoHienTai;
    }
}