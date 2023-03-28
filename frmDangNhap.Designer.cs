namespace datdeptraibodoi
{
    partial class FrmTrangChu
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
            this.btndangnhap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chkNhoMK = new System.Windows.Forms.CheckBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.lblTenTK = new System.Windows.Forms.Label();
            this.lblMK = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btndangnhap
            // 
            this.btndangnhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.Location = new System.Drawing.Point(181, 236);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(99, 28);
            this.btndangnhap.TabIndex = 0;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(438, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // chkNhoMK
            // 
            this.chkNhoMK.AutoSize = true;
            this.chkNhoMK.Location = new System.Drawing.Point(318, 169);
            this.chkNhoMK.Name = "chkNhoMK";
            this.chkNhoMK.Size = new System.Drawing.Size(111, 20);
            this.chkNhoMK.TabIndex = 2;
            this.chkNhoMK.Text = "Nhớ mật khẩu";
            this.chkNhoMK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNhoMK.UseVisualStyleBackColor = true;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(280, 44);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(217, 22);
            this.txtTenTK.TabIndex = 3;
            this.txtTenTK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(280, 105);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(217, 22);
            this.txtMK.TabIndex = 4;
            this.txtMK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTK.Location = new System.Drawing.Point(65, 44);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(141, 20);
            this.lblTenTK.TabIndex = 5;
            this.lblTenTK.Text = "Tên Tài Khoản : ";
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMK.Location = new System.Drawing.Point(65, 105);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(99, 20);
            this.lblMK.TabIndex = 6;
            this.lblMK.Text = "Mật Khẩu :";
            // 
            // FrmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 332);
            this.Controls.Add(this.lblMK);
            this.Controls.Add(this.lblTenTK);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.chkNhoMK);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btndangnhap);
            this.Name = "FrmTrangChu";
            this.Text = "Trang chủ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkNhoMK;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label lblTenTK;
        private System.Windows.Forms.Label lblMK;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

