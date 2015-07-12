using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_PolyViaInterfaces
{
    static class Print
    {
        public static void ToConsole(IPrintable printableObjects)
        {
            printableObjects.Print();
        }
    }
}
