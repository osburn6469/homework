using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_AggregationandContainment
{
    class truck : Auto
    {
        public int TowingCapacity;
        public int CargoCCapcity;

        public void Tow()
        {
            Console.WriteLine("Now Towing...");
        }

        public void Haul()
        {
            Console.WriteLine("Now Hauling...");
        }

        public override void Start()
        {
            base.Start(); // Access the Start from the Auto Class
            Console.WriteLine("Starting Truck...");
        }
    }
}
