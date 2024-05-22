using ATBM_A_11.Others;
using ATBM_A_11.General_Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBM_A_11.Student_Forms
{
    public partial class SV_Main : Form
    {
        readonly OracleConnection conn;

        public SV_Main(string connStr)
        {
            InitializeComponent();
            this.conn = new(connStr);
        }

        private void Student_Main_Load(object sender, EventArgs e)
        {
            String sql = "SELECT MASV, HOTEN, MACT FROM ADM.SINHVIEN";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    studentID.Text = reader["MASV"].ToString();
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
            Helper.loadform(new SV_TTCN(conn), this.mainPanel);
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

        private void courseButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new SV_HocPhan(conn), this.mainPanel);
        }

        private void cRegistrationButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new XemDangKy(conn), this.mainPanel);
        }

        private void announceButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new ThongBao(conn), this.mainPanel);
        }
    }
}
