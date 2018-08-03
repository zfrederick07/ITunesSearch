using ITunesSearch.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ITunesSearch.Services
{
    public static class FileServices
    {
        public static void SaveToFile(List<Click> clicks)
        {
            var clicksJson = JsonConvert.SerializeObject(clicks);

            using (var sWriter = new StreamWriter(GetURI(), false))
            {
                sWriter.WriteLine(clicksJson);
            }
        }

        public static List<Click> ReadFromFile()
        {
            var uri = GetURI();

            // make sure the file exist before we try to open it
            if (!File.Exists(uri))
            {
                return new List<Click>();
            }

            using (StreamReader reader = File.OpenText(uri))
            {
                return JsonConvert.DeserializeObject<List<Click>>(reader.ReadToEnd());
            }
        }

        public static string GetURI()
        {
            return "Clicks.txt";
        }
    }
}
