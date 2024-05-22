namespace ATBM_A_11.General_Forms
{
    partial class Course
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
            courseData = new DataGridView();
            unitData = new DataGridView();
            planData = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)courseData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unitData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)planData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(courseData);
            panel1.Controls.Add(unitData);
            panel1.Controls.Add(planData);
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1334, 753);
            panel1.TabIndex = 2;
            // 
            // courseData
            // 
            courseData.AllowUserToAddRows = false;
            courseData.AllowUserToDeleteRows = false;
            courseData.AllowUserToResizeColumns = false;
            courseData.AllowUserToResizeRows = false;
            courseData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            courseData.BorderStyle = BorderStyle.None;
            courseData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            courseData.Location = new Point(39, 20);
            courseData.Margin = new Padding(3, 2, 3, 2);
            courseData.Name = "courseData";
            courseData.ReadOnly = true;
            courseData.RowHeadersVisible = false;
            courseData.RowHeadersWidth = 51;
            courseData.Size = new Size(1277, 267);
            courseData.TabIndex = 10;
            // 
            // unitData
            // 
            unitData.AllowUserToAddRows = false;
            unitData.AllowUserToDeleteRows = false;
            unitData.AllowUserToResizeColumns = false;
            unitData.AllowUserToResizeRows = false;
            unitData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            unitData.BorderStyle = BorderStyle.None;
            unitData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            unitData.Location = new Point(1017, 308);
            unitData.Margin = new Padding(3, 2, 3, 2);
            unitData.Name = "unitData";
            unitData.ReadOnly = true;
            unitData.RowHeadersVisible = false;
            unitData.RowHeadersWidth = 51;
            unitData.Size = new Size(299, 349);
            unitData.TabIndex = 8;
            // 
            // planData
            // 
            planData.AllowUserToAddRows = false;
            planData.AllowUserToDeleteRows = false;
            planData.AllowUserToResizeColumns = false;
            planData.AllowUserToResizeRows = false;
            planData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            planData.BorderStyle = BorderStyle.None;
            planData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            planData.Location = new Point(39, 308);
            planData.Margin = new Padding(3, 2, 3, 2);
            planData.Name = "planData";
            planData.ReadOnly = true;
            planData.RowHeadersVisible = false;
            planData.RowHeadersWidth = 51;
            planData.Size = new Size(944, 349);
            planData.TabIndex = 0;
            // 
            // Course
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 752);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Course";
            Text = "Course";
            Load += Course_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)courseData).EndInit();
            ((System.ComponentModel.ISupportInitialize)unitData).EndInit();
            ((System.ComponentModel.ISupportInitialize)planData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView unitData;
        private DataGridView planData;
        private DataGridView courseData;
    }
}