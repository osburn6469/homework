using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {

            Auto myCar = new Auto();

            myCar.Speed = 0;
            myCar.Make = "Oldsmobile";
            myCar.Model = "Journey";
            myCar.Year = 2010;
            myCar.Color = "Silver";
            myCar.Miles = 50000;

            Console.WriteLine(myCar.Make + " " + myCar.Model);
            myCar.Acc();
            myCar.Acc();
            myCar.Acc();
            myCar.Acc();
            myCar.Decelerate();


            Console.WriteLine("My Current Speed: " + myCar.Speed);


            Auto myCar2 = new Auto();

            myCar2.Speed = 5;
            myCar2.Make = "Dodge";
            myCar2.Model = "Caravan";
            myCar2.Year = 2012;
            myCar2.Color = "Green";
            myCar2.Miles = 1000;

            Console.WriteLine("I have two types of cars :{0}   {1}", myCar.Model, myCar2.Model);

            Console.ReadLine();
        }
    }
}
