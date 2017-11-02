using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOneAnswer
{
    class Triangle : Shape
    {
        //Constructor
        public Triangle(int tbase, int theight)
        {
            this.TBase = tbase;
            this.THeight = theight;
        }

        //Properties
        public int TBase { get; set; }
        public int THeight { get; set; }
        public double TArea { get; set; }

        //Method
        public override double Area()
        {
            this.TArea = this.TBase * this.THeight / 2;
            return this.TArea;
        }
    }
}
