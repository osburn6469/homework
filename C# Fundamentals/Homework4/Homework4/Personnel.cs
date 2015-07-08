using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Personnell : Asset
    {
        public string Department { get; set; }
        public string Supervisor { get; set; }

        public Personnell(string codeName, string region, string skillSet, string department, string supervisor)
        {
            CodeName = codeName;
            Region = region;
            SkillSet = skillSet;
            Department = department;
            Supervisor = supervisor;
        }
    }
}
