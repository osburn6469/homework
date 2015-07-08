using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Asset
    {
        public string CodeName { get; set; }
        public string Region { get; set; }
        public string SkillSet { get; set; }
        public virtual void Print()
        {
            Console.WriteLine("{0}   {1}   {2}", CodeName, Region, SkillSet);
        }
    }
}
