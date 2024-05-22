using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ATBM_A_11.General_Forms
{
    public partial class Course : Form
    {
        readonly OracleConnection conn;
        public Course(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void Course_Load(object sender, EventArgs e)
        {
            OracleDataAdapter adpCourse = new("SELECT * FROM ADM.HOCPHAN", conn);
            OracleDataAdapter adpUnit = new("SELECT * FROM ADM.DONVI", conn);
            OracleDataAdapter adpPlan = new("SELECT * FROM ADM.KHMO", conn);

            try
            {
                DataTable dtCourse = new();
                DataTable dtUnit = new();
                DataTable dtPlan = new();
                adpCourse.Fill(dtCourse);
                adpUnit.Fill(dtUnit);
                adpPlan.Fill(dtPlan);
                courseData.DataSource = dtCourse;
                unitData.DataSource = dtUnit;
                planData.DataSource = dtPlan;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
