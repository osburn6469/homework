using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_PolyViaInterfaces
{
    class Toys : IPrintable, IProduct
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public void Print()
        {
            Console.WriteLine("{0} {1}   (Type: {2}", Manufacturer, Name, Type);
        }

        public void GetStorageLocation()
        {
            Console.WriteLine("{0}  toy is stored in warehouse C", Name);
        }
    }
}
