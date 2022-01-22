using System;
using System.Collections.Generic;
using System.Text;

namespace Legends.Models
{
    public class Legend
    {
        public string Version { get; set; }
        public string Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Lane { get; set; }

        public string Lore { get; set; }
        public LegendInfo Info { get; set; }
        public string Tags { get; set; }
        public LegendStats Stats { get; set; }
    }
}
