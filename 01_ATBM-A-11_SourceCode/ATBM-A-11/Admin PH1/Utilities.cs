using System;
using System.Data;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Diagnostics;


namespace phan_he_1
{
    public class Utilities
    {
        public static OracleConnection Con;

        private static string host_name = @"localhost:1521/PDBQLNB"; 


        public static void InitConnection(String username, String password)
        {
            String connectionString = @"Data Source=" + host_name + ";User ID=" + username + ";Password=" + password + "";

            Con = new OracleConnection();
            Con.ConnectionString = connectionString;

            try
            {
                Con.Open();

            }
            catch (OracleException ex)
            {
                Con = null;
                throw new Exception(ex.Message);
                MessageBox.Show("Không thể kết nối với DB");
            }
        }

        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();

                Con.Dispose();
                Con = null;

            }
        }

        public static string GetFieldValues(string sql) 
        {
            string ma = "";
            OracleCommand cmd = new OracleCommand(sql, Con);
            OracleDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }

        public static void RunSQL(string sql) 
        {
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = Con;

            cmd.CommandText = sql;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            cmd.Dispose();
            cmd = null;
        }

        public static int RunSQLwithResult(string sql)
        {
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = Con;

            cmd.CommandText = sql;

            try
            {
                cmd.ExecuteNonQuery();
                // Trả về 1 nếu truy vấn được thực hiện thành công
                return 1;
            }
            catch (Exception ex)
            {
                // Trả về 0 nếu xảy ra lỗi trong quá trình thực hiện truy vấn
                return 0;
            }
            finally
            {
                // Dọn dẹp tài nguyên
                cmd.Dispose();
            }
        }


        public static int isUserValid(string username) 
        {
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = Con;

            string sql = "SELECT * FROM all_users WHERE USERNAME = " + "'" + username + "'";
            cmd.CommandText = sql;

            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                cmd.Dispose();
                cmd = null;
                return 1;
            }
            else
            {
                cmd.Dispose();
                cmd = null;
                return 0;
            }
        }

        public static int isRoleValid(string username) 
        {
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = Con;

            string sql = "SELECT * FROM DBA_ROLES WHERE ROLE = " + "'" + username.ToUpper() + "'";
            cmd.CommandText = sql;

            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                cmd.Dispose();
                cmd = null;
                return 1;
            }
            else
            {
                cmd.Dispose();
                cmd = null;
                return 0;
            }
        }
        public static DataTable GetDataToTable(string sql) 
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = sql;
            command.Connection = Con;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

        

            return dataTable;
        }

        public static DataTable GetAll_TableName(String dbname) 
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT table_name FROM dba_tables where owner = '{dbname}'";
            command.Connection = Con;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); 
            adapter.Fill(dataTable);

            return dataTable;
        }




        public static DataTable GetAll_ColumnName(String table) 
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT column_name  FROM all_tab_cols WHERE table_name = '{table}'";
            command.Connection = Con;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }


        public static DataTable GetPrivilegeOnTable(String username) 
        {
            username = username.ToUpper();
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = '{username}' AND TYPE = 'TABLE' ORDER BY TABLE_NAME";
            command.Connection = Con;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); 
            adapter.Fill(dataTable);

            return dataTable;
        }




        public static DataTable GetPrivilegeOnView(String username, String table) 
        {
            username = username.ToUpper();
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT * FROM DBA_TAB_PRIVS, ALL_TAB_COLUMNS where GRANTEE='{username}' and ALL_TAB_COLUMNS.table_name='V_{table}_{username}' and ALL_TAB_COLUMNS.table_name=DBA_TAB_PRIVS.table_name";
            command.Connection = Con;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }


        public static DataTable GetColsOnView(String username, String table) 
        {
            username = username.ToUpper();
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT COLUMN_NAME FROM ALL_TAB_COLUMNS WHERE TABLE_NAME = 'V_{table}_{username}'";
            command.Connection = Con;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); 
            adapter.Fill(dataTable);

            return dataTable;
        }



        public static DataTable GetAllTabViewProcFunc()
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = "SELECT distinct table_name AS name FROM user_tables UNION ALL SELECT distinct name FROM user_source WHERE type IN ('PROCEDURE', 'FUNCTION') UNION ALL SELECT distinct view_name FROM user_views";
            command.Connection = Con;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); 
            adapter.Fill(dataTable);

            return dataTable;
        }


        public static DataTable GetAllRoles()
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = "SELECT ROLE, ROLE_ID " +
                "FROM USER_ROLE_PRIVS US JOIN DBA_ROLES DR ON DR.ROLE = US.GRANTED_ROLE " +
                "WHERE DR.ROLE <> 'CONNECT' AND DR.ROLE <> 'RESOURCE' AND DR.ROLE <> 'DBA'";
            command.Connection = Con;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); 
            adapter.Fill(dataTable);

            return dataTable;
        }

        public static DataTable GetAllUsers_wasCreateByUser()
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT * FROM dba_users WHERE ACCOUNT_STATUS = 'OPEN' ORDER BY CREATED DESC";
            command.Connection = Con;

            OracleDataAdapter adapter;
            DataTable dataTable;
            try
            {
                adapter = new OracleDataAdapter(command);
                dataTable = new DataTable(); 
                adapter.Fill(dataTable);
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }

            return dataTable;
        }

        public static void RevokeRoleFromUser_OR_Role(String role, String user_OR_role) 
        {
            role = role.ToUpper();
            user_OR_role = user_OR_role.ToUpper();


            OracleCommand command = new OracleCommand();
            command.CommandText = $"REVOKE {role} FROM {user_OR_role}";
            command.Connection = Con;
            command.ExecuteNonQuery();
            MessageBox.Show("Thu hoi quyen thanh cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static String CheckIfUserOrRoleExist(String userOrRole_name)
        {
            userOrRole_name = userOrRole_name.ToUpper();
            string result = "";



            OracleCommand command1 = new OracleCommand();
            command1.CommandText = $"SELECT USERNAME FROM DBA_USERS";
            command1.Connection = Con;

            OracleDataAdapter adapter1 = new OracleDataAdapter(command1);
            DataTable dataTable1 = new DataTable(); 
            adapter1.Fill(dataTable1);

            for (int i = 0; i < dataTable1.Rows.Count; i++)
            {
                if (dataTable1.Rows[i].Field<string>(0) == userOrRole_name)
                {
                    result = "User";
                    return result;
                }

            }

            OracleCommand command2 = new OracleCommand();
            command2.CommandText = $"SELECT ROLE FROM DBA_ROLES";
            command2.Connection = Con;

            OracleDataAdapter adapter2 = new OracleDataAdapter(command2);
            DataTable dataTable2 = new DataTable(); 
            adapter2.Fill(dataTable2);

            for (int i = 0; i < dataTable2.Rows.Count; i++)
            {
                if (dataTable2.Rows[i].Field<string>(0) == userOrRole_name)
                {
                    result = "Role";
                    return result;
                }

            }

            result = "NoExist";
            return result;
        }

        public static string CheckIfPrivilegeBelongToUser(String user_name, String table_name, String priv, String grant_opt)
        {
            user_name = user_name.ToUpper();
            table_name = table_name.ToUpper();
            priv = priv.ToUpper();
            grant_opt = grant_opt.ToUpper();
            string result = "";

            OracleCommand command1 = new OracleCommand();
            command1.CommandText = $"SELECT GRANTEE FROM DBA_TAB_PRIVS WHERE GRANTEE = '{user_name}' AND TABLE_NAME = '{table_name}' AND PRIVILEGE = '{priv}' AND GRANTABLE = '{grant_opt}'";
            command1.Connection = Con;

            OracleDataAdapter adapter1 = new OracleDataAdapter(command1);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);

            for (int i = 0; i < dataTable1.Rows.Count; i++)
            {
                if (dataTable1.Rows[i].Field<string>(0) == user_name)
                {
                    result = "Yes";
                    return result;
                }
            }
            result = "No";
            return result;
        }

        public static string CheckIfPrivilegeBelongToRole(String role_name, String roleTable_name, String priv, String grant_opt)
        {
            role_name = role_name.ToUpper();
            roleTable_name = roleTable_name.ToUpper();
            priv = priv.ToUpper();
            grant_opt = grant_opt.ToUpper();
            string result = "";


            OracleCommand command1 = new OracleCommand();
            command1.CommandText = $"SELECT ROLE FROM ROLE_TAB_PRIVS WHERE ROLE = '{role_name}' AND TABLE_NAME = '{roleTable_name}' AND PRIVILEGE = '{priv}' AND GRANTABLE = '{grant_opt}'";
            command1.Connection = Con;

            OracleDataAdapter adapter1 = new OracleDataAdapter(command1);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);

            for (int i = 0; i < dataTable1.Rows.Count; i++)
            {
                if (dataTable1.Rows[i].Field<string>(0) == role_name)
                {
                    result = "Yes";
                    return result;
                }
            }
            result = "No";

            return result;
        }
















        public static void RevokePrivilegeOnTable(String table_name, String userOrRole_name, String priv)
        {
            table_name = table_name.ToUpper();
            userOrRole_name = userOrRole_name.ToUpper();
            priv = priv.ToUpper();

            OracleCommand command = new OracleCommand();
            command.CommandText = $"REVOKE {priv} ON {table_name} FROM {userOrRole_name}";
            Console.WriteLine(command.CommandText);
            command.Connection = Con;
            command.ExecuteNonQuery();


        }

        public static void GrantPrivilegeOnTable(String table_name, String userOrRole_name, String priv, string grant_opt)
        {
            table_name = table_name.ToUpper();
            userOrRole_name = userOrRole_name.ToUpper();
            priv = priv.ToUpper();
            grant_opt = grant_opt.ToUpper();

            OracleCommand command = new OracleCommand();
            command.CommandText = $"GRANT {priv} ON {table_name} TO {userOrRole_name}  {grant_opt}";
            Console.WriteLine("GRANT "+priv+" ON "+table_name+" TO "+userOrRole_name+ " "+grant_opt);
            command.Connection = Con;
            command.ExecuteNonQuery();

        }




        public static void CreateAndGrantView(String table_name, string usr, List<String> cols, String priv, string grant_opt)
        {
            string str_cols="";
            for(int i=0;i<cols.Count; i++)
            {
                str_cols += cols[i];
                if(i!=cols.Count-1)
                {
                    str_cols+=", ";
                }
            }
            OracleCommand command = new OracleCommand();
            command.CommandText = $"CREATE OR REPLACE VIEW V_{table_name}_{usr}  AS SELECT {str_cols} FROM {table_name} ";
            command.Connection = Con;
            Console.WriteLine(command.CommandText);
            command.ExecuteNonQuery();


            command.CommandText = $"GRANT {priv} ON V_{table_name}_{usr} TO {usr}  {grant_opt} ";
            command.Connection = Con;
            Console.WriteLine(command.CommandText);
            command.ExecuteNonQuery();



        }

        public static void grantRoleToUser_OR_Role(String role, String user_OR_role)
        {
            role = role.ToUpper();
            user_OR_role = user_OR_role.ToUpper();


            OracleCommand command = new OracleCommand();
            command.CommandText = $"GRANT {role} TO {user_OR_role}";
            command.Connection = Con;
            command.ExecuteNonQuery();

            MessageBox.Show("Cap quyen thanh cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
