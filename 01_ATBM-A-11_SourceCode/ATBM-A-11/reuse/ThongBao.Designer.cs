namespace ATBM_A_11.General_Forms
{
    partial class ThongBao
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
            AnnData = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)AnnData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AnnData
            // 
            AnnData.AllowUserToAddRows = false;
            AnnData.AllowUserToDeleteRows = false;
            AnnData.AllowUserToResizeColumns = false;
            AnnData.AllowUserToResizeRows = false;
            AnnData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            AnnData.BorderStyle = BorderStyle.None;
            AnnData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AnnData.Dock = DockStyle.Bottom;
            AnnData.Location = new Point(0, 2);
            AnnData.Margin = new Padding(3, 2, 3, 2);
            AnnData.Name = "AnnData";
            AnnData.ReadOnly = true;
            AnnData.RowHeadersVisible = false;
            AnnData.RowHeadersWidth = 51;
            AnnData.Size = new Size(780, 727);
            AnnData.TabIndex = 1;

            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(AnnData);
            panel1.Location = new Point(293, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 729);
            panel1.TabIndex = 3;
            // 
            // Announcement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 761);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Announcement";
            Text = "Announcement";
            Load += Announcement_Load;
            ((System.ComponentModel.ISupportInitialize)AnnData).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView AnnData;
        private Panel panel1;
        private Label label1;
        private Panel privilagesPanel;
        private NumericUpDown AnnIDUpDown;
        private Label label4;
        private ComboBox LabelCbo;
        private Button RefreshButton;
        private Label label2;
        private TextBox ContentBox;
        private Label label3;
    }
}