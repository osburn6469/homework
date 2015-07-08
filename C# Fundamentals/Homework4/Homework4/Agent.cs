using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Agent : Asset
    {
        public void Print()
        {
            //TODO
            Console.WriteLine("{0} ...  {1} ...  {2} ...", CodeName, Region, SkillSet);
        }
    }
}
