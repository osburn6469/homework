using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Week5
{
    class Automobile
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Miles { get; set; }
        public string ExteriorColor { get; set; }

        public void Print()
        {
            Console.WriteLine("{0}    {1}    {2}   with  {3}    exterior (Odomiter: {4})", Year, Make, Model, ExteriorColor, Miles);
        }
    }
}
