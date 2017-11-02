using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOneAnswer
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triOne = new Triangle(2, 3);
            Triangle triTwo = new Triangle(4, 3);
            Triangle triThree = new Triangle(6, 3);
            Triangle triFour = new Triangle(8, 3);
            Triangle triFive = new Triangle(10, 3);

            triOne.Area();
            triTwo.Area();
            triThree.Area();
            triFour.Area();
            triFive.Area();

        }
    }
}
