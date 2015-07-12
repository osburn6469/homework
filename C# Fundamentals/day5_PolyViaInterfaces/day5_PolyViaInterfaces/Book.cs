using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_PolyViaInterfaces
{
    class Book :IPrintable, IProduct
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public void Print()
        {
            // base.Print();  Don't need if you use the Abstract Cases
            Console.WriteLine("\"{0}\", {1}, (ISBN: {2})", Title, Author, ISBN);
        }

        public void GetStorageLocation()
        {
            Console.WriteLine("The title \"{0}\" is stored in Warehouse B", Title);
        }
    }
}
