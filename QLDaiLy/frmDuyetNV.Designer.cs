namespace QLDaiLy
{
    partial class frmDuyetNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDuyetNV));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.txtTuKhoa = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgvNhanVienMoi = new DevExpress.XtraGrid.GridControl();
            this.nguoiDungsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewNVMoi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNguoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDuyet = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVienMoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNVMoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDuyet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(303, 41);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(305, 20);
            this.txtTuKhoa.TabIndex = 5;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDaiLy.Properties.Resources.Find;
            this.pictureBox1.Location = new System.Drawing.Point(197, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(246, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tìm kiếm";
            // 
            // dgvNhanVienMoi
            // 
            this.dgvNhanVienMoi.DataSource = this.nguoiDungsBindingSource;
            this.dgvNhanVienMoi.Location = new System.Drawing.Point(269, 99);
            this.dgvNhanVienMoi.MainView = this.gridViewNVMoi;
            this.dgvNhanVienMoi.Name = "dgvNhanVienMoi";
            this.dgvNhanVienMoi.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDuyet});
            this.dgvNhanVienMoi.Size = new System.Drawing.Size(735, 293);
            this.dgvNhanVienMoi.TabIndex = 6;
            this.dgvNhanVienMoi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNVMoi});
            // 
            // nguoiDungsBindingSource
            // 
            this.nguoiDungsBindingSource.DataSource = typeof(DAL.NguoiDung);
            // 
            // gridViewNVMoi
            // 
            this.gridViewNVMoi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNguoiDung,
            this.colTenDangNhap,
            this.colEmail,
            this.colSoDienThoai,
            this.colDiaChi,
            this.colDuyet});
            this.gridViewNVMoi.GridControl = this.dgvNhanVienMoi;
            this.gridViewNVMoi.Name = "gridViewNVMoi";
            this.gridViewNVMoi.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMaNguoiDung
            // 
            this.colMaNguoiDung.AppearanceCell.Options.UseTextOptions = true;
            this.colMaNguoiDung.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaNguoiDung.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMaNguoiDung.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaNguoiDung.AppearanceHeader.Options.UseFont = true;
            this.colMaNguoiDung.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaNguoiDung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaNguoiDung.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMaNguoiDung.Caption = "Mã Người Dùng";
            this.colMaNguoiDung.FieldName = "MaNguoiDung";
            this.colMaNguoiDung.Name = "colMaNguoiDung";
            this.colMaNguoiDung.OptionsColumn.AllowEdit = false;
            this.colMaNguoiDung.OptionsColumn.ReadOnly = true;
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.AppearanceCell.Options.UseTextOptions = true;
            this.colTenDangNhap.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenDangNhap.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTenDangNhap.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenDangNhap.AppearanceHeader.Options.UseFont = true;
            this.colTenDangNhap.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenDangNhap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenDangNhap.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTenDangNhap.Caption = "Tên Đăng Nhập";
            this.colTenDangNhap.FieldName = "TenDangNhap";
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.OptionsColumn.AllowEdit = false;
            this.colTenDangNhap.OptionsColumn.ReadOnly = true;
            this.colTenDangNhap.Visible = true;
            this.colTenDangNhap.VisibleIndex = 0;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceCell.Options.UseTextOptions = true;
            this.colEmail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmail.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEmail.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
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
            this.colEmail.VisibleIndex = 1;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.AppearanceCell.Options.UseTextOptions = true;
            this.colSoDienThoai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoDienThoai.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSoDienThoai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSoDienThoai.AppearanceHeader.Options.UseFont = true;
            this.colSoDienThoai.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoDienThoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoDienThoai.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSoDienThoai.Caption = "Số Điện Thoại";
            this.colSoDienThoai.FieldName = "SoDienThoai";
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.OptionsColumn.AllowEdit = false;
            this.colSoDienThoai.OptionsColumn.ReadOnly = true;
            this.colSoDienThoai.Visible = true;
            this.colSoDienThoai.VisibleIndex = 2;
            // 
            // colDiaChi
            // 
            this.colDiaChi.AppearanceCell.Options.UseTextOptions = true;
            this.colDiaChi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiaChi.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDiaChi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
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
            this.colDiaChi.VisibleIndex = 3;
            // 
            // colDuyet
            // 
            this.colDuyet.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDuyet.AppearanceHeader.Options.UseFont = true;
            this.colDuyet.AppearanceHeader.Options.UseTextOptions = true;
            this.colDuyet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDuyet.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDuyet.Caption = "Duyệt";
            this.colDuyet.ColumnEdit = this.btnDuyet;
            this.colDuyet.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colDuyet.Name = "colDuyet";
            this.colDuyet.Visible = true;
            this.colDuyet.VisibleIndex = 4;
            // 
            // btnDuyet
            // 
            this.btnDuyet.AutoHeight = false;
            this.btnDuyet.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDuyet.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDuyet.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDuyet_ButtonClick);
            // 
            // frmDuyetNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 431);
            this.Controls.Add(this.dgvNhanVienMoi);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmDuyetNV";
            this.Text = "Duyệt Nhân Viên";
            this.Load += new System.EventHandler(this.frmDuyetNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVienMoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNVMoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDuyet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTuKhoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl dgvNhanVienMoi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNVMoi;
        private System.Windows.Forms.BindingSource nguoiDungsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colDuyet;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDuyet;
    }
}