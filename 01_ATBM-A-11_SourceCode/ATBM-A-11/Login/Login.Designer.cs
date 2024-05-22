namespace ATBM_A_11
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            username = new TextBox();
            password = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(113, 100);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(113, 218);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 39);
            label1.TabIndex = 7;
            label1.Text = "LOGIN";
            // 
            // username
            // 
            username.AccessibleDescription = "";
            username.AccessibleName = "";
            username.BackColor = Color.FromArgb(255, 192, 192);
            username.CharacterCasing = CharacterCasing.Upper;
            username.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(113, 123);
            username.Margin = new Padding(4, 3, 4, 3);
            username.Multiline = true;
            username.Name = "username";
            username.Size = new Size(383, 42);
            username.TabIndex = 8;
            // 
            // password
            // 
            password.AccessibleDescription = "";
            password.AccessibleName = "";
            password.BackColor = Color.FromArgb(255, 192, 192);
            password.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(113, 241);
            password.Margin = new Padding(4, 3, 4, 3);
            password.Multiline = true;
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(383, 44);
            password.TabIndex = 9;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.IndianRed;
            loginButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.Location = new Point(179, 336);
            loginButton.Margin = new Padding(4, 3, 4, 3);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(217, 76);
            loginButton.TabIndex = 10;
            loginButton.Text = "Gooo";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += LoginButton_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(579, 438);
            Controls.Add(loginButton);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox username;
        private TextBox password;
        private Button loginButton;
    }
}
