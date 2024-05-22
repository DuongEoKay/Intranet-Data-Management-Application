namespace ATBM_A_11.DeptHead_Forms
{
    partial class TKH_NhanSu
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
            label10 = new Label();
            RefreshButton = new Button();
            BranchCbo = new ComboBox();
            label9 = new Label();
            DeleteButton = new Button();
            UnitCbo = new ComboBox();
            InsertButton = new Button();
            label8 = new Label();
            UpdateButton = new Button();
            PhoneBox = new TextBox();
            label7 = new Label();
            AllowanceUpDown = new NumericUpDown();
            EmpData = new DataGridView();
            label3 = new Label();
            RoleCbo = new ComboBox();
            BirthDateTime = new DateTimePicker();
            GenderCbo = new ComboBox();
            label2 = new Label();
            label6 = new Label();
            EmpIDBox = new TextBox();
            label5 = new Label();
            EmpNameBox = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllowanceUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmpData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(RefreshButton);
            panel1.Controls.Add(BranchCbo);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(DeleteButton);
            panel1.Controls.Add(UnitCbo);
            panel1.Controls.Add(InsertButton);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(UpdateButton);
            panel1.Controls.Add(PhoneBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(AllowanceUpDown);
            panel1.Controls.Add(EmpData);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(RoleCbo);
            panel1.Controls.Add(BirthDateTime);
            panel1.Controls.Add(GenderCbo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(EmpIDBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(EmpNameBox);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(80, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 831);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.WhiteSmoke;
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(569, 91);
            label10.Name = "label10";
            label10.Size = new Size(49, 21);
            label10.TabIndex = 33;
            label10.Text = "Co so";
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.IndianRed;
            RefreshButton.FlatAppearance.BorderSize = 0;
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.Font = new Font("Segoe UI", 14.25F);
            RefreshButton.ForeColor = Color.White;
            RefreshButton.Location = new Point(996, 92);
            RefreshButton.Margin = new Padding(3, 2, 3, 2);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(88, 30);
            RefreshButton.TabIndex = 19;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // BranchCbo
            // 
            BranchCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BranchCbo.FormattingEnabled = true;
            BranchCbo.Location = new Point(569, 115);
            BranchCbo.Margin = new Padding(3, 2, 3, 2);
            BranchCbo.Name = "BranchCbo";
            BranchCbo.Size = new Size(115, 24);
            BranchCbo.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.WhiteSmoke;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(394, 92);
            label9.Name = "label9";
            label9.Size = new Size(55, 21);
            label9.TabIndex = 31;
            label9.Text = "Don vi";
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.IndianRed;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI", 14.25F);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(996, 40);
            DeleteButton.Margin = new Padding(3, 2, 3, 2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(88, 30);
            DeleteButton.TabIndex = 18;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UnitCbo
            // 
            UnitCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnitCbo.FormattingEnabled = true;
            UnitCbo.Location = new Point(394, 115);
            UnitCbo.Margin = new Padding(3, 2, 3, 2);
            UnitCbo.Name = "UnitCbo";
            UnitCbo.Size = new Size(154, 24);
            UnitCbo.TabIndex = 30;
            // 
            // InsertButton
            // 
            InsertButton.BackColor = Color.IndianRed;
            InsertButton.FlatAppearance.BorderSize = 0;
            InsertButton.FlatStyle = FlatStyle.Flat;
            InsertButton.Font = new Font("Segoe UI", 14.25F);
            InsertButton.ForeColor = Color.White;
            InsertButton.Location = new Point(866, 40);
            InsertButton.Margin = new Padding(3, 2, 3, 2);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(88, 30);
            InsertButton.TabIndex = 17;
            InsertButton.Text = "Insert";
            InsertButton.UseVisualStyleBackColor = false;
            InsertButton.Click += InsertButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.WhiteSmoke;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(393, 22);
            label8.Name = "label8";
            label8.Size = new Size(28, 21);
            label8.TabIndex = 29;
            label8.Text = "DT";
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.IndianRed;
            UpdateButton.FlatAppearance.BorderSize = 0;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 14.25F);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(866, 92);
            UpdateButton.Margin = new Padding(3, 2, 3, 2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(88, 30);
            UpdateButton.TabIndex = 16;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(393, 42);
            PhoneBox.Margin = new Padding(3, 2, 3, 2);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(96, 23);
            PhoneBox.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.WhiteSmoke;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(253, 90);
            label7.Name = "label7";
            label7.Size = new Size(65, 21);
            label7.TabIndex = 27;
            label7.Text = "Phu cap";
            // 
            // AllowanceUpDown
            // 
            AllowanceUpDown.Location = new Point(253, 113);
            AllowanceUpDown.Margin = new Padding(3, 2, 3, 2);
            AllowanceUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            AllowanceUpDown.Name = "AllowanceUpDown";
            AllowanceUpDown.Size = new Size(80, 23);
            AllowanceUpDown.TabIndex = 26;
            // 
            // EmpData
            // 
            EmpData.AllowUserToAddRows = false;
            EmpData.AllowUserToDeleteRows = false;
            EmpData.AllowUserToResizeColumns = false;
            EmpData.AllowUserToResizeRows = false;
            EmpData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            EmpData.BorderStyle = BorderStyle.None;
            EmpData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmpData.Location = new Point(0, 158);
            EmpData.Margin = new Padding(3, 2, 3, 2);
            EmpData.Name = "EmpData";
            EmpData.ReadOnly = true;
            EmpData.RowHeadersVisible = false;
            EmpData.RowHeadersWidth = 51;
            EmpData.Size = new Size(1206, 502);
            EmpData.TabIndex = 0;
            EmpData.CellClick += EmpData_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(126, 90);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 25;
            label3.Text = "Ngay sinh";
            // 
            // RoleCbo
            // 
            RoleCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoleCbo.FormattingEnabled = true;
            RoleCbo.Location = new Point(507, 42);
            RoleCbo.Margin = new Padding(3, 2, 3, 2);
            RoleCbo.Name = "RoleCbo";
            RoleCbo.Size = new Size(219, 24);
            RoleCbo.TabIndex = 12;
            // 
            // BirthDateTime
            // 
            BirthDateTime.CustomFormat = "dd/MM/yyyy";
            BirthDateTime.Format = DateTimePickerFormat.Custom;
            BirthDateTime.Location = new Point(126, 113);
            BirthDateTime.Margin = new Padding(3, 2, 3, 2);
            BirthDateTime.Name = "BirthDateTime";
            BirthDateTime.Size = new Size(109, 23);
            BirthDateTime.TabIndex = 24;
            // 
            // GenderCbo
            // 
            GenderCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenderCbo.FormattingEnabled = true;
            GenderCbo.Items.AddRange(new object[] { "NAM", "NU" });
            GenderCbo.Location = new Point(43, 113);
            GenderCbo.Margin = new Padding(3, 2, 3, 2);
            GenderCbo.Name = "GenderCbo";
            GenderCbo.Size = new Size(64, 24);
            GenderCbo.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(39, 24);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 23;
            label2.Text = "Ma NV";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.WhiteSmoke;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(153, 25);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 16;
            label6.Text = "Ten NV";
            // 
            // EmpIDBox
            // 
            EmpIDBox.Location = new Point(39, 43);
            EmpIDBox.Margin = new Padding(3, 2, 3, 2);
            EmpIDBox.Name = "EmpIDBox";
            EmpIDBox.ReadOnly = true;
            EmpIDBox.Size = new Size(96, 23);
            EmpIDBox.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(507, 23);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 17;
            label5.Text = "Vai tro";
            // 
            // EmpNameBox
            // 
            EmpNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpNameBox.Location = new Point(153, 43);
            EmpNameBox.Margin = new Padding(3, 2, 3, 2);
            EmpNameBox.Name = "EmpNameBox";
            EmpNameBox.Size = new Size(219, 23);
            EmpNameBox.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(43, 91);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 20;
            label4.Text = "Gioi tinh";
            // 
            // DeptEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 848);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "DeptEmployee";
            Text = "DeptEmployee";
            Load += DeptEmployee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AllowanceUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmpData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button RefreshButton;
        private Button DeleteButton;
        private Button InsertButton;
        private Button UpdateButton;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox GenderCbo;
        private ComboBox RoleCbo;
        private DataGridView EmpData;
        private TextBox EmpNameBox;
        private TextBox EmpIDBox;
        private Label label2;
        private DateTimePicker BirthDateTime;
        private Label label3;
        private NumericUpDown AllowanceUpDown;
        private Label label7;
        private TextBox PhoneBox;
        private Label label8;
        private ComboBox BranchCbo;
        private Label label9;
        private ComboBox UnitCbo;
        private Label label10;
    }
}