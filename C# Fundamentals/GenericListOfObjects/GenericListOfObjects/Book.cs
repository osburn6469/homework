using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListOfObjects
{
    class Book : Product
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string  ISBN  { get; set; }

        public override void Print()
        {
            // base.Print();  Don't need if you use the Abstract Cases
            Console.WriteLine("\"{0}\", {1}, (ISBN: {2})", Title, Author, ISBN);
        }
    }
}
