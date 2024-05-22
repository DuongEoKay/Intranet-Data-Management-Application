using ATBM_A_11.Others;
using Oracle.ManagedDataAccess.Client;

namespace ATBM_A_11.Student_Forms
{
    public partial class SV_TTCN : Form
    {
        readonly OracleConnection conn;

        public SV_TTCN(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void Student_Account_Load(object sender, EventArgs e)
        {
            String sql = $"SELECT * FROM {OracleConfig.schema}.SINHVIEN";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    IDBox.Text = reader["MASV"].ToString();
                    nameBox.Text = reader["HOTEN"].ToString();
                    genderBox.Text = reader["PHAI"].ToString();
                    phoneBox.Text = reader["DT"].ToString();
                    bdayBox.Text = reader["NGSINH"].ToString();
                    addressBox.Text = reader["DCHI"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            String sql = $"UPDATE {OracleConfig.schema}.SINHVIEN " +
                $"SET DT='{phoneBox.Text}', DCHI='{addressBox.Text}'";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
    }
}
