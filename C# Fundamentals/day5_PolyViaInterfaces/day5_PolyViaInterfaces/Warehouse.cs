using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_PolyViaInterfaces
{
    class Warehouse
    {
        private Queue<IProduct> inventory { get; set; }

        public Warehouse()
        {
            inventory = new Queue<IProduct>();
        }

        public IProduct GetOldestItem()
        {
            IProduct newestItem = inventory.First();
            return newestItem;
        }

        public IProduct GetNewestItem()
        {
            IProduct newestItem = inventory.Last();
            return newestItem;
        }
        public void Add(IProduct productToAdd)
        {
            inventory.Enqueue(productToAdd);
        }
    }
}
