using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Homework_Assignmnet
{
    class Program
    {
        static void Main(string[] args)
        {
            String fused = "12 23 34 45";
            Console.WriteLine("Please enter the sequence to stop the timer: ");
            string userinput = Console.ReadLine();

            if (userinput==fused)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You saved the world!!!");
                Console.ResetColor();
            }
            else
            {
                Console.Beep(5000, 1000);
                Console.WriteLine("FAILURE!!!");
            }
        }
    }
}
