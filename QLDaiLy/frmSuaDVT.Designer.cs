namespace QLDaiLy
{
    partial class frmSuaDVT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaDVT));
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenDVT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ErrorChecker = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaDVT = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorChecker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDVT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(212, 112);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 23);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTenDVT
            // 
            this.txtTenDVT.Location = new System.Drawing.Point(135, 49);
            this.txtTenDVT.Name = "txtTenDVT";
            this.txtTenDVT.Size = new System.Drawing.Size(171, 20);
            this.txtTenDVT.TabIndex = 6;
            this.txtTenDVT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDVT_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Location = new System.Drawing.Point(104, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(14, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "(*)";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tên đơn vị tính";
            // 
            // ErrorChecker
            // 
            this.ErrorChecker.ContainerControl = this;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 112);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Mã DVT";
            this.labelControl3.Visible = false;
            // 
            // txtMaDVT
            // 
            this.txtMaDVT.Location = new System.Drawing.Point(81, 105);
            this.txtMaDVT.Name = "txtMaDVT";
            this.txtMaDVT.Properties.ReadOnly = true;
            this.txtMaDVT.Size = new System.Drawing.Size(61, 20);
            this.txtMaDVT.TabIndex = 9;
            this.txtMaDVT.Visible = false;
            // 
            // frmSuaDVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 168);
            this.Controls.Add(this.txtMaDVT);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtTenDVT);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSuaDVT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Thông Tin Đơn Vị Tính";
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorChecker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDVT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ErrorProvider ErrorChecker;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.TextEdit txtTenDVT;
        public DevExpress.XtraEditors.TextEdit txtMaDVT;
    }
}