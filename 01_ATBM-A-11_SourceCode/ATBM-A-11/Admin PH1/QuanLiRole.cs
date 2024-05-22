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
    public partial class QuanLiRole : Form
    {
        string name;
        public QuanLiRole()
        {
            InitializeComponent();
            Fill_comboBox_grant();
            Fill_comboBox_revoke();
        }



        private void btn_them_role_Click(object sender, EventArgs e)
        {
            name = textBox_them_role.Text.Trim().ToString().ToUpper();
            if (Utilities.isRoleValid(name) == 1 || Utilities.isUserValid(name) == 1)
            {
                MessageBox.Show("Ten role da duoc su dung!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = "alter session set  \"_ORACLE_SCRIPT\" = true";
            Utilities.RunSQL(sql);
            name = textBox_them_role.Text.Trim().ToString();
            sql = "CREATE ROLE " + name;

            if (Utilities.RunSQLwithResult(sql) == 1)
            {

                MessageBox.Show("Them Role thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }

        private void btn_xoa_role_Click(object sender, EventArgs e)
        {
            name = textBox_xoa_role.Text.Trim().ToString().ToUpper();
            if (Utilities.isRoleValid(name) == 0)
            {
                MessageBox.Show("Role khong ton tai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = "alter session set  \"_ORACLE_SCRIPT\" = true";
            Utilities.RunSQL(sql);
            name = textBox_xoa_role.Text.Trim().ToString();

            sql = "DROP ROLE " + name;


            if (Utilities.RunSQLwithResult(sql) == 1)
            {

                MessageBox.Show("Xoa Role thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }


        private void Fill_comboBox_grant()
        {
            DataTable all_role = Utilities.GetAllRoles();
            foreach (DataRow row in all_role.Rows)
            {
                comboBox_role.Items.Add(row["ROLE"].ToString());
            }

            DataTable all_user = Utilities.GetAllUsers_wasCreateByUser();
            foreach (DataRow row in all_user.Rows)
            {
                comboBox_user.Items.Add(row["USERNAME"].ToString());
            }
        }

        private void Run_SP_GrantRoleToUser_OR_Role()
        {
            String role = comboBox_role.Text.Trim();
            String user_OR_role = comboBox_user.Text.Trim();

            if (!role.Equals(user_OR_role))
            {
                Utilities.grantRoleToUser_OR_Role(role, user_OR_role);
            }
        }


        private void btn_gan_Click(object sender, EventArgs e)
        {
            if (comboBox_user.Text.Trim().Length == 0 | comboBox_role.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Run_SP_GrantRoleToUser_OR_Role();
        }



        private void Fill_comboBox_revoke()
        {
            DataTable all_role = Utilities.GetAllRoles();
            foreach (DataRow row in all_role.Rows)
            {
                comboBox_role_revoke.Items.Add(row["ROLE"].ToString());
            }

            DataTable all_user = Utilities.GetAllUsers_wasCreateByUser();
            foreach (DataRow row in all_user.Rows)
            {
                comboBox_user_revoke.Items.Add(row["USERNAME"].ToString());
            }
        }

        private void Run_SP_RevokeRoleFromUser_OR_Role()
        {
            String role = comboBox_role_revoke.Text.Trim().ToUpper();
            String user_OR_role = comboBox_user_revoke.Text.Trim().ToUpper();

            if (!role.Equals(user_OR_role))
            {
                String sql = "revoke " + role + " from " + user_OR_role;
                try
                {
                    Utilities.RunSQL(sql);
                    MessageBox.Show("Revoke thanh cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Revoke that bai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void btn_thu_hoi_Click(object sender, EventArgs e)
        {
            if (comboBox_role_revoke.Text.Trim().Length == 0 | comboBox_user_revoke.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Run_SP_RevokeRoleFromUser_OR_Role();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_role_revoke_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
