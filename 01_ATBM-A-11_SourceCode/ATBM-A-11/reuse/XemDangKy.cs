using ATBM_A_11.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using ATBM_A_11.General_Forms.Popup_Forms;

namespace ATBM_A_11.General_Forms
{
    public partial class XemDangKy : Form
    {
        ThemDangKy? formAddCrsReg;
        readonly string orderSql = "ORDER BY DK.MACT, DK.NAM, DK.HK, DK.MAHP, DK.MAGV, DK.MASV";
        readonly string sql = $"SELECT DK.MACT, DK.NAM, DK.HK, DK.MAHP, HP.TENHP, DK.MAGV, DK.MASV, " +
                $"DK.DIEMTH, DK.DIEMQT, DK.DIEMCK, DK.DIEMTK " +
            $"FROM ADM.DANGKY DK JOIN ADM.HOCPHAN HP ON DK.MAHP = HP.MAHP";
        readonly OracleConnection conn;

        public XemDangKy(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void CrsRegView_Load(object sender, EventArgs e)
        {
            RefreshButton.PerformClick();
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData($"{sql} {orderSql}", CrsRegData, conn);
        }

        private void CrsRegData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == CrsRegData.RowCount) return;
            DataGridViewRow cRow = CrsRegData.Rows[e.RowIndex];

            stuID.Text = cRow.Cells["MASV"].Value.ToString();
            lectID.Text = cRow.Cells["MAGV"].Value.ToString();
            courseID.Text = cRow.Cells["MAHP"].Value.ToString();
            CrsNameBox.Text = cRow.Cells["TENHP"].Value.ToString();
            semBox.Text = cRow.Cells["HK"].Value.ToString();
            yearBox.Text = cRow.Cells["NAM"].Value.ToString();
            progID.Text = cRow.Cells["MACT"].Value.ToString();
            eScore.Text = cRow.Cells["DIEMTH"].Value.ToString();
            pScore.Text = cRow.Cells["DIEMQT"].Value.ToString();
            fScore.Text = cRow.Cells["DIEMCK"].Value.ToString();
            aScore.Text = cRow.Cells["DIEMTK"].Value.ToString();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn xóa thông tin đăng ký này?", "Warning", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return;

            string delSql = $"DELETE FROM {OracleConfig.schema}.DANGKY WHERE MAGV='{lectID.Text}' " +
                $"AND MAHP='{courseID.Text}' AND MACT='{progID.Text}'";

            OracleCommand cmd = new(delSql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa đăng ký thành công!");
                RefreshButton.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            formAddCrsReg = new(conn);
            formAddCrsReg.FormClosedEvent += FormClosedEvent;
            formAddCrsReg.Show();
        }

        private void FormClosedEvent(object? sender, EventArgs e)
        {
            Helper.refreshData($"{sql} WHERE DK.MASV='{formAddCrsReg?.StuIDBox.Text}' " +
                $"AND DK.MAGV='{formAddCrsReg?.LectIDCbo.SelectedValue?.ToString()}' " +
                $"AND DK.HP='{formAddCrsReg?.CrsIDBox.Text}' AND DK.HK='{formAddCrsReg?.SemBox.Text}' " +
                $"AND DK.NAM={formAddCrsReg?.YearBox.Text} AND DK.MACT='{formAddCrsReg?.ProgIDBox.Text}'",
                CrsRegData, conn);
        }
    }
}
