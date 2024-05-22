using Oracle.ManagedDataAccess.Client;
using ATBM_A_11.Others;
using System.Data;

namespace ATBM_A_11.Ministry_Forms
{
    public partial class GVU_QLSV : Form
    {
        readonly OracleConnection conn;
        private static GVU_ThemSinhVien? f;
        readonly String studentSql = $"SELECT * FROM {OracleConfig.schema}.SINHVIEN";

        public GVU_QLSV(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void StudentManager_Load(object sender, EventArgs e)
        {
            OracleDataAdapter adp = new(studentSql, conn);
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

        private void studentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == studentData.RowCount) return;
            DataGridViewRow cRow = studentData.Rows[e.RowIndex];

            studentID.Text = cRow.Cells["MASV"].Value.ToString();
            studentName.Text = cRow.Cells["HOTEN"].Value.ToString();
            bdayBox.Text = cRow.Cells["NGSINH"].Value.ToString();
            genderCbo.Text = cRow.Cells["PHAI"].Value.ToString();
            programCbo.Text = cRow.Cells["MACT"].Value.ToString();
            majorCbo.Text = cRow.Cells["MANGANH"].Value.ToString();
            phoneBox.Text = cRow.Cells["DT"].Value.ToString();
            addressBox.Text = cRow.Cells["DCHI"].Value.ToString();
            creditUpDown.Value = Int32.Parse(cRow.Cells["SOTCTL"].Value.ToString() ?? "1");
            gpaUpDown.Value = decimal.Parse(cRow.Cells["DTBTL"].Value.ToString() ?? "1");
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            f = new GVU_ThemSinhVien(conn);
            f.FormClosedEvent += FormClosedEvent;
            f.Show();
        }

        private void FormClosedEvent(object? sender, EventArgs e)
        {
            Helper.refreshData($"{studentSql} WHERE MASV='{f?.studentID.Text}'", studentData, conn);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(studentName.Text) ||
                String.IsNullOrWhiteSpace(addressBox.Text) ||
                String.IsNullOrWhiteSpace(phoneBox.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                String updateSql = $"UPDATE {OracleConfig.schema}.SINHVIEN SET " +
                    $"HOTEN = '{studentName.Text}', " +
                    $"PHAI = '{genderCbo.Text}', " +
                    $"NGSINH = TO_DATE('{bdayBox.Text}', 'DD/MM/YYYY'), " +
                    $"DCHI = '{addressBox.Text}', " +
                    $"DT = '{phoneBox.Text}', " +
                    $"MACT = '{programCbo.Text}', " +
                    $"MANGANH = '{majorCbo.Text}', " +
                    $"SOTCTL = {creditUpDown.Value}, " +
                    $"DTBTL = {gpaUpDown.Value} " +
                    $"WHERE MASV = '{studentID.Text}'";
                OracleCommand cmd = new(updateSql, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!");
                    Helper.refreshData($"{studentSql} WHERE MASV='{studentID.Text}'", studentData, conn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData($"{studentSql} ORDER BY MASV", studentData, conn);
        }

    }
}
