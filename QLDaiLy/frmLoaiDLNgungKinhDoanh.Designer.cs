namespace QLDaiLy
{
    partial class frmLoaiDLNgungKinhDoanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiDLNgungKinhDoanh));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.txtTuKhoa = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgvLDLNgungKD = new DevExpress.XtraGrid.GridControl();
            this.loaiDaiLiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewLDLNgungKD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienNoToiDa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnKinhDoanh = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLNgungKD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiDaiLiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLDLNgungKD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKinhDoanh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(164, 54);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(294, 20);
            this.txtTuKhoa.TabIndex = 8;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDaiLy.Properties.Resources.Find;
            this.pictureBox1.Location = new System.Drawing.Point(58, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(107, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Tìm kiếm";
            // 
            // dgvLDLNgungKD
            // 
            this.dgvLDLNgungKD.DataSource = this.loaiDaiLiesBindingSource;
            this.dgvLDLNgungKD.Location = new System.Drawing.Point(33, 106);
            this.dgvLDLNgungKD.MainView = this.gridViewLDLNgungKD;
            this.dgvLDLNgungKD.Name = "dgvLDLNgungKD";
            this.dgvLDLNgungKD.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnKinhDoanh});
            this.dgvLDLNgungKD.Size = new System.Drawing.Size(646, 200);
            this.dgvLDLNgungKD.TabIndex = 9;
            this.dgvLDLNgungKD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLDLNgungKD});
            // 
            // loaiDaiLiesBindingSource
            // 
            this.loaiDaiLiesBindingSource.DataSource = typeof(DAL.LoaiDaiLy);
            // 
            // gridViewLDLNgungKD
            // 
            this.gridViewLDLNgungKD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLoai,
            this.colTenLoai,
            this.colTienNoToiDa,
            this.gridColumn1});
            this.gridViewLDLNgungKD.GridControl = this.dgvLDLNgungKD;
            this.gridViewLDLNgungKD.Name = "gridViewLDLNgungKD";
            this.gridViewLDLNgungKD.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
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
            this.colTenLoai.OptionsColumn.AllowEdit = false;
            this.colTenLoai.OptionsColumn.ReadOnly = true;
            this.colTenLoai.Visible = true;
            this.colTenLoai.VisibleIndex = 0;
            this.colTenLoai.Width = 250;
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
            this.colTienNoToiDa.OptionsColumn.AllowEdit = false;
            this.colTienNoToiDa.OptionsColumn.ReadOnly = true;
            this.colTienNoToiDa.Visible = true;
            this.colTienNoToiDa.VisibleIndex = 1;
            this.colTienNoToiDa.Width = 188;
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
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 190;
            // 
            // btnKinhDoanh
            // 
            this.btnKinhDoanh.AutoHeight = false;
            this.btnKinhDoanh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnKinhDoanh.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnKinhDoanh.Name = "btnKinhDoanh";
            this.btnKinhDoanh.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnKinhDoanh.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnKinhDoanh_ButtonClick);
            // 
            // frmLoaiDLNgungKinhDoanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 343);
            this.Controls.Add(this.dgvLDLNgungKD);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLoaiDLNgungKinhDoanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Loại Đại Lý Ngừng Kinh Doanh";
            this.Load += new System.EventHandler(this.frmLoaiDLNgungKinhDoanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLNgungKD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiDaiLiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLDLNgungKD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKinhDoanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTuKhoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl dgvLDLNgungKD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLDLNgungKD;
        private System.Windows.Forms.BindingSource loaiDaiLiesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colTienNoToiDa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnKinhDoanh;
    }
}