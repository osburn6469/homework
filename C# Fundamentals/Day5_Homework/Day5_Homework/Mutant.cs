using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Homework
{
    abstract class Mutant: IDisplayable
    {
        public string CodeName { get; set; }
        public int Level { get; set; }

        public abstract int DangerQuotient();
        
        public void DisplayInfo()
        {
            Console.WriteLine(CodeName + "-  DQ: " + DangerQuotient().ToString());
        }
    }
}
