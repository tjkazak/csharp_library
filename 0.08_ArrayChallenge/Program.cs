using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_ArrayChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze
            string[] favFoods = new string[3] { "cheeseburger", "tacos", "spaghetti" };

            foreach (string food in favFoods)
            {
                Console.WriteLine(food);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(favFoods[i]);
                //Console.ReadLine();

            }

            //Silver
            int[] num1 = new int[5] {2,4,6,8,10 };
            int[] num2 = new int[5] {1,3,5,7,9 };
            int[] num3 = new int[5];

            //            int[] total = new int[5];
            //            total[0] = num1[0];

//            for (int i = 0; i < num3.Length; i++)
//            {
//                num3[i] += num1[i] + num2[i];
////                Console.WriteLine(num3[i]);
//            }

//            // using a foreach loop to display the array
//            foreach (int number in num3)
//            {
//                Console.WriteLine(num3);
//            }

            //Gold - create an array of 10 random numbers
            int[] randomNumbers = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rnd.Next(100);
            }

            foreach (int number in randomNumbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
