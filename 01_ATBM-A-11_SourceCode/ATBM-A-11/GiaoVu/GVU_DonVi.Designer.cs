namespace ATBM_A_11.Ministry_Forms
{
    partial class GVU_DonVi
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
            unitID = new TextBox();
            refreshButton = new Button();
            updateButton = new Button();
            insertButton = new Button();
            unitData = new DataGridView();
            label3 = new Label();
            unitName = new TextBox();
            unitHeadID = new TextBox();
            label5 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)unitData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(unitID);
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(insertButton);
            panel1.Controls.Add(unitData);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(unitName);
            panel1.Controls.Add(unitHeadID);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1397, 931);
            panel1.TabIndex = 0;
            // 
            // unitID
            // 
            unitID.CharacterCasing = CharacterCasing.Upper;
            unitID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitID.Location = new Point(328, 94);
            unitID.Margin = new Padding(3, 2, 3, 2);
            unitID.Name = "unitID";
            unitID.Size = new Size(110, 23);
            unitID.TabIndex = 22;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.IndianRed;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Segoe UI", 14.25F);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(940, 50);
            refreshButton.Margin = new Padding(3, 2, 3, 2);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(109, 30);
            refreshButton.TabIndex = 26;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.IndianRed;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Segoe UI", 14.25F);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(775, 117);
            updateButton.Margin = new Padding(3, 2, 3, 2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(109, 30);
            updateButton.TabIndex = 25;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // insertButton
            // 
            insertButton.BackColor = Color.IndianRed;
            insertButton.FlatAppearance.BorderSize = 0;
            insertButton.FlatStyle = FlatStyle.Flat;
            insertButton.Font = new Font("Segoe UI", 14.25F);
            insertButton.ForeColor = Color.White;
            insertButton.Location = new Point(775, 50);
            insertButton.Margin = new Padding(3, 2, 3, 2);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(109, 30);
            insertButton.TabIndex = 16;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = false;
            insertButton.Click += insertButton_Click;
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
            unitData.Location = new Point(532, 217);
            unitData.Margin = new Padding(3, 2, 3, 2);
            unitData.Name = "unitData";
            unitData.ReadOnly = true;
            unitData.RowHeadersVisible = false;
            unitData.RowHeadersWidth = 51;
            unitData.Size = new Size(296, 341);
            unitData.TabIndex = 1;
            unitData.CellClick += unitData_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(481, 70);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 22;
            label3.Text = "ID truong DV";
            // 
            // unitName
            // 
            unitName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitName.Location = new Point(31, 93);
            unitName.Margin = new Padding(3, 2, 3, 2);
            unitName.Name = "unitName";
            unitName.Size = new Size(263, 23);
            unitName.TabIndex = 0;
            // 
            // unitHeadID
            // 
            unitHeadID.CharacterCasing = CharacterCasing.Upper;
            unitHeadID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitHeadID.Location = new Point(481, 93);
            unitHeadID.Margin = new Padding(3, 2, 3, 2);
            unitHeadID.Name = "unitHeadID";
            unitHeadID.Size = new Size(110, 23);
            unitHeadID.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(31, 70);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 18;
            label5.Text = "Ten don vi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(328, 70);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 20;
            label1.Text = "Ma don vi";
            // 
            // UnitManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 931);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UnitManager";
            Text = "c";
            Load += UnitManager_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)unitData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView unitData;
        private TextBox unitName;
        private Label label5;
        private Label label3;
        private TextBox unitHeadID;
        private Label label1;
        private Button updateButton;
        private Button insertButton;
        private Button refreshButton;
        private TextBox unitID;
    }
}