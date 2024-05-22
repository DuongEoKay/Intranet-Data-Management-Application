using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace phan_he_1
{
    public partial class PhanQuyen : Form
    {
        DataTable DT_AllPrivileges = new DataTable(); 
        String username = "", dbname = "";

        DataGridViewTextBoxColumn dgvc_TableName = new DataGridViewTextBoxColumn();
        string[] columnName = new string[] { "Select", "Select (WITH GRANT OPTION)",
                "Insert", "Insert (WITH GRANT OPTION)"
            ,"Update", "Update (WITH GRANT OPTION)"
            ,"Delete", "Delete (WITH GRANT OPTION)","" };


        DataGridViewTextBoxColumn dgvc_TableName1 = new DataGridViewTextBoxColumn();
        string[] columnName1 = new string[] { "Select", "Select (WITH GRANT OPTION)"
            ,"Update", "Update (WITH GRANT OPTION)",
            "" };














        DataTable all_TableName;
        DataTable all_privilegesOnTable;
        DataTable all_privilegesOnView;
        DataTable all_cols;
        DataTable all_cols_of_view;

        string checkUserOrRole;

        public PhanQuyen(String un, String dn)
        {
            this.username = un;
            this.dbname = dn;
            InitializeComponent();
            comboBox_table_grant();
        }

        private void init_Data()
        {
            // set font 
            dataGridView1.Font = new Font("Segoe UI", 12);

            // tạo các cột

            dgvc_TableName.HeaderText = "Table Name";
            dataGridView1.Columns.Add(dgvc_TableName);


            for (int i = 0; i < columnName.Length; i++)
            {
                DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
                dgvCmb.HeaderText = columnName[i];
                dataGridView1.Columns.Add(dgvCmb);
            }

            all_TableName = Utilities.GetAll_TableName(dbname);


            for (int i = 0; i < all_TableName.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(all_TableName.Rows[i].Field<string>(0), false, false,
                false, false,
                false, false,
                false, false);
            }

            dataGridView1.Columns[0].Width = 200;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView1.AllowUserToAddRows = false;

        }



        private void init_Data2()
        {
            dataGridView_insert.Columns.Clear();
            dataGridView_insert.Rows.Clear();
            dataGridView_insert.Font = new Font("Segoe UI", 12);


            dgvc_TableName1.HeaderText = "Column Name";
            dataGridView_insert.Columns.Add(dgvc_TableName1);


            for (int i = 0; i < columnName1.Length; i++)
            {
                DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
                dgvCmb.HeaderText = columnName1[i];
                dataGridView_insert.Columns.Add(dgvCmb);
            }

            all_TableName = Utilities.GetAll_ColumnName(comboBox_table.Text.Trim().ToUpper());


            for (int i = 0; i < all_TableName.Rows.Count; i++)
            {
                dataGridView_insert.Rows.Add(all_TableName.Rows[i].Field<string>(0), false, false,
                false, false);
            }

            dataGridView_insert.Columns[0].Width = 200;

            dataGridView_insert.AllowUserToAddRows = false;

        }





        private void btn_check_Click(object sender, EventArgs e)
        {
            if (dbname.Equals(textBox_user_role.Text.Trim()))
            {
                for (int i = 0; i < all_TableName.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(all_TableName.Rows[i].Field<string>(0), true, true,
                    true, true,
                    true, true,
                    true, true);
                }
                return;
            }

            dataGridView1.Rows.Clear();

            String userOrRole_name = textBox_user_role.Text.Trim().ToUpper();
            String res = Utilities.CheckIfUserOrRoleExist(userOrRole_name);
            checkUserOrRole = res;
            if (res == "NoExist")
            {
                MessageBox.Show("User hoac Role khong ton tai trong he thong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            all_privilegesOnTable = Utilities.GetPrivilegeOnTable(userOrRole_name);

            for (int i = 0; i < all_TableName.Rows.Count; i++)
            {
                bool select = false, select_withGrantOption = false,
                    insert = false, insert_withGrantOption = false,
                    update = false, update_withGrantOption = false,
                    delete = false, delete_withGrantOption = false;


                foreach (DataRow row in all_privilegesOnTable.Rows)
                {
                    String table_name = row["TABLE_NAME"].ToString();
                    String privilege = row["PRIVILEGE"].ToString();
                    String grantable = row["GRANTABLE"].ToString();
                    if (table_name.Equals(all_TableName.Rows[i].Field<string>(0)))
                    {
                        if (privilege == "SELECT")
                        {
                            select = true;
                            if (grantable == "YES")
                                select_withGrantOption = true;
                        }
                        if (privilege == "INSERT")
                        {
                            insert = true;
                            if (grantable == "YES")
                                insert_withGrantOption = true;
                        }
                        if (privilege == "UPDATE")
                        {
                            update = true;
                            if (grantable == "YES")
                                update_withGrantOption = true;
                        }
                        if (privilege == "DELETE")
                        {
                            delete = true;
                            if (grantable == "YES")
                                delete_withGrantOption = true;
                        }
                    }
                }

                dataGridView1.Rows.Add(all_TableName.Rows[i].Field<string>(0), select, select_withGrantOption,
                    insert, insert_withGrantOption,
                    update, update_withGrantOption,
                    delete, delete_withGrantOption);
            }

            dataGridView1.Columns[0].Width = 200;

            dataGridView1.AllowUserToAddRows = false;
        }

        private void btn_phan_quyen_Click(object sender, EventArgs e)
        {
            if (dbname.Equals(textBox_user_role.Text.Trim()))
            {
                MessageBox.Show("Khong the cap nhat vi user nay la Owner cua cac bang", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (textBox_user_role.Text.Trim() == "")
            {
                MessageBox.Show("Hay nhap ten cua user/role", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string userOrRole_name = textBox_user_role.Text.Trim();

            string[] privName = new string[] { "A", "SELECT", "SELECT",
                "INSERT", "INSERT"
            ,"UPDATE", "UPDATE"
            ,"DELETE", "DELETE"};


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                string table_name = (string)dataGridView1.Rows[i].Cells[0].Value;
                for (int j = 1; j < columnName.Length; j++)
                {
                    if (j % 2 == 0 && checkUserOrRole == "Role")
                        continue;

                    string priv = privName[j];

                    bool isChecked = (bool)dataGridView1.Rows[i].Cells[j].Value;

                    string privIsExist;
                    string grant_opt;
                    if (checkUserOrRole == "Role")
                        grant_opt = "NO";
                    else if (j % 2 == 0)
                        grant_opt = "YES";
                    else
                        grant_opt = "NO";

                    if (checkUserOrRole == "User")
                    {
                        privIsExist = Utilities.CheckIfPrivilegeBelongToUser(userOrRole_name, table_name, priv, grant_opt);
                    }
                    else
                    {
                        privIsExist = Utilities.CheckIfPrivilegeBelongToRole(userOrRole_name, table_name, priv, grant_opt);
                    }

                    if (isChecked == false && privIsExist == "Yes")
                    {
                        Utilities.RevokePrivilegeOnTable(table_name, userOrRole_name, priv);
                        continue;
                    }

                    if (isChecked == true && privIsExist == "No")
                    {
                        if (checkUserOrRole == "Role")
                        {
                            Utilities.GrantPrivilegeOnTable(table_name, userOrRole_name, priv, "");
                        }
                        else if (j % 2 == 0)
                        {
                            Utilities.GrantPrivilegeOnTable(table_name, userOrRole_name, priv, "WITH GRANT OPTION");
                        }
                        else
                        {
                            Utilities.GrantPrivilegeOnTable(table_name, userOrRole_name, priv, "");
                        }

                    }
                }
            }

            MessageBox.Show("Cap nhat quyen thanh cong !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox_table_grant()
        {
            DataTable all_tabs = Utilities.GetAll_TableName(dbname);
            foreach (DataRow row in all_tabs.Rows)
            {
                Console.WriteLine(row["table_name"].ToString());
                comboBox_table.Items.Add(row["TABLE_NAME"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable all_Colname = Utilities.GetAll_ColumnName(comboBox_table.Text.Trim().ToUpper());
            init_Data2();
            all_privilegesOnView = Utilities.GetPrivilegeOnView(textBox_user_role.Text.Trim().ToUpper(),comboBox_table.Text.Trim().ToUpper());
            for (int i = 0; i < all_Colname.Rows.Count; i++)
            {
                bool select = false, select_withGrantOption = false,
                    insert = false, insert_withGrantOption = false,
                    update = false, update_withGrantOption = false,
                    delete = false, delete_withGrantOption = false;


                foreach (DataRow row in all_privilegesOnView.Rows)
                {

                    String table_name = row["TABLE_NAME"].ToString();
                    String privilege = row["PRIVILEGE"].ToString();
                    String grantable = row["GRANTABLE"].ToString();
                    if (table_name.Equals(all_Colname.Rows[i].Field<string>(0)))
                    {
                        if (privilege == "SELECT")
                        {
                            select = true;
                            if (grantable == "YES")
                                select_withGrantOption = true;
                        }
                        if (privilege == "INSERT")
                        {
                            insert = true;
                            if (grantable == "YES")
                                insert_withGrantOption = true;
                        }
                        if (privilege == "UPDATE")
                        {
                            update = true;
                            if (grantable == "YES")
                                update_withGrantOption = true;
                        }
                        if (privilege == "DELETE")
                        {
                            delete = true;
                            if (grantable == "YES")
                                delete_withGrantOption = true;
                        }
                    }
                }

                dataGridView_insert.Rows.Add(all_TableName.Rows[i].Field<string>(0), select, select_withGrantOption,
                    insert, insert_withGrantOption,
                    update, update_withGrantOption,
                    delete, delete_withGrantOption);
            }

            dataGridView_insert.Columns[0].Width = 200;

            dataGridView_insert.AllowUserToAddRows = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            List<string> col_name_arr = new List<string>();
            if (dbname.Equals(textBox_user_role.Text.Trim()))
            {
                MessageBox.Show("Khong the cap nhat vi user nay la Owner cua cac bang", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (textBox_user_role.Text.Trim() == "")
            {
                MessageBox.Show("Hay nhap ten cua user/role", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string userOrRole_name = textBox_user_role.Text.Trim();

            string[] privName = new string[] { "A", "SELECT", "SELECT"
            ,"UPDATE", "UPDATE"};

            for (int i = 0; i < dataGridView_insert.Rows.Count; i++)
            {
                string col_name = (string)dataGridView_insert.Rows[i].Cells[0].Value;

                for (int j = 1; j < columnName1.Length; j++)
                {
                    if (j % 2 == 0 && checkUserOrRole == "Role")
                        continue;

                    string priv = privName[j];

                    bool isChecked = (bool)dataGridView_insert.Rows[i].Cells[j].Value;

                    string privIsExist;
                    string grant_opt;
                    if (checkUserOrRole == "Role")
                        grant_opt = "NO";
                    else if (j % 2 == 0)
                        grant_opt = "YES";
                    else
                        grant_opt = "NO";

                    if (checkUserOrRole == "User")
                    {
                        privIsExist = Utilities.CheckIfPrivilegeBelongToUser(userOrRole_name, col_name, priv, grant_opt);
                    }
                    else
                    {
                        privIsExist = Utilities.CheckIfPrivilegeBelongToRole(userOrRole_name, col_name, priv, grant_opt);
                    }

                    if (isChecked == false && privIsExist == "Yes")
                    {
                        Utilities.RevokePrivilegeOnTable(col_name, userOrRole_name, priv);
                        continue;
                    }

                    if (isChecked == true && privIsExist == "No")
                    {
                        col_name_arr.Add(col_name);
                        if (checkUserOrRole == "Role")
                        {
                            
                            Utilities.CreateAndGrantView(comboBox_table.Text.Trim().ToUpper(), userOrRole_name, col_name_arr, priv, "");
                            col_name_arr.Clear();
                        }
                        else if (j % 2 == 0)
                        {
                            Utilities.CreateAndGrantView(comboBox_table.Text.Trim().ToUpper(), userOrRole_name, col_name_arr, priv, "WITH GRANT OPTION");
                            col_name_arr.Clear();
                        }
                        else
                        {
                            Utilities.CreateAndGrantView(comboBox_table.Text.Trim().ToUpper(), userOrRole_name, col_name_arr, priv, "");
                            col_name_arr.Clear();
                        }

                    }
                }
            }

            MessageBox.Show("Cap nhat quyen thanh cong !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);






















        }

        private void PhanQuyen_Load(object sender, EventArgs e)
        {
            init_Data();
        }


    }
}
