using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Methods_Overloading
{
    class Player
    {
        //Create Player class with 
        //1 Attack method that accepts 3 different sets of parameters
        //for ex:
        //Attack(100) --> Attacked for 100!
        //Attack(100, "Weapon") --> Attacked with Weapon for 100
        //Attack(100, "Weapon", #times) --> Attacked with weapon for 100 #ofTimes, dealing totalDamage.


        public void Attack(int damage)
        {
            Console.WriteLine($"Attack for {damage}.");
        }

        public void Attack(int damage, string weapon)
        {
            Console.WriteLine($"Attacked with {weapon} for {damage}.");
        }

        public void Attack(int damage, string weapon, int numOfTimes)
        {
            //int totalDamage = damage * numOfTimes;
            //Console.WriteLine($"Attacked with {weapon} for {damage} {numOfTimes} times, dealing {totalDamage}.");
            Console.WriteLine($"Attacked with {weapon} for {damage} {numOfTimes} times, dealing {damage*numOfTimes}.");
        }

        //Using return example
        public int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}
