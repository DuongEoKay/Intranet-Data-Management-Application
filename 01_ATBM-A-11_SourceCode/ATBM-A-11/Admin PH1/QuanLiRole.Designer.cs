namespace phan_he_1
{
    partial class QuanLiRole
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
            textBox_them_role = new TextBox();
            textBox_xoa_role = new TextBox();
            lb_them_role = new Label();
            lb_xoa_role = new Label();
            btn_them_role = new Button();
            btn_xoa_role = new Button();
            lb_gan_role_1 = new Label();
            label1 = new Label();
            comboBox_role = new ComboBox();
            comboBox_user = new ComboBox();
            btn_gan = new Button();
            comboBox_role_revoke = new ComboBox();
            comboBox_user_revoke = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btn_thu_hoi = new Button();
            oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            SuspendLayout();
            // 
            // textBox_them_role
            // 
            textBox_them_role.Font = new Font("Segoe UI", 14.25F);
            textBox_them_role.Location = new Point(292, 119);
            textBox_them_role.Margin = new Padding(4, 3, 4, 3);
            textBox_them_role.Name = "textBox_them_role";
            textBox_them_role.Size = new Size(195, 33);
            textBox_them_role.TabIndex = 0;
            // 
            // textBox_xoa_role
            // 
            textBox_xoa_role.Font = new Font("Segoe UI", 14.25F);
            textBox_xoa_role.Location = new Point(292, 241);
            textBox_xoa_role.Margin = new Padding(4, 3, 4, 3);
            textBox_xoa_role.Name = "textBox_xoa_role";
            textBox_xoa_role.Size = new Size(195, 33);
            textBox_xoa_role.TabIndex = 1;
            // 
            // lb_them_role
            // 
            lb_them_role.AutoSize = true;
            lb_them_role.Font = new Font("Segoe UI", 14.25F);
            lb_them_role.Location = new Point(46, 119);
            lb_them_role.Margin = new Padding(4, 0, 4, 0);
            lb_them_role.Name = "lb_them_role";
            lb_them_role.Size = new Size(219, 25);
            lb_them_role.TabIndex = 2;
            lb_them_role.Text = "Nhap Role ban can them";
            // 
            // lb_xoa_role
            // 
            lb_xoa_role.AutoSize = true;
            lb_xoa_role.Font = new Font("Segoe UI", 14.25F);
            lb_xoa_role.Location = new Point(49, 241);
            lb_xoa_role.Margin = new Padding(4, 0, 4, 0);
            lb_xoa_role.Name = "lb_xoa_role";
            lb_xoa_role.Size = new Size(206, 25);
            lb_xoa_role.TabIndex = 3;
            lb_xoa_role.Text = "Nhap Role ban can xoa";
            // 
            // btn_them_role
            // 
            btn_them_role.BackColor = Color.IndianRed;
            btn_them_role.Font = new Font("Segoe UI", 14.25F);
            btn_them_role.ForeColor = Color.White;
            btn_them_role.Location = new Point(586, 114);
            btn_them_role.Margin = new Padding(4, 3, 4, 3);
            btn_them_role.Name = "btn_them_role";
            btn_them_role.Size = new Size(139, 38);
            btn_them_role.TabIndex = 4;
            btn_them_role.Text = "Them";
            btn_them_role.UseVisualStyleBackColor = false;
            btn_them_role.Click += btn_them_role_Click;
            // 
            // btn_xoa_role
            // 
            btn_xoa_role.BackColor = Color.IndianRed;
            btn_xoa_role.Font = new Font("Segoe UI", 14.25F);
            btn_xoa_role.ForeColor = Color.White;
            btn_xoa_role.Location = new Point(586, 237);
            btn_xoa_role.Margin = new Padding(4, 3, 4, 3);
            btn_xoa_role.Name = "btn_xoa_role";
            btn_xoa_role.Size = new Size(139, 37);
            btn_xoa_role.TabIndex = 5;
            btn_xoa_role.Text = "Xoa";
            btn_xoa_role.UseVisualStyleBackColor = false;
            btn_xoa_role.Click += btn_xoa_role_Click;
            // 
            // lb_gan_role_1
            // 
            lb_gan_role_1.AutoSize = true;
            lb_gan_role_1.Font = new Font("Segoe UI", 14.25F);
            lb_gan_role_1.Location = new Point(126, 351);
            lb_gan_role_1.Margin = new Padding(4, 0, 4, 0);
            lb_gan_role_1.Name = "lb_gan_role_1";
            lb_gan_role_1.Size = new Size(87, 25);
            lb_gan_role_1.TabIndex = 8;
            lb_gan_role_1.Text = "Gan Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(506, 351);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 9;
            label1.Text = "cho User";
            label1.Click += label1_Click;
            // 
            // comboBox_role
            // 
            comboBox_role.Font = new Font("Segoe UI", 14.25F);
            comboBox_role.FormattingEnabled = true;
            comboBox_role.Location = new Point(289, 347);
            comboBox_role.Margin = new Padding(4, 3, 4, 3);
            comboBox_role.Name = "comboBox_role";
            comboBox_role.Size = new Size(195, 33);
            comboBox_role.TabIndex = 10;
            // 
            // comboBox_user
            // 
            comboBox_user.Font = new Font("Segoe UI", 14.25F);
            comboBox_user.FormattingEnabled = true;
            comboBox_user.Location = new Point(626, 347);
            comboBox_user.Margin = new Padding(4, 3, 4, 3);
            comboBox_user.Name = "comboBox_user";
            comboBox_user.Size = new Size(195, 33);
            comboBox_user.TabIndex = 11;
            // 
            // btn_gan
            // 
            btn_gan.BackColor = Color.IndianRed;
            btn_gan.Font = new Font("Segoe UI", 14.25F);
            btn_gan.ForeColor = Color.White;
            btn_gan.Location = new Point(862, 347);
            btn_gan.Margin = new Padding(4, 3, 4, 3);
            btn_gan.Name = "btn_gan";
            btn_gan.Size = new Size(157, 43);
            btn_gan.TabIndex = 12;
            btn_gan.Text = "Gan";
            btn_gan.UseVisualStyleBackColor = false;
            btn_gan.Click += btn_gan_Click;
            // 
            // comboBox_role_revoke
            // 
            comboBox_role_revoke.Font = new Font("Segoe UI", 14.25F);
            comboBox_role_revoke.FormattingEnabled = true;
            comboBox_role_revoke.Location = new Point(626, 475);
            comboBox_role_revoke.Margin = new Padding(4, 3, 4, 3);
            comboBox_role_revoke.Name = "comboBox_role_revoke";
            comboBox_role_revoke.Size = new Size(195, 33);
            comboBox_role_revoke.TabIndex = 13;
            // 
            // comboBox_user_revoke
            // 
            comboBox_user_revoke.Font = new Font("Segoe UI", 14.25F);
            comboBox_user_revoke.FormattingEnabled = true;
            comboBox_user_revoke.Location = new Point(292, 475);
            comboBox_user_revoke.Margin = new Padding(4, 3, 4, 3);
            comboBox_user_revoke.Name = "comboBox_user_revoke";
            comboBox_user_revoke.Size = new Size(193, 33);
            comboBox_user_revoke.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(88, 480);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 15;
            label2.Text = "User can thu hoi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(506, 480);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 25);
            label3.TabIndex = 16;
            label3.Text = "thu hoi Role";
            // 
            // btn_thu_hoi
            // 
            btn_thu_hoi.BackColor = Color.IndianRed;
            btn_thu_hoi.Font = new Font("Segoe UI", 14.25F);
            btn_thu_hoi.ForeColor = Color.White;
            btn_thu_hoi.Location = new Point(862, 472);
            btn_thu_hoi.Margin = new Padding(4, 3, 4, 3);
            btn_thu_hoi.Name = "btn_thu_hoi";
            btn_thu_hoi.Size = new Size(157, 36);
            btn_thu_hoi.TabIndex = 17;
            btn_thu_hoi.Text = "Thu hoi";
            btn_thu_hoi.UseVisualStyleBackColor = false;
            btn_thu_hoi.Click += btn_thu_hoi_Click;
            // 
            // oracleCommand1
            // 
            oracleCommand1.Transaction = null;
            // 
            // QuanLiRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 658);
            Controls.Add(btn_thu_hoi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox_user_revoke);
            Controls.Add(comboBox_role_revoke);
            Controls.Add(btn_gan);
            Controls.Add(comboBox_user);
            Controls.Add(comboBox_role);
            Controls.Add(label1);
            Controls.Add(lb_gan_role_1);
            Controls.Add(btn_xoa_role);
            Controls.Add(btn_them_role);
            Controls.Add(lb_xoa_role);
            Controls.Add(lb_them_role);
            Controls.Add(textBox_xoa_role);
            Controls.Add(textBox_them_role);
            Margin = new Padding(4, 3, 4, 3);
            Name = "QuanLiRole";
            Text = "TaoRole";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_them_role;
        private System.Windows.Forms.TextBox textBox_xoa_role;
        private System.Windows.Forms.Label lb_them_role;
        private System.Windows.Forms.Label lb_xoa_role;
        private System.Windows.Forms.Button btn_them_role;
        private System.Windows.Forms.Button btn_xoa_role;
        private System.Windows.Forms.Label lb_gan_role_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.ComboBox comboBox_user;
        private System.Windows.Forms.Button btn_gan;
        private System.Windows.Forms.ComboBox comboBox_role_revoke;
        private System.Windows.Forms.ComboBox comboBox_user_revoke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_thu_hoi;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
    }
}