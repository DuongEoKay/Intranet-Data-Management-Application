using ATBM_A_11.General_Forms;
using ATBM_A_11.Others;
using Oracle.ManagedDataAccess.Client;

namespace ATBM_A_11.DeptHead_Forms
{
    public partial class TKH_Main : Form
    {
        readonly OracleConnection conn;
        public TKH_Main(string connStr)
        {
            InitializeComponent();
            this.conn = new(connStr);
        }

        private void DeptHead_Main_Load(object sender, EventArgs e)
        {
            String sql = $"SELECT MANV, HOTEN FROM ADM.v_nhan_vien_co_ban";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    deptHeadID.Text = reader["MANV"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new TTCN(conn), this.mainPanel);
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new SinhVien(conn), this.mainPanel);
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Course(conn), this.mainPanel);
        }

        private void assignmentButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new TKH_PhanCong(conn), this.mainPanel);
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn đăng xuất?", "Warning", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Hide();
                new Login().ShowDialog();
                this.Close();
            }
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new TKH_NhanSu(conn), this.mainPanel);
        }

        private void announceButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new ThongBao(conn), this.mainPanel);
        }
    }
}
