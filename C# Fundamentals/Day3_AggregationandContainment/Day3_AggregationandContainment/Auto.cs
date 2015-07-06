using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_AggregationandContainment
{
    class Auto
    {
        private string make;
        public string Model;
        public int Year;
        public string Color;
        public int Miles;
        private int speed;
        public Engine Engine;

        public AutoCustomer Customer = new AutoCustomer();

        public class AutoCustomer
        {
            public string LastName;
            public string Address;
            public DateTime DateOfPurchase;
        }

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 0)
                {
                    speed = 0;
                }
                else if (value > 110)
                {
                    speed = 110;
                }
                else
                {
                    speed = value;
                }
            }
        }

        public string Make
        {
            get { return make; }
            set
            {
                switch (value)
                {
                    case "Toyota":
                        make = value;
                        break;
                    case "Oldsmobile":
                        make = value;
                        break;
                    default:
                        throw new Exception("Not a valid Maker");
                }
            }
        }

        public void Accelerate()
        {
            Speed++;
            Console.WriteLine("Current speed: " + Speed.ToString());
        }

        public void Deccelerate()
        {
            Speed--;
            Console.WriteLine("Current speed: " + Speed.ToString());
        }


        public int AccelerateInt(int increasedSpeed)
        {
            Speed += increasedSpeed;
            Console.WriteLine("Current speed: " + Speed.ToString());
            return Speed;
        }

        public int DeccelerateInt(int decreasedSpeed)
        {
            Speed -= decreasedSpeed;
            //created a private method for encapsalation
            //Console.WriteLine("Current speed: " + Speed.ToString());
            writeLine("Current speed: " + Speed.ToString());
            return Speed;
        }
        public string SpeedLimitViolation(string initialMessage, int speedLimit)
        {
            string message = null;
            if (Speed < speedLimit)
            {
                message = "";
            }
            else
            {
                message = "You are going to FAST!!!!";
            }
            return initialMessage + " " + message;
        }

        private void writeLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
