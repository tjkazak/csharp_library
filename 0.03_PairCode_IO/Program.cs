using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_PairCode_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number 1-100");

            String input1 = Console.ReadLine();
            int i = Convert.ToInt32(input1);

            if(i <= 50)
            {
                Console.WriteLine("You like small numbers.");
            }
            else if(i >= 50 && i < 101)
            {
                Console.WriteLine("You like the larger numbers.");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            //            Console.WriteLine("How are you feeling today, from 1-5?");
 //           String input1 = Console.ReadLine();

            //            switch (input1){
            // case "1":
            // Console.WriteLine("A 1? What's the story morning glory?");
            //    break;
            //case "2":
            //    Console.WriteLine("A 2? No Coffee this morning, huh?");
            //    break;
            //case "3":
            //    Console.WriteLine("A 3, normal day, no better/no worse.");
            //    break;
            //case "4":
            //    Console.WriteLine("A 4? Alright, today's looking good!");
            //    break;
            //case "5":
            //    Console.WriteLine("A 5? Like Ice Cube said, 'Today was a good day!'");
            //    break;
            //default:
            //    Console.WriteLine("Don't care to follow the directions huh... must be a bad day!");
            //        break;
            //}
        }
    }
}
