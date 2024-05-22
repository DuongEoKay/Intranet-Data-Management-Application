using ATBM_A_11.Others;
using Oracle.ManagedDataAccess.Client;

namespace ATBM_A_11.Ministry_Forms
{
    public partial class GVU_ThemSinhVien : Form
    {
        public event EventHandler? FormClosedEvent;
        readonly OracleConnection conn;

        public GVU_ThemSinhVien(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(studentName.Text) ||
                String.IsNullOrWhiteSpace(addressBox.Text) ||
                String.IsNullOrWhiteSpace(phoneBox.Text) ||
                String.IsNullOrWhiteSpace(studentID.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                String inSql = $"INSERT INTO {OracleConfig.schema}.SINHVIEN VALUES ('{studentID.Text}', '{studentName.Text}', " +
                    $"'{genderCbo.Text}', TO_DATE('{bdayBox.Text}', 'DD/MM/YYYY'), '{addressBox.Text}', '{phoneBox.Text}', " +
                    $"'{programCbo.Text}', '{majorCbo.Text}', 0, 0, '{facilityCbo.Text}')";

                OracleCommand cmd = new(inSql, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm sinh viên thành công!");
                    FormClosedEvent?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là thoát khỏi quy trình thêm sinh viên?", "Warning", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
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
    }
}
