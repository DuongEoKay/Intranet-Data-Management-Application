using Oracle.ManagedDataAccess.Client;
using ATBM_A_11.Employee_Forms;
using ATBM_A_11.Lecturer_Forms;
using ATBM_A_11.Student_Forms;
using ATBM_A_11.Ministry_Forms;
using ATBM_A_11.UnitHead_Forms;
using ATBM_A_11.DeptHead_Forms;

using ATBM_A_11.Others;

using phan_he_1;


namespace ATBM_A_11
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = username;
            username.Focus();
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                password.Focus();
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                loginButton.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Up)
            {
                username.Focus();
            }
        }


        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(username.Text) || String.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                string connStr = $"Data Source = {OracleConfig.connString};" + $"User Id = {username.Text};password = {password.Text};";
                //$"User Id = {username.Text};password = {password.Text};";

                OracleConnection conn = new(connStr);

                try
                {
                    conn.Open();
                    this.Hide();
                    string type = username.Text[..3];

                    if (type.Substring(0, 2) == "AD")
                    {
                        try
                        {
                            Utilities.InitConnection(username.Text.Trim(), password.Text.Trim());
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                        phan_he_1.MainMenu form = new phan_he_1.MainMenu(username.Text.Trim(), password.Text.Trim());
                        form.ShowDialog();
                    }

                    else if (type.Substring(0, 2) == "NV")
                    {
                        NV_Main form = new(connStr);
                        form.ShowDialog();
                    }

                    else if (type.Substring(0, 2) == "GV" && Char.IsDigit(type[2]))
                    {
                        GV_Main form = new(connStr);
                        form.ShowDialog();
                    }

                    else if (type.Substring(0, 3) == "GVU")
                    {
                        GVU_Main form = new(connStr);
                        form.ShowDialog();
                    }

                    else if (type.Substring(0, 3) == "TDV")
                    {
                        TDV_Main form = new(connStr);
                        form.ShowDialog();
                    }

                    else if (type.Substring(0, 3) == "TKH")
                    {
                        TKH_Main form = new(connStr);
                        form.ShowDialog();
                    }

                    else if (type.Substring(0, 2) == "SV")
                    {
                        SV_Main form = new(connStr);
                        form.ShowDialog();
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ID hoặc mật khẩu sai! " + ex.Message);
                }
                finally { conn.Close(); }
            }
        }
    }
}
