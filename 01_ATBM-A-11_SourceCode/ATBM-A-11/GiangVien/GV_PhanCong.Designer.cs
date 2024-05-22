namespace ATBM_A_11.Lecturer_Forms
{
    partial class GV_PhanCong
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
            ((System.ComponentModel.ISupportInitialize)assignmentData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // assignmentData
            // 
            assignmentData.AllowUserToAddRows = false;
            assignmentData.AllowUserToDeleteRows = false;
            assignmentData.AllowUserToResizeColumns = false;
            assignmentData.AllowUserToResizeRows = false;
            assignmentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            assignmentData.BorderStyle = BorderStyle.None;
            assignmentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            assignmentData.Location = new Point(509, 18);
            assignmentData.Margin = new Padding(3, 2, 3, 2);
            assignmentData.Name = "assignmentData";
            assignmentData.ReadOnly = true;
            assignmentData.RowHeadersVisible = false;
            assignmentData.RowHeadersWidth = 51;
            assignmentData.Size = new Size(246, 510);
            assignmentData.TabIndex = 0;
            assignmentData.CellClick += assignmentData_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(assignmentData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 528);
            panel1.TabIndex = 1;
            // 
            // Assignment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 528);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Assignment";
            Text = "Assignment";
            Load += Assignment_Load;
            ((System.ComponentModel.ISupportInitialize)assignmentData).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView assignmentData;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox courseName;
        private Label label2;
        private Label label3;
        private TextBox lecturerName;
        private Label label4;
        private TextBox courseIDBox;
        private TextBox yearBox;
        private TextBox semesterBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox programBox;
    }
}