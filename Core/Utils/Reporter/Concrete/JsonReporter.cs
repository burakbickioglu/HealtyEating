using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Core.Utils.Reporter.Abstract;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Core.Utils.Reporter.Concrete
{
    public class JsonReporter : IReporter
    {        
        public void CreateJson(object data, string filePath)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            if(File.Exists(filePath)) File.Delete(filePath);

            StreamWriter sw = new StreamWriter(filePath);
            JsonWriter jsonWriter = new JsonTextWriter(sw);

            jsonSerializer.Serialize(jsonWriter,data);
            jsonWriter.Close();
            sw.Close();
        }
    }
}
