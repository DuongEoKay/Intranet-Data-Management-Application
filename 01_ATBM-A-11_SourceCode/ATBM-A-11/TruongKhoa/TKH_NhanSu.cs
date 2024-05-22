using ATBM_A_11.Ministry_Forms.Popup_Forms;
using ATBM_A_11.Others;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ATBM_A_11.DeptHead_Forms
{
    public partial class TKH_NhanSu : Form
    {
        TDV_ThemNhanVien? formAddEmp;
        readonly OracleConnection conn;
        readonly String orderSql = "ORDER BY NS.MANV";
        readonly String sql = "SELECT NS.MANV, NS.HOTEN, NS.PHAI, NS.NGSINH, NS.PHUCAP, NS.DT, " +
                "NS.VAITRO, NS.VAITRO, NS.MADV, NS.MADV, NS.MACS, NS.MACS " +
            $"FROM {OracleConfig.schema}.NHANSU NS ";

        public TKH_NhanSu(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void DeptEmployee_Load(object sender, EventArgs e)
        {
            RefreshButton.PerformClick();
            String roleSql = $"SELECT distinct VAITRO, VAITRO as vt FROM {OracleConfig.schema}.NHANSU ORDER BY VAITRO";
            String unitSql = $"SELECT  distinct MADV, MADV as dv FROM {OracleConfig.schema}.NHANSU ORDER BY MADV";
            String branchSql = $"SELECT  distinct MACS, MACS as cs FROM {OracleConfig.schema}.NHANSU ORDER BY MACS";
            try
            {
                RoleCbo.DisplayMember = "VAITRO";
                RoleCbo.ValueMember = "VAITRO";
                RoleCbo.DataSource = Helper.getData(roleSql, conn).Tables[0];

                UnitCbo.DisplayMember = "MADV";
                UnitCbo.ValueMember = "MADV";
                UnitCbo.DataSource = Helper.getData(unitSql, conn).Tables[0];

                BranchCbo.DisplayMember = "MACS";
                BranchCbo.ValueMember = "MACS";
                BranchCbo.DataSource = Helper.getData(branchSql, conn).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData($"{sql} {orderSql}", EmpData, conn);
        }

        private void EmpData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == EmpData.RowCount) return;
            DataGridViewRow cRow = EmpData.Rows[e.RowIndex];

            EmpIDBox.Text = cRow.Cells["MANV"].Value.ToString();
            EmpNameBox.Text = cRow.Cells["HOTEN"].Value.ToString();
            GenderCbo.Text = cRow.Cells["PHAI"].Value.ToString();
            BirthDateTime.Value = DateTime.Parse(cRow.Cells["NGSINH"].Value.ToString() ?? "01/01/2024");
            AllowanceUpDown.Value = Int32.Parse(cRow.Cells["PHUCAP"].Value.ToString() ?? "0");
            PhoneBox.Text = cRow.Cells["DT"].Value.ToString();
            RoleCbo.Text = cRow.Cells["VAITRO"].Value.ToString();
            UnitCbo.Text = cRow.Cells["MADV"].Value.ToString();
            BranchCbo.Text = cRow.Cells["MACS"].Value.ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn xóa nhân sự này?", "Warning", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return;

            string delSql = $"DELETE FROM {OracleConfig.schema}.NHANSU WHERE MANV='{EmpIDBox.Text}'";
            OracleCommand cmd = new(delSql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa nhân sự thành công!");
                RefreshButton.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string upSql = $"UPDATE {OracleConfig.schema}.NHANSU SET HOTEN='{EmpNameBox.Text}', " +
                $"PHAI='{GenderCbo.Text}', NGSINH=TO_DATE('{BirthDateTime.Text}', 'DD/MM/YYYY'), " +
                $"PHUCAP={AllowanceUpDown.Value}, DT='{PhoneBox.Text}', " +
                $"VAITRO='{RoleCbo.SelectedValue?.ToString()}', MADV='{UnitCbo.SelectedValue?.ToString()}', " +
                $"MACS='{BranchCbo.SelectedValue?.ToString()}' WHERE MANV='{EmpIDBox.Text}'";

            OracleCommand cmd = new(upSql, conn);
            string seSql = $"{sql} WHERE MANV='{EmpIDBox.Text}'";
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                Helper.refreshData(seSql, EmpData, conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }


        private void InsertButton_Click(object sender, EventArgs e)
        {
            formAddEmp = new(conn);
            formAddEmp.FormClosedEvent += FormClosedEvent;
            formAddEmp.Show();
        }

        private void FormClosedEvent(object? sender, EventArgs e)
        {
            Helper.refreshData($"{sql} WHERE NS.MANV='{formAddEmp?.EmpIDBox.Text}'", EmpData, conn);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
