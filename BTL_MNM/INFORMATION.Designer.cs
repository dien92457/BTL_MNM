namespace BTL_MNM
{
    partial class INFORMATION
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
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.text_phan_quyen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(224, 62);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(282, 26);
            this.txt_ten.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Nhân Viên";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(224, 128);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(282, 26);
            this.txt_id.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(46, 271);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(112, 31);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "them";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(279, 271);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(112, 31);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xoa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(168, 351);
            this.btn_capnhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(112, 31);
            this.btn_capnhat.TabIndex = 3;
            this.btn_capnhat.Text = "cap nhat";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(539, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(322, 269);
            this.dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phân Quyền";
            // 
            // text_phan_quyen
            // 
            this.text_phan_quyen.Location = new System.Drawing.Point(224, 194);
            this.text_phan_quyen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_phan_quyen.Name = "text_phan_quyen";
            this.text_phan_quyen.Size = new System.Drawing.Size(282, 26);
            this.text_phan_quyen.TabIndex = 5;
            // 
            // INFORMATION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 394);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_phan_quyen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_ten);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "INFORMATION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INFORMATION";
            this.Load += new System.EventHandler(this.INFORMATION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_phan_quyen;
    }
}