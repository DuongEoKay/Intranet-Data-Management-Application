namespace ATBM_A_11.Lecturer_Forms
{
    partial class GV_DangKy
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
            label11 = new Label();
            classData = new DataGridView();
            programID = new TextBox();
            label10 = new Label();
            year = new TextBox();
            refreshButton = new Button();
            label9 = new Label();
            studentName = new TextBox();
            semester = new TextBox();
            studentID = new TextBox();
            label8 = new Label();
            label2 = new Label();
            courseID = new TextBox();
            label3 = new Label();
            eScore = new TextBox();
            updateButton = new Button();
            aScore = new TextBox();
            label7 = new Label();
            fScore = new TextBox();
            label6 = new Label();
            pScore = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)classData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(classData);
            panel1.Controls.Add(programID);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(year);
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(studentName);
            panel1.Controls.Add(semester);
            panel1.Controls.Add(studentID);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(courseID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(eScore);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(aScore);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(fScore);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pScore);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1433, 669);
            panel1.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(816, 24);
            label11.Name = "label11";
            label11.Size = new Size(56, 21);
            label11.TabIndex = 24;
            label11.Text = "Ma KH";
            // 
            // classData
            // 
            classData.AllowUserToAddRows = false;
            classData.AllowUserToDeleteRows = false;
            classData.AllowUserToResizeColumns = false;
            classData.AllowUserToResizeRows = false;
            classData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            classData.BorderStyle = BorderStyle.None;
            classData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            classData.Dock = DockStyle.Bottom;
            classData.Location = new Point(0, 138);
            classData.Margin = new Padding(3, 2, 3, 2);
            classData.Name = "classData";
            classData.ReadOnly = true;
            classData.RowHeadersVisible = false;
            classData.RowHeadersWidth = 51;
            classData.Size = new Size(1433, 531);
            classData.TabIndex = 0;
            classData.CellClick += classData_CellClick;
            // 
            // programID
            // 
            programID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programID.Location = new Point(816, 47);
            programID.Margin = new Padding(3, 2, 3, 2);
            programID.Name = "programID";
            programID.ReadOnly = true;
            programID.Size = new Size(88, 23);
            programID.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(649, 24);
            label10.Name = "label10";
            label10.Size = new Size(44, 21);
            label10.TabIndex = 22;
            label10.Text = "Nam";
            // 
            // year
            // 
            year.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            year.Location = new Point(649, 47);
            year.Margin = new Padding(3, 2, 3, 2);
            year.Name = "year";
            year.ReadOnly = true;
            year.Size = new Size(88, 23);
            year.TabIndex = 21;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.IndianRed;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Segoe UI", 14.25F);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(1048, 89);
            refreshButton.Margin = new Padding(3, 2, 3, 2);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(175, 30);
            refreshButton.TabIndex = 16;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(475, 24);
            label9.Name = "label9";
            label9.Size = new Size(30, 21);
            label9.TabIndex = 20;
            label9.Text = "HK";
            // 
            // studentName
            // 
            studentName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentName.Location = new Point(57, 98);
            studentName.Margin = new Padding(3, 2, 3, 2);
            studentName.Name = "studentName";
            studentName.ReadOnly = true;
            studentName.Size = new Size(202, 23);
            studentName.TabIndex = 3;
            // 
            // semester
            // 
            semester.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            semester.Location = new Point(475, 47);
            semester.Margin = new Padding(3, 2, 3, 2);
            semester.Name = "semester";
            semester.ReadOnly = true;
            semester.Size = new Size(88, 23);
            semester.TabIndex = 19;
            // 
            // studentID
            // 
            studentID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentID.Location = new Point(57, 45);
            studentID.Margin = new Padding(3, 2, 3, 2);
            studentID.Name = "studentID";
            studentID.ReadOnly = true;
            studentID.Size = new Size(88, 23);
            studentID.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(310, 24);
            label8.Name = "label8";
            label8.Size = new Size(56, 21);
            label8.TabIndex = 18;
            label8.Text = "Ma KH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(57, 22);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 5;
            label2.Text = "Ma SV";
            // 
            // courseID
            // 
            courseID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseID.Location = new Point(310, 47);
            courseID.Margin = new Padding(3, 2, 3, 2);
            courseID.Name = "courseID";
            courseID.ReadOnly = true;
            courseID.Size = new Size(88, 23);
            courseID.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(57, 75);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 6;
            label3.Text = "Ten SV";
            // 
            // eScore
            // 
            eScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eScore.Location = new Point(310, 100);
            eScore.Margin = new Padding(3, 2, 3, 2);
            eScore.Name = "eScore";
            eScore.Size = new Size(66, 23);
            eScore.TabIndex = 7;
            eScore.KeyPress += eScore_KeyPress;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.IndianRed;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Segoe UI", 14.25F);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(1048, 37);
            updateButton.Margin = new Padding(3, 2, 3, 2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(175, 30);
            updateButton.TabIndex = 15;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // aScore
            // 
            aScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aScore.Location = new Point(816, 100);
            aScore.Margin = new Padding(3, 2, 3, 2);
            aScore.Name = "aScore";
            aScore.Size = new Size(66, 23);
            aScore.TabIndex = 8;
            aScore.KeyPress += aScore_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(816, 77);
            label7.Name = "label7";
            label7.Size = new Size(68, 21);
            label7.TabIndex = 14;
            label7.Text = "Diem TK";
            // 
            // fScore
            // 
            fScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fScore.Location = new Point(649, 100);
            fScore.Margin = new Padding(3, 2, 3, 2);
            fScore.Name = "fScore";
            fScore.Size = new Size(66, 23);
            fScore.TabIndex = 9;
            fScore.KeyPress += fScore_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(649, 77);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 13;
            label6.Text = "Diem CK";
            // 
            // pScore
            // 
            pScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pScore.Location = new Point(475, 100);
            pScore.Margin = new Padding(3, 2, 3, 2);
            pScore.Name = "pScore";
            pScore.Size = new Size(66, 23);
            pScore.TabIndex = 10;
            pScore.KeyPress += pScore_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(475, 77);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 12;
            label5.Text = "Diem QT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(308, 77);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 11;
            label4.Text = "Diem TH";
            // 
            // Class
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 669);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Class";
            Text = "Class";
            Load += Class_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)classData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView classData;
        private TextBox studentID;
        private TextBox studentName;
        private Label label2;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox pScore;
        private TextBox fScore;
        private TextBox aScore;
        private TextBox eScore;
        private Button updateButton;
        private Button refreshButton;
        private TextBox courseID;
        private Label label8;
        private Label label11;
        private TextBox programID;
        private Label label10;
        private TextBox year;
        private Label label9;
        private TextBox semester;
    }
}