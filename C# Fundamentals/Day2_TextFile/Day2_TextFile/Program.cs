using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day2_TextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader myReader = new StreamReader("ListOfNumbers.txt");

            string line = "";

            while(line != null)
            {
                line = myReader.ReadLine();

                if (line != null)
                {
                     Console.WriteLine(line);
                }
               
            }
            myReader.Close();
            Console.ReadLine();
        }
    }
}
