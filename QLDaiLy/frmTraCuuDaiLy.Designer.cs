namespace QLDaiLy
{
    partial class frmTraCuuDaiLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuDaiLy));
            this.txtTenDaiLy = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbQuan = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbLoaiDL = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoTu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoDen = new DevExpress.XtraEditors.TextEdit();
            this.dgvDaiLy = new DevExpress.XtraGrid.GridControl();
            this.daiLiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewDaiLy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDaiLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDaiLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiDaiLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTiepNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDaiLy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbQuan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLoaiDL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoDen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaiLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daiLiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDaiLy)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenDaiLy
            // 
            this.txtTenDaiLy.Location = new System.Drawing.Point(217, 46);
            this.txtTenDaiLy.Name = "txtTenDaiLy";
            this.txtTenDaiLy.Size = new System.Drawing.Size(481, 20);
            this.txtTenDaiLy.TabIndex = 7;
            this.txtTenDaiLy.TextChanged += new System.EventHandler(this.txtTenDaiLy_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(138, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Tên đại lý";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(138, 95);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Quận";
            // 
            // cbQuan
            // 
            this.cbQuan.Location = new System.Drawing.Point(217, 92);
            this.cbQuan.Name = "cbQuan";
            this.cbQuan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbQuan.Size = new System.Drawing.Size(138, 20);
            this.cbQuan.TabIndex = 9;
            this.cbQuan.EditValueChanged += new System.EventHandler(this.cbQuan_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(411, 95);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Loại đại lý";
            // 
            // cbLoaiDL
            // 
            this.cbLoaiDL.Location = new System.Drawing.Point(493, 92);
            this.cbLoaiDL.Name = "cbLoaiDL";
            this.cbLoaiDL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLoaiDL.Size = new System.Drawing.Size(205, 20);
            this.cbLoaiDL.TabIndex = 11;
            this.cbLoaiDL.EditValueChanged += new System.EventHandler(this.cbLoaiDL_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(138, 143);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Nợ từ";
            // 
            // txtNoTu
            // 
            this.txtNoTu.Location = new System.Drawing.Point(217, 140);
            this.txtNoTu.Name = "txtNoTu";
            this.txtNoTu.Size = new System.Drawing.Size(138, 20);
            this.txtNoTu.TabIndex = 13;
            this.txtNoTu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoTu_KeyPress);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(411, 143);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(18, 13);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "đến";
            // 
            // txtNoDen
            // 
            this.txtNoDen.Location = new System.Drawing.Point(493, 140);
            this.txtNoDen.Name = "txtNoDen";
            this.txtNoDen.Size = new System.Drawing.Size(138, 20);
            this.txtNoDen.TabIndex = 15;
            this.txtNoDen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoDen_KeyPress);
            // 
            // dgvDaiLy
            // 
            this.dgvDaiLy.DataSource = this.daiLiesBindingSource;
            this.dgvDaiLy.Location = new System.Drawing.Point(36, 203);
            this.dgvDaiLy.MainView = this.gridViewDaiLy;
            this.dgvDaiLy.Name = "dgvDaiLy";
            this.dgvDaiLy.Size = new System.Drawing.Size(1147, 228);
            this.dgvDaiLy.TabIndex = 16;
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
            this.colLoaiDaiLy,
            this.colDiaChi,
            this.colQuan,
            this.colNgayTiepNhan,
            this.colEmail,
            this.colTienNo});
            this.gridViewDaiLy.GridControl = this.dgvDaiLy;
            this.gridViewDaiLy.Name = "gridViewDaiLy";
            this.gridViewDaiLy.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
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
            this.colMaDaiLy.Visible = true;
            this.colMaDaiLy.VisibleIndex = 0;
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
            this.colTenDaiLy.VisibleIndex = 1;
            // 
            // colLoaiDaiLy
            // 
            this.colLoaiDaiLy.AppearanceCell.Options.UseTextOptions = true;
            this.colLoaiDaiLy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoaiDaiLy.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLoaiDaiLy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colLoaiDaiLy.AppearanceHeader.Options.UseFont = true;
            this.colLoaiDaiLy.AppearanceHeader.Options.UseTextOptions = true;
            this.colLoaiDaiLy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoaiDaiLy.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLoaiDaiLy.Caption = "Loại Đại Lý";
            this.colLoaiDaiLy.FieldName = "LoaiDaiLy.TenLoai";
            this.colLoaiDaiLy.Name = "colLoaiDaiLy";
            this.colLoaiDaiLy.OptionsColumn.AllowEdit = false;
            this.colLoaiDaiLy.OptionsColumn.ReadOnly = true;
            this.colLoaiDaiLy.Visible = true;
            this.colLoaiDaiLy.VisibleIndex = 7;
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
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(724, 138);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(106, 23);
            this.btnTim.TabIndex = 17;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmTraCuuDaiLy
            // 
            this.AcceptButton = this.btnTim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 457);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvDaiLy);
            this.Controls.Add(this.txtNoDen);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtNoTu);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbLoaiDL);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cbQuan);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtTenDaiLy);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTraCuuDaiLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra Cứu Đại Lý";
            this.Load += new System.EventHandler(this.frmTraCuuDaiLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDaiLy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbQuan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLoaiDL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoDen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaiLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daiLiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDaiLy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTenDaiLy;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit cbQuan;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit cbLoaiDL;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNoTu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtNoDen;
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
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiDaiLy;
        private DevExpress.XtraEditors.SimpleButton btnTim;
    }
}