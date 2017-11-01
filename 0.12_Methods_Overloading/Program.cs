using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Methods_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Player class with 
            //1 Attack method that accepts 3 different sets of parameters
            //for ex:
            //Attack(100) --> Attacked for 100!
            //Attack(100, "Weapon") --> Attacked with Weapon for 100
            //Attack(100, "Weapon", #times) --> Attacked with weapon for 100 #ofTimes, dealing totalDamage.

            //Object Instantiation 
            Player playerTom = new Player();

            //Calling the overloaded Method - Object.Method(variable(s))
            playerTom.Attack(2500);
            playerTom.Attack(2500, "Gatlin Gun");
            playerTom.Attack(2500, "Axe", 3);

            //Using returns
            int num1 = 3;
            int num2 = 5;

            int product = num1 * num2;
            int product2 = playerTom.Multiply(num1, num2);
            
        }
    }
}
