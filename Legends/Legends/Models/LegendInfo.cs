using System;
using System.Collections.Generic;
using System.Text;

namespace Legends.Data
{
    public class LegendInfo
    {
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Magic { get; set; }
        public int Difficulty { get; set; }
        public string InfoToString()
        {
            return $"Attack: {Attack}\nDefense: {Defense}\nMagic: {Magic}\nDifficulty: {Difficulty}";
        }
    }
}
