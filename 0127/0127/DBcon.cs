using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace _0127
{
    class DBcon
    {
        private static SqlConnection conn = null;
        public static string DBConnString { get; private set; }
        public static bool bDBConnCheck = false;
        private static int errorBoxCount = 0;

        public DBcon() { }

        public static SqlConnection DBConn

        {
            get
            {
                if (!ConnectToDB())
                {
                    return null;
                }
                return conn;
            }
        }
        /// Database 접속 시도
        public static bool ConnectToDB()
        {
            if (conn == null)
            {
                //서버명, 초기 DB명, 인증 방법
                DBConnString = String.Format("Data Source=({0});Initial Catalog={1};Integrated Security={2}; Timeout=3", "local", "dragon", "SSPI");
                conn = new SqlConnection(DBConnString);
            }

            try
            {
                if (!IsDBConnected)
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        bDBConnCheck = true;
                    }
                    else
                    {
                        bDBConnCheck = false;
                    }
                }
            }
            catch (SqlException e)
            {
                errorBoxCount++;
                if (errorBoxCount == 1)
                {
                }
                return false;
            }
            return true;
        }

        /// Database Open 여부 확인

        public static bool IsDBConnected
        {
            get
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    return false;
                }
                return true;
            }
        }

        /// Database 해제

        public static void Close()
        {
            if (IsDBConnected)
                DBConn.Close();
        }
    }
}
