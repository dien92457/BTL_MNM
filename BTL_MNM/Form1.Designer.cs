namespace BTL_MNM
{
    partial class ĐN
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
            this.TXT_TEN = new System.Windows.Forms.TextBox();
            this.TXT_MK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_DN = new System.Windows.Forms.Button();
            this.BTN_DX = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_TEN
            // 
            this.TXT_TEN.Location = new System.Drawing.Point(160, 93);
            this.TXT_TEN.Name = "TXT_TEN";
            this.TXT_TEN.Size = new System.Drawing.Size(209, 20);
            this.TXT_TEN.TabIndex = 2;
            // 
            // TXT_MK
            // 
            this.TXT_MK.Location = new System.Drawing.Point(160, 150);
            this.TXT_MK.Name = "TXT_MK";
            this.TXT_MK.Size = new System.Drawing.Size(209, 20);
            this.TXT_MK.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // BTN_DN
            // 
            this.BTN_DN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DN.Location = new System.Drawing.Point(99, 206);
            this.BTN_DN.Name = "BTN_DN";
            this.BTN_DN.Size = new System.Drawing.Size(95, 35);
            this.BTN_DN.TabIndex = 4;
            this.BTN_DN.Text = "Đăng nhập";
            this.BTN_DN.UseVisualStyleBackColor = true;
            this.BTN_DN.Click += new System.EventHandler(this.BTN_DN_Click);
            // 
            // BTN_DX
            // 
            this.BTN_DX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DX.Location = new System.Drawing.Point(351, 206);
            this.BTN_DX.Name = "BTN_DX";
            this.BTN_DX.Size = new System.Drawing.Size(95, 35);
            this.BTN_DX.TabIndex = 4;
            this.BTN_DX.Text = "Đăng xuất";
            this.BTN_DX.UseVisualStyleBackColor = true;
            this.BTN_DX.Click += new System.EventHandler(this.BTN_DX_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL_MNM.Properties.Resources.quan_ly_nhan_su_la_gi;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ĐN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 253);
            this.Controls.Add(this.BTN_DX);
            this.Controls.Add(this.BTN_DN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_MK);
            this.Controls.Add(this.TXT_TEN);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ĐN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TXT_TEN;
        private System.Windows.Forms.TextBox TXT_MK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_DN;
        private System.Windows.Forms.Button BTN_DX;
    }
}

