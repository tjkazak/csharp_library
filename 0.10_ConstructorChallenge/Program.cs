using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ConstructorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze
            MobilePhone tomsPhone = new MobilePhone("IPhone", "6");
            MobilePhone karenPhone = new MobilePhone("IPhone", "7");
            MobilePhone jaxPhone = new MobilePhone("Motorola", "Flip Phone");
            MobilePhone laylaPhone = new MobilePhone("Blackberry", "850");
            MobilePhone chrisPhone = new MobilePhone("Samsung", "Galaxy");

            Console.WriteLine($"I own an {tomsPhone.Make} {tomsPhone.Model}.");

            //Using Method = more DRY
            tomsPhone.PrintPhone();
            karenPhone.PrintPhone();

            //Silver
 
        }
    }
}
