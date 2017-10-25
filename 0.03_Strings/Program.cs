using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string occupation;

            firstName = "Tyler";
            lastName = "Durden";
            occupation = "CEO, Fight Club Inc.";

            string fullName = firstName + " " + lastName + " " + occupation;
            Console.WriteLine(fullName);

            Console.WriteLine("Hello, my name is " + firstName + " " + lastName + " my occupation is: " + occupation + ".");
            //String Interpolation - putting stuff inside of stuff
            Console.WriteLine("Hello, my name is {0} {1}. My occupation is: {2}.", firstName, lastName, occupation);
            //$ = anything inside brackets is interpolated
            Console.WriteLine($"Hello, my name is {firstName} {lastName}. My occuption is {occupation}.");

            Console.ReadLine();

        }
    }
}
