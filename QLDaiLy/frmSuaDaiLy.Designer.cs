namespace QLDaiLy
{
    partial class frmSuaDaiLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaDaiLy));
            this.dtpNgayTiepNhan = new DevExpress.XtraEditors.DateEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbQuan = new DevExpress.XtraEditors.LookUpEdit();
            this.cbLoaiDL = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDaiLy = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ErrorChecker = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaDaiLy = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayTiepNhan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayTiepNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbQuan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLoaiDL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDaiLy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorChecker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDaiLy.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayTiepNhan
            // 
            this.dtpNgayTiepNhan.EditValue = new System.DateTime(2018, 3, 16, 22, 36, 5, 100);
            this.dtpNgayTiepNhan.Location = new System.Drawing.Point(147, 45);
            this.dtpNgayTiepNhan.Name = "dtpNgayTiepNhan";
            this.dtpNgayTiepNhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayTiepNhan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayTiepNhan.Size = new System.Drawing.Size(131, 20);
            this.dtpNgayTiepNhan.TabIndex = 38;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(46, 48);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(76, 13);
            this.labelControl10.TabIndex = 37;
            this.labelControl10.Text = "Ngày Tiếp Nhận";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl9.Location = new System.Drawing.Point(86, 224);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(14, 13);
            this.labelControl9.TabIndex = 36;
            this.labelControl9.Text = "(*)";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Location = new System.Drawing.Point(104, 134);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(14, 13);
            this.labelControl8.TabIndex = 35;
            this.labelControl8.Text = "(*)";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Location = new System.Drawing.Point(78, 181);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(14, 13);
            this.labelControl7.TabIndex = 34;
            this.labelControl7.Text = "(*)";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl6.Location = new System.Drawing.Point(103, 89);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(14, 13);
            this.labelControl6.TabIndex = 33;
            this.labelControl6.Text = "(*)";
            // 
            // cbQuan
            // 
            this.cbQuan.Location = new System.Drawing.Point(147, 178);
            this.cbQuan.Name = "cbQuan";
            this.cbQuan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbQuan.Size = new System.Drawing.Size(223, 20);
            this.cbQuan.TabIndex = 32;
            // 
            // cbLoaiDL
            // 
            this.cbLoaiDL.Location = new System.Drawing.Point(147, 131);
            this.cbLoaiDL.Name = "cbLoaiDL";
            this.cbLoaiDL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLoaiDL.Size = new System.Drawing.Size(223, 20);
            this.cbLoaiDL.TabIndex = 31;
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(351, 329);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(158, 23);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Cập nhật thông tin";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(147, 266);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(294, 20);
            this.txtEmail.TabIndex = 28;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(147, 221);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(294, 20);
            this.txtDiaChi.TabIndex = 27;
            this.txtDiaChi.Leave += new System.EventHandler(this.txtDiaChi_Leave);
            // 
            // txtTenDaiLy
            // 
            this.txtTenDaiLy.Location = new System.Drawing.Point(147, 86);
            this.txtTenDaiLy.Name = "txtTenDaiLy";
            this.txtTenDaiLy.Size = new System.Drawing.Size(294, 20);
            this.txtTenDaiLy.TabIndex = 26;
            this.txtTenDaiLy.Leave += new System.EventHandler(this.txtTenDaiLy_Leave);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(46, 269);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 13);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Email";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(46, 181);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Quận";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(46, 224);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Địa Chỉ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(46, 134);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Loại Đại Lý";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(46, 89);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Tên Đại Lý";
            // 
            // ErrorChecker
            // 
            this.ErrorChecker.ContainerControl = this;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(438, 15);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(30, 13);
            this.labelControl11.TabIndex = 39;
            this.labelControl11.Text = "Mã ĐL";
            this.labelControl11.Visible = false;
            // 
            // txtMaDaiLy
            // 
            this.txtMaDaiLy.Location = new System.Drawing.Point(474, 12);
            this.txtMaDaiLy.Name = "txtMaDaiLy";
            this.txtMaDaiLy.Size = new System.Drawing.Size(61, 20);
            this.txtMaDaiLy.TabIndex = 40;
            this.txtMaDaiLy.Visible = false;
            // 
            // frmSuaDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 397);
            this.Controls.Add(this.txtMaDaiLy);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.dtpNgayTiepNhan);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.cbQuan);
            this.Controls.Add(this.cbLoaiDL);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenDaiLy);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSuaDaiLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Thông Tin Đại Lý";
            this.Load += new System.EventHandler(this.frmSuaDaiLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayTiepNhan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayTiepNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbQuan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLoaiDL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDaiLy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorChecker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDaiLy.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ErrorProvider ErrorChecker;
        public DevExpress.XtraEditors.DateEdit dtpNgayTiepNhan;
        public DevExpress.XtraEditors.LookUpEdit cbQuan;
        public DevExpress.XtraEditors.LookUpEdit cbLoaiDL;
        public DevExpress.XtraEditors.TextEdit txtEmail;
        public DevExpress.XtraEditors.TextEdit txtDiaChi;
        public DevExpress.XtraEditors.TextEdit txtTenDaiLy;
        public DevExpress.XtraEditors.TextEdit txtMaDaiLy;
        private DevExpress.XtraEditors.LabelControl labelControl11;
    }
}