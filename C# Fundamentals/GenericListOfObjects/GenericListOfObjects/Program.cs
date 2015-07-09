using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> invintory = new List<Product>(); //Create a list of any type

            Automobile a1 = new Automobile();
            a1.Make = "Dodge";
            a1.Model = "Journy";
            a1.Year = 2010;
            a1.ExteriorColor = "Gray";
            a1.Miles = 12300;


            Automobile a2 = new Automobile();
            a2.Make = "Oldsmobile";
            a2.Model = "Cutlas Surpreme";
            a2.Year = 1975;
            a2.ExteriorColor = "Blue";
            a2.Miles = 123432;



            Automobile a3 = new Automobile();
            a3.Make = "Geo";
            a3.Model = "Prism";
            a3.Year = 2012;
            a3.ExteriorColor = "White";
            a3.Miles = 1232342;


            Automobile a4 = new Automobile();
            a4.Make = "Nissan";
            a4.Model = "Altama";
            a4.Year = 2000;
            a4.ExteriorColor = "Green";
            a4.Miles = 123532;


            Automobile a5 = new Automobile();
            a5.Make = "BMW";
            a5.Model = "745SLi";
            a5.Year = 2012;
            a5.ExteriorColor = "Pink";
            a5.Miles = 1234564;

            invintory.Add(a1);
            invintory.Add(a2);
            invintory.Add(a3);
            invintory.Add(a4);
            invintory.Add(a5);

            Book b1 = new Book();
            b1.ProductID = 3;
            b1.Title = "Mike Gets Married";
            b1.Author = "Mike Cerv.";
            b1.ISBN = "0-13213=321-123";

            invintory.Add(b1);

            foreach (Product item in invintory)
            {
               
                item.Print();
            }

            Console.WriteLine("We have a special promotion on this vehical: ");
            
            invintory[0].Print();


            

            Console.ReadLine();
        }
    }
}
