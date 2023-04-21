using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool hasFeathers { get; set; } = true;
        public bool canFly { get; set; }
        public bool doesMigrate { get; set; }
        public bool eatsSeeds { get; set; }
    }
}
