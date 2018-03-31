namespace QLDaiLy
{
    partial class frmDVTNgungKinhDoanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDVTNgungKinhDoanh));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dgvDVTNgungSD = new DevExpress.XtraGrid.GridControl();
            this.donViTinhsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewDVTNgungSD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTuKhoa = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnTaiSuDung = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVTNgungSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDVTNgungSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTaiSuDung)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDVTNgungSD
            // 
            this.dgvDVTNgungSD.DataSource = this.donViTinhsBindingSource;
            this.dgvDVTNgungSD.Location = new System.Drawing.Point(35, 103);
            this.dgvDVTNgungSD.MainView = this.gridViewDVTNgungSD;
            this.dgvDVTNgungSD.Name = "dgvDVTNgungSD";
            this.dgvDVTNgungSD.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnTaiSuDung});
            this.dgvDVTNgungSD.Size = new System.Drawing.Size(400, 200);
            this.dgvDVTNgungSD.TabIndex = 0;
            this.dgvDVTNgungSD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDVTNgungSD});
            // 
            // donViTinhsBindingSource
            // 
            this.donViTinhsBindingSource.DataSource = typeof(DAL.DonViTinh);
            // 
            // gridViewDVTNgungSD
            // 
            this.gridViewDVTNgungSD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDVT,
            this.colTenDVT,
            this.gridColumn1});
            this.gridViewDVTNgungSD.GridControl = this.dgvDVTNgungSD;
            this.gridViewDVTNgungSD.Name = "gridViewDVTNgungSD";
            this.gridViewDVTNgungSD.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colMaDVT
            // 
            this.colMaDVT.AppearanceCell.Options.UseTextOptions = true;
            this.colMaDVT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaDVT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMaDVT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaDVT.AppearanceHeader.Options.UseFont = true;
            this.colMaDVT.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaDVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaDVT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMaDVT.Caption = "Mã Đơn Vị Tính";
            this.colMaDVT.FieldName = "MaDVT";
            this.colMaDVT.Name = "colMaDVT";
            this.colMaDVT.OptionsColumn.AllowEdit = false;
            this.colMaDVT.OptionsColumn.ReadOnly = true;
            // 
            // colTenDVT
            // 
            this.colTenDVT.AppearanceCell.Options.UseTextOptions = true;
            this.colTenDVT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenDVT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTenDVT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenDVT.AppearanceHeader.Options.UseFont = true;
            this.colTenDVT.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenDVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenDVT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTenDVT.Caption = "Tên Đơn Vị Tính";
            this.colTenDVT.FieldName = "TenDVT";
            this.colTenDVT.Name = "colTenDVT";
            this.colTenDVT.OptionsColumn.AllowEdit = false;
            this.colTenDVT.OptionsColumn.ReadOnly = true;
            this.colTenDVT.Visible = true;
            this.colTenDVT.VisibleIndex = 0;
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(158, 54);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(192, 20);
            this.txtTuKhoa.TabIndex = 8;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDaiLy.Properties.Resources.Find;
            this.pictureBox1.Location = new System.Drawing.Point(52, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(101, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Tìm kiếm";
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
            this.gridColumn1.Caption = "Tái Sử Dụng";
            this.gridColumn1.ColumnEdit = this.btnTaiSuDung;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // btnTaiSuDung
            // 
            this.btnTaiSuDung.AutoHeight = false;
            this.btnTaiSuDung.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnTaiSuDung.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnTaiSuDung.Name = "btnTaiSuDung";
            this.btnTaiSuDung.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnTaiSuDung.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnTaiSuDung_ButtonClick);
            // 
            // frmDVTNgungKinhDoanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 337);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dgvDVTNgungSD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDVTNgungKinhDoanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Đơn Vị Tính Ngưng Sử Dụng";
            this.Load += new System.EventHandler(this.frmDVTNgungKinhDoanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVTNgungSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDVTNgungSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTaiSuDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvDVTNgungSD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDVTNgungSD;
        private DevExpress.XtraEditors.TextEdit txtTuKhoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource donViTinhsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDVT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnTaiSuDung;
    }
}