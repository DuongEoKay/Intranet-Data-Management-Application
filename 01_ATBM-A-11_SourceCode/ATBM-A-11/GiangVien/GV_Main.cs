﻿using Oracle.ManagedDataAccess.Client;
using ATBM_A_11.General_Forms;
using ATBM_A_11.Others;

namespace ATBM_A_11.Lecturer_Forms
{
    public partial class GV_Main : Form
    {
        readonly OracleConnection conn;
        public GV_Main(string connStr)
        {
            InitializeComponent();
            this.conn = new(connStr);
        }

        private void Lecturer_Main_Load(object sender, EventArgs e)
        {
            String sql = $"SELECT MANV, HOTEN FROM ADM.V_NHAN_VIEN_CO_BAN";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lecturerID.Text = reader["MANV"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            TTCN f = new(conn);
            Helper.loadform(f, this.mainPanel);
        }

        private void studentListButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new SinhVien(conn), this.mainPanel);
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Course(conn), this.mainPanel);
        }

        private void assignmentButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new GV_PhanCong(conn), this.mainPanel);
        }

        private void classButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new GV_DangKy(conn), this.mainPanel);
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
    }
}
