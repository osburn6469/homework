using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnell p = new Personnell("Bob", "USA", "Assassan", "IT", "Killer Woman");
            Analyzer.Analyze(p);

            Agent a = new Agent();
            a.CodeName = "007";
            a.Region = "Africa";
            a.SkillSet = "killer";
            Analyzer.Analyze(a);

            Console.ReadLine();
        }
    }
}
