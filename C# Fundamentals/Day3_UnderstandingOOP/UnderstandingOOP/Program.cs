using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Auto myCar = new Auto();

            myCar.Speed = 0;
            myCar.Make = "Dodge";
            myCar.Model = "Journey";
            myCar.Year = 2010;
            myCar.Color = "Silver"; 
            myCar.Miles = 50000;

            Console.WriteLine(myCar.Make + " " + myCar.Model);
            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Deccelerate();

            myCar.AccelerateInt(5);
            myCar.AccelerateInt(2);
            myCar.AccelerateInt(1);
            myCar.AccelerateInt(3);
            myCar.DeccelerateInt(6);

            string message = myCar.SpeedLimitViolation("Warning: ", 20);
            Console.WriteLine("My current speed: " + myCar.Speed);
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
