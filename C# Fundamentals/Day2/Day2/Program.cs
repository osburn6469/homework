using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            string y = "Bob";
            string myFirstTry = x.ToString() + y;
            /* You can't cast a string of variables to a int
            int mySecondTry = x + y;
            */
            Console.WriteLine(myFirstTry);


            Console.WriteLine("Would you like option 1, 2, or 3?");
            int userValue = Console.Read();

            if (userValue == 1)
            {
                Console.WriteLine("You won a new car!!");
                Console.Read();
            }
            else if(userValue == 2)
            {
                Console.WriteLine("You won a new boat!!");
                Console.Read();
            }
            else if (userValue == 3)
            {
                Console.WriteLine("You won a new house!!");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Not a valid option");
                Console.Read();
            }




        }
    }
}
