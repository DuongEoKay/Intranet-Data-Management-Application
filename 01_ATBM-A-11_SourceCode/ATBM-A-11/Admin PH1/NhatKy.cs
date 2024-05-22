using phan_he_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_A_11.Admin_PH1
{
    public partial class NhatKy : Form
    {

        DataTable dtTableName = new DataTable();
        DataTable dtTableName1 = new DataTable();
        public NhatKy()
        {
            InitializeComponent();
            LoadData_ListUsers();
        }


        private void LoadData_ListUsers()
        {
            string sql = "select username, EXTENDED_TIMESTAMP ,obj_name, action_name, returncode from dba_audit_trail order by EXTENDED_TIMESTAMP desc";
            dtTableName = Utilities.GetDataToTable(sql);
            Console.WriteLine(dtTableName);
            dataGridView1.DataSource = dtTableName;

            dataGridView1.Font = new Font("Time New Roman", 13);
            dataGridView1.Columns[0].HeaderText = "USERNAME";
            dataGridView1.Columns[1].HeaderText = "EXTENDED TIMESTAMP";
            dataGridView1.Columns[2].HeaderText = "OBJECT NAME";
            dataGridView1.Columns[3].HeaderText = "ACTION NAME";
            dataGridView1.Columns[4].HeaderText = "RETURN CODE";

            dataGridView1.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 250;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;












            string sql1 = "SELECT DBUID, LSQLTEXT, NTIMESTAMP# FROM sys.FGA_LOG$ order by NTIMESTAMP# desc";
            dtTableName1 = Utilities.GetDataToTable(sql1);
            Console.WriteLine(dtTableName1);
            dataGridView2.DataSource = dtTableName1;

            dataGridView2.Font = new Font("Time New Roman", 13);
            dataGridView2.Columns[0].HeaderText = "DBUID";
            dataGridView2.Columns[1].HeaderText = "LSQLTEXT";
            dataGridView2.Columns[2].HeaderText = "NTIMESTAMP#";


            dataGridView2.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            dataGridView2.Columns[0].Width = 100;
            dataGridView2.Columns[1].Width = 300;
            dataGridView2.Columns[2].Width = 200;


            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
        }





    }
}
