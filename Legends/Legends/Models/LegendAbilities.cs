using System;
using System.Collections.Generic;
using System.Text;

namespace Legends.Models
{
    public class LegendAbilities
    {
        //Prop Class QSpell
        public LegendQSpell QSpell { get; set; }
        //Prop Class WSpell
        public LegendWSpell WSpell { get; set; }
        //Prop Class ESpell
        public LegendESpell ESpell { get; set; }
        //Prop Class RSpell
        public LegendRSpell RSpell { get; set; }
        //Prop Class PassiveSpell
        public LegendPassiveSpell PSpell { get; set; }
    }
}
