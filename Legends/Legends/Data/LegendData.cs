using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Legends.Data
{
    public static class LegendData
    {
        public static Dictionary<string, Legend> GetJsonData()
        {
            string jsonFileName = "legends.json";
            ResponseModel legendList = new ResponseModel();
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;

            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");

            using (StreamReader reader = new StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();

                legendList = JsonConvert.DeserializeObject<ResponseModel>(jsonString);
            }
            return legendList.Data;

        }
    }
}
