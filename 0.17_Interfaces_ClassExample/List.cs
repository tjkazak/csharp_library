using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Interfaces_ClassExample
{
    class ListClass : IEnum, IList, ICollect
    {
        public void AddStuff()
        {
            Console.WriteLine("Add stuff to list");
        }

        public void CheckTheCapacity()
        {
            Console.WriteLine("Checking capacity of list");
        }

        public void CheckTheCount()
        {
            Console.WriteLine("Checking count of list");
        }

        public void IterateOverCollection()
        {
            Console.WriteLine("Iterating over the list");
        }

        public void RemoveStuff()
        {
            Console.WriteLine("Removing from the list");
        }
    }
}
