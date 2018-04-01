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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbDaiLy = new DevExpress.XtraEditors.LookUpEdit();
            this.dtpNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.groupHangHoa = new DevExpress.XtraEditors.GroupControl();
            this.dgvHangHoa = new DevExpress.XtraGrid.GridControl();
            this.hangHoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewHangHoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSoLuongMua = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnMua = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDaiLy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupHangHoa)).BeginInit();
            this.groupHangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongMua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMua)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(46, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Đại Lý";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(46, 100);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ngày Lập Phiếu";
            // 
            // cbDaiLy
            // 
            this.cbDaiLy.Location = new System.Drawing.Point(139, 47);
            this.cbDaiLy.Name = "cbDaiLy";
            this.cbDaiLy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDaiLy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbDaiLy.Size = new System.Drawing.Size(229, 20);
            this.cbDaiLy.TabIndex = 2;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.EditValue = null;
            this.dtpNgayLap.Location = new System.Drawing.Point(139, 97);
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
            this.groupHangHoa.Location = new System.Drawing.Point(46, 151);
            this.groupHangHoa.Name = "groupHangHoa";
            this.groupHangHoa.Size = new System.Drawing.Size(1042, 276);
            this.groupHangHoa.TabIndex = 5;
            this.groupHangHoa.Text = "Chọn Hàng Hóa";
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.DataSource = this.hangHoasBindingSource;
            this.dgvHangHoa.Location = new System.Drawing.Point(5, 24);
            this.dgvHangHoa.MainView = this.gridViewHangHoa;
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtSoLuongMua,
            this.btnMua});
            this.dgvHangHoa.Size = new System.Drawing.Size(1032, 247);
            this.dgvHangHoa.TabIndex = 0;
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
            this.gridColumn1,
            this.gridColumn2});
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
            this.gridColumn1.Caption = "Số Lượng Mua";
            this.gridColumn1.ColumnEdit = this.txtSoLuongMua;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 152;
            // 
            // txtSoLuongMua
            // 
            this.txtSoLuongMua.AutoHeight = false;
            this.txtSoLuongMua.Name = "txtSoLuongMua";
            this.txtSoLuongMua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongMua_KeyPress);
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.Caption = "Mua";
            this.gridColumn2.ColumnEdit = this.btnMua;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 156;
            // 
            // btnMua
            // 
            this.btnMua.AutoHeight = false;
            this.btnMua.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnMua.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnMua.Name = "btnMua";
            this.btnMua.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmLapPhieuXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 492);
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
            ((System.ComponentModel.ISupportInitialize)(this.hangHoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongMua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit cbDaiLy;
        private DevExpress.XtraEditors.DateEdit dtpNgayLap;
        private DevExpress.XtraEditors.GroupControl groupHangHoa;
        private DevExpress.XtraGrid.GridControl dgvHangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHangHoa;
        private System.Windows.Forms.BindingSource hangHoasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtSoLuongMua;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnMua;
    }
}