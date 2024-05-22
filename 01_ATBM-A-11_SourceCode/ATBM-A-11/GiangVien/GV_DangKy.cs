using Oracle.ManagedDataAccess.Client;
using ATBM_A_11.Others;
using System.Data;

namespace ATBM_A_11.Lecturer_Forms
{
    public partial class GV_DangKy : Form
    {
        readonly string classSQL = "SELECT DK.MASV, SV.HOTEN, SV.PHAI, DK.MAHP, HP.TENHP, DK.HK, DK.NAM, DK.MACT, " +
            "DK.DIEMTH, DK.DIEMQT, DK.DIEMCK, DK.DIEMTK " +
            "FROM ADM.v_giang_vien_DANGKY DK JOIN ADM.SINHVIEN SV ON DK.MASV=SV.MASV " +
                "JOIN ADM.HOCPHAN HP ON HP.MAHP=DK.MAHP";
        readonly string orderSQL = "ORDER BY DK.MAHP, DK.MASV, DK.NAM, DK.HK";
        readonly OracleConnection conn;

        public GV_DangKy(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void Class_Load(object sender, EventArgs e)
        {
            String sql = $"{classSQL} {orderSQL}";
            OracleDataAdapter adp = new(sql, conn);
            try
            {
                DataTable dt = new();
                adp.Fill(dt);
                classData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void classData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == classData.RowCount) return;
            DataGridViewRow cRow = classData.Rows[e.RowIndex];

            studentID.Text = cRow.Cells["MASV"].Value.ToString();
            studentName.Text = cRow.Cells["HOTEN"].Value.ToString();
            courseID.Text = cRow.Cells["MAHP"].Value.ToString();
            semester.Text = cRow.Cells["HK"].Value.ToString();
            year.Text = cRow.Cells["NAM"].Value.ToString();
            programID.Text = cRow.Cells["MACT"].Value.ToString();
            eScore.Text = cRow.Cells["DIEMTH"].Value.ToString();
            pScore.Text = cRow.Cells["DIEMQT"].Value.ToString();
            fScore.Text = cRow.Cells["DIEMCK"].Value.ToString();
            aScore.Text = cRow.Cells["DIEMTK"].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if ((float.Parse(eScore.Text) < 0 || float.Parse(eScore.Text) > 10) ||
                (float.Parse(pScore.Text) < 0 || float.Parse(pScore.Text) > 10) ||
                (float.Parse(fScore.Text) < 0 || float.Parse(fScore.Text) > 10) ||
                (float.Parse(aScore.Text) < 0 || float.Parse(aScore.Text) > 10))
            {
                MessageBox.Show("Điểm nhập vào phải nằm trong khoảng từ 0 đến 10!");
            }
            else
            {
                String whereSql = $"WHERE MASV='{studentID.Text}' AND MAHP='{courseID.Text}' AND HK='{semester.Text}' " +
                    $"AND NAM={year.Text} AND MACT='{programID.Text}'";
                String sql = $"UPDATE ADM.v_giang_vien_DANGKY SET DIEMTH={eScore.Text}, DIEMQT={pScore.Text}, " +
                    $"DIEMCK={fScore.Text}, DIEMTK={aScore.Text}" + whereSql;

                //whereSql = $"WHERE DK.MASV='{studentID.Text}' AND DK.MAHP='{courseID.Text}' AND DK.HK='{semester.Text}' " +
                //    $"AND DK.NAM={year.Text} AND DK.MACT='{programID.Text}'";
                //String seSql = $"{classSQL} {whereSql} {orderSQL}";

                OracleCommand cmd = new(sql, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!");
                    //Helper.refreshData(seSql, classData, conn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { if (conn.State == ConnectionState.Open) conn.Close(); }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData($"{classSQL} {orderSQL}", classData, conn);
        }

        private void eScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && eScore.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void pScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && eScore.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void fScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && eScore.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void aScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && eScore.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
    }
}
