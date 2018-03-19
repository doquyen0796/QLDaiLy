namespace QLDaiLy
{
    partial class frmSuaHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaHangHoa));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaHH = new DevExpress.XtraEditors.TextEdit();
            this.txtTenHangHoa = new DevExpress.XtraEditors.TextEdit();
            this.cbDVT = new DevExpress.XtraEditors.LookUpEdit();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.ErrorChecker = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHangHoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorChecker)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(382, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã HH";
            this.labelControl1.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(45, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên hàng hóa";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(43, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Đơn vị tính";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(43, 151);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Đơn giá";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl6.Location = new System.Drawing.Point(117, 55);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(14, 13);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "(*)";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Location = new System.Drawing.Point(101, 101);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(14, 13);
            this.labelControl5.TabIndex = 35;
            this.labelControl5.Text = "(*)";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Location = new System.Drawing.Point(86, 151);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(14, 13);
            this.labelControl7.TabIndex = 36;
            this.labelControl7.Text = "(*)";
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(419, 12);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(74, 20);
            this.txtMaHH.TabIndex = 37;
            this.txtMaHH.Visible = false;
            // 
            // txtTenHangHoa
            // 
            this.txtTenHangHoa.Location = new System.Drawing.Point(157, 52);
            this.txtTenHangHoa.Name = "txtTenHangHoa";
            this.txtTenHangHoa.Size = new System.Drawing.Size(277, 20);
            this.txtTenHangHoa.TabIndex = 38;
            this.txtTenHangHoa.Leave += new System.EventHandler(this.txtTenHangHoa_Leave);
            // 
            // cbDVT
            // 
            this.cbDVT.Location = new System.Drawing.Point(157, 98);
            this.cbDVT.Name = "cbDVT";
            this.cbDVT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDVT.Size = new System.Drawing.Size(116, 20);
            this.cbDVT.TabIndex = 39;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(157, 148);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(156, 20);
            this.txtDonGia.TabIndex = 40;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            this.txtDonGia.Leave += new System.EventHandler(this.txtDonGia_Leave);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(287, 206);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(166, 23);
            this.btnSua.TabIndex = 41;
            this.btnSua.Text = "Cập nhật thông tin";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // ErrorChecker
            // 
            this.ErrorChecker.ContainerControl = this;
            // 
            // frmSuaHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 260);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.cbDVT);
            this.Controls.Add(this.txtTenHangHoa);
            this.Controls.Add(this.txtMaHH);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSuaHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Thông Tin Hàng Hóa";
            this.Load += new System.EventHandler(this.frmSuaHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHangHoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorChecker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        public DevExpress.XtraEditors.TextEdit txtMaHH;
        public DevExpress.XtraEditors.TextEdit txtTenHangHoa;
        public DevExpress.XtraEditors.LookUpEdit cbDVT;
        public DevExpress.XtraEditors.TextEdit txtDonGia;
        private System.Windows.Forms.ErrorProvider ErrorChecker;
    }
}