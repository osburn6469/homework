using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Homework
{
    class ElementalMutant : Mutant
    {
        public int Region { get; set; }

        public override int DangerQuotient()
        {
            return Level * Region;

        }
    }
}
