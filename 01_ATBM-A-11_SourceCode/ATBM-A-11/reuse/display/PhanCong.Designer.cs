namespace ATBM_A_11.General_Forms.Popup_Forms
{
    partial class PhanCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanCong));
            panel1 = new Panel();
            progCbo = new ComboBox();
            KhmoData = new DataGridView();
            yearUpDown = new NumericUpDown();
            unitNameBox = new TextBox();
            label3 = new Label();
            lecturerID = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            insertButton = new Button();
            unitIDBox = new TextBox();
            semUpDown = new NumericUpDown();
            label5 = new Label();
            courseID = new TextBox();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)KhmoData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yearUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)semUpDown).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(progCbo);
            panel1.Controls.Add(KhmoData);
            panel1.Controls.Add(yearUpDown);
            panel1.Controls.Add(unitNameBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lecturerID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(insertButton);
            panel1.Controls.Add(unitIDBox);
            panel1.Controls.Add(semUpDown);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(courseID);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 508);
            panel1.TabIndex = 0;
            // 
            // progCbo
            // 
            progCbo.Enabled = false;
            progCbo.FormattingEnabled = true;
            progCbo.Items.AddRange(new object[] { "CQ", "CLC", "CTTT", "VP" });
            progCbo.Location = new Point(26, 100);
            progCbo.Margin = new Padding(3, 2, 3, 2);
            progCbo.Name = "progCbo";
            progCbo.Size = new Size(88, 23);
            progCbo.TabIndex = 46;
            progCbo.Text = "CQ";
            // 
            // KhmoData
            // 
            KhmoData.AllowUserToAddRows = false;
            KhmoData.AllowUserToDeleteRows = false;
            KhmoData.AllowUserToResizeColumns = false;
            KhmoData.AllowUserToResizeRows = false;
            KhmoData.BorderStyle = BorderStyle.None;
            KhmoData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KhmoData.Dock = DockStyle.Bottom;
            KhmoData.Location = new Point(0, 184);
            KhmoData.Margin = new Padding(3, 2, 3, 2);
            KhmoData.Name = "KhmoData";
            KhmoData.ReadOnly = true;
            KhmoData.RowHeadersVisible = false;
            KhmoData.RowHeadersWidth = 51;
            KhmoData.Size = new Size(793, 324);
            KhmoData.TabIndex = 1;
            KhmoData.CellClick += KhmoData_CellClick;
            // 
            // yearUpDown
            // 
            yearUpDown.Location = new Point(257, 99);
            yearUpDown.Margin = new Padding(3, 2, 3, 2);
            yearUpDown.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            yearUpDown.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            yearUpDown.Name = "yearUpDown";
            yearUpDown.ReadOnly = true;
            yearUpDown.Size = new Size(88, 23);
            yearUpDown.TabIndex = 45;
            yearUpDown.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // unitNameBox
            // 
            unitNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitNameBox.Location = new Point(341, 48);
            unitNameBox.Margin = new Padding(3, 2, 3, 2);
            unitNameBox.Name = "unitNameBox";
            unitNameBox.ReadOnly = true;
            unitNameBox.Size = new Size(132, 23);
            unitNameBox.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(340, 29);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 44;
            label3.Text = "Ten don vi";
            // 
            // lecturerID
            // 
            lecturerID.CharacterCasing = CharacterCasing.Upper;
            lecturerID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lecturerID.Location = new Point(26, 48);
            lecturerID.Margin = new Padding(3, 2, 3, 2);
            lecturerID.Name = "lecturerID";
            lecturerID.Size = new Size(133, 23);
            lecturerID.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 27;
            label1.Text = "Ma GV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(144, 81);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 43;
            label4.Text = "Ma don vi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(179, 29);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 31;
            label2.Text = "Ma KH";
            // 
            // insertButton
            // 
            insertButton.BackColor = Color.IndianRed;
            insertButton.FlatAppearance.BorderSize = 0;
            insertButton.FlatStyle = FlatStyle.Flat;
            insertButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insertButton.ForeColor = Color.White;
            insertButton.Location = new Point(607, 69);
            insertButton.Margin = new Padding(3, 2, 3, 2);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(88, 30);
            insertButton.TabIndex = 34;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = false;
            insertButton.Click += insertButton_Click;
            // 
            // unitIDBox
            // 
            unitIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitIDBox.Location = new Point(144, 100);
            unitIDBox.Margin = new Padding(3, 2, 3, 2);
            unitIDBox.Name = "unitIDBox";
            unitIDBox.ReadOnly = true;
            unitIDBox.Size = new Size(88, 23);
            unitIDBox.TabIndex = 32;
            // 
            // semUpDown
            // 
            semUpDown.Location = new Point(385, 99);
            semUpDown.Margin = new Padding(3, 2, 3, 2);
            semUpDown.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            semUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            semUpDown.Name = "semUpDown";
            semUpDown.ReadOnly = true;
            semUpDown.Size = new Size(88, 23);
            semUpDown.TabIndex = 42;
            semUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(384, 80);
            label5.Name = "label5";
            label5.Size = new Size(30, 21);
            label5.TabIndex = 33;
            label5.Text = "HK";
            // 
            // courseID
            // 
            courseID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseID.Location = new Point(179, 48);
            courseID.Margin = new Padding(3, 2, 3, 2);
            courseID.Name = "courseID";
            courseID.ReadOnly = true;
            courseID.Size = new Size(132, 23);
            courseID.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(257, 80);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 36;
            label6.Text = "Nam";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(26, 81);
            label7.Name = "label7";
            label7.Size = new Size(54, 21);
            label7.TabIndex = 37;
            label7.Text = "Ma CT";
            // 
            // AddAssignment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 508);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddAssignment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Assignment";
            Load += AddAssignment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)KhmoData).EndInit();
            ((System.ComponentModel.ISupportInitialize)yearUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)semUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button cancelButton;
        private Button insertButton;
        private DataGridView KhmoData;
        private Label label3;
        private Label label4;
        private Button RefreshButton;
        private Label label7;
        private Label label6;
        private TextBox unitNameBox;
        private Label label5;
        private TextBox unitIDBox;
        private Label label2;
        private Label label1;
        internal TextBox lecturerID;
        internal TextBox courseID;
        internal NumericUpDown semUpDown;
        internal NumericUpDown yearUpDown;
        internal ComboBox progCbo;
    }
}