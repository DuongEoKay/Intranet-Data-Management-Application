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
    public partial class KiemTra : Form
    {
        DataTable dtTableName = new DataTable();
        String name;
        public KiemTra()
        {
            InitializeComponent();
        }

        private void LoadData_CheckPrivilegeOnTable()
        {
            name = textBox_user_role.Text.Trim().ToString().ToUpper();
            string sql = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE =" + "'" + name + "'" + " AND TYPE = 'TABLE' ORDER BY TABLE_NAME";
            dtTableName = Utilities.GetDataToTable(sql);
            dataGridView_quyen.DataSource = dtTableName;

            dataGridView_quyen.Font = new Font("Time New Roman", 13);
            dataGridView_quyen.Columns[0].HeaderText = "GRANTEE";
            dataGridView_quyen.Columns[1].HeaderText = "OWNER";
            dataGridView_quyen.Columns[2].HeaderText = "TABLE_NAME";
            dataGridView_quyen.Columns[3].HeaderText = "GRATOR STATUS";
            dataGridView_quyen.Columns[4].HeaderText = "GRANTALE";
            dataGridView_quyen.Columns[5].HeaderText = "HIERARCHY";
            dataGridView_quyen.Columns[6].HeaderText = "COMMON";
            dataGridView_quyen.Columns[7].HeaderText = "TYPE";
            dataGridView_quyen.Columns[8].HeaderText = "INHERITED";

            dataGridView_quyen.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            dataGridView_quyen.Columns[0].Width = 150;
            dataGridView_quyen.Columns[1].Width = 150;
            dataGridView_quyen.Columns[2].Width = 250;
            dataGridView_quyen.Columns[3].Width = 150;
            dataGridView_quyen.Columns[4].Width = 150;
            dataGridView_quyen.Columns[5].Width = 150;
            dataGridView_quyen.Columns[6].Width = 150;
            dataGridView_quyen.Columns[7].Width = 150;
            dataGridView_quyen.Columns[8].Width = 150;


            dataGridView_quyen.AllowUserToAddRows = false;
            dataGridView_quyen.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadData_CheckPrivilegeOnView()
        {
            name = textBox_user_role.Text.Trim().ToString().ToUpper();
            string sql = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE =" + "'" + name + "'" + " AND TYPE = 'VIEW' ORDER BY TABLE_NAME";
            dtTableName = Utilities.GetDataToTable(sql);
            dataGridView_quyen.DataSource = dtTableName;

            dataGridView_quyen.Font = new Font("Time New Roman", 13);
            dataGridView_quyen.Columns[0].HeaderText = "GRANTEE";
            dataGridView_quyen.Columns[1].HeaderText = "OWNER";
            dataGridView_quyen.Columns[2].HeaderText = "TABLE_NAME";
            dataGridView_quyen.Columns[3].HeaderText = "GRATOR STATUS";
            dataGridView_quyen.Columns[4].HeaderText = "GRANTALE";
            dataGridView_quyen.Columns[5].HeaderText = "HIERARCHY";
            dataGridView_quyen.Columns[6].HeaderText = "COMMON";
            dataGridView_quyen.Columns[7].HeaderText = "TYPE";
            dataGridView_quyen.Columns[8].HeaderText = "INHERITED";


            dataGridView_quyen.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            dataGridView_quyen.Columns[0].Width = 150;
            dataGridView_quyen.Columns[1].Width = 150;
            dataGridView_quyen.Columns[2].Width = 250;
            dataGridView_quyen.Columns[3].Width = 150;
            dataGridView_quyen.Columns[4].Width = 150;
            dataGridView_quyen.Columns[5].Width = 150;
            dataGridView_quyen.Columns[6].Width = 150;
            dataGridView_quyen.Columns[7].Width = 150;
            dataGridView_quyen.Columns[8].Width = 150;


            dataGridView_quyen.AllowUserToAddRows = false;
            dataGridView_quyen.EditMode = DataGridViewEditMode.EditProgrammatically;
        }



        private void btn_kiem_tra_muc_bang_Click(object sender, EventArgs e)
        {
            LoadData_CheckPrivilegeOnTable();
        }

        private void btn_kiem_tra_muc_cot_Click(object sender, EventArgs e)
        {
            LoadData_CheckPrivilegeOnView();
        }
    }
}
