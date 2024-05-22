namespace phan_he_1
{
    partial class Form_EditUser
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
            textBox_user = new TextBox();
            textBox_new_pass = new TextBox();
            lb_name = new Label();
            lb_new_pass = new Label();
            btn_doi_mat_khau = new Button();
            btn_xoa_user = new Button();
            btn_tao_user = new Button();
            checkBox_cascade = new CheckBox();
            SuspendLayout();
            // 
            // textBox_user
            // 
            textBox_user.Font = new Font("Segoe UI", 14.25F);
            textBox_user.Location = new Point(334, 199);
            textBox_user.Margin = new Padding(4, 3, 4, 3);
            textBox_user.Name = "textBox_user";
            textBox_user.Size = new Size(224, 33);
            textBox_user.TabIndex = 0;
            // 
            // textBox_new_pass
            // 
            textBox_new_pass.Font = new Font("Segoe UI", 14.25F);
            textBox_new_pass.Location = new Point(334, 285);
            textBox_new_pass.Margin = new Padding(4, 3, 4, 3);
            textBox_new_pass.Name = "textBox_new_pass";
            textBox_new_pass.Size = new Size(224, 33);
            textBox_new_pass.TabIndex = 2;
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 14.25F);
            lb_name.Location = new Point(200, 207);
            lb_name.Margin = new Padding(4, 0, 4, 0);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(97, 25);
            lb_name.TabIndex = 3;
            lb_name.Text = "Username";
            // 
            // lb_new_pass
            // 
            lb_new_pass.AutoSize = true;
            lb_new_pass.Font = new Font("Segoe UI", 14.25F);
            lb_new_pass.Location = new Point(200, 294);
            lb_new_pass.Margin = new Padding(4, 0, 4, 0);
            lb_new_pass.Name = "lb_new_pass";
            lb_new_pass.Size = new Size(131, 25);
            lb_new_pass.TabIndex = 5;
            lb_new_pass.Text = "Mat Khau Moi";
            // 
            // btn_doi_mat_khau
            // 
            btn_doi_mat_khau.BackColor = Color.IndianRed;
            btn_doi_mat_khau.Font = new Font("Segoe UI", 14.25F);
            btn_doi_mat_khau.ForeColor = Color.White;
            btn_doi_mat_khau.Location = new Point(679, 39);
            btn_doi_mat_khau.Margin = new Padding(4, 3, 4, 3);
            btn_doi_mat_khau.Name = "btn_doi_mat_khau";
            btn_doi_mat_khau.Size = new Size(203, 112);
            btn_doi_mat_khau.TabIndex = 6;
            btn_doi_mat_khau.Text = "Doi Mat Khau";
            btn_doi_mat_khau.UseVisualStyleBackColor = false;
            btn_doi_mat_khau.Click += btn_enter_Click;
            // 
            // btn_xoa_user
            // 
            btn_xoa_user.BackColor = Color.IndianRed;
            btn_xoa_user.Font = new Font("Segoe UI", 14.25F);
            btn_xoa_user.ForeColor = Color.White;
            btn_xoa_user.Location = new Point(679, 207);
            btn_xoa_user.Margin = new Padding(4, 3, 4, 3);
            btn_xoa_user.Name = "btn_xoa_user";
            btn_xoa_user.Size = new Size(203, 130);
            btn_xoa_user.TabIndex = 7;
            btn_xoa_user.Text = "Xoa Tai Khoan";
            btn_xoa_user.UseVisualStyleBackColor = false;
            btn_xoa_user.Click += button1_Click;
            // 
            // btn_tao_user
            // 
            btn_tao_user.BackColor = Color.IndianRed;
            btn_tao_user.Font = new Font("Segoe UI", 14.25F);
            btn_tao_user.ForeColor = Color.White;
            btn_tao_user.Location = new Point(679, 432);
            btn_tao_user.Margin = new Padding(4, 3, 4, 3);
            btn_tao_user.Name = "btn_tao_user";
            btn_tao_user.Size = new Size(203, 122);
            btn_tao_user.TabIndex = 8;
            btn_tao_user.Text = "Tao Tai Khoan";
            btn_tao_user.UseVisualStyleBackColor = false;
            btn_tao_user.Click += btn_tao_user_Click;
            // 
            // checkBox_cascade
            // 
            checkBox_cascade.AutoSize = true;
            checkBox_cascade.Font = new Font("Segoe UI", 14.25F);
            checkBox_cascade.Location = new Point(908, 271);
            checkBox_cascade.Margin = new Padding(4, 3, 4, 3);
            checkBox_cascade.Name = "checkBox_cascade";
            checkBox_cascade.Size = new Size(115, 29);
            checkBox_cascade.TabIndex = 9;
            checkBox_cascade.Text = "Cascade ?";
            checkBox_cascade.UseVisualStyleBackColor = true;
            // 
            // Form_EditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 691);
            Controls.Add(checkBox_cascade);
            Controls.Add(btn_tao_user);
            Controls.Add(btn_xoa_user);
            Controls.Add(btn_doi_mat_khau);
            Controls.Add(lb_new_pass);
            Controls.Add(lb_name);
            Controls.Add(textBox_new_pass);
            Controls.Add(textBox_user);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form_EditUser";
            Text = "SuaUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.TextBox textBox_new_pass;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_new_pass;
        private System.Windows.Forms.Button btn_doi_mat_khau;
        private System.Windows.Forms.Button btn_xoa_user;
        private System.Windows.Forms.Button btn_tao_user;
        private System.Windows.Forms.CheckBox checkBox_cascade;
    }
}