using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    class Auto
    {
        public string Make;
        public string Model;
        public int Year;
        public string Color;
        public int Miles;
        public int Speed;

        public void Acc()
        {
            Speed++;
            Console.WriteLine("Current Seed: " + Speed.ToString());
        }

        public void Decelerate()
        {
            Speed--;
            Console.WriteLine("Current speed: " + Speed.ToString());
        }
    }
}
