namespace ATBM_A_11.General_Forms
{
    partial class XemDangKy
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
            CrsRegData = new DataGridView();
            panel1 = new Panel();
            label12 = new Label();
            CrsNameBox = new TextBox();
            RefreshButton = new Button();
            RemoveButton = new Button();
            AddButton = new Button();
            lectID = new TextBox();
            label11 = new Label();
            courseID = new TextBox();
            progID = new TextBox();
            label2 = new Label();
            label10 = new Label();
            label3 = new Label();
            yearBox = new TextBox();
            eScore = new TextBox();
            label9 = new Label();
            aScore = new TextBox();
            semBox = new TextBox();
            fScore = new TextBox();
            label8 = new Label();
            pScore = new TextBox();
            stuID = new TextBox();
            label4 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)CrsRegData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CrsRegData
            // 
            CrsRegData.AllowUserToAddRows = false;
            CrsRegData.AllowUserToDeleteRows = false;
            CrsRegData.AllowUserToResizeColumns = false;
            CrsRegData.AllowUserToResizeRows = false;
            CrsRegData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            CrsRegData.BorderStyle = BorderStyle.None;
            CrsRegData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CrsRegData.Location = new Point(161, 146);
            CrsRegData.Margin = new Padding(3, 2, 3, 2);
            CrsRegData.Name = "CrsRegData";
            CrsRegData.RowHeadersVisible = false;
            CrsRegData.RowHeadersWidth = 51;
            CrsRegData.Size = new Size(887, 499);
            CrsRegData.TabIndex = 0;
            CrsRegData.CellClick += CrsRegData_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(CrsRegData);
            panel1.Controls.Add(CrsNameBox);
            panel1.Controls.Add(RefreshButton);
            panel1.Controls.Add(RemoveButton);
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(lectID);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(courseID);
            panel1.Controls.Add(progID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(yearBox);
            panel1.Controls.Add(eScore);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(aScore);
            panel1.Controls.Add(semBox);
            panel1.Controls.Add(fScore);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pScore);
            panel1.Controls.Add(stuID);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1196, 824);
            panel1.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(366, 89);
            label12.Name = "label12";
            label12.Size = new Size(57, 21);
            label12.TabIndex = 35;
            label12.Text = "Ten KH";
            // 
            // CrsNameBox
            // 
            CrsNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrsNameBox.Location = new Point(368, 109);
            CrsNameBox.Margin = new Padding(3, 2, 3, 2);
            CrsNameBox.Name = "CrsNameBox";
            CrsNameBox.ReadOnly = true;
            CrsNameBox.Size = new Size(324, 23);
            CrsNameBox.TabIndex = 34;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.IndianRed;
            RefreshButton.FlatAppearance.BorderSize = 0;
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.Font = new Font("Segoe UI", 14.25F);
            RefreshButton.ForeColor = Color.White;
            RefreshButton.Location = new Point(965, 29);
            RefreshButton.Margin = new Padding(3, 2, 3, 2);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(105, 30);
            RefreshButton.TabIndex = 33;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = Color.IndianRed;
            RemoveButton.FlatAppearance.BorderSize = 0;
            RemoveButton.FlatStyle = FlatStyle.Flat;
            RemoveButton.Font = new Font("Segoe UI", 14.25F);
            RemoveButton.ForeColor = Color.White;
            RemoveButton.Location = new Point(804, 91);
            RemoveButton.Margin = new Padding(3, 2, 3, 2);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(105, 30);
            RemoveButton.TabIndex = 32;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.IndianRed;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 14.25F);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(804, 29);
            AddButton.Margin = new Padding(3, 2, 3, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(105, 30);
            AddButton.TabIndex = 31;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // lectID
            // 
            lectID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lectID.Location = new Point(140, 50);
            lectID.Margin = new Padding(3, 2, 3, 2);
            lectID.Name = "lectID";
            lectID.ReadOnly = true;
            lectID.Size = new Size(88, 23);
            lectID.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(250, 89);
            label11.Name = "label11";
            label11.Size = new Size(56, 21);
            label11.TabIndex = 30;
            label11.Text = "Ma KH";
            // 
            // courseID
            // 
            courseID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseID.Location = new Point(250, 50);
            courseID.Margin = new Padding(3, 2, 3, 2);
            courseID.Name = "courseID";
            courseID.ReadOnly = true;
            courseID.Size = new Size(88, 23);
            courseID.TabIndex = 8;
            // 
            // progID
            // 
            progID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            progID.Location = new Point(250, 109);
            progID.Margin = new Padding(3, 2, 3, 2);
            progID.Name = "progID";
            progID.ReadOnly = true;
            progID.Size = new Size(88, 23);
            progID.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(250, 29);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 9;
            label2.Text = "Ma KH";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(140, 89);
            label10.Name = "label10";
            label10.Size = new Size(44, 21);
            label10.TabIndex = 28;
            label10.Text = "Nam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(140, 29);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 10;
            label3.Text = "Ma GV";
            // 
            // yearBox
            // 
            yearBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yearBox.Location = new Point(140, 109);
            yearBox.Margin = new Padding(3, 2, 3, 2);
            yearBox.Name = "yearBox";
            yearBox.ReadOnly = true;
            yearBox.Size = new Size(88, 23);
            yearBox.TabIndex = 27;
            // 
            // eScore
            // 
            eScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eScore.Location = new Point(368, 50);
            eScore.Margin = new Padding(3, 2, 3, 2);
            eScore.Name = "eScore";
            eScore.ReadOnly = true;
            eScore.Size = new Size(66, 23);
            eScore.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(28, 89);
            label9.Name = "label9";
            label9.Size = new Size(30, 21);
            label9.TabIndex = 26;
            label9.Text = "HK";
            // 
            // aScore
            // 
            aScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aScore.Location = new Point(626, 50);
            aScore.Margin = new Padding(3, 2, 3, 2);
            aScore.Name = "aScore";
            aScore.ReadOnly = true;
            aScore.Size = new Size(66, 23);
            aScore.TabIndex = 16;
            // 
            // semBox
            // 
            semBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            semBox.Location = new Point(28, 109);
            semBox.Margin = new Padding(3, 2, 3, 2);
            semBox.Name = "semBox";
            semBox.ReadOnly = true;
            semBox.Size = new Size(88, 23);
            semBox.TabIndex = 25;
            // 
            // fScore
            // 
            fScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fScore.Location = new Point(536, 50);
            fScore.Margin = new Padding(3, 2, 3, 2);
            fScore.Name = "fScore";
            fScore.ReadOnly = true;
            fScore.Size = new Size(66, 23);
            fScore.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(28, 29);
            label8.Name = "label8";
            label8.Size = new Size(55, 21);
            label8.TabIndex = 24;
            label8.Text = "Ma SV";
            // 
            // pScore
            // 
            pScore.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pScore.Location = new Point(453, 50);
            pScore.Margin = new Padding(3, 2, 3, 2);
            pScore.Name = "pScore";
            pScore.ReadOnly = true;
            pScore.Size = new Size(66, 23);
            pScore.TabIndex = 18;
            // 
            // stuID
            // 
            stuID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stuID.Location = new Point(28, 50);
            stuID.Margin = new Padding(3, 2, 3, 2);
            stuID.Name = "stuID";
            stuID.ReadOnly = true;
            stuID.Size = new Size(88, 23);
            stuID.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(366, 29);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 19;
            label4.Text = "Diem TH";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(626, 29);
            label7.Name = "label7";
            label7.Size = new Size(68, 21);
            label7.TabIndex = 22;
            label7.Text = "Diem TK";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(453, 29);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 20;
            label5.Text = "Diem QT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(536, 29);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 21;
            label6.Text = "Diem CK";
            // 
            // CrsRegView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 824);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CrsRegView";
            Text = "ClassView";
            Load += CrsRegView_Load;
            ((System.ComponentModel.ISupportInitialize)CrsRegData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CrsRegData;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private TextBox courseID;
        private TextBox lectID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox pScore;
        private TextBox fScore;
        private TextBox aScore;
        private TextBox eScore;
        private TextBox stuID;
        private Label label8;
        private Label label9;
        private TextBox semBox;
        private Label label11;
        private TextBox progID;
        private Label label10;
        private TextBox yearBox;
        private Button RefreshButton;
        private Button RemoveButton;
        private Button AddButton;
        private Label label12;
        private TextBox CrsNameBox;
    }
}