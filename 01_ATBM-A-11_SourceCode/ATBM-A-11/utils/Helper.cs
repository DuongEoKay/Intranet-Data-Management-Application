using Oracle.ManagedDataAccess.Client;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace ATBM_A_11.Others
{
    internal class Helper
    {
        public static DataSet getData(string query, OracleConnection conn)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            DataSet dt = new();
            OracleDataAdapter ap = new(query, conn);
            ap.Fill(dt);
            conn.Close();
            return dt;
        }

        public static void loadform(object Form, Panel mainPanel)
        {
            if (mainPanel.Controls.Count > 0)
                mainPanel.Controls.RemoveAt(0);
            Form f = (Form)Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(f);
            mainPanel.Tag = f;
            f.Show();
        }

        public static void refreshData(string query, DataGridView d, OracleConnection conn)
        {
            d.DataSource = getData(query, conn).Tables[0];
        }
    }
}
