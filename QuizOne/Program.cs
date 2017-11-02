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

            //Part Two
            IEnumerable<Triangle> triangles = new List<Triangle>()
            {
                //Objects
                new Triangle {TBase = 2, THeight = 3},
                new Triangle {TBase = 4, THeight = 3},
                new Triangle {TBase = 6, THeight = 3},
                new Triangle {TBase = 8, THeight = 3}

            };

            //Set up the query
            IEnumerable<Triangle> query = from t in triangles
                                   where t.TArea > 5
                                   orderby t.TArea ascending
                                   select t;

            foreach (Triangle triangle in query)
            {
                Console.WriteLine(triangle.TArea);

            }



        }
    }
}
