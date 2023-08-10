namespace BTL_MNM
{
    partial class MAINFORM
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.TT_TT = new System.Windows.Forms.ToolStripMenuItem();
            this.caLàmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chấmCôngVàLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chấmCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.QLNV,
            this.chấmCôngVàLươngToolStripMenuItem,
            this.quảnLýNghiệpVụToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // QLNV
            // 
            this.QLNV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TT_TT,
            this.caLàmToolStripMenuItem});
            this.QLNV.Name = "QLNV";
            this.QLNV.Size = new System.Drawing.Size(115, 20);
            this.QLNV.Text = "Quản lý nhân viên";
            // 
            // TT_TT
            // 
            this.TT_TT.Name = "TT_TT";
            this.TT_TT.Size = new System.Drawing.Size(180, 22);
            this.TT_TT.Text = "Thông tin";
            this.TT_TT.Click += new System.EventHandler(this.TT_TT_Click);
            // 
            // caLàmToolStripMenuItem
            // 
            this.caLàmToolStripMenuItem.Name = "caLàmToolStripMenuItem";
            this.caLàmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.caLàmToolStripMenuItem.Text = "ca làm";
            // 
            // chấmCôngVàLươngToolStripMenuItem
            // 
            this.chấmCôngVàLươngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chấmCôngToolStripMenuItem,
            this.lươngToolStripMenuItem});
            this.chấmCôngVàLươngToolStripMenuItem.Name = "chấmCôngVàLươngToolStripMenuItem";
            this.chấmCôngVàLươngToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.chấmCôngVàLươngToolStripMenuItem.Text = "Chấm công và lương";
            // 
            // chấmCôngToolStripMenuItem
            // 
            this.chấmCôngToolStripMenuItem.Name = "chấmCôngToolStripMenuItem";
            this.chấmCôngToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.chấmCôngToolStripMenuItem.Text = "chấm công";
            // 
            // lươngToolStripMenuItem
            // 
            this.lươngToolStripMenuItem.Name = "lươngToolStripMenuItem";
            this.lươngToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.lươngToolStripMenuItem.Text = "Lương";
            // 
            // quảnLýNghiệpVụToolStripMenuItem
            // 
            this.quảnLýNghiệpVụToolStripMenuItem.Name = "quảnLýNghiệpVụToolStripMenuItem";
            this.quảnLýNghiệpVụToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.quảnLýNghiệpVụToolStripMenuItem.Text = "Quản lý nghiệp vụ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL_MNM.Properties.Resources.quan_ly_nhan_su_la_gi;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MAINFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 270);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MAINFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAINFORM";
            this.Load += new System.EventHandler(this.MAINFORM_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLNV;
        private System.Windows.Forms.ToolStripMenuItem TT_TT;
        private System.Windows.Forms.ToolStripMenuItem caLàmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chấmCôngVàLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chấmCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNghiệpVụToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}