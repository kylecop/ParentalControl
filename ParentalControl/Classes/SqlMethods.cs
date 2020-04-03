using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentalControl
{
    class SqlMethods
    {
        static string serverAddress = "127.0.0.1";
        static string userName = "kyle";
        static string userPass = "**removed**";
        static string dbName = "beatspoints";
        //bankaccouns - username - amount
        //settings - settingName - value        - sessionLimit, numCoinsRequired
        public static string getSqlString(string sqlQuery)
        {
            string result = "";
            MySqlConnection con = new MySqlConnection("host=" + serverAddress + ";user=" + userName + ";password=" + userPass + ";database=" + dbName + ";");
            MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

            con.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    result = dr[0].ToString();
                }
            }

            con.Close();
            return result;
        }
        public static string getSqlString(string selectString, string fromString, string orderByString = "", string limitString = "")
        {
            string result = "";

            string sql = " SELECT " + selectString + " FROM " + fromString + " ORDER BY " + orderByString + " DESC LIMIT " + limitString;

            //$sql = "SELECT number, message FROM logs ORDER BY number DESC";
            MySqlConnection con = new MySqlConnection("host=" + serverAddress + ";user=" + userName + ";password=" + userPass + ";database=" + dbName + ";");
            MySqlCommand cmd = new MySqlCommand(sql, con);

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result += reader.GetString(selectString);
            }
            con.Close();
            return result;
        }
        public static void updateSqlString(string tableName, string insertValues, string insertColumns)
        {
            //string sql = "UPDATE `settings` SET `value` = '1234' WHERE `settings`.`settingName` = 'passCode'";
            string sql = "UPDATE `" + tableName + "` SET `value` = '" + insertValues + "' WHERE `settings`.`settingName` = '" + insertColumns + "'";
            MySqlConnection con = new MySqlConnection("host=" + serverAddress + ";user=" + userName + ";password=" + userPass + ";database=" + dbName + ";");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void setSqlString(string tableName, string insertValues, string insertColumns)
        {
            //INSERT INTO `logs` (`number`, `message`) VALUES(NULL, 'test');
            string sql = "INSERT INTO `" + tableName + "` ( `" + insertColumns + "`) VALUES(" + insertValues + ")";
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