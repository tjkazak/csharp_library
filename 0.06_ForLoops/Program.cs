using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0; i <= 10; i += 2)
            //{
            //    //               Console.WriteLine(i);
            //    if (i == 6) Console.WriteLine("Launch!");
            //    else Console.WriteLine(i);

            //    //   Console.ReadLine();
            //}

            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i <= 100; i += 5)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i < 100; i++)
            //{
            //    Console.WriteLine(
            //        i % 15 == 0 ? "Fizzbuzz";
            //        i % 5 == 0 ? "Buzz";
            //        i % 3 == 0 ? "Fizz";
            //        i.ToString())
            //}

            //for (int i = 0; i <= 100; i++)
            //{
            //    //               Console.WriteLine(i);

            // 
            //    if (i % 15 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }

            //    //   Console.ReadLine();
            //}

            //Fibonacci sequence

            int num1 = 1;
            int num2 = 2;
            int temp;
            int total = 2;

            while (num2 <= 4000000)
            {
                temp = num1 + num2;
                    if(temp % 2 == 0)
                    {
                        total += temp;
                    }
                num1 = num2;
                num2 = temp;
            }
            Console.WriteLine(total);
        }
    }
}
