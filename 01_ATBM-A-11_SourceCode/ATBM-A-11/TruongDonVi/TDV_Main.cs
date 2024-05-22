using ATBM_A_11.General_Forms;
using ATBM_A_11.Others;
using Oracle.ManagedDataAccess.Client;

namespace ATBM_A_11.UnitHead_Forms
{
    public partial class TDV_Main : Form
    {
        readonly OracleConnection conn;

        public TDV_Main(string connStr)
        {
            InitializeComponent();
            this.conn = new(connStr);
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


        private void UnitHead_Main_Load(object sender, EventArgs e)
        {
            String sql = $"SELECT MANV, HOTEN FROM ADM.V_NHAN_VIEN_CO_BAN";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    unitHeadID.Text = reader["MANV"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }


        private void accountButton_Click_1(object sender, EventArgs e)
        {
            Helper.loadform(new TTCN(conn), this.mainPanel);
        }

        private void announce_Click(object sender, EventArgs e)
        {
            Helper.loadform(new ThongBao(conn), this.mainPanel);
        }

        private void studentButton_Click_1(object sender, EventArgs e)
        {
            Helper.loadform(new SinhVien(conn), this.mainPanel);
        }

        private void courseButton_Click_1(object sender, EventArgs e)
        {
            Helper.loadform(new Course(conn), this.mainPanel);
        }

        private void assignmentButton_Click_1(object sender, EventArgs e)
        {
            Helper.loadform(new TDV_PhanCong(conn), this.mainPanel);
        }
    }
}
