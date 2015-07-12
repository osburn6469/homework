using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_PolyViaInterfaces
{
    class Auto : IPrintable, IProduct
    {
        #region Public Properties

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Miles { get; set; }
        public string ExteriorColor { get; set; }


        #endregion

        public void Print()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t with  {3}    exterior (Odomiter: {4})", Year, Make, Model, ExteriorColor, Miles);
        }

        public void GetStorageLocation()
        {
            Console.WriteLine("The {0}  {1}  {2} is stored in warehouse A", Year, Make, Model);
        }
    }
}
