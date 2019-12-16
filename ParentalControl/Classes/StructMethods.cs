using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ParentalControl
{
    public class StructMethods
    {
        public static void SaveData(SaveData saveData)
        {
            SqlMethods.updateSqlString("settings", EncryptionMethods.EncryptString(saveData.passCode.ToString(), "ivynk67104"), "passCode");
            SqlMethods.updateSqlString("settings", saveData.sessionLimit.ToString(), "sessionLimit");
            SqlMethods.updateSqlString("settings", saveData.numCoinsRequired.ToString(), "numCoinsRequired");
        }
        //public static void SaveData(string fileName, object structData)
        //{
        //    using (var file = File.OpenWrite(fileName))
        //    {
        //        var writer = new BinaryFormatter();
        //        writer.Serialize(file, structData); 
        //    }
        //}
        //public static object LoadData(string fileName)
        //{
        //    SaveData saveData = new SaveData();
        //    using (var file = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        //    {
        //        var reader = new BinaryFormatter();
        //        saveData = (SaveData)reader.Deserialize(file);
        //    }
        //    return saveData;
        //}
        public static object LoadData()
        {

            SaveData result = new SaveData();
            //settings - settingName - value        - sessionLimit, numCoinsRequired, passCode
            //public static string getSqlString(string selectString, string fromString, string orderByString = "", string limitString = "")

            Int32.TryParse(SqlMethods.getSqlString("SELECT value FROM settings WHERE `settingName`='sessionLimit'"), out result.sessionLimit);
            Int32.TryParse(SqlMethods.getSqlString("SELECT value FROM settings WHERE `settingName`='isSessionDisabled'"), out result.isSessionDisabled);
            Int32.TryParse(SqlMethods.getSqlString("SELECT value FROM settings WHERE `settingName`='numCoinsRequired'"), out result.numCoinsRequired);
            result.passCode = EncryptionMethods.DecryptString(SqlMethods.getSqlString("SELECT value FROM settings WHERE `settingName`='passCode'"), "ivynk67104");
            return result;
        }
    }
}
