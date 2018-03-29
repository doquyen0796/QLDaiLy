namespace QLDaiLy
{
    partial class frmTienNoToiDa
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
            this.dgvLoaiDaiLy = new DevExpress.XtraGrid.GridControl();
            this.loaiDaiLiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewLoaiDaiLy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienNoToiDa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTuKhoa = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDaiLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiDaiLiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLoaiDaiLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoaiDaiLy
            // 
            this.dgvLoaiDaiLy.DataSource = this.loaiDaiLiesBindingSource;
            this.dgvLoaiDaiLy.Location = new System.Drawing.Point(64, 105);
            this.dgvLoaiDaiLy.MainView = this.gridViewLoaiDaiLy;
            this.dgvLoaiDaiLy.Name = "dgvLoaiDaiLy";
            this.dgvLoaiDaiLy.Size = new System.Drawing.Size(551, 224);
            this.dgvLoaiDaiLy.TabIndex = 0;
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
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(191, 48);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(305, 20);
            this.txtTuKhoa.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDaiLy.Properties.Resources.Find;
            this.pictureBox1.Location = new System.Drawing.Point(85, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(134, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tìm kiếm";
            // 
            // frmTienNoToiDa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 384);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dgvLoaiDaiLy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTienNoToiDa";
            this.Text = "frmTienNoToiDa";
            this.Load += new System.EventHandler(this.frmTienNoToiDa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDaiLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiDaiLiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLoaiDaiLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvLoaiDaiLy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLoaiDaiLy;
        private DevExpress.XtraEditors.TextEdit txtTuKhoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource loaiDaiLiesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colTienNoToiDa;
    }
}