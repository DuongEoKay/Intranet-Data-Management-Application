namespace ATBM_A_11.Ministry_Forms
{
    partial class GVU_KHMO
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
            YearUpDown = new NumericUpDown();
            SemUpDown = new NumericUpDown();
            OpenCrsData = new DataGridView();
            RefreshButton = new Button();
            ProgIDCbo = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            CrsNameCbo = new ComboBox();
            AddButton = new Button();
            CrsIDCbo = new ComboBox();
            UpdateButton = new Button();
            label10 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)YearUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SemUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OpenCrsData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(YearUpDown);
            panel1.Controls.Add(SemUpDown);
            panel1.Controls.Add(OpenCrsData);
            panel1.Controls.Add(RefreshButton);
            panel1.Controls.Add(ProgIDCbo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(CrsNameCbo);
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(CrsIDCbo);
            panel1.Controls.Add(UpdateButton);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1413, 891);
            panel1.TabIndex = 2;
            // 
            // YearUpDown
            // 
            YearUpDown.Location = new Point(232, 72);
            YearUpDown.Margin = new Padding(3, 2, 3, 2);
            YearUpDown.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            YearUpDown.Minimum = new decimal(new int[] { 2020, 0, 0, 0 });
            YearUpDown.Name = "YearUpDown";
            YearUpDown.Size = new Size(88, 23);
            YearUpDown.TabIndex = 30;
            YearUpDown.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // SemUpDown
            // 
            SemUpDown.Location = new Point(386, 138);
            SemUpDown.Margin = new Padding(3, 2, 3, 2);
            SemUpDown.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            SemUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            SemUpDown.Name = "SemUpDown";
            SemUpDown.Size = new Size(88, 23);
            SemUpDown.TabIndex = 29;
            SemUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
            OpenCrsData.Location = new Point(522, 182);
            OpenCrsData.Margin = new Padding(3, 2, 3, 2);
            OpenCrsData.Name = "OpenCrsData";
            OpenCrsData.ReadOnly = true;
            OpenCrsData.RowHeadersVisible = false;
            OpenCrsData.RowHeadersWidth = 51;
            OpenCrsData.Size = new Size(417, 451);
            OpenCrsData.TabIndex = 2;
            OpenCrsData.CellClick += OpenCrsData_CellClick;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.IndianRed;
            RefreshButton.FlatAppearance.BorderSize = 0;
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.Font = new Font("Segoe UI", 14.25F);
            RefreshButton.ForeColor = Color.White;
            RefreshButton.Location = new Point(964, 61);
            RefreshButton.Margin = new Padding(3, 2, 3, 2);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(88, 30);
            RefreshButton.TabIndex = 18;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // ProgIDCbo
            // 
            ProgIDCbo.FormattingEnabled = true;
            ProgIDCbo.Location = new Point(386, 72);
            ProgIDCbo.Margin = new Padding(3, 2, 3, 2);
            ProgIDCbo.Name = "ProgIDCbo";
            ProgIDCbo.Size = new Size(88, 23);
            ProgIDCbo.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(45, 49);
            label5.Name = "label5";
            label5.Size = new Size(56, 21);
            label5.TabIndex = 5;
            label5.Text = "Ma KH";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(386, 49);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 25;
            label1.Text = "Ma chuong trinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(45, 115);
            label4.Name = "label4";
            label4.Size = new Size(100, 21);
            label4.TabIndex = 6;
            label4.Text = "Ten khoa hoc";
            // 
            // CrsNameCbo
            // 
            CrsNameCbo.Enabled = false;
            CrsNameCbo.FormattingEnabled = true;
            CrsNameCbo.Location = new Point(45, 138);
            CrsNameCbo.Margin = new Padding(3, 2, 3, 2);
            CrsNameCbo.Name = "CrsNameCbo";
            CrsNameCbo.Size = new Size(275, 23);
            CrsNameCbo.TabIndex = 24;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.IndianRed;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 14.25F);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(825, 61);
            AddButton.Margin = new Padding(3, 2, 3, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(88, 30);
            AddButton.TabIndex = 15;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // CrsIDCbo
            // 
            CrsIDCbo.FormattingEnabled = true;
            CrsIDCbo.Location = new Point(45, 72);
            CrsIDCbo.Margin = new Padding(3, 2, 3, 2);
            CrsIDCbo.Name = "CrsIDCbo";
            CrsIDCbo.Size = new Size(88, 23);
            CrsIDCbo.TabIndex = 23;
            CrsIDCbo.TextChanged += CrsIDCbo_TextChanged;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.IndianRed;
            UpdateButton.FlatAppearance.BorderSize = 0;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 14.25F);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(825, 115);
            UpdateButton.Margin = new Padding(3, 2, 3, 2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(88, 30);
            UpdateButton.TabIndex = 17;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(232, 49);
            label10.Name = "label10";
            label10.Size = new Size(44, 21);
            label10.TabIndex = 22;
            label10.Text = "Nam";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(386, 115);
            label9.Name = "label9";
            label9.Size = new Size(53, 21);
            label9.TabIndex = 21;
            label9.Text = "Hoc ki";
            // 
            // CoursePlanner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 891);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CoursePlanner";
            Text = "CoursePlanner";
            Load += CoursePlanner_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)YearUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)SemUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)OpenCrsData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView OpenCrsData;
        private Panel panel3;
        private Button RefreshButton;
        private Button UpdateButton;
        private Button AddButton;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox CrsIDCbo;
        private ComboBox CrsNameCbo;
        private ComboBox ProgNameCbo;
        private Label label2;
        private ComboBox ProgIDCbo;
        private Label label1;
        private NumericUpDown YearUpDown;
        private NumericUpDown SemUpDown;
    }
}