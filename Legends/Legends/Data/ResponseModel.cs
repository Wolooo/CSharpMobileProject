using System;
using System.Collections.Generic;
using System.Text;

namespace Legends.Data
{
    public class ResponseModel
    {
        public string Type { get; set; }
        public string Version { get; set; }
        public Dictionary<string, Legend> Data { get; set; }
    }
}
