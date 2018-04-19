namespace QLDaiLy
{
    partial class frmSoDaiLyToiDa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSoDaiLyToiDa));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoDLToiDa = new DevExpress.XtraEditors.TextEdit();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.ErrorChecker = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDLToiDa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorChecker)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(147, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Số đại lý tối đa trong một quận";
            // 
            // txtSoDLToiDa
            // 
            this.txtSoDLToiDa.Location = new System.Drawing.Point(226, 62);
            this.txtSoDLToiDa.Name = "txtSoDLToiDa";
            this.txtSoDLToiDa.Size = new System.Drawing.Size(97, 20);
            this.txtSoDLToiDa.TabIndex = 1;
            this.txtSoDLToiDa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDLToiDa_KeyPress);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(244, 118);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(102, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // ErrorChecker
            // 
            this.ErrorChecker.ContainerControl = this;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Location = new System.Drawing.Point(192, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(14, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "(*)";
            // 
            // frmSoDaiLyToiDa
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 182);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtSoDLToiDa);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSoDaiLyToiDa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài Đặt";
            this.Load += new System.EventHandler(this.frmSoDaiLyToiDa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDLToiDa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorChecker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSoDLToiDa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.ErrorProvider ErrorChecker;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}