using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_AggregationandContainment
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine v4 = new Engine();
            v4.Size = "v4";
            v4.HoresPower = 200;
            v4.FuleConsumptionRate = 1.6;

            Engine v6 = new Engine();
            v6.Size = "v6";
            v6.HoresPower = 350;
            v6.FuleConsumptionRate = 2.6;

            Engine v8 = new Engine();
            v4.Size = "v8";
            v8.HoresPower = 500;
            v8.FuleConsumptionRate = 3.7;


            Auto myCar = new Auto();
            myCar.Engine = v6;

            Console.WriteLine(myCar.Engine.HoresPower.ToString());
            Console.ReadLine();

            AssemblyRobot robot = new AssemblyRobot();
            myCar = robot.AssembleCar("74SLi", v8);

            Console.WriteLine(myCar.Engine.HoresPower.ToString());
            Console.ReadLine();

            myCar.Customer.LastName = "Tabor";
            myCar.Customer.Address = "123 E. Main St.";
            myCar.Customer.DateOfPurchase = DateTime.Now;

            Console.WriteLine("Owned by: " + myCar.Customer.LastName);
            Console.ReadLine();
        }
    }
}
