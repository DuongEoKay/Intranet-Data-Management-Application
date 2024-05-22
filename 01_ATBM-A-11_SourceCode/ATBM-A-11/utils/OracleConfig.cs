using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_A_11.Others
{
    public static class OracleConfig
    {
        public const string host = "localhost";
        public const string port = "1521";
        public const string service = "PDBQLNB";
        public const string connString = "localhost:1521/PDBQLNB";
        public const string schema = "ADM";
        public enum UIDBounds { low=150, high=1000000 };
        public const string olsPolicy = "P_THONGBAO";
    }
}
