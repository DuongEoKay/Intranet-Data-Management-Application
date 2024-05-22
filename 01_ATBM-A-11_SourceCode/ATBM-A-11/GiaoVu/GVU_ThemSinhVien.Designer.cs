namespace ATBM_A_11.Ministry_Forms
{
    partial class GVU_ThemSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GVU_ThemSinhVien));
            panel1 = new Panel();
            label9 = new Label();
            studentID = new TextBox();
            label3 = new Label();
            facilityCbo = new ComboBox();
            studentName = new TextBox();
            label6 = new Label();
            label = new Label();
            label2 = new Label();
            label8 = new Label();
            programCbo = new ComboBox();
            label7 = new Label();
            insertButton = new Button();
            label4 = new Label();
            genderCbo = new ComboBox();
            addressBox = new TextBox();
            majorCbo = new ComboBox();
            bdayBox = new DateTimePicker();
            label1 = new Label();
            phoneBox = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(studentID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(facilityCbo);
            panel1.Controls.Add(studentName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(programCbo);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(insertButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(genderCbo);
            panel1.Controls.Add(addressBox);
            panel1.Controls.Add(majorCbo);
            panel1.Controls.Add(bdayBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(phoneBox);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 332);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(12, 57);
            label9.Name = "label9";
            label9.Size = new Size(55, 21);
            label9.TabIndex = 45;
            label9.Text = "Ma SV";
            // 
            // studentID
            // 
            studentID.CharacterCasing = CharacterCasing.Upper;
            studentID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentID.Location = new Point(12, 80);
            studentID.Margin = new Padding(3, 2, 3, 2);
            studentID.Name = "studentID";
            studentID.Size = new Size(132, 23);
            studentID.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(518, 210);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 43;
            label3.Text = "Co so";
            // 
            // facilityCbo
            // 
            facilityCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            facilityCbo.FormattingEnabled = true;
            facilityCbo.Items.AddRange(new object[] { "1", "2" });
            facilityCbo.Location = new Point(518, 233);
            facilityCbo.Margin = new Padding(3, 2, 3, 2);
            facilityCbo.Name = "facilityCbo";
            facilityCbo.Size = new Size(44, 24);
            facilityCbo.TabIndex = 42;
            facilityCbo.Text = "1";
            // 
            // studentName
            // 
            studentName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentName.Location = new Point(171, 80);
            studentName.Margin = new Padding(3, 2, 3, 2);
            studentName.Name = "studentName";
            studentName.Size = new Size(219, 23);
            studentName.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 126);
            label6.Name = "label6";
            label6.Size = new Size(69, 21);
            label6.TabIndex = 35;
            label6.Text = "Gioi tinh";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.White;
            label.Font = new Font("Segoe UI", 12F);
            label.ForeColor = Color.Black;
            label.Location = new Point(147, 127);
            label.Name = "label";
            label.Size = new Size(54, 21);
            label.TabIndex = 41;
            label.Text = "Ma CT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(309, 9);
            label2.Name = "label2";
            label2.Size = new Size(193, 35);
            label2.TabIndex = 36;
            label2.Text = "Them Sinh Vien";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(261, 128);
            label8.Name = "label8";
            label8.Size = new Size(111, 21);
            label8.TabIndex = 39;
            label8.Text = "Chuyen nganh";
            // 
            // programCbo
            // 
            programCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programCbo.FormattingEnabled = true;
            programCbo.Items.AddRange(new object[] { "CQ", "CLC", "CTTT", "VP" });
            programCbo.Location = new Point(147, 153);
            programCbo.Margin = new Padding(3, 2, 3, 2);
            programCbo.Name = "programCbo";
            programCbo.Size = new Size(66, 24);
            programCbo.TabIndex = 40;
            programCbo.Text = "CQ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(430, 129);
            label7.Name = "label7";
            label7.Size = new Size(28, 21);
            label7.TabIndex = 37;
            label7.Text = "DT";
            // 
            // insertButton
            // 
            insertButton.BackColor = Color.IndianRed;
            insertButton.FlatAppearance.BorderSize = 0;
            insertButton.FlatStyle = FlatStyle.Flat;
            insertButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insertButton.ForeColor = Color.White;
            insertButton.Location = new Point(654, 138);
            insertButton.Margin = new Padding(3, 2, 3, 2);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(136, 38);
            insertButton.TabIndex = 34;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = false;
            insertButton.Click += insertButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 210);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 28;
            label4.Text = "Dia chi";
            // 
            // genderCbo
            // 
            genderCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderCbo.FormattingEnabled = true;
            genderCbo.Items.AddRange(new object[] { "NAM", "NU" });
            genderCbo.Location = new Point(12, 152);
            genderCbo.Margin = new Padding(3, 2, 3, 2);
            genderCbo.Name = "genderCbo";
            genderCbo.Size = new Size(66, 24);
            genderCbo.TabIndex = 34;
            genderCbo.Text = "NAM";
            // 
            // addressBox
            // 
            addressBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressBox.Location = new Point(12, 233);
            addressBox.Margin = new Padding(3, 2, 3, 2);
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(438, 23);
            addressBox.TabIndex = 27;
            // 
            // majorCbo
            // 
            majorCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            majorCbo.FormattingEnabled = true;
            majorCbo.Items.AddRange(new object[] { "HTTT", "CNPM", "KHMT", "CNTT", "TGMT", "MMT" });
            majorCbo.Location = new Point(261, 154);
            majorCbo.Margin = new Padding(3, 2, 3, 2);
            majorCbo.Name = "majorCbo";
            majorCbo.Size = new Size(110, 24);
            majorCbo.TabIndex = 38;
            majorCbo.Text = "HTTT";
            // 
            // bdayBox
            // 
            bdayBox.CustomFormat = "dd-MM-yyyy";
            bdayBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdayBox.Format = DateTimePickerFormat.Custom;
            bdayBox.Location = new Point(430, 78);
            bdayBox.Margin = new Padding(3, 2, 3, 2);
            bdayBox.Name = "bdayBox";
            bdayBox.Size = new Size(132, 23);
            bdayBox.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(171, 58);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 30;
            label1.Text = "Ho ten SV";
            // 
            // phoneBox
            // 
            phoneBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneBox.Location = new Point(430, 155);
            phoneBox.Margin = new Padding(3, 2, 3, 2);
            phoneBox.MaxLength = 11;
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(132, 23);
            phoneBox.TabIndex = 36;
            phoneBox.KeyPress += phoneBox_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(430, 56);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 33;
            label5.Text = "Ngay sinh";
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 332);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Student";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label;
        private ComboBox programCbo;
        private Label label8;
        private ComboBox majorCbo;
        private Label label7;
        private TextBox phoneBox;
        private Label label6;
        private ComboBox genderCbo;
        private Label label5;
        private Label label1;
        private DateTimePicker bdayBox;
        private Label label4;
        private TextBox addressBox;
        private TextBox studentName;
        private Button cancelButton;
        private Button insertButton;
        private Label label2;
        private Label label3;
        private ComboBox facilityCbo;
        private Label label9;
        public TextBox studentID;
    }
}