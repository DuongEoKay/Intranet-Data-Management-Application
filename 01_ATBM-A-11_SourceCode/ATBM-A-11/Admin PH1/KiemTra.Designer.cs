namespace phan_he_1
{
    partial class KiemTra
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
            lb_nhap = new Label();
            btn_kiem_tra_muc_bang = new Button();
            btn_kiem_tra_muc_cot = new Button();
            dataGridView_quyen = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_quyen).BeginInit();
            SuspendLayout();
            // 
            // textBox_user_role
            // 
            textBox_user_role.Location = new Point(531, 44);
            textBox_user_role.Margin = new Padding(4, 3, 4, 3);
            textBox_user_role.Name = "textBox_user_role";
            textBox_user_role.Size = new Size(135, 23);
            textBox_user_role.TabIndex = 0;
            // 
            // lb_nhap
            // 
            lb_nhap.AutoSize = true;
            lb_nhap.Font = new Font("Segoe UI", 14.25F);
            lb_nhap.Location = new Point(227, 42);
            lb_nhap.Margin = new Padding(4, 0, 4, 0);
            lb_nhap.Name = "lb_nhap";
            lb_nhap.Size = new Size(296, 25);
            lb_nhap.TabIndex = 1;
            lb_nhap.Text = "Nhap User hoac Role can kiem tra";
            // 
            // btn_kiem_tra_muc_bang
            // 
            btn_kiem_tra_muc_bang.BackColor = Color.IndianRed;
            btn_kiem_tra_muc_bang.Font = new Font("Segoe UI", 14.25F);
            btn_kiem_tra_muc_bang.ForeColor = Color.White;
            btn_kiem_tra_muc_bang.Location = new Point(31, 207);
            btn_kiem_tra_muc_bang.Margin = new Padding(4, 3, 4, 3);
            btn_kiem_tra_muc_bang.Name = "btn_kiem_tra_muc_bang";
            btn_kiem_tra_muc_bang.Size = new Size(166, 97);
            btn_kiem_tra_muc_bang.TabIndex = 2;
            btn_kiem_tra_muc_bang.Text = "Kiem tra theo muc bang";
            btn_kiem_tra_muc_bang.UseVisualStyleBackColor = false;
            btn_kiem_tra_muc_bang.Click += btn_kiem_tra_muc_bang_Click;
            // 
            // btn_kiem_tra_muc_cot
            // 
            btn_kiem_tra_muc_cot.BackColor = Color.IndianRed;
            btn_kiem_tra_muc_cot.Font = new Font("Segoe UI", 14.25F);
            btn_kiem_tra_muc_cot.ForeColor = Color.White;
            btn_kiem_tra_muc_cot.Location = new Point(31, 411);
            btn_kiem_tra_muc_cot.Margin = new Padding(4, 3, 4, 3);
            btn_kiem_tra_muc_cot.Name = "btn_kiem_tra_muc_cot";
            btn_kiem_tra_muc_cot.Size = new Size(166, 103);
            btn_kiem_tra_muc_cot.TabIndex = 3;
            btn_kiem_tra_muc_cot.Text = "Kiem tra theo muc cot";
            btn_kiem_tra_muc_cot.UseVisualStyleBackColor = false;
            btn_kiem_tra_muc_cot.Click += btn_kiem_tra_muc_cot_Click;
            // 
            // dataGridView_quyen
            // 
            dataGridView_quyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_quyen.Location = new Point(241, 96);
            dataGridView_quyen.Margin = new Padding(4, 3, 4, 3);
            dataGridView_quyen.Name = "dataGridView_quyen";
            dataGridView_quyen.Size = new Size(896, 562);
            dataGridView_quyen.TabIndex = 4;
            // 
            // KiemTra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 661);
            Controls.Add(dataGridView_quyen);
            Controls.Add(btn_kiem_tra_muc_cot);
            Controls.Add(btn_kiem_tra_muc_bang);
            Controls.Add(lb_nhap);
            Controls.Add(textBox_user_role);
            Margin = new Padding(4, 3, 4, 3);
            Name = "KiemTra";
            Text = "KiemTra";
            ((System.ComponentModel.ISupportInitialize)dataGridView_quyen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_user_role;
        private System.Windows.Forms.Label lb_nhap;
        private System.Windows.Forms.Button btn_kiem_tra_muc_bang;
        private System.Windows.Forms.Button btn_kiem_tra_muc_cot;
        private System.Windows.Forms.DataGridView dataGridView_quyen;
    }
}