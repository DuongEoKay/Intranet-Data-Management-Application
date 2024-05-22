namespace ATBM_A_11.General_Forms
{
    partial class SinhVien
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
            studentData = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(studentData);
            panel1.Location = new Point(112, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1151, 782);
            panel1.TabIndex = 0;
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
            studentData.Location = new Point(0, 9);
            studentData.Margin = new Padding(3, 2, 3, 2);
            studentData.Name = "studentData";
            studentData.ReadOnly = true;
            studentData.RowHeadersVisible = false;
            studentData.RowHeadersWidth = 51;
            studentData.Size = new Size(1151, 773);
            studentData.TabIndex = 0;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 795);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Student";
            Text = "Student";
            Load += Student_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)studentData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView studentData;
    }
}