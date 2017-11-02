using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOne
{
    class Triangle : Shape
    {
        //Constructor
        public Triangle()
            {
            }

        public int TBase { get; set; }
        public int THeight { get; set; }

 
        public override double Area()
        {

            return (TBase * THeight) / 2;
        }

    }
}
