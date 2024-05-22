namespace phan_he_1
{
    partial class PhanQuyen
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
            textBox_user_role = new TextBox();
            label_phan_quyen = new Label();
            dataGridView1 = new DataGridView();
            lb_check = new Label();
            btn_phan_quyen = new Button();
            btn_check = new Button();
            comboBox_table = new ComboBox();
            dataGridView_insert = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_insert).BeginInit();
            SuspendLayout();
            // 
            // textBox_user_role
            // 
            textBox_user_role.Font = new Font("Segoe UI", 14.25F);
            textBox_user_role.Location = new Point(370, 36);
            textBox_user_role.Margin = new Padding(4, 3, 4, 3);
            textBox_user_role.Name = "textBox_user_role";
            textBox_user_role.Size = new Size(194, 33);
            textBox_user_role.TabIndex = 0;
            // 
            // label_phan_quyen
            // 
            label_phan_quyen.AutoSize = true;
            label_phan_quyen.Font = new Font("Segoe UI", 14.25F);
            label_phan_quyen.Location = new Point(34, 39);
            label_phan_quyen.Margin = new Padding(4, 0, 4, 0);
            label_phan_quyen.Name = "label_phan_quyen";
            label_phan_quyen.Size = new Size(328, 25);
            label_phan_quyen.TabIndex = 1;
            label_phan_quyen.Text = "Nhap User hoac Role can phan quyen";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(103, 517);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1220, 312);
            dataGridView1.TabIndex = 2;
            // 
            // lb_check
            // 
            lb_check.AutoSize = true;
            lb_check.Font = new Font("Segoe UI", 14.25F);
            lb_check.Location = new Point(99, 486);
            lb_check.Margin = new Padding(4, 0, 4, 0);
            lb_check.Name = "lb_check";
            lb_check.Size = new Size(231, 25);
            lb_check.TabIndex = 3;
            lb_check.Text = "PHAN QUYEN MUC BANG";
            // 
            // btn_phan_quyen
            // 
            btn_phan_quyen.BackColor = Color.IndianRed;
            btn_phan_quyen.Font = new Font("Segoe UI", 14.25F);
            btn_phan_quyen.ForeColor = Color.White;
            btn_phan_quyen.Location = new Point(1331, 766);
            btn_phan_quyen.Margin = new Padding(4, 3, 4, 3);
            btn_phan_quyen.Name = "btn_phan_quyen";
            btn_phan_quyen.Size = new Size(148, 63);
            btn_phan_quyen.TabIndex = 4;
            btn_phan_quyen.Text = "Gan";
            btn_phan_quyen.UseVisualStyleBackColor = false;
            btn_phan_quyen.Click += btn_phan_quyen_Click;
            // 
            // btn_check
            // 
            btn_check.BackColor = Color.IndianRed;
            btn_check.Font = new Font("Segoe UI", 14.25F);
            btn_check.ForeColor = Color.White;
            btn_check.Location = new Point(602, 30);
            btn_check.Margin = new Padding(4, 3, 4, 3);
            btn_check.Name = "btn_check";
            btn_check.Size = new Size(106, 43);
            btn_check.TabIndex = 5;
            btn_check.Text = "Check";
            btn_check.UseVisualStyleBackColor = false;
            btn_check.Click += btn_check_Click;
            // 
            // comboBox_table
            // 
            comboBox_table.Font = new Font("Segoe UI", 14.25F);
            comboBox_table.FormattingEnabled = true;
            comboBox_table.Location = new Point(284, 107);
            comboBox_table.Margin = new Padding(4, 3, 4, 3);
            comboBox_table.Name = "comboBox_table";
            comboBox_table.Size = new Size(140, 33);
            comboBox_table.TabIndex = 7;
            // 
            // dataGridView_insert
            // 
            dataGridView_insert.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_insert.Location = new Point(471, 105);
            dataGridView_insert.Margin = new Padding(4, 3, 4, 3);
            dataGridView_insert.Name = "dataGridView_insert";
            dataGridView_insert.Size = new Size(852, 323);
            dataGridView_insert.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 14.25F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(315, 169);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(109, 56);
            button1.TabIndex = 9;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Font = new Font("Segoe UI", 14.25F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1331, 362);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(148, 66);
            button2.TabIndex = 10;
            button2.Text = "Gan";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(34, 105);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(215, 25);
            label1.TabIndex = 11;
            label1.Text = "PHAN QUYEN MUC COT";
            // 
            // PhanQuyen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 905);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView_insert);
            Controls.Add(comboBox_table);
            Controls.Add(btn_check);
            Controls.Add(btn_phan_quyen);
            Controls.Add(lb_check);
            Controls.Add(dataGridView1);
            Controls.Add(label_phan_quyen);
            Controls.Add(textBox_user_role);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PhanQuyen";
            Text = "PhanQuyen";
            Load += PhanQuyen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_insert).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_user_role;
        private System.Windows.Forms.Label label_phan_quyen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_check;
        private System.Windows.Forms.Button btn_phan_quyen;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.ComboBox comboBox_table;
        private System.Windows.Forms.DataGridView dataGridView_insert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}