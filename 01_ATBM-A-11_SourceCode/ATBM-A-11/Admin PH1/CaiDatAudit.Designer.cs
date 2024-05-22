namespace ATBM_A_11.Admin_PH1
{
    partial class CaiDatAudit
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
            btn_set_audit_object = new Button();
            comboBox_object = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btn_remove_audit_object = new Button();
            checkBox_audit_success = new CheckBox();
            checkBox_audit_fail = new CheckBox();
            SuspendLayout();
            // 
            // btn_set_audit_object
            // 
            btn_set_audit_object.BackColor = Color.IndianRed;
            btn_set_audit_object.Font = new Font("Segoe UI", 14.25F);
            btn_set_audit_object.ForeColor = Color.White;
            btn_set_audit_object.Location = new Point(902, 282);
            btn_set_audit_object.Margin = new Padding(4, 3, 4, 3);
            btn_set_audit_object.Name = "btn_set_audit_object";
            btn_set_audit_object.Size = new Size(172, 49);
            btn_set_audit_object.TabIndex = 15;
            btn_set_audit_object.Text = "Cai Audit Object";
            btn_set_audit_object.UseVisualStyleBackColor = false;
            btn_set_audit_object.Click += btn_set_audit_object_Click;
            // 
            // comboBox_object
            // 
            comboBox_object.Font = new Font("Segoe UI", 14.25F);
            comboBox_object.FormattingEnabled = true;
            comboBox_object.Location = new Point(479, 282);
            comboBox_object.Margin = new Padding(4, 3, 4, 3);
            comboBox_object.Name = "comboBox_object";
            comboBox_object.Size = new Size(195, 33);
            comboBox_object.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(278, 285);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 13;
            label1.Text = "Cai audit tren object: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(202, 218);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(162, 30);
            label2.TabIndex = 13;
            label2.Text = "Standard Audit";
            // 
            // btn_remove_audit_object
            // 
            btn_remove_audit_object.BackColor = Color.IndianRed;
            btn_remove_audit_object.Font = new Font("Segoe UI", 14.25F);
            btn_remove_audit_object.ForeColor = Color.White;
            btn_remove_audit_object.Location = new Point(904, 366);
            btn_remove_audit_object.Margin = new Padding(4, 3, 4, 3);
            btn_remove_audit_object.Name = "btn_remove_audit_object";
            btn_remove_audit_object.Size = new Size(170, 49);
            btn_remove_audit_object.TabIndex = 15;
            btn_remove_audit_object.Text = "Go Audit Object";
            btn_remove_audit_object.UseVisualStyleBackColor = false;
            btn_remove_audit_object.Click += btn_remove_audit_object_Click;
            // 
            // checkBox_audit_success
            // 
            checkBox_audit_success.AutoSize = true;
            checkBox_audit_success.Font = new Font("Segoe UI", 14.25F);
            checkBox_audit_success.Location = new Point(339, 377);
            checkBox_audit_success.Margin = new Padding(4, 3, 4, 3);
            checkBox_audit_success.Name = "checkBox_audit_success";
            checkBox_audit_success.Size = new Size(323, 29);
            checkBox_audit_success.TabIndex = 16;
            checkBox_audit_success.Text = "Theo Doi Cac Hanh Vi Thanh Cong";
            checkBox_audit_success.UseVisualStyleBackColor = true;
            // 
            // checkBox_audit_fail
            // 
            checkBox_audit_fail.AutoSize = true;
            checkBox_audit_fail.Font = new Font("Segoe UI", 14.25F);
            checkBox_audit_fail.Location = new Point(339, 435);
            checkBox_audit_fail.Margin = new Padding(4, 3, 4, 3);
            checkBox_audit_fail.Name = "checkBox_audit_fail";
            checkBox_audit_fail.Size = new Size(288, 29);
            checkBox_audit_fail.TabIndex = 16;
            checkBox_audit_fail.Text = "Theo Doi Cac Hanh Vi That Bai";
            checkBox_audit_fail.UseVisualStyleBackColor = true;
            // 
            // CaiDatAudit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 821);
            Controls.Add(checkBox_audit_fail);
            Controls.Add(checkBox_audit_success);
            Controls.Add(btn_remove_audit_object);
            Controls.Add(btn_set_audit_object);
            Controls.Add(comboBox_object);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CaiDatAudit";
            Text = "CaiDatAudit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_gan;
        private ComboBox comboBox_object;
        private Label label1;
        private Label label2;
        private Button button1;
        private CheckBox checkBox_cascade;
        private CheckBox checkBox1;
        private Button btn_set_audit_object;
        private Button btn_remove_audit_object;
        private CheckBox checkBox_audit_success;
        private CheckBox checkBox_audit_fail;
    }
}