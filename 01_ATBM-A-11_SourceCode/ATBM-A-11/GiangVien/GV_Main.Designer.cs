namespace ATBM_A_11.Lecturer_Forms
{
    partial class GV_Main
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
            classButton = new Button();
            assignmentButton = new Button();
            signOutButton = new Button();
            lecturerID = new Label();
            label1 = new Label();
            courseButton = new Button();
            studentListButton = new Button();
            accountButton = new Button();
            announceButton = new Button();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Location = new Point(0, 88);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1415, 674);
            mainPanel.TabIndex = 10;
            // 
            // classButton
            // 
            classButton.BackColor = Color.White;
            classButton.FlatAppearance.BorderSize = 0;
            classButton.FlatStyle = FlatStyle.Flat;
            classButton.Font = new Font("Segoe UI", 17.25F);
            classButton.ForeColor = Color.Black;
            classButton.Location = new Point(779, 1);
            classButton.Margin = new Padding(3, 2, 3, 2);
            classButton.Name = "classButton";
            classButton.Size = new Size(216, 94);
            classButton.TabIndex = 12;
            classButton.Text = "Nhap Diem";
            classButton.UseVisualStyleBackColor = false;
            classButton.Click += classButton_Click;
            // 
            // assignmentButton
            // 
            assignmentButton.BackColor = Color.White;
            assignmentButton.FlatAppearance.BorderSize = 0;
            assignmentButton.FlatStyle = FlatStyle.Flat;
            assignmentButton.Font = new Font("Segoe UI", 17.25F);
            assignmentButton.ForeColor = Color.Black;
            assignmentButton.Location = new Point(1199, 1);
            assignmentButton.Margin = new Padding(3, 2, 3, 2);
            assignmentButton.Name = "assignmentButton";
            assignmentButton.Size = new Size(216, 94);
            assignmentButton.TabIndex = 11;
            assignmentButton.Text = "Phan Cong";
            assignmentButton.UseVisualStyleBackColor = false;
            assignmentButton.Click += assignmentButton_Click;
            // 
            // signOutButton
            // 
            signOutButton.BackColor = Color.IndianRed;
            signOutButton.FlatAppearance.BorderSize = 0;
            signOutButton.FlatStyle = FlatStyle.Flat;
            signOutButton.Font = new Font("Segoe UI", 17.25F);
            signOutButton.ForeColor = Color.White;
            signOutButton.Location = new Point(21, 774);
            signOutButton.Margin = new Padding(3, 2, 3, 2);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(122, 34);
            signOutButton.TabIndex = 8;
            signOutButton.Text = "Logout";
            signOutButton.UseVisualStyleBackColor = false;
            signOutButton.Click += signOutButton_Click;
            // 
            // lecturerID
            // 
            lecturerID.AutoSize = true;
            lecturerID.Font = new Font("Segoe UI", 15.75F);
            lecturerID.ForeColor = Color.Black;
            lecturerID.Location = new Point(69, 34);
            lecturerID.Name = "lecturerID";
            lecturerID.Size = new Size(83, 30);
            lecturerID.TabIndex = 7;
            lecturerID.Text = "AB1234";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(30, 34);
            label1.Name = "label1";
            label1.Size = new Size(33, 30);
            label1.TabIndex = 6;
            label1.Text = "Hi";
            // 
            // courseButton
            // 
            courseButton.BackColor = Color.White;
            courseButton.FlatAppearance.BorderSize = 0;
            courseButton.FlatStyle = FlatStyle.Flat;
            courseButton.Font = new Font("Segoe UI", 17.25F);
            courseButton.ForeColor = Color.Black;
            courseButton.Location = new Point(991, 1);
            courseButton.Margin = new Padding(3, 2, 3, 2);
            courseButton.Name = "courseButton";
            courseButton.Size = new Size(216, 94);
            courseButton.TabIndex = 4;
            courseButton.Text = "Khoa Hoc";
            courseButton.UseVisualStyleBackColor = false;
            courseButton.Click += courseButton_Click;
            // 
            // studentListButton
            // 
            studentListButton.BackColor = Color.White;
            studentListButton.FlatAppearance.BorderSize = 0;
            studentListButton.FlatStyle = FlatStyle.Flat;
            studentListButton.Font = new Font("Segoe UI", 17.25F);
            studentListButton.ForeColor = Color.Black;
            studentListButton.Location = new Point(568, 1);
            studentListButton.Margin = new Padding(3, 2, 3, 2);
            studentListButton.Name = "studentListButton";
            studentListButton.Size = new Size(216, 94);
            studentListButton.TabIndex = 2;
            studentListButton.Text = "Danh Sach SV";
            studentListButton.UseVisualStyleBackColor = false;
            studentListButton.Click += studentListButton_Click;
            // 
            // accountButton
            // 
            accountButton.BackColor = Color.White;
            accountButton.FlatAppearance.BorderSize = 0;
            accountButton.FlatStyle = FlatStyle.Flat;
            accountButton.Font = new Font("Segoe UI", 17.25F);
            accountButton.ForeColor = Color.Black;
            accountButton.Location = new Point(176, 1);
            accountButton.Margin = new Padding(3, 2, 3, 2);
            accountButton.Name = "accountButton";
            accountButton.Size = new Size(216, 94);
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
            announceButton.Location = new Point(386, 1);
            announceButton.Margin = new Padding(3, 2, 3, 2);
            announceButton.Name = "announceButton";
            announceButton.Size = new Size(216, 94);
            announceButton.TabIndex = 0;
            announceButton.Text = "Thong Bao";
            announceButton.UseVisualStyleBackColor = false;
            announceButton.Click += announceButton_Click;
            // 
            // Lecturer_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 819);
            Controls.Add(mainPanel);
            Controls.Add(lecturerID);
            Controls.Add(label1);
            Controls.Add(classButton);
            Controls.Add(announceButton);
            Controls.Add(signOutButton);
            Controls.Add(studentListButton);
            Controls.Add(accountButton);
            Controls.Add(assignmentButton);
            Controls.Add(courseButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Lecturer_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lecturer Dashboard";
            Load += Lecturer_Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mainPanel;
        private Button signOutButton;
        private Label lecturerID;
        private Label label1;
        private Button courseButton;
        private Button studentListButton;
        private Button accountButton;
        private Button announceButton;
        private Button assignmentButton;
        private Button classButton;
    }
}