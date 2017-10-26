using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> dict = new Dictionary<int, string>();
            //dict.Add(2000, "American Beauty");
            //dict.Add(2001, "Gladiator");
            //dict.Add(2002, "Beautiful Mind");
            //dict.Add(2003, "Chicago");
            //dict.Add(2004, "LOTR");
            //dict.Add(2005, "Million Dollar Baby");

            //foreach (var winners in dict)
            //{
            //    Console.WriteLine("The winner was {1}, in {0}.", winners.Key, winners.Value);
            //}


            //Gold - shows collection within a collection
            Dictionary<string, string[]> dict = new Dictionary<string, string[]>()
            {
                {"2000", new string[] {"happy feet","cars","monster house"}},
                {"2001", new string[] {"ratatou","persepolis","surfs up"}},
                {"2002", new string[] {"wall e","bolt","kunfg fu panda"}},
            };

            foreach (var nominee in dict)
            {
                Console.WriteLine($"Nominees for {nominee.Key}: {nominee.Value[0]}, {nominee.Value[1]}, {nominee.Value[2]}");
            }
        //            Console.WriteLine();

    }
    }
}
