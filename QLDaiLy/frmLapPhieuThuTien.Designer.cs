namespace QLDaiLy
{
    partial class frmLapPhieuThuTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLapPhieuThuTien));
            this.cbDaiLy = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbDiaChi = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbTienNo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbEmail = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dtpNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoTienThu = new DevExpress.XtraEditors.TextEdit();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.ErrorChecker = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cbDaiLy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienThu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorChecker)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDaiLy
            // 
            this.cbDaiLy.Location = new System.Drawing.Point(149, 44);
            this.cbDaiLy.Name = "cbDaiLy";
            this.cbDaiLy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDaiLy.Size = new System.Drawing.Size(208, 20);
            this.cbDaiLy.TabIndex = 1;
            this.cbDaiLy.EditValueChanged += new System.EventHandler(this.cbDaiLy_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(41, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Đại lý";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(149, 104);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(45, 13);
            this.lbDiaChi.TabIndex = 2;
            this.lbDiaChi.Text = "lbDiaChi";
            this.lbDiaChi.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(41, 104);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Địa chỉ";
            // 
            // lbTienNo
            // 
            this.lbTienNo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienNo.Location = new System.Drawing.Point(149, 155);
            this.lbTienNo.Name = "lbTienNo";
            this.lbTienNo.Size = new System.Drawing.Size(48, 13);
            this.lbTienNo.TabIndex = 4;
            this.lbTienNo.Text = "lbTienNo";
            this.lbTienNo.Visible = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(41, 155);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Tiền nợ hiện tại";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(425, 104);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Email";
            // 
            // lbEmail
            // 
            this.lbEmail.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(526, 104);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(40, 13);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "lbEmail";
            this.lbEmail.Visible = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(425, 47);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Ngày thu tiền";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.EditValue = null;
            this.dtpNgayLap.Location = new System.Drawing.Point(526, 44);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayLap.Size = new System.Drawing.Size(114, 20);
            this.dtpNgayLap.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl6.Location = new System.Drawing.Point(41, 231);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(70, 14);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Số tiền thu";
            // 
            // txtSoTienThu
            // 
            this.txtSoTienThu.Location = new System.Drawing.Point(149, 229);
            this.txtSoTienThu.Name = "txtSoTienThu";
            this.txtSoTienThu.Size = new System.Drawing.Size(154, 20);
            this.txtSoTienThu.TabIndex = 3;
            this.txtSoTienThu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTienThu_KeyPress);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(438, 291);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(163, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Lập phiếu thu";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ErrorChecker
            // 
            this.ErrorChecker.ContainerControl = this;
            // 
            // frmLapPhieuThuTien
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 361);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoTienThu);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lbTienNo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbDaiLy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLapPhieuThuTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Phiếu Thu Tiền";
            this.Load += new System.EventHandler(this.frmLapPhieuThuTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbDaiLy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienThu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorChecker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cbDaiLy;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbTienNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lbEmail;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dtpNgayLap;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSoTienThu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.ErrorProvider ErrorChecker;
    }
}