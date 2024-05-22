namespace ATBM_A_11.Ministry_Forms
{
    partial class GVU_HocPhan
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
            cbo_madonvi = new ComboBox();
            UnitNameCbo = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            RefreshButton = new Button();
            MaxStuUpDown = new NumericUpDown();
            CrsNameBox = new TextBox();
            label5 = new Label();
            CrsIDBox = new TextBox();
            PracUpDown = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            TheoUpDown = new NumericUpDown();
            AddButton = new Button();
            CredUpDown = new NumericUpDown();
            UpdateButton = new Button();
            label7 = new Label();
            label6 = new Label();
            CrsData = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MaxStuUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PracUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TheoUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CredUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CrsData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(cbo_madonvi);
            panel1.Controls.Add(UnitNameCbo);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(RefreshButton);
            panel1.Controls.Add(MaxStuUpDown);
            panel1.Controls.Add(CrsNameBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(CrsIDBox);
            panel1.Controls.Add(PracUpDown);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TheoUpDown);
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(CredUpDown);
            panel1.Controls.Add(UpdateButton);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(CrsData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1396, 908);
            panel1.TabIndex = 2;
            // 
            // cbo_madonvi
            // 
            cbo_madonvi.FormattingEnabled = true;
            cbo_madonvi.Location = new Point(472, 50);
            cbo_madonvi.Name = "cbo_madonvi";
            cbo_madonvi.Size = new Size(121, 23);
            cbo_madonvi.TabIndex = 34;
            // 
            // UnitNameCbo
            // 
            UnitNameCbo.Enabled = false;
            UnitNameCbo.FormattingEnabled = true;
            UnitNameCbo.Location = new Point(500, 113);
            UnitNameCbo.Margin = new Padding(3, 2, 3, 2);
            UnitNameCbo.Name = "UnitNameCbo";
            UnitNameCbo.Size = new Size(219, 23);
            UnitNameCbo.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(500, 90);
            label9.Name = "label9";
            label9.Size = new Size(80, 21);
            label9.TabIndex = 32;
            label9.Text = "Ten don vi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(472, 27);
            label8.Name = "label8";
            label8.Size = new Size(79, 21);
            label8.TabIndex = 29;
            label8.Text = "Ma don vi";
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.IndianRed;
            RefreshButton.FlatAppearance.BorderSize = 0;
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.Font = new Font("Segoe UI", 14.25F);
            RefreshButton.ForeColor = Color.White;
            RefreshButton.Location = new Point(952, 39);
            RefreshButton.Margin = new Padding(3, 2, 3, 2);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(88, 30);
            RefreshButton.TabIndex = 18;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // MaxStuUpDown
            // 
            MaxStuUpDown.Location = new Point(362, 112);
            MaxStuUpDown.Margin = new Padding(3, 2, 3, 2);
            MaxStuUpDown.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            MaxStuUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MaxStuUpDown.Name = "MaxStuUpDown";
            MaxStuUpDown.Size = new Size(88, 23);
            MaxStuUpDown.TabIndex = 28;
            MaxStuUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // CrsNameBox
            // 
            CrsNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrsNameBox.Location = new Point(143, 50);
            CrsNameBox.Margin = new Padding(3, 2, 3, 2);
            CrsNameBox.Name = "CrsNameBox";
            CrsNameBox.Size = new Size(307, 23);
            CrsNameBox.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(362, 89);
            label5.Name = "label5";
            label5.Size = new Size(137, 21);
            label5.TabIndex = 27;
            label5.Text = "So sinh vien toi da";
            // 
            // CrsIDBox
            // 
            CrsIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrsIDBox.Location = new Point(34, 50);
            CrsIDBox.Margin = new Padding(3, 2, 3, 2);
            CrsIDBox.Name = "CrsIDBox";
            CrsIDBox.Size = new Size(88, 23);
            CrsIDBox.TabIndex = 4;
            // 
            // PracUpDown
            // 
            PracUpDown.Location = new Point(253, 112);
            PracUpDown.Margin = new Padding(3, 2, 3, 2);
            PracUpDown.Name = "PracUpDown";
            PracUpDown.Size = new Size(88, 23);
            PracUpDown.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(34, 27);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 5;
            label2.Text = "Ma KH";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(253, 89);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 25;
            label4.Text = "Thuc hanh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(143, 27);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 6;
            label3.Text = "Ten khoa hoc";
            // 
            // TheoUpDown
            // 
            TheoUpDown.Location = new Point(143, 112);
            TheoUpDown.Margin = new Padding(3, 2, 3, 2);
            TheoUpDown.Name = "TheoUpDown";
            TheoUpDown.Size = new Size(88, 23);
            TheoUpDown.TabIndex = 24;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.IndianRed;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 14.25F);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(818, 39);
            AddButton.Margin = new Padding(3, 2, 3, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(88, 30);
            AddButton.TabIndex = 15;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // CredUpDown
            // 
            CredUpDown.Location = new Point(34, 113);
            CredUpDown.Margin = new Padding(3, 2, 3, 2);
            CredUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CredUpDown.Name = "CredUpDown";
            CredUpDown.Size = new Size(88, 23);
            CredUpDown.TabIndex = 23;
            CredUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.IndianRed;
            UpdateButton.FlatAppearance.BorderSize = 0;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 14.25F);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(818, 102);
            UpdateButton.Margin = new Padding(3, 2, 3, 2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(88, 30);
            UpdateButton.TabIndex = 17;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(143, 89);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 22;
            label7.Text = "Ly thuyet";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(34, 89);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 21;
            label6.Text = "So tin chi";
            // 
            // CrsData
            // 
            CrsData.AllowUserToAddRows = false;
            CrsData.AllowUserToDeleteRows = false;
            CrsData.AllowUserToResizeColumns = false;
            CrsData.AllowUserToResizeRows = false;
            CrsData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            CrsData.BorderStyle = BorderStyle.None;
            CrsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CrsData.Location = new Point(334, 228);
            CrsData.Margin = new Padding(3, 2, 3, 2);
            CrsData.Name = "CrsData";
            CrsData.ReadOnly = true;
            CrsData.RowHeadersVisible = false;
            CrsData.RowHeadersWidth = 51;
            CrsData.Size = new Size(647, 312);
            CrsData.TabIndex = 0;
            CrsData.CellClick += CrsData_CellClick;
            // 
            // CourseManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 908);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CourseManager";
            Text = "CourseManager";
            Load += CourseManager_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MaxStuUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PracUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)TheoUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)CredUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)CrsData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button UpdateButton;
        private Button AddButton;
        private Label label3;
        private Label label2;
        private TextBox CrsIDBox;
        private TextBox CrsNameBox;
        private Label label1;
        private DataGridView CrsData;
        private Button RefreshButton;
        private Label label6;
        private Label label7;
        private NumericUpDown CredUpDown;
        private NumericUpDown UnitIDUpDown;
        private Label label8;
        private NumericUpDown MaxStuUpDown;
        private Label label5;
        private NumericUpDown PracUpDown;
        private Label label4;
        private NumericUpDown TheoUpDown;
        private Label label9;
        private ComboBox UnitNameCbo;
        private ComboBox cbo_madonvi;
    }
}