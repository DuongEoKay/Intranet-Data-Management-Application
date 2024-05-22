using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace phan_he_1
{
    public partial class Form_ShowUsers : Form
    {
        DataTable dtTableName = new DataTable();

        public Form_ShowUsers()
        {
            InitializeComponent();
        }


        private void LoadData_ListUsers()
        {
            string sql = "SELECT USERNAME, USER_ID, ACCOUNT_STATUS, CREATED, EXPIRY_DATE  FROM dba_users WHERE ACCOUNT_STATUS = 'OPEN' ORDER BY CREATED DESC";
            dtTableName = Utilities.GetDataToTable(sql);
            Console.WriteLine(dtTableName);
            dataGridView1.DataSource = dtTableName;

            dataGridView1.Font = new Font("Time New Roman", 13);
            dataGridView1.Columns[0].HeaderText = "USERNAME";
            dataGridView1.Columns[1].HeaderText = "USER_ID";
            dataGridView1.Columns[2].HeaderText = "ACOUNT STATUS";
            dataGridView1.Columns[3].HeaderText = "CREATED";
            dataGridView1.Columns[4].HeaderText = "EXPIRY DATE";

            dataGridView1.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 250;
            dataGridView1.Columns[4].Width = 250;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Form_ShowUsers_Load(object sender, EventArgs e)
        {

            LoadData_ListUsers();
        }

        private void label_list_name_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
