using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle newTriangle = new Triangle();

            newTriangle.TBase = 4;
            newTriangle.THeight = 3;

            Console.WriteLine($"Area = {newTriangle.Area()}.");

        }
    }
}
