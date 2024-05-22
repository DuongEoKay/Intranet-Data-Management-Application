namespace ATBM_A_11.DeptHead_Forms
{
    partial class TKH_PhanCong
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
            label8 = new Label();
            refreshButton = new Button();
            label7 = new Label();
            deleteButton = new Button();
            yearUpDown = new NumericUpDown();
            insertButton = new Button();
            semUpDown = new NumericUpDown();
            updateButton = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            assignmentData = new DataGridView();
            label5 = new Label();
            unitNameBox = new TextBox();
            label6 = new Label();
            lecturerCbo = new ComboBox();
            programCbo = new ComboBox();
            courseCbo = new ComboBox();
            unitIDBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yearUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)semUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)assignmentData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(yearUpDown);
            panel1.Controls.Add(insertButton);
            panel1.Controls.Add(semUpDown);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(assignmentData);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(unitNameBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lecturerCbo);
            panel1.Controls.Add(programCbo);
            panel1.Controls.Add(courseCbo);
            panel1.Controls.Add(unitIDBox);
            panel1.Location = new Point(22, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1358, 861);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(250, 109);
            label8.Name = "label8";
            label8.Size = new Size(58, 21);
            label8.TabIndex = 48;
            label8.Text = "Ten DV";
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.IndianRed;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Segoe UI", 14.25F);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(1037, 109);
            refreshButton.Margin = new Padding(3, 2, 3, 2);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(88, 30);
            refreshButton.TabIndex = 19;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(145, 109);
            label7.Name = "label7";
            label7.Size = new Size(57, 21);
            label7.TabIndex = 47;
            label7.Text = "Ma DV";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.IndianRed;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI", 14.25F);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(1037, 48);
            deleteButton.Margin = new Padding(3, 2, 3, 2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(88, 30);
            deleteButton.TabIndex = 18;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // yearUpDown
            // 
            yearUpDown.Location = new Point(600, 48);
            yearUpDown.Margin = new Padding(3, 2, 3, 2);
            yearUpDown.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            yearUpDown.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            yearUpDown.Name = "yearUpDown";
            yearUpDown.ReadOnly = true;
            yearUpDown.Size = new Size(88, 23);
            yearUpDown.TabIndex = 46;
            yearUpDown.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // insertButton
            // 
            insertButton.BackColor = Color.IndianRed;
            insertButton.FlatAppearance.BorderSize = 0;
            insertButton.FlatStyle = FlatStyle.Flat;
            insertButton.Font = new Font("Segoe UI", 14.25F);
            insertButton.ForeColor = Color.White;
            insertButton.Location = new Point(890, 48);
            insertButton.Margin = new Padding(3, 2, 3, 2);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(88, 30);
            insertButton.TabIndex = 17;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = false;
            insertButton.Click += insertButton_Click;
            // 
            // semUpDown
            // 
            semUpDown.Location = new Point(495, 48);
            semUpDown.Margin = new Padding(3, 2, 3, 2);
            semUpDown.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            semUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            semUpDown.Name = "semUpDown";
            semUpDown.ReadOnly = true;
            semUpDown.Size = new Size(88, 23);
            semUpDown.TabIndex = 43;
            semUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.IndianRed;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Segoe UI", 14.25F);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(890, 109);
            updateButton.Margin = new Padding(3, 2, 3, 2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(88, 30);
            updateButton.TabIndex = 16;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(389, 25);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 20;
            label4.Text = "Ma CT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(600, 25);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 19;
            label3.Text = "Nam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(495, 25);
            label2.Name = "label2";
            label2.Size = new Size(30, 21);
            label2.TabIndex = 18;
            label2.Text = "HK";
            // 
            // assignmentData
            // 
            assignmentData.AllowUserToAddRows = false;
            assignmentData.AllowUserToDeleteRows = false;
            assignmentData.AllowUserToResizeColumns = false;
            assignmentData.AllowUserToResizeRows = false;
            assignmentData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            assignmentData.BorderStyle = BorderStyle.None;
            assignmentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            assignmentData.Dock = DockStyle.Bottom;
            assignmentData.Location = new Point(0, 174);
            assignmentData.Margin = new Padding(3, 2, 3, 2);
            assignmentData.Name = "assignmentData";
            assignmentData.ReadOnly = true;
            assignmentData.RowHeadersVisible = false;
            assignmentData.RowHeadersWidth = 51;
            assignmentData.Size = new Size(1358, 687);
            assignmentData.TabIndex = 0;
            assignmentData.CellClick += assignmentData_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(469, 109);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 17;
            label5.Text = "Ten KH";
            // 
            // unitNameBox
            // 
            unitNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitNameBox.Location = new Point(250, 132);
            unitNameBox.Margin = new Padding(3, 2, 3, 2);
            unitNameBox.Name = "unitNameBox";
            unitNameBox.ReadOnly = true;
            unitNameBox.Size = new Size(193, 23);
            unitNameBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(146, 25);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 16;
            label6.Text = "Ten GV";
            // 
            // lecturerCbo
            // 
            lecturerCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lecturerCbo.FormattingEnabled = true;
            lecturerCbo.Location = new Point(146, 48);
            lecturerCbo.Margin = new Padding(3, 2, 3, 2);
            lecturerCbo.Name = "lecturerCbo";
            lecturerCbo.Size = new Size(219, 24);
            lecturerCbo.TabIndex = 11;
            // 
            // programCbo
            // 
            programCbo.Enabled = false;
            programCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programCbo.FormattingEnabled = true;
            programCbo.Items.AddRange(new object[] { "CQ", "VP", "CTTT", "CLC" });
            programCbo.Location = new Point(389, 48);
            programCbo.Margin = new Padding(3, 2, 3, 2);
            programCbo.Name = "programCbo";
            programCbo.Size = new Size(88, 24);
            programCbo.TabIndex = 15;
            programCbo.Text = "CQ";
            // 
            // courseCbo
            // 
            courseCbo.Enabled = false;
            courseCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseCbo.FormattingEnabled = true;
            courseCbo.Location = new Point(469, 132);
            courseCbo.Margin = new Padding(3, 2, 3, 2);
            courseCbo.Name = "courseCbo";
            courseCbo.Size = new Size(219, 24);
            courseCbo.TabIndex = 12;
            // 
            // unitIDBox
            // 
            unitIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitIDBox.Location = new Point(145, 132);
            unitIDBox.Margin = new Padding(3, 2, 3, 2);
            unitIDBox.Name = "unitIDBox";
            unitIDBox.ReadOnly = true;
            unitIDBox.Size = new Size(88, 23);
            unitIDBox.TabIndex = 14;
            // 
            // DeptAssignment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 883);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "DeptAssignment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DeptAssignemnt";
            Load += DeptAssignemnt_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yearUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)semUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)assignmentData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView assignmentData;
        private Button updateButton;
        private Button deleteButton;
        private Button insertButton;
        private Button refreshButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private ComboBox programCbo;
        private TextBox unitIDBox;
        private TextBox unitNameBox;
        private ComboBox courseCbo;
        private ComboBox lecturerCbo;
        private NumericUpDown semUpDown;
        private NumericUpDown yearUpDown;
        private Label label7;
        private Label label8;
    }
}