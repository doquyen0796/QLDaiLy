namespace QLDaiLy
{
    partial class frmQuiDinh
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Số Đại Lý Tối Đa");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Đại Lý", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Tiền Nợ Tối Đa");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Loại Đại Lý", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.treeViewOptions = new System.Windows.Forms.TreeView();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeViewOptions
            // 
            this.treeViewOptions.Location = new System.Drawing.Point(35, 39);
            this.treeViewOptions.Name = "treeViewOptions";
            treeNode13.Name = "NodeSoDaiLyToiDa";
            treeNode13.Text = "Số Đại Lý Tối Đa";
            treeNode14.Name = "NodeDaiLy";
            treeNode14.Text = "Đại Lý";
            treeNode15.Name = "NodeTienNoToiDa";
            treeNode15.Text = "Tiền Nợ Tối Đa";
            treeNode16.Name = "NodeLoaiDaiLy";
            treeNode16.Text = "Loại Đại Lý";
            this.treeViewOptions.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode16});
            this.treeViewOptions.Size = new System.Drawing.Size(195, 246);
            this.treeViewOptions.TabIndex = 0;
            this.treeViewOptions.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewOptions_AfterSelect);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Location = new System.Drawing.Point(265, 39);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(835, 352);
            this.MainPanel.TabIndex = 1;
            // 
            // frmQuiDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 437);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.treeViewOptions);
            this.Name = "frmQuiDinh";
            this.Text = "Qui Định";
            this.Load += new System.EventHandler(this.frmQuiDinh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewOptions;
        private System.Windows.Forms.Panel MainPanel;
    }
}