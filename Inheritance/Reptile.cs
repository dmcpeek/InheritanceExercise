using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool hasScales { get; set; } = true;
        public bool isVenomous { get; set; }
        public bool hasForkedTongue { get; set; } = true;
        public bool isArboreal { get; set; }
    }
}
