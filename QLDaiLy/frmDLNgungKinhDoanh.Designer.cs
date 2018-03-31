namespace QLDaiLy
{
    partial class frmDLNgungKinhDoanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDLNgungKinhDoanh));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dgvDLNgungKD = new DevExpress.XtraGrid.GridControl();
            this.daiLiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewDLNgungKD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDaiLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDaiLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTiepNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnKinhDoanh = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.txtTuKhoa = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDLNgungKD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daiLiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDLNgungKD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKinhDoanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDLNgungKD
            // 
            this.dgvDLNgungKD.DataSource = this.daiLiesBindingSource;
            this.dgvDLNgungKD.Location = new System.Drawing.Point(36, 99);
            this.dgvDLNgungKD.MainView = this.gridViewDLNgungKD;
            this.dgvDLNgungKD.Name = "dgvDLNgungKD";
            this.dgvDLNgungKD.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnKinhDoanh});
            this.dgvDLNgungKD.Size = new System.Drawing.Size(1204, 276);
            this.dgvDLNgungKD.TabIndex = 0;
            this.dgvDLNgungKD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDLNgungKD});
            // 
            // daiLiesBindingSource
            // 
            this.daiLiesBindingSource.DataSource = typeof(DAL.DaiLy);
            // 
            // gridViewDLNgungKD
            // 
            this.gridViewDLNgungKD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDaiLy,
            this.colTenDaiLy,
            this.colLoai,
            this.colDiaChi,
            this.colQuan,
            this.colEmail,
            this.colNgayTiepNhan,
            this.colTienNo,
            this.gridColumn1});
            this.gridViewDLNgungKD.GridControl = this.dgvDLNgungKD;
            this.gridViewDLNgungKD.Name = "gridViewDLNgungKD";
            this.gridViewDLNgungKD.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
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
            this.colMaDaiLy.Caption = "Mã Đại Lý";
            this.colMaDaiLy.FieldName = "MaDaiLy";
            this.colMaDaiLy.Name = "colMaDaiLy";
            this.colMaDaiLy.OptionsColumn.AllowEdit = false;
            this.colMaDaiLy.OptionsColumn.ReadOnly = true;
            this.colMaDaiLy.Width = 40;
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
            this.colTenDaiLy.FieldName = "TenDaiLy";
            this.colTenDaiLy.Name = "colTenDaiLy";
            this.colTenDaiLy.OptionsColumn.AllowEdit = false;
            this.colTenDaiLy.OptionsColumn.ReadOnly = true;
            this.colTenDaiLy.Visible = true;
            this.colTenDaiLy.VisibleIndex = 0;
            this.colTenDaiLy.Width = 177;
            // 
            // colLoai
            // 
            this.colLoai.AppearanceCell.Options.UseTextOptions = true;
            this.colLoai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoai.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLoai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colLoai.AppearanceHeader.Options.UseFont = true;
            this.colLoai.AppearanceHeader.Options.UseTextOptions = true;
            this.colLoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoai.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLoai.Caption = "Loại Đại Lý";
            this.colLoai.FieldName = "LoaiDaiLy.TenLoai";
            this.colLoai.Name = "colLoai";
            this.colLoai.OptionsColumn.AllowEdit = false;
            this.colLoai.OptionsColumn.ReadOnly = true;
            this.colLoai.Visible = true;
            this.colLoai.VisibleIndex = 1;
            this.colLoai.Width = 177;
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
            this.colDiaChi.VisibleIndex = 2;
            this.colDiaChi.Width = 132;
            // 
            // colQuan
            // 
            this.colQuan.AppearanceCell.Options.UseTextOptions = true;
            this.colQuan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuan.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQuan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
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
            this.colQuan.Width = 140;
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
            this.colEmail.VisibleIndex = 5;
            this.colEmail.Width = 140;
            // 
            // colNgayTiepNhan
            // 
            this.colNgayTiepNhan.AppearanceCell.Options.UseTextOptions = true;
            this.colNgayTiepNhan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayTiepNhan.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNgayTiepNhan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
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
            this.colNgayTiepNhan.VisibleIndex = 4;
            this.colNgayTiepNhan.Width = 142;
            // 
            // colTienNo
            // 
            this.colTienNo.AppearanceCell.Options.UseTextOptions = true;
            this.colTienNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTienNo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTienNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
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
            this.colTienNo.Width = 136;
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
            this.gridColumn1.Caption = "Tiếp Tục Kinh Doanh";
            this.gridColumn1.ColumnEdit = this.btnKinhDoanh;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 142;
            // 
            // btnKinhDoanh
            // 
            this.btnKinhDoanh.AutoHeight = false;
            this.btnKinhDoanh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnKinhDoanh.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.btnKinhDoanh.Name = "btnKinhDoanh";
            this.btnKinhDoanh.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnKinhDoanh.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnKinhDoanh_ButtonClick);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(283, 46);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(305, 20);
            this.txtTuKhoa.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDaiLy.Properties.Resources.Find;
            this.pictureBox1.Location = new System.Drawing.Point(177, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(226, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tìm kiếm";
            // 
            // frmDLNgungKinhDoanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 408);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dgvDLNgungKD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDLNgungKinhDoanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Đại Lý Ngừng Kinh Doanh";
            this.Load += new System.EventHandler(this.frmDLNgungKinhDoanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDLNgungKD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daiLiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDLNgungKD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKinhDoanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvDLNgungKD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDLNgungKD;
        private DevExpress.XtraEditors.TextEdit txtTuKhoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource daiLiesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDaiLy;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDaiLy;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colQuan;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTiepNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colTienNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnKinhDoanh;
    }
}