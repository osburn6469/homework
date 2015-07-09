using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListOfObjects
{
    abstract class Product  //abstract key word doesnt define the implementation of the method Print()
    {
        public int ProductID { get; set; }

        public abstract void Print();

        //public virtual void Print()
        //{
        //    Console.WriteLine("ID:  {0}  ... ", ProductID);
        //}
    }
}
