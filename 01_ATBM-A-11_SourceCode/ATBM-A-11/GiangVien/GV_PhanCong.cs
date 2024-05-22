using Oracle.ManagedDataAccess.Client;
using ATBM_A_11.Others;
using System.Data;

namespace ATBM_A_11.Lecturer_Forms
{
    public partial class GV_PhanCong : Form
    {
        readonly OracleConnection conn;

        public GV_PhanCong(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void Assignment_Load(object sender, EventArgs e)
        {
            String sql = $"SELECT MAHP,HK, NAM, MACT " +
                $"FROM adm.v_giang_vien_phan_cong";
            OracleDataAdapter adp = new(sql, conn);
            try
            {
                DataTable dt = new();
                adp.Fill(dt);
                assignmentData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void assignmentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
