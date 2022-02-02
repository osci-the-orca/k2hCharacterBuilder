using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace k2hCharacterBuilder
{
    class DataManager<T>
    {

        public static List<T> LoadData()
        {
            List<T> data = new();

            string[] files = Directory.GetFiles(@"C:\Users\oscar\OneDrive\Desktop\Items\", "*.json");

            foreach (string filePath in files)
            {
                string jsonString = File.ReadAllText(filePath);
                data.Add(JsonSerializer.Deserialize<T>(jsonString));
            }
            return data;
        }
    }
}
