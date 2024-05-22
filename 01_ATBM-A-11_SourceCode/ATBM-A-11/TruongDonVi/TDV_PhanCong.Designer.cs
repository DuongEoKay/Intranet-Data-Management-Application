namespace ATBM_A_11.UnitHead_Forms
{
    partial class TDV_PhanCong
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
            assignmentData = new DataGridView();
            panel1 = new Panel();
            lectIDBox = new TextBox();
            refreshButton = new Button();
            label2 = new Label();
            deleteButton = new Button();
            label1 = new Label();
            updateButton = new Button();
            label7 = new Label();
            insertButton = new Button();
            label5 = new Label();
            yearUpDown = new NumericUpDown();
            unitNameBox = new TextBox();
            semUpDown = new NumericUpDown();
            programCbo = new ComboBox();
            courseCbo = new ComboBox();
            unitIDBox = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)assignmentData).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yearUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)semUpDown).BeginInit();
            SuspendLayout();
            // 
            // assignmentData
            // 
            assignmentData.AllowUserToAddRows = false;
            assignmentData.AllowUserToDeleteRows = false;
            assignmentData.AllowUserToResizeColumns = false;
            assignmentData.AllowUserToResizeRows = false;
            assignmentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            assignmentData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            assignmentData.BorderStyle = BorderStyle.None;
            assignmentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            assignmentData.Location = new Point(370, 176);
            assignmentData.Margin = new Padding(3, 2, 3, 2);
            assignmentData.Name = "assignmentData";
            assignmentData.ReadOnly = true;
            assignmentData.RowHeadersVisible = false;
            assignmentData.RowHeadersWidth = 51;
            assignmentData.Size = new Size(587, 518);
            assignmentData.TabIndex = 0;
            assignmentData.CellClick += assignmentData_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(assignmentData);
            panel1.Controls.Add(lectIDBox);
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(insertButton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(yearUpDown);
            panel1.Controls.Add(unitNameBox);
            panel1.Controls.Add(semUpDown);
            panel1.Controls.Add(programCbo);
            panel1.Controls.Add(courseCbo);
            panel1.Controls.Add(unitIDBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 696);
            panel1.TabIndex = 1;
            // 
            // lectIDBox
            // 
            lectIDBox.Location = new Point(35, 55);
            lectIDBox.Margin = new Padding(3, 2, 3, 2);
            lectIDBox.Name = "lectIDBox";
            lectIDBox.Size = new Size(219, 23);
            lectIDBox.TabIndex = 59;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.IndianRed;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(1120, 111);
            refreshButton.Margin = new Padding(3, 2, 3, 2);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(88, 30);
            refreshButton.TabIndex = 26;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(524, 100);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 58;
            label2.Text = "Ten Don Vi";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.IndianRed;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(1120, 44);
            deleteButton.Margin = new Padding(3, 2, 3, 2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(88, 30);
            deleteButton.TabIndex = 25;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(35, 100);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 7;
            label1.Text = "Ten KH";
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.IndianRed;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(968, 111);
            updateButton.Margin = new Padding(3, 2, 3, 2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(88, 30);
            updateButton.TabIndex = 24;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(335, 100);
            label7.Name = "label7";
            label7.Size = new Size(57, 21);
            label7.TabIndex = 57;
            label7.Text = "Ma DV";
            // 
            // insertButton
            // 
            insertButton.BackColor = Color.IndianRed;
            insertButton.FlatAppearance.BorderSize = 0;
            insertButton.FlatStyle = FlatStyle.Flat;
            insertButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insertButton.ForeColor = Color.White;
            insertButton.Location = new Point(968, 44);
            insertButton.Margin = new Padding(3, 2, 3, 2);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(88, 30);
            insertButton.TabIndex = 16;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = false;
            insertButton.Click += insertButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(35, 32);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 6;
            label5.Text = "MaGV";
            // 
            // yearUpDown
            // 
            yearUpDown.Location = new Point(524, 56);
            yearUpDown.Margin = new Padding(3, 2, 3, 2);
            yearUpDown.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            yearUpDown.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            yearUpDown.Name = "yearUpDown";
            yearUpDown.ReadOnly = true;
            yearUpDown.Size = new Size(88, 23);
            yearUpDown.TabIndex = 56;
            yearUpDown.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // unitNameBox
            // 
            unitNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitNameBox.Location = new Point(524, 124);
            unitNameBox.Margin = new Padding(3, 2, 3, 2);
            unitNameBox.Name = "unitNameBox";
            unitNameBox.ReadOnly = true;
            unitNameBox.Size = new Size(278, 23);
            unitNameBox.TabIndex = 49;
            // 
            // semUpDown
            // 
            semUpDown.Location = new Point(335, 56);
            semUpDown.Margin = new Padding(3, 2, 3, 2);
            semUpDown.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            semUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            semUpDown.Name = "semUpDown";
            semUpDown.ReadOnly = true;
            semUpDown.Size = new Size(88, 23);
            semUpDown.TabIndex = 55;
            semUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // programCbo
            // 
            programCbo.Enabled = false;
            programCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programCbo.FormattingEnabled = true;
            programCbo.Items.AddRange(new object[] { "CQ", "VP", "CTTT", "CLC" });
            programCbo.Location = new Point(714, 56);
            programCbo.Margin = new Padding(3, 2, 3, 2);
            programCbo.Name = "programCbo";
            programCbo.Size = new Size(88, 24);
            programCbo.TabIndex = 51;
            programCbo.Text = "CQ";
            // 
            // courseCbo
            // 
            courseCbo.Enabled = false;
            courseCbo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseCbo.FormattingEnabled = true;
            courseCbo.Location = new Point(35, 123);
            courseCbo.Margin = new Padding(3, 2, 3, 2);
            courseCbo.Name = "courseCbo";
            courseCbo.Size = new Size(219, 24);
            courseCbo.TabIndex = 1;
            // 
            // unitIDBox
            // 
            unitIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitIDBox.Location = new Point(335, 124);
            unitIDBox.Margin = new Padding(3, 2, 3, 2);
            unitIDBox.Name = "unitIDBox";
            unitIDBox.ReadOnly = true;
            unitIDBox.Size = new Size(88, 23);
            unitIDBox.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(715, 33);
            label4.Name = "label4";
            label4.Size = new Size(28, 21);
            label4.TabIndex = 54;
            label4.Text = "CT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(335, 33);
            label6.Name = "label6";
            label6.Size = new Size(30, 21);
            label6.TabIndex = 52;
            label6.Text = "HK";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(524, 33);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 53;
            label3.Text = "Nam";
            // 
            // UnitAssignment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 696);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UnitAssignment";
            Text = "UnitAssignment";
            Load += UnitAssignment_Load;
            ((System.ComponentModel.ISupportInitialize)assignmentData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yearUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)semUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView assignmentData;
        private Panel panel1;
        private Button updateButton;
        private Button insertButton;
        private Button deleteButton;
        private Button refreshButton;
        private ComboBox courseCbo;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label label7;
        private NumericUpDown yearUpDown;
        private NumericUpDown semUpDown;
        private Label label4;
        private Label label3;
        private TextBox unitNameBox;
        private Label label6;
        private TextBox unitIDBox;
        private ComboBox programCbo;
        private TextBox lectIDBox;
    }
}