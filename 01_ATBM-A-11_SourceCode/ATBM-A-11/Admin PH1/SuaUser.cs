using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace phan_he_1
{
    public partial class Form_EditUser : Form
    {
        string name;
        string pass;
        public Form_EditUser()
        {
            InitializeComponent();
        }



        private void btn_enter_Click(object sender, EventArgs e)
        {

            string sql = "alter session set  \"_ORACLE_SCRIPT\" = true";
            Utilities.RunSQL(sql);
            name = textBox_user.Text.Trim().ToString();
            pass = textBox_new_pass.Text.Trim().ToString();

            sql = "ALTER USER " + name + " IDENTIFIED BY " + pass;



            if (Utilities.RunSQLwithResult(sql) == 1)
            {
                MessageBox.Show("Sua User thanh cong!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Ten User khong hop le!", "Thông báo");
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox_user.Text.Trim().ToString().ToUpper();
            if (Utilities.isUserValid(name) == 0)
            {
                MessageBox.Show("User khong ton tai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = "alter session set  \"_ORACLE_SCRIPT\" = true";
            Utilities.RunSQL(sql);
            name = textBox_user.Text.Trim().ToString();

            if (checkBox_cascade.Checked == true)
                sql = "DROP USER " + name + " CASCADE";
            else
                sql = "DROP USER " + name;

            if (Utilities.RunSQLwithResult(sql) == 1)
            {
                MessageBox.Show("Xoa User thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }




        ////////////////////////////////////////////////////////////////////////CREATE USER



            

        private void btn_tao_user_Click(object sender, EventArgs e)
        {
            if (textBox_user.Text.Trim().Length == 0 ||
                     textBox_new_pass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            name = textBox_user.Text.Trim().ToString().ToUpper();
            if (Utilities.isUserValid(name) == 1)
            {
                MessageBox.Show("Ten user da duoc su dung!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = "alter session set  \"_ORACLE_SCRIPT\" = true";
            Utilities.RunSQL(sql);
            name = textBox_user.Text.Trim().ToString();
            pass = textBox_new_pass.Text.Trim().ToString();



            sql = "create user " + name + " identified by " + pass;
            Utilities.RunSQL(sql);

            MessageBox.Show("Them User thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox_user.Text = "";
            textBox_new_pass.Text = "";
        }
    }
}
