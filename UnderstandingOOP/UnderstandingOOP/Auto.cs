using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOP
{
    class Auto
    {
        public string Make;
        public string Model;
        public int Year;
        public string Color;
        public int Miles;
        public int Speed;

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
            Speed+= increasedSpeed;
            Console.WriteLine("Current speed: " + Speed.ToString());
            return Speed;
        }

        public int DeccelerateInt(int decreasedSpeed)
        {
            Speed-= decreasedSpeed;
            Console.WriteLine("Current speed: " + Speed.ToString());
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

    }
}
