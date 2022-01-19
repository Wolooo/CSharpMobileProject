﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Legends.Data
{
    public class Legend
    {
        public string Version { get; set; }
        public string Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }

        public string Blurb { get; set; }
        public LegendInfo Info { get; set; }
        public List<string> Tags { get; set; }
        public LegendStats Stats { get; set; }
    }
}