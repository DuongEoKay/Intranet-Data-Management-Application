namespace phan_he_1
{
    partial class MainMenu
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
            label1 = new Label();
            hello_username = new Label();
            btn_ds_user = new Button();
            btn_quan_li_user = new Button();
            btn_quan_ly_role = new Button();
            button9 = new Button();
            button8 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            signOutButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(17, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(33, 30);
            label1.TabIndex = 2;
            label1.Text = "Hi";
            // 
            // hello_username
            // 
            hello_username.AutoSize = true;
            hello_username.Font = new Font("Segoe UI", 15.75F);
            hello_username.Location = new Point(44, 27);
            hello_username.Margin = new Padding(4, 0, 4, 0);
            hello_username.Name = "hello_username";
            hello_username.Size = new Size(68, 30);
            hello_username.TabIndex = 1;
            hello_username.Text = "label1";
            // 
            // btn_ds_user
            // 
            btn_ds_user.Font = new Font("Segoe UI", 15.75F);
            btn_ds_user.Location = new Point(236, -3);
            btn_ds_user.Margin = new Padding(4, 3, 4, 3);
            btn_ds_user.Name = "btn_ds_user";
            btn_ds_user.Size = new Size(185, 94);
            btn_ds_user.TabIndex = 0;
            btn_ds_user.Text = "Danh Sach User";
            btn_ds_user.UseVisualStyleBackColor = true;
            btn_ds_user.Click += btn_ds_user_onclick;
            // 
            // btn_quan_li_user
            // 
            btn_quan_li_user.Font = new Font("Segoe UI", 15.75F);
            btn_quan_li_user.Location = new Point(414, -3);
            btn_quan_li_user.Margin = new Padding(4, 3, 4, 3);
            btn_quan_li_user.Name = "btn_quan_li_user";
            btn_quan_li_user.Size = new Size(185, 94);
            btn_quan_li_user.TabIndex = 0;
            btn_quan_li_user.Text = "Quan Li User";
            btn_quan_li_user.UseVisualStyleBackColor = true;
            btn_quan_li_user.Click += btn_sua_user_onclick;
            // 
            // btn_quan_ly_role
            // 
            btn_quan_ly_role.Font = new Font("Segoe UI", 15.75F);
            btn_quan_ly_role.Location = new Point(593, -3);
            btn_quan_ly_role.Margin = new Padding(4, 3, 4, 3);
            btn_quan_ly_role.Name = "btn_quan_ly_role";
            btn_quan_ly_role.Size = new Size(185, 94);
            btn_quan_ly_role.TabIndex = 0;
            btn_quan_ly_role.Text = "Quan Li Role";
            btn_quan_ly_role.UseVisualStyleBackColor = true;
            btn_quan_ly_role.Click += btn_quan_ly_role_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 15.75F);
            button9.Location = new Point(774, -3);
            button9.Margin = new Padding(4, 3, 4, 3);
            button9.Name = "button9";
            button9.Size = new Size(185, 94);
            button9.TabIndex = 0;
            button9.Text = "Kiem tra quyen cua User/Role";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 15.75F);
            button8.Location = new Point(954, -3);
            button8.Margin = new Padding(4, 3, 4, 3);
            button8.Name = "button8";
            button8.Size = new Size(185, 94);
            button8.TabIndex = 0;
            button8.Text = "Gan quyen cho User/Role";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 85);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1490, 850);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F);
            button1.Location = new Point(1128, -3);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(185, 94);
            button1.TabIndex = 2;
            button1.Text = "Cai Dat Audit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1305, -3);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(185, 94);
            button2.TabIndex = 3;
            button2.Text = "Nhat Ky Audit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // signOutButton
            // 
            signOutButton.BackColor = Color.IndianRed;
            signOutButton.FlatAppearance.BorderSize = 0;
            signOutButton.FlatStyle = FlatStyle.Flat;
            signOutButton.Font = new Font("Segoe UI", 17.25F);
            signOutButton.ForeColor = Color.White;
            signOutButton.Location = new Point(17, 949);
            signOutButton.Margin = new Padding(3, 2, 3, 2);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(117, 39);
            signOutButton.TabIndex = 9;
            signOutButton.Text = "Logout";
            signOutButton.UseVisualStyleBackColor = false;
            signOutButton.Click += signOutButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1487, 999);
            Controls.Add(signOutButton);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button8);
            Controls.Add(hello_username);
            Controls.Add(btn_quan_ly_role);
            Controls.Add(button9);
            Controls.Add(btn_ds_user);
            Controls.Add(btn_quan_li_user);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainMenu";
            Text = "MainMenu";
            FormClosed += MainMenu_FormClosed;
            Load += MainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btn_ds_user;
        private System.Windows.Forms.Button btn_quan_li_user;
        private System.Windows.Forms.Button btn_quan_ly_role;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label hello_username;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Button button1;
        private Button button2;
        private Button signOutButton;
    }
}