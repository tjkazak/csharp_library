using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 15;
            int number2 = 5;
            int number3 = 10;

            byte myByte = 255; //range: 0 - 255

            float myFloat = 3.14f;           //the f at the end is used to define explicit - 
            decimal myDecimal = 3.14159M;    //128 bit
            double myDouble = 2.54;          //64 bit

            char myLetter = 'A';// single quote for char double for string
            string myName = "Tom";

            bool myTruth = true; // True=1 / False=1

            //Console.WriteLine(myName);
            //Console.ReadLine(); 

            //Declaration
            // <type> <variablename> = <optional initializer>;
            int age;
            string country;
            // Initialization
            age = 41;
            Console.WriteLine(age);
            age = 42;
            Console.WriteLine(age);
            Console.ReadLine();
            

        }
    }
}
