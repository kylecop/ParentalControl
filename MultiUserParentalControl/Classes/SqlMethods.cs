using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl
{
    class SqlMethods
    {
        static string serverAddress = "192.168.20.250";
        static string userName = "kyle";
        static string userPass = "***REMOVED***";
        static string dbName = "beatspoints";
        public static string getSqlString(string selectString, string fromString, string orderByString, string limitString)
        {
            string result = "";

            string sql = " SELECT "+selectString+" FROM "+fromString+" ORDER BY "+orderByString+" DESC LIMIT "+limitString;
            
//$sql = "SELECT number, message FROM logs ORDER BY number DESC";
            MySqlConnection con = new MySqlConnection("host=" + serverAddress + ";user=" + userName + ";password=" + userPass + ";database=" + dbName + ";");
            MySqlCommand cmd = new MySqlCommand(sql, con);

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result += reader.GetString("message");
            }
            con.Close();
            return result;
        }
        public static void setSqlString(string insertInto, string insertValues, string insertColumns)
        {
            string sql = " INSERT INTO " + insertInto + " ( " + insertColumns + " ) " + " VALUES( " + insertValues + " ) ";
            MySqlConnection con = new MySqlConnection("host=" + serverAddress + ";user=" + userName + ";password=" + userPass + ";database=" + dbName + ";");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void writeToPointsLog(string message)
        {
            SqlMethods.setSqlString("logs", "'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + Environment.UserName + " " + message + "'", "message");
        }
    }
}
