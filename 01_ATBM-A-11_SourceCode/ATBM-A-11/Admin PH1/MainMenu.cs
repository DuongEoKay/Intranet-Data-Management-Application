using ATBM_A_11;
using ATBM_A_11.Admin_PH1;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace phan_he_1
{
    public partial class MainMenu : Form
    {
        Thread t;
        String username = "", password = "", dbname = "";
        public MainMenu(String un, String pw)
        {
            this.username = un;
            this.password = pw;
            this.dbname = un.ToUpper();
            Console.WriteLine(dbname);

            InitializeComponent();

            hello_username.Text = username;
        }

        private Form activeform = null;
        private void openChildForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private Button currentButton;





        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_ds_user_onclick(object sender, EventArgs e)
        {
            openChildForm(new Form_ShowUsers());

        }

        private void btn_quan_ly_role_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLiRole());

        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new KiemTra());

        }

        private void button8_Click(object sender, EventArgs e)
        {

            openChildForm(new PhanQuyen(username, dbname));

        }

        private void btn_sua_user_onclick(object sender, EventArgs e)
        {
            openChildForm(new Form_EditUser());

        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new CaiDatAudit());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new NhatKy());
        }
    }
}
