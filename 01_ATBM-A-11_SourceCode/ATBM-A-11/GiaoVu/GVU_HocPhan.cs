using ATBM_A_11.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ATBM_A_11.Ministry_Forms
{
    public partial class GVU_HocPhan : Form
    {
        readonly OracleConnection conn;
        readonly string orderSql = "ORDER BY HP.MAHP";
        readonly string sql = $"SELECT HP.*, DV.TENDV FROM {OracleConfig.schema}.HOCPHAN HP " +
                $"JOIN {OracleConfig.schema}.DONVI DV ON HP.MADV = DV.MADV";

        public GVU_HocPhan(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void CourseManager_Load(object sender, EventArgs e)
        {
            RefreshButton.PerformClick();
            String unitSql = $"SELECT * FROM {OracleConfig.schema}.DONVI ORDER BY MADV";
            try
            {
                UnitNameCbo.DisplayMember = "TENDV";
                UnitNameCbo.ValueMember = "MADV";
                UnitNameCbo.DataSource = Helper.getData(unitSql, conn).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData($"{sql} {orderSql}", CrsData, conn);
        }

        private void CrsData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == CrsData.RowCount) return;
            DataGridViewRow cRow = CrsData.Rows[e.RowIndex];

            CrsIDBox.Text = cRow.Cells["MAHP"].Value.ToString();
            CrsNameBox.Text = cRow.Cells["TENHP"].Value.ToString();
            CredUpDown.Value = Convert.ToInt32(cRow.Cells["SOTC"].Value.ToString());
            TheoUpDown.Value = Convert.ToInt32(cRow.Cells["STLT"].Value.ToString());
            PracUpDown.Value = Convert.ToInt32(cRow.Cells["STTH"].Value.ToString());
            MaxStuUpDown.Value = Convert.ToInt32(cRow.Cells["SOSVTD"].Value.ToString());
            cbo_madonvi.Text = cRow.Cells["MADV"].Value.ToString();
            UnitNameCbo.Text = cRow.Cells["TENDV"].Value.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(CrsIDBox.Text) ||
                String.IsNullOrWhiteSpace(CrsNameBox.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            String upSql = $"UPDATE {OracleConfig.schema}.HOCPHAN " +
                $"SET TENHP='{CrsNameBox.Text}', SOTC={CredUpDown.Value}, STLT={TheoUpDown.Value}, " +
                    $"STTH={PracUpDown.Value}, SOSVTD={MaxStuUpDown.Value}, MADV='{cbo_madonvi.Text}' " +
                $"WHERE MAHP='{CrsIDBox.Text}'";
            OracleCommand cmd = new(upSql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                Helper.refreshData($"{sql} WHERE MAHP='{CrsIDBox.Text}'", CrsData, conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { if (conn.State != ConnectionState.Closed) conn.Close(); }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(CrsIDBox.Text) ||
                String.IsNullOrWhiteSpace(CrsNameBox.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            String inSql = $"INSERT INTO {OracleConfig.schema}.HOCPHAN VALUES('{CrsIDBox.Text}', " +
                $"'{CrsNameBox.Text}', {CredUpDown.Value}, {TheoUpDown.Value}, {PracUpDown.Value}, " +
                $"{MaxStuUpDown.Value}, '{cbo_madonvi.Text}')";
            OracleCommand cmd = new(inSql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
                Helper.refreshData($"{sql} WHERE MAHP='{CrsIDBox.Text}'", CrsData, conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { if (conn.State != ConnectionState.Closed) conn.Close(); }
        }

        private void UnitIDUpDown_ValueChanged(object sender, EventArgs e)
        {
            UnitNameCbo.SelectedValue = UnitIDUpDown.Value;
        }
    }
}