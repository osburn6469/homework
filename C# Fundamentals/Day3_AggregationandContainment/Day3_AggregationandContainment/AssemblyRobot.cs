using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_AggregationandContainment
{

    class AssemblyRobot
    {

        public string  Name { get; set; }


        public static Auto AssembleCar(string model, Engine enginType)
        {
            Auto newCar = new Auto();
            newCar.Model = model;
            newCar.Engine = enginType;
            return newCar;
        }
    }
}
