using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_PolyViaInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPrintable> invintory = new List<IPrintable>(); //Create a list of any type

            Auto a1 = new Auto();
            a1.Make = "Dodge";
            a1.Model = "Journy";
            a1.Year = 2010;
            a1.ExteriorColor = "Gray";
            a1.Miles = 12300;

            

            Book b1 = new Book();
            b1.Title = "Mike Gets Married";
            b1.Author = "Mike Cerv.";
            b1.ISBN = "0-13213=321-123";

            invintory.Add(a1);
            invintory.Add(b1);

            foreach (var item in invintory)
            {

                //item.Print();
                Print.ToConsole(item);
            }

            Console.WriteLine("We have a special promotion on this vehical: ");

            invintory[0].Print();

            // PART 2

            Console.WriteLine("");
            Console.WriteLine("Where is our oldest product located?");

            Warehouse myWarehouse = new Warehouse();

            myWarehouse.Add(a1);
            myWarehouse.Add(b1);

            var myOldestProduct = myWarehouse.GetOldestItem();
            myOldestProduct.GetStorageLocation();


            // PART 3
            Console.WriteLine("");
            Console.WriteLine("Adding...");
            Toys newToy = new Toys() { Manufacturer = "Kenner", Name = "Luck Skywalker", Type = "Action Figure" };
            Print.ToConsole(newToy);

            Console.WriteLine("");
            Console.WriteLine("Where is our newest product located?");
            myWarehouse.Add(newToy);
            var myNewestProduct = myWarehouse.GetNewestItem();
            myNewestProduct.GetStorageLocation();



            Console.ReadLine();
        }
    }
}
