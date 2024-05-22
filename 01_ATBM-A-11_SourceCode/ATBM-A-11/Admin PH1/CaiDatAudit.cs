using phan_he_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ATBM_A_11.Admin_PH1
{
    public partial class CaiDatAudit : Form
    {

        string object_name;
        string user_name;


        public CaiDatAudit()
        {
            InitializeComponent();
            Fill_comboBox();
        }

        private void Fill_comboBox()
        {
            DataTable all_object = Utilities.GetAllTabViewProcFunc();
            foreach (DataRow row in all_object.Rows)
            {
                comboBox_object.Items.Add(row["NAME"].ToString());
            }


        }



        private void btn_set_audit_object_Click(object sender, EventArgs e)
        {
            string object_name = comboBox_object.Text.Trim().ToUpper();

            string sql = "AUDIT ALL ON ADM." + object_name + " BY ACCESS";
            

            if(checkBox_audit_success.Checked == true && checkBox_audit_fail.Checked==false)
            {
                sql += " WHENEVER SUCCESSFUL";
            }
            if (checkBox_audit_fail.Checked == true && checkBox_audit_success.Checked == false)
            {
                sql += " WHENEVER NOT SUCCESSFUL";
            }
  

            if (Utilities.RunSQLwithResult(sql) == 1)
            {
                MessageBox.Show("Cai audit tren object thanh cong!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cai audit tren object that bai!", "Thông báo");
            }
            return;
        }

        private void btn_remove_audit_object_Click(object sender, EventArgs e)
        {
            string object_name = comboBox_object.Text.Trim().ToUpper();

            string sql = "NOAUDIT ALL ON ADM." + object_name ;


            if (Utilities.RunSQLwithResult(sql) == 1)
            {
                MessageBox.Show("Go cai dat audit tren object thanh cong!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Go cai dat audit tren object that bai!", "Thông báo");
            }
            return;
        }
    }
}
