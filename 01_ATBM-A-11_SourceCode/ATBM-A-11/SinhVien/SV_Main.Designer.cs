namespace ATBM_A_11.Student_Forms
{
    partial class SV_Main
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
            mainPanel = new Panel();
            signOutButton = new Button();
            studentID = new Label();
            label1 = new Label();
            cRegistrationButton = new Button();
            courseButton = new Button();
            accountButton = new Button();
            announceButton = new Button();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Location = new Point(0, 87);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1366, 631);
            mainPanel.TabIndex = 12;
            // 
            // signOutButton
            // 
            signOutButton.BackColor = Color.IndianRed;
            signOutButton.FlatAppearance.BorderSize = 0;
            signOutButton.FlatStyle = FlatStyle.Flat;
            signOutButton.Font = new Font("Segoe UI", 17.25F);
            signOutButton.ForeColor = Color.White;
            signOutButton.Location = new Point(19, 730);
            signOutButton.Margin = new Padding(3, 2, 3, 2);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(117, 39);
            signOutButton.TabIndex = 8;
            signOutButton.Text = "Logout";
            signOutButton.UseVisualStyleBackColor = false;
            signOutButton.Click += signOutButton_Click;
            // 
            // studentID
            // 
            studentID.AutoSize = true;
            studentID.Font = new Font("Segoe UI", 15.75F);
            studentID.ForeColor = Color.Black;
            studentID.Location = new Point(53, 20);
            studentID.Name = "studentID";
            studentID.Size = new Size(83, 30);
            studentID.TabIndex = 7;
            studentID.Text = "AB1234";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(33, 30);
            label1.TabIndex = 6;
            label1.Text = "Hi";
            // 
            // cRegistrationButton
            // 
            cRegistrationButton.BackColor = Color.White;
            cRegistrationButton.FlatAppearance.BorderSize = 0;
            cRegistrationButton.FlatStyle = FlatStyle.Flat;
            cRegistrationButton.Font = new Font("Segoe UI", 17.25F);
            cRegistrationButton.ForeColor = Color.Black;
            cRegistrationButton.Location = new Point(1086, -4);
            cRegistrationButton.Margin = new Padding(3, 2, 3, 2);
            cRegistrationButton.Name = "cRegistrationButton";
            cRegistrationButton.Size = new Size(280, 94);
            cRegistrationButton.TabIndex = 4;
            cRegistrationButton.Text = "Dang Ky";
            cRegistrationButton.UseVisualStyleBackColor = false;
            cRegistrationButton.Click += cRegistrationButton_Click;
            // 
            // courseButton
            // 
            courseButton.BackColor = Color.White;
            courseButton.FlatAppearance.BorderSize = 0;
            courseButton.FlatStyle = FlatStyle.Flat;
            courseButton.Font = new Font("Segoe UI", 17.25F);
            courseButton.ForeColor = Color.Black;
            courseButton.Location = new Point(810, -4);
            courseButton.Margin = new Padding(3, 2, 3, 2);
            courseButton.Name = "courseButton";
            courseButton.Size = new Size(280, 94);
            courseButton.TabIndex = 2;
            courseButton.Text = "Khoa Hoc";
            courseButton.UseVisualStyleBackColor = false;
            courseButton.Click += courseButton_Click;
            // 
            // accountButton
            // 
            accountButton.BackColor = Color.White;
            accountButton.FlatAppearance.BorderSize = 0;
            accountButton.FlatStyle = FlatStyle.Flat;
            accountButton.Font = new Font("Segoe UI", 17.25F);
            accountButton.ForeColor = Color.Black;
            accountButton.Location = new Point(261, -4);
            accountButton.Margin = new Padding(3, 2, 3, 2);
            accountButton.Name = "accountButton";
            accountButton.Size = new Size(280, 94);
            accountButton.TabIndex = 1;
            accountButton.Text = "Thong Tin Ca Nhan";
            accountButton.UseVisualStyleBackColor = false;
            accountButton.Click += accountButton_Click;
            // 
            // announceButton
            // 
            announceButton.BackColor = Color.White;
            announceButton.FlatAppearance.BorderSize = 0;
            announceButton.FlatStyle = FlatStyle.Flat;
            announceButton.Font = new Font("Segoe UI", 17.25F);
            announceButton.ForeColor = Color.Black;
            announceButton.Location = new Point(535, -4);
            announceButton.Margin = new Padding(3, 2, 3, 2);
            announceButton.Name = "announceButton";
            announceButton.Size = new Size(280, 94);
            announceButton.TabIndex = 0;
            announceButton.Text = "Thong Bao";
            announceButton.UseVisualStyleBackColor = false;
            announceButton.Click += announceButton_Click;
            // 
            // Student_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 780);
            Controls.Add(mainPanel);
            Controls.Add(cRegistrationButton);
            Controls.Add(courseButton);
            Controls.Add(accountButton);
            Controls.Add(announceButton);
            Controls.Add(studentID);
            Controls.Add(label1);
            Controls.Add(signOutButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Student_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Dashboard";
            Load += Student_Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mainPanel;
        private Button signOutButton;
        private Label studentID;
        private Label label1;
        private Button cRegistrationButton;
        private Button courseButton;
        private Button accountButton;
        private Button announceButton;
    }
}