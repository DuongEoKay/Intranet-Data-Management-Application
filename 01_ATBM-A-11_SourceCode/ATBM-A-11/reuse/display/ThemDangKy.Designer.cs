namespace ATBM_A_11.General_Forms.Popup_Forms
{
    partial class ThemDangKy
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
            label5 = new Label();
            OpenCrsData = new DataGridView();
            LectIDCbo = new ComboBox();
            label11 = new Label();
            StudentData = new DataGridView();
            ProgIDBox = new TextBox();
            label10 = new Label();
            StuNameBox = new TextBox();
            YearBox = new TextBox();
            StuIDBox = new TextBox();
            label9 = new Label();
            label2 = new Label();
            SemBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            AddButton = new Button();
            CrsNameBox = new TextBox();
            CrsIDBox = new TextBox();
            CrsIDLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OpenCrsData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(OpenCrsData);
            panel1.Controls.Add(LectIDCbo);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(StudentData);
            panel1.Controls.Add(ProgIDBox);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(StuNameBox);
            panel1.Controls.Add(YearBox);
            panel1.Controls.Add(StuIDBox);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(SemBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(CrsNameBox);
            panel1.Controls.Add(CrsIDBox);
            panel1.Controls.Add(CrsIDLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1068, 698);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(457, 81);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 38;
            label5.Text = "Ten GV";
            // 
            // OpenCrsData
            // 
            OpenCrsData.AllowUserToAddRows = false;
            OpenCrsData.AllowUserToDeleteRows = false;
            OpenCrsData.AllowUserToResizeColumns = false;
            OpenCrsData.AllowUserToResizeRows = false;
            OpenCrsData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            OpenCrsData.BorderStyle = BorderStyle.None;
            OpenCrsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OpenCrsData.Location = new Point(16, 148);
            OpenCrsData.Margin = new Padding(3, 2, 3, 2);
            OpenCrsData.Name = "OpenCrsData";
            OpenCrsData.ReadOnly = true;
            OpenCrsData.RowHeadersVisible = false;
            OpenCrsData.RowHeadersWidth = 51;
            OpenCrsData.Size = new Size(389, 338);
            OpenCrsData.TabIndex = 2;
            OpenCrsData.CellClick += OpenCrsData_CellClick;
            // 
            // LectIDCbo
            // 
            LectIDCbo.FormattingEnabled = true;
            LectIDCbo.Location = new Point(457, 104);
            LectIDCbo.Margin = new Padding(3, 2, 3, 2);
            LectIDCbo.Name = "LectIDCbo";
            LectIDCbo.Size = new Size(197, 23);
            LectIDCbo.TabIndex = 37;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(566, 24);
            label11.Name = "label11";
            label11.Size = new Size(54, 21);
            label11.TabIndex = 36;
            label11.Text = "Ma CT";
            // 
            // StudentData
            // 
            StudentData.AllowUserToAddRows = false;
            StudentData.AllowUserToDeleteRows = false;
            StudentData.AllowUserToResizeColumns = false;
            StudentData.AllowUserToResizeRows = false;
            StudentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            StudentData.BorderStyle = BorderStyle.None;
            StudentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentData.Location = new Point(440, 148);
            StudentData.Margin = new Padding(3, 2, 3, 2);
            StudentData.Name = "StudentData";
            StudentData.ReadOnly = true;
            StudentData.RowHeadersVisible = false;
            StudentData.RowHeadersWidth = 51;
            StudentData.Size = new Size(616, 532);
            StudentData.TabIndex = 0;
            StudentData.CellClick += StudentData_CellClick;
            // 
            // ProgIDBox
            // 
            ProgIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProgIDBox.Location = new Point(566, 47);
            ProgIDBox.Margin = new Padding(3, 2, 3, 2);
            ProgIDBox.Name = "ProgIDBox";
            ProgIDBox.ReadOnly = true;
            ProgIDBox.Size = new Size(88, 23);
            ProgIDBox.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(457, 24);
            label10.Name = "label10";
            label10.Size = new Size(44, 21);
            label10.TabIndex = 34;
            label10.Text = "Nam";
            // 
            // StuNameBox
            // 
            StuNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StuNameBox.Location = new Point(109, 47);
            StuNameBox.Margin = new Padding(3, 2, 3, 2);
            StuNameBox.Name = "StuNameBox";
            StuNameBox.ReadOnly = true;
            StuNameBox.Size = new Size(202, 23);
            StuNameBox.TabIndex = 3;
            // 
            // YearBox
            // 
            YearBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YearBox.Location = new Point(457, 47);
            YearBox.Margin = new Padding(3, 2, 3, 2);
            YearBox.Name = "YearBox";
            YearBox.ReadOnly = true;
            YearBox.Size = new Size(88, 23);
            YearBox.TabIndex = 33;
            // 
            // StuIDBox
            // 
            StuIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StuIDBox.Location = new Point(16, 47);
            StuIDBox.Margin = new Padding(3, 2, 3, 2);
            StuIDBox.Name = "StuIDBox";
            StuIDBox.Size = new Size(88, 23);
            StuIDBox.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(348, 24);
            label9.Name = "label9";
            label9.Size = new Size(30, 21);
            label9.TabIndex = 32;
            label9.Text = "HK";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(16, 24);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 5;
            label2.Text = "MaSV";
            // 
            // SemBox
            // 
            SemBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SemBox.Location = new Point(348, 47);
            SemBox.Margin = new Padding(3, 2, 3, 2);
            SemBox.Name = "SemBox";
            SemBox.ReadOnly = true;
            SemBox.Size = new Size(88, 23);
            SemBox.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(109, 24);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 6;
            label3.Text = "Ho Ten SV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(109, 81);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 20;
            label4.Text = "Ten KH";
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.IndianRed;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(798, 47);
            AddButton.Margin = new Padding(3, 2, 3, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(105, 40);
            AddButton.TabIndex = 15;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // CrsNameBox
            // 
            CrsNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrsNameBox.Location = new Point(109, 104);
            CrsNameBox.Margin = new Padding(3, 2, 3, 2);
            CrsNameBox.Name = "CrsNameBox";
            CrsNameBox.ReadOnly = true;
            CrsNameBox.Size = new Size(327, 23);
            CrsNameBox.TabIndex = 19;
            // 
            // CrsIDBox
            // 
            CrsIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrsIDBox.Location = new Point(16, 104);
            CrsIDBox.Margin = new Padding(3, 2, 3, 2);
            CrsIDBox.Name = "CrsIDBox";
            CrsIDBox.ReadOnly = true;
            CrsIDBox.Size = new Size(88, 23);
            CrsIDBox.TabIndex = 17;
            // 
            // CrsIDLabel
            // 
            CrsIDLabel.AutoSize = true;
            CrsIDLabel.Font = new Font("Segoe UI", 12F);
            CrsIDLabel.ForeColor = Color.Black;
            CrsIDLabel.Location = new Point(16, 81);
            CrsIDLabel.Name = "CrsIDLabel";
            CrsIDLabel.Size = new Size(56, 21);
            CrsIDLabel.TabIndex = 18;
            CrsIDLabel.Text = "Ma KH";
            // 
            // AddCrsReg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 698);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddCrsReg";
            Text = "Add New Course Registration";
            Load += CourseReg_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OpenCrsData).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button AddButton;
        private Label label3;
        private Label label2;
        private TextBox StuNameBox;
        private DataGridView StudentData;
        private DataGridView OpenCrsData;
        private Label CrsIDLabel;
        private Label label4;
        private TextBox CrsNameBox;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label5;
        internal TextBox StuIDBox;
        internal TextBox CrsIDBox;
        internal TextBox ProgIDBox;
        internal TextBox YearBox;
        internal TextBox SemBox;
        internal ComboBox LectIDCbo;
    }
}