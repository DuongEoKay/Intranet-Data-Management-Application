using Oracle.ManagedDataAccess.Client;
using ATBM_A_11.General_Forms;
using ATBM_A_11.Others;
using ATBM_A_11.Student_Forms;

namespace ATBM_A_11.Ministry_Forms
{
    public partial class GVU_Main : Form
    {
        readonly OracleConnection conn;

        public GVU_Main(string connStr)
        {
            InitializeComponent();
            this.conn = new(connStr);
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            TTCN f = new(conn);
            Helper.loadform(f, this.mainPanel);
        }

        private void Ministry_Main_Load(object sender, EventArgs e)
        {
            String sql = $"SELECT MANV, HOTEN FROM ADM.V_NHAN_VIEN_CO_BAN";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ministryID.Text = reader["MANV"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void studentMButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new GVU_QLSV(conn), this.mainPanel);
        }

        private void unitMButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new GVU_DonVi(conn), this.mainPanel);
        }

        private void courseMButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new GVU_HocPhan(conn), this.mainPanel);
        }

        private void CrsPlannerButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new GVU_KHMO(conn), this.mainPanel);
        }

        private void assignmentButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new GVU_PhanCong(conn), this.mainPanel);
        }

        private void announceButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new ThongBao(conn), this.mainPanel);
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

        private void cRegistrationButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new XemDangKy(conn), this.mainPanel);
        }
    }
}
