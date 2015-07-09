using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//IMPORTANT:  <Modified the code to add an ArrayList
using System.Collections;

namespace Week5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Automobile[] invintory = new Automobile[5];

            ArrayList invintory = new ArrayList();

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

            Automobile a6 = new Automobile();
            a5.Make = "BMW";
            a5.Model = "743SLi";
            a5.Year = 2012;
            a5.ExteriorColor = "Green";
            a5.Miles = 1234564;

            invintory.Add(a1);
            invintory.Add(a2);
            invintory.Add(a3);
            invintory.Add(a4);
            invintory.Add(a5);

            Console.WriteLine("Inserting a new car:");
            invintory.Insert(3, a6);

            Console.WriteLine("Removing car:");
            invintory.RemoveAt(2);

            Console.WriteLine("Removing car:");
            Automobile removeAuto = (Automobile)invintory[0];
            invintory.Remove(removeAuto);

            Console.WriteLine("There are {0} items in the Array.", invintory.Count);
            

            Console.WriteLine("Our current inventory includes:");

            foreach (object item in invintory)
            {
                Automobile auto = (Automobile)item;
                auto.Print();
            }

            //for (int i = 0; i < invintory.Length; i++)
            //{
            //    invintory[i].Print();
            //}


            Console.WriteLine("");
            Console.WriteLine("We have a special promotion on this vehical: ");
            Automobile promoAuto =  (Automobile)invintory[2];
            promoAuto.Print();




            Console.ReadLine();
        }

    }
}
