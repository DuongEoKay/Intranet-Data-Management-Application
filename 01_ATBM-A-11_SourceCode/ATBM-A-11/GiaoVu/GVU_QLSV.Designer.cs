namespace ATBM_A_11.Ministry_Forms
{
    partial class GVU_QLSV
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
            gpaUpDown = new NumericUpDown();
            refreshButton = new Button();
            creditUpDown = new NumericUpDown();
            updateButton = new Button();
            label10 = new Label();
            insertButton = new Button();
            label9 = new Label();
            label = new Label();
            studentData = new DataGridView();
            programCbo = new ComboBox();
            label8 = new Label();
            addressBox = new TextBox();
            majorCbo = new ComboBox();
            studentName = new TextBox();
            label7 = new Label();
            label4 = new Label();
            phoneBox = new TextBox();
            bdayBox = new DateTimePicker();
            label6 = new Label();
            label1 = new Label();
            genderCbo = new ComboBox();
            studentID = new TextBox();
            label5 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gpaUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)creditUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(gpaUpDown);
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(creditUpDown);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(insertButton);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label);
            panel1.Controls.Add(studentData);
            panel1.Controls.Add(programCbo);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(addressBox);
            panel1.Controls.Add(majorCbo);
            panel1.Controls.Add(studentName);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(phoneBox);
            panel1.Controls.Add(bdayBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(genderCbo);
            panel1.Controls.Add(studentID);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1375, 864);
            panel1.TabIndex = 1;
            // 
            // gpaUpDown
            // 
            gpaUpDown.DecimalPlaces = 2;
            gpaUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            gpaUpDown.Location = new Point(424, 114);
            gpaUpDown.Margin = new Padding(3, 2, 3, 2);
            gpaUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            gpaUpDown.Name = "gpaUpDown";
            gpaUpDown.Size = new Size(66, 23);
            gpaUpDown.TabIndex = 31;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.IndianRed;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Segoe UI", 14.25F);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(1091, 49);
            refreshButton.Margin = new Padding(3, 2, 3, 2);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(88, 30);
            refreshButton.TabIndex = 19;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // creditUpDown
            // 
            creditUpDown.Location = new Point(328, 114);
            creditUpDown.Margin = new Padding(3, 2, 3, 2);
            creditUpDown.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            creditUpDown.Name = "creditUpDown";
            creditUpDown.Size = new Size(66, 23);
            creditUpDown.TabIndex = 30;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.IndianRed;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Segoe UI", 14.25F);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(965, 103);
            updateButton.Margin = new Padding(3, 2, 3, 2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(88, 30);
            updateButton.TabIndex = 17;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(424, 92);
            label10.Name = "label10";
            label10.Size = new Size(52, 21);
            label10.TabIndex = 29;
            label10.Text = "DTBTL";
            // 
            // insertButton
            // 
            insertButton.BackColor = Color.IndianRed;
            insertButton.FlatAppearance.BorderSize = 0;
            insertButton.FlatStyle = FlatStyle.Flat;
            insertButton.Font = new Font("Segoe UI", 14.25F);
            insertButton.ForeColor = Color.White;
            insertButton.Location = new Point(967, 49);
            insertButton.Margin = new Padding(3, 2, 3, 2);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(88, 30);
            insertButton.TabIndex = 16;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = false;
            insertButton.Click += insertButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(328, 92);
            label9.Name = "label9";
            label9.Size = new Size(52, 21);
            label9.TabIndex = 27;
            label9.Text = "STCTL";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F);
            label.ForeColor = Color.Black;
            label.Location = new Point(599, 92);
            label.Name = "label";
            label.Size = new Size(54, 21);
            label.TabIndex = 25;
            label.Text = "Ma CT";
            // 
            // studentData
            // 
            studentData.AllowUserToAddRows = false;
            studentData.AllowUserToDeleteRows = false;
            studentData.AllowUserToResizeColumns = false;
            studentData.AllowUserToResizeRows = false;
            studentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            studentData.BorderStyle = BorderStyle.None;
            studentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentData.Dock = DockStyle.Bottom;
            studentData.Location = new Point(0, 333);
            studentData.Margin = new Padding(3, 2, 3, 2);
            studentData.Name = "studentData";
            studentData.ReadOnly = true;
            studentData.RowHeadersVisible = false;
            studentData.RowHeadersWidth = 51;
            studentData.Size = new Size(1375, 531);
            studentData.TabIndex = 0;
            studentData.CellClick += studentData_CellClick;
            // 
            // programCbo
            // 
            programCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programCbo.FormattingEnabled = true;
            programCbo.Items.AddRange(new object[] { "CQ", "CLC", "CTTT", "VP" });
            programCbo.Location = new Point(602, 114);
            programCbo.Margin = new Padding(3, 2, 3, 2);
            programCbo.Name = "programCbo";
            programCbo.Size = new Size(66, 24);
            programCbo.TabIndex = 24;
            programCbo.Text = "CQ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(688, 92);
            label8.Name = "label8";
            label8.Size = new Size(111, 21);
            label8.TabIndex = 23;
            label8.Text = "Chuyen nganh";
            // 
            // addressBox
            // 
            addressBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressBox.Location = new Point(329, 51);
            addressBox.Margin = new Padding(3, 2, 3, 2);
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(263, 23);
            addressBox.TabIndex = 1;
            // 
            // majorCbo
            // 
            majorCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            majorCbo.FormattingEnabled = true;
            majorCbo.Items.AddRange(new object[] { "HTTT", "CNPM", "KHMT", "CNTT", "TGMT", "MMT" });
            majorCbo.Location = new Point(688, 114);
            majorCbo.Margin = new Padding(3, 2, 3, 2);
            majorCbo.Name = "majorCbo";
            majorCbo.Size = new Size(66, 24);
            majorCbo.TabIndex = 22;
            majorCbo.Text = "HTTT";
            // 
            // studentName
            // 
            studentName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentName.Location = new Point(54, 112);
            studentName.Margin = new Padding(3, 2, 3, 2);
            studentName.Name = "studentName";
            studentName.Size = new Size(219, 23);
            studentName.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(146, 28);
            label7.Name = "label7";
            label7.Size = new Size(81, 21);
            label7.TabIndex = 21;
            label7.Text = "Dien thoai";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(329, 28);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 12;
            label4.Text = "Dia chi";
            // 
            // phoneBox
            // 
            phoneBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneBox.Location = new Point(146, 51);
            phoneBox.Margin = new Padding(3, 2, 3, 2);
            phoneBox.MaxLength = 11;
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(152, 23);
            phoneBox.TabIndex = 20;
            phoneBox.KeyPress += phoneBox_KeyPress;
            // 
            // bdayBox
            // 
            bdayBox.CustomFormat = "dd-MM-yyyy";
            bdayBox.Enabled = false;
            bdayBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdayBox.Format = DateTimePickerFormat.Custom;
            bdayBox.Location = new Point(644, 51);
            bdayBox.Margin = new Padding(3, 2, 3, 2);
            bdayBox.Name = "bdayBox";
            bdayBox.Size = new Size(110, 23);
            bdayBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(513, 92);
            label6.Name = "label6";
            label6.Size = new Size(69, 21);
            label6.TabIndex = 19;
            label6.Text = "Gioi tinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(54, 89);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 14;
            label1.Text = "Ho ten";
            // 
            // genderCbo
            // 
            genderCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderCbo.FormattingEnabled = true;
            genderCbo.Items.AddRange(new object[] { "NAM", "NU" });
            genderCbo.Location = new Point(513, 114);
            genderCbo.Margin = new Padding(3, 2, 3, 2);
            genderCbo.Name = "genderCbo";
            genderCbo.Size = new Size(66, 24);
            genderCbo.TabIndex = 18;
            genderCbo.Text = "NAM";
            // 
            // studentID
            // 
            studentID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentID.Location = new Point(54, 49);
            studentID.Margin = new Padding(3, 2, 3, 2);
            studentID.Name = "studentID";
            studentID.ReadOnly = true;
            studentID.Size = new Size(66, 23);
            studentID.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(644, 28);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 17;
            label5.Text = "Ngay sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(54, 26);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 16;
            label3.Text = "Ma SV";
            // 
            // StudentManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 864);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentManager";
            Text = "StudentManager";
            Load += StudentManager_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gpaUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)creditUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView studentData;
        private TextBox studentName;
        private Button updateButton;
        private Button insertButton;
        private TextBox addressBox;
        private Label label4;
        private DateTimePicker bdayBox;
        private TextBox studentID;
        private Label label1;
        private Label label5;
        private Label label3;
        private Label label6;
        private ComboBox genderCbo;
        private Label label7;
        private TextBox phoneBox;
        private ComboBox majorCbo;
        private Label label;
        private ComboBox programCbo;
        private Label label8;
        private Button refreshButton;
        private Label label9;
        private Label label10;
        private NumericUpDown gpaUpDown;
        private NumericUpDown creditUpDown;
    }
}