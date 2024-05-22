namespace ATBM_A_11.Student_Forms
{
    partial class SV_TTCN
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
            label3 = new Label();
            addressBox = new TextBox();
            genderBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            IDBox = new TextBox();
            updateButton = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            bdayBox = new DateTimePicker();
            nameBox = new TextBox();
            phoneBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addressBox);
            panel1.Controls.Add(genderBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(IDBox);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(bdayBox);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(phoneBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 730);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(411, 381);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 27;
            label3.Text = "Dia Chi";
            // 
            // addressBox
            // 
            addressBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressBox.Location = new Point(411, 404);
            addressBox.Margin = new Padding(3, 2, 3, 2);
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(438, 23);
            addressBox.TabIndex = 26;
            // 
            // genderBox
            // 
            genderBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderBox.Location = new Point(411, 316);
            genderBox.Margin = new Padding(3, 2, 3, 2);
            genderBox.MaxLength = 11;
            genderBox.Name = "genderBox";
            genderBox.ReadOnly = true;
            genderBox.Size = new Size(110, 23);
            genderBox.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(411, 293);
            label7.Name = "label7";
            label7.Size = new Size(72, 21);
            label7.TabIndex = 24;
            label7.Text = "Gioi Tinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(411, 216);
            label6.Name = "label6";
            label6.Size = new Size(32, 21);
            label6.TabIndex = 20;
            label6.Text = "Ma";
            // 
            // IDBox
            // 
            IDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDBox.Location = new Point(411, 239);
            IDBox.Margin = new Padding(3, 2, 3, 2);
            IDBox.MaxLength = 11;
            IDBox.Name = "IDBox";
            IDBox.ReadOnly = true;
            IDBox.Size = new Size(90, 23);
            IDBox.TabIndex = 19;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.IndianRed;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(953, 305);
            updateButton.Margin = new Padding(3, 2, 3, 2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(175, 38);
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
            label4.Location = new Point(717, 293);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 14;
            label4.Text = "Ngay Sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(542, 216);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 13;
            label2.Text = "Ho Ten";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(542, 293);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 12;
            label1.Text = "DT";
            // 
            // bdayBox
            // 
            bdayBox.CustomFormat = "dd-MM-yyyy";
            bdayBox.Enabled = false;
            bdayBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdayBox.Format = DateTimePickerFormat.Custom;
            bdayBox.Location = new Point(717, 316);
            bdayBox.Margin = new Padding(3, 2, 3, 2);
            bdayBox.Name = "bdayBox";
            bdayBox.Size = new Size(132, 23);
            bdayBox.TabIndex = 3;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.Location = new Point(542, 239);
            nameBox.Margin = new Padding(3, 2, 3, 2);
            nameBox.Name = "nameBox";
            nameBox.ReadOnly = true;
            nameBox.Size = new Size(307, 23);
            nameBox.TabIndex = 2;
            // 
            // phoneBox
            // 
            phoneBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneBox.Location = new Point(542, 316);
            phoneBox.Margin = new Padding(3, 2, 3, 2);
            phoneBox.MaxLength = 11;
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(154, 23);
            phoneBox.TabIndex = 1;
            phoneBox.KeyPress += phoneBox_KeyPress;
            // 
            // Student_Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 730);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Student_Account";
            Text = "Student_Account";
            Load += Student_Account_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox genderBox;
        private Label label7;
        private Label label6;
        private TextBox IDBox;
        private Button updateButton;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label2;
        private Label label1;
        private DateTimePicker bdayBox;
        private TextBox nameBox;
        private TextBox phoneBox;
        private TextBox addressBox;
        private Label label3;
    }
}