using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_03_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Agency CIA = new Agency();
            CIA.AgencyName = "CIA";
            CIA.Country = "USA";
            CIA.OrginizationSize = 10000;

            Spy newSpy = new Spy();
            newSpy.CodeName = "Charly";
            newSpy.DateLastSeen = DateTime.Now;
            newSpy.Notes = "The insect";
            newSpy.SpyAgency = CIA;


            newSpy.DisplaySpyInfo();

            Console.ReadLine();

        }
    }
}
