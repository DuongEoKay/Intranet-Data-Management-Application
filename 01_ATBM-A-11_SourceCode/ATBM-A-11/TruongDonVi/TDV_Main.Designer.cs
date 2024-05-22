namespace ATBM_A_11.UnitHead_Forms
{
    partial class TDV_Main
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
            unitHeadID = new Label();
            label1 = new Label();
            accountButton = new Button();
            announce = new Button();
            studentButton = new Button();
            courseButton = new Button();
            assignmentButton = new Button();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Location = new Point(2, 87);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1361, 712);
            mainPanel.TabIndex = 16;
            // 
            // signOutButton
            // 
            signOutButton.BackColor = Color.IndianRed;
            signOutButton.FlatAppearance.BorderSize = 0;
            signOutButton.FlatStyle = FlatStyle.Flat;
            signOutButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signOutButton.ForeColor = Color.White;
            signOutButton.Location = new Point(12, 817);
            signOutButton.Margin = new Padding(3, 2, 3, 2);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(91, 30);
            signOutButton.TabIndex = 8;
            signOutButton.Text = "Logout";
            signOutButton.UseVisualStyleBackColor = false;
            signOutButton.Click += signOutButton_Click;
            // 
            // unitHeadID
            // 
            unitHeadID.AutoSize = true;
            unitHeadID.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitHeadID.ForeColor = Color.Black;
            unitHeadID.Location = new Point(55, 28);
            unitHeadID.Name = "unitHeadID";
            unitHeadID.Size = new Size(90, 31);
            unitHeadID.TabIndex = 7;
            unitHeadID.Text = "AB1234";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(18, 32);
            label1.Name = "label1";
            label1.Size = new Size(31, 27);
            label1.TabIndex = 6;
            label1.Text = "Hi";
            // 
            // accountButton
            // 
            accountButton.Font = new Font("Segoe UI", 17.25F);
            accountButton.Location = new Point(152, -4);
            accountButton.Margin = new Padding(4, 3, 4, 3);
            accountButton.Name = "accountButton";
            accountButton.Size = new Size(226, 94);
            accountButton.TabIndex = 17;
            accountButton.Text = "Thong Tin Ca Nhan";
            accountButton.UseVisualStyleBackColor = true;
            accountButton.Click += accountButton_Click_1;
            // 
            // announce
            // 
            announce.Font = new Font("Segoe UI", 17.25F);
            announce.Location = new Point(375, -4);
            announce.Margin = new Padding(4, 3, 4, 3);
            announce.Name = "announce";
            announce.Size = new Size(258, 94);
            announce.TabIndex = 18;
            announce.Text = "Thong Bao";
            announce.UseVisualStyleBackColor = true;
            announce.Click += announce_Click;
            // 
            // studentButton
            // 
            studentButton.Font = new Font("Segoe UI", 17.25F);
            studentButton.Location = new Point(627, -4);
            studentButton.Margin = new Padding(4, 3, 4, 3);
            studentButton.Name = "studentButton";
            studentButton.Size = new Size(251, 94);
            studentButton.TabIndex = 19;
            studentButton.Text = "Danh Sach SV";
            studentButton.UseVisualStyleBackColor = true;
            studentButton.Click += studentButton_Click_1;
            // 
            // courseButton
            // 
            courseButton.Font = new Font("Segoe UI", 17.25F);
            courseButton.Location = new Point(872, -1);
            courseButton.Margin = new Padding(4, 3, 4, 3);
            courseButton.Name = "courseButton";
            courseButton.Size = new Size(237, 91);
            courseButton.TabIndex = 20;
            courseButton.Text = "Khoa Hoc";
            courseButton.UseVisualStyleBackColor = true;
            courseButton.Click += courseButton_Click_1;
            // 
            // assignmentButton
            // 
            assignmentButton.Font = new Font("Segoe UI", 17.25F);
            assignmentButton.Location = new Point(1106, -4);
            assignmentButton.Margin = new Padding(4, 3, 4, 3);
            assignmentButton.Name = "assignmentButton";
            assignmentButton.Size = new Size(253, 94);
            assignmentButton.TabIndex = 21;
            assignmentButton.Text = "Phan Cong";
            assignmentButton.UseVisualStyleBackColor = true;
            assignmentButton.Click += assignmentButton_Click_1;
            // 
            // UnitHead_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 858);
            Controls.Add(assignmentButton);
            Controls.Add(courseButton);
            Controls.Add(studentButton);
            Controls.Add(announce);
            Controls.Add(accountButton);
            Controls.Add(signOutButton);
            Controls.Add(unitHeadID);
            Controls.Add(mainPanel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UnitHead_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Unit Head Dashboard";
            Load += UnitHead_Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mainPanel;
        private Button signOutButton;
        private Button courseButton;
        private Button assignmentButton;
        private Label label1;
        private Label unitHeadID;
        private Button accountButton;
        private Button announce;
        private Button studentButton;

    }
}