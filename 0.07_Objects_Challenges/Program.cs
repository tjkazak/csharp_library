using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Objects_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze 
            Netflix account1 = new Netflix();
            Netflix account2 = new Netflix();
            Netflix account3 = new Netflix();

            account1.Name = "Tom";
            account1.Genre = "Horror";
            account1.Rating = 7;

            account2.Name = "Karen";
            account2.Genre = "Rom-Com";
            account2.Rating = 2;

            account3.Name = "Misc";
            account3.Genre = "Animation";
            account3.Rating = 10;
            
            Console.WriteLine(account1);
            Console.WriteLine(account1.Name);
        }
    }
}
