using System;
using System.Collections.Generic;
using System.Text;

namespace Legends.Models
{
    public class LegendInfo
    {
        public double Attack { get; set; }
        public double Defense { get; set; }
        public double Magic { get; set; }
        public double Difficulty { get; set; }
        public string InfoToString()
        {
            return $"Attack: {Attack}\nDefense: {Defense}\nMagic: {Magic}\nDifficulty: {Difficulty}";
        }
    }
}
