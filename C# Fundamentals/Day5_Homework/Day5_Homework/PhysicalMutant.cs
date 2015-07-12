using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Homework
{
    class PhysicalMutant : Mutant
    {
        public int IQ { get; set; }
        public int Strength { get; set; }

        public override int DangerQuotient()
        {
            return Level * IQ * Strength;

        }
    }
}
