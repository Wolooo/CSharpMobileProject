using System;
using System.Collections.Generic;
using System.Text;

namespace Legends.Data
{
    public class Legend
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public string UrlToString()
        {
            return Name;
        }
    }
}
