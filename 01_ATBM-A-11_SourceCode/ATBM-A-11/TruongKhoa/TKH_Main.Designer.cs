namespace ATBM_A_11.DeptHead_Forms
{
    partial class TKH_Main
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
            employeeButton = new Button();
            assignmentButton = new Button();
            signOutButton = new Button();
            deptHeadID = new Label();
            label1 = new Label();
            courseButton = new Button();
            studentButton = new Button();
            accountButton = new Button();
            announceButton = new Button();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Location = new Point(4, 83);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1370, 738);
            mainPanel.TabIndex = 18;
            // 
            // employeeButton
            // 
            employeeButton.BackColor = Color.White;
            employeeButton.FlatAppearance.BorderSize = 0;
            employeeButton.FlatStyle = FlatStyle.Flat;
            employeeButton.Font = new Font("Segoe UI", 17.25F);
            employeeButton.ForeColor = Color.Black;
            employeeButton.Location = new Point(788, -6);
            employeeButton.Margin = new Padding(3, 2, 3, 2);
            employeeButton.Name = "employeeButton";
            employeeButton.Size = new Size(200, 94);
            employeeButton.TabIndex = 13;
            employeeButton.Text = "Nhan Su";
            employeeButton.UseVisualStyleBackColor = false;
            employeeButton.Click += employeeButton_Click;
            // 
            // assignmentButton
            // 
            assignmentButton.BackColor = Color.White;
            assignmentButton.FlatAppearance.BorderSize = 0;
            assignmentButton.FlatStyle = FlatStyle.Flat;
            assignmentButton.Font = new Font("Segoe UI", 17.25F);
            assignmentButton.ForeColor = Color.Black;
            assignmentButton.Location = new Point(1174, -6);
            assignmentButton.Margin = new Padding(3, 2, 3, 2);
            assignmentButton.Name = "assignmentButton";
            assignmentButton.Size = new Size(200, 94);
            assignmentButton.TabIndex = 12;
            assignmentButton.Text = "Phan Cong";
            assignmentButton.UseVisualStyleBackColor = false;
            assignmentButton.Click += assignmentButton_Click;
            // 
            // signOutButton
            // 
            signOutButton.BackColor = Color.IndianRed;
            signOutButton.FlatAppearance.BorderSize = 0;
            signOutButton.FlatStyle = FlatStyle.Flat;
            signOutButton.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signOutButton.ForeColor = Color.Black;
            signOutButton.Location = new Point(12, 836);
            signOutButton.Margin = new Padding(3, 2, 3, 2);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(94, 43);
            signOutButton.TabIndex = 8;
            signOutButton.Text = "Logout";
            signOutButton.UseVisualStyleBackColor = false;
            signOutButton.Click += signOutButton_Click;
            // 
            // deptHeadID
            // 
            deptHeadID.AutoSize = true;
            deptHeadID.Font = new Font("Tw Cen MT", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deptHeadID.ForeColor = Color.Black;
            deptHeadID.Location = new Point(67, 25);
            deptHeadID.Name = "deptHeadID";
            deptHeadID.Size = new Size(90, 27);
            deptHeadID.TabIndex = 7;
            deptHeadID.Text = "AB1234";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(36, 31);
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
            courseButton.Location = new Point(980, -6);
            courseButton.Margin = new Padding(3, 2, 3, 2);
            courseButton.Name = "courseButton";
            courseButton.Size = new Size(200, 94);
            courseButton.TabIndex = 4;
            courseButton.Text = "Khoa Hoc";
            courseButton.UseVisualStyleBackColor = false;
            courseButton.Click += courseButton_Click;
            // 
            // studentButton
            // 
            studentButton.BackColor = Color.White;
            studentButton.FlatAppearance.BorderSize = 0;
            studentButton.FlatStyle = FlatStyle.Flat;
            studentButton.Font = new Font("Segoe UI", 17.25F);
            studentButton.ForeColor = Color.Black;
            studentButton.Location = new Point(595, -6);
            studentButton.Margin = new Padding(3, 2, 3, 2);
            studentButton.Name = "studentButton";
            studentButton.Size = new Size(200, 94);
            studentButton.TabIndex = 2;
            studentButton.Text = "Danh Sach SV";
            studentButton.UseVisualStyleBackColor = false;
            studentButton.Click += studentButton_Click;
            // 
            // accountButton
            // 
            accountButton.BackColor = Color.White;
            accountButton.FlatAppearance.BorderSize = 0;
            accountButton.FlatStyle = FlatStyle.Flat;
            accountButton.Font = new Font("Segoe UI", 17.25F);
            accountButton.ForeColor = Color.Black;
            accountButton.Location = new Point(203, -6);
            accountButton.Margin = new Padding(3, 2, 3, 2);
            accountButton.Name = "accountButton";
            accountButton.Size = new Size(200, 94);
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
            announceButton.Location = new Point(399, -6);
            announceButton.Margin = new Padding(3, 2, 3, 2);
            announceButton.Name = "announceButton";
            announceButton.Size = new Size(200, 94);
            announceButton.TabIndex = 0;
            announceButton.Text = "Thong Bao";
            announceButton.UseVisualStyleBackColor = false;
            announceButton.Click += announceButton_Click;
            // 
            // DeptHead_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 890);
            Controls.Add(deptHeadID);
            Controls.Add(mainPanel);
            Controls.Add(label1);
            Controls.Add(assignmentButton);
            Controls.Add(announceButton);
            Controls.Add(signOutButton);
            Controls.Add(accountButton);
            Controls.Add(studentButton);
            Controls.Add(courseButton);
            Controls.Add(employeeButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DeptHead_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Department Head Dashboard";
            Load += DeptHead_Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mainPanel;
        private Button assignmentButton;
        private Button signOutButton;
        private Label deptHeadID;
        private Label label1;
        private Button courseButton;
        private Button studentButton;
        private Button accountButton;
        private Button announceButton;
        private Button employeeButton;
    }
}