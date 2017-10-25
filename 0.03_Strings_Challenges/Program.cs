using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Strings_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze
            string primes;
            primes = String.Format("Prime numbers less than 10: {0}, {1}, {2}, {3}", 2, 3, 5, 7);
            Console.WriteLine(primes);

            //currency
            double cash = 123.45;
            Console.WriteLine("{0:C}", cash);

            //pnone number
            uint phone = 2247301976;
 //           int phone = 1234567890;
            //phone = string.Format("{0:###-###-####"},);
            Console.WriteLine("{0:###-###-####}",phone);

            int value = 6324;
            //escaping braces
            string output = string.Format("{0}{1:D}{2}", "{", value, "}");
            Console.WriteLine(output);

            string FormatString1 = String.Format("{0:dddd MMMM}", DateTime.Now);
            string FormatString2 = DateTime.Now.ToString("dddd MMMM");
            Console.WriteLine(FormatString1);
            Console.WriteLine(FormatString2);

            //Silver
            string empName = "Mr. Jones";
            string FormatString3 = String.Format("{0:MM/dd/yy}", DateTime.Now);
            Console.WriteLine($"Dear {empName}, Today is {FormatString3}. I'm enjoying class, and I think I like C# the best. I'd like to get a job as a developer after I finish this course.");

            //Gold
            string uName = "TOM KAZAK";
            string lName = "tom kazak";

            Console.WriteLine("The Strings are equal when case is ignored? {0}",
                              String.Compare(uName, lName, true) == 0 ? "true" : "false");

            Console.WriteLine("The Strings are equal when case is compared? {0}",
                              String.Compare(uName, lName, false) == 0 ? "true" : "false");

            if (uName == lName)
            {
                Console.WriteLine("The strings are equal.");
            }
            else
            {
                Console.WriteLine("The strings are not equal.");
            }

            Console.ReadLine();

        }
    }
}
