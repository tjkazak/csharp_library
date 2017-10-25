using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypes_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1;
            i1 = 32;

            string year = "1976";

            int y = Convert.ToInt32(year);

            string s1;
            s1 = "This is my initialized string!";

            float f1;
            f1 = 3.14f;

            double d1;
            d1 = 3.1234;

            decimal dec1;
            dec1 = 2.56M;

            bool b1;
            b1 = true;

            Console.WriteLine(i1);
            Console.WriteLine(s1);
            Console.WriteLine(f1);
            Console.WriteLine(d1);
            Console.WriteLine(dec1);
            Console.WriteLine(b1);

            Console.WriteLine(s1 + " My age is not " + i1);
            Console.WriteLine("I was born in " + Convert.ToInt32(year));
            Console.WriteLine("I was born in " + y);
            Console.ReadLine();



        }
    }
}
