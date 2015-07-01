using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Day2_Homework_Assignmnet
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            char[] convert;
            StreamReader myReader = new StreamReader("decodethis.txt");
            StreamWriter myWriter = new StreamWriter("writenToFile.txt");

            while((line = myReader.ReadLine()) != null)
            {
                convert = line.ToCharArray();
                Array.Reverse(convert);
                string revChr = new string(convert);
                Console.WriteLine(revChr);
                myWriter.Write(revChr);
            }
            myWriter.Close();
            myReader.Close();
            Console.ReadLine();
        }
    }
}
