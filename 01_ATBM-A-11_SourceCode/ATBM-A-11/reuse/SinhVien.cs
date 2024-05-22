using Oracle.ManagedDataAccess.Client;
using ATBM_A_11.Others;
using System.Data;

namespace ATBM_A_11.General_Forms
{
    public partial class SinhVien : Form
    {
        readonly OracleConnection conn;

        public SinhVien(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void Student_Load(object sender, EventArgs e)
        {
            OracleDataAdapter adp = new("SELECT * FROM ADM.SINHVIEN SV ORDER BY SV.MASV", conn);
            try
            {
                DataTable dt = new();
                adp.Fill(dt);
                studentData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
