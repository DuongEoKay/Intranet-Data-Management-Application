namespace ATBM_A_11.Ministry_Forms
{
    partial class GVU_PhanCong
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
            panel1 = new Panel();
            progCbo = new ComboBox();
            yearUpDown = new NumericUpDown();
            label3 = new Label();
            assignmentData = new DataGridView();
            label4 = new Label();
            refreshButton = new Button();
            semUpDown = new NumericUpDown();
            lecturerID = new TextBox();
            courseID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            updateButton = new Button();
            unitIDBox = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            unitNameBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yearUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)assignmentData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)semUpDown).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(progCbo);
            panel1.Controls.Add(yearUpDown);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(assignmentData);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(semUpDown);
            panel1.Controls.Add(lecturerID);
            panel1.Controls.Add(courseID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(unitIDBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(unitNameBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 888);
            panel1.TabIndex = 0;
            // 
            // progCbo
            // 
            progCbo.Enabled = false;
            progCbo.FormattingEnabled = true;
            progCbo.Items.AddRange(new object[] { "CQ", "CLC", "CTTT", "VP" });
            progCbo.Location = new Point(299, 142);
            progCbo.Margin = new Padding(3, 2, 3, 2);
            progCbo.Name = "progCbo";
            progCbo.Size = new Size(88, 23);
            progCbo.TabIndex = 46;
            progCbo.Text = "CQ";
            // 
            // yearUpDown
            // 
            yearUpDown.Location = new Point(181, 143);
            yearUpDown.Margin = new Padding(3, 2, 3, 2);
            yearUpDown.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            yearUpDown.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            yearUpDown.Name = "yearUpDown";
            yearUpDown.ReadOnly = true;
            yearUpDown.Size = new Size(88, 23);
            yearUpDown.TabIndex = 45;
            yearUpDown.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(646, 120);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 44;
            label3.Text = "Ten don vi";
            // 
            // assignmentData
            // 
            assignmentData.AllowUserToAddRows = false;
            assignmentData.AllowUserToDeleteRows = false;
            assignmentData.AllowUserToResizeColumns = false;
            assignmentData.AllowUserToResizeRows = false;
            assignmentData.BorderStyle = BorderStyle.None;
            assignmentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            assignmentData.Location = new Point(3, 201);
            assignmentData.Margin = new Padding(3, 2, 3, 2);
            assignmentData.Name = "assignmentData";
            assignmentData.ReadOnly = true;
            assignmentData.RowHeadersVisible = false;
            assignmentData.RowHeadersWidth = 51;
            assignmentData.Size = new Size(1363, 676);
            assignmentData.TabIndex = 0;
            assignmentData.CellClick += assignmentData_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(450, 120);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 43;
            label4.Text = "Ma don vi";
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.IndianRed;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Segoe UI", 14.25F);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(977, 120);
            refreshButton.Margin = new Padding(3, 2, 3, 2);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(131, 30);
            refreshButton.TabIndex = 40;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // semUpDown
            // 
            semUpDown.Location = new Point(62, 143);
            semUpDown.Margin = new Padding(3, 2, 3, 2);
            semUpDown.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            semUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            semUpDown.Name = "semUpDown";
            semUpDown.ReadOnly = true;
            semUpDown.Size = new Size(88, 23);
            semUpDown.TabIndex = 42;
            semUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lecturerID
            // 
            lecturerID.CharacterCasing = CharacterCasing.Upper;
            lecturerID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lecturerID.Location = new Point(62, 64);
            lecturerID.Margin = new Padding(3, 2, 3, 2);
            lecturerID.Name = "lecturerID";
            lecturerID.Size = new Size(133, 23);
            lecturerID.TabIndex = 25;
            // 
            // courseID
            // 
            courseID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseID.Location = new Point(258, 64);
            courseID.Margin = new Padding(3, 2, 3, 2);
            courseID.Name = "courseID";
            courseID.ReadOnly = true;
            courseID.Size = new Size(132, 23);
            courseID.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(62, 45);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 27;
            label1.Text = "Ma GV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(258, 45);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 31;
            label2.Text = "Ma KH";
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.IndianRed;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Segoe UI", 14.25F);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(977, 59);
            updateButton.Margin = new Padding(3, 2, 3, 2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(131, 30);
            updateButton.TabIndex = 39;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // unitIDBox
            // 
            unitIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitIDBox.Location = new Point(450, 143);
            unitIDBox.Margin = new Padding(3, 2, 3, 2);
            unitIDBox.Name = "unitIDBox";
            unitIDBox.ReadOnly = true;
            unitIDBox.Size = new Size(132, 23);
            unitIDBox.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(300, 120);
            label7.Name = "label7";
            label7.Size = new Size(102, 21);
            label7.TabIndex = 37;
            label7.Text = "Chuong trinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(62, 120);
            label5.Name = "label5";
            label5.Size = new Size(30, 21);
            label5.TabIndex = 33;
            label5.Text = "HK";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(182, 120);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 36;
            label6.Text = "Nam";
            // 
            // unitNameBox
            // 
            unitNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitNameBox.Location = new Point(645, 143);
            unitNameBox.Margin = new Padding(3, 2, 3, 2);
            unitNameBox.Name = "unitNameBox";
            unitNameBox.ReadOnly = true;
            unitNameBox.Size = new Size(132, 23);
            unitNameBox.TabIndex = 35;
            // 
            // Assignment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 888);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Assignment";
            Text = "Assignment";
            Load += Assignment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yearUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)assignmentData).EndInit();
            ((System.ComponentModel.ISupportInitialize)semUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView assignmentData;
        private Panel panel2;
        private Label label8;
        private TextBox lecturerID;
        private Label label1;
        private Label label2;
        private TextBox unitIDBox;
        private Label label5;
        private Label label7;
        private Label label6;
        private TextBox unitNameBox;
        private Button refreshButton;
        private Button updateButton;
        private TextBox courseID;
        private NumericUpDown semUpDown;
        private Label label4;
        private Label label3;
        private NumericUpDown yearUpDown;
        private ComboBox progCbo;
    }
}