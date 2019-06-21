using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MultiUserParentalControl
{
    public class StructMethods
    {
        public static void SaveData(string fileName, object structData)
        {
            using (var file = File.OpenWrite(fileName))
            {
                var writer = new BinaryFormatter();
                writer.Serialize(file, structData); 
            }
        }
        public static object LoadData(string fileName)
        {
            SaveData saveData = new SaveData();
            using (var file = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                var reader = new BinaryFormatter();
                saveData = (SaveData)reader.Deserialize(file);
            }
            return saveData;
        }
    }
}
