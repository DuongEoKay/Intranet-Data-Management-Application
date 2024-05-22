using ATBM_A_11.Others;
using Oracle.ManagedDataAccess.Client;

namespace ATBM_A_11.General_Forms
{
    public partial class ThongBao : Form
    {
        readonly OracleConnection conn;
        readonly String gridSql = $"SELECT * " +
            $"FROM {OracleConfig.schema}.THONGBAO";
        readonly String orderSql = "";

        public ThongBao(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void Announcement_Load(object sender, EventArgs e)
        {
            Helper.refreshData($"{gridSql} {orderSql}", AnnData, conn);
            AnnData.Columns[1].Width = 400;
            AnnData.Columns[2].Width = 300;
        }



    }
}
