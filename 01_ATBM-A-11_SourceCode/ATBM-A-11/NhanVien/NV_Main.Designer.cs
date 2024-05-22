namespace ATBM_A_11.Employee_Forms
{
    partial class NV_Main
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
            signOutButton = new Button();
            empID = new Label();
            label1 = new Label();
            courseButton = new Button();
            studentListButton = new Button();
            accountButton = new Button();
            announceButton = new Button();
            mainPanel = new Panel();
            SuspendLayout();
            // 
            // signOutButton
            // 
            signOutButton.BackColor = Color.IndianRed;
            signOutButton.FlatAppearance.BorderSize = 0;
            signOutButton.FlatStyle = FlatStyle.Flat;
            signOutButton.Font = new Font("Segoe UI", 17.25F);
            signOutButton.ForeColor = Color.White;
            signOutButton.Location = new Point(27, 759);
            signOutButton.Margin = new Padding(3, 2, 3, 2);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(124, 41);
            signOutButton.TabIndex = 8;
            signOutButton.Text = "Logout";
            signOutButton.UseVisualStyleBackColor = false;
            signOutButton.Click += signOutButton_Click;
            // 
            // empID
            // 
            empID.AutoSize = true;
            empID.Font = new Font("Segoe UI", 15.75F);
            empID.ForeColor = Color.Black;
            empID.Location = new Point(68, 21);
            empID.Name = "empID";
            empID.Size = new Size(83, 30);
            empID.TabIndex = 7;
            empID.Text = "AB1234";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(29, 21);
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
            courseButton.Location = new Point(1066, -2);
            courseButton.Margin = new Padding(3, 2, 3, 2);
            courseButton.Name = "courseButton";
            courseButton.Size = new Size(280, 94);
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
            studentListButton.Location = new Point(788, -2);
            studentListButton.Margin = new Padding(3, 2, 3, 2);
            studentListButton.Name = "studentListButton";
            studentListButton.Size = new Size(280, 94);
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
            accountButton.Location = new Point(237, -2);
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
            announceButton.Location = new Point(512, -2);
            announceButton.Margin = new Padding(3, 2, 3, 2);
            announceButton.Name = "announceButton";
            announceButton.Size = new Size(280, 94);
            announceButton.TabIndex = 0;
            announceButton.Text = "Thong Bao";
            announceButton.UseVisualStyleBackColor = false;
            announceButton.Click += announceButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Location = new Point(1, 90);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1345, 652);
            mainPanel.TabIndex = 8;
            // 
            // Emp_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 820);
            Controls.Add(mainPanel);
            Controls.Add(announceButton);
            Controls.Add(studentListButton);
            Controls.Add(courseButton);
            Controls.Add(signOutButton);
            Controls.Add(empID);
            Controls.Add(accountButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Emp_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Dashboard";
            Load += Emp_Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label empID;
        private Label label1;
        private Button courseButton;
        private Button studentListButton;
        private Button accountButton;
        private Button announceButton;
        private Panel mainPanel;
        private Button signOutButton;
    }
}