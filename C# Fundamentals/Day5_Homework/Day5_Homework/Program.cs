using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mutant> mutants = new List<Mutant>();

            PsychicMutant ps1 = new PsychicMutant();
            ps1.CodeName = "MindBender";
            ps1.IQ = 100;
            ps1.Level = 3;
            ps1.PowerUsageCount = 2;
            mutants.Add(ps1);

            PsychicMutant ps2 = new PsychicMutant();
            ps2.CodeName = "Svenghali";
            ps2.IQ = 120;
            ps2.Level = 4;
            ps2.PowerUsageCount = 1;
            mutants.Add(ps2);

            PhysicalMutant ph1 = new PhysicalMutant();
            ph1.CodeName = "StrongMan";
            ph1.IQ = 80;
            ph1.Level = 2;
            ph1.Strength = 30;
            mutants.Add(ph1);

            PhysicalMutant ph2 = new PhysicalMutant();
            ph2.CodeName = "FireDude";
            ph2.IQ = 100;
            ph2.Level = 3;
            ph2.Strength = 30;
            mutants.Add(ph2);

            ElementalMutant em1 = new ElementalMutant();
            em1.CodeName = "Biggy";
            em1.Level = 4;
            em1.Region = 7;
            mutants.Add(em1);

            ElementalMutant em2 = new ElementalMutant();
            em2.CodeName = "RainGirl";
            em2.Level = 5;
            em2.Region = 6;
            mutants.Add(em2);

            foreach (Mutant mutant in mutants)
            {
                mutant.DisplayInfo();
            }

            Console.ReadLine();
        }
    }
}
