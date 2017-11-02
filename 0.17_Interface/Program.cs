using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is ODD");

            IFive obj1 = new OddEven();

            obj1.ONE();
            obj1.THREE();
            obj1.FIVE();

            Console.WriteLine("\n\nThis is EVEN");

            IEVEN obj2 = new OddEven();

            obj2.TWO();
            obj2.FOUR();
            Console.ReadLine();

        }
    }
}
